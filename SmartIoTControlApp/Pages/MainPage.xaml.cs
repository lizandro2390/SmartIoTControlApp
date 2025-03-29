using Microsoft.Maui.Controls;
using System;

namespace SmartIoTControlApp.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnEnterClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DevicesPage());
        }

    }
}
