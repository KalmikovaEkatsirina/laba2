using System;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Linq;
using System.Collections.Generic;

namespace E_library
{
    
    public partial class BookFile : Form
    {
        public string Size { get; set; }
        public string Book { get; set; }

        BookFilesClass bookFilesClass = new BookFilesClass();

        public BookFile()
        {
            Program.bookFile = this;
            InitializeComponent();            
            this.Book =textBoxBookName.Text;
            this.Size = textBoxSizeFile.Text;
            
        }

        public void textBoxBookName_KeyPress(object sender, KeyPressEventArgs e)
        {
            bookFilesClass.inputLetters(e);
        }

        private void textBoxPublishingHouse_KeyPress(object sender, KeyPressEventArgs e)
        {
            bookFilesClass.inputLetters(e);
        }

        private void textBoxSizeFile_KeyPress(object sender, KeyPressEventArgs e)
        {
            bookFilesClass.inputNumber(e);
        }

        private void textBoxNumberOfPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            bookFilesClass.inputNumber(e);
        }

        private void textBoxYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            bookFilesClass.inputNumber(e);
        }           

        private void buttonClear_Click(object sender, EventArgs e)
        {
            bookFilesClass.Clear(textBoxBookName, fb2, txt, lrf, azw, kf8, textBoxNumberOfPage, textBoxSizeFile, dateTimeOfDownload,comboBoxPublishing);
        }     
        
        public void buttonView_Click(object sender, EventArgs e)
        {
           bookFilesClass.AddListBox(listBoxInfo,textBoxBookName,comboBoxAuthor,textBoxYear,fb2, txt, lrf, azw,kf8, textBoxNumberOfPage, textBoxSizeFile,dateTimeOfDownload,comboBoxPublishing);

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            bookFilesClass.checkYear(textBoxYear, trackBarYear);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bookFilesClass.openNewForm();
        }

        private void buttonAddXML_Click(object sender, EventArgs e)
        {
            bookFilesClass.AddXML(listBoxInfo);
        }

        private void buttonOutXML_Click(object sender, EventArgs e)
        {
            bookFilesClass.OutXML(textBoxOutXML);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bookFilesClass.updateAuthor(comboBoxAuthor);
        }

        private void buttonAddPublishing_Click(object sender, EventArgs e)
        {
            bookFilesClass.openFormPublishing();
        }

        private void buttonUpdatePublishing_Click(object sender, EventArgs e)
        {
            bookFilesClass.updatePublishing(comboBoxPublishing);
        }
    }
}
