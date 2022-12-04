using AddressBookSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book ");
            NewContact user = new NewContact();
            while (true)
            {
                Console.WriteLine("Please enter a command: ");
                string command = Console.ReadLine();
                Console.WriteLine("Entered Command is " + command);

                if (command == "add")
                {
                    NewContact.AddPerson();
                }
                if (command == "view")
                {
                    NewContact.listPerson();
                }
                if (command == "UniqueBookName")
                {
                    user.NewUser();
                }

                if (command == "ViewDictionary")
                {
                    user.Display();
                }
            }
        }
    }
}