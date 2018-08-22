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
                EarthPage();
            }

        }
        public void Bank()
        {
            Console.Clear();
            // write flavor text for bank
            Console.WriteLine($"You have {PS.MyCurrentCredit} Galactic Credits in your Galactic Bank Account. The title of Duke of Mercury costs 1,000,000 GC.\n" +
                $"You need {(1000000 - PS.MyCurrentCredit)} more credits before you can win the king of Venus' approval.\nPress any key to continue...");
            Console.ReadLine();
            EarthPage();
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
                ShipCheck();
            if (BuyShip)
                PurchaseShip();
            if (Return)
                EarthPage();
        }
        public void PurchaseShip()
        {
            Console.WriteLine("There are no ships available for purchase right now, come back later...\nPress any key to continue...");
            Console.ReadLine();
            ShipYard();
        }
        public void ShipCheck()
        {
            Console.WriteLine($"You arrive at your personal hanger, you ship, a {PS.ShipName} the SS {PS.MyName}, stands before you gleaming in the artificail lights of the hanger\n" +
                $"A {PS.ShipName} like this has {PS.ShipCapacity} slots in its cargo hold and a top speed of Warp Factor {PS.ShipSpeed}\n" +
                $"Inside the hold you have {PS.NoBalanaceShoes} boxes of No Balance Shoes, {PS.SpaceGold} bars of Space Gold & {PS.GalacticTVs} boxes of Galactic TVs\n" +
                $"Press any key to continue...");
            Console.ReadLine();
            ShipYard();
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
            double playerWarpSpeed = (Math.Pow(PS.ShipSpeed, 10 / 3) + Math.Pow(10 - PS.ShipSpeed, -11 / 3));
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

        #region AlphaCentari
        public void AlphaCentariPage()
        {
            Console.Clear();
            Console.Write("Welcome to Alpha Centari! You stand in the port city of Macawalani. Centarian birdpeople fly to and fro. \nYou spot a few pairs of No Balances here and there but whats the point when you have wings? \n" +
                "Stilted building dominate the skyline, your human sensability is assualted by the seemingly \nrandom way the doors are arranged until you see a Centarian fly up to a sixth floor door and" +
                "enter the building. \nThe air is surprisingly clear from the lack of vehicles in the city center.\n" +
                "It's not just Centarians though, you see a large amount of humans from your own region of space, \n some are earth humans but " +
                "you spot a blue Venusian and a orange mercurian amoung them. \n Coming out of the docks you even spot a Pician fellow his telltale" +
                " glass helmet \nkeeping his gills underwater. \nWhere would you like to go? \n" +
                "1. Ship Yard \n" +
                "2. Galactic Bank of Centari IV \n" +
                "3. Buy, Sell, Trade \n" +
                "4. Galactic Stock Exchange\n" +
                "5. Departure Port\n" +
                "Enter your choice: ");
            AlphaCentariSelector();
        }
        public void AlphaCentariSelector()
        {
            
            int response = Convert.ToInt32(Console.ReadLine());
            bool shipYard = response == 1;
            bool galacticBank = response == 2;
            bool shop = response == 3;
            bool market = response == 4;
            bool port = response == 5;
            
            if (shipYard)
                AlphaShipYard();

            if (galacticBank)
                AlphaBank();

            if (shop)
                AlphaShop();

            if (market)
                AlphaMarket();

            if (port)
                AlphaCentariPort();

            else
            {
                Console.WriteLine("invalid entry");
                AlphaCentariPage();
            }
        }
        public void AlphaShop()
        {
            Console.Clear();
            Console.WriteLine("What would you like to do?\n 1 Buy Cargo\n 2 Sell Cargo\n 3 Return to Macawalani streets");
            int response = Convert.ToInt32(Console.ReadLine());
            bool purchase = response == 1;
            bool offload = response == 2;
            bool Return = response == 3;
            if (purchase)
                AlphaBuy();
            if (offload)
                AlphaSell();
            if (Return)
                AlphaCentariPage();
        }
        public void AlphaBuy()
        {
            Console.Clear();
            Console.WriteLine($"You have {PS.MyCurrentCredit} Galactic Credits, what good would you like to buy?\n " +
                $"1 NoBalanceShoes {PS.AlphaCentariNoBalanceShoes} GC per Unit\n 2 Space Gold {PS.AlphaCentariGold} GC per Unit\n 3 Galactic TV {PS.AlphaCentariGalacticTVs} GC per Unit \n 4 " +
                $"Return to the Shop");
            int response = Convert.ToInt32(Console.ReadLine());
            bool Shoes = response == 1;
            bool Gold = response == 2;
            bool TV = response == 3;
            bool Return = response == 4;

            //Buy Shoes
            if (Shoes)
            {
                Console.Write("How many?");
                int quantity = Convert.ToInt32(Console.ReadLine());
                if ((quantity * PS.AlphaCentariNoBalanceShoes) > PS.MyCurrentCredit)
                {
                    Console.Write("You can't afford that! \n" +
                        "Press enter to return to the Shop..");
                    Console.ReadLine();
                    AlphaBuy();
                }
                if ((quantity + PS.GalacticTVs + PS.SpaceGold + PS.NoBalanaceShoes) > PS.ShipCapacity)
                {
                    Console.Write($"You don't have room for that! You currently" +
                        $" have {(PS.ShipCapacity - (PS.SpaceGold + PS.GalacticTVs + PS.NoBalanaceShoes))} space left in your cargo hold\n" +
                        $"Press enter to continue...");
                    Console.ReadLine();
                    AlphaBuy();
                }
                PS.MyCurrentCredit -= (quantity * PS.AlphaCentariNoBalanceShoes);

                PS.NoBalanaceShoes += quantity;

                Console.WriteLine($"you bought {quantity} NoBalance Shoes for {quantity * PS.AlphaCentariNoBalanceShoes} GC, your new balance is {PS.MyCurrentCredit} GC \n " +
                    $"You now have {PS.NoBalanaceShoes} pairs of No Balanace Shoes in your ship.\n Press any key to continue..");

                Console.ReadLine();
                AlphaBuy();
            }
            //Buy Gold
            if (Gold)
            {
                Console.WriteLine("How many?");
                int quantity = Convert.ToInt32(Console.ReadLine());
                if ((quantity * PS.AlphaCentariGold) > PS.MyCurrentCredit)
                {
                    Console.WriteLine("You can't afford that! \n" +
                        "Press any key to return to the Shop..");
                    Console.ReadLine();
                    AlphaBuy();
                }
                if ((quantity + PS.GalacticTVs + PS.SpaceGold + PS.NoBalanaceShoes) > PS.ShipCapacity)
                {
                    Console.WriteLine($"You don't have room for that! You currently" +
                        $" have {(PS.ShipCapacity - (PS.SpaceGold + PS.GalacticTVs + PS.NoBalanaceShoes))} space left in your cargo hold\n" +
                        $"Press any key to continue...");
                    Console.ReadLine();
                    AlphaBuy();
                }
                PS.MyCurrentCredit -= (quantity * PS.AlphaCentariGold);

                PS.SpaceGold += quantity;

                Console.WriteLine($"you bought {quantity} Bars of Space Gold for {quantity * PS.AlphaCentariGold} GC, your new balance is {PS.MyCurrentCredit} GC \n " +
                    $" You have {PS.SpaceGold} bars of Space Gold in your spaceship.\n Press any key to continue..");
                Console.ReadLine();
                AlphaBuy();
            }

            if (TV)
            {
                Console.WriteLine("How many?");
                int quantity = Convert.ToInt32(Console.ReadLine());
                if ((quantity * PS.AlphaCentariGalacticTVs) > PS.MyCurrentCredit)
                {
                    Console.WriteLine("You can't afford that! \n" +
                        "Press any key to return to the Shop..");
                    Console.ReadLine();
                    AlphaBuy();
                }
                if ((quantity + PS.GalacticTVs + PS.SpaceGold + PS.NoBalanaceShoes) > PS.ShipCapacity)
                {
                    Console.WriteLine($"You don't have room for that! You currently" +
                        $" have {(PS.ShipCapacity - (PS.SpaceGold + PS.GalacticTVs + PS.NoBalanaceShoes))} space left in your cargo hold\n" +
                        $"Press any key to continue...");
                    Console.ReadLine();
                    AlphaBuy();
                }
                PS.MyCurrentCredit -= (quantity * PS.AlphaCentariGalacticTVs);

                PS.GalacticTVs += quantity;



                Console.WriteLine($"you bought {quantity} Galactic TV(s) for {quantity * PS.AlphaCentariGalacticTVs} GC, your new balance is {PS.MyCurrentCredit} GC \n " +
                    $"You now have {PS.GalacticTVs} Galactic Tvs in your ship. \n Press any key to continue..");
                Console.ReadLine();
                AlphaBuy();
            }

            if (Return)
            {
                AlphaShop();
            }
        }
        public void AlphaSell()
        {
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
                    AlphaSell();
                }
                PS.NoBalanaceShoes -= quantity;
                PS.MyCurrentCredit += (quantity * PS.AlphaCentariNoBalanceShoes);
                Console.WriteLine($"Thank you for the No Balance Shoes, you can jump so high when gravity doesn't affect your feet!\nYou sold {quantity} No Balance Shoes for {(quantity * PS.AlphaCentariNoBalanceShoes)} Galactic Credits.\n" +
                    $"You now have {PS.MyCurrentCredit} Galactic Credits and {PS.NoBalanaceShoes} No Balanace Shoes.\n Press any key to continue...");
                Console.ReadLine();
                AlphaSell();
            } 
            if (Gold)
            {
                Console.WriteLine("How much Space Gold do you want sell?");
                int quantity = Convert.ToInt32(Console.ReadLine());
                if (quantity > PS.SpaceGold)
                {
                    Console.WriteLine($"You don't have that much Space Gold!\nYou only have {PS.SpaceGold} bars of Space Gold. \nPress any key to return to the selling menu...");
                    Console.ReadLine();
                    AlphaSell();
                }
                PS.SpaceGold -= quantity;
                PS.MyCurrentCredit += (quantity * PS.AlphaCentariGold);
                Console.WriteLine($"Thanks for the Space Gold, Space Gold is so much more shiny than boring old regular gold!\nYou sold {quantity} bars of Space Gold for {(quantity * PS.AlphaCentariGold)} Galactic Credits.\n" +
                    $"You now have {PS.MyCurrentCredit} Galactic Credits and {PS.SpaceGold} bars of Space Gold left.\n Press any key to continue...");
                Console.ReadLine();
                AlphaSell();
            }
            if (TV)
            {
                Console.WriteLine("How many TVs do you want to sell?");
                int quantity = Convert.ToInt32(Console.ReadLine());
                if (quantity > PS.GalacticTVs)
                {
                    Console.WriteLine($"You don't have that many Galactic TVs, you only have {PS.GalacticTVs}.\n Press any key to return to the selling menu...");
                    Console.ReadLine();
                    AlphaSell();
                }
                PS.GalacticTVs -= quantity;
                PS.MyCurrentCredit += (quantity * PS.AlphaCentariGalacticTVs);
                Console.WriteLine($"Thank you for the Galactic TVs I can't believe how thin they are!\nYou sold {quantity} Galactic TVs for {(quantity * PS.AlphaCentariGalacticTVs)} Galactic Credits.\n" +
                    $"You now have {PS.MyCurrentCredit} Galactic Credits and {PS.GalacticTVs} Galactic TVs left.\n Press any key to continue...");
                Console.ReadLine();
                AlphaSell();
            }
            if (Return)
            {
                AlphaShop();
            }

        }
        #endregion
        #region EndPage
        public void EndScreen()
        {
            Console.WriteLine($"Game Over\n\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\nYou had {PS.MyCurrentCredit} Galactic Credits at the end of your journey" +
                $"\nYou traveled for {PS.MyTravelTime} years total\nYou had a {PS.ShipName} class ship");
        }
        #endregion
    }
}
