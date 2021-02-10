using System.Windows;
using System.Windows.Media;

namespace Roman_Numeral_Converter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const string ROMAN_ONE = "I";
        const string ROMAN_TWO = "II";
        const string ROMAN_THREE = "III";
        const string ROMAN_FOUR = "IV";
        const string ROMAN_FIVE = "V";
        const string ROMAN_SIX = "VI";
        const string ROMAN_SEVEN = "VII";
        const string ROMAN_EIGHT = "VIII";
        const string ROMAN_NINE = "IX";
        const string ROMAN_TEN = "X";

        public MainWindow()
        {
            InitializeComponent();
            ConvertButton.Background = new LinearGradientBrush(Colors.White, Colors.DarkGray, 45);
        }

        private void InputTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            BackgroundBlur.Radius = 20;
        }

        void ApplyErrorStyle()
        {
            ConvertedRomanNumber.FontSize = 40;
            ConvertedRomanNumber.VerticalContentAlignment = VerticalAlignment.Center;
        }

        void ApplyNormalStyle()
        {
            ConvertedRomanNumber.FontSize = 100;
            ConvertedRomanNumber.VerticalContentAlignment = VerticalAlignment.Top;
        }

        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var Number = int.Parse(InputTextBox.Text);
                if(Number < 1 || Number > 10)
                {
                    ApplyErrorStyle();
                    ConvertedRomanNumber.Content = "Please enter a valid number between 1 and 10.";
                }
                else
                {
                    ApplyNormalStyle();
                    switch (Number)
                    {
                        case 1:
                            ConvertedRomanNumber.Content = ROMAN_ONE;
                            break;
                        case 2:
                            ConvertedRomanNumber.Content = ROMAN_TWO;
                            break;
                        case 3:
                            ConvertedRomanNumber.Content = ROMAN_THREE;
                            break;
                        case 4:
                            ConvertedRomanNumber.Content = ROMAN_FOUR;
                            break;
                        case 5:
                            ConvertedRomanNumber.Content = ROMAN_FIVE;
                            break;
                        case 6:
                            ConvertedRomanNumber.Content = ROMAN_SIX;
                            break;
                        case 7:
                            ConvertedRomanNumber.Content = ROMAN_SEVEN;
                            break;
                        case 8:
                            ConvertedRomanNumber.Content = ROMAN_EIGHT;
                            break;
                        case 9:
                            ConvertedRomanNumber.Content = ROMAN_NINE;
                            break;
                        case 10:
                            ConvertedRomanNumber.Content = ROMAN_TEN;
                            break;
                        default:
                            break;
                    }
                }
            }
            catch
            {
                ApplyErrorStyle();
                ConvertedRomanNumber.Content = "Please enter a valid number between 1 and 10.";
            }
        }
    }
}
