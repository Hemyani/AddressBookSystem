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
            Console.WriteLine("Welcome To Address Book");
            EditContact edit = new EditContact();
            while (true)
            {
                Console.WriteLine("Please enter a command: ");
                string command = Console.ReadLine();
                Console.WriteLine("Entered Command is " + command);

                if (command == "add")
                {
                    EditContact.AddPerson();
                }
                if (command == "view")
                {
                    EditContact.listPerson();
                }
                if (command == "edit")
                {
                    EditContact.EditPerson();
                }
                if (command == "UniqueBookName")
                {
                    edit.NewUser();
                }

                if (command == "ViewDictionary")
                {
                    edit.Display();
                }
            }
        }
    }
}