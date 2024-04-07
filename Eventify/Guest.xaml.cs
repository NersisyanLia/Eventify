using System.Collections.ObjectModel;
using System.Windows;

namespace EventPlanner
{
    public partial class GuestWindow : Window
    {
        ObservableCollection<string> invitedGuests = new ObservableCollection<string>();
        private string userName;

        public GuestWindow()
        {
            InitializeComponent();
            guestListBox.ItemsSource = invitedGuests;
        }

        private void AddGuest_Click(object sender, RoutedEventArgs e)
        {
            string guestName = guestNameTextBox.Text;
            string guestEmail = guestEmailTextBox.Text;
            string guestPhone = guestPhoneTextBox.Text;

            if (string.IsNullOrWhiteSpace(guestName) || string.IsNullOrWhiteSpace(guestEmail) || string.IsNullOrWhiteSpace(guestPhone))
            {
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            invitedGuests.Add($"{guestName} ({guestEmail}, {guestPhone})");

            guestNameTextBox.Text = "";
            guestEmailTextBox.Text = "";
            guestPhoneTextBox.Text = "";
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void guestNameTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void GoToProfile_Click(object sender, RoutedEventArgs e)
        {
            ProfileWindow profileWindow = new ProfileWindow(userName);
            profileWindow.Show();
            this.Close();
        }

    }
}
