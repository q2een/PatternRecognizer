using System.Collections.Generic;

namespace PatternRecognizer.BL.Network
{
    /// <summary>
    /// Предоставляет менеджер для управелния обучающей выборкой.
    /// </summary>
    /// <typeparam name="T">Тип данных, содержащий обучающую выборку</typeparam>
    /// <typeparam name="U">Тип данных для получения обучающих образцов <see cref="TrainExample"/> на основе обучающей выборки.</typeparam>
    public interface ITrainsetManager<T,U>
    {
        /// <summary>
        /// Проверяет является ли обучающая выборка, расположенная по пути <paramref name="path"/>,
        /// верного формата и возвращает результат проверки.
        /// </summary>
        bool IsCorrectFormat(string path);

        /// <summary>
        /// Возвращает обучающую выборку расположенную по пути <paramref name="path"/>.
        /// </summary>
        /// <returns>Объект, содержащий обучающую выборку</returns>
        T GetTrainSet(string path);

        /// <summary>
        /// Возвращает коллекцию обучающих образцов <see cref="TrainExample"/> на основе обучающей выборки <paramref name="trainset"/>. 
        /// </summary>
        /// <returns>Коллекция обучающих образцов</returns>
        IEnumerable<TrainExample> GetTrainExamples(U trainset);

        /// <summary>
        /// Возвращает коллекцию обучающих образцов <see cref="TrainExample"/> на основе обучающей выборки <paramref name="trainset"/>. 
        /// </summary>
        /// <param name="path">Путь к объекту обучающей выборки</param>
        /// <returns>Коллекция обучающих образцов</returns>
        IEnumerable<TrainExample> GetTrainExamples(U trainset, string path);
    }
}
