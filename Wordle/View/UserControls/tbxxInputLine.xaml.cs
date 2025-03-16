using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

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
                
            }
        }
    }
}
