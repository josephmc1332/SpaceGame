using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Shop
    {
        public void BuyShoes(int currentPlanetShoes, PersonalStatus PS, UtilityMethods UM, Ship ship, Fuel fuel)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"" +
                $"How many No Balance Shoes would you like to buy for {currentPlanetShoes} GC?");
            int quantity = Convert.ToInt32(Console.ReadLine());
            if ((quantity + PS.SpaceGold + PS.NoBalanaceShoes + PS.GalacticTVs) > ship.ShipCapacity)
            {
                Console.WriteLine($"You don't have enough room for that many shoes, you can only" +
                    $" buy {(ship.ShipCapacity - (PS.SpaceGold + PS.NoBalanaceShoes + PS.GalacticTVs))}\n" +
                    $"Press <enter> to return...");
                Console.ReadLine();
                return;
            }
            if ((quantity * currentPlanetShoes) > PS.Cash())

            {
                Console.WriteLine($"" +
                    $"You can't afford that many shoes\n" +
                    $"Press <enter> to return...");
                Console.ReadLine();
                return;
            }
            PS.SpendMoney(quantity * currentPlanetShoes);
            PS.NoBalanaceShoes += quantity;
            Console.WriteLine($"" +
                $"You have bought {quantity} No Balance Shoes for {(quantity * currentPlanetShoes)} GC.\n" +
                $"You now have {PS.Cash()} GC and {PS.NoBalanaceShoes} shoes.");
            Console.ReadLine();
            return;

        }

        public void BuyGold(int currentPlanetGold, PersonalStatus PS, UtilityMethods UM, Ship ship, Fuel fuel)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"" +
                $"How much Space Gold would you like to buy for {currentPlanetGold} GC?");
            int quantity = Convert.ToInt32(Console.ReadLine());
            if ((quantity + PS.SpaceGold + PS.NoBalanaceShoes + PS.GalacticTVs) > ship.ShipCapacity)
            {
                Console.WriteLine($"" +
                    $"You don't have enough room for that much Space Gold, you can only" +
                    $" buy {(ship.ShipCapacity - (PS.SpaceGold + PS.NoBalanaceShoes + PS.GalacticTVs))}\n" +
                    $"Press <enter> to return...");
                Console.ReadLine();
                return;
            }
            if ((quantity * currentPlanetGold) > PS.Cash())

            {
                Console.WriteLine($"" +
                    $"You can't afford that much Space Gold\n" +
                    $"Press <enter> to return...");
                Console.ReadLine();
                return;
            }
            PS.SpendMoney(quantity * currentPlanetGold);
            PS.SpaceGold += quantity;
            Console.WriteLine($"" +
                $"You have bought {quantity} bars of Space Gold for {(quantity * currentPlanetGold)} GC.\n" +
                $"You now have {PS.Cash()} GC and {PS.SpaceGold} bars of Space Gold.");
            Console.ReadLine();
            return;

        }

        public void BuyTV(int currentPlanetTV, PersonalStatus PS, UtilityMethods UM, Ship ship, Fuel fuel)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"" +
                $"How many Galactic TVs would you like to buy for {currentPlanetTV} GC?");
            int quantity = Convert.ToInt32(Console.ReadLine());
            if ((quantity + PS.SpaceGold + PS.NoBalanaceShoes + PS.GalacticTVs) > ship.ShipCapacity)
            {
                Console.WriteLine($"" +
                    $"You don't have enough room for that many Galactic TVs, you can only" +
                    $" buy {(ship.ShipCapacity - (PS.SpaceGold + PS.NoBalanaceShoes + PS.GalacticTVs))}\n" +
                    $"Press <enter> to return...");
                Console.ReadLine();
                return;
            }
            if ((quantity * currentPlanetTV) > PS.Cash())

            {
                Console.WriteLine($"" +
                    $"You can't afford that many Galactic TVs\n" +
                    $"Press <enter> to return...");
                Console.ReadLine();
                return;
            }
            PS.SpendMoney(quantity * currentPlanetTV);
            PS.GalacticTVs += quantity;
            Console.WriteLine($"" +
                $"You have bought {quantity} bars of Space Gold for {(quantity * currentPlanetTV)} GC.\n" +
                $"You now have {PS.Cash()} GC and {PS.GalacticTVs} Galactic TVs.");
            Console.ReadLine();
            return;

        }

        public void SellShoes(int currentPlanetShoes, PersonalStatus PS, UtilityMethods UM, Ship ship, Fuel fuel)
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
                return;
            }
            PS.NoBalanaceShoes -= quantity;
            PS.EarnMoney(quantity * currentPlanetShoes);
            Console.WriteLine($"'Thank you for these No Balance Shoes these things are AMAZING. Look at me zipping around like\n" +
            $"a bird in the air, I am the God of Flying without wings!' \n" +
            $"You sold {quantity} No Balance Shoes for {quantity * currentPlanetShoes} GC.");
            Console.ReadLine();
            return;
        }

        public void SellGold(int currentPlanetGold, PersonalStatus PS, UtilityMethods UM, Ship ship, Fuel fuel)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"How much Space Gold do you want to sell?");
            int quantity = Convert.ToInt32(Console.ReadLine());
            if (quantity > PS.SpaceGold)
            {
                Console.WriteLine($"You don't have that much Space Gold to sell. You have {PS.SpaceGold} shoes in your cargo hold.");
                Console.ReadLine();
                return;
            }
            PS.SpaceGold -= quantity;
            PS.EarnMoney(quantity * currentPlanetGold);
            Console.WriteLine($"'Thanks for the Space Gold, I guess. I have plenty already though...' \n" +
            $"You sold {quantity} Space Gold for {quantity * currentPlanetGold} GC.");
            Console.ReadLine();
            return;
        }

        public void SellTV( int currrentPlanetTV, PersonalStatus PS, UtilityMethods UM, Ship ship, Fuel fuel)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"How many Galactic TVs do you want to sell?");
            int quantity = Convert.ToInt32(Console.ReadLine());
            if (quantity > PS.GalacticTVs)
            {
                Console.WriteLine($"You don't have that many Galactic TVs to sell. You have {PS.GalacticTVs} shoes in your cargo hold.");
                Console.ReadLine();
                return;
            }
            PS.GalacticTVs -= quantity;
            PS.EarnMoney(quantity * currrentPlanetTV);
            Console.WriteLine($"'Thanks for the Galactic TVs I usually just watch the Valkyries fly by to pass the time.' \n" +
            $"You sold {quantity} Galactic TVs for {quantity * currrentPlanetTV} GC.");
            Console.ReadLine();
            return;
        }
    }
}
