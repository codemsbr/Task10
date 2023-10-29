using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10.AbstactClass
{
    internal abstract class Vehicle
    {
        public abstract float DriveTime { get; set; }
        public abstract float DrivePath { get; set; }
        public abstract float AverageSpeed();
    }
}
