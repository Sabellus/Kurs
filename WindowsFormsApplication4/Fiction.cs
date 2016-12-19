using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    [Serializable]
    class Fiction:Literature //Художественная литерутура 
    {
        public string genre; //Жанр 
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }
       
        public Fiction():base(){}
        public Fiction(string NameBook, int Date, string Author,string geNRE,string tyPELITER):base(NameBook,Date,Author)
        {
            genre = geNRE;            
        }
        public override string ToString()
        {
            return base.ToString()+"Жанр"+genre;
        }
    }
}
