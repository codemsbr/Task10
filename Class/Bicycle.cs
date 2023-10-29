using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task10.AbstactClass;
using Task10.Interfeys;

namespace Task10.Class
{
    internal class Bicycle :Vehicle, IWheel
    {
        string _pedalKind;
        float _driveTime;
        float _drivePath;
        float _wheelThickness;

        public string PedalKind { get => _pedalKind; set => _pedalKind = string.IsNullOrWhiteSpace(value) ? value : string.Empty; }
        public override float DriveTime { get => _driveTime; set => _driveTime = value > 0 ? value : 0; }
        public override float DrivePath { get => _drivePath; set => _drivePath = value > 0 ? value : 0; }
        public float WheelThickness { get => _wheelThickness; set => _wheelThickness = value > 0 ? value : 0; }

        public Bicycle(string pedalKind,float driveTime,float drivePath,float wheelThickness)
        {
            PedalKind = pedalKind;
            DriveTime = driveTime;
            DrivePath = drivePath;
            WheelThickness = wheelThickness;
        }

        public Bicycle()
        {
            
        }
        public override float AverageSpeed()
        {
            return DrivePath / DriveTime;
        }

        public override string ToString()
        {
            return $"{PedalKind} {DriveTime} {DrivePath} {WheelThickness}";
        }
    }
}
