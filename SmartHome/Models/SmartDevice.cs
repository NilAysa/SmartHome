using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome.Models
{
    public abstract class SmartDevice : ISmartDevice
    {
        public string Name { get; protected set; }
        public bool IsOn { get; protected set; }

        protected SmartDevice(string name)
        {
            Name = name;
            IsOn = false;
        }

        public virtual void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Name} je uključen.");
        }

        public virtual void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Name} je isključen.");
        }

        public virtual void ResetDevice()
        {
            TurnOff();
            Console.WriteLine($"{Name} je resetovan.");
        }
    }
}
