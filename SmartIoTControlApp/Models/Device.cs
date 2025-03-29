using System;

namespace SmartIoTControlApp.Models
{
    public class Device
    {
        public Guid Id { get; set; }       // ID único
        public string Name { get; set; }   // Nombre del dispositivo
        public string Type { get; set; }   // Tipo de dispositivo
        public bool IsOnline { get; set; } // Estado del dispositivo
    }
}
