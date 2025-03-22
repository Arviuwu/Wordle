using System.Windows.Controls;
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
        public void ChangeColor()
        {





        }
    }
}
