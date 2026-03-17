using System;
using System.Linq;
using System.Windows.Forms;

namespace ContactProject
{
    public partial class ContactForm : Form
    {
        private ContactManager contactManager;

        public ContactForm()
        {
            InitializeComponent();
            contactManager = new ContactManager();
            UpdateContactsList();
        }

        private void UpdateContactsList()
        {
            contactsListBox.Items.Clear();
            foreach (var contact in contactManager.Contacts)
            {
                contactsListBox.Items.Add($"{contact.Name} - {contact.PhoneNumber}");
            }
        }

        private void AddContactButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) ||
                string.IsNullOrWhiteSpace(phoneNumberTextBox.Text))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newContact = new Contact(
                nameTextBox.Text.Trim(),
                phoneNumberTextBox.Text.Trim());

            contactManager.AddContact(newContact);
            nameTextBox.Clear();
            phoneNumberTextBox.Clear();
            UpdateContactsList();
        }

        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            if (contactsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите контакт для удаления!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedItem = contactsListBox.SelectedItem.ToString();
            var parts = selectedItem.Split(new[] { " - " }, StringSplitOptions.None);

            if (parts.Length >= 2)
            {
                var contact = contactManager.Contacts
                    .FirstOrDefault(c => c.Name == parts[0] && c.PhoneNumber == parts[1]);

                if (contact != null)
                {
                    contactManager.RemoveContact(contact);
                    UpdateContactsList();
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var query = searchTextBox.Text.Trim();

            if (string.IsNullOrEmpty(query))
            {
                UpdateContactsList();
                return;
            }

            var results = contactManager.SearchContacts(query);
            contactsListBox.Items.Clear();

            foreach (var contact in results)
            {
                contactsListBox.Items.Add($"{contact.Name} - {contact.PhoneNumber}");
            }
        }
    }
}