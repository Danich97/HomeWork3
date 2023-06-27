using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneBookLib
{
    public class Contact
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string Adress { get; }
        public string TelephoneNumber { get; set; }




        public Contact(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string ContactToString()
        {
            return $@"
First Name: {FirstName}
Last Name: {LastName}
Telephone Number: {TelephoneNumber}
Adress: {Adress}";
        }
    }
}

