using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Notifications;
using MyProject.Data;

#pragma warning disable CS4014

namespace MyProject
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BrowserView.Services = (Application.Current as App)?.Services;
            BrowserView.Initialize();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            BrowserView.Shutdown();
        }
    }
}
