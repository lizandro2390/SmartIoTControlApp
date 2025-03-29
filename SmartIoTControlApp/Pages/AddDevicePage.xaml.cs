using Microsoft.Maui.Controls;
using System;
using SmartIoTControlApp.Services;
using DeviceModel = SmartIoTControlApp.Models.Device;

namespace SmartIoTControlApp.Pages
{
    public partial class AddDevicePage : ContentPage
    {
        private readonly DeviceService _deviceService = new DeviceService();

        public AddDevicePage()
        {
            InitializeComponent();
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameEntry.Text) || TypePicker.SelectedIndex == -1)
            {
                await DisplayAlert("Error", "Por favor, complete todos los campos.", "OK");
                return;
            }

            var newDevice = new DeviceModel
            {
                Id = Guid.NewGuid(),
                Name = NameEntry.Text,
                Type = TypePicker.SelectedItem.ToString(),
                IsOnline = IsOnlineSwitch.IsToggled
            };

            try
            {
                await _deviceService.AddDeviceAsync(newDevice);
                await DisplayAlert("Éxito", "Dispositivo agregado correctamente", "OK");
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"No se pudo guardar el dispositivo.\n{ex.Message}", "OK");
            }
        }
    }
}
