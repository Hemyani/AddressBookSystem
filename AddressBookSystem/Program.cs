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
            Create person = new Create();
            while (true)
            {
                Console.WriteLine("Please enter a command: ");
                string command = Console.ReadLine();
                Console.WriteLine("Entered Command is " + command);

                if (command == "add")
                {
                    Create.AddPerson();
                }
                if (command == "view")
                {
                    Create.listPerson();
                }

                if (command == "ViewDictionary")
                {
                    person.Display();
                }
            }
        }
    }
}