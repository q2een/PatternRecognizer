using System.Drawing;
using System;
using PatternRecognizer.BL.Pattern;

namespace PatternRecognizer
{
    /// <summary>
    /// Предоставляет статический класс, содержащий методы для получения разных представлений смайликов.
    /// </summary>
    public class SmileyMap:IPatternMap<Image>
    {
        public int PatternCount => smiley.Length;

        private string[] smiley = new string[] { ":)", ":d", "xd", "oo", "(:", ":-|", ":p", "3(", "<3", ":(" };

        public int GetIndexByPatternText(string pattern)
        {
            return Array.IndexOf(smiley, pattern.ToLower());
        }

        public string GetPatternTextByIndex(int index) => smiley[index];

        public Image GetPatternObject(int index)
        {
           /* switch (index)
            {
                case 0: return Properties.Resources._1;
                case 1: return Properties.Resources._2;
                case 2: return Properties.Resources._3;
                case 3: return Properties.Resources._4;
                case 4: return Properties.Resources._5;
                case 5: return Properties.Resources._6;
                case 6: return Properties.Resources._7;
                case 7: return Properties.Resources._8;
                case 8: return Properties.Resources._9;
                case 9: return Properties.Resources._10;
            }
                        */
            return null;
        }

        public Image GetPatternObject(string text)
        {
            return GetPatternObject(GetIndexByPatternText(text));
        }
    }
}
