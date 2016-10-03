using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Classes.Stuff;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle myVehicle = new Vehicle(58, 4);
            myVehicle.HasDoors = false;
            bool doorQuestion = myVehicle.HasDoors;

            bool wheelQuestion = myVehicle.HasWheels;

            Vehicle myCar = new Vehicle(4);
            myCar.HasDoors = true;

            Console.WriteLine("My Car has {0} wheels", myCar.NumWheels);
        }
    }
}
