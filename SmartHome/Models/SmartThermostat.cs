using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome.Models
{
    public class SmartThermostat : SmartDevice
    {
        public double Temperature { get; private set; }

        public SmartThermostat(string name, double initialTemp) : base(name)
        {
            Temperature = initialTemp;
        }

        public void SetTemperature(double temp)
        {
            if (IsOn)
            {
                Temperature = temp;
                Console.WriteLine($"{Name} termostat podešen na {Temperature}°C.");
            }
            else
            {
                Console.WriteLine($"Termostat {Name} je isključen.");
            }
        }
    }
}
