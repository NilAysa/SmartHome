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
        private List<IDevice> uredjaji = new List<IDevice>();
        private List<ISensor> senzori = new List<ISensor>();

        public void AddDevice(IDevice uredjaj)
        {
            uredjaji.Add(uredjaj);
            Console.WriteLine($"Dodano: {uredjaj.nazivUredjaja}");
        }

        public void RemoveDevice(IDevice uredjaj)
        {
            if (uredjaji.Remove(uredjaj))
                Console.WriteLine($"Uređaj {uredjaj.nazivUredjaja} je uklonjen.");
        }

        public void AddSensor(ISensor senzor)
        {
            senzori.Add(senzor);
            Console.WriteLine($"Senzor '{senzor.tipSenzora}' je dodan.");
        }

        public void RemoveSensor(ISensor senzor)
        {
            if (senzori.Remove(senzor))
                Console.WriteLine($"Senzor '{senzor.tipSenzora}' je uklonjen.");
        }

        public void ShowStatus()
        {
            Console.WriteLine("\nStatus uređaja:");
            foreach (var uredjaj in uredjaji)
            {
                Console.WriteLine($"- {uredjaj.nazivUredjaja}: {(uredjaj.IsOn ? "Uključeno" : "Isključeno")}");
            }

            Console.WriteLine("\nVrijednosti senzora:");
            foreach (var senzor in senzori)
            {
                Console.WriteLine($"- {senzor.tipSenzora}: {senzor.GetValue()}°C");
            }
        }
    }
}
