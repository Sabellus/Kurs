using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    [Serializable]
    class PeriodicalPublic:PrintEdition //Журналы 
    {
        public  int number; //Номер издания 
           public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public PeriodicalPublic():base() { }
        public PeriodicalPublic(string NameBook, int Date,int NUMber):base(NameBook,Date) 
        {
            NUMber = number;        
        }
        public override string ToString()
        {
            return base.ToString()+"Номер журнала:"+number;
        }

    }
}
