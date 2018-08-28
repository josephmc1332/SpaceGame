using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class UtilityMethods
    {
        GameOver GO = new GameOver();
        // this method will populate the navigation menu and return a number that the selector can use.
        public int MainPageOptions()
        {
            Console.WriteLine("" +
            " 1 Shipyard\n" +
            " 2 Galactic Bank\n" +
            " 3 Buy, Sell, Trade\n" +
            " 4 Market\n" +
            " 5 Departure Port\n\n" +
            " 9 Quit game");
            int response = Convert.ToInt32(Console.ReadLine());
            return response;
        }
        // this method will stream line all the shipyard menus
        public int ShipYardMenu()
        {
            Console.WriteLine("What would you like to do:\n" +
            " 1 Check your ship stats\n" +
            " 2 Buy a new ship\n" +
            " 3 Return to planetary menu");
            int response = Convert.ToInt32(Console.ReadLine());
            return response;
        }

        public void BankDisplay(PersonalStatus ps)
        {
            Console.WriteLine($"You have {ps.MyCurrentCredit} Galactic Credits in your bank account.\n" +
            $"The title of Duke of Mercury is 1,000,000 Galactic Credits. You need {(1000000 - ps.MyCurrentCredit)} more\n" +
            $"Galactic Credits before you can win the King of Venus' approval.\n\n" +
            $"Press <enter> to continue...");
            Console.ReadLine();
            GO.Win(ps);
        }
        public void InventoryDisplay(PersonalStatus ps)
        {
            Console.WriteLine($"Space Gold: {ps.SpaceGold} No Balanace Shoes: {ps.NoBalanaceShoes} Galactic TVs: {ps.GalacticTVs} Galactic Credits: {ps.MyCurrentCredit} Cargo Space: {ps.ShipCapacity - (ps.SpaceGold + ps.NoBalanaceShoes + ps.GalacticTVs)}\n");
        }
    }
}
