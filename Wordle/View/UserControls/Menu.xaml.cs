using System.Windows.Controls;
using Wordle.Classes;

namespace Wordle.View.UserControls
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : UserControl
    {
        public bool language = true;
        
        public Menu()
        {
            InitializeComponent();
        }

        public void Game_Start(object sender, System.Windows.RoutedEventArgs e)
        {
           WordDict.StartGameClick?.Invoke();
        }

        private void LanguageToggle_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            
            if (language)
            {
                LanguageToggle.Content = "GER";
                language = !language;
                WordDict.LanguageChanged?.Invoke();
            }
            else if(!language)
            {
                LanguageToggle.Content = "ENG";
                language = !language;
                WordDict.LanguageChanged?.Invoke();
            }
        }
    }
}
