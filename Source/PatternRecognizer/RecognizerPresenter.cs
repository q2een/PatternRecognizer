using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using PatternRecognizer.BL.Network;
using PatternRecognizer.BL.ImagePattern;

namespace PatternRecognizer
{
    public class RecognizerPresenter
    {
        #region Поля класса.

        private readonly IRecognizerView view;         
        private readonly IMessageService messageService;
        private INeuralNetwork network;
        private readonly INetworkManager manager;
        private readonly ITrainsetManager<Image, ImagePattern> trainsetManager;
        private readonly ImagePattern pattern;

        #endregion

        /// <summary>
        /// Предоставляет класс Presenter.
        /// </summary>
        /// <param name="mainView">Объект представления</param>
        /// <param name="messageService">Объект отображения оповещений</param>
        /// <param name="network">Объект нейронной сети</param>
        /// <param name="manager">Объект для управления загрузкой / сохранением нейронной сети</param>
        /// <param name="trainsetManager">Объект для получени и обработки обучающей выборки</param>
        /// <param name="pattern">Объект представляющий структуру паттерна</param>
        public RecognizerPresenter(IRecognizerView mainView, IMessageService messageService, INeuralNetwork network, INetworkManager manager, ITrainsetManager<Image, ImagePattern> trainsetManager, ImagePattern pattern)
        {
            this.view = mainView;
            this.messageService = messageService;
            this.network = network;
            this.manager = manager;
            this.trainsetManager = trainsetManager;
            this.pattern = pattern;

            view.OpenTrainSetClick += View_OpenTrainSetClick;
            view.LoadNetworkClick += View_LoadNetworkClick;
            view.SaveNetworkClick += View_SaveNetworkClick;
            view.RecognizeClick += View_RecognizeClick;
            view.TrainNetworkClick += View_TrainNetworkClick;
            view.BeforeLoad += View_BeforeLoad;

            network.EpochTrained += Network_EpochTrained;
            network.OnTrainingEnd += Network_OnTrainingEnd;
        }

        // Вовзращает коллекцию с результами распознавания смайликов нейронной сетью.
        private List<RecognizerItem> GetNetworkOutput(double[] networkOutput)
        {
            var items = new RecognizerItem[networkOutput.Length];

            for (int i = 0; i < networkOutput.Length; i++)
            {
                items[i] = new RecognizerItem(pattern.Map) { Index = i, ProbabilityValue = networkOutput[i] };
            }

            return items.OrderByDescending(item => item.ProbabilityValue).ToList();
        }

        #region Обработка событий.

        #region Нейронная сеть.

        private void Network_EpochTrained(object sender, EphochTrainedEventArgs e)
        {
            view.SetTrainProgress(e.CurrentEpoch, e.TotalEpochCount, e.Cost);
        }

        private void Network_OnTrainingEnd(object sender, EphochTrainedEventArgs e)
        {
            messageService.ShowMessage("Процесс обучения нейронной сети завершен");
        }

        #endregion

        #region View.

        private void View_BeforeLoad(object sender, EventArgs e)
        {
            view.SetNetworkProperties(network.Activations, pattern.PatternHeight, pattern.PatternWidth, pattern.Map.PatternCount);
            view.IsTrainMode = true;
        }
        
        private async void View_TrainNetworkClick(object sender, EventArgs e)
        {
            try
            {
                network.LayerConfigurations = view.LayerConfigurations.ToArray();  

                var examples = trainsetManager.GetTrainExamples(pattern, view.TrainSetImagePath);

                await Task.Run(() => network.Train(examples, view.NumberOfEpochs, view.LearningRate, view.Momentum));

            }
            catch(Exception ex)
            {
                messageService.ShowError(ex.Message);
            }
        }

        private void View_RecognizeClick(object sender, EventArgs e)
        {
            try
            {
                if (network.IsNull)
                    throw new Exception("Перед распознованием образа необходимо загрузить или обучить нейронную сеть");

                var output = network.GetNetworkOutput(view.CurrentImage);

                view.SetRecognitionResult(GetNetworkOutput(output));
            }
            catch (Exception ex)
            {
                messageService.ShowError(ex.Message); 
            }
        }

        private void View_SaveNetworkClick(object sender, EventArgs e)
        {
            try
            {
                manager.SaveNeuralNetwork(network, view.SaveNetworkPath);
            }
            catch (Exception ex)
            {
                messageService.ShowError(ex.Message);
            }
        }

        private void View_LoadNetworkClick(object sender, EventArgs e)
        {
            try
            {
                if (!manager.IsExist(view.LoadNetworkPath))
                    throw new Exception("Невозможно получить нейронную сеть из указанного источника");

                network = manager.GetNeuralNetwork(view.LoadNetworkPath);

                view.IsTrainMode = false;
            }
            catch (Exception ex)
            {
                messageService.ShowError(ex.Message);
            }
        }

        private void View_OpenTrainSetClick(object sender, EventArgs e)
        {
            if (trainsetManager.IsCorrectFormat(view.TrainSetImagePath))
                return;

            messageService.ShowError("Изображение для обучения нейронной сети некорректно");
        }

        #endregion

        #endregion
    }
}
