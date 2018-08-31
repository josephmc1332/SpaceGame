﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Titan
    {
        public void TitanPage(LandingPage LP, Shop Shop, ShipYard SY, GameOver GO, PersonalStatus PS,
           UtilityMethods UM, Ship ship, PlanetInfo PI, Fuel fuel, Asgard asgard, Earth earth, AlphaCentari alpha, M63 m63)
        {
            PS.MyCurrentLocation = "Planet X";




            //display menu on earth upon arrival
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine("Welecome to Titan, --------------------" +
               "\n1. ShipYard" +
               "\n2. Galactic Bank" +
               "\n3. Buy, Sell, Trade" +
               "\n4. Galactic Market" +
               "\n5. Departure Port" +
               "\n9. Quit Game");


            //send back to check selected option after invalid input
            try
            {
                SelectTitanOptions(LP, Shop, SY, GO, PS, UM, ship, PI, fuel, asgard, earth, alpha, m63);
            }

            //display if invalid input
            catch (Exception)
            {
                Console.WriteLine("Invalid input, try again! Press any key to continue.");
                Console.ReadLine();

                //recycle to Welcome to planet x after invalid entry  
                TitanPage(LP, Shop, SY, GO, PS, UM, ship, PI, fuel, asgard, earth, alpha, m63);
            }

        }

        public void SelectTitanOptions(LandingPage LP, Shop shop, ShipYard SY, GameOver GO, PersonalStatus PS, UtilityMethods UM, Ship ship, PlanetInfo PI, Fuel fuel, Asgard asgard, Earth earth, AlphaCentari alpha, M63 m63)
        {
            //convert/parse user input string 
            int response = Convert.ToInt32(Console.ReadLine());

            //point of method access after valid user selection
            if (response == 1)
                ShipYard(UM, PS, ship, fuel, SY);

            if (response == 2)
                Bank(PS, UM, ship, fuel);

            if (response == 3)
                TitanShop(UM, PS, ship, fuel, PI, shop);

            if (response == 4)
                Market(PS, UM, ship, fuel, PI);

            if (response == 5)
                TitanPort(ship, UM, PS, fuel, PI, LP, shop, asgard, m63, earth, alpha, SY, GO);

            if (response == 9)
                GO.EndScreen(PS, ship);

            else
            {
                //loops back to the beginning of planet x page page
                Console.WriteLine("invalid entry");
                TitanPage(LP, shop, SY, GO, PS, UM, ship, PI, fuel, asgard, earth, alpha, m63);
            }
        }


        public void Bank(PersonalStatus PS, UtilityMethods UM, Ship ship, Fuel fuel)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            UM.BankDisplay(PS);
            return;
        }

        public void ShipYard(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, ShipYard SY)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            // write flavor text about shipyard
            Console.WriteLine("\n\n" +
                "\tYou walk into the Shipyard, the sound of welders and hammers fills the air. Ship salesman \n" +
                "\tare weaving in and out of the ships pushing their latest ship on travelers all the while \n" +
                "\tdodging the laborers.\n\n" +
                "\t\tWould you like to:\n" +
                "\t\t  1 Check your ship stats\n" +
                "\t\t  2 Buy a new Ship\n" +
                "\t\t  3 Return to planetary hub");
            int response = Convert.ToInt32(Console.ReadLine());
            if (response == 1)
                SY.ShipCheck(PS, ship, UM, fuel);
            if (response == 2)
                SY.PurchaseShip(PS, ship, UM, fuel);
            if (response == 3)
                return;
        }


        public void TitanShop(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI, Shop shop)
        {

            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine("Welcome to Masterons, my name is Liam. What can I get for you today?");
            int response = UM.ShopSelector();
            if (response == 1)
                Buy(UM, PS, ship, fuel, PI, shop);
            if (response == 2)
                Sell(UM, PS, ship, fuel, PI, shop);
            if (response == 3)
                fuel.BuyFuel(PS, ship);
            if (response == 4)
                return;
        }

        public void Buy(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI, Shop Shop)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"\n\n" +
                $"\tYou have {PS.MyCurrentCredit} Galactic Credits, what good would you like to buy?\n" +
                $"\t 1 NoBalanceShoes 80 GC per Unit\n" +
                $"\t 2 Space Gold 100 GC per Unit\n" +
                $"\t 3 Galactic TV 120 GC per Unit \n" +
                $"\t 4 Return to Shop");
            int response = Convert.ToInt32(Console.ReadLine());
            //Buy Shoes
            if (response == 1)
            {
                Shop.BuyShoes(PI.PlanetXNoBalanceShoes, PS, UM, ship, fuel);
            }
            //Buy Gold
            if (response == 2)
            {
                Shop.BuyGold(PI.PlanetXGold, PS, UM, ship, fuel);
            }

            if (response == 3)
            {
                Shop.BuyTV(PI.PlanetXGalacticTVs, PS, UM, ship, fuel);
            }

            if (response == 4)
            {
                return;
            }
        }
        public void Sell(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI, Shop shop)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"\n\n" +
                $"\tYou have {PS.NoBalanaceShoes} pairs of No Balance Shoes, \n" +
                $"\t{PS.SpaceGold} bars of Space Gold \n" +
                $"\t{PS.GalacticTVs} sets of Galactic TVs.\n" +
                $"\tWhich would you like to sell?\n" +
                $"\t  1 No Balance Shoes\n" +
                $"\t  2 Space Gold\n" +
                $"\t  3 Galactic TVs\n" +
                $"\t  4 or Return to the Shop");
            int response = Convert.ToInt32(Console.ReadLine());

            if (response == 1)
            {
                shop.SellShoes(PI.TitanNoBalanceShoes, PS, UM, ship, fuel);
            }
            if (response == 2)
            {
                shop.SellGold(PI.TitanGold, PS, UM, ship, fuel);
            }
            if (response == 3)
            {
                shop.SellTV(PI.TitanGalacticTVs, PS, UM, ship, fuel);
            }
            if (response == 4)
            {
                TitanShop(UM, PS, ship, fuel, PI, shop);
            }
        }

        public void Market(PersonalStatus PS, UtilityMethods UM, Ship ship, Fuel fuel, PlanetInfo PI)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine("--------- ");
            UM.MarketDisplay(PI);

            Console.ReadLine();
        }

        public void TitanPort(Ship ship, UtilityMethods UM, PersonalStatus PS, Fuel fuel, PlanetInfo PI, LandingPage LP, Shop shop, Asgard Asgard, M63 M63, Earth Earth, AlphaCentari AlphaCentari, ShipYard SY, GameOver GO)
        {
            double playerWarpSpeed = (Math.Pow(ship.ShipSpeed, 10 / 3) + Math.Pow(10 - ship.ShipSpeed, -11 / 3));
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"\n\n" +
                $"\tWhere would you like to go? \n");
            if (UM.FuelCheck(PI.TitanXPosition, PI.AlphaCentariXPosition, PI.TitanYPosition, PI.AlphaCentariYPosition, ship, PS, fuel) == "OK")
                Console.WriteLine($"" +
                    $"\t\t<centari> Alpha Centari: {UM.PlanetDistance(PI.TitanXPosition, PI.AlphaCentariXPosition, PI.TitanYPosition, PI.AlphaCentariYPosition)} Light years away which will take {UM.PlanetDistance(PI.TitanXPosition, PI.AlphaCentariXPosition, PI.TitanXPosition, PI.AlphaCentariYPosition) / playerWarpSpeed} years\n");
            if (UM.FuelCheck(PI.EarthXPosition, PI.M63XPosition, PI.EarthYPosition, PI.M63YPosition, ship, PS, fuel) == "OK")
                Console.WriteLine($"" +
                    $"\t\t<m63> M63: {UM.PlanetDistance(PI.TitanXPosition, PI.M63XPosition, PI.TitanYPosition, PI.M63YPosition)} Light years away which will take {UM.PlanetDistance(PI.TitanXPosition, PI.M63XPosition, PI.TitanYPosition, PI.M63YPosition) / playerWarpSpeed} years\n");
            if (UM.FuelCheck(PI.EarthXPosition, PI.AsgardXPosition, PI.EarthYPosition, PI.AsgardYPosition, ship, PS, fuel) == "OK")
                Console.WriteLine($"" +
                    $"\t\t<asgard> Asgard: {UM.PlanetDistance(PI.TitanXPosition, PI.AsgardXPosition, PI.TitanYPosition, PI.AsgardYPosition)} Light years away which will take {UM.PlanetDistance(PI.TitanXPosition, PI.AsgardXPosition, PI.TitanYPosition, PI.AsgardYPosition) / playerWarpSpeed} years\n");
            if (UM.FuelCheck(PI.TitanXPosition, PI.EarthXPosition, PI.TitanXPosition, PI.EarthYPosition, ship, PS, fuel) == "OK")
                Console.WriteLine($"" +
                    $"\t\t<earth> Earth: {UM.PlanetDistance(PI.TitanXPosition, PI.EarthXPosition, PI.TitanYPosition, PI.EarthYPosition)} Light years away which will take {UM.PlanetDistance(PI.EarthXPosition, PI.TitanXPosition, PI.EarthYPosition, PI.TitanYPosition) / playerWarpSpeed} years\n");



            Console.WriteLine($"" +
                $"\t\t<return> Return to Titan");
            string response = Console.ReadLine();
            if (response == "earth")
            {
                if (UM.FuelCheck(PI.TitanXPosition, PI.EarthXPosition, PI.TitanYPosition, PI.EarthYPosition, ship, PS, fuel) == "OK")
                {
                    UM.PlanetTravel(PI.TitanXPosition, PI.EarthXPosition, PI.TitanYPosition, PI.EarthYPosition, ship, PS, fuel);
                    UM.Travel(PS);
                    PS.MyCurrentLocation = "Earth";
                    LP.LandingPagePicker(LP, shop, SY, GO, PS, UM, ship, PI, fuel, Asgard, Earth, AlphaCentari, M63);
                }
                if (UM.FuelCheck(PI.TitanXPosition, PI.EarthXPosition, PI.TitanYPosition, PI.EarthYPosition, ship, PS, fuel) == "TooFar")
                {
                    UM.TooFar(PI.TitanXPosition, PI.EarthXPosition, PI.TitanYPosition, PI.EarthYPosition, fuel);
                    return;
                }
            }
            if (response == "centari")
            {
                if (UM.FuelCheck(PI.TitanXPosition, PI.AlphaCentariXPosition, PI.TitanYPosition, PI.AlphaCentariYPosition, ship, PS, fuel) == "OK")
                {
                    UM.PlanetTravel(PI.TitanXPosition, PI.AlphaCentariXPosition, PI.TitanYPosition, PI.AlphaCentariYPosition, ship, PS, fuel);
                    UM.Travel(PS);
                    PS.MyCurrentLocation = "AlphaCentari";
                    LP.LandingPagePicker(LP, shop, SY, GO, PS, UM, ship, PI, fuel, Asgard, Earth, AlphaCentari, M63);
                }
                if (UM.FuelCheck(PI.TitanXPosition, PI.AlphaCentariXPosition, PI.TitanYPosition, PI.AlphaCentariYPosition, ship, PS, fuel) == "TooFar")
                {
                    UM.TooFar(PI.TitanXPosition, PI.AlphaCentariXPosition, PI.TitanYPosition, PI.AlphaCentariYPosition, fuel);
                    return;
                }
            }
            if (response == "m63")
            {
                if (UM.FuelCheck(PI.TitanXPosition, PI.M63XPosition, PI.TitanYPosition, PI.M63YPosition, ship, PS, fuel) == "OK")
                {
                    UM.PlanetTravel(PI.TitanXPosition, PI.M63XPosition, PI.TitanYPosition, PI.M63YPosition, ship, PS, fuel);
                    UM.Travel(PS);
                    PS.MyCurrentLocation = "M63";
                    LP.LandingPagePicker(LP, shop, SY, GO, PS, UM, ship, PI, fuel, Asgard, Earth, AlphaCentari, M63);
                }
                if (UM.FuelCheck(PI.TitanXPosition, PI.M63XPosition, PI.TitanYPosition, PI.M63YPosition, ship, PS, fuel) == "TooFar")
                {
                    UM.TooFar(PI.TitanXPosition, PI.M63XPosition, PI.TitanYPosition, PI.M63YPosition, fuel);
                    return;
                }
            }
            if (response == "asgard")
            {
                if (UM.FuelCheck(PI.TitanXPosition, PI.AsgardXPosition, PI.TitanYPosition, PI.AsgardYPosition, ship, PS, fuel) == "OK")
                {
                    UM.PlanetTravel(PI.TitanXPosition, PI.AsgardXPosition, PI.TitanYPosition, PI.AsgardYPosition, ship, PS, fuel);
                    UM.Travel(PS);
                    PS.MyCurrentLocation = "Asgard";
                    LP.LandingPagePicker(LP, shop, SY, GO, PS, UM, ship, PI, fuel, Asgard, Earth, AlphaCentari, M63);
                }
                if (UM.FuelCheck(PI.TitanXPosition, PI.AsgardXPosition, PI.TitanYPosition, PI.AsgardYPosition, ship, PS, fuel) == "TooFar")
                {
                    UM.TooFar(PI.TitanXPosition, PI.AsgardXPosition, PI.TitanYPosition, PI.AsgardYPosition, fuel);
                    return;
                }
            }
            if (response == "return")
            {
                return;
            }
        }


    }
}
