 using System.Reflection;

namespace Программа
{
    public class Word
    {
        public string WordText { get; set; } // Поле для хранения слова
        public string Translation { get; set; } // Поле для хранения перевода

        public Word(string wordText, string translation)
        {
            WordText = wordText;
            Translation = translation;
        }
    }

    public class FileHandler
    {
        string mainPath = Environment.CurrentDirectory + "\\WordContents\\";

        public void WriteToFile(string fileName, List<Word> words)
        {
            using (StreamWriter writer = new StreamWriter(mainPath + fileName))
            {
                foreach (Word word in words)
                {
                    writer.WriteLine($"{word.WordText}:{word.Translation}");
                }
            }
        }

        public List<Word> ReadFromFile(string fileName)
        {
            List<Word> words = new List<Word>();
            

            using (StreamReader reader = new StreamReader(mainPath + fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(':');
                    if (parts.Length == 2)
                    {
                        string word = parts[0].Trim();
                        string translation = parts[1].Trim();
                        Word newWord = new Word(word, translation);
                        words.Add(newWord);
                    }
                }
            }

            return words;
        }
    }

    public class Dictionary
    {
        private List<Word> words; // Поле для хранения списка слов
        string mainPath = Environment.CurrentDirectory + "\\WordContents\\";

        public Dictionary()
        {
            words = new List<Word>();
        }

        public void AddWord(string word, string translation)
        {
            Word newWord = new Word(word, translation);
            words.Add(newWord);
        }

        public void RemoveWord(string word)
        {
            Word wordToRemove = words.Find(w => w.WordText.Equals(word, StringComparison.OrdinalIgnoreCase));
            if (wordToRemove != null)
            {
                words.Remove(wordToRemove);
            }
        }

        public void EditWord(string word, string newWord, string newTranslation)
        {
            Word wordToEdit = words.Find(w => w.WordText.Equals(word, StringComparison.OrdinalIgnoreCase));
            if (wordToEdit != null)
            {
                wordToEdit.WordText = newWord;
                wordToEdit.Translation = newTranslation;
            }
        }

        public string ConvertToStringList()
        {
            List<string> wordList = new List<string>();
            foreach (Word word in words)
            {
                string wordString = $"{word.WordText} - {word.Translation}";
                wordList.Add(wordString);
            }
            string concatenatedString = string.Join(Environment.NewLine, wordList);
            return concatenatedString;
        }


        public void SaveToFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(mainPath + fileName))
            {
                foreach (Word word in words)
                {
                    writer.WriteLine($"{word.WordText}:{word.Translation}");
                }
            }
        }

        public void LoadFromFile(string fileName)
        {
            words.Clear(); // Очистить текущий список слов

            using (StreamReader reader = new StreamReader(mainPath + fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(':');
                    if (parts.Length == 2)
                    {
                        string word = parts[0].Trim();
                        string translation = parts[1].Trim();
                        AddWord(word, translation);
                    }
                }
            }
        }
        public void SortWords()
        {
            words.Sort((w1, w2) => w1.WordText.CompareTo(w2.WordText));
        }

        public int CountWords()
        {
            return words.Count;
        }
    }

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new mainForm());
        }
    }
}