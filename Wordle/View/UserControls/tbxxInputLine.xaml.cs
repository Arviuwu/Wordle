using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Wordle.Classes;

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
            
        }
        public string GetWordGuess()
        {
            string word = $"{box0.tbxInputBox.Text}{box1.tbxInputBox.Text}{box2.tbxInputBox.Text}{box3.tbxInputBox.Text}{box4.tbxInputBox.Text}";
            Debug.WriteLine(word);
            WordGuess = word;
            return word;
        }
        

        private void UserControl_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter && !String.IsNullOrEmpty(box4.tbxInputBox.Text))
            {
                GetWordGuess();
                // Debug.WriteLine("Inputline word guess:" + GetWordGuess());
                if (!String.IsNullOrEmpty(WordGuess)) 
                {
                    //Check correct letter AND position
                    ColorControl(box0.tbxInputBox, 0);
                    ColorControl(box1.tbxInputBox, 1);
                    ColorControl(box2.tbxInputBox, 2);
                    ColorControl(box3.tbxInputBox, 3);
                    ColorControl(box4.tbxInputBox, 4);
                }
            }
        }
       private void ColorControl(TextBox element, int col)
        {
            if (WordDict.testWord[col] == element.Text[0])
            {
                element.Background = Brushes.Green;
            }
            else if (WordDict.testWord.Contains(element.Text[0]))
            {
               element.Background = Brushes.Yellow;
            }
            else
            {
               WordDict.notContained.Add(element.Text[0]);
            }
        }
        

    }
}
