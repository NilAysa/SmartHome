using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome.Models
{
    public interface ISensor
    {
        string SensorType { get; }
        double GetValue();
    }
}
