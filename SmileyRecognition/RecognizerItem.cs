using System;
using System.ComponentModel;
using System.Drawing;
using PatternRecognizer.BL.Pattern;

namespace PatternRecognizer
{
    /// <summary>
    /// Предоставляет класс, содержащий данные о распознавании смайлика.
    /// </summary>
    public class RecognizerItem
    {

        private readonly IPatternMap<Image> map;

        /// <summary>
        /// Возвращает или задает индекс смайлика.
        /// </summary>
        [Browsable(false)]
        public int Index { get; set; }
       
        /// <summary>
        /// Возвращает или задает вероятность правильности распознования.
        /// </summary>
        [Browsable(false)]
        public double ProbabilityValue { get; set; }

        /// <summary>
        /// Возвращает изображения смайлика.
        /// </summary>
        [Browsable(false)]
        public Image Image
        {
            get
            {
                return map.GetPatternObject(Index);
            }
        }

        /// <summary>
        /// Возвращает текстовое представление смайлика.
        /// </summary>
        [DisplayName("Паттерн")]
        public string PatternText
        {
            get
            {
                return map.GetPatternTextByIndex(Index);
            }
        }
          
        /// <summary>
        /// Возвращает вероятность в научном формате.
        /// </summary>
        [DisplayName("Вероятность")]
        public string FormatProbabilityValue
        {
            get
            {
                return string.Format(Math.Round(Math.Abs(ProbabilityValue), 3) < 0.0001 ? "{0:#.##E+0}" : "{0:0.0000}", ProbabilityValue);
            }
        }

        public RecognizerItem(IPatternMap<Image> map)
        {
            this.map = map;   
        }
    }
}
