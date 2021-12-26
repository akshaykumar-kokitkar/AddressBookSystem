using System;
using System.Collections.Generic;
namespace AddressBookTrail
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the operation:\n1.Add Contact.\n2.View Contact Info.\n3.Exit Adress Book Application.");
            int userInput = Convert.ToInt32(Console.ReadLine());
            var addressBook = new AddressBook();

            while (true)
            {
                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("First Name:");
                        string firstname = (Console.ReadLine());
                        Console.WriteLine("Last Name:");
                        string lastname = Console.ReadLine();
                        Console.WriteLine("Address:");
                        string address = Console.ReadLine();
                        Console.WriteLine("City:");
                        string city = Console.ReadLine();
                        Console.WriteLine("State:");
                        string state = Console.ReadLine();
                        Console.WriteLine("Zip Code:");
                        string zipcode = Console.ReadLine();
                        Console.WriteLine("Phone Number:");
                        string phonenumber = Console.ReadLine();
                        Console.WriteLine("Email:");
                        string email = Console.ReadLine();
                        var newContact = new Contact(firstname, lastname, address, city, state, zipcode, phonenumber, email);
                        addressBook.AddContact(newContact);
                        break;
                    case 2:
                        addressBook.DisplayAllContact();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Choose valid operation.");
                        break;

                }
                Console.WriteLine("Choose the operation:\n1.Add Contact.\n2.View Contact Info.\n3.Exit Adress Book Application.\n=================================");
                userInput = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}