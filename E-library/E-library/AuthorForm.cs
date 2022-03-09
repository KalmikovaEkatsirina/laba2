using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_library
{
    public partial class AuthorForm : Form
    {
        BookFilesClass BookFilesClass = new BookFilesClass();
        

        public AuthorForm()
        {
            InitializeComponent();
                        
        }   

        public void listBook_Click(object sender, EventArgs e)
        {
            BookFilesClass.AddName(textBoxNameAthor);         
                   
        }

        private void textBoxNameAthor_KeyPress(object sender, KeyPressEventArgs e)
        {
            BookFilesClass.inputLetters(e);
        }
    }
}
