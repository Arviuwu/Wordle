using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Wordle.Classes;
using Wordle.View;

namespace Wordle.View.UserControls
{
    /// <summary>
    /// Interaction logic for InputLine.xaml
    /// </summary>
    
    public partial class InputLine : UserControl
    {
        
        private int rowNum;

        public int RowNum
        {
            get
            {
                return rowNum;
            }
            set
            {
                rowNum = value;
            }
        }

        private string wordGuess;

        public string WordGuess
        {
            get
            {
                return wordGuess;
            }
            set
            {
                wordGuess = value;
            }
        }




        public InputLine()
        {
            InitializeComponent();
            FocusFirst();
            
        }
        public string GetWordGuess()
        {
            
            string word = $"{box0.tbxInputBox.Text}{box1.tbxInputBox.Text}{box2.tbxInputBox.Text}{box3.tbxInputBox.Text}{box4.tbxInputBox.Text}";
            Debug.WriteLine(word);
            WordGuess = word;
            WordDict.currentGuess = word;
            return word;
        }
        void FocusFirst()
        {
            if (rowNum == 0)
            {
                var request = new TraversalRequest(FocusNavigationDirection.First);

                box0.tbxInputBox.MoveFocus(request);
            }
        }
        private void UserControl_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            
            if(e.Key == Key.Enter && !String.IsNullOrEmpty(box4.tbxInputBox.Text))
            {
            
                GetWordGuess();
                if (WordDict.words.Contains(wordGuess))
                {
                  
                    ColorControl(box0.tbxInputBox, 0);
                    ColorControl(box1.tbxInputBox, 1);
                    ColorControl(box2.tbxInputBox, 2);
                    ColorControl(box3.tbxInputBox, 3);
                    ColorControl(box4.tbxInputBox, 4);
                    if (wordGuess == WordDict.currentWord)
                    {

                        WordDict.GameWon?.Invoke();
                        return;
                    }
                    if(RowNum == 4 && !string.IsNullOrEmpty(box4.tbxInputBox.Text))
                    {
                        WordDict.GameLost?.Invoke();
                    }
                    WordDict.OnLineCompleted?.Invoke();
                   
                }
                
            }
        }
       private void ColorControl(TextBox element, int col)
        {
            if (WordDict.currentWord[col] == element.Text?[0])
            {
                element.Background = Brushes.Green;
                WordDict.correctChars.Add(element.Text[0]);
                if (WordDict.yellowChars.Contains(element.Text[0]))
                {
                    WordDict.yellowChars.Remove(element.Text[0]);
                }
            }
            else if (WordDict.currentWord.Contains(element.Text[0]))
            {
               element.Background = Brushes.Yellow;
               WordDict.yellowChars.Add(element.Text[0]);
            }
            else
            {
                Color customColor = Color.FromArgb(255, 78, 78, 78);
                SolidColorBrush customBrush = new SolidColorBrush(customColor);
                element.Background = customBrush;
                WordDict.notContained.Add(element.Text[0]);
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            FocusFirst();
        }
    }
}
