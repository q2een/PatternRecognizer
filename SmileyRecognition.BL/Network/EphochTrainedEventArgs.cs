using System;

namespace PatternRecognizer.BL.Network
{
    /// <summary>
    /// Предоставляет класс, содержащий данные событий обучения нейронной сети.
    /// </summary>
    public class EphochTrainedEventArgs : EventArgs
    {
        /// <summary>
        /// Возвращает текующую эпоху обучения.
        /// </summary>
        public int CurrentEpoch { get; internal set; }

        /// <summary>
        /// Возвращает общее количечтво эпох обучения.
        /// </summary>
        public int TotalEpochCount { get; internal set; }

        /// <summary>
        /// Возвращает ошибку обучения на данной эпохе. 
        /// </summary>
        public double Cost { get; internal set; }
       
        /// <summary>
        /// Предоставляет класс, содержащий данные событий обучения нейронной сети.
        /// </summary>
        /// <param name="currentEpoch">Текущая эпоха обучения</param>
        /// <param name="totalEpochCount">Общее количество эпох обучения</param>
        /// <param name="сost">Ошибка обучения</param>
        public EphochTrainedEventArgs(int currentEpoch, int totalEpochCount, double сost)
        {
            CurrentEpoch = currentEpoch;
            TotalEpochCount = totalEpochCount;
            Cost = сost;
        }
    }
}
