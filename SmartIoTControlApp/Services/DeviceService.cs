using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using DeviceModel = SmartIoTControlApp.Models.Device;

namespace SmartIoTControlApp.Services
{
    public class DeviceService
    {
        private readonly HttpClient _httpClient;

        private const string ApiUrl = "https://smartiotapi.onrender.com/api/devices";

        public DeviceService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<DeviceModel>> GetDevicesAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<DeviceModel>>(ApiUrl);
        }

        public async Task AddDeviceAsync(DeviceModel device)
        {
            var response = await _httpClient.PostAsJsonAsync(ApiUrl, device);
            response.EnsureSuccessStatusCode();
        }
    }
}
