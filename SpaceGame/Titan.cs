using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Titan
    {
        public void TitanPage(LandingPage LP, Shop Shop, ShipYard SY, GameOver GO, PersonalStatus PS,
           UtilityMethods UM, Ship ship, PlanetInfo PI, Fuel fuel, Asgard asgard, Earth earth, AlphaCentari alpha, M63 m63, 
           PlanetX PlanetX, Titan Titan, PlanetJoe planetJoe, Vormir vormir)
        {
            PS.LocationChanger("Titan");




            //display menu on earth upon arrival
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine("Welecome to Titan, the oldest planet in the universe. This planet has survived every disaster in history and still stands tall as" +
                "\none of the universal leaders. We excel in importing and exporting the most desirable goods in the universe. Our world leader is Dwayne Johnson, " +
                "\nso you could say we are all pretty yoked due to his anabolic policy." +
               "\n1. ShipYard" +
               "\n2. Galactic Bank" +
               "\n3. Buy, Sell, Trade" +
               "\n4. Galactic Market" +
               "\n5. Departure Port" +
               "\n9. Quit Game");


            //send back to check selected option after invalid input
            try
            {
                SelectTitanOptions(LP, Shop, SY, GO, PS, UM, ship, PI, fuel, asgard, earth, alpha, m63, PlanetX, Titan, planetJoe, vormir);
            }

            //display if invalid input
            catch (Exception)
            {
                Console.WriteLine("Invalid input, try again! Press any key to continue.");
                Console.ReadLine();

                //recycle to Welcome to planet x after invalid entry  
                TitanPage(LP, Shop, SY, GO, PS, UM, ship, PI, fuel, asgard, earth, alpha, m63, PlanetX, Titan, planetJoe, vormir);
            }

        }

        public void SelectTitanOptions(LandingPage LP, Shop shop, ShipYard SY, GameOver GO, PersonalStatus PS, UtilityMethods UM, 
            Ship ship, PlanetInfo PI, Fuel fuel, Asgard asgard, Earth earth, AlphaCentari alpha, M63 m63, 
            PlanetX PlanetX, Titan Titan, PlanetJoe planetJoe, Vormir vormir)
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
                TitanPort(ship, UM, PS, fuel, PI, LP, shop, asgard, m63, earth, alpha, SY, GO, PlanetX, Titan, planetJoe, vormir);

            if (response == 9)
                GO.EndScreen(PS, ship);

            else
            {
                //loops back to the beginning of planet x page page
                Console.WriteLine("invalid entry");
                TitanPage(LP, shop, SY, GO, PS, UM, ship, PI, fuel, asgard, earth, alpha, m63, PlanetX, Titan, planetJoe, vormir);
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
            Console.WriteLine("Welcome to Masterons, my name is Liam. This is a one of a kind shop we have got here.\n" +
                "The gym is in the back if you feel like getting a quick pump in between your travels. What can I get for you today?");
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
                $"\tYou have {PS.Cash()} Galactic Credits, what good would you like to buy?\n" +
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

        public void TitanPort(Ship ship, UtilityMethods UM, PersonalStatus PS, Fuel fuel, PlanetInfo PI, LandingPage LP, 
            Shop shop, Asgard Asgard, M63 M63, Earth Earth, AlphaCentari AlphaCentari, ShipYard SY, GameOver GO, 
            PlanetX PlanetX, Titan Titan, PlanetJoe planetJoe, Vormir vormir)
        {
            double playerWarpSpeed = (Math.Pow(ship.ShipSpeed, 10 / 3) + Math.Pow(10 - ship.ShipSpeed, -11 / 3));
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);

            UM.PortMenu(PI.TitanXPosition, PI.TitanYPosition, UM, PS, ship, fuel, PI);

            string response = Console.ReadLine();
            if (response == "earth")
            {
                UM.PortTravel(PI.TitanXPosition, PI.EarthXPosition, PI.TitanYPosition, PI.EarthYPosition, "Earth", UM, PS, fuel, ship, PI, shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan, planetJoe, vormir);
            }
            if (response == "centari")
            {
                UM.PortTravel(PI.TitanXPosition, PI.AlphaCentariXPosition, PI.TitanYPosition, PI.AlphaCentariYPosition, "AlphaCentari", UM, PS, fuel, ship, PI, shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan, planetJoe, vormir);
            }
            if (response == "m63")
            {
                UM.PortTravel(PI.TitanXPosition, PI.M63XPosition, PI.TitanYPosition, PI.M63YPosition, "M63", UM, PS, fuel, ship, PI, shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan, planetJoe, vormir);
            }
            if (response == "asgard")
            {
                UM.PortTravel(PI.TitanXPosition, PI.AsgardXPosition, PI.TitanYPosition, PI.AsgardYPosition, "Asgard", UM, PS, fuel, ship, PI, shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan, planetJoe, vormir);
            }
            if (response == "return")
            {
                return;
            }
        }


    }
}
