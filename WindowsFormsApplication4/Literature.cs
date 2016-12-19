using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WindowsFormsApplication4
{
    [Serializable]
    class Literature:PrintEdition
    {
        public string author;
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public Literature():base(){}
        public Literature(string NameBook,int Year,string auThor):base(NameBook,Year) 
        {
            author = auThor;
        }
        public override string ToString()
        {
            return base.ToString()+"Автор:"+author;
        }
    }

    }

