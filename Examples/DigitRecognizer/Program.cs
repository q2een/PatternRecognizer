using PatternRecognizer;
using PatternRecognizer.BL.ImagePattern;
using PatternRecognizer.BL.Network;
using PatternRecognizer.BL.NeuraNet;
using System;
using System.Windows.Forms;

namespace DigitRecognizer
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

            var view = new MainForm();
            IMessageService msgService = new DialogMessageService();

            INeuralNetwork network = new NeuraNet();
            INetworkManager manager = new NeuraNetFileManager();

            var patternManager = new ImagePatternManager();
            var pattern = new ImagePattern(3, 5, new DigitMap());

            var presenter = new RecognizerPresenter(view, msgService, network, manager, patternManager, pattern);

            Application.Run(view);
        }
    }
}
