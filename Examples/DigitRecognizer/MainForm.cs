using PatternRecognizer;

namespace DigitRecognizer
{
    class MainForm: RecognizerView
    {
        public MainForm()
        {
            DrawerMultiplier = 80;
            IsGraphicsResultExists = false;
            Text = "Распознавание цифр";
        }
    }
}
