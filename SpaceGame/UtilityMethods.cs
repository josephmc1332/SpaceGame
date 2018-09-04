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
            try
            {
                int response = Convert.ToInt32(Console.ReadLine());
                return response;
            }
            catch
            {
                return 6;
            }
        }

        // this method will stream line all the shipyard menus
        public int ShipYardMenu()
        {
            Console.WriteLine("What would you like to do:\n" +
            "\t\t 1 Check your ship stats\n" +
            "\t\t 2 Buy a new ship\n" +
            "\t\t 3 Return to planetary menu");
            try
            {
                int response = Convert.ToInt32(Console.ReadLine());
                return response;
            }
            catch
            {
                return 3;
            }
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
                $"\t\tGalactic TVs: {PI.PlanetXGalacticTVs}\n" +
                $"\tVormir:\n" +
                $"\t\tNo Balance Shoes: {PI.VormirNoBalanceShoes}\n" +
                $"\t\tSpace Gold: {PI.VormirGold}\n" +
                $"\t\tGalactic TVs {PI.VormirGalacticTVs}\n" +
                $"\tPicium:\n" +
                $"\t\tNo Balance Shoes: {PI.PiciumNoBalanaceShoes}\n" +
                $"\t\tSpace Gold: {PI.PiciumGold}\n" +
                $"\t\tGalactic TVs: {PI.PiciumGalacticTVs}\n" +
                $"\tTitan:\n" +
                $"\t\tNo Balance Shoes: {PI.TitanNoBalanceShoes}\n" +
                $"\t\tSpace Gold: {PI.TitanGold}\n" +
                $"\t\tGalactic TVs: {PI.TitanGalacticTVs}\n" +
                $"\tPlanet Joe:\n" +
                $"\t\tNo Balance Shoes: {PI.PlanetJoeNoBalanceShoes}\n" +
                $"\t\tSpace Gold: {PI.PlanetJoeGold}\n" +
                $"\t\tGalactic TVs: {PI.PlanetJoeGalacticTVs}\n");
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
                Console.WriteLine($"It's lonely out there in space {ps.NameCall()}. You are doing great! Keep it up!");
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
                    $"'Please don't kill us {ps.NameCall()}, we will give you 100 GC if you let us go!' \n" +
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
            try
            {
                int response = Convert.ToInt32(Console.ReadLine());
                return response;
            }
            catch
            {
                return 4;
            }
        }

        public void PlanetTravel(double currentPlanetx, double destinationPlanetx, double currentPlanety, double destinationPlanety, Ship ship, PersonalStatus PS, Fuel fuel)
        {
            double distTraveled = (Math.Sqrt(Math.Pow(currentPlanetx - destinationPlanetx, 2) + Math.Pow(currentPlanety - destinationPlanety, 2)));
            double playerWarpSpeed = (Math.Pow(ship.ShipSpeed, 10 / 3) + Math.Pow(10 - ship.ShipSpeed, -11 / 3));
            double time = distTraveled /playerWarpSpeed;
            PS.AddTime(time);
            fuel.MyCurrentFuel -= ((int)(distTraveled));
            if (PS.TravelAge() > 40.0)
            {
                GO.Retire(PS, ship);
            }
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

        public void PortTravel(double currentX, double destinationX, double currentY, double destinationY, string destination, UtilityMethods UM, PersonalStatus PS, Fuel fuel, Ship ship, PlanetInfo PI, Shop shop, ShipYard SY, LandingPage LP,
            Asgard Asgard, Earth Earth, AlphaCentari AlphaCentari, M63 M63, PlanetX PlanetX, Titan Titan, PlanetJoe planetJoe, Vormir vormir, Picium Picium)
        {
            if (UM.FuelCheck(currentX, destinationX, currentY, destinationY, ship, PS, fuel) == "OK")
            {
                UM.PlanetTravel(currentX, destinationX, currentY, destinationY, ship, PS, fuel);
                UM.Travel(PS);
                PS.LocationChanger(destination);
                LP.LandingPagePicker(LP, shop, SY, GO, PS, UM, ship, PI, fuel, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan, planetJoe, vormir, Picium);
            }
            if (UM.FuelCheck(currentX, destinationX, currentY, destinationY, ship, PS, fuel) == "TooFar")
            {
                UM.TooFar(currentX, destinationX, currentY, destinationY, fuel);
                return;
            }
        }

        public string PortMenu(double currentX, double currentY, UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI )
        {
            
            double playerWarpSpeed = (Math.Pow(ship.ShipSpeed, 10 / 3) + Math.Pow(10 - ship.ShipSpeed, -11 / 3));
            Console.WriteLine($"\n\n" +
                $"\tWhere would you like to go? \n");

            if (UM.FuelCheck(currentX, PI.AlphaCentariXPosition, currentY, PI.AlphaCentariYPosition, ship, PS, fuel) == "OK")

                Console.WriteLine($"" +
                    $"\t\t<centari> Alpha Centari : {UM.PlanetDistance(currentX, PI.AlphaCentariXPosition, currentY, PI.AlphaCentariYPosition)} Light years away which will take {UM.PlanetDistance(currentX, PI.AlphaCentariXPosition, currentY, PI.AlphaCentariYPosition) / playerWarpSpeed} years\n");

            if (UM.FuelCheck(currentX, PI.AsgardXPosition, currentY, PI.AsgardYPosition, ship, PS, fuel) == "OK")

                Console.WriteLine($"" +
                    $"\t\t<asgard> Asgard : {UM.PlanetDistance(currentX, PI.AsgardXPosition, currentY, PI.AsgardYPosition)} Light years away which will take {UM.PlanetDistance(currentX, PI.AsgardXPosition, currentY, PI.AsgardYPosition) / playerWarpSpeed} years\n");

            if (UM.FuelCheck(currentX, PI.EarthXPosition, currentY, PI.EarthYPosition, ship, PS, fuel) == "OK")

                Console.WriteLine($"" +
                    $"\t\t<earth> Earth : {UM.PlanetDistance(currentX, PI.EarthXPosition, currentY, PI.EarthYPosition)} Light years away which will take {UM.PlanetDistance(currentX, PI.EarthXPosition, currentY, PI.EarthYPosition) / playerWarpSpeed} years\n");

            if (UM.FuelCheck(currentX, PI.M63XPosition, currentY, PI.M63YPosition, ship, PS, fuel) == "OK")

                Console.WriteLine($"" +
                    $"\t\t<m63> M63 : {UM.PlanetDistance(currentX, PI.M63XPosition, currentY, PI.M63YPosition)} Light years away which will take {UM.PlanetDistance(currentX, PI.M63XPosition,currentY, PI.M63YPosition) / playerWarpSpeed} years\n");

            if (UM.FuelCheck(currentX, PI.PlanetXXPosition, currentY, PI.PlanetXYPosition, ship, PS, fuel) == "OK")

                Console.WriteLine($"" +
                    $"\t\t<x> Planet X : {UM.PlanetDistance(currentX, PI.PlanetXXPosition, currentY, PI.PlanetXYPosition)} Light years away which will take {UM.PlanetDistance(currentX, PI.PlanetXXPosition, currentY, PI.PlanetXYPosition) / playerWarpSpeed} years\n");

            if (UM.FuelCheck(currentX, PI.TitanXPosition, currentY, PI.TitanYPosition, ship, PS, fuel) == "OK")

                Console.WriteLine($"" +
                    $"\t\t<titan> Titan : {UM.PlanetDistance(currentX, PI.TitanXPosition, currentY, PI.TitanYPosition)} Light years away which will take {UM.PlanetDistance(currentX, PI.TitanXPosition, currentY, PI.TitanYPosition) / playerWarpSpeed} years\n");

            if (UM.FuelCheck(currentX, PI.VormirXPosition, currentY, PI.VormirYPosition, ship, PS, fuel) == "OK")

                Console.WriteLine($"" +
                    $"\t\t<x> Planet X : {UM.PlanetDistance(currentX, PI.VormirXPosition, currentY, PI.VormirYPosition)} Light years away which will take {UM.PlanetDistance(currentX, PI.VormirXPosition, currentY, PI.VormirYPosition) / playerWarpSpeed} years\n");

            if (UM.FuelCheck(currentX, PI.PiciumXPosition, currentY, PI.PiciumYPosition, ship, PS, fuel) == "OK")

                Console.WriteLine($"" +
                     $"\t\t<picium> Picium : {UM.PlanetDistance(currentX, PI.PiciumXPosition, currentY, PI.PiciumYPosition)} Light years away which will take {UM.PlanetDistance(currentX, PI.PiciumXPosition, currentY, PI.PiciumYPosition) / playerWarpSpeed} years\n");

            Console.WriteLine($"" +
                $"\t\t<return> Return to earth");
            string response = Console.ReadLine();
            return response;
        }

        
    }
}
