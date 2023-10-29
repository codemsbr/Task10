using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task10.AbstactClass;
using Task10.Interfeys;

namespace Task10.Class
{
    internal class Plane:Vehicle,IEngine
    {
        string _fuelType;
        float _wingLength;
        float _driveTime;
        float _drivePath;
        float _tankSize;
        float _currentOil;
        int _horsePower;

        public string FuelType { get => _fuelType; set => _fuelType = string.IsNullOrWhiteSpace(value) ? value : string.Empty;}
        public float WingLength { get => _wingLength; set => _wingLength = value > 0 ? value : 0; }
        public override float DriveTime { get => _driveTime; set => _driveTime = value > 0 ? value : 0; }
        public override float DrivePath { get => _drivePath; set => _drivePath = value > 0 ? value : 0; } 
        public int HorsePower { get => _horsePower; set => _horsePower = value > 0 ? value : 0; }
        public float TankSize { get => _tankSize; set => _tankSize = value > 0 ? value : 0; }
        public float CurrentOil { get => _currentOil; set => _currentOil = value > 0 ? value : 0; }


        public Plane(string fuelType,float wingLength,float driveTime,float drivePath,float tankSize,float currentOil,int horsePower)
        {
            FuelType = fuelType;
            WingLength = wingLength;
            DriveTime = driveTime;
            DrivePath = drivePath;
            TankSize = tankSize;
            CurrentOil = currentOil;
            HorsePower = horsePower;
        }

        public Plane()
        {
            
        }

        public override float AverageSpeed()
        {
            return DrivePath / DrivePath;
        }

        public float RemainOilAmount()
        {
            return TankSize - CurrentOil;
        }

        public override string ToString()
        {
            return $"{FuelType} {WingLength} {DriveTime} {DrivePath} {HorsePower} {TankSize} {CurrentOil}";
        }
    }
}
