using System;
using System.Collections.Generic;

namespace PatternRecognizer.BL.Network
{
    /// <summary>
    /// Предоставляет интерфейс нейронной сети.
    /// </summary>
    public interface INeuralNetwork
    {
        /// <summary>
        /// Возвращает коллекцию функций активации, которые реализует нейронная сеть.
        /// </summary>
        IEnumerable<string> Activations { get; }

        /// <summary>
        /// Возвращает или задает структуру нейронной сети.
        /// </summary>
        IEnumerable<LayerConfiguration> LayerConfigurations { get; set; }

        /// <summary>
        /// Возвращает количество нейронов на первом слое нейронной сети.
        /// </summary>
        int FirstLayerNeuronCount { get; }

        /// <summary>
        /// Возвращает количетсво нейронов на последнем слое нейронной сети.
        /// </summary>
        int LastLayerNeuronCount { get; }

        /// <summary>
        /// Происходит при завершении эпохи обучения нейронной сети. 
        /// </summary>
        event EventHandler<EphochTrainedEventArgs> EpochTrained;

        /// <summary>
        /// Происходит перед началом процесса обучения нейронной сети.
        /// </summary>
        event EventHandler<EphochTrainedEventArgs> BeforeTrainingStart;

        /// <summary>
        /// Происходит после заверщения обучения нейронной сети.
        /// </summary>
        event EventHandler<EphochTrainedEventArgs> OnTrainingEnd;

        /// <summary>
        /// Выполняет процесс обучения нейронной сети и возвращает значение ошибки на последней эпохе обучения.
        /// </summary>
        /// <param name="trainset">Коллекция объектов <see cref="TrainExample"/> представляющая обучающую выборку</param>
        /// <param name="numberOfEpochs">Количество эпох обучения</param>
        /// <param name="learningRate">Норма обучения</param>
        /// <param name="momentum">Момент обучения</param>
        double Train(IEnumerable<TrainExample> trainset, int numberOfEpochs, double learningRate, double momentum);

        /// <summary>
        /// Возвращает значения на выходе нейронной сети, при заданных значениях <paramref name="input"/>
        /// на вход нейронной сети.
        /// </summary>
        double[] GetNetworkOutput(double[] input);
    }
}
