using SmartHome.Models;
using SmartHome.Services;
using SmartHome.Data;
using System;

namespace SmartHouseProject
{
    class Program
    {
        static void Main()
        {
            SmartHomeService homeService = new SmartHomeService();

            // Kreiranje uređaja
            SmartLight light = new SmartLight("Dnevna soba - Svjetlo");
            SmartThermostat thermostat = new SmartThermostat("Termostat", 22.5);
            SmartOutlet outlet = new SmartOutlet("Pametna utičnica");

            // Dodavanje uređaja
            homeService.AddDevice(light);
            homeService.AddDevice(thermostat);
            homeService.AddDevice(outlet);

            // Kreiranje i dodavanje senzora
            TemperatureSensor tempSensor = new TemperatureSensor();
            homeService.AddSensor(tempSensor);

            // Uključivanje uređaja
            light.TurnOn();
            light.SetBrightness(75);

            thermostat.TurnOn();
            thermostat.SetTemperature(24.0);

            outlet.TurnOn();
            outlet.SetPowerConsumption(150);

            // Prikaz trenutnog statusa
            homeService.ShowStatus();

            // Resetovanje i isključivanje uređaja
            light.ResetDevice();
            thermostat.TurnOff();
            outlet.TurnOff();

            // Prikaz ažuriranog statusa
            homeService.ShowStatus();
        }
    }
}
