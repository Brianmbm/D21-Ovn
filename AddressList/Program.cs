using System.Net.NetworkInformation;

namespace PhoneListApp
{
    public class Contact
    {
        private string name;
        private string adress;
        private string phoneNumber;

        public Contact (string Name, string Adress, string PhoneNumber)
        {
            name = Name ;
            adress = Adress;
            phoneNumber = PhoneNumber;
        }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }

    }
    //List<Contact> contactList = new List<Contact>();
    internal class Program
    {
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

                }
                else if (command == "remove")
                {

                }
                else if (command == "list")
                {

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
        public static void addContact() { }
        public static void removeContact() { }
        public static void listContacts() { }

    }
}

//Mål: vi vill ha en telefonlista som kan innehålla max 10 kontaktadresser, vilket bör implementeras som en lista av objekt. Vi vill att följande operationer skall finnas i telefonlistan:
//lägg till
//ta bort
//lista
//Varje kontakt ska ha ett namn, en adress och ett telefonnummer.

