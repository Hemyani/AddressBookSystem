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
            MultiplePerson multiple = new MultiplePerson();
            while (true)
            {
                Console.WriteLine("Please enter a command: ");
                string command = Console.ReadLine();
                Console.WriteLine("Entered Command is " + command);

                if (command == "add")
                {
                    MultiplePerson.AddPerson();
                }
                if (command == "view")
                {
                    MultiplePerson.listPerson();
                }
                if (command == "edit")
                {
                    MultiplePerson.EditPerson();
                }
                if (command == "delete")
                {
                    MultiplePerson.DeleteContact();
                }
                if (command == "AddMultiplePerson")
                {
                    MultiplePerson.MultipleContacts();
                }
                if (command == "UniqueBookName")
                {
                    multiple.NewUser();
                }

                if (command == "ViewDictionary")
                {
                    multiple.Display();
                }
            }
        }
    }
}