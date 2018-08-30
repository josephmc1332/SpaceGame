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

        public void M63Page(LandingPage LP, Shop Shop, ShipYard SY, GameOver GO, PersonalStatus PS, UtilityMethods UM, Ship ship, PlanetInfo PI, Fuel fuel, Asgard Asgard, Earth Earth)
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
                SelectM63Options(GO, PS, ship, LP, SY, UM, PI, Shop, fuel, Asgard, Earth);
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

        public void SelectM63Options(GameOver GO, PersonalStatus PS, Ship ship, LandingPage LP, ShipYard SY, UtilityMethods UM, PlanetInfo PI, Shop Shop, Fuel fuel, Asgard Asgard, Earth Earth)
        {
            int response = Convert.ToInt32(Console.ReadLine());

            //evaluate user input by using boolean expressions
            bool shipYard = response == 1;
            bool galacticBank = response == 2;
            bool shop = response == 3;
            bool market = response == 4;
            bool port = response == 5;
            bool quit = response == 9;


            //point of method access after valid user selection
            if (response == 1)
                M63ShipYard(UM, PS, ship, fuel, SY, LP);

            if (response == 2)
                M63Bank(UM, PS, ship, fuel);

            if (response == 3)
                M63Shop(UM, PS, ship, fuel, PI);

            if (response == 4)
                M63Market(PI, PS, UM, ship, fuel);

            if (response == 5)
                M63Port(LP, Shop, SY, GO, PS, UM, ship, PI, fuel, Asgard, Earth);

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
            Console.WriteLine($"" +
                $"Tall white columns frame the door to the Messinese Galactic Bank branch.\n" +
                $"Men and women dressed in all white are coming and going from the inside.\n" +
                $"The shining white walls of the bank hum with the electricity from the sheer\n" +
                $"number of data transfers taking place inside. The interior is more of the \n" +
                $"same, white walls and white clothes contrasting sharply with the coal black\n");
            UM.BankDisplay(PS);
            return;
        }

        public void M63Shop(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine("You've arrived at the shop on M63. Niko, the owner welcomes you to look around at all the goods." +
                "\nWe've got the highest quality TV's in the universe!");
            int response = UM.ShopSelector();
            if (response == 1)
                M63Buy(UM, PS, ship, fuel, PI);
            if (response == 2)
                M63Sell(UM, PS, ship, fuel, PI);
            if (response == 3)
                fuel.BuyFuel(PS, ship);
            if (response == 4)
                return;
        }

        public void M63Buy(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"You have {PS.MyCurrentCredit} Galactic Credits, what good would you like to buy?\n " +
                $"1 NoBalanceShoes {PI.M63NoBalanceShoes} GC per Unit\n 2 Space Gold {PI.M63SpaceGold} GC per Unit\n 3 Galactic TV {PI.M63GalacticTVs} GC per Unit \n 4 " +
                $"Return to Planetary Menu");
            int response = Convert.ToInt32(Console.ReadLine());

            //Buy Shoes
            if (response == 1)
            {
                Console.WriteLine("How many?");
                int quantity = Convert.ToInt32(Console.ReadLine());
                if ((quantity * PI.M63NoBalanceShoes) > PS.MyCurrentCredit)
                {
                    Console.WriteLine("You can't afford that! \n" +
                        "Press any key to return to the Shop..");
                    Console.ReadLine();
                    return;
                }
                if ((quantity + PS.GalacticTVs + PS.SpaceGold + PS.NoBalanaceShoes) > ship.ShipCapacity)
                {
                    Console.WriteLine($"You don't have room for that! You currently" +
                        $" have {(ship.ShipCapacity - (PS.SpaceGold + PS.GalacticTVs + PS.NoBalanaceShoes))} space left in your cargo hold\n" +
                        $"Press any key to continue...");
                    Console.ReadLine();
                    return;
                }
                PS.MyCurrentCredit -= (quantity * PI.M63NoBalanceShoes);

                PS.NoBalanaceShoes += quantity;

                Console.WriteLine($"you bought {quantity} NoBalance Shoes for {PI.M63NoBalanceShoes * quantity} GC, your new balance is {PS.MyCurrentCredit} GC \n " +
                    $"You now have {PS.NoBalanaceShoes} pairs of No Balanace Shoes in your ship.\n Press any key to continue..");

                Console.ReadLine();
                return;
            }
            //Buy Gold
            if (response == 2)
            {
                Console.WriteLine("How many?");
                int quantity = Convert.ToInt32(Console.ReadLine());
                if ((quantity * PI.M63SpaceGold) > PS.MyCurrentCredit)
                {
                    Console.WriteLine("You can't afford that! \n" +
                        "Press any key to return to the Shop..");
                    Console.ReadLine();
                    return;
                }
                if ((quantity + PS.GalacticTVs + PS.SpaceGold + PS.NoBalanaceShoes) > ship.ShipCapacity)
                {
                    Console.WriteLine($"You don't have room for that! You currently" +
                        $" have {(ship.ShipCapacity - (PS.SpaceGold + PS.GalacticTVs + PS.NoBalanaceShoes))} space left in your cargo hold\n" +
                        $"Press any key to continue...");
                    Console.ReadLine();
                    return;
                }
                PS.MyCurrentCredit -= (quantity * PI.M63SpaceGold);

                PS.SpaceGold += quantity;

                Console.WriteLine($"you bought {quantity} Bars of Space Gold, your new balance is {PS.MyCurrentCredit} \n " +
                    $" You have {PS.SpaceGold} bars of Space Gold in your spaceship.\n Press any key to continue..");
                Console.ReadLine();
                return;
            }

            if (response == 3)
            {
                Console.WriteLine("How many?");
                int quantity = Convert.ToInt32(Console.ReadLine());
                if ((quantity * PI.M63GalacticTVs) > PS.MyCurrentCredit)
                {
                    Console.WriteLine("You can't afford that! \n" +
                        "Press any key to return to the Shop..");
                    Console.ReadLine();
                    return;
                }
                if ((quantity + PS.GalacticTVs + PS.SpaceGold + PS.NoBalanaceShoes) > ship.ShipCapacity)
                {
                    Console.WriteLine($"You don't have room for that! You currently" +
                        $" have {(ship.ShipCapacity - (PS.SpaceGold + PS.GalacticTVs + PS.NoBalanaceShoes))} space left in your cargo hold\n" +
                        $"Press any key to continue...");
                    Console.ReadLine();
                    return;
                }
                PS.MyCurrentCredit -= (quantity * PI.M63GalacticTVs);

                PS.GalacticTVs += quantity;



                Console.WriteLine($"you bought {quantity} Galactic TV(s), your new balance is {PS.MyCurrentCredit} \n " +
                    $"You now have {PS.GalacticTVs} Galactic Tvs in your ship. \n Press any key to continue..");
                Console.ReadLine();
                return;
            }

            if (response == 4)
            {
                return;
            }
        }

        public void M63Sell(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"You have {PS.NoBalanaceShoes} pairs of No Balance Shoes, {PS.SpaceGold} bars of Space Gold & {PS.GalacticTVs} sets of Galactic TVs." +
                $" Which would you like to sell?\n 1 No Balance Shoes\n 2 Space Gold\n 3 Galactic TVs\n 4 or Return to the Shop");
            int response = Convert.ToInt32(Console.ReadLine());

            if (response == 1)
            {
                Console.WriteLine("How many No Balance Shoes would you like to offload?");
                int quantity = Convert.ToInt32(Console.ReadLine());
                if (quantity > PS.NoBalanaceShoes)
                {
                    Console.WriteLine($"You don't have that many shoes!\n You only have {PS.NoBalanaceShoes} pairs of No Balance Shoes. \nPress any key to return to the selling menu...");
                    Console.ReadLine();
                    return;
                }
                PS.NoBalanaceShoes -= quantity;
                PS.MyCurrentCredit += (quantity * PI.M63NoBalanceShoes);
                Console.WriteLine($"Thank you for the No Balance Shoes, you can jump so high when gravity doesn't affect your feet!\nYou sold {quantity} No Balance Shoes for {(quantity * PI.M63NoBalanceShoes)} Galactic Credits.\n" +
                    $"You now have {PS.MyCurrentCredit} Galactic Credits and {PS.NoBalanaceShoes} No Balanace Shoes.\n Press any key to continue...");
                Console.ReadLine();
                return;
            }
            if (response == 2)
            {
                Console.WriteLine("How much Space Gold do you want sell?");
                int quantity = Convert.ToInt32(Console.ReadLine());
                if (quantity > PS.SpaceGold)
                {
                    Console.WriteLine($"You don't have that much Space Gold!\nYou only have {PS.SpaceGold} bars of Space Gold. \nPress any key to return to the selling menu...");
                    Console.ReadLine();
                    return;
                }
                PS.SpaceGold -= quantity;
                PS.MyCurrentCredit += (quantity * PI.M63SpaceGold);
                Console.WriteLine($"Thanks for the Space Gold, Space Gold is so much more shiny than boring old regular gold!\nYou sold {quantity} bars of Space Gold for {(quantity * PI.M63SpaceGold)} Galactic Credits.\n" +
                    $"You now have {PS.MyCurrentCredit} Galactic Credits and {PS.SpaceGold} bars of Space Gold left.\n Press any key to continue...");
                Console.ReadLine();
                return;
            }
            if (response == 3)
            {
                Console.WriteLine("How many TVs do you want to sell?");
                int quantity = Convert.ToInt32(Console.ReadLine());
                if (quantity > PS.GalacticTVs)
                {
                    Console.WriteLine($"You don't have that many Galactic TVs, you only have {PS.GalacticTVs}.\n Press any key to return to the selling menu...");
                    Console.ReadLine();
                    return;
                }
                PS.GalacticTVs -= quantity;
                PS.MyCurrentCredit += (quantity * PI.M63GalacticTVs);
                Console.WriteLine($"Thank you for the Galactic TVs I can't believe how thin they are!\nYou sold {quantity} Galactic TVs for {(quantity * PI.M63GalacticTVs)} Galactic Credits.\n" +
                    $"You now have {PS.MyCurrentCredit} Galactic Credits and {PS.GalacticTVs} Galactic TVs left.\n Press any key to continue...");
                Console.ReadLine();
                return;
            }
            if (response == 4)
            {
                return;
            }
        }

        public void M63Port(LandingPage LP, Shop Shop, ShipYard SY, GameOver GO, PersonalStatus PS, UtilityMethods UM, Ship ship, PlanetInfo PI, Fuel fuel, Asgard Asgard, Earth Earth)
        {
            double playerWarpSpeed = (Math.Pow(ship.ShipSpeed, 10 / 3) + Math.Pow(10 - ship.ShipSpeed, -11 / 3));
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"Where would you like to go?");
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
                    LP.LandingPagePicker();
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
                    LP.LandingPagePicker();
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
                    LP.LandingPagePicker();
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

        public void M63ShipYard(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, ShipYard SY, LandingPage LP)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            // write flavor text about shipyard
            Console.WriteLine("You walk into the Shipyard, the sound of welders and hammers fills the air. Ship salesman are weaving in and out of" +
                "the ships pushing their latest ship on travelers all the while dodging the laborers.\n" +
                "Would you like to:\n" +
                " 1 Check your ship stats\n" +
                " 2 Buy a new Ship\n" +
                " 3 Return to planetary hub");
            int response = Convert.ToInt32(Console.ReadLine());
            if (response == 1)
                SY.ShipCheck(PS, ship, UM, fuel);
            if (response == 2)
                SY.PurchaseShip(PS, ship, UM, fuel);
            if (response == 3)
                LP.LandingPagePicker();
        }

        public void M63Market(PlanetInfo PI, PersonalStatus PS, UtilityMethods UM, Ship ship, Fuel fuel)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"" +
                $"Welcome to the Epic Market on M63, where your opportunity for wealth is boundless and the products are of the most elegant varieties. " +
                $"  \nEarth: \n\tNo Balance Shoes: {PI.EarthNoBalanceShoes} \n\tSpace Gold: {PI.EarthSpaceGold} \n\tGalactic TVs: {PI.EarthGalacticTVs}" +
                $"\n \nAlpha Centari:\n\t No Balance Shoe: {PI.AlphaCentariNoBalanceShoes}\n\tSpace Gold: {PI.AlphaCentariGold}\n\tGalactic " +
                $"TVs: {PI.AlphaCentariGalacticTVs}\n \nM63:\n\t No Balance Shoes: {PI.M63NoBalanceShoes}" +
                $"\n\tSpace Gold: {PI.M63SpaceGold}\n\tGalactic TVs: {PI.M63GalacticTVs} \n" +
                $"Press enter to return to the Messien streets...");
            Console.ReadLine();
        }
        #endregion

    }
}
