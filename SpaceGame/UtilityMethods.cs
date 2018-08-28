using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class UtilityMethods
    {
        PersonalStatus PS = new PersonalStatus();
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

        public void BankDisplay()
        {
            Console.WriteLine($"You have {PS.MyCurrentCredit} Galactic Credits in your bank account.\n" +
            $"The title of Duke of Mercury is 1,000,000 Galactic Credits. You need {(1000000 - PS.MyCurrentCredit)} more\n" +
            $"Galactic Credits before you can win the King of Venus' approval.\n\n" +
            $"Press <enter> to continue...");
            Console.ReadLine();
            GO.Win();
        }
        public void InventoryDisplay()
        {
            Console.WriteLine($"Space Gold: {PS.SpaceGold} No Balanace Shoes: {PS.NoBalanaceShoes} Galactic TVs: {PS.GalacticTVs} Galactic Credits: {PS.MyCurrentCredit} Cargo Space: {PS.ShipCapacity - (PS.SpaceGold + PS.NoBalanaceShoes + PS.GalacticTVs)}\n");
        }
    }
}
