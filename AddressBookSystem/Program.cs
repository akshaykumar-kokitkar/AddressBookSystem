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
                        addressBook.StoreContact();
                        break;
                    case 2:
                        addressBook.DisplayAllContact();
                        break;
                    case 3:
                        addressBook.EditContact();
                        break;
                    case 4:
                        addressBook.DeleteContact();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("!!! Choose valid operation !!!");
                        break;
                }
                Console.WriteLine("=================================\nChoose the operation:\n1.Add Another Contact.\n2.View Saved Contacts.\n3.Edit Existing Contact.\n4.Delete Existing Contact.\n5.Exit Adress Book Application.\n=================================");
                userInput = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}