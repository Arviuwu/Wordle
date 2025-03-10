using System.Windows.Controls;

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

        private void tbxInputBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(tbxInputBox.Text.Length == 1)
            {

            }
        }
        p
    }
}
