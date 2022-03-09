namespace E_library
{
    partial class BookFile
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.bookName = new System.Windows.Forms.Label();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.formatFile = new System.Windows.Forms.Label();
            this.fb2 = new System.Windows.Forms.RadioButton();
            this.azw = new System.Windows.Forms.RadioButton();
            this.txt = new System.Windows.Forms.RadioButton();
            this.lrf = new System.Windows.Forms.RadioButton();
            this.kf8 = new System.Windows.Forms.RadioButton();
            this.sizeFile = new System.Windows.Forms.Label();
            this.numberOfPage = new System.Windows.Forms.Label();
            this.textBoxSizeFile = new System.Windows.Forms.TextBox();
            this.dateTimeOfDownload = new System.Windows.Forms.DateTimePicker();
            this.publicationDateOfDownload = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.listBoxInfo = new System.Windows.Forms.ListBox();
            this.year = new System.Windows.Forms.Label();
            this.trackBarYear = new System.Windows.Forms.TrackBar();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.buttonAddAuthor = new System.Windows.Forms.Button();
            this.textBoxNumberOfPage = new System.Windows.Forms.TextBox();
            this.buttonAddPublishing = new System.Windows.Forms.Button();
            this.buttonAddXML = new System.Windows.Forms.Button();
            this.buttonOutXML = new System.Windows.Forms.Button();
            this.textBoxOutXML = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxAuthor = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonUpdatePublishing = new System.Windows.Forms.Button();
            this.comboBoxPublishing = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarYear)).BeginInit();
            this.SuspendLayout();
            // 
            // bookName
            // 
            this.bookName.AutoSize = true;
            this.bookName.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookName.Location = new System.Drawing.Point(69, 71);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(152, 22);
            this.bookName.TabIndex = 0;
            this.bookName.Text = "Название книги :";
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Location = new System.Drawing.Point(259, 63);
            this.textBoxBookName.Multiline = true;
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxBookName.Size = new System.Drawing.Size(185, 35);
            this.textBoxBookName.TabIndex = 1;
            this.textBoxBookName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBookName_KeyPress);
            // 
            // formatFile
            // 
            this.formatFile.AutoSize = true;
            this.formatFile.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formatFile.Location = new System.Drawing.Point(213, 222);
            this.formatFile.Name = "formatFile";
            this.formatFile.Size = new System.Drawing.Size(146, 25);
            this.formatFile.TabIndex = 2;
            this.formatFile.Text = "Формат файла :";
            // 
            // fb2
            // 
            this.fb2.AutoSize = true;
            this.fb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fb2.Location = new System.Drawing.Point(117, 261);
            this.fb2.Name = "fb2";
            this.fb2.Size = new System.Drawing.Size(66, 24);
            this.fb2.TabIndex = 3;
            this.fb2.TabStop = true;
            this.fb2.Text = "FB2 ";
            this.fb2.UseVisualStyleBackColor = true;
            // 
            // azw
            // 
            this.azw.AutoSize = true;
            this.azw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.azw.Location = new System.Drawing.Point(189, 261);
            this.azw.Name = "azw";
            this.azw.Size = new System.Drawing.Size(66, 24);
            this.azw.TabIndex = 4;
            this.azw.TabStop = true;
            this.azw.Text = "AZW";
            this.azw.UseVisualStyleBackColor = true;
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt.Location = new System.Drawing.Point(261, 261);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(61, 24);
            this.txt.TabIndex = 5;
            this.txt.TabStop = true;
            this.txt.Text = "TXT";
            this.txt.UseVisualStyleBackColor = true;
            // 
            // lrf
            // 
            this.lrf.AutoSize = true;
            this.lrf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lrf.Location = new System.Drawing.Point(328, 261);
            this.lrf.Name = "lrf";
            this.lrf.Size = new System.Drawing.Size(62, 24);
            this.lrf.TabIndex = 6;
            this.lrf.TabStop = true;
            this.lrf.Text = "LRF";
            this.lrf.UseVisualStyleBackColor = true;
            // 
            // kf8
            // 
            this.kf8.AutoSize = true;
            this.kf8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kf8.Location = new System.Drawing.Point(395, 261);
            this.kf8.Name = "kf8";
            this.kf8.Size = new System.Drawing.Size(60, 24);
            this.kf8.TabIndex = 7;
            this.kf8.TabStop = true;
            this.kf8.Text = "KF8";
            this.kf8.UseVisualStyleBackColor = true;
            // 
            // sizeFile
            // 
            this.sizeFile.AutoSize = true;
            this.sizeFile.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeFile.Location = new System.Drawing.Point(125, 331);
            this.sizeFile.Name = "sizeFile";
            this.sizeFile.Size = new System.Drawing.Size(142, 22);
            this.sizeFile.TabIndex = 8;
            this.sizeFile.Text = "Размер файла :";
            // 
            // numberOfPage
            // 
            this.numberOfPage.AutoSize = true;
            this.numberOfPage.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfPage.Location = new System.Drawing.Point(324, 320);
            this.numberOfPage.Name = "numberOfPage";
            this.numberOfPage.Size = new System.Drawing.Size(109, 44);
            this.numberOfPage.TabIndex = 9;
            this.numberOfPage.Text = "Количество\r\n   страниц :";
            // 
            // textBoxSizeFile
            // 
            this.textBoxSizeFile.Location = new System.Drawing.Point(122, 376);
            this.textBoxSizeFile.Multiline = true;
            this.textBoxSizeFile.Name = "textBoxSizeFile";
            this.textBoxSizeFile.Size = new System.Drawing.Size(145, 26);
            this.textBoxSizeFile.TabIndex = 12;
            this.textBoxSizeFile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSizeFile_KeyPress);
            // 
            // dateTimeOfDownload
            // 
            this.dateTimeOfDownload.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimeOfDownload.Location = new System.Drawing.Point(281, 434);
            this.dateTimeOfDownload.Name = "dateTimeOfDownload";
            this.dateTimeOfDownload.Size = new System.Drawing.Size(174, 22);
            this.dateTimeOfDownload.TabIndex = 13;
            // 
            // publicationDateOfDownload
            // 
            this.publicationDateOfDownload.AutoSize = true;
            this.publicationDateOfDownload.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicationDateOfDownload.Location = new System.Drawing.Point(113, 434);
            this.publicationDateOfDownload.Name = "publicationDateOfDownload";
            this.publicationDateOfDownload.Size = new System.Drawing.Size(139, 22);
            this.publicationDateOfDownload.TabIndex = 14;
            this.publicationDateOfDownload.Text = "Дата загрузки :";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(218, 712);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(114, 43);
            this.buttonClear.TabIndex = 21;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(700, 265);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(115, 43);
            this.buttonView.TabIndex = 23;
            this.buttonView.Text = "Сохранить";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // listBoxInfo
            // 
            this.listBoxInfo.FormattingEnabled = true;
            this.listBoxInfo.ItemHeight = 16;
            this.listBoxInfo.Location = new System.Drawing.Point(591, 52);
            this.listBoxInfo.Name = "listBoxInfo";
            this.listBoxInfo.Size = new System.Drawing.Size(333, 180);
            this.listBoxInfo.TabIndex = 25;
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year.Location = new System.Drawing.Point(69, 120);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(125, 22);
            this.year.TabIndex = 19;
            this.year.Text = "Год издания :";
            // 
            // trackBarYear
            // 
            this.trackBarYear.Location = new System.Drawing.Point(34, 163);
            this.trackBarYear.Maximum = 2022;
            this.trackBarYear.Minimum = 1900;
            this.trackBarYear.Name = "trackBarYear";
            this.trackBarYear.Size = new System.Drawing.Size(511, 56);
            this.trackBarYear.TabIndex = 27;
            this.trackBarYear.Value = 1900;
            this.trackBarYear.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(259, 120);
            this.textBoxYear.Multiline = true;
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(145, 26);
            this.textBoxYear.TabIndex = 28;
            // 
            // buttonAddAuthor
            // 
            this.buttonAddAuthor.Location = new System.Drawing.Point(115, 537);
            this.buttonAddAuthor.Name = "buttonAddAuthor";
            this.buttonAddAuthor.Size = new System.Drawing.Size(152, 42);
            this.buttonAddAuthor.TabIndex = 29;
            this.buttonAddAuthor.Text = "Добавить автора";
            this.buttonAddAuthor.UseVisualStyleBackColor = true;
            this.buttonAddAuthor.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxNumberOfPage
            // 
            this.textBoxNumberOfPage.Location = new System.Drawing.Point(309, 376);
            this.textBoxNumberOfPage.Multiline = true;
            this.textBoxNumberOfPage.Name = "textBoxNumberOfPage";
            this.textBoxNumberOfPage.Size = new System.Drawing.Size(146, 26);
            this.textBoxNumberOfPage.TabIndex = 11;
            this.textBoxNumberOfPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumberOfPage_KeyPress);
            // 
            // buttonAddPublishing
            // 
            this.buttonAddPublishing.Location = new System.Drawing.Point(117, 637);
            this.buttonAddPublishing.Name = "buttonAddPublishing";
            this.buttonAddPublishing.Size = new System.Drawing.Size(152, 43);
            this.buttonAddPublishing.TabIndex = 30;
            this.buttonAddPublishing.Text = "Добавить издательство";
            this.buttonAddPublishing.UseVisualStyleBackColor = true;
            this.buttonAddPublishing.Click += new System.EventHandler(this.buttonAddPublishing_Click);
            // 
            // buttonAddXML
            // 
            this.buttonAddXML.Location = new System.Drawing.Point(700, 336);
            this.buttonAddXML.Name = "buttonAddXML";
            this.buttonAddXML.Size = new System.Drawing.Size(115, 43);
            this.buttonAddXML.TabIndex = 31;
            this.buttonAddXML.Text = "Записать в XML";
            this.buttonAddXML.UseVisualStyleBackColor = true;
            this.buttonAddXML.Click += new System.EventHandler(this.buttonAddXML_Click);
            // 
            // buttonOutXML
            // 
            this.buttonOutXML.Location = new System.Drawing.Point(700, 409);
            this.buttonOutXML.Name = "buttonOutXML";
            this.buttonOutXML.Size = new System.Drawing.Size(115, 43);
            this.buttonOutXML.TabIndex = 32;
            this.buttonOutXML.Text = "Вывод из XML";
            this.buttonOutXML.UseVisualStyleBackColor = true;
            this.buttonOutXML.Click += new System.EventHandler(this.buttonOutXML_Click);
            // 
            // textBoxOutXML
            // 
            this.textBoxOutXML.Location = new System.Drawing.Point(591, 474);
            this.textBoxOutXML.Multiline = true;
            this.textBoxOutXML.Name = "textBoxOutXML";
            this.textBoxOutXML.Size = new System.Drawing.Size(333, 267);
            this.textBoxOutXML.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 22);
            this.label2.TabIndex = 34;
            this.label2.Text = "Выберите автора";
            // 
            // comboBoxAuthor
            // 
            this.comboBoxAuthor.FormattingEnabled = true;
            this.comboBoxAuthor.Location = new System.Drawing.Point(281, 495);
            this.comboBoxAuthor.Name = "comboBoxAuthor";
            this.comboBoxAuthor.Size = new System.Drawing.Size(174, 24);
            this.comboBoxAuthor.TabIndex = 35;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(281, 537);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(174, 42);
            this.buttonUpdate.TabIndex = 36;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonUpdatePublishing
            // 
            this.buttonUpdatePublishing.Location = new System.Drawing.Point(281, 637);
            this.buttonUpdatePublishing.Name = "buttonUpdatePublishing";
            this.buttonUpdatePublishing.Size = new System.Drawing.Size(174, 43);
            this.buttonUpdatePublishing.TabIndex = 39;
            this.buttonUpdatePublishing.Text = "Обновить";
            this.buttonUpdatePublishing.UseVisualStyleBackColor = true;
            this.buttonUpdatePublishing.Click += new System.EventHandler(this.buttonUpdatePublishing_Click);
            // 
            // comboBoxPublishing
            // 
            this.comboBoxPublishing.FormattingEnabled = true;
            this.comboBoxPublishing.Location = new System.Drawing.Point(281, 598);
            this.comboBoxPublishing.Name = "comboBoxPublishing";
            this.comboBoxPublishing.Size = new System.Drawing.Size(174, 24);
            this.comboBoxPublishing.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 598);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 22);
            this.label3.TabIndex = 37;
            this.label3.Text = "Выберите автора";
            // 
            // BookFile
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1003, 806);
            this.Controls.Add(this.buttonUpdatePublishing);
            this.Controls.Add(this.comboBoxPublishing);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.comboBoxAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxOutXML);
            this.Controls.Add(this.buttonOutXML);
            this.Controls.Add(this.buttonAddXML);
            this.Controls.Add(this.buttonAddPublishing);
            this.Controls.Add(this.buttonAddAuthor);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.trackBarYear);
            this.Controls.Add(this.listBoxInfo);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.year);
            this.Controls.Add(this.publicationDateOfDownload);
            this.Controls.Add(this.dateTimeOfDownload);
            this.Controls.Add(this.textBoxSizeFile);
            this.Controls.Add(this.textBoxNumberOfPage);
            this.Controls.Add(this.numberOfPage);
            this.Controls.Add(this.sizeFile);
            this.Controls.Add(this.kf8);
            this.Controls.Add(this.lrf);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.azw);
            this.Controls.Add(this.fb2);
            this.Controls.Add(this.formatFile);
            this.Controls.Add(this.textBoxBookName);
            this.Controls.Add(this.bookName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookFile";
            this.Text = "BookFile";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bookName;
        private System.Windows.Forms.Label formatFile;
        private System.Windows.Forms.RadioButton fb2;
        private System.Windows.Forms.RadioButton azw;
        private System.Windows.Forms.RadioButton txt;
        private System.Windows.Forms.RadioButton lrf;
        private System.Windows.Forms.RadioButton kf8;
        private System.Windows.Forms.Label sizeFile;
        private System.Windows.Forms.Label numberOfPage;
        private System.Windows.Forms.TextBox textBoxSizeFile;
        private System.Windows.Forms.DateTimePicker dateTimeOfDownload;
        private System.Windows.Forms.Label publicationDateOfDownload;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonView;
        public System.Windows.Forms.ListBox listBoxInfo;
        public System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.TrackBar trackBarYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Button buttonAddAuthor;
        private System.Windows.Forms.TextBox textBoxNumberOfPage;
        private System.Windows.Forms.Button buttonAddPublishing;
        private System.Windows.Forms.Button buttonAddXML;
        private System.Windows.Forms.Button buttonOutXML;
        private System.Windows.Forms.TextBox textBoxOutXML;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox comboBoxAuthor;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonUpdatePublishing;
        public System.Windows.Forms.ComboBox comboBoxPublishing;
        private System.Windows.Forms.Label label3;
    }
}

