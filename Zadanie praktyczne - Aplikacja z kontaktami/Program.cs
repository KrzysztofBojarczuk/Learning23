using System;

namespace Zadanie_praktyczne___Aplikacja_z_kontaktami
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from the Phonebook app!");

            Console.WriteLine("1 Add conact");
            Console.WriteLine("2 Display contact by number");
            Console.WriteLine("3 Display all contacts");
            Console.WriteLine("4 Search contacts");
            Console.WriteLine("To exit insert 'x'");

            var userInput = Console.ReadLine();

            var phoneBook = new PhoneBook();

            while(true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Insert number");
                        var number = Console.ReadLine();
                        Console.WriteLine("Insert name");
                        var name = Console.ReadLine();

                        var newConact = new Contact(name, number);

                        phoneBook.AddConact(newConact);

                        break;
                    case "2":
                        Console.WriteLine("Insert number");
                        var numberToSearch = Console.ReadLine();

                        phoneBook.DisplayContact(numberToSearch);

                        break;
                    case "3":
                        phoneBook.DisplayAllContacts();
                        break;
                    case "4":
                        Console.WriteLine("Insert search phrase");
                        var searchPhrase = Console.ReadLine();

                        phoneBook.DisplayMatchingContact(searchPhrase);
                        break;
                    case  "x":
                        return;
                    default:
                        Console.WriteLine("Invalid operation");
                        break;
                }
                Console.WriteLine("Select operation");
                userInput = Console.ReadLine();

            }

           
        }
    }
}
