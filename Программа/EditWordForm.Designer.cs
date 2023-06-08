namespace Программа
{
    partial class EditWordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxWord = new TextBox();
            textBoxTranslation = new TextBox();
            buttonOK = new Button();
            buttonCancel = new Button();
            buttonDelete = new Button();
            SuspendLayout();
            // 
            // textBoxWord
            // 
            textBoxWord.Location = new Point(32, 34);
            textBoxWord.Name = "textBoxWord";
            textBoxWord.Size = new Size(271, 23);
            textBoxWord.TabIndex = 0;
            // 
            // textBoxTranslation
            // 
            textBoxTranslation.Location = new Point(32, 79);
            textBoxTranslation.Name = "textBoxTranslation";
            textBoxTranslation.Size = new Size(271, 23);
            textBoxTranslation.TabIndex = 1;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(32, 118);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(75, 23);
            buttonOK.TabIndex = 2;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(228, 118);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(131, 118);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // EditWordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 171);
            Controls.Add(buttonDelete);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Controls.Add(textBoxTranslation);
            Controls.Add(textBoxWord);
            Name = "EditWordForm";
            Text = "Editing";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxWord;
        private TextBox textBoxTranslation;
        private Button buttonOK;
        private Button buttonCancel;
        private Button buttonDelete;
    }
}