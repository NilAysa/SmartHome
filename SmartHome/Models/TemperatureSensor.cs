using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome.Models
{
    public class TemperatureSensor : ISensor
    {
        public string SensorType => "Temperature";
        private Random random = new Random();

        public double GetValue()
        {
            return Math.Round(15 + random.NextDouble() * 15, 1); //simulira vrijednosti izmedju 15 i 30 stepeni
        }
    }
}
