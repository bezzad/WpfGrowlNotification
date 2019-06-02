using System;
using System.Windows;

namespace WPFGrowlNotification
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private const double TopOffset = 20;
        private const double LeftOffset = 380;
        private readonly GrowlNotifiactions _growlNotifications = new GrowlNotifiactions();

        public MainWindow()
        {
            InitializeComponent();
            _growlNotifications.Top = SystemParameters.WorkArea.Top + TopOffset;
            _growlNotifications.Left = SystemParameters.WorkArea.Left + SystemParameters.WorkArea.Width - LeftOffset;
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            var rand = new Random().NextDouble() * 4;
            if (rand <= 1)
                _growlNotifications.AddNotification(new Notification { Title = "Message #1", ImageUrl = "pack://application:,,,/Resources/notification-icon.png", Message = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." });
            else if (rand <= 2)
                _growlNotifications.AddNotification(new Notification { Title = "Message #2", ImageUrl = "pack://application:,,,/Resources/microsoft-windows-8-logo.png", Message = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." });
            else if (rand <= 3)
                _growlNotifications.AddNotification(new Notification { Title = "Message #3", ImageUrl = "pack://application:,,,/Resources/facebook-button.png", Message = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." });
            else if (rand <= 4)
                _growlNotifications.AddNotification(new Notification { Title = "Message #4", ImageUrl = "pack://application:,,,/Resources/Radiation_warning_symbol.png", Message = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." });
        }

        protected override void OnClosed(System.EventArgs e)
        {
            _growlNotifications.Close();
            base.OnClosed(e);
        }

        private void WindowLoaded1(object sender, RoutedEventArgs e)
        {
            //this will make minimize restore of notifications too
            //growlNotifications.Owner = GetWindow(this);
        }
    }
}
