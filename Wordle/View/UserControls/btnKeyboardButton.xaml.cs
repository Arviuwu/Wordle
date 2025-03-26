using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Media;
using Wordle.Classes;

namespace Wordle.View.UserControls
{
    /// <summary>
    /// Interaction logic for KeyboardButton.xaml
    /// </summary>
    public partial class KeyboardButton : UserControl
    {
        public KeyboardButton()
        {
            
            InitializeComponent();
            WordDict.OnLineCompleted += ChangeColor;

        }
        
        public string ButtonContent
        {
            get { return (string)LetterButton.Content; }
            set { LetterButton.Content = value; }
        }
        public void ChangeColor()
        {
            if (LetterButton.Content != null && WordDict.notContained.Contains(LetterButton.Content.ToString()[0]))
            {
                LetterButton.Background = WordDict.ReturnBrush(255, 78, 78, 78);
            }
            else if(LetterButton.Content != null && WordDict.yellowChars.Contains(LetterButton.Content.ToString()[0]))
            {
                LetterButton.Background = Brushes.Yellow;
            }
            else if(LetterButton.Content != null && WordDict.correctChars.Contains(LetterButton.Content.ToString()[0]))
            {
                LetterButton.Background = Brushes.Green;
            }
        }
        private void LetterButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            LetterButton.Content = ButtonContent;
            Debug.WriteLine(LetterButton.Content);
        }

        private void LetterButton_PreviewMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            e.Handled = true;
        }
    }
}
