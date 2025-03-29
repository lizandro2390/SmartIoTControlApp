using Microsoft.Maui.Controls;
using System;

namespace SmartIoTControlApp.Pages
{
    public partial class AddDevicePage : ContentPage
    {
        public AddDevicePage()
        {
            InitializeComponent();
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            string name = NameEntry.Text;
            string type = TypePicker.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(type))
            {
                await DisplayAlert("Error", "Por favor complete todos los campos.", "OK");
                return;
            }

            Console.WriteLine($"Nuevo dispositivo: {name} - {type}");

            await DisplayAlert("Éxito", "Dispositivo agregado correctamente.", "OK");
            await Navigation.PopAsync();
        }
    }
}
