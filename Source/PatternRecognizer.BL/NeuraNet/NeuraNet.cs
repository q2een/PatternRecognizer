using System;
using System.Collections.Generic;
using System.Linq;
using NeuraNet;
using NeuraNet.Cost;
using PatternRecognizer.BL.Network;

namespace PatternRecognizer.BL.NeuraNet
{
    public class NeuraNet : INeuralNetwork
    {

        internal NeuralNetwork Network { get; private set; }

        #region Конструкторы.

        public NeuraNet()
        {

        }

        internal NeuraNet(NeuralNetwork network)
        {
            this.Network = network;
            Network.ExampleTrained += Network_ExampleTrained;
        }

        #endregion

        #region INeuralNetwork

        public IEnumerable<string> Activations => new string[] { "Sigmoid", "Tanh", "ReLU", "Softplus" };

        private IEnumerable<LayerConfiguration> configs;

        public IEnumerable<LayerConfiguration> LayerConfigurations
        {
            get => configs;
            set
            {
                var layoutProvider = new NeuraNetLayout(value.ToArray());

                Network = new NeuralNetwork(layoutProvider, new QuadraticCost());
                Network.ExampleTrained += Network_ExampleTrained;

                configs = value;
            }
        }

        public int FirstLayerNeuronCount => configs.FirstOrDefault()?.NeuronCount ?? -1;

        public int LastLayerNeuronCount => configs.LastOrDefault()?.NeuronCount ?? -1;

        public bool IsNull => Network == null;

        public event EventHandler<EphochTrainedEventArgs> EpochTrained = delegate { };
        public event EventHandler<EphochTrainedEventArgs> BeforeTrainingStart = delegate { };
        public event EventHandler<EphochTrainedEventArgs> OnTrainingEnd = delegate { };

        public double[] GetNetworkOutput(double[] input)
        {
            return Network?.Query(input);
        }

        public double Train(IEnumerable<TrainExample> trainset, int numberOfEpochs, double learningRate, double momentum)
        {
            var samples = trainset.Select(example => new TrainingExample(example.Input, example.ExpectedOutput)).ToArray();

            BeforeTrainingStart(this, new EphochTrainedEventArgs(0, numberOfEpochs, 1));

            return Network.Train(samples, numberOfEpochs, learningRate, momentum);
        }
        
        private void Network_ExampleTrained(object sender, ExampleTrainedEventArgs e)
        {
            if (e.CurrentExample != e.TotalExampleCount)
                return;
                                                 
            EpochTrained(this, new EphochTrainedEventArgs(e.CurrentEpoch, e.TotalEpochCount, e.MeanCost));

            if (e.CurrentEpoch == e.TotalEpochCount)
                OnTrainingEnd(this, new EphochTrainedEventArgs(e.CurrentEpoch, e.TotalEpochCount, e.MeanCost));
        }

        #endregion

    }
}
