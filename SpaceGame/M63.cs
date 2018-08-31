using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class M63
    {
        #region M63

        public void M63Page(LandingPage LP, Shop Shop, ShipYard SY, GameOver GO, PersonalStatus PS, UtilityMethods UM, Ship ship, PlanetInfo PI, Fuel fuel, Asgard Asgard, Earth Earth, AlphaCentari AlphaCentari, M63 M63)
        {
            PS.MyCurrentLocation = "M63";
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine("\n\n" +
                "\tWelcome to the star system M63, named for Messier star cluster circling a black hole.\n" +
                "\tAs you walk into the streets the first thing that you notice is that everything is\n" +
                "\tclean and bright white. None of the architecture has a scrap of color anywhere, the\n" +
                "\tonly exception is the flat holographic ads that are projected up on some of the walls\n" +
                "\tbut even thier colors are muted. The Messinese that you see all wear the same color white\n" +
                "\tof the buildings but in stark contrast their skin is as black as the hole their star orbits" +
                "\n\n\t\tWhere would you like to go? \n" +
                "\t\t1. Ship Yard \n" +
                "\t\t2. Galactic Bank \n" +
                "\t\t3. Buy, Sell, Trade \n" +
                "\t\t4. Galactic Market\n" +
                "\t\t5. Departure Port\n\n" +
                "\t\t9. Quit the Game");
            try
            {
                SelectM63Options(GO, PS, ship, LP, SY, UM, PI, Shop, fuel, Asgard, Earth, AlphaCentari, M63);
            }

            //display if invalid input
            catch (Exception)
            {
                Console.WriteLine("Invalid input, try again! Press any key to continue.");
                Console.ReadLine();

                //recycle to Welcome to m63 after invalid entry  
                return;
            }
        }

        public void SelectM63Options(GameOver GO, PersonalStatus PS, Ship ship, LandingPage LP, ShipYard SY, UtilityMethods UM, PlanetInfo PI, Shop Shop, Fuel fuel, Asgard Asgard, Earth Earth, AlphaCentari AlphaCentari, M63 M63)
        {
            int response = Convert.ToInt32(Console.ReadLine());


            //point of method access after valid user selection
            if (response == 1)
                M63ShipYard(UM, PS, ship, fuel, SY, LP,Shop, GO, PI, Asgard, Earth, AlphaCentari, M63);

            if (response == 2)
                M63Bank(UM, PS, ship, fuel);

            if (response == 3)
                M63Shop(UM, PS, ship, fuel, PI, Shop);

            if (response == 4)
                M63Market(PI, PS, UM, ship, fuel);

            if (response == 5)
                M63Port(LP, Shop, SY, GO, PS, UM, ship, PI, fuel, Asgard, Earth, AlphaCentari, M63);

            if (response == 9)
                GO.EndScreen(PS, ship);

            else
            {
                //loops back to the beginning of earth page
                Console.WriteLine("invalid entry");
                return;
            }
        }

        public void M63Bank(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"\n\n" +
                $"\tTall white columns frame the door to the Messinese Galactic Bank branch.\n" +
                $"\tMen and women dressed in all white are coming and going from the inside.\n" +
                $"\tThe shining white walls of the bank hum with the electricity from the sheer\n" +
                $"\tnumber of data transfers taking place inside. The interior is more of the \n" +
                $"\tsame, white walls and white clothes contrasting sharply with the coal black\n");
            UM.BankDisplay(PS);
            return;
        }

        public void M63Shop(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI, Shop Shop)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine("\n\n" +
                "\tYou've arrived at the shop on M63. Niko, the owner welcomes you to look around at all the goods." +
                "\n\tWe've got the highest quality TV's in the universe!");
            int response = UM.ShopSelector();
            if (response == 1)
                M63Buy(UM, PS, ship, fuel, PI, Shop);
            if (response == 2)
                M63Sell(UM, PS, ship, fuel, PI, Shop);
            if (response == 3)
                fuel.BuyFuel(PS, ship);
            if (response == 4)
                return;
        }

        public void M63Buy(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI, Shop Shop)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"\n\n" +
                $"\tYou have {PS.Cash()} Galactic Credits, what good would you like to buy?\n" +
                $"\t 1 NoBalanceShoes {PI.M63NoBalanceShoes} GC per Unit\n" +
                $"\t 2 Space Gold {PI.M63SpaceGold} GC per Unit\n" +
                $"\t 3 Galactic TV {PI.M63GalacticTVs} GC per Unit \n" +
                $"\t 4 Return to Planetary Menu");
            int response = Convert.ToInt32(Console.ReadLine());

            //Buy Shoes
            if (response == 1)
            {
                Shop.BuyShoes(PI.M63NoBalanceShoes, PS, UM, ship, fuel);
               
            }
            //Buy Gold
            if (response == 2)
            {
                Shop.BuyGold(PI.M63SpaceGold, PS, UM, ship, fuel);
            }

            if (response == 3)
            {
                Shop.BuyTV(PI.M63GalacticTVs, PS, UM, ship, fuel);
            }

            if (response == 4)
            {
                return;
            }
        }

        public void M63Sell(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI, Shop Shop)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"\n\n" +
                $"\tYou have {PS.NoBalanaceShoes} pairs of No Balance Shoes, {PS.SpaceGold} bars of Space Gold & {PS.GalacticTVs} sets of Galactic TVs.\n" +
                $"\tWhich would you like to sell?\n" +
                $"\t 1 No Balance Shoes\n" +
                $"\t 2 Space Gold\n" +
                $"\t 3 Galactic TVs\n" +
                $"\t 4 or Return to the Shop");
            int response = Convert.ToInt32(Console.ReadLine());

            if (response == 1)
            {
                Shop.SellShoes(PI.M63NoBalanceShoes, PS, UM, ship, fuel);
            }
            if (response == 2)
            {
                Shop.SellGold(PI.M63SpaceGold, PS, UM, ship, fuel);
            }
            if (response == 3)
            {
                Shop.SellTV(PI.M63GalacticTVs, PS, UM, ship, fuel);
            }
            if (response == 4)
            {
                return;
            }
        }

        public void M63Port(LandingPage LP, Shop Shop, ShipYard SY, GameOver GO, PersonalStatus PS, UtilityMethods UM, Ship ship, PlanetInfo PI, Fuel fuel, Asgard Asgard, Earth Earth, AlphaCentari AlphaCentari, M63 M63)
        {
            double playerWarpSpeed = (Math.Pow(ship.ShipSpeed, 10 / 3) + Math.Pow(10 - ship.ShipSpeed, -11 / 3));
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"\n\n" +
                $"\tWhere would you like to go?");
            if (UM.FuelCheck(PI.M63XPosition, PI.EarthXPosition, PI.M63YPosition, PI.EarthYPosition, ship, PS, fuel) == "OK")
                Console.WriteLine($"\t<earth> Earth: {UM.PlanetDistance(PI.M63XPosition, PI.EarthXPosition, PI.M63YPosition, PI.EarthYPosition)} Light years away which will take {UM.PlanetDistance(PI.M63XPosition, PI.EarthXPosition, PI.M63YPosition, PI.EarthYPosition) / playerWarpSpeed} years\n");
            if (UM.FuelCheck(PI.M63XPosition, PI.AlphaCentariXPosition, PI.M63YPosition, PI.AlphaCentariYPosition, ship, PS, fuel) == "OK")
                Console.WriteLine($"\t<centari> Alpha Centari: {UM.PlanetDistance(PI.M63XPosition, PI.AlphaCentariXPosition, PI.M63YPosition, PI.AlphaCentariYPosition)} Light years away which will take {UM.PlanetDistance(PI.M63XPosition, PI.AlphaCentariXPosition, PI.M63YPosition, PI.AlphaCentariYPosition) / playerWarpSpeed} years\n");
            if (UM.FuelCheck(PI.M63XPosition, PI.AsgardXPosition, PI.M63YPosition, PI.AsgardYPosition, ship, PS, fuel) == "OK")
                Console.WriteLine($"\t<asgard> Asgard: {UM.PlanetDistance(PI.M63XPosition, PI.AsgardXPosition, PI.M63YPosition, PI.AsgardYPosition)} Light years away which will take {UM.PlanetDistance(PI.M63XPosition, PI.AsgardXPosition, PI.M63YPosition, PI.AsgardYPosition) / playerWarpSpeed} year");
            Console.WriteLine($"\t<return> Return to earth");
            string response = Console.ReadLine();

            if (response == "earth")
            {
                if (UM.FuelCheck(PI.M63XPosition, PI.EarthXPosition, PI.M63YPosition, PI.EarthYPosition, ship, PS, fuel) == "OK")
                {
                    UM.PlanetTravel(PI.M63XPosition, PI.EarthXPosition, PI.M63YPosition, PI.EarthYPosition, ship, PS, fuel);
                    UM.Travel(PS);
                    PS.MyCurrentLocation = "Earth";
                    LP.LandingPagePicker(LP, Shop, SY, GO, PS, UM, ship, PI, fuel, Asgard, Earth, AlphaCentari, M63);
                }
                if (UM.FuelCheck(PI.M63XPosition, PI.EarthXPosition, PI.M63YPosition, PI.EarthYPosition, ship, PS, fuel) == "TooFar")
                {
                    UM.TooFar(PI.M63XPosition, PI.EarthXPosition, PI.M63YPosition, PI.EarthYPosition, fuel);
                    return;
                }
            }
            if (response == "centari")
            {
                if (UM.FuelCheck(PI.M63XPosition, PI.AlphaCentariXPosition, PI.M63YPosition, PI.AlphaCentariYPosition, ship, PS, fuel) == "OK")
                {
                    UM.PlanetTravel(PI.M63XPosition, PI.AlphaCentariXPosition, PI.M63YPosition, PI.AlphaCentariYPosition, ship, PS, fuel);
                    UM.Travel(PS);
                    PS.MyCurrentLocation = "AlphaCentari";
                    LP.LandingPagePicker(LP, Shop, SY, GO, PS, UM, ship, PI, fuel, Asgard, Earth, AlphaCentari, M63);
                }
                if (UM.FuelCheck(PI.M63XPosition, PI.AlphaCentariXPosition, PI.M63YPosition, PI.AlphaCentariYPosition, ship, PS, fuel) == "TooFar")
                {
                    UM.TooFar(PI.M63XPosition, PI.AlphaCentariXPosition, PI.M63YPosition, PI.AlphaCentariYPosition, fuel);
                    return;
                }
            }
            if (response == "asgard")
            {
                if (UM.FuelCheck(PI.M63XPosition, PI.AsgardXPosition, PI.M63YPosition, PI.AsgardYPosition, ship, PS, fuel) == "OK")
                {
                    UM.PlanetTravel(PI.M63XPosition, PI.AsgardXPosition, PI.M63YPosition, PI.AsgardYPosition, ship, PS, fuel);
                    UM.Travel(PS);
                    PS.MyCurrentLocation = "Asgard";
                    LP.LandingPagePicker(LP, Shop, SY, GO, PS, UM, ship, PI, fuel, Asgard, Earth, AlphaCentari, M63);
                }
                if (UM.FuelCheck(PI.M63XPosition, PI.AsgardXPosition, PI.M63YPosition, PI.AsgardYPosition, ship, PS, fuel) == "TooFar")
                {
                    UM.TooFar(PI.M63XPosition, PI.AsgardXPosition, PI.M63YPosition, PI.AsgardYPosition, fuel);
                    return;
                }
            }
            if (response == "return")
            {
                return;
            }
        }

        public void M63ShipYard(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, ShipYard SY, LandingPage LP, Shop Shop, GameOver GO, PlanetInfo PI, Asgard Asgard, Earth Earth, AlphaCentari AlphaCentari, M63 M63)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            // write flavor text about shipyard
            Console.WriteLine("\n\n" +
                "\tYou walk into the Shipyard, the sound of welders and hammers fills the air. Ship salesman are\n" +
                "\tweaving in and out of the ships pushing their latest ship on travelers all the while dodging the laborers.\n" +
                "\t\tWould you like to:\n" +
                "\t\t 1 Check your ship stats\n" +
                "\t\t 2 Buy a new Ship\n" +
                "\t\t 3 Return to planetary hub");
            int response = Convert.ToInt32(Console.ReadLine());
            if (response == 1)
                SY.ShipCheck(PS, ship, UM, fuel);
            if (response == 2)
                SY.PurchaseShip(PS, ship, UM, fuel);
            if (response == 3)
                LP.LandingPagePicker(LP, Shop, SY, GO, PS, UM, ship, PI, fuel, Asgard, Earth, AlphaCentari, M63);
        }

        public void M63Market(PlanetInfo PI, PersonalStatus PS, UtilityMethods UM, Ship ship, Fuel fuel)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"\n\n" +
                $"\tWelcome to the Epic Market on M63, where your opportunity for wealth is boundless and the \n" +
                $"\tproducts are of the most elegant varieties.");
            UM.MarketDisplay(PI);
        }
        #endregion
    }
}
