using PatternRecognizer.BL.Network;
using PatternRecognizer.BL.NeuraNet;
using PatternRecognizer.BL.ImagePattern;
using System;
using System.Windows.Forms;

namespace PatternRecognizer
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var view = new RecognizerView();
            IMessageService msgService = new DialogMessageService();

            INeuralNetwork network = new NeuraNet();
            INetworkManager manager = new NeuraNetFileManager();

            var patternManager = new ImagePatternManager();
            var pattern = new ImagePattern(7, 5, new SmileyMap());

            var presenter = new RecognizerPresenter(view, msgService, network, manager, patternManager, pattern);

            Application.Run(view);
        }
    }
}
