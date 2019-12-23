using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleClassExample
{
    class Motorbike : Vehicle
    {
        public Motorbike()
        {
            TireCount = 2;
        }

        public override string Accelerate()
        {
            return "Motorbikes accelerate by rotating the right handle with ones right hand.";
        }
        public override string Break()
        {
            return "Motorbikes deccelerate by pushing the break padel with ones hands.";
        }
    }
}
