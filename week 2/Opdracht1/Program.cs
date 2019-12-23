using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class Program
    {
        static CultureInfo PROVIDER = new CultureInfo("nl-NL");
        static void Main(string[] args)
        {
            Console.ResetColor();
            Console.WriteLine("Geef het te betalen bedrag:");
            var totaalBedrag = DecimalInputValidation();


            Console.WriteLine("\nGeef het betaalde bedrag:");
            var betaaldBedrag = DecimalInputValidation();


            Kassa objKassa = new Kassa(totaalBedrag, betaaldBedrag);
            Console.Write("\n\n");
            Console.ForegroundColor = ConsoleColor.Green;
            //if totaalBedrag and betaaldBedrag are the same
            if (objKassa.WisselGeld == 0)
            {
                Console.WriteLine("Geen wisselgeld hoefd geven te worden");
            }
            //if less is given than has to be payed
            else if (objKassa.WisselGeld < 0)
            {
                Console.WriteLine("De klant heeft " + String.Format("{0:.00}", Math.Abs(objKassa.WisselGeld)) + " euro te weinig betaald");
            }
            else
            {
                Console.WriteLine("Wisselgeld:");
                Console.WriteLine(objKassa.PrintWisselGeldInBilieten());
            }

            Console.Write("\nDruk op een knop om opnieuw te beginnen...");
            Console.ReadKey();
            Console.Clear();
            Main(args);
        }

        //checks Console.ReadLine() to make sure it's the kind of value I want and repeats reading untill it is
        static decimal DecimalInputValidation()
        {
            decimal input = 0;
            bool repeat;

            //repeats untill a good input has been given
            do
            {
                try
                {
                    input = decimal.Parse(Console.ReadLine(), PROVIDER);

                    //also repeats when the value is in the minus
                    if (input < 0)
                    {
                        throw new System.ArgumentException("Input cannot be less than 0", "original");
                    }

                    repeat = false;
                }
                catch
                {
                    Console.WriteLine("Geef een gelid beedrag in:");
                    repeat = true;
                }
            }
            while (repeat);

            return input;
        }
    }
}
