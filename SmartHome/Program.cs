using SmartHome.Models;
using SmartHome.Services;
using System;

namespace SmartHouseProject
{
    class Program
    {
        static void Main()
        {
            SmartHomeService home = new SmartHomeService();

            SmartLight svjetlo = new SmartLight("Svjetlo u dnevnoj");
            SmartThermostat termostat = new SmartThermostat("Termostat", 22.5);
            SmartOutlet uticnica = new SmartOutlet("Pametna utičnica");

            home.AddDevice(svjetlo);
            home.AddDevice(termostat);
            home.AddDevice(uticnica);

            TemperatureSensor tempSensor = new TemperatureSensor();
            home.AddSensor(tempSensor);

            svjetlo.TurnOn();
            svjetlo.SetBrightness(75);

            termostat.TurnOn();
            termostat.SetTemperature(24.0);

            uticnica.TurnOn();
            uticnica.SetPowerConsumption(150);

            home.ShowStatus();

            svjetlo.ResetDevice();
            termostat.TurnOff();
            uticnica.TurnOff();

            home.ShowStatus();
        }
    }
}
