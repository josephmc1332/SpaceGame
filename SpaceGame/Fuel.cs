using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Fuel
    {
       
       

        


        /// <summary>
        /// restricts over 100 fuel and less than 0 fuel
        /// </summary>
        public int MyCurrentFuel { get; set; }


        public Fuel()
        {
            MyCurrentFuel = 0;
        }



        public void BuyFuel(PersonalStatus PS, Ship ship)
        {
            Console.WriteLine($"Your current fuel level is: {MyCurrentFuel}, fuel costs 5 GC per unit. How much fuel would you like to buy?");
            try
            {
                int response = Convert.ToInt32(Console.ReadLine());
                if (response * 5 > PS.Cash())
                {
                    Console.WriteLine($"You can't afford that much fuel. You can only afford {PS.Cash() / 5}");
                    Console.ReadLine();
                    BuyFuel(PS, ship);
                }
                if (response + MyCurrentFuel > ship.ShipFuelMax)
                {
                    Console.WriteLine($"You dont have the capacity for that, You are ready have {MyCurrentFuel} and only a max of {ship.ShipFuelMax}");
                    Console.ReadLine();
                    BuyFuel(PS, ship);
                }
                if (response + MyCurrentFuel <= ship.ShipFuelMax && response * 5 <= PS.Cash())
                {
                    MyCurrentFuel += response;
                    PS.SpendMoney(response * 5);
                    Console.WriteLine($"You now have {MyCurrentFuel} amount of fuel.\n" +
                        $"It cost {response * 5} you now have {PS.Cash()}");
                    return;
                }
                else
                    return;
            }
            catch
            {
                return;
            }
                
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
