using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Asgard
    {
        

        public void AsgardPage(LandingPage LP, Shop Shop, ShipYard SY, GameOver GO, PersonalStatus PS, UtilityMethods UM, Ship ship, PlanetInfo PI, Fuel fuel, Asgard Asgard, Earth Earth)
        {
            PS.MyCurrentLocation = "Asgard";
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"" +
            $"Golden spires and beautiful vistas greet you as soon as you land. The rainbow\n" +
            $"bifrost is visable in the distance. It's as beautiful as you always imagined it\n" +
            $"would be. It's just like the legends. Waterfalls and spill off cliffs that lead to\n" +
            $"nowhere. The grand Mead-hall can be barely seen past some clouds and the distant \n" +
            $"sound of drunken revelry carries across the open space.\n" +
            $"Where would you like to go?\n");
            AsgardSelector(UM, PS, ship, fuel, GO, SY, PI, Shop, LP);
        }

        //Selector for the Asgard planet menus
        public void AsgardSelector(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, GameOver GO, ShipYard SY, PlanetInfo PI, Shop Shop, LandingPage LP)
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
                AsgardPort(PS, UM, PI, fuel, ship, LP);

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
            $"\t{PS.MyName} welcome to my shipyard I am Sven son of Baldur God of ship sales and\n" +
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
            $"\tBank {PS.MyName} I am the Thrador! Son of Spandar, God of Banking and money exchange!' He" +
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
            AsgardShopSelector(UM, fuel, PS, ship, PI, Shop);
        }

        public void AsgardShopSelector(UtilityMethods UM, Fuel fuel, PersonalStatus PS, Ship ship, PlanetInfo PI, Shop Shop)
        {
            int response = UM.ShopSelector();

            if (response == 1)
                AsgardBuy(UM, PS, ship, fuel, PI, Shop);

            if (response == 2)
                AsgardSell(UM, PS, ship, fuel, PI);

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
            $"\t\tYou have {PS.MyCurrentCredit} Galactic Credits What would you like to buy?\n" +
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

        public void AsgardSell(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI)
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
                SellAsgardShoes(UM, PS, ship, fuel, PI);
            if (response == 2)
                SellAsgardGold(UM, PS, ship, fuel, PI);
            if (response == 3)
                SellAsgardTV(UM, PS, ship, fuel, PI);
            if (response == 4)
                return;
        }
        // move to shop class
        public void SellAsgardShoes(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"\n\n" +
                $"\t\tHow many shoes do you want to sell?");
            int quantity = Convert.ToInt32(Console.ReadLine());
            if (quantity > PS.NoBalanaceShoes)
            {
                Console.WriteLine($"" +
                    $"\t\tYou don't have that many shoes to sell. You have {PS.NoBalanaceShoes} shoes in your cargo hold.");
                Console.ReadLine();
                SellAsgardShoes(UM, PS, ship, fuel, PI);
            }
            PS.NoBalanaceShoes -= quantity;
            PS.MyCurrentCredit += (quantity * PI.AsgardNoBalanceShoes);
            Console.WriteLine($"'Thank you for these No Balance Shoes these things are AMAZING. Look at me zipping around like\n" +
            $"a bird in the air, I am the God of Flying without wings!' \n" +
            $"You sold {quantity} No Balance Shoes for {quantity * PI.AsgardNoBalanceShoes} GC.");
            Console.ReadLine();
            return;
        }
        // move to shop class
        public void SellAsgardGold(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"How much Space Gold do you want to sell?");
            int quantity = Convert.ToInt32(Console.ReadLine());
            if (quantity > PS.SpaceGold)
            {
                Console.WriteLine($"You don't have that much Space Gold to sell. You have {PS.SpaceGold} shoes in your cargo hold.");
                Console.ReadLine();
                SellAsgardGold(UM, PS, ship, fuel, PI);
            }
            PS.SpaceGold -= quantity;
            PS.MyCurrentCredit += (quantity * PI.AsgardGold);
            Console.WriteLine($"'Thanks for the Space Gold, I guess. I have plenty already though...' \n" +
            $"You sold {quantity} Space Gold for {quantity * PI.AsgardGold} GC.");
            Console.ReadLine();
            return;
        }
        // move to shop class
        public void SellAsgardTV(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"How many Galactic TVs do you want to sell?");
            int quantity = Convert.ToInt32(Console.ReadLine());
            if (quantity > PS.GalacticTVs)
            {
                Console.WriteLine($"You don't have that many Galactic TVs to sell. You have {PS.GalacticTVs} shoes in your cargo hold.");
                Console.ReadLine();
                SellAsgardTV(UM, PS, ship, fuel, PI);
            }
            PS.GalacticTVs -= quantity;
            PS.MyCurrentCredit += (quantity * PI.AsgardGalacticTVs);
            Console.WriteLine($"'Thanks for the Galactic TVs I usually just watch the Valkyries fly by to pass the time.' \n" +
            $"You sold {quantity} Galactic TVs for {quantity * PI.AsgardGalacticTVs} GC.");
            Console.ReadLine();
            return;
        }

        public void AsgardMarket(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"" +
                $"Interestingly there are no screens here. You have been to so many of these stock exchanges and the\n" +
                $" one thing that they all have in common is screens, screens everywhere but here on Asgard there is\n" +
                $"instead a man standing on marble block shouting words and numbers quickly and loudly, but he doesn't\n" +
                $"seem to be saying anything about your glorious three. You turn to one of the Asgardians near you and\n" +
                $"ask them what the deal is. They reply 'Jodiamnur, the God of Stock Quotes, doesn't bother with pidly\n" +
                $"static stocks like ...space gold... pft, we post those prices on the wall.' Sure enough when you look\n" +
                $"over at the indicated wall you see a man finishing chiseling the wall and when he leaves you see the\n" +
                $"following:");
            UM.MarketDisplay(PI);
            return;
        }

        public void AsgardPort(PersonalStatus PS, UtilityMethods UM, PlanetInfo PI, Fuel fuel, Ship ship, LandingPage LP)
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
                if (UM.FuelCheck(PI.AsgardXPosition, PI.AlphaCentariXPosition, PI.AsgardYPosition, PI.AlphaCentariYPosition, ship, PS, fuel) == "OK")
                {
                    UM.PlanetTravel(PI.AsgardXPosition, PI.AlphaCentariXPosition, PI.AsgardYPosition, PI.AlphaCentariYPosition, ship, PS, fuel);
                    UM.Travel(PS);
                    PS.MyCurrentLocation = "AlphaCentari";
                    LP.LandingPagePicker();
                }
                if (UM.FuelCheck(PI.AsgardXPosition, PI.AlphaCentariXPosition, PI.AsgardYPosition, PI.AlphaCentariYPosition, ship, PS, fuel) == "TooFar")
                {
                    UM.TooFar(PI.AsgardXPosition, PI.AlphaCentariXPosition, PI.AsgardYPosition, PI.AlphaCentariYPosition, fuel);
                    return;
                }
            }
            if (response == "m63")
            {
                if (UM.FuelCheck(PI.AsgardXPosition, PI.M63XPosition, PI.AsgardYPosition, PI.M63YPosition, ship, PS, fuel) == "OK")
                {
                    UM.PlanetTravel(PI.AsgardXPosition, PI.M63XPosition, PI.AsgardYPosition, PI.M63YPosition, ship, PS, fuel);
                    UM.Travel(PS);
                    PS.MyCurrentLocation = "M63";
                    LP.LandingPagePicker();
                }
                if (UM.FuelCheck(PI.AsgardXPosition, PI.M63XPosition, PI.AsgardYPosition, PI.M63YPosition, ship, PS, fuel) == "TooFar")
                {
                    UM.TooFar(PI.AsgardXPosition, PI.M63XPosition, PI.AsgardYPosition, PI.M63YPosition, fuel);
                    return;
                }
            }
            if (response == "earth")
            {
                if (UM.FuelCheck(PI.AsgardXPosition, PI.EarthXPosition, PI.AsgardYPosition, PI.EarthYPosition, ship, PS, fuel) == "OK")
                {
                    UM.PlanetTravel(PI.AsgardXPosition, PI.EarthXPosition, PI.AsgardYPosition, PI.EarthYPosition, ship, PS, fuel);
                    UM.Travel(PS);
                    PS.MyCurrentLocation = "Earth";
                    LP.LandingPagePicker();
                }
                if (UM.FuelCheck(PI.AsgardXPosition, PI.EarthXPosition, PI.AsgardYPosition, PI.EarthYPosition, ship, PS, fuel) == "TooFar")
                {
                    UM.TooFar(PI.AsgardXPosition, PI.EarthXPosition, PI.AsgardYPosition, PI.EarthYPosition, fuel);
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
