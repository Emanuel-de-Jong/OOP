using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleClassExample
{
    public abstract class Vehicle
    {
        public int TireCount { get; set; }

        public abstract string Accelerate();
        public abstract string Break();
    }
}
