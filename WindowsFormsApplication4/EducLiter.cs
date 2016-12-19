using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    [Serializable]
    class EducLiter:Literature //Учебная литература
    {
        string subject; //Предмет 
        string specialty; //Для какой специальности предназначен 
        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }
        public string Specialty
        {
            get{ return specialty; }
            set { specialty = value; }
        }
        public EducLiter():base() { }
        public EducLiter(string NameBook, int Date, string Author, string suBJECT, string spECIALTY) : base(NameBook, Date,Author)
        {
            subject = suBJECT;
            specialty = spECIALTY;
        }
        public override string ToString()
        {
            return base.ToString()+"Предмет:"+subject+"Специальность"+specialty;
        }
    }
}
