using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDinamica
{
    internal class ContactList
    {
        Contact? head;
        Contact? tail;

        public ContactList()
        {
            this.head = null;
            this.tail = null;
        }

        public void Add(Contact contact)
        {
            if (IsEmpty()) this.head = this.tail = contact;
            else
            {
                int comparison = string.Compare(contact.GetName(), this.head.GetName(), comparisonType: StringComparison.OrdinalIgnoreCase);

                if (comparison <= 0)
                {
                    Contact aux = this.head;
                    this.head = aux;
                    this.head.SetNext(aux);
                }
                else
                {
                    Contact aux = this.head;
                    Contact prev = this.head;

                    do
                    {
                        comparison = string.Compare(contact.GetName(), aux.GetName(), comparisonType: StringComparison.OrdinalIgnoreCase);
                        if (comparison > 0)
                        {
                            prev = aux;
                            aux = aux.GetNext();
                        }
                    } while (comparison > 0 && aux != null);

                    prev.SetNext(contact);
                    contact.SetNext(aux);

                    if (aux == null) this.tail = contact;
                }
            }
        }

        public void RemoveByName(string name)
        {
            if (IsEmpty()) Console.WriteLine("Lista já está vazia.");
            else if (this.head.GetName() == name)
            {
                if (head == tail) this.head = this.tail = null;
                else this.head = this.head.GetNext();
            }
            else
            {
                Contact aux = this.head, prev = this.head;
                bool compare;
                do
                {
                    compare = name.Equals(aux.GetName());
                    if (aux.GetName() != name)
                    {
                        prev = aux;
                        aux = aux.GetNext();
                    }
                    else
                    {
                        prev.SetNext(aux.GetNext());
                        if (prev.GetNext() == null) this.tail = prev;
                    }
                } while (aux != null && compare == false);
            }
        }

        bool IsEmpty() { return this.head == null; }
    }
}
