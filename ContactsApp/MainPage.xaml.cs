using System.Collections.Generic;
using Microsoft.Maui.Controls;

namespace ContactsApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            LoadContacts(); // Calls the LoadContacts method to load the dummy contacts into the ListView.
        }

        private void LoadContacts()
        {
            // Sample data to show in the list
            var contacts = new List<Contact>
            {
                new Contact { Name = "Aaron Reblora", PhoneNumber = "123-456-7890" },
                new Contact { Name = "Jane Smith", PhoneNumber = "987-654-3210" },
                new Contact { Name = "Sam Johnson", PhoneNumber = "555-123-4567" }
            };

            ContactsListView.ItemsSource = contacts; // Binds the list of contacts to the ListView.
        }

        private void OnAddContactClicked(object sender, EventArgs e)
        {
            // Handle adding a contact (for now, we'll just display a message)
            DisplayAlert("Add Contact", "This will allow you to add a new contact.", "OK");
        }
    }

    public class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}
