using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace E_library
{
    public class BookFilesClass
    {
        List<string> listName = new List<string>();
        List<string> listPublishing = new List<string>();

        public void inputLetters(KeyPressEventArgs e)
        {
            char letters = e.KeyChar;
            if ((letters < 'А' || letters > 'я') && (letters < 'A' || letters > 'z') && letters != '\b' && letters != '.')
            {
                e.Handled = true;
            }
        }
        public  void inputNumber(KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 45) // цифры , клавиша BackSpace и минус
            {
                e.Handled = true;
            }
        }
        public void checkYear(TextBox textBox, TrackBar trackBar)
        {
            textBox.Text = String.Format($"{trackBar.Value}");
        }
        public void openNewForm()
        {
            AuthorForm form = new AuthorForm();
            form.ShowDialog();
            form.Hide();
        }
        public void openFormPublishing()
        {
            PublishingForm form = new PublishingForm();
            form.ShowDialog();
            form.Hide();
        }
        public void AddXML(ListBox listBox)
        {
            XElement doc2 = new XElement("doc",
           new XElement("txt1", listBox.Items));
            doc2.Save(@"D:\file.xml");
        }
        public void OutXML(TextBox text)
        {
            XDocument myDoc = XDocument.Load(@"D:\file.xml");
            string s = myDoc.Descendants("txt1").First().Value;
            text.Text = s;
        }

       public void Clear(TextBox n, RadioButton fb2, RadioButton txt,RadioButton lrf, RadioButton azw, RadioButton kf8,TextBox k,TextBox s, DateTimePicker d ,ComboBox p)
        {
            if(n.Text == "" && fb2.Checked == false && txt.Checked == false && lrf.Checked == false && azw.Checked == false && kf8.Checked == false && k.Text == "" && s.Text == "" && d.Text == "" && p.Text == "")
            {
                MessageBox.Show("Все поля очищены");
            }
            else
            {
                n.Text = "";               
                fb2.Checked = false;
                txt.Checked = false;
                lrf.Checked = false;
                azw.Checked = false;
                kf8.Checked = false;
                k.Text = "";
                s.Text = "";
                d.Text = "";
                p.Text = "";
            }
        }

        

        public void AddName(TextBox text)
        {
            listName.Add(text.Text);
            StreamWriter sw = new StreamWriter(@"D:\Name.txt");
            foreach(string s in listName)
            { sw.WriteLine(s); }
            
            sw.Close();

        }
        public void AddPublishing(TextBox text)
        {
            listPublishing.Add(text.Text);
            StreamWriter sw = new StreamWriter(@"D:\Publishing.txt");
            foreach (string s in listPublishing)
            { sw.WriteLine(s); }

            sw.Close();

        }      

        public void updateAuthor(ComboBox comboBox)
        {
           
         comboBox.Items.AddRange(File.ReadAllLines(@"D:\Name.txt"));

        }

        public void updatePublishing(ComboBox comboBox)
        {

            comboBox.Items.AddRange(File.ReadAllLines(@"D:\Publishing.txt"));

        }
        public void AddListBox(ListBox list, TextBox name, ComboBox author,TextBox year,RadioButton fb2,RadioButton azw,RadioButton txt,RadioButton lrf,RadioButton kf8,TextBox size,TextBox page, DateTimePicker date,ComboBox publishing )
        {
            list.Items.Add($"Название книги :{name.Text}");
            list.Items.Add($"Издательство : {publishing.Text}");
            list.Items.Add($"Год издания : {year.Text}");
            list.Items.Add($"Автор : {author.Text}");

            if (fb2.Checked) { list.Items.Add($"Формат :{fb2.Text} "); }
            if (azw.Checked) { list.Items.Add($"Формат :{azw.Text} "); }
            if (txt.Checked) { list.Items.Add($"Формат :{txt.Text} "); }
            if (lrf.Checked) { list.Items.Add($"Формат :{lrf.Text} "); }
            if (kf8.Checked) { list.Items.Add($"Формат :{kf8.Text} "); }

            list.Items.Add($"Размер файла : {size.Text}");
            list.Items.Add($"Количество страниц : {page.Text}");
            list.Items.Add($"Дата загрузки : {date.Text}");
        }
    }
}
