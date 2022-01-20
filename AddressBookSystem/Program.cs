using System;

namespace AddressBookTrail
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to Address Book.");
            Console.WriteLine("=================================\nChoose the operation:\n1.Add Contact.\n2.View Saved Contacts.\n3.Edit Existing Contact.\n4.Delete Existing Contact.\n5.Duplicate Checker.\n6.Search Person.\n7.Find City/State.\n8.Find Number Of Persons..\n9.Sort Entries.\n10.Convert To Text.\n11.Convert To Csv.\n12.Convert To Json.\n13.Exit Adress Book Application.\n=================================");
            var userInput = Console.ReadLine();
            var addressBook = new AddressBook();

            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        addressBook.StoreContact();
                        break;
                    case "2":
                        addressBook.DisplayAllContact();
                        break;
                    case "3":
                        addressBook.EditContact();
                        break;
                    case "4":
                        addressBook.DeleteContact();
                        break;
                    case "5":
                        addressBook.DuplicateChecker();
                        break;
                    case "6":
                        addressBook.SearchPerson();
                        break;
                    case "7":
                        addressBook.FindCityState();
                        break;
                    case "8":
                        addressBook.FindNumOfPerson();
                        break;
                    case "9":
                        addressBook.ChooseSort();
                        break;
                    case "10":
                        addressBook.ConvertToText();
                        break;
                    case "11":
                        addressBook.ConvertToCsv();
                        break;
                    case "12":
                        addressBook.ConvertToJson();
                        break;
                    case "13":
                        return;

                    default:
                        Console.WriteLine("!!! Choose valid operation !!!");
                        break;
                }
                Console.WriteLine("=================================\nChoose the operation:\n1.Add Another Contact.\n2.View Saved Contacts.\n3.Edit Existing Contact.\n4.Delete Existing Contact.\n5.Duplicate Checker.\n6.Search Person.\n7.FindCity/State.\n8.Find Number Of Persons..\n9.Sort Entries.\n10.Convert To Text.\n11.Convert To Csv.\n12.Convert To Json.\n13.Exit Address Book Application.\n=================================");
                userInput = Console.ReadLine();
            }
        }
    }
}