﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Earth
    {
        GameOver GO = new GameOver();
        PersonalStatus PS = new PersonalStatus();
        Random rnd = new Random();
        UtilityMethods UM = new UtilityMethods();

        public void FirstPage()
        {
            Console.Write("\n\n\n" +
                "\t\t\t\t                  D U K E                  \n" +
                "\t\t\t\t                    O F                    \n" +
                "\t\t\t\t               M E R C U R Y               \n" +
                "\t\t\t\t  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n" +
                "\t\t\t\t |  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|\n" +
                "\t\t\t\t | |   .      .  _____________  .     *   ||\n" +
                "\t\t\t\t | |     *      / _    \\    \\ \\  .        ||\n" +
                "\t\t\t\t | |  .        / /#\\    \\    \\ \\__    *   ||\n" +
                "\t\t\t\t | |    .  *  | |##|    |    | |##\\       ||\n" +
                "\t\t\t\t | |#####     | |##|    |    | |###\\      ||\n" +
                "\t\t\t\t | |######   _|_|##|____|____|_|####\\     ||\n" +
                "\t\t\t\t | |#######<| | //\\ | /\\\\    CAMEL   |    ||\n" +
                "\t\t\t\t | |#######<|_|||  \\|/ ||____________|    ||\n" +
                "\t\t\t\t | |######   . ||  /*\\ ||     * .    *    ||\n" +
                "\t\t\t\t | |#####  .    \\\\/_|_\\//                 ||\n" +
                "\t\t\t\t | |   *     .   -------     .     *    . ||\n" +
                "\t\t\t\t | |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~||\n" +
                "\t\t\t\t |_~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|\n\n" +
                "\t\t\t\t  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~" +
                "\n\t\t\t\t    Hello, welcome to Duke Of Mercury!\n" +
                "\t\t\t\t  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n" +
                "\t\t\t\t\t   What is your name? ");

            //user name
            PS.MyName = Console.ReadLine();
            PS.MyCurrentCredit = 300;
            //clears the text
            Console.Clear();

            //add story here
            Console.WriteLine($"\n\n\n\n" +
                $"\t\tOkay, {PS.MyName}. You were engaged to Venusian royalty but the king of Venus has forbidden your beloved \n" +
                $"\t\tto marry a mere commoner like yourself. But there is even worse news! \n" +
                $"\t\tYour beloved has other interested parties, and what's worse is they are already nobility. \n" +
                $"\t\tBut you are in luck there is a way to buy into galactic nobility, but it's going to be a lot of work. \n" +
                $"\t\tYou've got a {PS.ShipName} class ship and {PS.MyCurrentCredit} Galactic Credits, \n" +
                $"\t\tso get out there and get to trading, {PS.MyName}!\n\n" +
                $"\n\n\n\n\n\n\n\n\t\t\tPress enter to continue past this or any screen in this game.");

            Console.ReadLine();
        }

        #region Earth Page

        public void EarthPage()


        {
            //Define Location

            PS.MyCurrentLocation = "Earth";

          

           if (PS.MyCurrentLocation == "Earth")
            {
                double xAxis = PS.EarthXPosition;
                double yAxis = PS.EarthYPosition;
            }




            //clear up window
            Console.Clear();

            //display menu on earth upon arrival
            UM.InventoryDisplay(PS);
            Console.WriteLine("\n\n" +
                "\t'Welcome to Earth!' earth ambassador Will Smith says dressed in his now \n" +
                "\ticonic US Air Force pilots uniform'Home planet of us Humans.' He smiles \n" +
                "\tbroadly stepping to the side and allowing you to pass. As you step by him\n" +
                "\tthe streets of Merica, the famous capital of Earth, are packed with busy humans\n" +
                "\tmoving in and out of the buildings. Self driving cars clog the streets and the\n" +
                "\tside walks are full to the gills with people.\n\n" +
                "\t\tWhere would you like to go? \n" +
                "\t\t  1. Ship Yard \n" +
                "\t\t  2. Galactic Bank \n" +
                "\t\t  3. Buy, Sell, Trade \n" +
                "\t\t  4. Galactic Market\n" +
                "\t\t  5. Departure Port\n\n" +
                "\t\t9. Quit the Game");

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
            


            //point of method access after valid user selection
            if (response == 1)
                ShipYard();

            if (response == 2)
                Bank();

            if (response == 3)
                Shop();

            if (response == 4) 
                 Market();

            if (response == 5) 
               EarthPort();

            if (response == 9)
                GO.EndScreen(PS);

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
            UM.InventoryDisplay(PS);
            // write flavor text for bank
            Console.WriteLine($"\n\n" +
                $"\tYou have {PS.MyCurrentCredit} Galactic Credits in your Galactic Bank Account.\n" +
                $"\tThe title of Duke of Mercury costs 1,000,000 GC. You need {(1000000 - PS.MyCurrentCredit)} \n" +
                $"\tmore credits before you can win the king of Venus' approval.\n\n" +
                $"\t\tPress any enter to continue...");
            Console.ReadLine();
            GO.Win(PS);
            EarthPage();
        }
        public void ShipYard()
        {
            Console.Clear();
            UM.InventoryDisplay(PS);
            // write flavor text about shipyard
            Console.WriteLine("\n\n" +
                "\tYou walk into the Shipyard, the sound of welders and hammers fills the air. Ship salesman \n" +
                "\tare weaving in and out of the ships pushing their latest ship on travelers all the while \n" +
                "\tdodging the laborers.\n\n" +
                "\t\tWould you like to:\n" +
                "\t\t  1 Check your ship stats\n" +
                "\t\t  2 Buy a new Ship\n" +
                "\t\t  3 Return to planetary hub");
            int response = Convert.ToInt32(Console.ReadLine());
            if (response == 1)
                ShipCheck();
            if (response == 2)
                PurchaseShip();
            if (response == 3)
                EarthPage();
        }
        public void PurchaseShip()
        {
            Console.Clear();
            UM.InventoryDisplay(PS);
            //display the users current ship and credits. Ship selections with price
            Console.WriteLine($"\n\n" +
                $"\tYou currently own the {PS.ShipName}, which is a great ship, but it's time to upgrade... \n" +
                $"\tWhat ship are you looking to hop in today?\n" +
                $"\tYou currently have {PS.MyCurrentCredit} credits\n" +
                $"\t  1 The Interstellar Connex 600 GCs\n" +
                $"\t  2 The StarWagon 1200GCs");
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
                    PS.ShipSpeed = PS.InterstellarConnexSpeed;
                    PS.ShipCapacity = PS.InterstellarConnexCapacity;
                    PS.ShipName = myShipUpgrade;
                    //subtract credit after purchase
                    PS.MyCurrentCredit = PS.MyCurrentCredit - 600;
                    //display ship bought and remaining credit
                    Console.WriteLine($"Congratulations on your new ship purchase! " +
                        $"You now own the {PS.ShipName} and have {PS.MyCurrentCredit} remaining");
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
                Console.WriteLine($"\n\n" +
                    $"\tYou chose the {myShipUpgrade}! That's a great choice. \n" +
                    $"\tIt has a capacity of {PS.StarWagonCapacity} slots.\n" +
                    $"\tWith a max warp speed of {PS.StarWagonSpeed}. This is our fastest ship by far!");
                //press enter
                Console.ReadLine();
                //confirm purchase
                Console.WriteLine("\n\nWould you like to complete this purchase? \nyes or no?");
                string userShipAnswer = Console.ReadLine();
                //after purchase is confirmed subtract credits
                if (userShipAnswer == "yes")
                {
                    PS.ShipName = myShipUpgrade;
                    PS.ShipCapacity = PS.StarWagonCapacity;
                    PS.ShipSpeed = PS.StarWagonSpeed;
                    PS.MyCurrentCredit = PS.MyCurrentCredit - 1200;
                    //display ship purchased and remaining credits
                    Console.Clear();
                    Console.WriteLine($"Congratulations on your new ship purchase! You now own the {PS.ShipName} " +
                        $"\nand have {PS.MyCurrentCredit} credits remaining");
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
        public void ShipCheck()
        {
            Console.Clear();
            UM.InventoryDisplay(PS);
            Console.WriteLine($"\n\n" +
                $"\tYou arrive at your personal hanger, you ship, a {PS.ShipName} the SS {PS.MyName}, stands \n" +
                $"\tbefore you gleaming in the artificail lights of the hanger. \n" +
                $"\tA {PS.ShipName} like this has {PS.ShipCapacity} slots in its cargo hold \n" +
                $"\tand a top speed of Warp Factor {PS.ShipSpeed}\n" +
                $"\tInside the hold you have: \n" +
                $"\t{PS.NoBalanaceShoes} boxes of No Balance Shoes \n" +
                $"\t{PS.SpaceGold} bars of Space Gold \n" +
                $"\t{PS.GalacticTVs} boxes of Galactic TVs\n\n" +
                $"\t\tPress enter to continue...");
            Console.ReadLine();
            ShipYard();
        }
        public void Shop()
        {
            Console.Clear();
            UM.InventoryDisplay(PS);
            Console.WriteLine("\n\n" +
                "\t'Welcome to my little shop!' The man behind the counter says. His Earth flag bandana, a \n" +
                "\tmodified version of Old Glory with the stars replaced with a picture of the planet earth, \n" +
                "\tis made from light enhanced fabric that shines even in the dark. He smiles at you his dirty \n" +
                "\tblond scruff offsetting his brigthly whitened teeth. 'I've got all the Space Gold and TVs a \n" +
                "\ttrader like you could ever want, and have you seen these new zero grav shoes? They are all \n" +
                "\tthe rage out on the larger planets.\n\n" +
                "\t\tWhat would you like to do?\n" +
                "\t\t  1 Buy Cargo\n" +
                "\t\t  2 Sell Cargo\n" +
                "\t\t  3 Return to planetary hub");
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
            Console.Clear();
            UM.InventoryDisplay(PS);
            Console.WriteLine($"\n\n" +
                $"\tYou have {PS.MyCurrentCredit} Galactic Credits, what good would you like to buy?\n" +
                $"\t 1 NoBalanceShoes 80 GC per Unit\n" +
                $"\t 2 Space Gold 100 GC per Unit\n" +
                $"\t 3 Galactic TV 120 GC per Unit \n" +
                $"\t 4 Return to Planetary Menu");
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
                if ((quantity * PS.EarthNoBalanceShoes) > PS.MyCurrentCredit)
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
                PS.MyCurrentCredit -= (quantity * PS.EarthNoBalanceShoes);

                PS.NoBalanaceShoes += quantity;

                Console.WriteLine($"you bought {quantity} NoBalance Shoes for {PS.EarthNoBalanceShoes * quantity} GC, your new balance is {PS.MyCurrentCredit} GC \n " +
                    $"You now have {PS.NoBalanaceShoes} pairs of No Balanace Shoes in your ship.\n Press any key to continue..");

                Console.ReadLine();
                Buy();
            }
            //Buy Gold
            if (Gold)
            {
                Console.WriteLine("How many?");
                int quantity = Convert.ToInt32(Console.ReadLine());
                if ((quantity * PS.EarthSpaceGold) > PS.MyCurrentCredit)
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
                PS.MyCurrentCredit -= (quantity * PS.EarthSpaceGold);

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
                if ((quantity * PS.EarhtGalacticTVs) > PS.MyCurrentCredit)
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
                PS.MyCurrentCredit -= (quantity * PS.EarhtGalacticTVs);

                PS.GalacticTVs += quantity;



                Console.WriteLine($"You bought {quantity} Galactic TV(s), your new balance is {PS.MyCurrentCredit} \n " +
                    $"You now have {PS.GalacticTVs} Galactic Tvs in your ship. \n" +
                    $" Press enter to continue...");
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
            UM.InventoryDisplay(PS);
            Console.WriteLine($"\n\n" +
                $"\tYou have {PS.NoBalanaceShoes} pairs of No Balance Shoes, \n" +
                $"\t{PS.SpaceGold} bars of Space Gold \n" +
                $"\t{PS.GalacticTVs} sets of Galactic TVs.\n" +
                $"\tWhich would you like to sell?\n" +
                $"\t  1 No Balance Shoes\n" +
                $"\t  2 Space Gold\n" +
                $"\t  3 Galactic TVs\n" +
                $"\t  4 or Return to the Shop");
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
            Console.Clear();
            UM.InventoryDisplay(PS);
            Console.WriteLine("\n\n" +
                "\tThe Galactic Stock exchange glitters and flashes, and down but you worry about the three perenial commodities.\n" +
                "\tNo Balance Shoes, the zero gravity shoes that changed the way the galaxy moves. \n" +
                "\tSpace Gold, it's like the gold everyone knows and loves but shinier and better in every way.\n" +
                "\tAnd Galactic TVs, TVs so thin that you can't even see them unless you are standing in front of them.\n" +
                $"\tThe display flashes their market prices. \n\n" +
                $"\tEarth: \n" +
                $"\t\tNo Balance Shoes: {PS.EarthNoBalanceShoes} \n" +
                $"\t\tSpace Gold: {PS.EarthSpaceGold} \n" +
                $"\t\tGalactic TVs: {PS.EarhtGalacticTVs}\n\n" +
                $"\tAlpha Centari:\n" +
                $"\t\tNo Balance Shoe: {PS.AlphaCentariNoBalanceShoes}\n" +
                $"\t\tSpace Gold: {PS.AlphaCentariGold}\n" +
                $"\t\tGalactic TVs: {PS.AlphaCentariGalacticTVs}\n\n" +
                $"\tM63:\n" +
                $"\t\tNo Balance Shoes: {PS.M63NoBalanceShoes}\n" +
                $"\t\tSpace Gold: {PS.M63SpaceGold}\n" +
                $"\t\tGalactic TVs: {PS.M63GalacticTVs} ");
            Console.ReadLine();
        }
        public void EarthPort()
        {
            double distAlphaCentari = (Math.Sqrt(Math.Pow(PS.EarthXPosition - PS.AlphaCentariXPosition, 2) + Math.Pow(PS.EarthYPosition - PS.AlphaCentariYPosition, 2)));
            double distM63 = (Math.Sqrt(Math.Pow(PS.EarthXPosition - PS.M63XPosition, 2) + Math.Pow(PS.EarthYPosition - PS.M63YPosition, 2)));
            double playerWarpSpeed = (Math.Pow(PS.ShipSpeed, 10 / 3) + Math.Pow(10 - PS.ShipSpeed, -11 / 3));
            Console.Clear();
            UM.InventoryDisplay(PS);
            Console.WriteLine($"\n\n" +
                $"\tWhere would you like to go? \n" +
                $"\t\t1 Alpha Centari: {distAlphaCentari} Light years away which will take {distAlphaCentari / playerWarpSpeed} years\n" +
                $"\t\t2 M63: {distM63} Light years away which will take {distM63 / playerWarpSpeed} years\n" +
                $"\t\t3 Return to earth");
            int response = Convert.ToInt32(Console.ReadLine());
            bool travelAlpha = response == 1;
            bool travelM63 = response == 2;
            bool Return = response == 3;
            if (travelAlpha)
            {
                PS.MyTravelTime += (distAlphaCentari / playerWarpSpeed);
                if ((distAlphaCentari / playerWarpSpeed) + PS.MyTravelTime > 40.0)
                {
                    GO.Retire(PS);
                }
                UM.Travel(PS);
                Console.WriteLine($"The journey takes you {distAlphaCentari / playerWarpSpeed} you have been traveling for {PS.MyTravelTime} years now.\n" +
                    $"You arrive on ALpha Centari");
                Console.ReadLine();
                AlphaCentariPage();
            }
            if (travelM63)
            {
                PS.MyTravelTime += (distM63 / playerWarpSpeed); 
                if (PS.MyTravelTime > 40.0)
                {
                    GO.Retire(PS);
                }
                UM.Travel(PS);
                Console.WriteLine($"The jouney take you {distM63 / playerWarpSpeed} years, you have been traveling for {PS.MyTravelTime} years total.\n" +
                    $"You arrive on M63");
                Console.ReadLine();
                M63Page();
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
            UM.InventoryDisplay(PS);
            Console.Write("\n\n" +
                "\tWelcome to Alpha Centari! You stand in the port city of Macawalani. Centarian birdpeople fly to and fro. \n" +
                "\tYou spot a few pairs of No Balances here and there but whats the point when you have wings? \n" +
                "\tStilted building dominate the skyline, your human sensability is assualted by the seemingly \n" +
                "\trandom way the doors are arranged until you see a Centarian fly up to a sixth floor door and\n" +
                "\tenter the building. The air is surprisingly clear from the lack of vehicles in the city center.\n" +
                "\tIt's not just Centarians though, you see a large amount of humans from your own region of space, \n" +
                "\tsome are earth humans but you spot a blue Venusian and a orange mercurian amoung them. \n" +
                "\tComing out of the docks you even spot a Pician fellow his telltale glass helmet \n" +
                "\tkeeping his gills underwater. \n\n" +
                "\t\tWhere would you like to go? \n" +
                "\t\t 1. Ship Yard \n" +
                "\t\t 2. Galactic Bank of Centari IV \n" +
                "\t\t 3. Buy, Sell, Trade \n" +
                "\t\t 4. Galactic Stock Exchange\n" +
                "\t\t 5. Departure Port\n\n" +
                "\t\t 9. Quit game\n" +
                "\t\t Enter your choice: ");
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
            bool quit = response == 9;
            
            if (shipYard)
               AlphaYard();

            if (galacticBank)
                AlphaBank();

            if (shop)
                AlphaShop();

            if (market)
                AlphaMarket();

            if (port)
                AlphaCentariPort();

            if (quit)
                GO.EndScreen(PS);

            else
            {
                Console.WriteLine("invalid entry");
                AlphaCentariPage();
            }
        }
        public void AlphaYard()
        {
            Console.Clear();
            UM.InventoryDisplay(PS);
            // write flavor text about shipyard
            Console.WriteLine("\n\n" +
                "\tYou walk into the Shipyard, the sound of welders and hammers fills the air. Ship salesman are weaving in and out of" +
                "\tthe ships pushing their latest ship on travelers all the while dodging the laborers.\n" +
                "\t\tWould you like to:\n" +
                "\t\t 1 Check your ship stats\n" +
                "\t\t 2 Buy a new Ship\n" +
                "\t\t 3 Return to planetary hub");
            int response = Convert.ToInt32(Console.ReadLine());
            bool ShipStats = response == 1;
            bool BuyShip = response == 2;
            bool Return = response == 3;
            if (ShipStats)
                AlphaShipCheck();
            if (BuyShip)
                AlphaPurchaseShip();
            if (Return)
                AlphaCentariPage();
        }
        public void AlphaPurchaseShip()
        {
            Console.Clear();
            UM.InventoryDisplay(PS);
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
                    PS.ShipSpeed = PS.InterstellarConnexSpeed;
                    PS.ShipCapacity = PS.InterstellarConnexCapacity;
                    PS.ShipName = myShipUpgrade;
                    //subtract credit after purchase
                    PS.MyCurrentCredit = PS.MyCurrentCredit - 600;
                    //display ship bought and remaining credit
                    Console.WriteLine($"Congratulations on your new ship purchase! " +
                        $"You now own the {PS.ShipName} and have {PS.MyCurrentCredit} remaining");
                    Console.ReadLine();
                    AlphaYard();
                }
                //stop the purchase
                else
                {
                    AlphaYard();
                }
            }
            //stop purchase. not enough credits
            else
            {
                Console.WriteLine("You do not have enough credits to complete this purchase!");
                Console.ReadLine();
                AlphaYard();

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
                    PS.ShipName = myShipUpgrade;
                    PS.ShipCapacity = PS.StarWagonCapacity;
                    PS.ShipSpeed = PS.StarWagonSpeed;
                    PS.MyCurrentCredit = PS.MyCurrentCredit - 1200;
                    //display ship purchased and remaining credits
                    Console.WriteLine($"Congratulations on your new ship purchase! You now own the {PS.ShipName} " +
                        $"\nand have {PS.MyCurrentCredit} credits remaining");
                    Console.ReadLine();
                    AlphaYard();
                }
                //stop purchase
                else
                {
                    AlphaYard();
                }
            }
            //stop purchase
            else
            {
                Console.WriteLine("You do not have enough credits to complete this purchase!");
                Console.ReadLine();
                AlphaYard();
            }
        }
        public void AlphaShipCheck()
        {
            Console.Clear();
            UM.InventoryDisplay(PS);
            Console.WriteLine($"You arrive at your personal hanger, you ship, a {PS.ShipName} the SS {PS.MyName}, stands before you gleaming in the artificail lights of the hanger\n" +
                $"A {PS.ShipName} like this has {PS.ShipCapacity} slots in its cargo hold and a top speed of Warp Factor {PS.ShipSpeed}\n" +
                $"Inside the hold you have {PS.NoBalanaceShoes} boxes of No Balance Shoes, {PS.SpaceGold} bars of Space Gold & {PS.GalacticTVs} boxes of Galactic TVs\n" +
                $"Press any key to continue...");
            Console.ReadLine();
            AlphaYard();
        }
       
        
        public void AlphaShop()
        {
            Console.Clear();
            Console.WriteLine("You arrive at the shop on Alpha Centari. The owner, Brahman welcomes you. What's up, mane you know that we have the highest quality " +
                "\ngold in the universe!");
            Console.ReadLine();
            UM.InventoryDisplay(PS);
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
        public void AlphaBank()
        {
            Console.Clear();
            UM.InventoryDisplay(PS);
            Console.WriteLine($"Welcome to the Galactic Bank of Centari Four!\nBehind the counter is an tall old bird, his specticles are low on his beak and attached to his head by a gold chain.\n" +
                $"The high ceilings make room for doors on many levels but with no visable landing, of course ground based humans like you have to come in through the 'walkers' door.\n");
            UM.BankDisplay(PS);
            Console.ReadLine();
            AlphaCentariPage();
        }
        public void AlphaBuy()
        {
            Console.Clear();
            UM.InventoryDisplay(PS);
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
            UM.InventoryDisplay(PS);
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
        public void AlphaMarket()
        {
            Console.Clear();
            UM.InventoryDisplay(PS);
            Console.WriteLine($"The city of Macawalani on Centari IV has the largest stock exchange for a light year in any direction.\n" +
                $"But unlike the exchanges of earth it's nearly silent in the exchange. The Centarians are famously capatalistic and the \nMacawalani exchange is almost" +
                $"like a temple. But it takes you hardly any time at all to find the entries of your\nclassic moneymakers..." +
                $"  \nEarth: \n\tNo Balance Shoes: {PS.EarthNoBalanceShoes} \n\tSpace Gold: {PS.EarthSpaceGold} \n\tGalactic TVs: {PS.EarhtGalacticTVs}" +
                $"\n \nAlpha Centari:\n\t No Balance Shoe: {PS.AlphaCentariNoBalanceShoes}\n\tSpace Gold: {PS.AlphaCentariGold}\n\tGalactic " +
                $"TVs: {PS.AlphaCentariGalacticTVs}\n \nM63:\n\t No Balance Shoes: {PS.M63NoBalanceShoes}" +
                $"\n\tSpace Gold: {PS.M63SpaceGold}\n\tGalactic TVs: {PS.M63GalacticTVs} \n" +
                $"Press enter to return to the Macawalani streets...");
            Console.ReadLine();
        }
        public void AlphaCentariPort()
        {
            double distEarth = (Math.Sqrt(Math.Pow(PS.EarthXPosition - PS.AlphaCentariXPosition, 2) + Math.Pow(PS.EarthYPosition - PS.AlphaCentariYPosition, 2)));
            
            double distM63 = (Math.Sqrt(Math.Pow(PS.AlphaCentariXPosition - PS.M63XPosition, 2) + Math.Pow(PS.AlphaCentariYPosition - PS.M63YPosition, 2)));
            double playerWarpSpeed = (Math.Pow(PS.ShipSpeed, 10 / 3) + Math.Pow(10 - PS.ShipSpeed, -11 / 3));
            Console.Clear();
            Console.WriteLine($"" +
                $"Wind swirls around you as a ships takes off to some new and exciting destination.\n" +
                $"Ports like this always make you miss home a little but the dream of the \n" +
                $"Dukedom of Mercury and the thoughts of your upcoming(hopefully)\n" +
                $"nuptuals drive you forward." +
                $"\nWhere would you like to go? \n\t1 Earth: {distEarth} Light years away which will take {distEarth / playerWarpSpeed} years" +
                $"\n\t2 M63: {distM63} Light years away which will take {distM63 / playerWarpSpeed} years\n\t3 Return to Macawalani, the Capital of Centari IV");
            int response = Convert.ToInt32(Console.ReadLine());
            bool travelEarth = response == 1;
            bool travelM63 = response == 2;
            bool Return = response == 3;
            if (travelEarth)
            {
                PS.MyTravelTime += (distEarth / playerWarpSpeed);
                if (PS.MyTravelTime > 40.0)
                {
                    GO.Retire(PS);
                }
                UM.Travel(PS);
                Console.WriteLine($"The journey takes you {distEarth / playerWarpSpeed} years you have been traveling for {PS.MyTravelTime} years now.\n" +
                    $"You arrive on Earth");
                Console.ReadLine();
                EarthPage();
            }
            if (travelM63)
            {
                PS.MyTravelTime += (distM63 / playerWarpSpeed);
                if (PS.MyTravelTime > 40.0)
                {
                    GO.Retire(PS);
                }
                UM.Travel(PS);
                Console.WriteLine($"The journey takes you {distM63 / playerWarpSpeed} years, you have been traveling for {PS.MyTravelTime} years total.\n" +
                    $"You arrive on M63");
                Console.ReadLine();
                M63Page();
            }
            if (Return)
            {
                AlphaCentariPage();
            }
        }
        #endregion

        #region M63

        public void M63Page()
        {
            Console.Clear();
            UM.InventoryDisplay(PS);
            Console.WriteLine("" +
                "Welcome to the star system M63, named for Messier star cluster circling a black hole.\n" +
                "As you walk into the streets the first thing that you notice is that everything is\n" +
                "clean and bright white. None of the architecture has a scrap of color anywhere, the\n" +
                "only exception is the flat holographic ads that are projected up on some of the walls\n" +
                "but even thier colors are muted. The Messinese that you see all wear the same color white\n" +
                "of the buildings but in stark contrast their skin is as black as the hole their star orbits" +
                "\n\nWhere would you like to go? \n" +
                "1. Ship Yard \n" +
                "2. Galactic Bank \n" +
                "3. Buy, Sell, Trade \n" +
                "4. Galactic Market\n" +
                "5. Departure Port\n" +
                "9. Quit the Game");
            try
            {
                SelectM63Options();
            }

            //display if invalid input
            catch (Exception)
            {
                Console.WriteLine("Invalid input, try again! Press any key to continue.");
                Console.ReadLine();

                //recycle to Welcome to m63 after invalid entry  
                M63Page();
            }
        }
        public void SelectM63Options()
        {
            int response = Convert.ToInt32(Console.ReadLine());

            //evaluate user input by using boolean expressions
            bool shipYard = response == 1;
            bool galacticBank = response == 2;
            bool shop = response == 3;
            bool market = response == 4;
            bool port = response == 5;
            bool quit = response == 9;


            //point of method access after valid user selection
            if (shipYard)
            M63ShipYard();

            if (galacticBank)
                M63Bank();

            if (shop)
               M63Shop();

            if (market)
              M63Market();

            if (port)
                M63Port();

            if (quit)
                GO.EndScreen(PS);

            else
            {
                //loops back to the beginning of earth page
                Console.WriteLine("invalid entry");
                M63Page();
            }
        }
        public void M63Bank()
        {
            Console.Clear();
            UM.InventoryDisplay(PS);
            Console.WriteLine($"" +
                $"Tall white columns frame the door to the Messinese Galactic Bank branch.\n" +
                $"Men and women dressed in all white are coming and going from the inside.\n" +
                $"The shining white walls of the bank hum with the electricity from the sheer\n" +
                $"number of data transfers taking place inside. The interior is more of the \n" +
                $"same, white walls and white clothes contrasting sharply with the coal black\n" +
                $"skin of the Messinese" +
                $" \nYou have {PS.MyCurrentCredit} Galactic Credits in your Galactic Bank Account. The title of Duke of Mercury costs 1,000,000 GC.\n" +
                $"You need {(1000000 - PS.MyCurrentCredit)} more credits before you can win the king of Venus' approval.\nPress any key to continue...");
            Console.ReadLine();
            GO.Win(PS);
            M63Page();
        }
        public void M63Shop()
        {
            Console.Clear();
            Console.WriteLine("You've arrived at the shop on M63. Niko, the owner welcomes you to look around at all the goods." +
                "/nWe've got the highest quality TV's in the universe!");
            Console.ReadLine();
            UM.InventoryDisplay(PS);
            Console.WriteLine("What would you like to do?\n 1 Buy Cargo\n 2 Sell Cargo\n 3 Return to the streets of M63");
            int response = Convert.ToInt32(Console.ReadLine());
            bool purchase = response == 1;
            bool offload = response == 2;
            bool Return = response == 3;
            if (purchase)
                M63Buy();
            if (offload)
                M63Sell();
            if (Return)
                M63Page();
        }
        public void M63Buy()
        {
            Console.Clear();
            UM.InventoryDisplay(PS);
            Console.WriteLine($"You have {PS.MyCurrentCredit} Galactic Credits, what good would you like to buy?\n " +
                $"1 NoBalanceShoes {PS.M63NoBalanceShoes} GC per Unit\n 2 Space Gold {PS.M63SpaceGold} GC per Unit\n 3 Galactic TV {PS.M63GalacticTVs} GC per Unit \n 4 " +
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
                if ((quantity * PS.M63NoBalanceShoes) > PS.MyCurrentCredit)
                {
                    Console.WriteLine("You can't afford that! \n" +
                        "Press any key to return to the Shop..");
                    Console.ReadLine();
                    M63Buy();
                }
                if ((quantity + PS.GalacticTVs + PS.SpaceGold + PS.NoBalanaceShoes) > PS.ShipCapacity)
                {
                    Console.WriteLine($"You don't have room for that! You currently" +
                        $" have {(PS.ShipCapacity - (PS.SpaceGold + PS.GalacticTVs + PS.NoBalanaceShoes))} space left in your cargo hold\n" +
                        $"Press any key to continue...");
                    Console.ReadLine();
                    M63Buy();
                }
                PS.MyCurrentCredit -= (quantity * PS.M63NoBalanceShoes);

                PS.NoBalanaceShoes += quantity;

                Console.WriteLine($"you bought {quantity} NoBalance Shoes for {PS.M63NoBalanceShoes * quantity} GC, your new balance is {PS.MyCurrentCredit} GC \n " +
                    $"You now have {PS.NoBalanaceShoes} pairs of No Balanace Shoes in your ship.\n Press any key to continue..");

                Console.ReadLine();
                M63Buy();
            }
            //Buy Gold
            if (Gold)
            {
                Console.WriteLine("How many?");
                int quantity = Convert.ToInt32(Console.ReadLine());
                if ((quantity * PS.M63SpaceGold) > PS.MyCurrentCredit)
                {
                    Console.WriteLine("You can't afford that! \n" +
                        "Press any key to return to the Shop..");
                    Console.ReadLine();
                    M63Buy();
                }
                if ((quantity + PS.GalacticTVs + PS.SpaceGold + PS.NoBalanaceShoes) > PS.ShipCapacity)
                {
                    Console.WriteLine($"You don't have room for that! You currently" +
                        $" have {(PS.ShipCapacity - (PS.SpaceGold + PS.GalacticTVs + PS.NoBalanaceShoes))} space left in your cargo hold\n" +
                        $"Press any key to continue...");
                    Console.ReadLine();
                    M63Buy();
                }
                PS.MyCurrentCredit -= (quantity * PS.M63SpaceGold);

                PS.SpaceGold += quantity;

                Console.WriteLine($"you bought {quantity} Bars of Space Gold, your new balance is {PS.MyCurrentCredit} \n " +
                    $" You have {PS.SpaceGold} bars of Space Gold in your spaceship.\n Press any key to continue..");
                Console.ReadLine();
                M63Buy();
            }

            if (TV)
            {
                Console.WriteLine("How many?");
                int quantity = Convert.ToInt32(Console.ReadLine());
                if ((quantity * PS.M63GalacticTVs) > PS.MyCurrentCredit)
                {
                    Console.WriteLine("You can't afford that! \n" +
                        "Press any key to return to the Shop..");
                    Console.ReadLine();
                    M63Buy();
                }
                if ((quantity + PS.GalacticTVs + PS.SpaceGold + PS.NoBalanaceShoes) > PS.ShipCapacity)
                {
                    Console.WriteLine($"You don't have room for that! You currently" +
                        $" have {(PS.ShipCapacity - (PS.SpaceGold + PS.GalacticTVs + PS.NoBalanaceShoes))} space left in your cargo hold\n" +
                        $"Press any key to continue...");
                    Console.ReadLine();
                    M63Buy();
                }
                PS.MyCurrentCredit -= (quantity * PS.M63GalacticTVs);

                PS.GalacticTVs += quantity;



                Console.WriteLine($"you bought {quantity} Galactic TV(s), your new balance is {PS.MyCurrentCredit} \n " +
                    $"You now have {PS.GalacticTVs} Galactic Tvs in your ship. \n Press any key to continue..");
                Console.ReadLine();
                M63Buy();
            }

            if (Return)
            {
                M63Shop();
            }
        }
        public void M63Sell()
        {
            Console.Clear();
            UM.InventoryDisplay(PS);
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
                    M63Sell();
                }
                PS.NoBalanaceShoes -= quantity;
                PS.MyCurrentCredit += (quantity * PS.M63NoBalanceShoes);
                Console.WriteLine($"Thank you for the No Balance Shoes, you can jump so high when gravity doesn't affect your feet!\nYou sold {quantity} No Balance Shoes for {(quantity * PS.M63NoBalanceShoes)} Galactic Credits.\n" +
                    $"You now have {PS.MyCurrentCredit} Galactic Credits and {PS.NoBalanaceShoes} No Balanace Shoes.\n Press any key to continue...");
                Console.ReadLine();
                M63Sell();
            }
            if (Return)
            {
                M63Shop();
            }
            if (Gold)
            {
                Console.WriteLine("How much Space Gold do you want sell?");
                int quantity = Convert.ToInt32(Console.ReadLine());
                if (quantity > PS.SpaceGold)
                {
                    Console.WriteLine($"You don't have that much Space Gold!\nYou only have {PS.SpaceGold} bars of Space Gold. \nPress any key to return to the selling menu...");
                    Console.ReadLine();
                    M63Sell();
                }
                PS.SpaceGold -= quantity;
                PS.MyCurrentCredit += (quantity * PS.M63SpaceGold);
                Console.WriteLine($"Thanks for the Space Gold, Space Gold is so much more shiny than boring old regular gold!\nYou sold {quantity} bars of Space Gold for {(quantity * PS.M63SpaceGold)} Galactic Credits.\n" +
                    $"You now have {PS.MyCurrentCredit} Galactic Credits and {PS.SpaceGold} bars of Space Gold left.\n Press any key to continue...");
                Console.ReadLine();
                M63Sell();
            }
            if (TV)
            {
                Console.WriteLine("How many TVs do you want to sell?");
                int quantity = Convert.ToInt32(Console.ReadLine());
                if (quantity > PS.GalacticTVs)
                {
                    Console.WriteLine($"You don't have that many Galactic TVs, you only have {PS.GalacticTVs}.\n Press any key to return to the selling menu...");
                    Console.ReadLine();
                    M63Sell();
                }
                PS.GalacticTVs -= quantity;
                PS.MyCurrentCredit += (quantity * PS.M63GalacticTVs);
                Console.WriteLine($"Thank you for the Galactic TVs I can't believe how thin they are!\nYou sold {quantity} Galactic TVs for {(quantity * PS.M63GalacticTVs)} Galactic Credits.\n" +
                    $"You now have {PS.MyCurrentCredit} Galactic Credits and {PS.GalacticTVs} Galactic TVs left.\n Press any key to continue...");
                Console.ReadLine();
                M63Sell();
            }
        }
        public void M63Port()
        {
            double distAlphaCentari = (Math.Sqrt(Math.Pow(PS.M63XPosition - PS.AlphaCentariXPosition, 2) + Math.Pow(PS.M63YPosition - PS.AlphaCentariYPosition, 2)));
            double distEarth = (Math.Sqrt(Math.Pow(PS.EarthXPosition - PS.M63XPosition, 2) + Math.Pow(PS.EarthYPosition - PS.M63YPosition, 2)));
            double playerWarpSpeed = (Math.Pow(PS.ShipSpeed, 10 / 3) + Math.Pow(10 - PS.ShipSpeed, -11 / 3));
            Console.Clear();
            UM.InventoryDisplay(PS);
            Console.WriteLine($"Where would you like to go? \n\t1 Alpha Centari: {distAlphaCentari} Light years away which will take {distAlphaCentari / playerWarpSpeed} years" +
                $"\n\t2 Earth: {distEarth} Light years away which will take {distEarth / playerWarpSpeed} years\n\t3 Return to earth");
            int response = Convert.ToInt32(Console.ReadLine());
            bool travelAlpha = response == 1;
            bool travelEarth = response == 2;
            bool Return = response == 3;
            if (travelAlpha)
            {
                PS.MyTravelTime += (distAlphaCentari / playerWarpSpeed);
                if ((distAlphaCentari / playerWarpSpeed) + PS.MyTravelTime > 40.0)
                {
                    GO.Retire(PS);
                }
                UM.Travel(PS);
                Console.WriteLine($"The journey takes you {distAlphaCentari / playerWarpSpeed} you have been traveling for {PS.MyTravelTime} years now.\n" +
                    $"You arrive on ALpha Centari");
                Console.ReadLine();
                AlphaCentariPage();
            }
            if (travelEarth)
            {
                PS.MyTravelTime += (distEarth / playerWarpSpeed);
                if (PS.MyTravelTime > 40.0)
                {
                    GO.Retire(PS);
                }
                UM.Travel(PS);
                Console.WriteLine($"The jouney take you {distEarth / playerWarpSpeed} years, you have been traveling for {PS.MyTravelTime} years total.\n" +
                    $"You arrive on Earth");
                Console.ReadLine();
                EarthPage();
            }
            if (Return)
            {
                M63Page();
            }
        }
        public void M63ShipYard()
        {
            Console.Clear();
            UM.InventoryDisplay(PS);
            // write flavor text about shipyard
            Console.WriteLine("You walk into the Shipyard, the sound of welders and hammers fills the air. Ship salesman are weaving in and out of" +
                "the ships pushing their latest ship on travelers all the while dodging the laborers.\nWould you like to:\n 1 Check your ship stats\n 2 Buy a new Ship\n 3 Return to planetary hub");
            int response = Convert.ToInt32(Console.ReadLine());
            bool ShipStats = response == 1;
            bool BuyShip = response == 2;
            bool Return = response == 3;
            if (ShipStats)
                M63ShipCheck();
            if (BuyShip)
                M63PurchaseShip();
            if (Return)
                M63Page();
        }
        public void M63PurchaseShip()
        {
            Console.Clear();
            UM.InventoryDisplay(PS);
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
                    PS.ShipSpeed = PS.InterstellarConnexSpeed;
                    PS.ShipCapacity = PS.InterstellarConnexCapacity;
                    PS.ShipName = myShipUpgrade;
                    //subtract credit after purchase
                    PS.MyCurrentCredit = PS.MyCurrentCredit - 600;
                    //display ship bought and remaining credit
                    Console.WriteLine($"Congratulations on your new ship purchase! " +
                        $"You now own the {PS.ShipName} and have {PS.MyCurrentCredit} remaining");
                    Console.ReadLine();
                    M63ShipYard();
                }
                //stop the purchase
                else
                {
                    M63ShipYard();
                }
            }
            //stop purchase. not enough credits
            else
            {
                Console.WriteLine("You do not have enough credits to complete this purchase!");
                Console.ReadLine();
                M63ShipYard();

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
                    PS.ShipName = myShipUpgrade;
                    PS.ShipCapacity = PS.StarWagonCapacity;
                    PS.ShipSpeed = PS.StarWagonSpeed;
                    PS.MyCurrentCredit = PS.MyCurrentCredit - 1200;
                    //display ship purchased and remaining credits
                    Console.WriteLine($"Congratulations on your new ship purchase! You now own the {PS.ShipName} " +
                        $"\nand have {PS.MyCurrentCredit} credits remaining");
                    Console.ReadLine();
                    M63ShipYard();
                }
                //stop purchase
                else
                {
                    M63ShipYard();
                }
            }
            //stop purchase
            else
            {
                Console.WriteLine("You do not have enough credits to complete this purchase!");
                Console.ReadLine();
                M63ShipYard();
            }
        }
        public void M63ShipCheck()
        {
            Console.Clear();
            UM.InventoryDisplay(PS);
            Console.WriteLine($"You arrive at your personal hanger, you ship, a {PS.ShipName} the SS {PS.MyName}, stands before you gleaming in the artificail lights of the hanger\n" +
                $"A {PS.ShipName} like this has {PS.ShipCapacity} slots in its cargo hold and a top speed of Warp Factor {PS.ShipSpeed}\n" +
                $"Inside the hold you have {PS.NoBalanaceShoes} boxes of No Balance Shoes, {PS.SpaceGold} bars of Space Gold & {PS.GalacticTVs} boxes of Galactic TVs\n" +
                $"Press any key to continue...");
            Console.ReadLine();
            M63ShipYard();
        }
        public void M63Market()
        {
            Console.WriteLine($"Welcome to the Epic Market on M63, where your opportunity for wealth is boundless and the products are of the most elegant varieties. " +
                $"  \nEarth: \n\tNo Balance Shoes: {PS.EarthNoBalanceShoes} \n\tSpace Gold: {PS.EarthSpaceGold} \n\tGalactic TVs: {PS.EarhtGalacticTVs}" +
                $"\n \nAlpha Centari:\n\t No Balance Shoe: {PS.AlphaCentariNoBalanceShoes}\n\tSpace Gold: {PS.AlphaCentariGold}\n\tGalactic " +
                $"TVs: {PS.AlphaCentariGalacticTVs}\n \nM63:\n\t No Balance Shoes: {PS.M63NoBalanceShoes}" +
                $"\n\tSpace Gold: {PS.M63SpaceGold}\n\tGalactic TVs: {PS.M63GalacticTVs} \n" +
                $"Press enter to return to the Messien streets...");
            Console.ReadLine();
        }
        #endregion

        #region Asgard

        public void AsgardPage()
        {
            Console.Clear();
            UM.InventoryDisplay(PS);
            Console.WriteLine($"" +
            $"Golden spires and beautiful vistas greet you as soon as you land. The rainbow\n" +
            $"bifrost is visable in the distance. It's as beautiful as you always imagined it\n" +
            $"would be. It's just like the legends. Waterfalls and spill off cliffs that lead to\n" +
            $"nowhere. The grand Mead-hall can be barely seen past some clouds and the distant \n" +
            $"sound of drunken revelry carries across the open space.\n" +
            $"Where would you like to go?\n");
            AsgardSelector();
        }

        //Selector for the Asgard planet menus
        public void AsgardSelector()
        {
            int response = UM.MainPageOptions();

            if (response == 1)
                AsgardShipyard();

            if (response == 2)
                AsgardBank();

            //if (response == 3)
                //AsgardShop();

            //if (response == 4)
                //AsgardMarket();

            //if (response == 5)
                //AsgardPort();

            if (response == 9)
                GO.EndScreen(PS);
        }

        public void AsgardShipyard()
        {
            Console.Clear();
            UM.InventoryDisplay(PS);
            Console.WriteLine($"" +
            $"You walk into the shipyard of Asgard and are greeted by a man who looks like he" +
            $"stepped right out of an old Norse myth. He smiles through his huge beard, 'Greetings" +
            $"{PS.MyName} welcome to my shipyard I am Sven son of Baldur God of ship sales and" +
            $"maintenance. I see you have a {PS.ShipName} class ship, those are good but I think you" +
            $"could do better, well anyway what can I do for you?");
            AsgardShipYardSelector();
        }

        public void AsgardShipYardSelector()
        {
            int response = UM.ShipYardMenu();

            if (response == 1)
                ShipCheck();

            if (response == 2)
                PurchaseShip();

            if (response == 3)
                AsgardPage();

            else
                AsgardShipyard();
        }

        public void AsgardBank()
        {
            Console.Clear();
            UM.InventoryDisplay(PS);
            Console.WriteLine($"" +
            $"You walk into the bank which is easily one of the most expensive buildings you've ever" +
            $"been in. It seems everything in Asgard is either a deadly steel blade or made entirely" +
            $"from space gold. The banker smiles at you, 'Welcome to the Asgardian branch of the Galactic" +
            $"Bank {PS.MyName} I am the Thrador! Son of Spandar, God of Banking and money exchange!' He" +
            $"quite boisterous for a banker. He taps away at some glowing runes carved into the gold top" +
            $"of the counter.");
            UM.BankDisplay(PS);
            AsgardPage();
        }
        #endregion







        
    }
}
