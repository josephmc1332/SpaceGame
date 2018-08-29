using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Asgard
    {
        public void AsgardPage(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, GameOver GO, ShipYard SY, PlanetInfo PI, Shop Shop)
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
            AsgardSelector(UM, PS, ship, fuel, GO, SY, PI, Shop);
        }

        //Selector for the Asgard planet menus
        public void AsgardSelector(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, GameOver GO, ShipYard SY, PlanetInfo PI, Shop Shop)
        {
            int response = UM.MainPageOptions();

            if (response == 1)
                AsgardShipyard(UM, PS, ship, fuel, SY);

            if (response == 2)
                AsgardBank(UM, PS, ship, fuel);

            if (response == 3)
                AsgardShop(UM, PS, ship, fuel, PI, Shop);

            //if (response == 4)
            //AsgardMarket();

            //if (response == 5)
            //AsgardPort();

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
            Console.WriteLine($"" +
            $"You walk into the bank which is easily one of the most expensive buildings you've ever" +
            $"been in. It seems everything in Asgard is either a deadly steel blade or made entirely" +
            $"from space gold. The banker smiles at you, 'Welcome to the Asgardian branch of the Galactic" +
            $"Bank {PS.MyName} I am the Thrador! Son of Spandar, God of Banking and money exchange!' He" +
            $"quite boisterous for a banker. He taps away at some glowing runes carved into the gold top" +
            $"of the counter.");
            UM.BankDisplay(PS);
            return;
        }
        public void AsgardShop(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI, Shop Shop)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"" +
            $"The shop is more of the same, boisterous bearded men and impossibly tall women crowd the\n" +
            $"marketplace. The vendor you've chosen as your dealer for the items you want is 'Ruslagg God\n" +
            $"merchandise and profit!' it seems everyone on this planet is a God... But his prices seem fair\n" +
            $"good, especially the Space Gold.\n");
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
            Console.WriteLine($"" +
            $"You have {PS.MyCurrentCredit} Galactic Credits What would you like to buy?\n" +
            $" 1 No Balance Shoes for {PI.AsgardNoBalanceShoes} GC\n" +
            $" 2 Space Gold for {PI.AsgardGold} GC\n" +
            $" 3 Galactic TVs for {PI.AsgardGalacticTVs} GC\n" +
            $" 4 Return to the Asgardian Shop");
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
            Console.WriteLine($"" +
            $"You have {PS.NoBalanaceShoes} Shoes, {PS.SpaceGold} bars of Space Gold and {PS.GalacticTVs} Galactic TVs\n" +
            $"What would you like to sell?\n" +
            $" 1 No Balance Shoes\n" +
            $" 2 Space Gold\n" +
            $" 3 Galactic TVs\n" +
            $" 4 Return to the Asgardian Shop");
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

        public void SellAsgardShoes(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"How many shoes do you want to sell?");
            int quantity = Convert.ToInt32(Console.ReadLine());
            if (quantity > PS.NoBalanaceShoes)
            {
                Console.WriteLine($"You don't have that many shoes to sell. You have {PS.NoBalanaceShoes} shoes in your cargo hold.");
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
    }
}
