namespace PatternRecognizer.BL.Network
{
    /// <summary>
    /// Предоставляет класс содержащий свойства конфигурации слоя нейронной сети.
    /// </summary>
    public class LayerConfiguration
    {
        /// <summary>
        /// Предоставляет класс содержащий свойства конфигурации слоя нейронной сети.
        /// </summary>
        /// <param name="neuronCount">Количество нейронов</param>
        /// <param name="outputActivation">Функция активации слоя</param>
        public LayerConfiguration(int neuronCount, string outputActivationName)
        {
            NeuronCount = neuronCount;
            OutputActivationName = outputActivationName;
        }

        /// <summary>
        /// Возвращает количествао нейронов на слое.
        /// </summary>
        public int NeuronCount { get; }

        /// <summary>
        /// Возвращает функцию активации.
        /// </summary>
        public string OutputActivationName { get; }
    }
}
