using Eventify;
using EventPlanner;
using System;
using System.Windows;

public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        var registrationWindow = new Registration();
        registrationWindow.ShowDialog();

        if (registrationWindow.DialogResult == true)
        {
            var loginWindow = new Login();
            loginWindow.ShowDialog();

            if (loginWindow.DialogResult == true)
            {
                string eventType = "DefaultEventType";

                var mainWindow = new MainWindow(eventType);
                mainWindow.Show();

                var guestWindow = new GuestWindow();
                guestWindow.Show();
            }
            else
            {
                Application.Current.Shutdown();
            }
        }
        else
        {
            Application.Current.Shutdown();
        }
    }
}
