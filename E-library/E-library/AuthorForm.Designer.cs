namespace E_library
{
    partial class AuthorForm
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
            this.NameAuthor = new System.Windows.Forms.Label();
            this.listBook = new System.Windows.Forms.Button();
            this.textBoxNameAthor = new System.Windows.Forms.TextBox();
            this.Language = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.checkBoxEnglish = new System.Windows.Forms.CheckBox();
            this.checkBoxRussian = new System.Windows.Forms.CheckBox();
            this.checkBoxBel = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // NameAuthor
            // 
            this.NameAuthor.AutoSize = true;
            this.NameAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameAuthor.Location = new System.Drawing.Point(63, 42);
            this.NameAuthor.Name = "NameAuthor";
            this.NameAuthor.Size = new System.Drawing.Size(114, 20);
            this.NameAuthor.TabIndex = 30;
            this.NameAuthor.Text = "ФИО автора";
            // 
            // listBook
            // 
            this.listBook.Location = new System.Drawing.Point(219, 277);
            this.listBook.Name = "listBook";
            this.listBook.Size = new System.Drawing.Size(185, 29);
            this.listBook.TabIndex = 35;
            this.listBook.Text = "Добавить автора\r\n\r\n\r\n\r\n";
            this.listBook.UseVisualStyleBackColor = true;
            this.listBook.Click += new System.EventHandler(this.listBook_Click);
            // 
            // textBoxNameAthor
            // 
            this.textBoxNameAthor.Location = new System.Drawing.Point(204, 40);
            this.textBoxNameAthor.Multiline = true;
            this.textBoxNameAthor.Name = "textBoxNameAthor";
            this.textBoxNameAthor.Size = new System.Drawing.Size(335, 22);
            this.textBoxNameAthor.TabIndex = 36;
            this.textBoxNameAthor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNameAthor_KeyPress);
            // 
            // Language
            // 
            this.Language.AutoSize = true;
            this.Language.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Language.Location = new System.Drawing.Point(215, 94);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(170, 20);
            this.Language.TabIndex = 37;
            this.Language.Text = "Владение языками";
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.City.Location = new System.Drawing.Point(54, 212);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(178, 20);
            this.City.TabIndex = 38;
            this.City.Text = "Страна проживания";
            // 
            // checkBoxEnglish
            // 
            this.checkBoxEnglish.AutoSize = true;
            this.checkBoxEnglish.Location = new System.Drawing.Point(67, 143);
            this.checkBoxEnglish.Name = "checkBoxEnglish";
            this.checkBoxEnglish.Size = new System.Drawing.Size(106, 20);
            this.checkBoxEnglish.TabIndex = 39;
            this.checkBoxEnglish.Text = "Английский";
            this.checkBoxEnglish.UseVisualStyleBackColor = true;
            // 
            // checkBoxRussian
            // 
            this.checkBoxRussian.AutoSize = true;
            this.checkBoxRussian.Location = new System.Drawing.Point(257, 143);
            this.checkBoxRussian.Name = "checkBoxRussian";
            this.checkBoxRussian.Size = new System.Drawing.Size(83, 20);
            this.checkBoxRussian.TabIndex = 40;
            this.checkBoxRussian.Text = "Русский";
            this.checkBoxRussian.UseVisualStyleBackColor = true;
            // 
            // checkBoxBel
            // 
            this.checkBoxBel.AutoSize = true;
            this.checkBoxBel.Location = new System.Drawing.Point(424, 143);
            this.checkBoxBel.Name = "checkBoxBel";
            this.checkBoxBel.Size = new System.Drawing.Size(115, 20);
            this.checkBoxBel.TabIndex = 41;
            this.checkBoxBel.Text = "Белорусский";
            this.checkBoxBel.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Россия",
            "Украина",
            "Беларусь"});
            this.comboBox1.Location = new System.Drawing.Point(277, 212);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(262, 24);
            this.comboBox1.TabIndex = 42;
            // 
            // AuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 327);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBoxBel);
            this.Controls.Add(this.checkBoxRussian);
            this.Controls.Add(this.checkBoxEnglish);
            this.Controls.Add(this.City);
            this.Controls.Add(this.Language);
            this.Controls.Add(this.textBoxNameAthor);
            this.Controls.Add(this.listBook);
            this.Controls.Add(this.NameAuthor);
            this.Name = "AuthorForm";
            this.Text = "Author";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NameAuthor;
        private System.Windows.Forms.Button listBook;
        private System.Windows.Forms.TextBox textBoxNameAthor;
        private System.Windows.Forms.Label Language;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.CheckBox checkBoxEnglish;
        private System.Windows.Forms.CheckBox checkBoxRussian;
        private System.Windows.Forms.CheckBox checkBoxBel;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}