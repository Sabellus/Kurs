using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    [Serializable]
    abstract class PrintEdition //Книги
    {
        public string namebook; //Имя книги        
        public int year; //Год издания
        private int date;

        public string Namebook
        {
            get { return namebook; }
            set { namebook = value; }
        }
        
        public int Year
        {
            get { return year; }
            set { year = value; }
        } 
        public PrintEdition()
        {
            namebook = "Крутая книга";
            year= 0000;
        }
        
        public PrintEdition(string nameBook, int yeAr)
        {
            namebook = nameBook;
            year = yeAr;
        }

        public override string ToString()
        {
            return "Название книги:" + namebook+"Год:"+year;
        }

    }
}
