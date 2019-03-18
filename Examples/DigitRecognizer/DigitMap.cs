using System.Drawing;
using PatternRecognizer.BL.Pattern;

namespace DigitRecognizer
{
    /// <summary>
    /// Предоставляет статический класс, содержащий методы для получения разных представлений смайликов.
    /// </summary>
    public class DigitMap: IPatternMap<Image>
    {
        public int PatternCount => 10;

        public int GetIndexByPatternText(string pattern) => int.Parse(pattern);

        public string GetPatternTextByIndex(int index) => index.ToString();

        public Image GetPatternObject(int index) => null;

        public Image GetPatternObject(string text) => null;
    }
}
