using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Fuel
    {
        PersonalStatus PS = new PersonalStatus();
        Earth EA = new Earth();

        private int myCurrentFuel = 0;


        /// <summary>
        /// restricts over 100 fuel and less than 0 fuel
        /// </summary>
        public int MyCurrentFuel { get; set; }


        public Fuel()
        {
            MyCurrentFuel = 0;
        }



        public int BuyFuel(PersonalStatus ps)
        {
            Console.WriteLine($"Your current fuel level is: {MyCurrentFuel} How much fuel would you like to buy?");
            int response = Convert.ToInt32(Console.ReadLine());
            if (response )
            MyCurrentFuel += response;
            return MyCurrentFuel;
        }


        public int fuelCost = 5;

        public int FuelCost
        {
            get
            {
                return fuelCost;
            }
            set
            {
                if (value != 5)
                {
                    throw new Exception("You can't change the value of fuel");
                }

            }
        }








        //Reduce current fuel per planet travel
        public int ReduceFull(PersonalStatus ps, PlanetInfo pi)
        {
           
            double xAxisPlanet1 = 0.0;
            double yAxisPlanet1 = 0.0;

            double xAxisPlanet2 = 0.0;
            double yAxisPlanet2 = 0.0;



               myCurrentFuel -= Convert.ToInt32(Math.Sqrt(Math.Pow(xAxisPlanet1 - xAxisPlanet2, 2) + Math.Pow(yAxisPlanet1 - yAxisPlanet2, 2)));

                return myCurrentFuel;

            
        }




    }
}
