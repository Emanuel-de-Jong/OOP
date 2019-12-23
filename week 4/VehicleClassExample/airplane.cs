using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleClassExample
{
    class Airplane : Vehicle
    {
        public Airplane()
        {
            TireCount = 18;
        }

        public override string Accelerate()
        {
            return "Airplanes accelerate by pulling the steer down.";
        }
        public override string Break()
        {
            return "Airplanes deccelerate by pushing the steer up.";
        }
    }
}
