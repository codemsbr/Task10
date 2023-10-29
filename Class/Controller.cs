using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Task10.AbstactClass;

namespace Task10.Class
{
    internal class Controller
    {
        Vehicle[] myArray = new Vehicle[0];

        public void Menu()
        {
            Console.WriteLine("1.Create New Car");
            Console.WriteLine("2.Create new Bicycle");
            Console.WriteLine("3.Create New Plane");
            Console.WriteLine("4.Look At All Vehicles");
            Console.WriteLine("5.Delete Vehicle");
            Console.WriteLine("6.Exit");
            Console.Write("Enter User Answer : ");
        }

        public void CreateCar()
        {
            Console.Write("Enter Door Count : ");
            int doorCount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Win Code : ");
            string winCode = Console.ReadLine();

            Console.Write("Enter Horse Power : ");
            int horsePower = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Tank Size : ");
            float tankSize = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter Current Oil : ");
            float currentOil = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter Fuel Type : ");
            string fuelType = Console.ReadLine();

            Console.Write("Enter Drive Time : ");
            float driveTime = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter Drive Path : ");
            float drivePath = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter Wheel Thickness : ");
            float wheelThickness = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter Transmission Kind : ");
            string transmissionKind = Console.ReadLine();
            Console.Clear();
            Add(new Car(doorCount, winCode, horsePower, tankSize, currentOil, fuelType, driveTime, drivePath, wheelThickness, transmissionKind));
        }

        public void CreateBicycle()
        {
            #region Yol 1
            //Console.Write("Enter Pedal Kind : ");
            //string pedalKind = Console.ReadLine();

            //Console.Write("Enter Drive Time : ");
            //float driveTime = Convert.ToSingle(Console.ReadLine());

            //Console.Write("Enter Drive Path : ");
            //float drivePath = Convert.ToSingle(Console.ReadLine());

            //Console.Write("Enter Wheel Thickness : ");
            //float wheelThickness = Convert.ToSingle(Console.ReadLine());

            //Bicycle newBicycle = new Bicycle(pedalKind,driveTime,drivePath,wheelThickness);
            //Add(new Bicycle(pedalKind, driveTime, drivePath, wheelThickness));
            #endregion

            Bicycle newBicycle = new Bicycle();
            Console.Write("Enter Pedal Kind : ");
            newBicycle.PedalKind = Console.ReadLine();

            Console.Write("Enter Drive Time : ");
            newBicycle.DriveTime = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter Drive Path : ");
            newBicycle.DrivePath = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter Wheel Thickness : ");
            newBicycle.WheelThickness = Convert.ToSingle(Console.ReadLine());
            Add(newBicycle);
            Console.Clear();
        }

        public void CreatePlane()
        {
            #region Yol 1
            //Console.Write("Enter Fuel Type : ");
            //string fuelType = Console.ReadLine();

            //Console.Write("Enter Wing Length : ");
            //float wingLength = Convert.ToSingle(Console.ReadLine());

            //Console.Write("Enter Drive Time : ");
            //float driveTime = Convert.ToSingle(Console.ReadLine());

            //Console.Write("Enter Drive Path : ");
            //float drivePath = Convert.ToSingle(Console.ReadLine());


            //Console.Write("Enter Tank Size : ");
            //float tankSize = Convert.ToSingle(Console.ReadLine());

            //Console.Write("Enter Current Oil : ");
            //float currentOil = Convert.ToSingle(Console.ReadLine());

            //Console.Write("Enter Horse Power : ");
            //int horsePower = Convert.ToInt32(Console.ReadLine());
            //Add(new(fuelType, wingLength, driveTime, drivePath, tankSize, currentOil, horsePower));
            #endregion


            Plane newPlane = new();
            Console.Write("Enter Fuel Type : ");
            newPlane.FuelType = Console.ReadLine();

            Console.Write("Enter Wing Length : ");
            newPlane.WingLength = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter Drive Time : ");
            newPlane.DriveTime = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter Drive Path : ");
            newPlane.DrivePath = Convert.ToSingle(Console.ReadLine());


            Console.Write("Enter Tank Size : ");
            newPlane.TankSize = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter Current Oil : ");
            newPlane.CurrentOil = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter Horse Power : ");
            newPlane.HorsePower = Convert.ToInt32(Console.ReadLine());
            Add(newPlane);
            Console.Clear();
        }

        public void Add(Vehicle user)
        {
            Array.Resize(ref myArray, myArray.Length + 1);
            myArray[myArray.Length - 1] = user;
        }

        public void GetAll()
        {
            foreach (Vehicle myItem in myArray)
            {
                Console.WriteLine(myItem);
            }
        }

        public void RemoveIndex(int index)
        {
            if (myArray.Length - 1 != index)
            {
                Short(index);
                Array.Resize(ref myArray, myArray.Length - 1);
            }
            else
            {
                Array.Resize(ref myArray, myArray.Length - 1);
            }

        }

        void Short(int index)
        {
            myArray[index] = myArray[myArray.Length - 1];
            myArray[myArray.Length - 1] = null;
        }
    }
}
