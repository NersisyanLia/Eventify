using System.Windows;

namespace EventPlanner
{
    public partial class ProfileWindow : Window
    {

        private string userName;

        public ProfileWindow(string userName)
        {
            InitializeComponent();
            this.userName = userName;
            UpdateWelcomeMessage();
        }

        public ProfileWindow()
        {
        }

        private void UpdateWelcomeMessage()
        {
            welcomeMessageTextBlock.Text = $"Hello, {userName}";
        }

        private void Movie_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow("Movie");
            mainWindow.Show();
            this.Close();
        }

        private void Concert_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow("Concert");
            mainWindow.Show();
            this.Close();
        }

        private void Conference_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow("Conference");
            mainWindow.Show();
            this.Close();
        }

        private void Workshop_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow("Workshop");
            mainWindow.Show();
            this.Close();
        }
    }
}
