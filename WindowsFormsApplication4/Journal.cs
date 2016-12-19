using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    class Journal
    {
        public List<JournalEntry> entries = new List<JournalEntry>();

        public void AddEntry(object source, CollectionHandlerEventArgs args)
        {
            entries.Add(new JournalEntry(args.name, args.changes, args.data));
        }

        public override string ToString()
        {
            string str = "";
            foreach (var a in entries)
            {
                str += a + "\n";
            }
            return str;
        }
    }
}
