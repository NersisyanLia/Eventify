using System;
using System.Windows;

namespace EventPlanner
{
    public partial class MainWindow : Window
    {
        private string userName;

        public MainWindow()
        {
        }

        public MainWindow(string eventType)
        {
            InitializeComponent();

        }

        private void AddEvent_Click(object sender, RoutedEventArgs e)
        {
            string eventName = eventNameTextBox.Text;
            DateTime eventDate = eventDatePicker.SelectedDate ?? DateTime.MinValue;
            string eventLocation = eventLocationTextBox.Text;
            string eventBudget = eventBudgetTextBox.Text;
            string eventDescription = eventDescriptionTextBox.Text;
            DateTime startTime;
            DateTime endTime;
            if (!DateTime.TryParse(eventStartTimeTextBox.Text, out startTime) || !DateTime.TryParse(eventEndTimeTextBox.Text, out endTime))
            {
                MessageBox.Show("Please enter valid start and end times.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(eventName) || eventDate == DateTime.MinValue || string.IsNullOrWhiteSpace(eventLocation) || string.IsNullOrWhiteSpace(eventBudget) || string.IsNullOrWhiteSpace(eventDescription))
            {
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            eventNameTextBox.Text = "";
            eventDatePicker.SelectedDate = null;
            eventLocationTextBox.Text = "";
            eventBudgetTextBox.Text = "";
            eventDescriptionTextBox.Text = "";

            MessageBox.Show("Event added successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

            GuestWindow guestPage = new GuestWindow();
            guestPage.Show();
            this.Close();
        }

        private void GoToProfile_Click(object sender, RoutedEventArgs e)
        {
            ProfileWindow profileWindow = new ProfileWindow(userName);
            profileWindow.Show();
            this.Close();
        }
      }
    }