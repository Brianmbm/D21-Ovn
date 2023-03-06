using System.Net.NetworkInformation;

namespace PhoneListApp
{
    
    internal class Program
    {
        static List<Contact> contactList = new List<Contact>();
        public class Contact
        {
            
            private string name;
            private string address;
            private int phoneNumber;

            public Contact(string Name, string Address, int PhoneNumber)
            {
                name = Name;
                address = Address;
                phoneNumber = PhoneNumber;
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public string Address
            {
                get { return address; }
                set { address = value; }
            }

            public int PhoneNumber
            {
                get { return phoneNumber; }
                set { phoneNumber = value; }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the phone list.");
            Console.WriteLine("Write help to get help!");
            string command;
            do
            {
                Console.Write("Commmand: ");
                command = Console.ReadLine();
                if (command == "Help")
                {
                    Console.WriteLine($"Command not implemented!");
                }
                else if (command == "add")
                {
                    addContact();
                }
                else if (command == "remove")
                {
                    removeContact();
                }
                else if (command == "list")
                {
                    listContacts();
                }
                else if(command == "quit")
                {

                }
                else
                {
                    Console.WriteLine($"Unknown command: {command}");
                }
            } while (command != "quit");
            Console.WriteLine("Bye!");
        }
        public static void addContact() {
            Console.Write("Person's name: ");
            string name = Console.ReadLine();

            Console.Write("Address: ");
            string address = Console.ReadLine();

            Console.Write("Phone number: ");
            int phoneNumber = Int32.Parse(Console.ReadLine());

            Contact newcontact = new Contact(name, address, phoneNumber);
            contactList.Add(newcontact);

            Console.WriteLine($"Added {newcontact.Name} {newcontact.Address}{newcontact.PhoneNumber}.");
        }
        public static void removeContact() { }
        public static void listContacts() {
            foreach (Contact a in contactList)
            {
                Console.WriteLine($"{a.Name} {a.Address} {a.PhoneNumber}");
            }
        }

    }
}

//Mål: vi vill ha en telefonlista som kan innehålla max 10 kontaktadresser, vilket bör implementeras som en lista av objekt. Vi vill att följande operationer skall finnas i telefonlistan:

