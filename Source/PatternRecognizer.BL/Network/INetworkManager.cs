namespace PatternRecognizer.BL.Network
{
    /// <summary>
    /// Предоставляет менеджер для управления получением и сохранением нейронной сети.
    /// </summary>
    public interface INetworkManager
    {
        /// <summary>
        /// Проверяет существует ли объект по указанному пути <paramref name="path"/> и возвращает
        /// результат проверки.
        /// </summary>
        bool IsExist(string path);

        /// <summary>
        /// Получает объект нейронной сети из указанного пути <paramref name="path"/> и возвращает ее.
        /// </summary>
        INeuralNetwork GetNeuralNetwork(string path);

        /// <summary>
        /// Сохраняет нейронную сеть <paramref name="network"/> в путь <paramref name="path"/>.
        /// </summary>
        void SaveNeuralNetwork(INeuralNetwork network, string path);
    }
}
