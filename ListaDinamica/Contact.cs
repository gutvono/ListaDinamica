using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDinamica
{
    internal class Contact
    {
        string name;
        string phone;
        Contact? next;

        public Contact(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
            this.next = null;
        }

        public string GetName() { return this.name; }
        public string GetPhone() { return this.phone; }
        public void SetNext(Contact c) { this.next = c; }
        public Contact GetNext() { return this.next; }
    }
}
