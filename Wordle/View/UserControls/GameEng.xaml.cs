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
using System.Windows.Navigation;
using Wordle.Classes;
using System.IO;
using System.Diagnostics;


namespace Wordle.View.UserControls
{
    /// <summary>
    /// Interaction logic for GameEng.xaml
    /// </summary>
    public partial class GameEng : UserControl
    {
        public GameEng()
        {
            InitializeComponent();
            
            WordDict.GameWonCheck = false;
            WordDict.correctChars.Clear();
            WordDict.yellowChars.Clear();
            WordDict.notContained.Clear();
            WordDict.PathAllWords = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files", "five_letter_words_eng.txt");
            WordDict.PathGuessWords = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files", "guessable_words_eng.txt");
            WordDict.InitializeDict();
            WordDict.PickWord();
        }
    }
}
