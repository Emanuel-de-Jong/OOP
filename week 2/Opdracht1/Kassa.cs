using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class Kassa
    {
        //FIELDS
        //amount to pay
        private decimal totaalBedrag;
        //amount payed
        private decimal betaaldBedrag;
        //betaaldBedrag - totaalBedrag rounded to 0.05
        private decimal wisselGeld;
        //Dictionary with all dutch bill types and their amount needed to make the value of wisselGeld
        private Dictionary<decimal, int> wisselGeldInBilieten = new Dictionary<decimal, int> { [200m] = 0, [100m] = 0, [50m] = 0, [20m] = 0, [10m] = 0, [5m] = 0, [2m] = 0, [1m] = 0, [0.5m] = 0, [0.2m] = 0, [0.1m] = 0, [0.05m] = 0 };



        //PROPERTIES
        public decimal TotaalBedrag
        {
            get { return totaalBedrag; }
            set
            {
                totaalBedrag = value;
                //calculates wisselGeld if betaaldBedrag has been given before
                if (betaaldBedrag != 0)
                {
                    SetWisselGeld(betaaldBedrag - value);
                }
            }
        }
        public decimal BetaaldBedrag
        {
            get { return betaaldBedrag; }
            set
            {
                betaaldBedrag = value;
                //calculates wisselGeld if totaalBedrag has been given before
                if (totaalBedrag != 0)
                {
                    SetWisselGeld(value - totaalBedrag);
                }
            }
        }
        public decimal WisselGeld { get { return wisselGeld; } }
        public Dictionary<decimal, int> WisselGeldInBilieten { get { return wisselGeldInBilieten; } }



        //CONSTRUCTORS
        public Kassa() { }
        public Kassa(decimal _totaalBedrag)
        {
            totaalBedrag = _totaalBedrag;
        }
        public Kassa(decimal _totaalBedrag, decimal _betaaldBedrag)
        {
            totaalBedrag = _totaalBedrag;
            betaaldBedrag = _betaaldBedrag;
            //calculates wisselGeld because both values needed have already been given
            SetWisselGeld(_betaaldBedrag - _totaalBedrag);
        }



        //METHODS
        //sets wisselGeldInBilieten by converting wisselGeld to it's  bills
        private void SetWisselGeldInBilieten()
        {
            //sets all values to 0 so it can start counting fresh
            foreach (var key in wisselGeldInBilieten.Keys.ToList())
            {
                wisselGeldInBilieten[key] = 0;
            }

            //makes a copy of wisselGeld so wisselGeld won't be affected in the loop
            decimal tempWisselGeld = wisselGeld;
            //goes through every key (bill type) in wisselGeldInBilieten
            foreach (var key in wisselGeldInBilieten.Keys.ToList())
            {
                if (tempWisselGeld <= 0)
                {
                    break;
                }
                //decreases tempWisselGeld by the bill type and adds +1 to it's value untill tempWisselGeld is les than the bill type
                while (tempWisselGeld >= key)
                {
                    tempWisselGeld -= key;
                    wisselGeldInBilieten[key] += 1;
                }
            }
        }
        private void SetWisselGeld(decimal _wisselGeld)
        {
            //rounds wisselGeld to 0.05
            wisselGeld = Math.Round(_wisselGeld * 20) / 20;
            //calculates wisselGeldInBilieten so it's always updated when wisselGeld is
            SetWisselGeldInBilieten();
        }



        public string PrintWisselGeldInBilieten()
        {
            string toReturn = "";

            foreach (var key in wisselGeldInBilieten.Keys)
            {
                //skips bill types without values
                if (wisselGeldInBilieten[key] != 0)
                {
                    //seperates euros from cents
                    if (key >= 1)
                    {
                        toReturn += wisselGeldInBilieten[key].ToString() + " keer " + key.ToString() + " euro\n";
                    }
                    else
                    {
                        toReturn += wisselGeldInBilieten[key].ToString() + " keer " + String.Format("{0:0}", key * 100) + " cent\n";
                    }
                }
            }

            return toReturn;
        }
        public string PrintWisselGeld()
        {
            return String.Format("{0:.00}", wisselGeld);
        }


        //calculates wisselGeld and with that wisselGeldInBilieten with the given parameters and returns wisselGeldInBilieten
        public Dictionary<decimal, int> BerekenWisselGeldInBilieten()
        {
            SetWisselGeld(betaaldBedrag - totaalBedrag);
            return wisselGeldInBilieten;
        }
        public Dictionary<decimal, int> BerekenWisselGeldInBilieten(decimal _totaalBedrag)
        {
            totaalBedrag = _totaalBedrag;
            SetWisselGeld(betaaldBedrag - _totaalBedrag);
            return wisselGeldInBilieten;
        }
        public Dictionary<decimal, int> BerekenWisselGeldInBilieten(decimal _totaalBedrag, decimal _betaaldBedrag)
        {
            totaalBedrag = _totaalBedrag;
            betaaldBedrag = _betaaldBedrag;
            SetWisselGeld(_betaaldBedrag - _totaalBedrag);
            return wisselGeldInBilieten;
        }

        //calculates wisselGeld and returns it
        public decimal BerekenWisselGeld()
        {
            SetWisselGeld(betaaldBedrag - totaalBedrag);
            return wisselGeld;
        }
        public decimal BerekenWisselGeld(decimal _totaalBedrag)
        {
            totaalBedrag = _totaalBedrag;
            SetWisselGeld(betaaldBedrag - _totaalBedrag);
            return wisselGeld;
        }
        public decimal BerekenWisselGeld(decimal _totaalBedrag, decimal _betaaldBedrag)
        {
            totaalBedrag = _totaalBedrag;
            betaaldBedrag = _betaaldBedrag;
            SetWisselGeld(_betaaldBedrag - _totaalBedrag);
            return wisselGeld;
        }
    }
}
