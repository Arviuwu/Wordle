using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
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
         void GameWon()
        {
            
                WinMessage.Visibility = Visibility.Visible;
                LossMessage.Visibility = Visibility.Hidden;
            

        }
        void GameLost()
        {
            WinMessage.Visibility = Visibility.Hidden;
            LossMessage.Visibility = Visibility.Visible;
        }
       
    }
}
