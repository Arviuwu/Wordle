using System.Windows.Controls;
using Wordle.Classes;

namespace Wordle.View.UserControls
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : UserControl
    {
        
        public Menu()
        {
            InitializeComponent();
        }

        public void Game_Start(object sender, System.Windows.RoutedEventArgs e)
        {
           WordDict.StartGameClick?.Invoke();
        }
    }
}
