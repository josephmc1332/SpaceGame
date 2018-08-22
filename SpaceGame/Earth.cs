using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Earth
    {
        PersonalStatus PS = new PersonalStatus();
        IntroPage IP = new IntroPage();
        #region Earth Page

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

            if (market) 
                 Market();

            if (port) 
               EarthPort();

            else
            {
                //loops back to the beginning of earth page
                Console.WriteLine("invalid entry");
                Console.ReadLine();
                EarthPage();
            }

        }
        /// <summary>
        /// Go to the Bank
        /// </summary>
        public void Bank()
        {
            Console.Clear();

            // write flavor text for bank
            Console.WriteLine($"You have {PS.MyCurrentCredit} Galactic Credits in your Galactic Bank Account. " +
                $"The title of Duke of Mercury costs 1,000,000 GC.\n" +
                $"You need {(1000000 - PS.MyCurrentCredit)} more credits before you can " +
                $"win the king of Venus' approval.\nPress any key to continue...");

            Console.ReadLine();

            //Return
            EarthPage();
        }
        /// <summary>
        /// go to the Ship Yard
        /// </summary>
        public void ShipYard()
        {
            Console.Clear();

            // write flavor text about shipyard
            Console.WriteLine("You walk into the Shipyard, the sound of welders and hammers fills the air. " +
                "Ship salesman are weaving in and out of" +
                "the ships pushing their latest ship on travelers all the while dodging the laborers." +
                "\nWould you like to:\n 1 Check your ship stats\n 2 Buy a new Ship\n 3 Return to planetary hub");

            //convert response to numberic value of type int
            int response = Convert.ToInt32(Console.ReadLine());

            //Determines where user wants to go in the Ship yard
            bool ShipStats = response == 1;
            bool BuyShip = response == 2;
            bool Return = response == 3;

            //boolean value tells what method will be called
            if (ShipStats)
                ShipCheck();
            if (BuyShip)
                PurchaseShip();
            if (Return)
                EarthPage();
        }
        /// <summary>
        /// Buy a new Ship
        /// </summary>
        public void PurchaseShip()
        {
            Console.Clear();

            //display the users current ship and credits. Ship selections with price
            Console.WriteLine($"You currently own the {PS.ShipName}, which is a great ship, but it's time to upgrade... " +
                $"\nwhat ship are you looking to hop in today?" +
                $"\nyou currently have {PS.MyCurrentCredit} credits" +
                $"\n1 The Interstellar Connex 600 GCs" +
                $"\n2 The StarWagon 1200GCs");

            //convert response to numeric value of type int
            int shipUpgrade = Convert.ToInt32(Console.ReadLine());



            //If buying the interstellar
            if (shipUpgrade == 1 && PS.MyCurrentCredit >= 600)
            {
                string myShipUpgrade = "The Interstellar Connex";

                Console.Clear();

                Console.WriteLine($"You chose the {myShipUpgrade}! That's a great choice. \n" +
                    $"It has a capacity of {PS.InterstellarConnexCapacity} slots. This is our biggest ship! " +
                    $"\nWith a max warp speed of" +
                    $" {PS.InterstellarConnexSpeed}. ");

                Console.ReadLine();

                //ask if user is sure of purchase
                Console.WriteLine("Would you like to complete this purchase? \nyes or no?");

                //user response 
                string userShipAnswer = Console.ReadLine();

                //execute the purchase
                if (userShipAnswer == "yes")
                {
                    //subtract credit after purchase
                    PS.MyCurrentCredit = PS.MyCurrentCredit - 600;

                    //display ship bought and remaining credit
                    Console.WriteLine($"Congratulations on your new ship purchase! " +
                        $"You now own the {myShipUpgrade} and have {PS.MyCurrentCredit} remaining");

                    Console.ReadLine();

                    ShipYard();
                }
                //stop the purchase
                else
                {
                    ShipYard();
                }

            }
            //stop purchase. not enough credits
            else
            {
                Console.WriteLine("You do not have enough credits to complete this purchase!");

                Console.ReadLine();

                ShipYard();
                    
            }

            //if buying the starwagon
            if (shipUpgrade == 2 && PS.MyCurrentCredit >= 1200)
            {
                //initialize ship 
                string myShipUpgrade = "The StarWagon";

                Console.Clear();

                //summary of ship(speed, name, and capacity)
                Console.WriteLine($"You chose the {myShipUpgrade}! That's a great choice. \n" +
                    $"It has a capacity of {PS.StarWagonCapacity} slots." +
                    $"\nWith a max warp speed of" +
                    $" {PS.StarWagonSpeed}. This is our fastest ship by far!");

                //press enter
                Console.ReadLine();

                //confirm purchase
                Console.WriteLine("Would you like to complete this purchase? \nyes or no?");
                string userShipAnswer = Console.ReadLine();

                //after purchase is confirmed subtract credits
                if (userShipAnswer == "yes")
                {
                    PS.MyCurrentCredit = PS.MyCurrentCredit - 1200;

                    //display ship purchased and remaining credits
                    Console.WriteLine($"Congratulations on your new ship purchase! You now own the {myShipUpgrade} and have {PS.MyCurrentCredit} remaining");

                    Console.ReadLine();

                    ShipYard();
                }
                //stop purchase
                else
                {
                    ShipYard();
                }

            }
            //stop purchase
            else
            {
                Console.WriteLine("You do not have enough credits to complete this purchase!");

                Console.ReadLine();
                ShipYard();

            }

        }
        /// <summary>
        /// status of my ship -----IF I HAVE A NEW SHIP------
        /// </summary>
        public void ShipCheck()
        {
            //Description of current ship (cargo information) 
            Console.WriteLine($"You arrive at your personal hanger, your ship, a {PS.ShipName} the SS {PS.MyName}, " +
                $"stands before you gleaming in the artificail lights of the hanger\n" +
                $"A {PS.ShipName} like this has {PS.ShipCapacity} slots in its cargo hold and a top speed of Warp Factor {PS.ShipSpeed}\n" +
                $"Inside the hold you have {PS.NoBalanaceShoes} boxes of No Balance Shoes, {PS.SpaceGold} bars of Space Gold & {PS.GalacticTVs} " +
                $"boxes of Galactic TVs\n" +
                $"Press any key to continue...");

            Console.ReadLine();
            ShipYard();
        }
        /// <summary>
        /// BUY SELL TRADE GOODS
        /// </summary>
        public void Shop()
        {
            Console.Clear();

            //user select option for shop
            Console.WriteLine("What would you like to do?\n 1 Buy Cargo\n 2 Sell Cargo\n 3 Return to planetary hub");

            //convert string response to numeric value of type int
            int response = Convert.ToInt32(Console.ReadLine());

            //bool expression to identify what method to call for user response
            bool purchase = response == 1;
            bool offload = response == 2;
            bool Return = response == 3;

            //methods to potentially be called
            if (purchase)
                Buy();
            if (offload)
                Sell();
            if (Return)
                EarthPage();
        }

        /// <summary>
        /// user to buy products
        /// </summary>
        public void Buy()
        {
            //Initialize earth values of goods
            int sGold = 100;
            int noShoes = 80;
            int gTV = 120;


            Console.Clear();

            //display current credit and ask user for purchase selection (number based)
            Console.WriteLine($"You have {PS.MyCurrentCredit} Galactic Credits, what good would you like to buy?\n " +
                $"1 NoBalanceShoes 80 GC per Unit\n 2 Space Gold 100 GC per Unit\n 3 Galactic TV 120 GC per Unit \n 4 " +
                $"Return to Planetary Menu");

            //convert user response to numberic value of type int
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
                if ((quantity + PS.GalacticTVs + PS.SpaceGold + PS.NoBalanaceShoes) > PS.ShipCapacity)
                {
                    Console.WriteLine($"You don't have room for that! You currently" +
                        $" have {(PS.ShipCapacity - (PS.SpaceGold + PS.GalacticTVs + PS.NoBalanaceShoes))} space left in your cargo hold\n" +
                        $"Press any key to continue...");
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
                if ((quantity + PS.GalacticTVs + PS.SpaceGold + PS.NoBalanaceShoes) > PS.ShipCapacity)
                {
                    Console.WriteLine($"You don't have room for that! You currently" +
                        $" have {(PS.ShipCapacity - (PS.SpaceGold + PS.GalacticTVs + PS.NoBalanaceShoes))} space left in your cargo hold\n" +
                        $"Press any key to continue...");
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
                if ((quantity + PS.GalacticTVs + PS.SpaceGold + PS.NoBalanaceShoes) > PS.ShipCapacity)
                {
                    Console.WriteLine($"You don't have room for that! You currently" +
                        $" have {(PS.ShipCapacity - (PS.SpaceGold + PS.GalacticTVs + PS.NoBalanaceShoes))} space left in your cargo hold\n" +
                        $"Press any key to continue...");
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
                    Console.WriteLine($"You don't have that many shoes!\n You only have {PS.NoBalanaceShoes} pairs of No Balance Shoes. \nPress any key to return to the selling menu...");
                    Console.ReadLine();
                    Sell();
                }
                PS.NoBalanaceShoes -= quantity;
                PS.MyCurrentCredit += (quantity * noShoes);
                Console.WriteLine($"Thank you for the No Balance Shoes, you can jump so high when gravity doesn't affect your feet!\nYou sold {quantity} No Balance Shoes for {(quantity * noShoes)} Galactic Credits.\n" +
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
                    Console.WriteLine($"You don't have that much Space Gold!\nYou only have {PS.SpaceGold} bars of Space Gold. \nPress any key to return to the selling menu...");
                    Console.ReadLine();
                    Sell();
                }
                PS.SpaceGold -= quantity;
                PS.MyCurrentCredit += (quantity * sGold);
                Console.WriteLine($"Thanks for the Space Gold, Space Gold is so much more shiny than boring old regular gold!\nYou sold {quantity} bars of Space Gold for {(quantity * sGold)} Galactic Credits.\n" +
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
                Console.WriteLine($"Thank you for the Galactic TVs I can't believe how thin they are!\nYou sold {quantity} Galactic TVs for {(quantity * gTV)} Galactic Credits.\n" +
                    $"You now have {PS.MyCurrentCredit} Galactic Credits and {PS.GalacticTVs} Galactic TVs left.\n Press any key to continue...");
                Console.ReadLine();
                Sell();
            }

         }
        public void Market()
        {
            Console.WriteLine("The Galactic Stock exchange glitters and flashes, \nnumbers come and go up and down but you worry about the three perenial commodities.\n" +
                "No Balance Shoes, the zero gravity shoes that changed the way the galaxy moves. \nSpace Gold, it's like the gold everyone knows and loves but shinier and better in every way." +
                "\nAnd Galactic TVs, TVs so thin that you can't even see them unless you are standing in front of them.\n" +
                $"The display flashes their market prices. \nEarth: \n\tNo Balance Shoes: {PS.EarthNoBalanceShoes} \n\tSpace Gold: {PS.EarthSpaceGold} \n\tGalactic TVs: {PS.EarhtGalacticTVs}" +
                $"\n \nAlpha Centari:\n\t No Balance Shoe: {PS.AlphaCentariNoBalanceShoes}\n\tSpace Gold: {PS.AlphaCentariGold}\n\tGalactic TVs: {PS.AlphaCentariGalacticTVs}\n \nM63:\n\t No Balance Shoes: {PS.M63NoBalanceShoes}" +
                $"\n\tSpace Gold: {PS.M63SpaceGold}\n\tGalactic TVs: {PS.M63GalacticTVs} ");
            Console.ReadLine();
        }
        public void EarthPort()
        {
            double distAlphaCentari = (Math.Sqrt(Math.Pow(PS.EarthXPosition - PS.AlphaCentariXPosition, 2) + Math.Pow(PS.EarthYPosition - PS.AlphaCentariYPosition, 2)));
            double distM63 = (Math.Sqrt(Math.Pow(PS.EarthXPosition - PS.M63XPosition, 2) + Math.Pow(PS.EarthYPosition - PS.M63YPosition, 2)));
            double playerWarpSpeed = (Math.Pow(PS.ShipSpeed, 10.0 / 3.0) + Math.Pow(10 - PS.ShipSpeed, -11.0 / .03));
            Console.Clear();
            Console.WriteLine($"Where would you like to go? \n\t1 Alpha Centari: {distAlphaCentari} Light years away which will take {distAlphaCentari / playerWarpSpeed} years" +
                $"\n\t2 M63: {distM63} Light years away which will take {distM63 / playerWarpSpeed} years\n\t3 Return to earth");
            int response = Convert.ToInt32(Console.ReadLine());
            bool travelAlpha = response == 1;
            bool travelM63 = response == 2;
            bool Return = response == 3;
            if (travelAlpha)
            {
                if ((distAlphaCentari / playerWarpSpeed) + PS.MyTravelTime > 40.0)
                {
                    Console.WriteLine("As you travel to Alpha Centari you realize you are too old for this space shiz and decide to retire");
                    Console.ReadLine();
                    PS.MyTravelTime += (distAlphaCentari / playerWarpSpeed);
                    EndScreen();
                }
                PS.MyTravelTime += (distAlphaCentari / playerWarpSpeed);
                Console.WriteLine($"The journey takes you {distAlphaCentari / playerWarpSpeed} you have been traveling for {PS.MyTravelTime} years now.\n" +
                    $"You arrive on ALpha Centari");
                Console.ReadLine();
                AlphaCentariPage();
            }
            
            if (Return)
            {
                EarthPage();
            }
        }

        #endregion

        public void AlphaCentariPage()
        {
            Console.WriteLine("You live on Alpha centari for 15 years. You turn around and go home to earth");
            Console.ReadLine();
            PS.MyTravelTime += 15;
            EarthPage();
        }

        #region EndPage
        public void EndScreen()
        {
            Console.WriteLine($"Game Over\n\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\nYou had {PS.MyCurrentCredit} Galactic Credits at the end of your journey" +
                $"\nYou traveled for {PS.MyTravelTime} years total\nYou had a {PS.ShipName} class ship");
        }
        #endregion
    }
}
