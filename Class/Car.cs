using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task10.AbstactClass;
using Task10.Interfeys;

namespace Task10.Class
{
    internal class Car: Vehicle, IEngine, IWheel, ITransmission
    {
        string _winCode;
        string _transmissionKind;
        string _fuelType;
        int _doorCount;
        int _horsePower;
        float _tankSize;
        float _currentOil;
        float _driveTime;
        float _drivePath;
        float _wheelThickness;

        public string WinCode { get => _winCode; set => _winCode = string.IsNullOrWhiteSpace(value) ? value : string.Empty; }
        public string TransmissionKind { get => _transmissionKind; set => _transmissionKind = string.IsNullOrWhiteSpace(value) ? value : string.Empty; }
        public string FuelType { get => _fuelType; set => _fuelType = string.IsNullOrWhiteSpace(value) ? value : string.Empty; }
        public int DoorCount { get => _doorCount; set => _doorCount = value > 0 ? value : 0; } 
        public int HorsePower { get => _horsePower; set => _horsePower = value > 0 ? value : 0; }
        public float TankSize { get => _tankSize; set => _tankSize = value > 0 ? value : 0; }
        public float CurrentOil { get => _currentOil; set => _currentOil = value > 0 && value < TankSize ? value : 0; }
        public override float DriveTime { get => _driveTime; set => _driveTime = value > 0 ? value : 0;}
        public override float DrivePath { get => _drivePath; set => _drivePath = value > 0 ? value : 0; }
        public float WheelThickness { get => _wheelThickness; set => _wheelThickness = value > 0 ? value : 0; }

        public Car(int doorCount,string winCode,int horsePower,float tankSize,float currentOil,string fuelType,float driveTime,float drivePath,float wheelThickness,string transmissionKind)
        {
            DoorCount = doorCount;
            WinCode = winCode;
            HorsePower = horsePower;
            TankSize = tankSize;
            CurrentOil = currentOil;
            FuelType = fuelType;
            DriveTime = driveTime;
            DrivePath = drivePath;
            WheelThickness = wheelThickness;
            TransmissionKind = transmissionKind;
        }

        public override float AverageSpeed()
        {
            return _drivePath / _driveTime;
        }

        public float RemainOilAmount()
        {
            return _tankSize - _currentOil;
        }

        public override string ToString()
        {
            return $"{WinCode} {TransmissionKind} {FuelType} {DoorCount} {HorsePower} {TankSize} {CurrentOil} {DriveTime} {DrivePath} {WheelThickness}";
        }
    }
}
