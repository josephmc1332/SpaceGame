using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Picium
    {
        public void PiciumPage(PersonalStatus PS, UtilityMethods UM, Ship ship, Fuel fuel, ShipYard SY, Shop Shop, PlanetInfo PI, LandingPage LP, GameOver GO, Asgard Asgard, Earth Earth, AlphaCentari AlphaCentari, M63 M63, PlanetX PlanetX, Titan Titan)
        {
            PS.LocationChanger("Picium");
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"\n\n" +
                $"\tYou step onto the planet or rather into the planet you instinctivly reach up and\n" +
                $"\tcheck your helmet clasp. It's always disconcerting to come here since the entire\n" +
                $"\tplanet's infestructure is underwater. Some people swim places and some people use\n" +
                $"\tweighted boots to walk on the ground." +
                $"\t\tWhere would you like to go?\n");
            int response = UM.MainPageOptions();
            if (response == 1)
                PiciumShipyard(UM, PS, ship, fuel, SY);
            if (response == 2)
                PiciumBank(UM, PS, ship, fuel);
            if (response == 3)
                PiciumShop(UM, PS, ship, fuel, Shop, PI);
            if (response == 4)
                PiciumMarket(UM, PS, ship, fuel, PI);
            if (response == 5)
                PiciumPort(UM, PS, ship, fuel, PI, Shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan);
            if (response == 9)
                GO.EndScreen(PS, ship);
        }
        public void PiciumShipyard(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, ShipYard SY)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"\n\n" +
                $"\tThe ships are all stored in these strange underwater hangers. Tubes run from the hanger to the sky so\n" +
                $"\tthat the ships have a clear shot to space. You see other traders and swiming to their hangers the sealocks\n" +
                $"\topening and closing letting mechanics in and out.\n\n");
            Console.WriteLine("\t\tWould you like to:\n" +
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
        public void PiciumBank(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"\n\n" +
                $"\tSwiming into the Galactic bank you see loan officers floating behind their desks typing\n" +
                $"\taway at thier work. Fishmen in suits waiting to make deposits and withdraws or lining up\n" +
                $"\tto apply for loans. You swim up to the counter and the woman behind the counter smiles to\n" +
                $"\t as she gives you your bank info.");
            UM.BankDisplay(PS);
        }
        public void PiciumShop(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, Shop Shop, PlanetInfo PI)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"\n\n" +
                $"\t'Welcome to my shop!' the owner says to you his words coming to you distorted by the water between\n" +
                $"Have you ever thought about how weird it is that you can hear all the people here even though you are\n" +
                $"underwater, weird. Anyway let's buy some stuff.");
            int response = UM.ShopSelector();
            if (response == 1)
                PiciumBuy(UM, PS, ship, fuel, PI, Shop);
            if (response == 2)
                PiciumSell(UM, PS, ship, fuel, Shop, PI);
            if (response == 3)
                fuel.BuyFuel(PS, ship);
            if (response == 4)
                return;
        }
        public void PiciumBuy(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI, Shop Shop)
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
                Shop.BuyShoes(PI.PiciumNoBalanceShoes, PS, UM, ship, fuel);
            }
            //Buy Gold
            if (response == 2)
            {
                Shop.BuyGold(PI.PiciumGold, PS, UM, ship, fuel);
            }

            if (response == 3)
            {
                Shop.BuyTV(PI.PiciumTVs, PS, UM, ship, fuel);
            }

            if (response == 4)
            {
                return;
            }
        }
        public void PiciumSell(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, Shop Shop, PlanetInfo PI)
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
                Shop.SellShoes(PI.PiciumNoBalanceShoes, PS, UM, ship, fuel);
            }

            if (response == 2)
            {
                Shop.SellGold(PI.PiciumGold, PS, UM, ship, fuel);
            }
            if (response == 3)
            {
                Shop.SellTV(PI.PiciumTVs, PS, UM, ship, fuel);
            }
            if (response == 4)
            {
                return;
            }
        }
        public void PiciumMarket(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine("\n\n" +
                "\tThe Picium stock exchange is beautiful. Fish swim about freely inside the building and in\n" +
                "fact the fish are the ones that bring you the stock quotes that you are interested in, you\n" +
                "just tell the nearby fish which stocks you are looking for and then before you know it the\n" +
                "fish have gathered and they are all carrying the quotes you want.\n\n");
            UM.MarketDisplay(PI);
        }
        public void PiciumPort(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI, Shop shop, ShipYard SY, LandingPage LP, Asgard Asgard, Earth Earth, AlphaCentari AlphaCentari, M63 M63, PlanetX PlanetX, Titan Titan)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"\n\n" +
                $"\tThis is it, the famous Space Gold space port. It gleams brighter than you ever thought possible,\n" +
                $"\tso bright in fact that it hurts your eyes a little. But if nothing else you must admit it is one of\n" +
                $"\tthe most impressive things you've ever seen.\n");
            UM.PortMenu(PI.PiciumXPosition, PI.PiciumYPosition, UM, PS, ship, fuel, PI);

            string response = Console.ReadLine();
            if (response == "titan" || response == "Titan")
            {
                UM.PortTravel(PI.PiciumXPosition, PI.TitanXPosition, PI.PiciumYPosition, PI.TitanYPosition, "Titan", UM, PS, fuel, ship, PI, shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan);
            }

            if (response == "centari")
            {
                UM.PortTravel(PI.PiciumXPosition, PI.AlphaCentariXPosition, PI.PiciumYPosition, PI.AlphaCentariYPosition, "AlphaCentari", UM, PS, fuel, ship, PI, shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan);
            }
            if (response == "m63")
            {
                UM.PortTravel(PI.PiciumXPosition, PI.M63XPosition, PI.PiciumYPosition, PI.M63YPosition, "M63", UM, PS, fuel, ship, PI, shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan);
            }
            if (response == "asgard")
            {
                UM.PortTravel(PI.PiciumXPosition, PI.AsgardXPosition, PI.PiciumYPosition, PI.AsgardYPosition, "Asgard", UM, PS, fuel, ship, PI, shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan);
            }
            if (response == "x")
            {
                UM.PortTravel(PI.PiciumXPosition, PI.PlanetXXPosition, PI.PiciumYPosition, PI.PlanetXYPosition, "Planet X", UM, PS, fuel, ship, PI, shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan);
            }
            if (response == "return")
            {
                return;
            }
        }
    }
}
