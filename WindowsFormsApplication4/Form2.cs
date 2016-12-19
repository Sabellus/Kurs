using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();                     
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
         private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString()=="Книги")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(new string[] { "Учебная литература", "Художественная литература", "Научная литература" });
            }
            if(comboBox1.SelectedItem.ToString() == "Журналы и газеты")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(new string[] { "Журналы", "Газеты"});
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            Random rand = new Random();
            
            //if (comboBox2.SelectedItem.ToString() == "Учебная литература")
            //{              
            //    form.book.Add("" + rand.Next(1, 1000000), new EducLiter { Namebook = textBox1.Text, Year = rand.Next(1954,2016), Author = textBox2.Text, Subject = textBox3.Text, Specialty = textBox4.Text });
            //    ICollection<string> keys = book.Keys;

            //        foreach (string f in keys)
            //        {
            //            if (book[f] is EducLiter)
            //            {
            //                form.dataGridView1.Rows.Add(book[f].Namebook, book[f].Year, (book[f] as EducLiter).Author, (book[f] as EducLiter).Subject, (book[f] as EducLiter).Specialty);

            //            }
            //        }

            //}
            if (comboBox2.SelectedItem.ToString() == "Художественная литература")
            {
                
            }
            if (comboBox2.SelectedItem.ToString() == "Научная литература")
            {
                
            }
        }

        public string string1, string2, string3, string4;
        public bool b;
        private void button1_Click(object sender, EventArgs e)
        {
            string1 = textBox1.Text;
            string2 = textBox2.Text;
            string3 = textBox3.Text;
            string4 = textBox4.Text;
            b = true;
        }
    }
}
