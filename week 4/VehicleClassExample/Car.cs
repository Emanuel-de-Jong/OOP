using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleClassExample
{
    class Car : Vehicle
    {
        public Car()
        {
            TireCount = 4;
        }

        public override string Accelerate()
        {
            return "Cars accelerate by pushing the gas padel with ones right foot.";
        }
        public override string Break()
        {
            return "Cars deccelerate by pushing the break padel with ones right foot.";
        }
    }
}
