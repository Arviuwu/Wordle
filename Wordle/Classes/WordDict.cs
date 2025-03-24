using System.IO;
using System.Diagnostics;
namespace Wordle.Classes
{
    class WordDict
    {
        public WordDict()
        {
            words = new List<string> { };
            testWord = "SUPER";
            notContained = new List<char> { };
            yellowChars = new List<char> { };
            correctChars = new List<char> { };
           PathAllWords = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Files", "five_letter_words.txt");
            PathGuessWords = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Files", "5000-more-common.txt");
            
            currentGuess = string.Empty;
            guessableWords = new List<string>();
            currentWord = string.Empty;
            Random random = new Random();
        }
        static public List<string> words = new List<string> { };
        static public string testWord = "SUPER";
        static public List<char> notContained = new List<char> { };
        static public List<char> yellowChars = new List<char> { };
        static public List<char> correctChars = new List<char> { };
        static public string PathAllWords = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"..","..","..", "Files", "five_letter_words.txt");
        static public string PathGuessWords = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"..","..","..", "Files", "guess_words.txt");
        static public Action? OnLineCompleted;
        static public Action? GameWon;
        static public string? currentGuess;
        static public List<string> guessableWords = new List<string>();
        static public string? currentWord = "0";
        static public Random random = new Random();
        static public Action? StartGameClick;

        public static void InitializeDict()
        {
            foreach(var x in File.ReadAllLines(PathAllWords))
            {
                words.Add(x.ToUpper());
            }
            Debug.WriteLine("dict initialized with " + words.Count()+" words");
        }
        
        public static void WriteDict()
        {
            foreach (var x in words)
            {
               Debug.WriteLine(x);
            }
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
    }
}
