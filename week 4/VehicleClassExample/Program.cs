using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace VehicleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rndNumber = rnd.Next(15);
            Console.BackgroundColor = (ConsoleColor)rndNumber;
            if (rndNumber < 11)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Black;
            }
            Console.Clear();
            

            Car objCar = new Car();
            Motorbike objMotorbike = new Motorbike();
            Airplane objAirplane = new Airplane();

            Console.WriteLine(
                "Car" +
                "\nAmount of tires: " + objCar.TireCount +
                "\nHow to accelerate: " + objCar.Accelerate() +
                "\nHow to decelerate: " + objCar.Break()
                );

            Console.WriteLine(
                "\nMotorbike" +
                "\nAmount of tires: " + objMotorbike.TireCount +
                "\nHow to accelerate: " + objMotorbike.Accelerate() +
                "\nHow to decelerate: " + objMotorbike.Break()
                );

            Console.WriteLine(
                "\nobjAirplane" +
                "\nAmount of tires: " + objAirplane.TireCount +
                "\nHow to accelerate: " + objAirplane.Accelerate() +
                "\nHow to decelerate: " + objAirplane.Break()
                );

            Thread.Sleep(200);

            Main(args);
        }
    }
}
