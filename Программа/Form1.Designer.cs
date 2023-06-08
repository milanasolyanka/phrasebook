namespace Программа
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            tab1LabelCountPhrases = new Label();
            tab1ButtonSearch = new Button();
            tab1TextBoxSearch = new TextBox();
            tab1LabelSearch = new Label();
            tab1LabelCountWords = new Label();
            tab1TextboxPhrases = new RichTextBox();
            tab1TextboxWords = new RichTextBox();
            tabPage2 = new TabPage();
            tab2listBox = new ListBox();
            tab2ButtonPhrase = new Button();
            tab2ButtonWord = new Button();
            tab2LabelRu = new Label();
            tab2TextboxRu = new TextBox();
            tab2LabelEng = new Label();
            tab2TextboxEng = new TextBox();
            tabPage3 = new TabPage();
            tab3Label3 = new Label();
            tab3Label2 = new Label();
            tab3Label1 = new Label();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(tabPage3);
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(704, 475);
            tabControl.TabIndex = 0;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tab1LabelCountPhrases);
            tabPage1.Controls.Add(tab1ButtonSearch);
            tabPage1.Controls.Add(tab1TextBoxSearch);
            tabPage1.Controls.Add(tab1LabelSearch);
            tabPage1.Controls.Add(tab1LabelCountWords);
            tabPage1.Controls.Add(tab1TextboxPhrases);
            tabPage1.Controls.Add(tab1TextboxWords);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(696, 447);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dictionary";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tab1LabelCountPhrases
            // 
            tab1LabelCountPhrases.AutoSize = true;
            tab1LabelCountPhrases.Location = new Point(23, 249);
            tab1LabelCountPhrases.Name = "tab1LabelCountPhrases";
            tab1LabelCountPhrases.Size = new Size(80, 15);
            tab1LabelCountPhrases.TabIndex = 8;
            tab1LabelCountPhrases.Text = "CountPhrases";
            // 
            // tab1ButtonSearch
            // 
            tab1ButtonSearch.Location = new Point(351, 31);
            tab1ButtonSearch.Name = "tab1ButtonSearch";
            tab1ButtonSearch.Size = new Size(75, 23);
            tab1ButtonSearch.TabIndex = 7;
            tab1ButtonSearch.Text = "Search";
            tab1ButtonSearch.UseVisualStyleBackColor = true;
            tab1ButtonSearch.Click += tab1ButtonSearch_Click;
            // 
            // tab1TextBoxSearch
            // 
            tab1TextBoxSearch.Location = new Point(23, 31);
            tab1TextBoxSearch.Name = "tab1TextBoxSearch";
            tab1TextBoxSearch.Size = new Size(299, 23);
            tab1TextBoxSearch.TabIndex = 6;
            // 
            // tab1LabelSearch
            // 
            tab1LabelSearch.AutoSize = true;
            tab1LabelSearch.Location = new Point(23, 13);
            tab1LabelSearch.Name = "tab1LabelSearch";
            tab1LabelSearch.Size = new Size(124, 15);
            tab1LabelSearch.TabIndex = 5;
            tab1LabelSearch.Text = "Search word or phrase";
            // 
            // tab1LabelCountWords
            // 
            tab1LabelCountWords.AutoSize = true;
            tab1LabelCountWords.Location = new Point(23, 75);
            tab1LabelCountWords.Name = "tab1LabelCountWords";
            tab1LabelCountWords.Size = new Size(74, 15);
            tab1LabelCountWords.TabIndex = 4;
            tab1LabelCountWords.Text = "CountWords";
            // 
            // tab1TextboxPhrases
            // 
            tab1TextboxPhrases.BackColor = SystemColors.Window;
            tab1TextboxPhrases.BorderStyle = BorderStyle.None;
            tab1TextboxPhrases.Location = new Point(23, 267);
            tab1TextboxPhrases.Name = "tab1TextboxPhrases";
            tab1TextboxPhrases.ReadOnly = true;
            tab1TextboxPhrases.Size = new Size(667, 132);
            tab1TextboxPhrases.TabIndex = 3;
            tab1TextboxPhrases.Text = "PhrasesTB";
            tab1TextboxPhrases.DoubleClick += tab1TextboxPhrases_DoubleClick;
            // 
            // tab1TextboxWords
            // 
            tab1TextboxWords.BackColor = SystemColors.Window;
            tab1TextboxWords.BorderStyle = BorderStyle.None;
            tab1TextboxWords.Location = new Point(23, 93);
            tab1TextboxWords.Name = "tab1TextboxWords";
            tab1TextboxWords.ReadOnly = true;
            tab1TextboxWords.ScrollBars = RichTextBoxScrollBars.Vertical;
            tab1TextboxWords.Size = new Size(667, 132);
            tab1TextboxWords.TabIndex = 2;
            tab1TextboxWords.Text = "WordsTB";
            tab1TextboxWords.DoubleClick += tab1TextboxWords_DoubleClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tab2listBox);
            tabPage2.Controls.Add(tab2ButtonPhrase);
            tabPage2.Controls.Add(tab2ButtonWord);
            tabPage2.Controls.Add(tab2LabelRu);
            tabPage2.Controls.Add(tab2TextboxRu);
            tabPage2.Controls.Add(tab2LabelEng);
            tabPage2.Controls.Add(tab2TextboxEng);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(696, 447);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Add new";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tab2listBox
            // 
            tab2listBox.BorderStyle = BorderStyle.None;
            tab2listBox.FormattingEnabled = true;
            tab2listBox.ItemHeight = 15;
            tab2listBox.Location = new Point(21, 172);
            tab2listBox.Name = "tab2listBox";
            tab2listBox.Size = new Size(670, 240);
            tab2listBox.TabIndex = 6;
            // 
            // tab2ButtonPhrase
            // 
            tab2ButtonPhrase.Location = new Point(147, 120);
            tab2ButtonPhrase.Name = "tab2ButtonPhrase";
            tab2ButtonPhrase.Size = new Size(120, 23);
            tab2ButtonPhrase.TabIndex = 5;
            tab2ButtonPhrase.Text = "Add as phrase";
            tab2ButtonPhrase.UseVisualStyleBackColor = true;
            tab2ButtonPhrase.Click += tab2ButtonPhrase_Click;
            // 
            // tab2ButtonWord
            // 
            tab2ButtonWord.Location = new Point(21, 120);
            tab2ButtonWord.Name = "tab2ButtonWord";
            tab2ButtonWord.Size = new Size(120, 23);
            tab2ButtonWord.TabIndex = 4;
            tab2ButtonWord.Text = "Add as word";
            tab2ButtonWord.UseVisualStyleBackColor = true;
            tab2ButtonWord.Click += tab2ButtonWord_Click;
            // 
            // tab2LabelRu
            // 
            tab2LabelRu.AutoSize = true;
            tab2LabelRu.Location = new Point(21, 62);
            tab2LabelRu.Name = "tab2LabelRu";
            tab2LabelRu.Size = new Size(92, 15);
            tab2LabelRu.TabIndex = 3;
            tab2LabelRu.Text = "Word in Russian";
            // 
            // tab2TextboxRu
            // 
            tab2TextboxRu.Location = new Point(21, 80);
            tab2TextboxRu.Name = "tab2TextboxRu";
            tab2TextboxRu.Size = new Size(650, 23);
            tab2TextboxRu.TabIndex = 2;
            // 
            // tab2LabelEng
            // 
            tab2LabelEng.AutoSize = true;
            tab2LabelEng.Location = new Point(21, 14);
            tab2LabelEng.Name = "tab2LabelEng";
            tab2LabelEng.Size = new Size(90, 15);
            tab2LabelEng.TabIndex = 1;
            tab2LabelEng.Text = "Word in English";
            // 
            // tab2TextboxEng
            // 
            tab2TextboxEng.Location = new Point(21, 32);
            tab2TextboxEng.Name = "tab2TextboxEng";
            tab2TextboxEng.Size = new Size(650, 23);
            tab2TextboxEng.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(tab3Label3);
            tabPage3.Controls.Add(tab3Label2);
            tabPage3.Controls.Add(tab3Label1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(696, 447);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "About";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tab3Label3
            // 
            tab3Label3.AutoSize = true;
            tab3Label3.Location = new Point(323, 284);
            tab3Label3.Name = "tab3Label3";
            tab3Label3.Size = new Size(42, 15);
            tab3Label3.TabIndex = 2;
            tab3Label3.Text = "2023 г.";
            // 
            // tab3Label2
            // 
            tab3Label2.AutoSize = true;
            tab3Label2.Location = new Point(211, 152);
            tab3Label2.Name = "tab3Label2";
            tab3Label2.Size = new Size(275, 15);
            tab3Label2.TabIndex = 1;
            tab3Label2.Text = "Разработано в рамках курсовой работы по ООП";
            // 
            // tab3Label1
            // 
            tab3Label1.AutoSize = true;
            tab3Label1.Location = new Point(233, 212);
            tab3Label1.Name = "tab3Label1";
            tab3Label1.Size = new Size(228, 15);
            tab3Label1.TabIndex = 0;
            tab3Label1.Text = "Разработчик: Тупейко Милана, гр. 421-1";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 455);
            Controls.Add(tabControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "mainForm";
            Text = "Разговорник";
            Load += mainForm_Load;
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label tab3Label1;
        private Label tab3Label2;
        private Label tab3Label3;
        private TextBox tab2TextboxEng;
        private Label tab2LabelRu;
        private TextBox tab2TextboxRu;
        private Label tab2LabelEng;
        private Button tab2ButtonWord;
        private Button tab2ButtonPhrase;
        private ListBox tab2listBox;
        private RichTextBox tab1TextboxPhrases;
        private RichTextBox tab1TextboxWords;
        private Label tab1LabelCountWords;
        private Button tab1ButtonSearch;
        private TextBox tab1TextBoxSearch;
        private Label tab1LabelSearch;
        private Label tab1LabelCountPhrases;
    }
}