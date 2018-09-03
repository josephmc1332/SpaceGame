using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class PlanetJoe
    {
        public void PlanetJoePage(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, GameOver GO, ShipYard SY, Shop Shop, PlanetInfo PI, LandingPage LP, Asgard Asgard, Earth Earth, AlphaCentari AlphaCentari, M63 M63, PlanetX PlanetX, Titan Titan)
        {
            PS.LocationChanger("Planet Joe");
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"\n\n" +
                $"\tYou arrive on the remote planet of Planet Joe, named for the king King Joe. The people of\n" +
                $"\tPlanet Joe are wealthy beyond measure. It's honestly weird, no one on the whole planet has\n" +
                $"\tany kind of hurry or drive. They all work hard at their shared project but only when they\n" +
                $"\twant to, because there is no way you could pay them enough to make it worth their while.\n" +
                $"\tAll that being said, their love of King Joe has brought them all together and they are all\n" +
                $"\tgetting together to build a giant golden space port out of pure Space Gold. It's unfinished\n" +
                $"\tfacade gleams in the sunlight. You look forward to checking that out and maybe picking up a\n" +
                $"\tprofit from these gold hungry builders.\n" +
                $"\t\tWhere would you like to go?\n");
            int response = UM.MainPageOptions();
            if (response == 1)
                JoeShipyard(UM, PS, ship, fuel, SY);
            if (response == 2)
                JoeBank(UM, PS, ship, fuel);
            if (response == 3)
                JoeShop(UM, PS, ship, fuel, Shop, PI);
            if (response == 4)
                JoeMarket(UM, PS, ship, fuel, PI);
            if (response == 5)
                JoePort(UM, PS, ship, fuel, PI, Shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan);
            if (response == 9)
                GO.EndScreen(PS, ship);
        }
        public void JoeShipyard(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, ShipYard SY)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"\n\n" +
                $"\tYou walk into the shipyard on planet Joe and the quiet bang of the occatioanal hammer on metal\n" +
                $"\tor maybe the sound of a drill working here or there. There seems to be salesmen but for the first\n" +
                $"\ttime in your life you need to track them down. But the upshot is there is champagin and caviar on \n" +
                $"\ta serving tray in the corner.\n\n");
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
        public void JoeBank(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"\n\n" +
                $"\tYou walk into the Galactic Bank branch of Planet Joe, the area is open and clear, there are\n" +
                $"\tstacks of money just lying about. you walk up to the counter and the man behind the counter greets\n" +
                $"\twarmly, 'Hello there {PS.NameCall()} are you super rich like me? Let's check...");
            UM.BankDisplay(PS);
        }
        public void JoeShop(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, Shop Shop, PlanetInfo PI)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"\n\n" +
                $"\tYou walk into the shop, everything in the shop is too expensive for you to purchase. Part of you\n" +
                $"\twonder if you should even be in the same room with it. A shopkeeper dressed all in silks and gold\n" +
                $"\tsteps out and talks to you, 'Hello there traveler...' he looks over your clothes and then says, \n" +
                $"\t'The trading commodities are this way...' He says in a hesitant tone of voice.");
            int response = UM.ShopSelector();
            if (response == 1)
                JoeBuy(UM, PS, ship, fuel, PI, Shop);
            if (response == 2)
                JoeSell(UM, PS, ship, fuel, PI, Shop);
            if (response == 3)
                fuel.BuyFuel(PS, ship);
            if (response == 4)
                return;
        }
        public void JoeBuy(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI, Shop Shop)
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
                Shop.BuyShoes(PI.PlanetJoeNoBalanceShoes, PS, UM, ship, fuel);
            }
            //Buy Gold
            if (response == 2)
            {
                Shop.BuyGold(PI.PlanetJoeGold, PS, UM, ship, fuel);
            }

            if (response == 3)
            {
                Shop.BuyTV(PI.PlanetJoeGalacticTVs, PS, UM, ship, fuel);
            }

            if (response == 4)
            {
                return;
            }
        }
        public void JoeSell(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI, Shop Shop)
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
                Shop.SellShoes(PI.PlanetJoeNoBalanceShoes, PS, UM, ship, fuel);
            }

            if (response == 2)
            {
                Shop.SellGold(PI.PlanetJoeGold, PS, UM, ship, fuel);
            }
            if (response == 3)
            {
                Shop.SellTV(PI.PlanetJoeGalacticTVs, PS, UM, ship, fuel);
            }
            if (response == 4)
            {
                return;
            }
        }
        public void JoeMarket(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine("\n\n" +
                "\tWhen you go to enter the stock exchange you immediately notice a glaring inconsistancy with this\n" +
                "\tmarket. It doesnt exist. There is a small display showing the prices of commdities but that is all\n" +
                "\tand the Gold is lit up rather bright but that is it, no pomp, no circumstance, just a few numbers on\n" +
                "\ta small screen.\n\n");
            UM.MarketDisplay(PI);
        }
        public void JoePort(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI, Shop shop, ShipYard SY, LandingPage LP, Asgard Asgard, Earth Earth, AlphaCentari AlphaCentari, M63 M63, PlanetX PlanetX, Titan Titan)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"\n\n" +
                $"\tThis is it, the famous Space Gold space port. It gleams brighter than you ever thought possible,\n" +
                $"\tso bright in fact that it hurts your eyes a little. But if nothing else you must admit it is one of\n" +
                $"\tthe most impressive things you've ever seen.\n");
            UM.PortMenu(PI.PlanetJoeXPosition, PI.PlanetJoeYPosition, UM, PS, ship, fuel, PI);

            string response = Console.ReadLine();
            if (response == "titan" || response == "Titan")
            {
                UM.PortTravel(PI.PlanetJoeXPosition, PI.TitanXPosition, PI.PlanetJoeYPosition, PI.TitanYPosition, "Titan", UM, PS, fuel, ship, PI, shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan);
            }

            if (response == "centari")
            {
                UM.PortTravel(PI.PlanetJoeXPosition, PI.AlphaCentariXPosition, PI.PlanetJoeYPosition, PI.AlphaCentariYPosition, "AlphaCentari", UM, PS, fuel, ship, PI, shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan);
            }
            if (response == "m63")
            {
                UM.PortTravel(PI.PlanetJoeXPosition, PI.M63XPosition, PI.PlanetJoeYPosition, PI.M63YPosition, "M63", UM, PS, fuel, ship, PI, shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan);
            }
            if (response == "asgard")
            {
                UM.PortTravel(PI.PlanetJoeXPosition, PI.AsgardXPosition, PI.PlanetJoeYPosition, PI.AsgardYPosition, "Asgard", UM, PS, fuel, ship, PI, shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan);
            }
            if (response == "x")
            {
                UM.PortTravel(PI.PlanetJoeXPosition, PI.PlanetXXPosition, PI.PlanetJoeYPosition, PI.PlanetXYPosition, "Planet X", UM, PS, fuel, ship, PI, shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan);
            }
            if (response == "return")
            {
                return;
            }
        }

    }
}
