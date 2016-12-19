using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    class JournalEntry
    {

        public string name { get; }
        public string changes { get; }
        public PrintEdition data { get; }

        public JournalEntry(string name, string changes, PrintEdition data)
        {
            this.name = name;
            this.changes = changes;
            this.data = data;
        }

        public override string ToString()
        {
            return string.Format("В отделе '{0}' {1} элемент {2}", name, changes, data.Namebook);
        }
    }
}
