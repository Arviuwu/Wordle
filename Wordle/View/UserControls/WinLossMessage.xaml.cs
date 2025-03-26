using System.Windows;
using System.Windows.Controls;
using Wordle.Classes;

namespace Wordle.View.UserControls
{
    /// <summary>
    /// Interaction logic for WinLossMessage.xaml
    /// </summary>
    public partial class WinLossMessage : UserControl
    {
        public WinLossMessage()
        {
            InitializeComponent();
            
            WordDict.GameWon += GameWon;
            WordDict.GameLost += GameLost;
            
          
        }
        private string customText;

        public string CustomText
        {
            get { return customText; }
            set { customText = value; }
        }

        void GameWon()
        {
            WordDisplay.Text =$"The word was:\n{WordDict.currentWord}";
            Test.Visibility = Visibility.Visible;
                WinMessage.Visibility = Visibility.Visible;
                LossMessage.Visibility = Visibility.Hidden;
                btnMenu.Visibility = Visibility.Visible;
                btnPlayAgain.Visibility = Visibility.Visible;
            

        }
        void GameLost()
        {
            WordDisplay.Text = $"The word was:\n{WordDict.currentWord}";
            Test.Visibility = Visibility.Visible;
            WinMessage.Visibility = Visibility.Hidden;
            LossMessage.Visibility = Visibility.Visible;
            btnMenu.Visibility = Visibility.Visible;
            btnPlayAgain.Visibility = Visibility.Visible;
        }

        private void btnPlayAgain_Click(object sender, RoutedEventArgs e)
        {
            WordDict.StartGameClick?.Invoke();
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            WordDict.ClickMainMenu?.Invoke();
        }
    }
}
