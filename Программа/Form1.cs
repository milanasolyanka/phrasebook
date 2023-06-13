using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Программа
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            updateTextboxes();
        }

        private void tab2ButtonWord_Click(object sender, EventArgs e)
        {
            string english = tab2TextboxEng.Text;
            string russian = tab2TextboxRu.Text;
            tab2TextboxEng.Text = "";
            tab2TextboxRu.Text = "";

            Dictionary wordList = new Dictionary();
            wordList.LoadFromFile("words.txt");
            wordList.AddWord(english, russian);
            wordList.SaveToFile("words.txt");

            tab2listBox.Items.Add(english + " - " + russian);
        }

        private void tab2ButtonPhrase_Click(object sender, EventArgs e)
        {
            string english = tab2TextboxEng.Text;
            string russian = tab2TextboxRu.Text;
            tab2TextboxEng.Text = "";
            tab2TextboxRu.Text = "";

            Dictionary wordList = new Dictionary();
            wordList.LoadFromFile("phrases.txt");
            wordList.AddWord(english, russian);
            wordList.SaveToFile("phrases.txt");

            tab2listBox.Items.Add(english + " - " + russian);
        }

        private void updateTextboxes()
        {
            Dictionary wordList = new Dictionary();
            wordList.LoadFromFile("words.txt");
            wordList.SortWords();
            tab1LabelCountWords.Text = $"Words ({wordList.CountWords()})";
            tab1TextboxWords.Text = wordList.ConvertToStringList();

            wordList.LoadFromFile("phrases.txt");
            wordList.SortWords();
            tab1LabelCountPhrases.Text = $"Phrases ({wordList.CountWords()})";
            tab1TextboxPhrases.Text = wordList.ConvertToStringList();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabPage1)
            {
                updateTextboxes();
            }
        }

        private void tab1TextboxWords_DoubleClick(object sender, EventArgs e)
        {
            int index = tab1TextboxWords.GetLineFromCharIndex(tab1TextboxWords.SelectionStart);
            string selectedLine = tab1TextboxWords.Lines[index];
            Dictionary wordList = new Dictionary();
            wordList.LoadFromFile("words.txt");

            if (selectedLine.Contains(" - "))
            {
                string[] parts = selectedLine.Split(new string[] { " - " }, StringSplitOptions.None);
                string word = parts[0];
                string translation = parts[1];

                // Открываем форму редактирования слова и перевода
                EditWordForm editForm = new EditWordForm(word, translation);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // Получаем отредактированное слово и перевод из формы
                    string editedWord = editForm.EditedWord;
                    string editedTranslation = editForm.EditedTranslation;

                    // Вызываем метод EditWord для обновления слова и перевода в словаре
                    wordList.EditWord(word, editedWord, editedTranslation);
                    wordList.SaveToFile("words.txt");

                    // Обновляем текст в TextBox
                    updateTextboxes();
                }
                else if (editForm.DialogResult == DialogResult.Abort)
                {
                    wordList.RemoveWord(word);
                    wordList.SaveToFile("words.txt");
                    updateTextboxes();
                }
            }
        }

        private void tab1TextboxPhrases_DoubleClick(object sender, EventArgs e)
        {
            int index = tab1TextboxPhrases.GetLineFromCharIndex(tab1TextboxPhrases.SelectionStart);
            string selectedLine = tab1TextboxPhrases.Lines[index];
            Dictionary wordList = new Dictionary();
            wordList.LoadFromFile("phrases.txt");

            if (selectedLine.Contains(" - "))
            {
                string[] parts = selectedLine.Split(new string[] { " - " }, StringSplitOptions.None);
                string word = parts[0];
                string translation = parts[1];

                // Открываем форму редактирования слова и перевода
                EditWordForm editForm = new EditWordForm(word, translation);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // Получаем отредактированное слово и перевод из формы
                    string editedWord = editForm.EditedWord;
                    string editedTranslation = editForm.EditedTranslation;

                    // Вызываем метод EditWord для обновления слова и перевода в словаре
                    wordList.EditWord(word, editedWord, editedTranslation);
                    wordList.SaveToFile("phrases.txt");

                    // Обновляем текст в TextBox
                    updateTextboxes();
                }
                else if (editForm.DialogResult == DialogResult.Abort)
                {
                    wordList.RemoveWord(word);
                    wordList.SaveToFile("phrases.txt");
                    updateTextboxes();
                }
            }
        }

        private void tab1ButtonSearch_Click(object sender, EventArgs e)
        {
            // Очистка выделения в текстовых полях
            tab1TextboxWords.SelectionStart = 0;
            tab1TextboxWords.SelectionLength = 0;

            tab1TextboxPhrases.SelectionStart = 0;
            tab1TextboxPhrases.SelectionLength = 0;

            string searchWord = tab1TextBoxSearch.Text.Trim(); // Получение слова для поиска

            // Поиск совпадений в тексте и выделение их
            if (!string.IsNullOrEmpty(searchWord))
            {
                // Поиск совпадений в tab1TextboxWords
                int wordIndex = tab1TextboxWords.Text.IndexOf(searchWord, StringComparison.OrdinalIgnoreCase);
                if (wordIndex >= 0)
                {
                    tab1TextboxWords.SelectionStart = wordIndex;
                    tab1TextboxWords.SelectionLength = searchWord.Length;
                    tab1TextboxWords.Focus(); // Установка фокуса на TextBox с найденным словом
                }
                else
                {
                    // Поиск совпадений в tab1TextboxPhrases
                    int phraseIndex = tab1TextboxPhrases.Text.IndexOf(searchWord, StringComparison.OrdinalIgnoreCase);
                    if (phraseIndex >= 0)
                    {
                        tab1TextboxPhrases.SelectionStart = phraseIndex;
                        tab1TextboxPhrases.SelectionLength = searchWord.Length;
                        tab1TextboxPhrases.Focus(); // Установка фокуса на TextBox с найденной фразой
                    }
                    else
                    {
                        MessageBox.Show("Key word is not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Please, fill in the search field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}