using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome.Models
{
    public class SmartOutlet : SmartDevice
    {
        public double potrosnja { get; private set; }

        public SmartOutlet(string naziv) : base(naziv) { }

        public void SetPowerConsumption(double snaga)
        {
            if (IsOn)
            {
                potrosnja = snaga;
                Console.WriteLine($"{nazivUredjaja} troši {potrosnja}W.");
            }
            else
            {
                Console.WriteLine($"{nazivUredjaja} je isključen i ne troši struju.");
            }
        }
    }
}
