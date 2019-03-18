using NeuraNet;
using NeuraNet.Activations;
using NeuraNet.NetworkLayout;
using PatternRecognizer.BL.Network;
using System;
using System.Linq;

namespace PatternRecognizer.BL.NeuraNet
{
    /// <summary>
    /// Предоставляет класс для конфигурации структуры нейронной сети.
    /// </summary>
    internal class NeuraNetLayout : NetworkLayoutProvider
    {
        /// <summary>
        /// Предоставляет класс для конфигурации структуры нейронной сети.
        /// </summary>
        /// <param name="layerConfigurations">Коллекция конфигураций слоя нейронной сети</param>
        public NeuraNetLayout(LayerConfiguration[] layerConfigurations)
        {
            if (layerConfigurations == null)
                throw new ArgumentNullException("layerConfigurations");

            if (layerConfigurations.Length < 2)
                throw new ArgumentException("Минимальное количество слоев в нейронной сети должно быть равно двум", "layerConfigurations");

            var initializer = new RandomLayerInitializer();

            layers = Enumerable.Range(1, layerConfigurations.Length-1).Select(index =>
            {
                var activation = GetActivationByName(layerConfigurations[index].OutputActivationName);
                return new Layer(layerConfigurations[index - 1].NeuronCount, layerConfigurations[index].NeuronCount, initializer, activation);
            }).ToList();

            ConnectLayers();
        }

        // Возвращает объект функции активации в зависимости от ее наименования.
        private static IActivation GetActivationByName(string activationName)
        {
            switch (activationName)
            {
                case "Sigmoid":
                    return new SigmoidActivation();

                case "Tanh":
                    return new HyperbolicTangentActivation();

                case "ReLU":
                    return new RectifiedLinearUnitActivation();

                case "Softplus":
                    return new SoftplusActivation();

                default:
                    throw new ArgumentException($"{activationName} не является функцией активации");
            }
        }
    }
}

