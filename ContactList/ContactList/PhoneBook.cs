using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList
{
    public class PhoneBook
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>();

        public PhoneBook() { }

        public PhoneBook(List<Contact> contacts)
        {
            Contacts=contacts;
        }


        public void addContact(Contact contact)
        {
            if(Contacts.Count > 250)
            {
                foreach (Contact con in Contacts)
                {
                    if (con.getName().Equals(contact.getName()))
                    {
                        throw new Exception("The name exist");
                    }
                    else
                    {
                        Contacts.Add(con);
                        Console.WriteLine("The contact was added");
                    }
                }
            }
            else
            {
                throw new Exception("Full list");
            }
        }


        public Contact getContactForName(string name)
        {
            Contact contact = null;

            for(int i = 0; i < Contacts.Count; i++)
            {
                if (name.Equals(Contacts[i].getName()))
                {
                    contact= Contacts[i];
                }
                
               
            }
            return contact;

        }

        public int numberOfContacts()
        {
            return Contacts.Count;
        }

        public List<Contact> getContact()
        {
            return Contacts.OrderBy(x=>x.getName()).ToList();
        }


        public bool removeContact(String name)
        {
            Contact contact = Contacts.Where(x=>x.getName().Equals(name)).FirstOrDefault();

            if(contact != null)
            {
                Contacts.Remove(contact);
                return true;
            }
            else
            {
                return false;
            }
        }


        public void ToString()
        {
            List<Contact>  contacts = Contacts.OrderBy(x => x.getName()).ToList();

            foreach (Contact contact in contacts)
            {
                Console.WriteLine($"{contact.getName()} {contact.Surname} {contact.Address}");
            }
        }

        public List<Contact> getContactsForNumber(String number_prefix)
        {
            List<Contact> contacts = new List<Contact>();

            for(int i = 0; i<Contacts.Count; i++)
            {
                if (Contacts[i].PhoneNumbers.Count != 0)


                for(int j = 0; j<Contacts[i].PhoneNumbers.Count; j++)
                {

                    if (Contacts[i].PhoneNumbers[j].StartsWith(number_prefix))
                    {
                        contacts.Add(Contacts[i]);
                        break;
                    }

                }


            }
            return contacts.OrderBy(x => x.getName()).ToList();

        }




    }
}
