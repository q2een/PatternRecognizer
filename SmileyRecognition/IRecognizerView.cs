using PatternRecognizer.BL.Network;
using System;
using System.Collections.Generic;

namespace PatternRecognizer
{
    public interface IRecognizerView
    {
        #region Свойства.

        #region Параметры обучения нейронной сети.

        /// <summary>
        /// Возвращает конфигурацию слоев.
        /// </summary>
        IEnumerable<LayerConfiguration> LayerConfigurations { get; }

        /// <summary>
        /// Возвращает количество эпох, заднанных пользователем.
        /// </summary>
        int NumberOfEpochs { get; }

        /// <summary>
        /// Возвращает норму обучения, заднанную пользователем.
        /// </summary>
        double LearningRate { get; }

        /// <summary>
        /// Возвращает импульс, заднанный пользователем.
        /// </summary>
        double Momentum { get; }

        #endregion

        #region Управление загрузкой/сохранением.
                     
        /// <summary>
        /// Возвращает путь изображения с обучающей выборкой для обучения нейронной сети.
        /// </summary>
        string TrainSetImagePath { get; }

        /// <summary>
        /// Возвращает путь для загрузки нейронной сети.
        /// </summary>
        string LoadNetworkPath { get; }

        /// <summary>
        /// Возвращает путь для сохранения нейронной сети.
        /// </summary>
        string SaveNetworkPath { get; }

        #endregion

        /// <summary>
        /// Возвращает или задает режим работы представления. Обучение или распознавание.
        /// </summary>
        bool IsTrainMode { get; set; }

        /// <summary>
        /// Возвращает текущее изображение нарисованное пользователем.
        /// </summary>
        double[] CurrentImage { get; }

        #endregion

        #region Методы.

        /// <summary>
        /// Устанавливает основные параметры нейронной сети.
        /// </summary>
        /// <param name="activations">Список функций активации, которые поддерживает нейронная сеть</param>
        /// <param name="patternImageWidth">Ширина изображения с паттерном</param>
        /// <param name="patternImageHeight">Высота изображения с паттерном</param>
        /// <param name="patternCount">Количество распознаваемых паттернов</param>
        void SetNetworkProperties(IEnumerable<string> activations, int patternImageWidth, int patternImageHeight, int patternCount);

        /// <summary>
        /// Задает прогресс обучения нейроной сети.
        /// </summary>
        /// <param name="currentEpoch">Текущая эпоха</param>
        /// <param name="epochCount">Общее количество эпох обучения</param>
        /// <param name="meanCost">Ошибка обучения</param>
        void SetTrainProgress(int currentEpoch, int epochCount, double meanCost);

        /// <summary>
        /// Устанавливает результат распознавания паттерна.
        /// </summary>
        /// <param name="results">Коллеция <see cref="RecognizerItem"/> результатов распозвонования. 
        /// Первый элемент в списке - наиболее вероятный результат.</param>
        void SetRecognitionResult(List<RecognizerItem> results);

        #endregion

        #region События.

        /// <summary>
        /// Происходит перед загрузкой представления.
        /// </summary>
        event EventHandler BeforeLoad;    

        /// <summary>
        /// Происхоидит при получении обучающей выбоки.
        /// </summary>
        event EventHandler OpenTrainSetClick;

        /// <summary>
        /// Происходит при сохранении нейронной сети.
        /// </summary>
        event EventHandler SaveNetworkClick;

        /// <summary>
        /// Происходи при загрузке нейронной сети.
        /// </summary>
        event EventHandler LoadNetworkClick;

        /// <summary>
        /// Происходит при обучении нейронной сети.
        /// </summary>
        event EventHandler TrainNetworkClick;

        /// <summary>
        /// Происходит при распознавании паттерна, указанного пользователем.
        /// </summary>
        event EventHandler RecognizeClick;

        #endregion

    }
}
