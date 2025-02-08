using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome.Models
{
    public interface IDevice
    {
        string Name { get; }
        bool IsOn { get; }
        void TurnOn();
        void TurnOff();
    }
    public interface ISmartDevice : IDevice
    {
        void ResetDevice();
    }
}
