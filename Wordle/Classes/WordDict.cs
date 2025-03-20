using System.IO;
using System.Diagnostics;
namespace Wordle.Classes
{
    class WordDict
    {
        static public List<string> words = new List<string> { };
        static public string testWord = "SUPER";
        static public List<char> notContained = new List<char> { };
        static public List<char> yellowChars = new List<char> { };
        static public List<char> correctChars = new List<char> { };
        static public string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"..","..","..", "Files", "five_letter_words.txt");
        static public Action? OnLineCompleted;
        static public string currentGuess;
        public static void InitializeDict()
        {
            foreach(var x in File.ReadAllLines(filePath))
            {
                words.Add(x.ToUpper());
            }
            
        }
        public static void WriteDict()
        {
            foreach (var x in words)
            {
               Debug.WriteLine(x);
            }
        }
    }
}
