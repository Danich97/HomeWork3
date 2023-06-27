using TelephoneBookLib;

namespace TelephoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TelephoneBookClass telephoneBook = new TelephoneBookClass();

            while (true)
            {
                Console.WriteLine("Select action:");
                Console.WriteLine("1. Add new contact:");
                Console.WriteLine("2. Search by phone number");
                Console.WriteLine("3. Search by name");
                Console.WriteLine("4. Display all contacts");

                var action = Console.ReadLine();

                switch (action)
                {
                    case "1":
                        telephoneBook.AddContact();
                        break;
                    case "2":
                        Console.Write("Enter phone number to search: ");
                        var phoneNumberToSearch = Console.ReadLine();
                        telephoneBook.SearchContactByPhone(phoneNumberToSearch);
                        break;
                    case "3":
                        Console.Write("Enter first name to search: ");
                        var nameToSearch = Console.ReadLine();
                        telephoneBook.SearchContactByFirstName(nameToSearch);
                        break;
                    case "4":
                        telephoneBook.DisplayAllContacts();
                        break;
                    default:
                        break;
                }
            }
            
            
            
        }
    }
}