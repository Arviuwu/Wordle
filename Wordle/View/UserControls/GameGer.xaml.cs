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
using Wordle.Classes;
using System.IO;

namespace Wordle.View.UserControls
{
    /// <summary>
    /// Interaction logic for GameGer.xaml
    /// </summary>
    public partial class GameGer : UserControl
    {
        public GameGer()
        {
            InitializeComponent();

            WordDict.GameWonCheck = false;
            WordDict.correctChars.Clear();
            WordDict.yellowChars.Clear();
            WordDict.notContained.Clear();
            WordDict.PathAllWords = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files", "five_letter_words_ger.txt");
            WordDict.PathGuessWords = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files", "guessable_words_ger.txt");
            WordDict.InitializeDict();
            WordDict.PickWord();
        }
    }
}
