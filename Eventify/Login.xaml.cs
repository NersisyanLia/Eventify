using Eventify;
using System.Windows;
using System.Linq;

namespace EventPlanner
{
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordBox.Password;

            User user = Registration.simulatedDatabase.Find(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                MessageBox.Show($"Logged in successfully as {username}.", "Login Success", MessageBoxButton.OK, MessageBoxImage.Information);

                ProfileWindow profilePage = new ProfileWindow(username);
                profilePage.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }



        private void Register_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to registration window
            Registration registrationWindow = new Registration();
            registrationWindow.Show();
            this.Close();
        }
    }
}
