using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    class CollectionHandlerEventArgs
    {
        public string name { get; }
        public string changes { get; }
        public PrintEdition data { get; }

        public CollectionHandlerEventArgs(string name, string changes, PrintEdition data)
        {
            this.name = name;
            this.changes = changes;
            this.data = data;
        }
    }
}
