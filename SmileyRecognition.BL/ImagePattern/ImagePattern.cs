using PatternRecognizer.BL.Pattern;
using System.Drawing;

namespace PatternRecognizer.BL.ImagePattern
{
    /// <summary>
    /// Предоставляет паттерн представленный в виде изображения.
    /// </summary>
    public class ImagePattern
    {
        /// <summary>
        /// Возвращает или задает изображение, содержащее обучающую выборку.
        /// </summary>
        /// <remarks>
        /// Изображение должно формироваться по следующим правилам:
        /// Вертикально - паттерны для распознавания. Например, смайлики :), (:, xD ...
        /// Горизонтально - различные варианты отображения паттерна.
        /// Пример:
        ///   _________
        ///   | :) =) :-) - один смайлик, разные варианты отображения
        ///   | (: (= (-:
        /// </remarks>
        public Image Trainset { get; set; }

        /// <summary>
        /// Возвращает ширину изображения одного паттерна.
        /// </summary>
        public int PatternWidth { get; }

        /// <summary>
        /// Возвращает высоту изображения одного паттерна.
        /// </summary>
        public int PatternHeight { get; }

        /// <summary>
        /// Возвращает общее количество пикселей в одном паттерне.
        /// </summary>
        public int PixelCount => PatternWidth * PatternHeight;
                       
        /// <summary>
        /// Возвращает карту поддерживаемых паттернов.
        /// </summary>
        public IPatternMap<Image> Map { get; }

        /// <summary>
        /// Предоставляет паттерн представленный в виде изображения.
        /// </summary>
        /// <param name="patternWidth">Ширина изображения одного паттерна.</param>
        /// <param name="patternHeight">Высота изображения одного паттерна</param>
        /// <param name="map">Карта поддерживаемых паттернов.</param>
        public ImagePattern(int patternWidth, int patternHeight, IPatternMap<Image> map)
        {
            PatternWidth = patternWidth;
            PatternHeight = patternHeight;
            Map = map;
        }
    }
}
