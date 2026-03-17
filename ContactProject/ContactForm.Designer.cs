using System.Windows.Forms;

namespace ContactProject
{
    partial class ContactForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox nameTextBox;
        private TextBox phoneNumberTextBox;
        private Button addContactButton;
        private Button removeContactButton;
        private TextBox searchTextBox;
        private Button searchButton;
        private ListBox contactsListBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.addContactButton = new System.Windows.Forms.Button();
            this.removeContactButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.contactsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(10, 10);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(150, 22);
            this.nameTextBox.TabIndex = 0;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(170, 10);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(150, 22);
            this.phoneNumberTextBox.TabIndex = 1;
            // 
            // addContactButton
            // 
            this.addContactButton.Location = new System.Drawing.Point(10, 40);
            this.addContactButton.Name = "addContactButton";
            this.addContactButton.Size = new System.Drawing.Size(100, 23);
            this.addContactButton.TabIndex = 2;
            this.addContactButton.Text = "Добавить";
            this.addContactButton.Click += new System.EventHandler(this.AddContactButton_Click);
            // 
            // removeContactButton
            // 
            this.removeContactButton.Location = new System.Drawing.Point(120, 40);
            this.removeContactButton.Name = "removeContactButton";
            this.removeContactButton.Size = new System.Drawing.Size(100, 23);
            this.removeContactButton.TabIndex = 3;
            this.removeContactButton.Text = "Удалить";
            this.removeContactButton.Click += new System.EventHandler(this.RemoveContactButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(10, 70);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(200, 22);
            this.searchTextBox.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(220, 70);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(80, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Искать";
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // contactsListBox
            // 
            this.contactsListBox.ItemHeight = 16;
            this.contactsListBox.Location = new System.Drawing.Point(10, 100);
            this.contactsListBox.Name = "contactsListBox";
            this.contactsListBox.Size = new System.Drawing.Size(450, 196);
            this.contactsListBox.TabIndex = 6;
            // 
            // ContactForm
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.addContactButton);
            this.Controls.Add(this.removeContactButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.contactsListBox);
            this.Name = "ContactForm";
            this.Text = "Управление контактами";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}