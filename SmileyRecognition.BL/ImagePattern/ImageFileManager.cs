using PatternRecognizer.BL.Network;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace PatternRecognizer.BL.ImagePattern
{
    /// <summary>
    /// Предоставляет менеджер для управелния обучающей выборкой представленной в виде изображения. 
    /// </summary>
    public class ImagePatternManager : ITrainsetManager<Image,ImagePattern>
    {
        public bool IsCorrectFormat(string path)
        {
            if (!File.Exists(path))
                return false;

            var bytes = File.ReadAllBytes(path);
            var pngHeader = new byte[] { 137, 80, 78, 71 };

            if (!pngHeader.SequenceEqual(bytes.Take(pngHeader.Length)))
                return false;

            return true;
        }

        public Image GetTrainSet(string path)
        {
            return Image.FromFile(path);
        }

        public IEnumerable<TrainExample> GetTrainExamples(ImagePattern trainset, string path)
        {
            trainset.Trainset = GetTrainSet(path);
            return GetTrainExamples(trainset);
        }

        public IEnumerable<TrainExample> GetTrainExamples(ImagePattern trainset)
        {
            return GetExamples(trainset.Trainset, trainset.PatternHeight, trainset.PatternWidth);
        }

        // Возвращает образец для обучения нейронной сети.
        private static TrainExample CreateExample(double[] lineValues, int outputValuesCount, int index)
        {
            double[] targets = Enumerable.Range(0, outputValuesCount).Select(_ => 0.01).ToArray();
            targets[index] = 0.99;

            return new TrainExample(lineValues, targets);
        }

        /// <summary>
        /// Возвращает образцы для обучения нейронной сети.
        /// </summary>
        /// <param name="trainImagePath">Путь к изображению с обучающей выборкой</param>
        /// <param name="rowsCount">Количество образцов для распознавания</param>
        /// <param name="columnsCount">Количество вариантов для данного образца.</param>
        /// <param name="outputValuesCount">Количество нейронов на выходе нейронной сети</param>
        /// <returns>Коллекция образцов для обучения нейронной сети</returns>
        private TrainExample[] GetExamples(Image trainset, int patternHeight, int patternWidth)
        {
            var image = new Bitmap(trainset);

            var examples = GetTrainsetPixels(image, patternHeight, patternWidth);

            int examplesPerPattern = image.Width / patternWidth;

            var trainExamples = new TrainExample[examples.Count];

            for (int i = 0; i < trainExamples.Length; i++)
            {
                trainExamples[i] = CreateExample(examples[i], examples.Count / examplesPerPattern, i / examplesPerPattern);
            }

            return trainExamples;
        }

        /// <summary>
        /// Возвращает коллекцию массивов пикселей, представляющих изображение для обучения нейронной сети.
        /// 1 = белый пиксел. 0 - черный пиксел. 
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
        /// <param name="trainset">Изображение с обучающей выборкой</param>
        /// <param name="rowsCount">Количество образцов для распознавания</param>
        /// <param name="columnsCount">Количество вариантов для данного образца.</param>
        /// <returns>Коллекция массивов пикселей, представляющих изображение для обучения</returns>
        public static List<double[]> GetTrainsetPixels(Bitmap trainset, int rowsCount, int columnsCount)
        {
            var patternsCount = trainset.Height / rowsCount;
            var samplesPerPattern = trainset.Width / columnsCount;

            var samples = Enumerable.Range(0, patternsCount * samplesPerPattern).Select(i => new double[rowsCount * columnsCount]).ToList();

            for (int x = 0; x < trainset.Width; x++)
            {
                for (int y = 0; y < trainset.Height; y++)
                {
                    int currentPattern = y / rowsCount;
                    int currentPatternSample = x / columnsCount;

                    int currentSampleIndex = (currentPattern * samplesPerPattern) + currentPatternSample;
                    int currentSamplePixelIndex = (x % columnsCount) + ((y % rowsCount) * columnsCount);

                    var pixelColor = trainset.GetPixel(x, y);

                    samples[currentSampleIndex][currentSamplePixelIndex] = GetPixelColor(pixelColor);
                }
            }

            return samples;
        }

        /// <summary>
        /// Возвращает значение цвета пикселя. 0 - черный пиксель. 1 - белый пиксель.
        /// </summary>
        /// <param name="color">RGB - Цвет пикселя</param>
        /// <returns></returns>
        private static double GetPixelColor(Color color)
        {
            // 255 * 3 = 765.
            return (color.R + color.G + color.B) / (765.0d);
        }
    }
}
