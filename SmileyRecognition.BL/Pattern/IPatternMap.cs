namespace PatternRecognizer.BL.Pattern
{
    /// <summary>
    /// Предоставляет структуру распознаваемых нейронной сетью паттернов.
    /// </summary>
    /// <typeparam name="T">Тип паттерна</typeparam>
    public interface IPatternMap<T>
    {
        /// <summary>
        /// Возвращает количество распознаваемых паттернов.
        /// </summary>
        int PatternCount { get;}

        /// <summary>
        /// Возвращает индекс паттерна по его текстовому представлению <paramref name="text"/>.
        /// </summary>
        int GetIndexByPatternText(string text);

        /// <summary>
        /// Возвращает текст паттерна по его индексу <paramref name="index"/>.
        /// </summary>
        string GetPatternTextByIndex(int index);

        /// <summary>
        /// Возвращает объект паттерна по его индексу <paramref name="index"/>.
        /// </summary>
        T GetPatternObject(int index);

        /// <summary>
        /// Возвращает объект паттерна по его текстовому представлению <paramref name="text"/>.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        T GetPatternObject(string text);
    }
}
