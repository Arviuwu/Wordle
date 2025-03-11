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

        private int myVar;


        public InputLine()
        {
            InitializeComponent();
            
        }
        public string GetWordGuess()
        {
            string word = $"{box0.tbxInputBox.Text}{box1.tbxInputBox.Text}{box2.tbxInputBox.Text}{box3.tbxInputBox.Text}{box4.tbxInputBox.Text}";
            Debug.WriteLine(word);
            return word;
            
        }
        void FocusNext(UIElement element)
        {
            var request = new TraversalRequest(FocusNavigationDirection.First);

            element.MoveFocus(request);
        }

        private void UserControl_PreviewKeyDown(object sender, KeyEventArgs e)
        {
          
        }
    }
}
