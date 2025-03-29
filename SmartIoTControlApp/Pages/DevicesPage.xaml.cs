using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;

namespace SmartIoTControlApp.Pages
{
    public partial class DevicesPage : ContentPage
    {
        public ObservableCollection<DeviceViewModel> Devices { get; set; }

        public DevicesPage()
        {
            InitializeComponent();

            Devices = new ObservableCollection<DeviceViewModel>
            {
                new DeviceViewModel { Name = "Luz Sala", IP = "192.168.1.10", Icon = "icon_bulb.png", IsOnline = true },
                new DeviceViewModel { Name = "Ventilador", IP = "192.168.1.20", Icon = "icon_fan.png", IsOnline = false },
                new DeviceViewModel { Name = "Sensor Humedad", IP = "192.168.1.30", Icon = "icon_sensor.png", IsOnline = true },
            };

            BindingContext = this;
        }

        private async void OnAddDeviceClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddDevicePage());
        }
    }

    public class DeviceViewModel
    {
        public string Name { get; set; }
        public string IP { get; set; }
        public string Icon { get; set; }
        public bool IsOnline { get; set; }

        public string StatusText => IsOnline ? "ONLINE" : "OFFLINE";
        public Color StatusColor => IsOnline ? Colors.Green : Colors.Gray;
    }
}
