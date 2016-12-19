using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    [Serializable]
    class Jor:PeriodicalPublic
    {
        public string themes; 
        public string Themes
        {
            get { return themes; }
            set { themes = value; }
        }
        public Jor():base() { }
        public Jor(string NameBook, int Date, int numBER,string theEmes):base(NameBook,Date, numBER) 
        {
            theEmes = themes;
        }
        public override string ToString()
        {
            return base.ToString() + "Номер журнала:" + "Тематика:"+themes;
        }
    }
}
