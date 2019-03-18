namespace PatternRecognizer.BL.Network
{
    /// <summary>
    /// Предоставляет класс обучающего образца нейронной сети.
    /// </summary>
    public class TrainExample
    {
        /// <summary>
        /// Возвращает значения для входного слоя нейронной сети.
        /// </summary>
        public double[] Input { get; }

        /// <summary>
        /// Возвращает ожидаемый результат на выходном слое нейрноой сети.
        /// </summary>
        public double[] ExpectedOutput { get; }

        /// <summary>
        /// Предоставляет класс обучающего образца нейронной сети.
        /// </summary>
        /// <param name="input">Значения для входного слоя нейронной сети</param>
        /// <param name="expectedOutput">Ожидаемый результат на выходном слое нейрноой сети</param>
        public TrainExample(double[] input, double[] expectedOutput)
        {
            Input = input; 
            ExpectedOutput = expectedOutput;
        }
    }
}
