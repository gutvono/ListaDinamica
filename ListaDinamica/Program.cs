using ListaDinamica;

ContactList lista = new();

Contact contact1 = new("Ana", "123");
lista.Add(contact1);

Contact contact2 = new("Bernardo", "123");
lista.Add(contact2);

Contact contact3 = new("Caua", "123");
lista.Add(contact3);

Contact contact4 = new("Bruna", "123");
lista.Add(contact4);


lista.RemoveByName("Caua");