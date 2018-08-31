using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Asgard
    {
        

        public void AsgardPage(LandingPage LP, Shop Shop, ShipYard SY, GameOver GO, PersonalStatus PS, UtilityMethods UM, Ship ship, PlanetInfo PI, Fuel fuel, Asgard Asgard, Earth Earth, AlphaCentari AlphaCentari, M63 M63, PlanetX PlanetX)
        {
            PS.LocationChanger("Asgard");
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"\n\n" +
            $"\tGolden spires and beautiful vistas greet you as soon as you land. The rainbow\n" +
            $"\tbifrost is visable in the distance. It's as beautiful as you always imagined it\n" +
            $"\twould be. It's just like the legends. Waterfalls and spill off cliffs that lead to\n" +
            $"\tnowhere. The grand Mead-hall can be barely seen past some clouds and the distant \n" +
            $"\tsound of drunken revelry carries across the open space.\n" +
            $"\t\tWhere would you like to go?\n");
            AsgardSelector(UM, PS, ship, fuel, GO, SY, PI, Shop, LP, Asgard, Earth, AlphaCentari, M63, PlanetX);
        }

        //Selector for the Asgard planet menus
        public void AsgardSelector(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, GameOver GO, ShipYard SY, PlanetInfo PI, Shop Shop, LandingPage LP, Asgard Asgard, Earth Earth, AlphaCentari AlphaCentari, M63 M63, PlanetX PlanetX)
        {
            int response = UM.MainPageOptions();

            if (response == 1)
                AsgardShipyard(UM, PS, ship, fuel, SY);

            if (response == 2)
                AsgardBank(UM, PS, ship, fuel);

            if (response == 3)
                AsgardShop(UM, PS, ship, fuel, PI, Shop);

            if (response == 4)
                AsgardMarket(UM, PS, ship, fuel, PI);

            if (response == 5)
                AsgardPort(LP, Shop, SY, GO, PS, UM, ship, PI, fuel, Asgard, Earth, AlphaCentari, M63, PlanetX);

            if (response == 9)
                GO.EndScreen(PS, ship);
        }

        public void AsgardShipyard(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, ShipYard SY)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"\n\n" +
            $"\tYou walk into the shipyard of Asgard and are greeted by a man who looks like he\n" +
            $"\tstepped right out of an old Norse myth. He smiles through his huge beard, 'Greetings\n" +
            $"\t{PS.NameCall()} welcome to my shipyard I am Sven son of Baldur God of ship sales and\n" +
            $"\tmaintenance. I see you have a {ship.ShipName} class ship, those are good but I think you\n" +
            $"\tcould do better, well anyway what can I do for you?\n" +
            $"\t\tWhat do you want to do?\n" +
            $"\t\t1 Check on your ship\n" +
            $"\t\t2 Buy a new ship\n" +
            $"\t\t3 Return to the Planetary hub");
            int response = Convert.ToInt32(Console.ReadLine());
            if (response == 1)
                SY.ShipCheck(PS, ship, UM, fuel);
            if (response == 2)
                SY.PurchaseShip(PS, ship, UM, fuel);
            if (response == 3)
                return;
        }

         public void AsgardBank(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"\n\n" +
            $"\tYou walk into the bank which is easily one of the most expensive buildings you've ever" +
            $"\tbeen in. It seems everything in Asgard is either a deadly steel blade or made entirely" +
            $"\tfrom space gold. The banker smiles at you, 'Welcome to the Asgardian branch of the Galactic" +
            $"\tBank {PS.NameCall()} I am the Thrador! Son of Spandar, God of Banking and money exchange!' He" +
            $"\tquite boisterous for a banker. He taps away at some glowing runes carved into the gold top" +
            $"\tof the counter.");
            UM.BankDisplay(PS);
            return;
        }

        public void AsgardShop(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI, Shop Shop)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"\n\n" +
            $"\tThe shop is more of the same, boisterous bearded men and impossibly tall women crowd the\n" +
            $"\tmarketplace. The vendor you've chosen as your dealer for the items you want is 'Ruslagg God\n" +
            $"\tmerchandise and profit!' it seems everyone on this planet is a God... But his prices seem fair\n" +
            $"\tgood, especially the Space Gold.\n");
            int response = UM.ShopSelector();

            if (response == 1)
                AsgardBuy(UM, PS, ship, fuel, PI, Shop);

            if (response == 2)
                AsgardSell(UM, PS, ship, fuel, PI, Shop);

            if (response == 3)
                fuel.BuyFuel(PS, ship);

            if (response == 4)
                return;
        }

        public void AsgardBuy(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI, Shop Shop)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"\n\n" +
            $"\t\tYou have {PS.Cash()} Galactic Credits What would you like to buy?\n" +
            $"\t\t 1 No Balance Shoes for {PI.AsgardNoBalanceShoes} GC\n" +
            $"\t\t 2 Space Gold for {PI.AsgardGold} GC\n" +
            $"\t\t 3 Galactic TVs for {PI.AsgardGalacticTVs} GC\n" +
            $"\t\t 4 Return to the Asgardian Shop");
            int response = Convert.ToInt32(Console.ReadLine());
            if (response == 1)
                Shop.BuyShoes(PI.AsgardNoBalanceShoes, PS, UM, ship, fuel);
            if (response == 2)
                Shop.BuyGold(PI.AsgardGold, PS, UM, ship, fuel);
            if (response == 3)
                Shop.BuyTV(PI.AsgardGalacticTVs, PS, UM, ship, fuel);
            if (response == 4)
                return;
        }

        public void AsgardSell(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI, Shop Shop)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"\n\n" +
            $"\t\tYou have {PS.NoBalanaceShoes} Shoes, {PS.SpaceGold} bars of Space Gold and {PS.GalacticTVs} Galactic TVs\n" +
            $"\t\tWhat would you like to sell?\n" +
            $"\t\t 1 No Balance Shoes\n" +
            $"\t\t 2 Space Gold\n" +
            $"\t\t 3 Galactic TVs\n" +
            $"\t\t 4 Return to the Asgardian Shop");
            int response = Convert.ToInt32(Console.ReadLine());
            if (response == 1)
                Shop.SellShoes(PI.AsgardNoBalanceShoes, PS, UM, ship, fuel);
            if (response == 2)
                Shop.SellGold(PI.AsgardGold, PS, UM, ship, fuel);
            if (response == 3)
                Shop.SellTV(PI.AsgardGalacticTVs, PS, UM, ship, fuel);
            if (response == 4)
                return;
        }
       
        public void AsgardMarket(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"\n\n" +
                $"\tInterestingly there are no screens here. You have been to so many of these stock exchanges and the\n" +
                $"\tone thing that they all have in common is screens, screens everywhere but here on Asgard there is\n" +
                $"\tinstead a man standing on marble block shouting words and numbers quickly and loudly, but he doesn't\n" +
                $"\tseem to be saying anything about your glorious three. You turn to one of the Asgardians near you and\n" +
                $"\task them what the deal is. They reply 'Jodiamnur, the God of Stock Quotes, doesn't bother with pidly\n" +
                $"\tstatic stocks like ...space gold... pft, we post those prices on the wall.' Sure enough when you look\n" +
                $"\tover at the indicated wall you see a man finishing chiseling the wall and when he leaves you see the\n" +
                $"\tfollowing:");
            UM.MarketDisplay(PI);
            return;
        }

        public void AsgardPort(LandingPage LP, Shop Shop, ShipYard SY, GameOver GO, PersonalStatus PS, UtilityMethods UM, Ship ship, PlanetInfo PI, Fuel fuel, Asgard Asgard, Earth Earth, AlphaCentari AlphaCentari, M63 M63, PlanetX PlanetX)
        {
            double playerWarpSpeed = (Math.Pow(ship.ShipSpeed, 10 / 3) + Math.Pow(10 - ship.ShipSpeed, -11 / 3));
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"\n\n" +
                $"\tWhere would you like to go? \n");
            if (UM.FuelCheck(PI.AsgardXPosition, PI.AlphaCentariXPosition, PI.AsgardYPosition, PI.AlphaCentariYPosition, ship, PS, fuel) == "OK")
                Console.WriteLine($"" +
                    $"\t\t<centari> Alpha Centari: {UM.PlanetDistance(PI.AsgardXPosition, PI.AlphaCentariXPosition, PI.AsgardYPosition, PI.AlphaCentariYPosition)} Light years away which will take {UM.PlanetDistance(PI.AsgardXPosition, PI.AlphaCentariXPosition, PI.AsgardYPosition, PI.AlphaCentariYPosition) / playerWarpSpeed} years\n");
            if (UM.FuelCheck(PI.AsgardXPosition, PI.M63XPosition, PI.AsgardYPosition, PI.M63YPosition, ship, PS, fuel) == "OK")
                Console.WriteLine($"" +
                    $"\t\t<m63> M63: {UM.PlanetDistance(PI.AsgardXPosition, PI.M63XPosition, PI.AsgardYPosition, PI.M63YPosition)} Light years away which will take {UM.PlanetDistance(PI.AsgardXPosition, PI.M63XPosition, PI.AsgardYPosition, PI.M63YPosition) / playerWarpSpeed} years\n");
            if (UM.FuelCheck(PI.AsgardXPosition, PI.EarthXPosition, PI.AsgardYPosition, PI.EarthYPosition, ship, PS, fuel) == "OK")
                Console.WriteLine($"" +
                    $"\t\t<asgard> Earth: {UM.PlanetDistance(PI.AsgardXPosition, PI.EarthXPosition, PI.AsgardYPosition, PI.EarthYPosition)} Light years away which will take {UM.PlanetDistance(PI.EarthXPosition, PI.AsgardXPosition, PI.EarthYPosition, PI.AsgardYPosition) / playerWarpSpeed} years\n");
            Console.WriteLine($"" +
                $"\t\t<return> Return to earth");
            string response = Console.ReadLine();
            if (response == "centari")
            {
                UM.PortTravel(PI.AsgardXPosition, PI.AlphaCentariXPosition, PI.AsgardYPosition, PI.AlphaCentariYPosition, "AlphaCentari", UM, PS, fuel, ship, PI, Shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX);
            }
            if (response == "m63")
            {
                UM.PortTravel(PI.AsgardXPosition, PI.M63XPosition, PI.AsgardYPosition, PI.M63YPosition, "M63", UM, PS, fuel, ship, PI, Shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX);
            }
            if (response == "earth")
            {
                UM.PortTravel(PI.AsgardXPosition, PI.EarthXPosition, PI.AsgardYPosition, PI.EarthYPosition, "Earth", UM, PS, fuel, ship, PI, Shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX);
            }
            if (response == "return")
            {
                return;
            }
        }
    }
}
