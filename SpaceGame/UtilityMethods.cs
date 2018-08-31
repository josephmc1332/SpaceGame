using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class UtilityMethods
    {
        Random rnd = new Random();
        GameOver GO = new GameOver();
        Ship ship = new Ship();

        // this method will populate the navigation menu and return a number that the selector can use.
        public int MainPageOptions()
        {
            Console.WriteLine("" +
            "\t\t 1 Shipyard\n" +
            "\t\t 2 Galactic Bank\n" +
            "\t\t 3 Buy, Sell, Trade\n" +
            "\t\t 4 Market\n" +
            "\t\t 5 Departure Port\n\n" +
            "\t\t 9 Quit game");
            int response = Convert.ToInt32(Console.ReadLine());
            return response;
        }

        // this method will stream line all the shipyard menus
        public int ShipYardMenu()
        {
            Console.WriteLine("What would you like to do:\n" +
            "\t\t 1 Check your ship stats\n" +
            "\t\t 2 Buy a new ship\n" +
            "\t\t 3 Return to planetary menu");
            int response = Convert.ToInt32(Console.ReadLine());
            return response;
        }

        // general display for all bank screens
        public void BankDisplay(PersonalStatus ps)
        {
            Console.WriteLine($"" +
            $"\tYou have {ps.Cash()} Galactic Credits in your bank account.\n" +
            $"\tThe title of Duke of Mercury is 1,000,000 Galactic Credits. You need {(1000000 - ps.Cash())} more\n" +
            $"\tGalactic Credits before you can win the King of Venus' approval.\n\n" +
            $"\t  Press <enter> to continue...");
            Console.ReadLine();
            GO.Win(ps, ship);
        }
        
        // single place for all the market displays
        public void MarketDisplay(PlanetInfo PI)
        {
            Console.WriteLine($"\tEarth: \n" +
                $"\t\tNo Balance Shoes: {PI.EarthNoBalanceShoes} \n" +
                $"\t\tSpace Gold: {PI.EarthSpaceGold} \n" +
                $"\t\tGalactic TVs: {PI.EarthGalacticTVs}\n\n" +
                $"\tAlpha Centari:\n" +
                $"\t\tNo Balance Shoe: {PI.AlphaCentariNoBalanceShoes}\n" +
                $"\t\tSpace Gold: {PI.AlphaCentariGold}\n" +
                $"\t\tGalactic TVs: {PI.AlphaCentariGalacticTVs}\n\n" +
                $"\tM63:\n" +
                $"\t\tNo Balance Shoes: {PI.M63NoBalanceShoes}\n" +
                $"\t\tSpace Gold: {PI.M63SpaceGold}\n" +
                $"\t\tGalactic TVs: {PI.M63GalacticTVs} \n" +
                $"\tAsgard:\n" +
                $"\t\tNo Balance Shoes: {PI.AsgardNoBalanceShoes}\n" +
                $"\t\tSpace Gold: {PI.AsgardGold}\n" +
                $"\t\tGalactic TVs: {PI.AsgardGalacticTVs}\n" +
                $"\tPlanet X:\n" +
                $"\t\tNo Balance Shoes: {PI.PlanetJoeNoBalanceShoes}\n" +
                $"\t\tSpace Gold: {PI.PlanetXGold}\n" +
                $"\t\tGalactic TVs: {PI.PlanetXGalacticTVs}");
            Console.ReadLine();
        }

        // a player hud
        public void InventoryDisplay(PersonalStatus ps, Ship ship, Fuel fuel)
        {
            Console.WriteLine($"Space Gold: {ps.SpaceGold} No Balanace Shoes: {ps.NoBalanaceShoes} Galactic TVs: {ps.GalacticTVs} " +
                $"Galactic Credits: {ps.Cash()} \nCurrent Ship: {ship.ShipName} Current Fuel: {fuel.MyCurrentFuel} Cargo Space: {ship.ShipCapacity - (ps.SpaceGold + ps.NoBalanaceShoes + ps.GalacticTVs)}\n");
        }

        // travel between the stars can be dangerous
        public void Travel(PersonalStatus ps)
        {
            int travelEvent = rnd.Next(1, 11);
            Console.Clear();
            Console.WriteLine("3...\n2...\n1...\nBlast Off!!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("" +
                "    *    .     *    \n" +
                " #===>     *      . \n" +
                "      *      *     *");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("" +
                "    *  .    .   * .  \n" +
                "  *  ###===>  .   *  \n" +
                "    .    . *      *  \n");
            Console.ReadLine();
            //random event
            if (travelEvent > 5)
            {
                Console.WriteLine("You found some space gold out there!");
                if ((ps.SpaceGold + ps.NoBalanaceShoes + ps.GalacticTVs + 1) > ship.ShipCapacity)
                {
                    Console.WriteLine("You dont have enough room for it though. Sad day...");
                    Console.ReadLine();
                }
                if ((ps.SpaceGold + ps.NoBalanaceShoes + ps.GalacticTVs + 1) <= ship.ShipCapacity)
                {
                    ps.SpaceGold += 1;
                    Console.WriteLine($"You now have {ps.SpaceGold} space gold");
                    Console.ReadLine();
                }
            }
            if (travelEvent == 5)
            {
                Console.WriteLine($"It's lonely out there in space {ps.MyName}. You are doing great! Keep it up!");
                Console.ReadLine();
            }
            if (travelEvent < 5 && travelEvent > 1)
            {
                if (ps.Cash() < 10)
                {
                    Console.WriteLine("The Pirates killed you because you couldnt pay their 10 GC toll.");
                    Console.ReadLine();
                    GO.Died(ps, ship);
                }
                else
                    Console.WriteLine("Pirate attack! You lost 10 GC to them");
                ps.SpendMoney(10);
                Console.WriteLine($"You now have {ps.Cash()} GCs");
                Console.ReadLine();
            }
            if (travelEvent == 1)
            {
                Console.WriteLine($"The galaxies worst pirates attack you but you easily overpower them. \n" +
                    $"'Please don't kill us {ps.MyName}, we will give you 100 GC if you let us go!' \n" +
                    $"You let them off easy this time...");
                ps.EarnMoney(100);
                Console.ReadLine();
            }
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("" +
                "    *   *     .    *  \n" +
                "   *  . ###===> .   * \n" +
                "  *   .    .     *     ");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("" +
                "          *         . \n" +
                "     *     .   ###===>\n" +
                "   *        *   .   .   ");
            Console.ReadLine();
        }

        public int ShopSelector()
        {
	        Console.WriteLine($"\n" +
            $"\t\tWould you like to:\n" +
            $"\t\t 1 Buy\n" +
            $"\t\t 2 Sell\n" +
            $"\t\t 3 Buy Fuel\n" +
            $"\t\t 4 Return to planetary menu");
            int response = Convert.ToInt32(Console.ReadLine());
            return response;
        }

        public void PlanetTravel(double currentPlanetx, double destinationPlanetx, double currentPlanety, double destinationPlanety, Ship ship, PersonalStatus PS, Fuel fuel)
        {
            double distTraveled = (Math.Sqrt(Math.Pow(currentPlanetx - destinationPlanetx, 2) + Math.Pow(currentPlanety - destinationPlanety, 2)));
            double playerWarpSpeed = (Math.Pow(ship.ShipSpeed, 10 / 3) + Math.Pow(10 - ship.ShipSpeed, -11 / 3));
            double time = playerWarpSpeed / distTraveled;
            PS.MyTravelTime += time;
            fuel.MyCurrentFuel -= (int)(distTraveled);
            if (PS.MyTravelTime > 40.0)
                GO.Retire(PS, ship);
        }

        public double PlanetDistance(double currentPlanetx, double destinationPlanetx, double currentPlanety, double destinationPlanety)
        {
            double dist = (Math.Sqrt(Math.Pow(currentPlanetx - destinationPlanetx, 2) + Math.Pow(currentPlanety - destinationPlanety, 2)));
            return dist;
        }

        public string FuelCheck(double currentPlanetx, double destinationPlanetx, double currentPlanety, double destinationPlanety, Ship ship, PersonalStatus PS, Fuel fuel)
        {
            double distTraveled = (Math.Sqrt(Math.Pow(currentPlanetx - destinationPlanetx, 2) + Math.Pow(currentPlanety - destinationPlanety, 2)));
            string fuelCheck = "OK";
            if (fuel.MyCurrentFuel < (distTraveled))
            {
                
                string failedCheck = "TooFar";
                return failedCheck;
            }
            return fuelCheck;
        }

        public void TooFar(double currentPlanetx, double destinationPlanetx, double currentPlanety, double destinationPlanety, Fuel fuel)
        {
            double distTraveled = (Math.Sqrt(Math.Pow(currentPlanetx - destinationPlanetx, 2) + Math.Pow(currentPlanety - destinationPlanety, 2)));
            Console.WriteLine($"" +
                    $"You don't have enough fuel for that trip, you only have {fuel.MyCurrentFuel} amount of fuel\n" +
                    $"you would need {(int)(distTraveled) - fuel.MyCurrentFuel} more fuel to make that trip.");
            Console.ReadLine();
        }

        
    }
}
