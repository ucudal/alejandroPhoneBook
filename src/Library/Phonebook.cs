using System.Collections.Generic;

namespace Library
{
    public class Phonebook
    {
        public Phonebook(Contact owner)
        {
            this.Owner = owner;
            this.persons = new List<Contact>();
        }
        public Contact Owner { get; }
        private List<Contact> persons;

        public void SendMessage(string text, string[] name, IMessageChannel channel)
        {
            foreach (Contact receiver in Search(name))
            {
                Message message= new Message(this.Owner.Name, receiver.Name);
                message.Text= text;
                channel.Send(message,receiver);
            }
        }
        public void Add(string name)
        {
            Contact contact= new Contact(name);
            this.persons.Add(contact);
        }

        public void Remove(Contact contact)
        {
            this.persons.Remove(contact);
        }


        public List<Contact> Search(string[] names)
        {
            List<Contact> result = new List<Contact>();

            foreach (Contact person in this.persons)
            {
                foreach (string name in names)
                {
                    if (person.Name.Equals(name))
                    {
                        result.Add(person);
                    }
                }
            }

            return result;
        }
    }
}