using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ContactProject
{
    public class ContactManager
    {
        public List<Contact> Contacts { get; private set; }
        private string filePath;

        public ContactManager()
        {
            Contacts = new List<Contact>();
            filePath = "contacts.txt";
            LoadContacts();
        }

        public void AddContact(Contact contact)
        {
            if (contact == null)
                throw new ArgumentNullException(nameof(contact));

            Contacts.Add(contact);
            SaveContacts();
        }

        public void RemoveContact(Contact contact)
        {
            if (contact == null)
                throw new ArgumentNullException(nameof(contact));

            Contacts.Remove(contact);
            SaveContacts();
        }

        public List<Contact> SearchContacts(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                return new List<Contact>(Contacts);

            return Contacts.Where(c =>
                c.Name.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0 ||
                c.PhoneNumber.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }

        private void SaveContacts()
        {
            var lines = Contacts.Select(c => $"{c.Name}|{c.PhoneNumber}");
            File.WriteAllLines(filePath, lines);
        }

        private void LoadContacts()
        {
            if (!File.Exists(filePath))
                return;

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts.Length == 2)
                {
                    Contacts.Add(new Contact(parts[0].Trim(), parts[1].Trim()));
                }
            }
        }
    }
}