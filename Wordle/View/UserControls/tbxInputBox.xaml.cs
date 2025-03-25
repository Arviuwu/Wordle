using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Wordle.Classes;


namespace Wordle.View.UserControls
{
    /// <summary>
    /// Interaction logic for InputBox.xaml
    /// </summary>
    public partial class InputBox : UserControl
    {
        
        public InputBox()
        {
            InitializeComponent();
        }

        private int colNum;

        public int ColNum
        {
            get { return colNum; }
            set { colNum = value; }
        }


        private void tbxInputBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            if (ColNum < 4)
            {
            if (tbxInputBox.Text.Length == 1)
                {
                    FocusRight(tbxInputBox);
                }
            }
            
        }
        
        
        private void tbxInputBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.Key == Key.Back)
            {
                if(string.IsNullOrEmpty(tbxInputBox.Text) && ColNum == 0)
                {

                }
                else if (string.IsNullOrEmpty(tbxInputBox.Text))
                {
                    FocusLeft(tbxInputBox);
                }
                else if (ColNum == 4)
                {
                    e.Handled = true;
                    tbxInputBox.Clear();
                }
                else if(colNum > 0)
                {
                    e.Handled = true; 
                    tbxInputBox.Clear();      
                }
            }

            if(e.Key == Key.Enter && ColNum == 4 && !String.IsNullOrEmpty(tbxInputBox.Text) && WordDict.words.Contains(WordDict.currentGuess))
            {

                FocusNext(tbxInputBox); 
                
                
            }
        }

        void FocusLeft(UIElement element)
        {
            var request = new TraversalRequest(FocusNavigationDirection.Previous);
            
            element.MoveFocus(request);
        }
        void FocusRight(UIElement element)
        {
            var request = new TraversalRequest(FocusNavigationDirection.Right);

            element.MoveFocus(request);
        }
        public void FocusNext(UIElement element)
        {
            var request = new TraversalRequest(FocusNavigationDirection.Next);

            element.MoveFocus(request);
        }
        public void NextCaller()
        {
            FocusNext(tbxInputBox);
        }

        private void UserControl_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;
        }
    }
}
