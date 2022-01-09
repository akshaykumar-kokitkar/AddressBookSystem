using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookTrail
{
    class AddressBook
    {
        private List<Contact> List { get; set; } = new List<Contact>();
        public void AddContact(Contact contact)
        {
            List.Add(contact);
        }

        public Dictionary<string, Contact> DictName = new Dictionary<string, Contact>();

        public void StoreContact()
        {
            Console.WriteLine("Enter a unique name to your Addressbook:");
            string addressbookName = Console.ReadLine();
            Console.WriteLine("First Name:");
            string firstname = Console.ReadLine();
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
            DictName.Add(addressbookName, newContact);
        }
        public void DisplayAllContact()
        {
            foreach (var element in DictName)
            {
<<<<<<< HEAD
                Console.WriteLine("----------------\nADDRESSBOOK :\n----------------\nAddressbook Key: " + element.Key + "\nPerson's Name: " + element.Value.FirstName + " " + element.Value.LastName + "\nAddress: " + element.Value.Address + "\nCity: " + element.Value.City + "\nState: " + element.Value.State + "\nZip Code: " + element.Value.ZipCode + "\nPhone Number: " + element.Value.PhoneNumber + "\nEmail: " + element.Value.Email);
            }
        }
        public void EditContact()
=======
                Console.WriteLine("\n CONTACT :\n" + contact.FirstName + " " + contact.LastName + "\nAddress: " + contact.Address + "\nCity: " + contact.City + "\nState: " + contact.State + "\nZip Code: " + contact.ZipCode + "\nPhone Number: " + contact.PhoneNumber + "\nEmail: " + contact.Email);

            }
        }
        public void EditContact(string personName)
>>>>>>> UC5-AddMultiple-Contacts
        {
            Console.WriteLine("Available Addressbooks are:: ");
            foreach (var key in DictName)
            {
<<<<<<< HEAD
                Console.WriteLine(key.Key + "\n----------------");
            }
            Console.WriteLine("------------------\nEnter Name of the AddressBook you want to edit:: ");
            string dictName = Console.ReadLine();

            foreach (var element in DictName)
            {
                if (element.Key == dictName)
=======
                if (contact.FirstName == personName)
>>>>>>> UC5-AddMultiple-Contacts
                {
                    Console.WriteLine("Enter new First Name");
                    string newFirstName = Console.ReadLine();
                    element.Value.FirstName = newFirstName;
                    Console.WriteLine("Enter new Last Name:");
                    string newLastName = Console.ReadLine();
                    element.Value.LastName = newLastName;
                    Console.WriteLine("Enter new Address:");
                    string newAddress = Console.ReadLine();
                    element.Value.Address = newAddress;
                    Console.WriteLine("Enter new City:");
                    string newCity = Console.ReadLine();
                    element.Value.City = newCity;
                    Console.WriteLine("Enter new State:");
                    string newState = Console.ReadLine();
                    element.Value.State = newState;
                    Console.WriteLine("Enter new Zip Code:");
                    string newZipcode = Console.ReadLine();
                    element.Value.ZipCode = newZipcode;
                    Console.WriteLine("Enter new Phone Number:");
                    string newPhonenumber = Console.ReadLine();
                    element.Value.PhoneNumber = newPhonenumber;
                    Console.WriteLine("Enter new Email:");
                    string newEmail = Console.ReadLine();
<<<<<<< HEAD
                    element.Value.Email = newEmail;
=======
                    contact.Email = newEmail;
>>>>>>> UC5-AddMultiple-Contacts
                    Console.WriteLine("---------------------------------\n!!Contact Edited!!");
                }
            }

        }
<<<<<<< HEAD
        public void DeleteContact()
=======
        public void DeleteContact(string name)
>>>>>>> UC5-AddMultiple-Contacts
        {
            Console.WriteLine("Enter First Name of the Contact you want to Delete:");
            string name = Console.ReadLine();
            foreach (var contact in List)
            {
                if (contact.FirstName == name)
                {
                    List.Remove(contact);
                    Console.WriteLine("---------------------------------\n!!Contact Removed!!");
                    break;
                }
            }

        }
        public void DuplicateChecker()
        {
            Console.WriteLine("Enter a unique name to your Addressbook:");
            string addressbookName = Console.ReadLine();
            Console.WriteLine("First Name:");
            string name = Console.ReadLine();

            foreach (var element in DictName)
            {
                if (element.Value.FirstName.Equals(name))
                {
                    Console.WriteLine("=================================\nEntered Person Name already exist in Addressbook in AddressBook::\n" + element.Key + "\n=================================");
                }
                else
                {
                    string newName = name;
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
                    var newContact = new Contact(newName, lastname, address, city, state, zipcode, phonenumber, email);
                    DictName.Add(addressbookName, newContact);
                    Console.WriteLine("=================================\nDuplicate checker passed contact added successfully.\n=================================");
                }
            }
        }
        public void SearchPerson()
        {
            Console.WriteLine("Enter City or State to search person::");
            string city = Console.ReadLine();
            foreach (var element in DictName)
            {
                if (element.Value.City.Equals(city))
                {
                    Console.WriteLine("Contact(s) in found in " + city + ":: " + element.Value.FirstName);
                }
                else if (element.Value.State.Equals(city))
                {
                    Console.WriteLine("Contact(s) in found in " + city + ":: " + element.Value.FirstName);
                }
                else
                {
                    Console.WriteLine("No such City or State stored in your addressbook.\nAvailable city and states are ::\n Cites:: " + element.Value.City + "\nStates:: " + element.Value.State);
                }
            }
        }
    }
}