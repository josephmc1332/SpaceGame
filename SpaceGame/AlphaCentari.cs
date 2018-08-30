using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class AlphaCentari
    {
        #region AlphaCentari

        public void AlphaCentariPage(LandingPage LP, Shop Shop, ShipYard SY, GameOver GO, PersonalStatus PS, UtilityMethods UM, Ship ship, PlanetInfo PI, Fuel fuel, Asgard Asgard, Earth Earth)
        {
            PS.MyCurrentLocation = "AlphaCentari";
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.Write("\n\n" +
                "\tWelcome to Alpha Centari! You stand in the port city of Macawalani. Centarian birdpeople fly to and fro. \n" +
                "\tYou spot a few pairs of No Balances here and there but whats the point when you have wings? \n" +
                "\tStilted building dominate the skyline, your human sensability is assualted by the seemingly \n" +
                "\trandom way the doors are arranged until you see a Centarian fly up to a sixth floor door and\n" +
                "\tenter the building. The air is surprisingly clear from the lack of vehicles in the city center.\n" +
                "\tIt's not just Centarians though, you see a large amount of humans from your own region of space, \n" +
                "\tsome are earth humans but you spot a blue Venusian and a orange mercurian amoung them. \n" +
                "\tComing out of the docks you even spot a Pician fellow his telltale glass helmet \n" +
                "\tkeeping his gills underwater. \n\n" +
                "\t\tWhere would you like to go? \n" +
                "\t\t 1. Ship Yard \n" +
                "\t\t 2. Galactic Bank of Centari IV \n" +
                "\t\t 3. Buy, Sell, Trade \n" +
                "\t\t 4. Galactic Stock Exchange\n" +
                "\t\t 5. Departure Port\n\n" +
                "\t\t 9. Quit game\n" +
                "\t\t Enter your choice: ");
            AlphaCentariSelector(GO, PS, ship, PI, fuel, UM, LP, SY, Shop, Asgard, Earth);
        }

        public void AlphaCentariSelector(GameOver GO, PersonalStatus PS, Ship ship, PlanetInfo PI, Fuel fuel, UtilityMethods UM, LandingPage LP, ShipYard SY, Shop Shop, Asgard Asgard, Earth Earth)
        {

            int response = Convert.ToInt32(Console.ReadLine());

            if (response == 1)
                AlphaYard(UM, PS, ship, fuel, SY, LP);

            if (response == 2)
                AlphaBank(UM, PS, ship, fuel);

            if (response == 3)
                AlphaShop(UM, PS, ship, fuel, PI, Shop);

            if (response == 4)
                AlphaMarket(UM, PS, ship, fuel, PI);

            if (response == 5)
                AlphaCentariPort(ship, PI, PS, fuel, UM, LP, SY, GO, Shop, Asgard, Earth);

            if (response == 9)
                GO.EndScreen(PS, ship);

            else
            {
                Console.WriteLine("invalid entry");
                return;
            }
        }

        public void AlphaYard(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, ShipYard SY, LandingPage LP)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            // write flavor text about shipyard
            Console.WriteLine("\n\n" +
                "\tYou walk into the Shipyard, the sound of welders and hammers fills the air. Ship\n" +
                "\tsalesman are weaving in and out of the ships pushing their latest ship on travelers\n" +
                "\tall the while dodging the laborers.\n" +
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
                LP.LandingPagePicker();
        }

        public void AlphaShop(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI, Shop Shop)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine("\n\n" +
                "\t\tYou arrive at the shop on Alpha Centari. The owner, Brahman welcomes you. 'What's up, \n" +
                "\t\tmane you know that we have the highest quality gold in the universe!'");
            int response = UM.ShopSelector();
            if (response == 1)
                AlphaBuy(UM, PS, ship, fuel, PI, Shop);
            if (response == 2)
                AlphaSell(UM, PS, ship, fuel, PI);
            if (response == 3)
                fuel.BuyFuel(PS, ship);
            if (response == 4)
                return;
        }

        public void AlphaBank(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"" +
                $"Welcome to the Galactic Bank of Centari Four! Behind the counter is an tall old bird, his \n" +
                $"specticles are low on his beak and attached to his head by a gold chain.\n" +
                $"The high ceilings make room for doors on many levels but with no visable landing, \n" +
                $"of course ground based humans like you have to come in through the 'walkers' door.\n");
            UM.BankDisplay(PS);
            Console.ReadLine();
            return;
        }

        public void AlphaBuy(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI, Shop Shop)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"You have {PS.MyCurrentCredit} Galactic Credits, what good would you like to buy?\n " +
                $"1 NoBalanceShoes {PI.AlphaCentariNoBalanceShoes} GC per Unit\n" +
                $"2 Space Gold {PI.AlphaCentariGold} GC per Unit\n" +
                $"3 Galactic TV {PI.AlphaCentariGalacticTVs} GC per Unit \n" +
                $"4 Return to the Shop");
            int response = Convert.ToInt32(Console.ReadLine());
            //Buy Shoes
            if (response == 1)
            {
                Shop.BuyShoes(PI.AlphaCentariNoBalanceShoes, PS, UM, ship, fuel);
            }
            //Buy Gold
            if (response == 2)
            {
                Shop.BuyGold(PI.AlphaCentariGold, PS, UM, ship, fuel);
            }

            if (response == 3)
            {
                Shop.BuyTV(PI.AlphaCentariGalacticTVs, PS, UM, ship, fuel);
            }

            if (response == 4)
            {
                return;
            }
        }

        public void AlphaSell(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"You have {PS.NoBalanaceShoes} pairs of No Balance Shoes, {PS.SpaceGold} bars of Space Gold & {PS.GalacticTVs} sets of Galactic TVs." +
                $" Which would you like to sell?\n 1 No Balance Shoes\n 2 Space Gold\n 3 Galactic TVs\n 4 or Return to the Shop");
            int response = Convert.ToInt32(Console.ReadLine());

            bool Shoes = response == 1;
            bool Gold = response == 2;
            bool TV = response == 3;
            bool Return = response == 4;

            if (Shoes)
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
                PS.MyCurrentCredit += (quantity * PI.AlphaCentariNoBalanceShoes);
                Console.WriteLine($"Thank you for the No Balance Shoes, you can jump so high when gravity doesn't affect your feet!\nYou sold {quantity} No Balance Shoes for {(quantity * PI.AlphaCentariNoBalanceShoes)} Galactic Credits.\n" +
                    $"You now have {PS.MyCurrentCredit} Galactic Credits and {PS.NoBalanaceShoes} No Balanace Shoes.\n Press any key to continue...");
                Console.ReadLine();
                return;
            }
            if (Gold)
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
                PS.MyCurrentCredit += (quantity * PI.AlphaCentariGold);
                Console.WriteLine($"Thanks for the Space Gold, Space Gold is so much more shiny than boring old regular gold!\nYou sold {quantity} bars of Space Gold for {(quantity * PI.AlphaCentariGold)} Galactic Credits.\n" +
                    $"You now have {PS.MyCurrentCredit} Galactic Credits and {PS.SpaceGold} bars of Space Gold left.\n Press any key to continue...");
                Console.ReadLine();
                return;
            }
            if (TV)
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
                PS.MyCurrentCredit += (quantity * PI.AlphaCentariGalacticTVs);
                Console.WriteLine($"Thank you for the Galactic TVs I can't believe how thin they are!\nYou sold {quantity} Galactic TVs for {(quantity * PI.AlphaCentariGalacticTVs)} Galactic Credits.\n" +
                    $"You now have {PS.MyCurrentCredit} Galactic Credits and {PS.GalacticTVs} Galactic TVs left.\n Press any key to continue...");
                Console.ReadLine();
                return;
            }
            if (Return)
            {
                return;
            }

        }

        public void AlphaMarket(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"" +
                $"The city of Macawalani on Centari IV has the largest stock exchange for a light year in any direction.\n" +
                $"But unlike the exchanges of earth it's nearly silent in the exchange. The Centarians are famously capatalistic and the \n" +
                $"Macawalani exchange is almost like a temple. But it takes you hardly any time at all to find the entries of your\n" +
                $"classic moneymakers...\n");
            UM.MarketDisplay(PI);
        }

        public void AlphaCentariPort(Ship ship, PlanetInfo PI, PersonalStatus PS, Fuel fuel, UtilityMethods UM, LandingPage LP, ShipYard SY, GameOver GO, Shop Shop, Asgard Asgard, Earth Earth)
        {

            double playerWarpSpeed = (Math.Pow(ship.ShipSpeed, 10 / 3) + Math.Pow(10 - ship.ShipSpeed, -11 / 3));
            Console.Clear();
            Console.WriteLine($"" +
                $"Wind swirls around you as a ships takes off to some new and exciting destination.\n" +
                $"Ports like this always make you miss home a little but the dream of the \n" +
                $"Dukedom of Mercury and the thoughts of your upcoming(hopefully)\n" +
                $"nuptuals drive you forward.");
            Console.WriteLine($"\n\n" +
           $"\tWhere would you like to go? \n");
            if (UM.FuelCheck(PI.AlphaCentariXPosition, PI.EarthXPosition, PI.AlphaCentariYPosition, PI.EarthYPosition, ship, PS, fuel) == "OK")
                Console.WriteLine($"" +
                    $"\t\t<earth> Earth: {UM.PlanetDistance(PI.AlphaCentariXPosition, PI.EarthXPosition, PI.AlphaCentariYPosition, PI.EarthYPosition)} Light years away which will take {UM.PlanetDistance(PI.EarthXPosition, PI.AlphaCentariXPosition, PI.EarthYPosition, PI.AlphaCentariYPosition) / playerWarpSpeed} years\n");
            if (UM.FuelCheck(PI.AlphaCentariXPosition, PI.M63XPosition, PI.AlphaCentariYPosition, PI.M63YPosition, ship, PS, fuel) == "OK")
                Console.WriteLine($"" +
                    $"\t\t<m63> M63: {UM.PlanetDistance(PI.AlphaCentariXPosition, PI.M63XPosition, PI.AlphaCentariYPosition, PI.M63YPosition)} Light years away which will take {UM.PlanetDistance(PI.EarthXPosition, PI.M63XPosition, PI.EarthYPosition, PI.M63YPosition) / playerWarpSpeed} years\n");
            if (UM.FuelCheck(PI.AlphaCentariXPosition, PI.AsgardXPosition, PI.AlphaCentariYPosition, PI.AsgardYPosition, ship, PS, fuel) == "OK")
                Console.WriteLine($"" +
                    $"\t\t<asgard> Asgard: {UM.PlanetDistance(PI.AlphaCentariXPosition, PI.AsgardXPosition, PI.AlphaCentariYPosition, PI.AsgardYPosition)} Light years away which will take {UM.PlanetDistance(PI.EarthXPosition, PI.AsgardXPosition, PI.EarthYPosition, PI.AsgardYPosition) / playerWarpSpeed} years\n");
            Console.WriteLine($"" +
                $"\t\t<return> Return to Alpha Centari");
            string response = Console.ReadLine();
            if (response == "earth")
            {
                if (UM.FuelCheck(PI.AlphaCentariXPosition, PI.EarthXPosition, PI.AlphaCentariYPosition, PI.EarthYPosition, ship, PS, fuel) == "OK")
                {
                    UM.PlanetTravel(PI.AlphaCentariXPosition, PI.EarthXPosition, PI.AlphaCentariYPosition, PI.EarthYPosition, ship, PS, fuel);
                    UM.Travel(PS);
                    PS.MyCurrentLocation = "Earth";
                    LP.LandingPagePicker();
                }
                if (UM.FuelCheck(PI.AlphaCentariXPosition, PI.EarthXPosition, PI.AlphaCentariYPosition, PI.EarthYPosition, ship, PS, fuel) == "TooFar")
                {
                    UM.TooFar(PI.AlphaCentariXPosition, PI.EarthXPosition, PI.AlphaCentariYPosition, PI.EarthYPosition, fuel);
                    return;
                }
            }
            if (response == "M63")
            {
                if (UM.FuelCheck(PI.AlphaCentariXPosition, PI.M63XPosition, PI.AlphaCentariYPosition, PI.M63YPosition, ship, PS, fuel) == "OK")
                {
                    UM.PlanetTravel(PI.AlphaCentariXPosition, PI.M63XPosition, PI.AlphaCentariYPosition, PI.M63YPosition, ship, PS, fuel);
                    UM.Travel(PS);
                    PS.MyCurrentLocation = "M63";
                    LP.LandingPagePicker();
                }
                if (UM.FuelCheck(PI.AlphaCentariXPosition, PI.M63XPosition, PI.AlphaCentariYPosition, PI.M63YPosition, ship, PS, fuel) == "TooFar")
                {
                    UM.TooFar(PI.AlphaCentariXPosition, PI.M63XPosition, PI.AlphaCentariYPosition, PI.M63YPosition, fuel);
                    return;
                }
            }
            if (response == "asgard")
            {
                if (UM.FuelCheck(PI.AlphaCentariXPosition, PI.AsgardXPosition, PI.AlphaCentariYPosition, PI.AsgardYPosition, ship, PS, fuel) == "OK")
                {
                    UM.PlanetTravel(PI.AlphaCentariXPosition, PI.AsgardXPosition, PI.AlphaCentariYPosition, PI.AsgardYPosition, ship, PS, fuel);
                    UM.Travel(PS);
                    PS.MyCurrentLocation = "Asgard";
                    LP.LandingPagePicker();
                }
                if (UM.FuelCheck(PI.AlphaCentariXPosition, PI.AsgardXPosition, PI.AlphaCentariYPosition, PI.AsgardYPosition, ship, PS, fuel) == "TooFar")
                {
                    UM.TooFar(PI.AlphaCentariXPosition, PI.AsgardXPosition, PI.AlphaCentariYPosition, PI.AsgardYPosition, fuel);
                    return;
                }
            }
            if (response == "return")
            {
                return;
            }
        }
        #endregion
    }
}
