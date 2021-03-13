using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Zadanie_praktyczne___Aplikacja_z_kontaktami
{
    class PhoneBook
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>();

        public void AddConact(Contact contact)
        {
            Contacts.Add(contact);
        }
        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Conact: {contact.Name}, {contact.Number}");
        }
        private void DisplayContactsDetails(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                DisplayContactDetails(contact);
            }

        }
        public void DisplayContact(string number)
        {
            var contact = Contacts.FirstOrDefault(c => c.Number == number);

            if (contact == null)
            {
                Console.WriteLine("Contact not found");
            }
            else
            {
                DisplayContactDetails(contact);
            }
        }
        public void DisplayAllContacts()
        {
            DisplayContactsDetails(Contacts);
        }
        public void DisplayMatchingContact(string searchPhrase)
        {
            var matchingContacts = Contacts.Where(c => c.Name.Contains(searchPhrase)).ToList();
            DisplayContactsDetails(matchingContacts);
        }
    }
}
