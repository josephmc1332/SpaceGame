using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Earth
    {

        #region Earth Page
        PersonalStatus PS = new PersonalStatus();
        public void EarthPage()
        {
            //Define Location
           
            PS.MyCurrentLocation = "Earth";

            //clear up window
            Console.Clear();

            //display menu on earth upon arrival
            Console.WriteLine("Welcome to Earth! Where would you like to go? \n" +
                "1. Ship Yard \n" +
                "2. Galactic Bank \n" +
                "3. Buy, Sell, Trade \n" +
                "4. Galactic Market\n" +
                "5. Departure Port");

            //send back to check selected option after invalid input
            try
            {
                SelectEarthOptions();
            }

            //display if invalid input
            catch (Exception)
            {
                Console.WriteLine("Invalid input, try again! Press any key to continue.");
                Console.ReadLine();

                //recycle to Welcome to Earth after invalid entry  
                EarthPage();
            }



        }
        public void SelectEarthOptions()
        {
            //convert/parse user input string 
            int response = Convert.ToInt32(Console.ReadLine());

            //evaluate user input by using boolean expressions
            bool shipYard = response == 1;
            bool galacticBank = response == 2;
            bool shop = response == 3;
            bool market = response == 4;
            bool port = response == 5;


            //point of method access after valid user selection
            if (shipYard) 
                ShipYard();

            if (galacticBank) 
                Bank();

            if (shop) 
                Shop();

            if (market) ;
            //   Market();

            if (port) ;
            //   Port();

            else
            {
                //loops back to the beginning of earth page
                Console.WriteLine("invalid entry");
                EarthPage();
            }

        }
        public void Bank()
        {
            Console.Clear();
            // write flavor text for bank
            Console.WriteLine($"You have {PS.MyCurrentCredit}");
        }
        public void ShipYard()
        {
            Console.Clear();
            // write flavor text about shipyard
            Console.WriteLine("You walk into the Shipyard, the sound of welders and hammers fills the air. Ship salesman are weaving in and out of" +
                "the ships pushing their latest ship on travelers all the while dodging the laborers.\nWould you like to:\n 1 Check your ship stats\n 2 Buy a new Ship\n 3 Return to planetary hub");
            int response = Convert.ToInt32(Console.ReadLine());
            bool ShipStats = response == 1;
            bool BuyShip = response == 2;
            bool Return = response == 3;
            if (ShipStats)
                //ShipStats();
                if (BuyShip)
                    // BuyShip();
                    if (Return)
                        EarthPage();
        }
        public void Shop()
        {
            Console.Clear();
            Console.WriteLine("What would you like to do?\n 1 Buy Cargo\n 2 Sell Cargo\n 3 Return to planetary hub");
            int response = Convert.ToInt32(Console.ReadLine());
            bool purchase = response == 1;
            bool offload = response == 2;
            bool Return = response == 3;
            if (purchase)
                Buy();
            if (offload)
                //Sell();
            if (Return)
                EarthPage();
        }
        public void Buy()
        {
            int sGold = 100;
            int noShoes = 80;
            int gTV = 120;
            Console.Clear();
            Console.WriteLine($"You have {PS.MyCurrentCredit} Galactic Credits, what good would you like to buy?\n " +
                $"1 NoBalanceShoes 80 GC per Unit\n 2 Space Gold 100 GC per Unit\n 3 Galactic TV 120 GC per Unit");
            int response = Convert.ToInt32(Console.ReadLine());
            bool Shoes = response == 1;
            bool Gold = response == 2;
            bool TV = response == 3;
            if (Shoes)
            {
                Console.WriteLine("How many?");
                int quantity = Convert.ToInt32(Console.ReadLine());
                if ((quantity * noShoes) > PS.MyCurrentCredit)
                {
                    Console.WriteLine("You can't afford that!");
                    Buy();
                }
                PS.MyCurrentCredit -= (quantity * noShoes);
            }
        }
        
        #endregion

    }
}
