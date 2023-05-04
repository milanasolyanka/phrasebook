using System.Windows.Forms;

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

        }

        private void tab2ButtonWord_Click(object sender, EventArgs e)
        {
            string english = tab2TextboxEng.Text;
            string russian = tab2TextboxRu.Text;
            tab2TextboxEng.Text = "";
            tab2TextboxRu.Text = "";

            Word newWord = new Word(english, russian);

            tab2listBox.Items.Add(english + " - " + russian);
        }

        private void tab2ButtonPhrase_Click(object sender, EventArgs e)
        {
            string english = tab2TextboxEng.Text;
            string russian = tab2TextboxRu.Text;
            tab2TextboxEng.Text = "";
            tab2TextboxRu.Text = "";

            Phrase newWord = new Phrase(english, russian);

            tab2listBox.Items.Add(english + " - " + russian);
        }

        private void tab1ButtonWord_Click(object sender, EventArgs e)
        {
            FileManage fm = new FileManage();
            tab1TextboxWords.Text = fm.readFile("words.txt");
        }

        private void tab1TextboxWords_DoubleClick(object sender, EventArgs e)
        {
            if (tab1TextboxWords.Text != "")
            {
                if (tab1TextboxWords.ReadOnly)
                {
                    tab1TextboxWords.BackColor = Color.Bisque;
                }
                else
                {
                    tab1TextboxWords.BackColor = SystemColors.Control;
                }
                tab1TextboxWords.ReadOnly = !tab1TextboxWords.ReadOnly;
            }
            FileManage fm = new FileManage();

            //fm.addLines() tab1TextboxWords.Text;
        }

        private void tab1TextboxPhrases_DoubleClick(object sender, EventArgs e)
        {
        }
    }
}