using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using SmartIoTControlApp.Services;
using DeviceModel = SmartIoTControlApp.Models.Device;

namespace SmartIoTControlApp.Pages
{
    public partial class DevicesPage : ContentPage
    {
        private readonly DeviceService _deviceService = new DeviceService();

        public ObservableCollection<DeviceModel> Devices { get; set; } = new ObservableCollection<DeviceModel>();

        public DevicesPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await LoadDevicesFromApi();
        }

        private async Task LoadDevicesFromApi()
        {
            try
            {
                var devicesFromApi = await _deviceService.GetDevicesAsync();
                Devices.Clear();
                foreach (var device in devicesFromApi)
                {
                    Devices.Add(device);
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"No se pudieron cargar los dispositivos.\n{ex.Message}", "OK");
            }
        }

        private async void OnAddDeviceClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddDevicePage());
        }

    }
}
