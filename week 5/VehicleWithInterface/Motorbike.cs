using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleWithInterface
{
    class Motorbike : Vehicle, IVehicleFunctions
    {
        //properties
        public int TireCount { get; set; }

        //constructors
        public Motorbike()
        {
            TireCount = 2;
        }

        //methods
        public string Accelerate()
        {
            return "Motorbikes accelerate by rotating the right handle with ones right hand.";
        }
        public string deccelerate()
        {
            return "Motorbikes deccelerate by pushing the break padel with ones hands.";
        }
    }
}
