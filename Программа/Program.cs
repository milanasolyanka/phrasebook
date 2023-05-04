using System.Reflection;

namespace Программа
{
    internal class WordContent
    {
        //public Guid id;
        protected string contentEng;
        protected string contentRu;

        public WordContent(string contentEng, string contentRu)
        {
            this.contentEng = contentEng;
            this.contentRu = contentRu;
            //this.id = Guid.NewGuid();
        }

        public void setContentEng(string newContentEng)
        {
            this.contentEng = newContentEng;
        }
        public void setContentRu(string newContentRu) 
        {
            this.contentRu = newContentRu;
        }
        public string getContentEng()
        {
            return this.contentEng;
        }
        public string getContentRu()
        {
            return this.contentRu;
        }

        public override string ToString()
        {
            return this.contentEng + " - " + this.contentRu;
        }
    }

    internal class Word : WordContent
    {
        public Word(string contentEng, string contentRu) : base(contentEng, contentRu)
        {
        }
    }

    internal class Phrase : WordContent
    {
        public Phrase(string contentEng, string contentRu) : base(contentEng, contentRu)
        {
        }
    }

    internal class FileManage
    {
        private string mainPath = Environment.CurrentDirectory + "\\WordContents\\";

        public string readFile(string filename)
        {
            return File.ReadAllText(mainPath + filename);
        }

        public void addLine(string filename, WordContent phrase)
        {
            File.AppendAllText(mainPath + filename, phrase.ToString());
        }

        public void addLines(string filename, WordContent[] array) 
        {
            List<string> list = new List<string>();
            foreach (WordContent listitem in array)
            {
                list.Add(listitem.ToString());
            }
            File.WriteAllLines(mainPath + filename, list);
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