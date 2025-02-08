using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome.Models
{
    public class SmartOutlet : SmartDevice
    {
        public double PowerConsumption { get; private set; }

        public SmartOutlet(string name) : base(name) { }

        public void SetPowerConsumption(double power)
        {
            if (IsOn)
            {
                PowerConsumption = power;
                Console.WriteLine($"{Name} troši {PowerConsumption}W.");
            }
            else
            {
                Console.WriteLine($"{Name} je isključen i ne troši struju.");
            }
        }
    }
}
