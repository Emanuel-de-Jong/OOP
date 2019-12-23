using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleWithInterface
{
    class Car : Vehicle, IVehicleFunctions
    {
        //properties
        public int TireCount { get; set; }

        //constructors
        public Car()
        {
            TireCount = 4;
        }

        //methods
        public string Accelerate()
        {
            return "Cars accelerate by pushing the gas padel with ones right foot.";
        }
        public string deccelerate()
        {
            return "Cars deccelerate by pushing the break padel with ones right foot.";
        }
    }
}
