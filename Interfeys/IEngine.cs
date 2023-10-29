using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10.Interfeys
{
    internal interface IEngine
    {
        int HorsePower { get; set; }
        float TankSize { get; set; }
        float CurrentOil { get; set; }
        string FuelType { get; set; }
        float RemainOilAmount();
    }
}
