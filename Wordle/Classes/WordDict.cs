using System.IO;
using System.Diagnostics;
using System.Windows.Media;
using Wordle.View.UserControls;
namespace Wordle.Classes
{
    class WordDict
    {
        public WordDict()
        {
           
        }
        static public List<string> words = new List<string> { };
        static public string testWord = "SUPER";
        static public List<char> notContained = new List<char> { };
        static public List<char> yellowChars = new List<char> { };
        static public List<char> correctChars = new List<char> { };
        static public string PathAllWords ="";
        static public string PathGuessWords="";
       
        static public Action? OnLineCompleted;
        static public bool GameWonCheck = false;
        static public string? currentGuess;
        static public List<string> guessableWords = new List<string>();
        static public string? currentWord = "0";
        static public Random random = new Random();
        static public Action? StartGameClick;
        static public Action? GameLost;
        static public Action? GameWon;
        static public Action? LanguageChanged;
        static public Action? ClickMainMenu;
        static Color DesignGray = Color.FromArgb(255, 78, 78, 78);
        public SolidColorBrush DarkerGray = new SolidColorBrush(DesignGray);
        
        
        public static void InitializeDict()
        {
            foreach(var x in File.ReadAllLines(PathAllWords))
            {
                words.Add(x.ToUpper());
            }
            Debug.WriteLine("dict initialized with " + words.Count()+" words");
        }
        
        public static string PickWord()
        {
            foreach(var x in File.ReadAllLines(PathGuessWords))
            {
                guessableWords.Add(x);
            }
            currentWord = guessableWords[random.Next(0, guessableWords.Count -1)].ToUpper();
            
            Debug.WriteLine("Current Word: "+currentWord);
            return currentWord;
        }

        public static SolidColorBrush ReturnBrush(byte a, byte b, byte c, byte d)
        {
            Color customColor = Color.FromArgb(a, b, c, d);
            SolidColorBrush customBrush = new SolidColorBrush(DesignGray);
            return customBrush;
        }
        public static void FilterWords()
        {
           
           
        }
    }
}
