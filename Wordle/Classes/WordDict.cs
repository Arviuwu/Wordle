using System.IO;
namespace Wordle.Classes
{
    class WordDict
    {
        static public List<string> words = new List<string> { };
        static public string testWord = "SUPER";
        static public List<char> notContained = new List<char> { };
        static public List<char> yellowChars = new List<char> { };
        static public List<char> correctChars = new List<char> { };

        public static void InitializeDict()
        {
            foreach(var x in File.ReadAllLines("C:\\Users\\jakob\\source\\repos\\Arviuwu\\Wordle\\Wordle\\FIles\\five_letter_words.txt"))
            {
                words.Add(x);
            }
            
        }
        
    }
}
