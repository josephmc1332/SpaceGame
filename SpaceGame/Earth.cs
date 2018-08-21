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
                Sell();
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
                $"1 NoBalanceShoes 80 GC per Unit\n 2 Space Gold 100 GC per Unit\n 3 Galactic TV 120 GC per Unit \n 4 " +
                $"Return to Planetary Menu");
            int response = Convert.ToInt32(Console.ReadLine());
            bool Shoes = response == 1;
            bool Gold = response == 2;
            bool TV = response == 3;
            bool Return = response == 4;

            //Buy Shoes
            if (Shoes)
            {
                Console.WriteLine("How many?");
                int quantity = Convert.ToInt32(Console.ReadLine());
                if ((quantity * noShoes) > PS.MyCurrentCredit)
                {
                    Console.WriteLine("You can't afford that! \n" +
                        "Press any key to return to the Shop..");
                    Console.ReadLine();
                    Buy();
                }
                PS.MyCurrentCredit -= (quantity * noShoes);

                PS.NoBalanaceShoes += quantity;

                Console.WriteLine($"you bought {quantity} NoBalance Shoes, your new balance is {PS.MyCurrentCredit} \n " +
                    $"You now have {PS.NoBalanaceShoes} pairs of No Balanace Shoes in your ship.\n Press any key to continue..");

                Console.ReadLine();
                Buy();
            }
            //Buy Gold
            if (Gold)

            {
                Console.WriteLine("How many?");
                int quantity = Convert.ToInt32(Console.ReadLine());
                if ((quantity * sGold) > PS.MyCurrentCredit)
                {
                    Console.WriteLine("You can't afford that! \n" +
                        "Press any key to return to the Shop..");
                    Console.ReadLine();
                    Buy();
                }
                PS.MyCurrentCredit -= (quantity * sGold);

                PS.SpaceGold += quantity;

                Console.WriteLine($"you bought {quantity} Bars of Space Gold, your new balance is {PS.MyCurrentCredit} \n " +
                    $" You have {PS.SpaceGold} bars of Space Gold in your spaceship.\n Press any key to continue..");
                Console.ReadLine();
                Buy();
            }

            if (TV)
            {
                Console.WriteLine("How many?");
                int quantity = Convert.ToInt32(Console.ReadLine());
                if ((quantity * gTV) > PS.MyCurrentCredit)
                {
                    Console.WriteLine("You can't afford that! \n" +
                        "Press any key to return to the Shop..");
                    Console.ReadLine();
                    Buy();
                }
                PS.MyCurrentCredit -= (quantity * gTV);

                PS.GalacticTVs += quantity;



                Console.WriteLine($"you bought {quantity} Galactic TV(s), your new balance is {PS.MyCurrentCredit} \n " +
                    $"You now have {PS.GalacticTVs} Galactic Tvs in your ship. \n Press any key to continue..");
                Console.ReadLine();
                Buy();
            }

            if (Return)
            {
                Shop();
            }
        }
        public void Sell()
        {
            int sGold = 100;
            int noShoes = 80;
            int gTV = 120;
            Console.Clear();
            Console.WriteLine($"You have {PS.NoBalanaceShoes} pairs of No Balance Shoes, {PS.SpaceGold} bars of Space Gold & {PS.GalacticTVs} sets of Galactic TVs." +
                $" Which would you like to sell?\n 1 No Balance Shoes\n 2 Space Gold\n 3 Galactic TVs\n 4 or Return to the Shop");
            int response = Convert.ToInt32(Console.ReadLine());

            bool Shoes = response == 1;
            bool Gold = response == 2;
            bool TV = response == 3;
            bool Return = response == 4;

            if (Shoes)
            {
                Console.WriteLine("How many No Balance Shoes would you like to offload?");
                int quantity = Convert.ToInt32(Console.ReadLine());
                if (quantity > PS.NoBalanaceShoes)
                {
                    Console.WriteLine("You don't have that many shoes!\n Press any key to return to the selling menu...");
                    Console.ReadLine();
                    Sell();
                }
                PS.NoBalanaceShoes -= quantity;
                PS.MyCurrentCredit += (quantity * noShoes);
                Console.WriteLine($"Thank you for the shoes, you sold {quantity} No Balance Shoes for {(quantity * noShoes)} Galactic Credits." +
                    $"You now have {PS.MyCurrentCredit} Galactic Credits and {PS.NoBalanaceShoes} No Balanace Shoes.\n Press any key to continue...");
                Console.ReadLine();
                Sell();
            }
            if (Return)
            {
                Shop();
            }
            if (Gold)
            {
                Console.WriteLine("How much Space Gold do you want sell?");
                int quantity = Convert.ToInt32(Console.ReadLine());
                if (quantity > PS.SpaceGold)
                {
                    Console.WriteLine("You don't have that much Space Gold!\n Press any key to return to the selling menu...");
                    Console.ReadLine();
                    Sell();
                }
                PS.SpaceGold -= quantity;
                PS.MyCurrentCredit += (quantity * sGold);
                Console.WriteLine($"Thanks for the Gold! You sold {quantity} bars of Space Gold for {(quantity * sGold)} Galactic Credits." +
                    $"You now have {PS.MyCurrentCredit} Galactic Credits and {PS.SpaceGold} bars of Space Gold left.\n Press any key to continue...");
                Console.ReadLine();
                Sell();
            }
            if (TV)
            {
                Console.WriteLine("How many TVs do you want to sell?");
                int quantity = Convert.ToInt32(Console.ReadLine());
                if (quantity > PS.GalacticTVs)
                {
                    Console.WriteLine($"You don't have that many Galactic TVs, you only have {PS.GalacticTVs}.\n Press any key to return to the selling menu...");
                    Console.ReadLine();
                    Sell();
                }
                PS.GalacticTVs -= quantity;
                PS.MyCurrentCredit += (quantity * gTV);
                Console.WriteLine($"Thank you for the Galactic TVs I can't believe how thin they are!\n You sold {quantity} Galactic TVs for {(quantity * gTV)} Galactic Credits." +
                    $"You now have {PS.MyCurrentCredit} Galactic Credits and {PS.GalacticTVs} Galactic TVs left.\n Press any key to continue...");
                Console.ReadLine();
                Sell();
            }


            #endregion

        }
    }
}
