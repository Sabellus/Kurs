using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    [Serializable]
    class Newspaper:PeriodicalPublic
    {
        public string territory; 
        public string Territory
        {
            get { return territory; }
            set { territory = value; }
        }
        public Newspaper():base() { }
        public Newspaper(string NameBook, int Date, int numBER, string terRitory) :base(NameBook,Date, numBER) 
        {
            terRitory = territory;
        }
        public override string ToString()
        {
            return base.ToString() + "Номер журнала:" + "Территориальное значение:" + territory;
        }
    }
}
