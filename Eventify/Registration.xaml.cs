using System.Collections.Generic;
using System.Windows;

namespace EventPlanner
{
    public partial class Registration : Window
    {

        public static List<User> simulatedDatabase = new List<User>();

        public Registration()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordBox.Password;
            string email = emailTextBox.Text;

            if (username.Length < 4 || password.Length < 4 || password.Length > 16)
            {
                MessageBox.Show("Username must be between 4 and 8 characters long, and password must be between 4 and 16 characters long.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (simulatedDatabase.Exists(user => user.Username == username))
            {
                MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            simulatedDatabase.Add(new User { Username = username, Password = password, Email = email });

            MessageBox.Show($"Registered successfully!\nUsername: {username}\nEmail: {email}", "Registration Success", MessageBoxButton.OK, MessageBoxImage.Information);

            usernameTextBox.Text = "";
            passwordBox.Password = "";
            emailTextBox.Text = "";

            Login loginPage = new Login();
            loginPage.Show();
            this.Close();
        }
    }

    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
