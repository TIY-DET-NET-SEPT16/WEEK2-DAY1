using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Stuff
{
    public class Vehicle
    {
        private bool hasWheels = true;
        private int numWheels;
        private bool hasDoors;
        private int numDoors;

        public Vehicle()
        {
        }

        public Vehicle(string whatever)
        {

        }

        public Vehicle(int initialNumWheels)
        {
            NumWheels = initialNumWheels;
        }

        public Vehicle(int initialNumWheels, int initialNumDoors)
        {
            NumWheels = initialNumWheels;
            NumDoors = initialNumDoors;
        }

        public bool HasWheels
        {
            get
            {
                return hasWheels;
            }
        }

        public int NumWheels
        {
            get
            {
                return numWheels;
            }

            set
            {
                if (value < 1)
                {
                    numWheels = 1;
                }
                else
                {
                    numWheels = value;
                }
            }
        }

        public bool HasDoors
        {
            get
            {
                return hasDoors;
            }

            set
            {
                hasDoors = value;
            }
        }

        public int NumDoors
        {
            get
            {
                return numDoors;
            }

            set
            {
                numDoors = value;
            }
        }
    }
}
