using SmartHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome.Services
{
    public class SmartHomeService
    {
        private List<IDevice> devices = new List<IDevice>();
        private List<ISensor> sensors = new List<ISensor>();

        public void AddDevice(IDevice device)
        {
            devices.Add(device);
            Console.WriteLine($"Dodano: {device.Name}");
        }

        public void RemoveDevice(IDevice device)
        {
            if (devices.Remove(device))
                Console.WriteLine($"Uređaj {device.Name} je uklonjen.");
        }

        public void AddSensor(ISensor sensor)
        {
            sensors.Add(sensor);
            Console.WriteLine($"Senzor '{sensor.SensorType}' je dodan.");
        }

        public void RemoveSensor(ISensor sensor)
        {
            if (sensors.Remove(sensor))
                Console.WriteLine($"Senzor '{sensor.SensorType}' je uklonjen.");
        }

        public void ShowStatus()
        {
            Console.WriteLine("\nStatus uređaja:");
            foreach (var device in devices)
            {
                Console.WriteLine($"- {device.Name}: {(device.IsOn ? "Uključeno" : "Isključeno")}");
            }

            Console.WriteLine("\nVrijednosti senzora:");
            foreach (var sensor in sensors)
            {
                Console.WriteLine($"- {sensor.SensorType}: {sensor.GetValue()}°C");
            }
        }
    }
}
