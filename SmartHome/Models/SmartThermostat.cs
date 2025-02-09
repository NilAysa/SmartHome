using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome.Models
{
    public class SmartThermostat : SmartDevice
    {
        public double temperatura { get; private set; }

        public SmartThermostat(string naziv, double inicijalnaTemp) : base(naziv)
        {
            temperatura = inicijalnaTemp;
        }

        public void SetTemperature(double temp)
        {
            if (IsOn)
            {
                temperatura = temp;
                Console.WriteLine($"{nazivUredjaja} termostat podešen na {temperatura}°C.");
            }
            else
            {
                Console.WriteLine($"Termostat {nazivUredjaja} je isključen.");
            }
        }
    }
}
