using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Программа
{
    public partial class EditWordForm : Form
    {
        public string EditedWord { get; set; }
        public string EditedTranslation { get; set; }

        public EditWordForm(string word, string translation)
        {
            InitializeComponent();

            // Инициализация текстовых полей значением текущего слова и перевода
            textBoxWord.Text = word;
            textBoxTranslation.Text = translation;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            // Получение отредактированного слова и перевода из текстовых полей
            EditedWord = textBoxWord.Text;
            EditedTranslation = textBoxTranslation.Text;

            // Проверка, что оба поля заполнены
            if (!string.IsNullOrWhiteSpace(EditedWord) && !string.IsNullOrWhiteSpace(EditedTranslation))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Please, fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure that you want to delete this word?", "Deleting word", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DialogResult = DialogResult.Abort; // Возвращаем другой результат, чтобы указать удаление слова
                Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }

}
