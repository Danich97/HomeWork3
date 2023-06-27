using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneBookLib
{
    public class TelephoneBookClass
    {
        private List<Contact> _listOfContacts = new List<Contact>();

        public void AddContact()
        {
            Console.Write("Enter First Name: ");
            var firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            var lastName = Console.ReadLine();

            Console.Write("Enter Telephone Number: ");
            var telephoneNumber = Console.ReadLine();

            Console.Write("Enter Adress: ");
            var adress = Console.ReadLine();

            _listOfContacts.Add(new Contact(firstName, lastName)
            {
                TelephoneNumber = telephoneNumber,
                Adress = adress
        });
        }

        public void SearchContactByPhone(string phone)
        {
            Console.WriteLine();
            foreach (var contact in _listOfContacts)
            {
                if (contact.TelephoneNumber == phone)
                {
                    Console.WriteLine(contact.ContactToString());
                    Console.WriteLine();
                }
            }
        }

        public void SearchContactByFirstName(string FirstName)
        {
            Console.WriteLine();
            foreach (var contact in _listOfContacts)
            {
                if (contact.FirstName == FirstName)
                {
                    Console.WriteLine(contact.ContactToString());
                    Console.WriteLine();
                }
            }
        }
        public void DisplayAllContacts()
        {
            foreach (var contact in _listOfContacts)
            {
                Console.WriteLine(contact.ContactToString());
                Console.WriteLine();
            }
        }
    }
}
