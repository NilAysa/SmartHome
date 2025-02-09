using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome.Models
{
    public abstract class SmartDevice : ISmartDevice
    {
        public string nazivUredjaja { get; protected set; }
        public bool IsOn { get; protected set; }

        protected SmartDevice(string name)
        {
            nazivUredjaja = name;
            IsOn = false;
        }

        public virtual void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{nazivUredjaja} je uključen.");
        }

        public virtual void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{nazivUredjaja} je isključen.");
        }

        public virtual void ResetDevice()
        {
            TurnOff();
            Console.WriteLine($"{nazivUredjaja} je resetovan.");
        }
    }
}
