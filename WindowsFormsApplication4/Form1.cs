using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace WindowsFormsApplication4
{

    public partial class Form1 : Form
    {
        bool coll = false;
        string typebook = "";        
        public Form2 form2 = new Form2();
        SortedDictionary <string,MyCollection> printlit = new SortedDictionary<string,MyCollection>();
        MyCollection book = new MyCollection();
        MyCollection jorgazet = new MyCollection();
        Journal journal1 = new Journal();

        public Form1()
        {           
            InitializeComponent();
            //book.Add("N", new EducLiter { Namebook = "Основы теории цепей", Year = 2011, Author = "Кулютникова", Subject = "Электротехника", Specialty = "Все" });
            //book.Add("L", new EducLiter { Namebook = "С# 4.0", Year = 2012, Author = "Шилд", Subject = "Программирование", Specialty = "АСУ" });
            //book.Add("A", new Fiction { Namebook = "Евгений Онегин", Year = 2012, Author = "Пушкин", Genre = "Повесть" });
            //jorgazet.Add("y", new Jor { Namebook = "Playboy", Year = 2016, Number = 1, Themes = "Эротика" });
            //jorgazet.Add("Y", new Newspaper { Namebook = "Аргументы и факты", Year = 2016, Number = 356, Territory = "Федеральное" });
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            //book.Add("N", new EducLiter { Namebook = "Основы теории цепей", Year = 2011, Author = "Кулютникова", Subject = "Электротехника", Specialty = "Все" });
            //book.Add("L", new EducLiter { Namebook = "С# 4.0", Year = 2012, Author = "Шилд", Subject = "Программирование", Specialty = "АСУ" });
            //book.Add("A", new Fiction { Namebook = "Евгений Онегин", Year = 2012, Author = "Пушкин", Genre = "Повесть" });
            if (coll == true)
            {
                printlit.Add("1", book);
                printlit.Add("2", jorgazet);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_ResizeEnd(Object sender, EventArgs e)
        {

            MessageBox.Show("You are in the Form.ResizeEnd event.");

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form2.ShowDialog();
           
        }


        private void ProvGrid(DataGridView grid) //Удаление Грида
        {
            int q = grid.Columns.Count;
            if (q > 0)
            {
                do
                {
                    grid.Columns.Remove(grid.Columns[grid.Columns.Count - 1].Name);
                    q--;
                } while (q != 0);
            }
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            typebook = "";
            ProvGrid(dataGridView1);
            if (e.Node.Text == "Книги")
            {
                
                dataGridView1.Columns.Add("column1", "Название");
                dataGridView1.Columns.Add("column2", "Дата");
                ICollection<string> keys = book.Keys;
                foreach (string i in keys)
                {
                    dataGridView1.Rows.Add(book[i].Namebook, book[i].Year);
                }

                typebook = e.Node.Text;
            }

            if (e.Node.Text == "Журналы и газеты")
            {
                ProvGrid(dataGridView1);
                dataGridView1.Columns.Add("column1", "Название");
                dataGridView1.Columns.Add("column2", "Дата");
                dataGridView1.Columns.Add("column3", "Номер журнала");
                ICollection<string> keys = jorgazet.Keys;
                foreach (string f in keys)
                {
                    if (jorgazet[f] is PeriodicalPublic)
                    {
                        dataGridView1.Rows.Add(jorgazet[f].Namebook, jorgazet[f].Year, (jorgazet[f] as PeriodicalPublic).number);
                    }
                }
                typebook = e.Node.Text;

            }
            if (e.Node.Text == "Журналы")
            {
                ProvGrid(dataGridView1);
                dataGridView1.Columns.Add("column1", "Название");
                dataGridView1.Columns.Add("column2", "Дата");
                dataGridView1.Columns.Add("column3", "Номер журнала");
                dataGridView1.Columns.Add("column4", "Тематика");
                ICollection<string> keys = jorgazet.Keys;
                foreach (string f in keys)
                {
                    if (jorgazet[f] is Jor)
                    {
                        dataGridView1.Rows.Add(jorgazet[f].Namebook, jorgazet[f].Year, (jorgazet[f] as Jor).number, (jorgazet[f] as Jor).themes);
                    }
                }
                typebook = e.Node.Text;

            }
            if (e.Node.Text == "Газеты")
            {
                ProvGrid(dataGridView1);
                dataGridView1.Columns.Add("column1", "Название");
                dataGridView1.Columns.Add("column2", "Дата");
                dataGridView1.Columns.Add("column3", "Номер журнала");
                dataGridView1.Columns.Add("column4", "Территориальное значение");
                ICollection<string> keys = jorgazet.Keys;
                foreach (string f in keys)
                {
                    if (jorgazet[f] is Newspaper)
                    {
                        dataGridView1.Rows.Add(jorgazet[f].Namebook, jorgazet[f].Year, (jorgazet[f] as Newspaper).number, (jorgazet[f] as Newspaper).territory);
                    }
                }
                typebook = e.Node.Text;

            }
            if (e.Node.Text == "Учебная литература")
            {
                ProvGrid(dataGridView1);
                dataGridView1.Columns.Add("column1", "Название");
                dataGridView1.Columns.Add("column2", "Дата");
                dataGridView1.Columns.Add("column3", "Автор");
                dataGridView1.Columns.Add("column4", "Предмет");
                dataGridView1.Columns.Add("column5", "Специальность");
                ICollection<string> keys = book.Keys;
                foreach (string f in keys)
                {
                    if (book[f] is EducLiter)
                    {

                        dataGridView1.Rows.Add(book[f].Namebook, book[f].Year, (book[f] as EducLiter).Author, (book[f] as EducLiter).Subject, (book[f] as EducLiter).Specialty);
                    }
                }
                typebook = e.Node.Text;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {


        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            coll = true;
            int i = 0;
            if (e.Button == MouseButtons.Left)
            {
                form2.ShowDialog();
                
            }
            Random rand = new Random();
            if (e.Button == MouseButtons.Right)
            {       

                i++;
                if  (typebook == "Учебная литература")
                {
                    dataGridView1.Rows.Clear();
                    book.Add(""+rand.Next(1,1000000), RandomPrintEdition.Random_Lit_Method());
                    ICollection<string> keys = book.Keys;
                    
                       foreach (string f in keys)
                    {
                        if (book[f] is EducLiter)
                        {
                            dataGridView1.Rows.Add(book[f].Namebook, book[f].Year, (book[f] as EducLiter).Author, (book[f] as EducLiter).Subject, (book[f] as EducLiter).Specialty);
                          
                        }
                    }
                    
                }
                if(typebook =="Журналы")
                {
                    dataGridView1.Rows.Clear();
                    jorgazet.Add("" + rand.Next(1, 100000), RandomPrintEdition.Random_Per_Method());
                    ICollection<string> keys = jorgazet.Keys;
                    foreach(string f in keys)
                    {
                        if (jorgazet[f] is Jor)
                        {
                            dataGridView1.Rows.Add(jorgazet[f].Namebook, jorgazet[f].Year, (jorgazet[f] as Jor).Number, (jorgazet[f] as Jor).Themes);
                        }
                    }
                }
            }

            //if (e.Node.Text == "Книги")
            //    {
            //        MessageBox.Show("Книги");
            //    }
            //    if (e.Node.Text == "Журналы и газеты")
            //    {
            //        MessageBox.Show("Журналы и газеты");
            //    }
            //    if (e.Node.Text == "Учебная литература")
            //    {
            //        MessageBox.Show("Учебная литература");
            //    }
        }              
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
                
                if (typebook == "Учебная литература")
                {                    
                   book.Remove(book.ElementAt(dataGridView1.CurrentRow.Index).Key);                    
                }
                if (typebook == "Журналы")
                {
                   jorgazet.Remove(jorgazet.ElementAt(dataGridView1.CurrentRow.Index).Key);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate);
            formatter.Serialize(fs, printlit);
            MessageBox.Show("Объект сериализован");
            
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        void Update_Coll_List()
        {
                    
            
        }
        SortedDictionary<string, MyCollection> temp = new SortedDictionary<string, MyCollection>();
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            FileStream fs = new FileStream("people.dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            printlit = (SortedDictionary<string,MyCollection>)bf.Deserialize(fs);
            ICollection<string> keys = printlit.Keys;
            foreach (string i in keys)
            {
                book = printlit["1"];
                jorgazet = printlit["2"];
                ICollection<string> keys1 = printlit[i].Keys;
                foreach(string j in keys1)
                {
                    //MessageBox.Show((printlit[i][j] as EducLiter).Specialty);//
                }
            }
            fs.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
           
        }
    }
    
}
