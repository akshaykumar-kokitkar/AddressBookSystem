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

        public void DisplayAllContact()
        {
            foreach (var contact in List)
            {
                Console.WriteLine(contact.FirstName + contact.LastName + "\nAddress: " + contact.Address + "\nCity: " + contact.City + "\nState: " + contact.State + "\nZip Code: " + contact.ZipCode + "\nPhone Number: " + contact.PhoneNumber + "\nEmail: " + contact.Email);

            }
        }
    }

}