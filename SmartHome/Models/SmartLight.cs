using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome.Models
{
    public class SmartLight : SmartDevice
    {
        public int osvijetljenost { get; private set; } = 100;

        public SmartLight(string name) : base(name) { }

        public void SetBrightness(int level)
        {
            osvijetljenost = Math.Clamp(level, 0, 100);
            Console.WriteLine($"{nazivUredjaja} svjetlo podešeno na {osvijetljenost}% osvjetljenja.");
        }
    }
}
