using Microsoft.Maui.Controls;

namespace SmartIoTControlApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell(); // Usamos navegación tipo Shell
        }
    }
}
