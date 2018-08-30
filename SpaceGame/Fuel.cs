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
       

        


        /// <summary>
        /// restricts over 100 fuel and less than 0 fuel
        /// </summary>
        public int MyCurrentFuel { get; set; }


        public Fuel()
        {
            MyCurrentFuel = 0;
        }



        public void BuyFuel(PersonalStatus ps, Ship ship)
        {
            Console.WriteLine($"Your current fuel level is: {MyCurrentFuel}, fuel costs 5 GC per unit. How much fuel would you like to buy?");
            int response = Convert.ToInt32(Console.ReadLine());
            if (response * 5 > PS.MyCurrentCredit)
            {
                Console.WriteLine($"You can't afford that much fuel. You can only afford {PS.MyCurrentCredit / 5}");
                Console.ReadLine();
                BuyFuel(ps, ship);
            }
            if (response + MyCurrentFuel > ship.ShipFuelMax)
            {
                Console.WriteLine($"You dont have the capacity for that, You are ready have {MyCurrentFuel} and only a max of {ship.ShipFuelMax}");
                Console.ReadLine();
                BuyFuel(ps, ship);
            }
            if (response + MyCurrentFuel <= ship.ShipFuelMax && response * 5 <= PS.MyCurrentCredit)
            {
                MyCurrentFuel += response;
                PS.MyCurrentCredit -= (response * 5);
                Console.WriteLine($"You now have {MyCurrentFuel} amount of fuel.\n" +
                    $"It cost {response * 5} you now have {PS.MyCurrentCredit}");
                return;
            }
            else
                return;
            
                
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

    }
}
