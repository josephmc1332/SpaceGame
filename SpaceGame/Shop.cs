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
            Console.WriteLine($"How many No Balance Shoes would you like to buy for {currentPlanetShoes} GC?");
            int quantity = Convert.ToInt32(Console.ReadLine());
            if ((quantity + PS.SpaceGold + PS.NoBalanaceShoes + PS.GalacticTVs) > ship.ShipCapacity)
            {
                Console.WriteLine($"You don't have enough room for that many shoes, you can only" +
                    $" buy {(ship.ShipCapacity - (PS.SpaceGold + PS.NoBalanaceShoes + PS.GalacticTVs))}\n" +
                $"Press <enter> to return...");
                Console.ReadLine();
                return;
            }
            if ((quantity * currentPlanetShoes) > PS.MyCurrentCredit)

            {
                Console.WriteLine($"You can't afford that many shoes\n" +
                $"Press <enter> to return...");
                Console.ReadLine();
                return;
            }
            PS.MyCurrentCredit -= (quantity * currentPlanetShoes);
            PS.NoBalanaceShoes += quantity;
            Console.WriteLine($"You have bought {quantity} No Balance Shoes for {(quantity * currentPlanetShoes)} GC.\n" +
            $"You now have {PS.MyCurrentCredit} GC and {PS.NoBalanaceShoes} shoes.");
            Console.ReadLine();
            return;

        }

        public void BuyGold(int currentPlanetGold, PersonalStatus PS, UtilityMethods UM, Ship ship, Fuel fuel)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"How much Space Gold would you like to buy for {currentPlanetGold} GC?");
            int quantity = Convert.ToInt32(Console.ReadLine());
            if ((quantity + PS.SpaceGold + PS.NoBalanaceShoes + PS.GalacticTVs) > ship.ShipCapacity)
            {
                Console.WriteLine($"You don't have enough room for that much Space Gold, you can only" +
                    $" buy {(ship.ShipCapacity - (PS.SpaceGold + PS.NoBalanaceShoes + PS.GalacticTVs))}\n" +
                $"Press <enter> to return...");
                Console.ReadLine();
                return;
            }
            if ((quantity * currentPlanetGold) > PS.MyCurrentCredit)

            {
                Console.WriteLine($"You can't afford that much Space Gold\n" +
                $"Press <enter> to return...");
                Console.ReadLine();
                return;
            }
            PS.MyCurrentCredit -= (quantity * currentPlanetGold);
            PS.SpaceGold += quantity;
            Console.WriteLine($"You have bought {quantity} bars of Space Gold for {(quantity * currentPlanetGold)} GC.\n" +
            $"You now have {PS.MyCurrentCredit} GC and {PS.SpaceGold} bars of Space Gold.");
            Console.ReadLine();
            return;

        }

        public void BuyTV(int currentPlanetTV, PersonalStatus PS, UtilityMethods UM, Ship ship, Fuel fuel)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"How many Galactic TVs would you like to buy for {currentPlanetTV} GC?");
            int quantity = Convert.ToInt32(Console.ReadLine());
            if ((quantity + PS.SpaceGold + PS.NoBalanaceShoes + PS.GalacticTVs) > ship.ShipCapacity)
            {
                Console.WriteLine($"You don't have enough room for that many Galactic TVs, you can only" +
                    $" buy {(ship.ShipCapacity - (PS.SpaceGold + PS.NoBalanaceShoes + PS.GalacticTVs))}\n" +
                $"Press <enter> to return...");
                Console.ReadLine();
                return;
            }
            if ((quantity * currentPlanetTV) > PS.MyCurrentCredit)

            {
                Console.WriteLine($"You can't afford that many Galactic TVs\n" +
                $"Press <enter> to return...");
                Console.ReadLine();
                return;
            }
            PS.MyCurrentCredit -= (quantity * currentPlanetTV);
            PS.GalacticTVs += quantity;
            Console.WriteLine($"You have bought {quantity} bars of Space Gold for {(quantity * currentPlanetTV)} GC.\n" +
            $"You now have {PS.MyCurrentCredit} GC and {PS.GalacticTVs} Galactic TVs.");
            Console.ReadLine();
            return;

        }
    }
}
