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
            DeletePerson obj = new DeletePerson();
            while (true)
            {
                Console.WriteLine("Please enter a command: ");
                string command = Console.ReadLine();
                Console.WriteLine("Entered Command is " + command);

                if (command == "add")
                {
                    DeletePerson.AddPerson();
                }
                if (command == "view")
                {
                    DeletePerson.listPerson();
                }
                if (command == "edit")
                {
                    DeletePerson.EditPerson();
                }
                if (command == "delete")
                {
                    DeletePerson.DeleteContact();
                }
                if (command == "UniqueBookName")
                {
                    obj.NewUser();
                }

                if (command == "ViewDictionary")
                {
                    obj.Display();
                }
            }
        }
    }
}