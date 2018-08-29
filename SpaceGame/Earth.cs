using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Earth
    {
        Shop Shop = new Shop();
        ShipYard SY = new ShipYard();
        GameOver GO = new GameOver();
        PersonalStatus PS = new PersonalStatus();
        UtilityMethods UM = new UtilityMethods();
        Ship ship = new Ship();
        PlanetInfo PI = new PlanetInfo();
        Fuel fuel = new Fuel();
        Asgard Asgard = new Asgard();

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
                $"\t\tYou've got a {ship.ShipName} class ship and {PS.MyCurrentCredit} Galactic Credits, \n" +
                $"\t\tso get out there and get to trading, {PS.MyName}!\n\n" +
                $"\n\n\n\n\n\n\n\n\t\t\tPress enter to continue past this or any screen in this game.");

            Console.ReadLine();
        }

        public void LandingPagePicker()
        {
            if (PS.MyCurrentLocation == "Earth")
                EarthPage();
            if (PS.MyCurrentLocation == "AlphaCentari")
                AlphaCentariPage();
            if (PS.MyCurrentLocation == "M63")
                M63Page();
            if (PS.MyCurrentLocation == "Asgard")
                Asgard.AsgardPage(UM, PS, ship, fuel, GO, SY, PI, Shop);
        }

        #region Earth Page

        public void EarthPage()


        {
            //Define Location

            PS.MyCurrentLocation = "Earth";

            //clear up window
            Console.Clear();

            //display menu on earth upon arrival
            UM.InventoryDisplay(PS, ship, fuel);
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
                EarthShop();

            if (response == 4) 
                 Market();

            if (response == 5) 
               EarthPort();

            if (response == 9)
                GO.EndScreen(PS, ship);

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
            UM.InventoryDisplay(PS, ship, fuel);
            UM.BankDisplay(PS);
            return;
        }
        public void ShipYard()
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
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
                SY.ShipCheck(PS, ship, UM, fuel);
            if (response == 2)
                SY.PurchaseShip(PS, ship, UM, fuel);
            if (response == 3)
                return;
        }
       
        public void EarthShop()
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine("\n\n" +
                "\t'Welcome to my little shop!' The man behind the counter says. His Earth flag bandana, a \n" +
                "\tmodified version of Old Glory with the stars replaced with a picture of the planet earth, \n" +
                "\tis made from light enhanced fabric that shines even in the dark. He smiles at you his dirty \n" +
                "\tblond scruff offsetting his brigthly whitened teeth. 'I've got all the Space Gold and TVs a \n" +
                "\ttrader like you could ever want, and have you seen these new zero grav shoes? They are all \n" +
                "\tthe rage out on the larger planets.\n\n");
            int response = UM.ShopSelector();
            if (response == 1)
                Buy();
            if (response == 2)
                Sell();
            if (response == 3)
                fuel.BuyFuel(PS, ship);
            if (response == 4)
                return;
        }
        public void Buy()
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"\n\n" +
                $"\tYou have {PS.MyCurrentCredit} Galactic Credits, what good would you like to buy?\n" +
                $"\t 1 NoBalanceShoes 80 GC per Unit\n" +
                $"\t 2 Space Gold 100 GC per Unit\n" +
                $"\t 3 Galactic TV 120 GC per Unit \n" +
                $"\t 4 Return to Shop");
            int response = Convert.ToInt32(Console.ReadLine());
            //Buy Shoes
            if (response == 1)
            {
                Shop.BuyShoes(PI.EarthNoBalanceShoes, PS, UM, ship, fuel);
            }
            //Buy Gold
            if (response == 2)
            {
                Shop.BuyGold(PI.EarthSpaceGold, PS, UM, ship, fuel);
            }

            if (response ==3)
            {
                Shop.BuyTV(PI.EarhtGalacticTVs, PS, UM, ship, fuel);
            }

            if (response == 4)
            {
                return;
            }
        }
        public void Sell()
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
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
             if (response == 1)
            {
                Console.WriteLine("How many No Balance Shoes would you like to offload?");
                int quantity = Convert.ToInt32(Console.ReadLine());
                if (quantity > PS.NoBalanaceShoes)
                {
                    Console.WriteLine($"You don't have that many shoes!\n You only have {PS.NoBalanaceShoes} pairs of No Balance Shoes. \nPress any key to return to the selling menu...");
                    Console.ReadLine();
                    return;
                }
                PS.NoBalanaceShoes -= quantity;
                PS.MyCurrentCredit += (quantity * PI.EarthNoBalanceShoes);
                Console.WriteLine($"" +
                    $"Thank you for the No Balance Shoes, you can jump so high when gravity doesn't affect your feet!\n" +
                    $"You sold {quantity} No Balance Shoes for {(quantity * PI.EarthNoBalanceShoes)} Galactic Credits.\n" +
                    $"You now have {PS.MyCurrentCredit} Galactic Credits and {PS.NoBalanaceShoes} No Balanace Shoes.\n" +
                    $"Press any key to continue...");
                Console.ReadLine();
                return;
            }
            
            if (response == 2)
            {
                Console.WriteLine("How much Space Gold do you want sell?");
                int quantity = Convert.ToInt32(Console.ReadLine());
                if (quantity > PS.SpaceGold)
                {
                    Console.WriteLine($"You don't have that much Space Gold!\n" +
                        $"You only have {PS.SpaceGold} bars of Space Gold. \n" +
                        $"Press any key to return to the selling menu...");
                    Console.ReadLine();
                    return;
                }
                PS.SpaceGold -= quantity;
                PS.MyCurrentCredit += (quantity * PI.EarthSpaceGold);
                Console.WriteLine($"Thanks for the Space Gold, Space Gold is so much more shiny than boring old regular gold!\n" +
                    $"You sold {quantity} bars of Space Gold for {(quantity * PI.EarthSpaceGold)} Galactic Credits.\n" +
                    $"You now have {PS.MyCurrentCredit} Galactic Credits and {PS.SpaceGold} bars of Space Gold left.\n" +
                    $"Press any key to continue...");
                Console.ReadLine();
                return;
            }
            if (response == 3)
            {
                Console.WriteLine("How many TVs do you want to sell?");
                int quantity = Convert.ToInt32(Console.ReadLine());
                if (quantity > PS.GalacticTVs)
                {
                    Console.WriteLine($"You don't have that many Galactic TVs, you only have {PS.GalacticTVs}.\n" +
                        $"Press any key to return to the selling menu...");
                    Console.ReadLine();
                    return;
                }
                PS.GalacticTVs -= quantity;
                PS.MyCurrentCredit += (quantity * PI.EarhtGalacticTVs);
                Console.WriteLine($"Thank you for the Galactic TVs I can't believe how thin they are!\n" +
                    $"You sold {quantity} Galactic TVs for {(quantity * PI.EarhtGalacticTVs)} Galactic Credits.\n" +
                    $"You now have {PS.MyCurrentCredit} Galactic Credits and {PS.GalacticTVs} Galactic TVs left.\n" +
                    $"Press any key to continue...");
                Console.ReadLine();
                return;
            }
            if (response == 4)
            {
                return;
            }

        }
        public void Market()
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine("\n\n" +
                "\tThe Galactic Stock exchange glitters and flashes, and down but you worry about the three perenial commodities.\n" +
                "\tNo Balance Shoes, the zero gravity shoes that changed the way the galaxy moves. \n" +
                "\tSpace Gold, it's like the gold everyone knows and loves but shinier and better in every way.\n" +
                "\tAnd Galactic TVs, TVs so thin that you can't even see them unless you are standing in front of them.\n" +
                $"\tThe display flashes their market prices. \n\n" +
                $"\tEarth: \n" +
                $"\t\tNo Balance Shoes: {PI.EarthNoBalanceShoes} \n" +
                $"\t\tSpace Gold: {PI.EarthSpaceGold} \n" +
                $"\t\tGalactic TVs: {PI.EarhtGalacticTVs}\n\n" +
                $"\tAlpha Centari:\n" +
                $"\t\tNo Balance Shoe: {PI.AlphaCentariNoBalanceShoes}\n" +
                $"\t\tSpace Gold: {PI.AlphaCentariGold}\n" +
                $"\t\tGalactic TVs: {PI.AlphaCentariGalacticTVs}\n\n" +
                $"\tM63:\n" +
                $"\t\tNo Balance Shoes: {PI.M63NoBalanceShoes}\n" +
                $"\t\tSpace Gold: {PI.M63SpaceGold}\n" +
                $"\t\tGalactic TVs: {PI.M63GalacticTVs} ");
            Console.ReadLine();
        }
        public void EarthPort()
        {
            double playerWarpSpeed = (Math.Pow(ship.ShipSpeed, 10 / 3) + Math.Pow(10 - ship.ShipSpeed, -11 / 3));
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"\n\n" +
                $"\tWhere would you like to go? \n" +
                $"\t\t1 Alpha Centari: {UM.PlanetDistance(PI.EarthXPosition, PI.AlphaCentariXPosition, PI.EarthYPosition, PI.AlphaCentariYPosition)} Light years away which will take {UM.PlanetDistance(PI.EarthXPosition, PI.AlphaCentariXPosition, PI.EarthYPosition, PI.AlphaCentariYPosition) / playerWarpSpeed} years\n" +
                $"\t\t2 M63: {UM.PlanetDistance(PI.EarthXPosition, PI.M63XPosition, PI.EarthYPosition, PI.M63YPosition)} Light years away which will take {UM.PlanetDistance(PI.EarthXPosition, PI.M63XPosition, PI.EarthYPosition, PI.M63YPosition) / playerWarpSpeed} years\n" +
                $"\t\t3 Asgard: {UM.PlanetDistance(PI.EarthXPosition, PI.AsgardXPosition, PI.EarthYPosition, PI.AsgardYPosition)} Light years away which will take {UM.PlanetDistance(PI.EarthXPosition, PI.AsgardXPosition, PI.EarthYPosition, PI.AsgardYPosition) / playerWarpSpeed} years\n" +
                $"\t\t4 Return to earth");
            int response = Convert.ToInt32(Console.ReadLine());
            if (response == 1)
            {
                UM.PlanetTravel(PI.EarthXPosition, PI.AlphaCentariXPosition, PI.EarthYPosition, PI.AlphaCentariYPosition, ship, PS, fuel);
                UM.Travel(PS);
                AlphaCentariPage();
            }
            if (response == 2)
            {
                UM.PlanetTravel(PI.EarthXPosition, PI.M63XPosition, PI.EarthYPosition, PI.M63YPosition, ship, PS, fuel);
                UM.Travel(PS);
                M63Page();
            }
            if (response == 3)
            {
                UM.PlanetTravel(PI.EarthXPosition, PI.AsgardXPosition, PI.EarthYPosition, PI.AsgardYPosition, ship, PS, fuel);
                UM.Travel(PS);
                Asgard.AsgardPage(UM, PS, ship, fuel, GO, SY, PI, Shop);
            }
            if (response == 4)
            {
                return;
            }
        }

        #endregion

        #region AlphaCentari

        public void AlphaCentariPage()
        {
            PS.MyCurrentLocation = "AlphaCentari";
            Console.Clear();
            UM.InventoryDisplay(PS,ship, fuel);
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
                GO.EndScreen(PS, ship);

            else
            {
                Console.WriteLine("invalid entry");
                AlphaCentariPage();
            }
        }
        public void AlphaYard()
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            // write flavor text about shipyard
            Console.WriteLine("\n\n" +
                "\tYou walk into the Shipyard, the sound of welders and hammers fills the air. Ship\n" +
                "\tsalesman are weaving in and out of the ships pushing their latest ship on travelers\n" +
                "\tall the while dodging the laborers.\n" +
                "\t\tWould you like to:\n" +
                "\t\t 1 Check your ship stats\n" +
                "\t\t 2 Buy a new Ship\n" +
                "\t\t 3 Return to planetary hub");
            int response = Convert.ToInt32(Console.ReadLine());
            if (response == 1)
                SY.ShipCheck(PS, ship, UM, fuel);
            if (response == 2)
                SY.PurchaseShip(PS, ship, UM, fuel);
            if (response == 3)
                LandingPagePicker();
        }

        public void AlphaShop()
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine("\n\n" +
                "\t\tYou arrive at the shop on Alpha Centari. The owner, Brahman welcomes you. 'What's up, \n" +
                "\t\tmane you know that we have the highest quality gold in the universe!'");
            Console.ReadLine();
            Console.WriteLine("\nWhat would you like to do?\n 1 Buy Cargo\n 2 Sell Cargo\n 3 Buy Rocket fuel\n 4 Return to Macawalani streets");
            int response = Convert.ToInt32(Console.ReadLine());
            if (response == 1)
                AlphaBuy();
            if (response == 2)
                AlphaSell();
            if (response == 3)
                fuel.BuyFuel(PS, ship);
            if (response == 4)
                AlphaCentariPage();
        }
        public void AlphaBank()
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"Welcome to the Galactic Bank of Centari Four!\nBehind the counter is an tall old bird, his specticles are low on his beak and attached to his head by a gold chain.\n" +
                $"The high ceilings make room for doors on many levels but with no visable landing, of course ground based humans like you have to come in through the 'walkers' door.\n");
            UM.BankDisplay(PS);
            Console.ReadLine();
            AlphaCentariPage();
        }
        public void AlphaBuy()
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"You have {PS.MyCurrentCredit} Galactic Credits, what good would you like to buy?\n " +
                $"1 NoBalanceShoes {PI.AlphaCentariNoBalanceShoes} GC per Unit\n 2 Space Gold {PI.AlphaCentariGold} GC per Unit\n 3 Galactic TV {PI.AlphaCentariGalacticTVs} GC per Unit \n 4 " +
                $"Return to the Shop");
            int response = Convert.ToInt32(Console.ReadLine());
            //Buy Shoes
            if (response == 1)
            {
                Shop.BuyShoes(PI.AlphaCentariNoBalanceShoes, PS, UM, ship, fuel);
            }
            //Buy Gold
            if (response == 2)
            {
                Shop.BuyGold(PI.AlphaCentariGold, PS, UM, ship, fuel);
            }

            if (response == 3)
            {
                Shop.BuyTV(PI.AlphaCentariGalacticTVs, PS, UM, ship, fuel);
            }

            if (response == 4)
            {
                AlphaShop();
            }
        }
        public void AlphaSell()
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
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
                PS.MyCurrentCredit += (quantity * PI.AlphaCentariNoBalanceShoes);
                Console.WriteLine($"Thank you for the No Balance Shoes, you can jump so high when gravity doesn't affect your feet!\nYou sold {quantity} No Balance Shoes for {(quantity * PI.AlphaCentariNoBalanceShoes)} Galactic Credits.\n" +
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
                PS.MyCurrentCredit += (quantity * PI.AlphaCentariGold);
                Console.WriteLine($"Thanks for the Space Gold, Space Gold is so much more shiny than boring old regular gold!\nYou sold {quantity} bars of Space Gold for {(quantity * PI.AlphaCentariGold)} Galactic Credits.\n" +
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
                PS.MyCurrentCredit += (quantity * PI.AlphaCentariGalacticTVs);
                Console.WriteLine($"Thank you for the Galactic TVs I can't believe how thin they are!\nYou sold {quantity} Galactic TVs for {(quantity * PI.AlphaCentariGalacticTVs)} Galactic Credits.\n" +
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
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"The city of Macawalani on Centari IV has the largest stock exchange for a light year in any direction.\n" +
                $"But unlike the exchanges of earth it's nearly silent in the exchange. The Centarians are famously capatalistic and the \nMacawalani exchange is almost" +
                $"like a temple. But it takes you hardly any time at all to find the entries of your\nclassic moneymakers..." +
                $"  \nEarth: \n\tNo Balance Shoes: {PI.EarthNoBalanceShoes} \n\tSpace Gold: {PI.EarthSpaceGold} \n\tGalactic TVs: {PI.EarhtGalacticTVs}" +
                $"\n \nAlpha Centari:\n\t No Balance Shoe: {PI.AlphaCentariNoBalanceShoes}\n\tSpace Gold: {PI.AlphaCentariGold}\n\tGalactic " +
                $"TVs: {PI.AlphaCentariGalacticTVs}\n \nM63:\n\t No Balance Shoes: {PI.M63NoBalanceShoes}" +
                $"\n\tSpace Gold: {PI.M63SpaceGold}\n\tGalactic TVs: {PI.M63GalacticTVs} \n" +
                $"Press enter to return to the Macawalani streets...");
            Console.ReadLine();
        }
        public void AlphaCentariPort()
        {
            
            double playerWarpSpeed = (Math.Pow(ship.ShipSpeed, 10 / 3) + Math.Pow(10 - ship.ShipSpeed, -11 / 3));
            Console.Clear();
            Console.WriteLine($"" +
                $"Wind swirls around you as a ships takes off to some new and exciting destination.\n" +
                $"Ports like this always make you miss home a little but the dream of the \n" +
                $"Dukedom of Mercury and the thoughts of your upcoming(hopefully)\n" +
                $"nuptuals drive you forward." +
                $"\nWhere would you like to go? \n\t1 Earth: {UM.PlanetDistance(PI.AlphaCentariXPosition, PI.EarthXPosition,PI.AlphaCentariYPosition, PI.EarthYPosition)} Light years away which will take {UM.PlanetDistance(PI.AlphaCentariXPosition, PI.EarthXPosition, PI.AlphaCentariYPosition, PI.EarthYPosition) / playerWarpSpeed} years" +
                $"\n\t2 M63: {UM.PlanetDistance(PI.AlphaCentariXPosition, PI.M63XPosition, PI.AlphaCentariYPosition, PI.M63YPosition)} Light years away which will take {UM.PlanetDistance(PI.AlphaCentariXPosition, PI.M63XPosition, PI.AlphaCentariYPosition, PI.M63YPosition) / playerWarpSpeed} years\n\t3 Return to Macawalani, the Capital of Centari IV");
            int response = Convert.ToInt32(Console.ReadLine());
            if (response == 1)
            {
                UM.PlanetTravel(PI.AlphaCentariXPosition, PI.EarthXPosition, PI.AlphaCentariYPosition, PI.EarthYPosition, ship, PS, fuel);
                UM.Travel(PS);
                EarthPage();
            }
            if (response == 2)
            {
                UM.PlanetTravel(PI.AlphaCentariXPosition, PI.M63XPosition, PI.AlphaCentariYPosition, PI.M63YPosition, ship, PS, fuel);
                UM.Travel(PS);
                M63Page();
            }
            if (response == 3)
            {
                return;
            }
        }
        #endregion

        #region M63

        public void M63Page()
        {
            PS.MyCurrentLocation = "M63";
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
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
                GO.EndScreen(PS, ship);

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
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"" +
                $"Tall white columns frame the door to the Messinese Galactic Bank branch.\n" +
                $"Men and women dressed in all white are coming and going from the inside.\n" +
                $"The shining white walls of the bank hum with the electricity from the sheer\n" +
                $"number of data transfers taking place inside. The interior is more of the \n" +
                $"same, white walls and white clothes contrasting sharply with the coal black\n");
            UM.BankDisplay(PS);
            M63Page();
        }
        public void M63Shop()
        {
            Console.Clear();
            Console.WriteLine("You've arrived at the shop on M63. Niko, the owner welcomes you to look around at all the goods." +
                "\nWe've got the highest quality TV's in the universe!");
            Console.ReadLine();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine("What would you like to do?\n 1 Buy Cargo\n 2 Sell Cargo\n 3 Return to the streets of M63");
            int response = Convert.ToInt32(Console.ReadLine());
            bool purchase = response == 1;
            bool offload = response == 2;
            bool Return = response == 3;
            if (response == 1)
                M63Buy();
            if (response == 2)
                M63Sell();
            if (response == 3)
                fuel.BuyFuel(PS, ship);
            if (response == 4)
                M63Page();
        }
        public void M63Buy()
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"You have {PS.MyCurrentCredit} Galactic Credits, what good would you like to buy?\n " +
                $"1 NoBalanceShoes {PI.M63NoBalanceShoes} GC per Unit\n 2 Space Gold {PI.M63SpaceGold} GC per Unit\n 3 Galactic TV {PI.M63GalacticTVs} GC per Unit \n 4 " +
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
                if ((quantity * PI.M63NoBalanceShoes) > PS.MyCurrentCredit)
                {
                    Console.WriteLine("You can't afford that! \n" +
                        "Press any key to return to the Shop..");
                    Console.ReadLine();
                    M63Buy();
                }
                if ((quantity + PS.GalacticTVs + PS.SpaceGold + PS.NoBalanaceShoes) > ship.ShipCapacity)
                {
                    Console.WriteLine($"You don't have room for that! You currently" +
                        $" have {(ship.ShipCapacity - (PS.SpaceGold + PS.GalacticTVs + PS.NoBalanaceShoes))} space left in your cargo hold\n" +
                        $"Press any key to continue...");
                    Console.ReadLine();
                    M63Buy();
                }
                PS.MyCurrentCredit -= (quantity * PI.M63NoBalanceShoes);

                PS.NoBalanaceShoes += quantity;

                Console.WriteLine($"you bought {quantity} NoBalance Shoes for {PI.M63NoBalanceShoes * quantity} GC, your new balance is {PS.MyCurrentCredit} GC \n " +
                    $"You now have {PS.NoBalanaceShoes} pairs of No Balanace Shoes in your ship.\n Press any key to continue..");

                Console.ReadLine();
                M63Buy();
            }
            //Buy Gold
            if (Gold)
            {
                Console.WriteLine("How many?");
                int quantity = Convert.ToInt32(Console.ReadLine());
                if ((quantity * PI.M63SpaceGold) > PS.MyCurrentCredit)
                {
                    Console.WriteLine("You can't afford that! \n" +
                        "Press any key to return to the Shop..");
                    Console.ReadLine();
                    M63Buy();
                }
                if ((quantity + PS.GalacticTVs + PS.SpaceGold + PS.NoBalanaceShoes) > ship.ShipCapacity)
                {
                    Console.WriteLine($"You don't have room for that! You currently" +
                        $" have {(ship.ShipCapacity - (PS.SpaceGold + PS.GalacticTVs + PS.NoBalanaceShoes))} space left in your cargo hold\n" +
                        $"Press any key to continue...");
                    Console.ReadLine();
                    M63Buy();
                }
                PS.MyCurrentCredit -= (quantity * PI.M63SpaceGold);

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
                if ((quantity * PI.M63GalacticTVs) > PS.MyCurrentCredit)
                {
                    Console.WriteLine("You can't afford that! \n" +
                        "Press any key to return to the Shop..");
                    Console.ReadLine();
                    M63Buy();
                }
                if ((quantity + PS.GalacticTVs + PS.SpaceGold + PS.NoBalanaceShoes) > ship.ShipCapacity)
                {
                    Console.WriteLine($"You don't have room for that! You currently" +
                        $" have {(ship.ShipCapacity - (PS.SpaceGold + PS.GalacticTVs + PS.NoBalanaceShoes))} space left in your cargo hold\n" +
                        $"Press any key to continue...");
                    Console.ReadLine();
                    M63Buy();
                }
                PS.MyCurrentCredit -= (quantity * PI.M63GalacticTVs);

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
            UM.InventoryDisplay(PS, ship, fuel);
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
                PS.MyCurrentCredit += (quantity * PI.M63NoBalanceShoes);
                Console.WriteLine($"Thank you for the No Balance Shoes, you can jump so high when gravity doesn't affect your feet!\nYou sold {quantity} No Balance Shoes for {(quantity * PI.M63NoBalanceShoes)} Galactic Credits.\n" +
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
                PS.MyCurrentCredit += (quantity * PI.M63SpaceGold);
                Console.WriteLine($"Thanks for the Space Gold, Space Gold is so much more shiny than boring old regular gold!\nYou sold {quantity} bars of Space Gold for {(quantity * PI.M63SpaceGold)} Galactic Credits.\n" +
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
                PS.MyCurrentCredit += (quantity * PI.M63GalacticTVs);
                Console.WriteLine($"Thank you for the Galactic TVs I can't believe how thin they are!\nYou sold {quantity} Galactic TVs for {(quantity * PI.M63GalacticTVs)} Galactic Credits.\n" +
                    $"You now have {PS.MyCurrentCredit} Galactic Credits and {PS.GalacticTVs} Galactic TVs left.\n Press any key to continue...");
                Console.ReadLine();
                M63Sell();
            }
        }
        public void M63Port()
        {
            double distAlphaCentari = (Math.Sqrt(Math.Pow(PI.M63XPosition - PI.AlphaCentariXPosition, 2) + Math.Pow(PI.M63YPosition - PI.AlphaCentariYPosition, 2)));
            double distEarth = (Math.Sqrt(Math.Pow(PI.EarthXPosition - PI.M63XPosition, 2) + Math.Pow(PI.EarthYPosition - PI.M63YPosition, 2)));
            double playerWarpSpeed = (Math.Pow(ship.ShipSpeed, 10 / 3) + Math.Pow(10 - ship.ShipSpeed, -11 / 3));
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
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
                    GO.Retire(PS, ship);
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
                    GO.Retire(PS, ship);
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
            UM.InventoryDisplay(PS, ship, fuel);
            // write flavor text about shipyard
            Console.WriteLine("You walk into the Shipyard, the sound of welders and hammers fills the air. Ship salesman are weaving in and out of" +
                "the ships pushing their latest ship on travelers all the while dodging the laborers.\n" +
                "Would you like to:\n" +
                " 1 Check your ship stats\n" +
                " 2 Buy a new Ship\n" +
                " 3 Return to planetary hub");
            int response = Convert.ToInt32(Console.ReadLine());
            if (response == 1)
                SY.ShipCheck(PS, ship, UM, fuel);
            if (response == 2)
                SY.PurchaseShip(PS, ship, UM, fuel);
            if (response == 3)
                LandingPagePicker();
        }

            public void M63Market()
        {
            Console.WriteLine($"Welcome to the Epic Market on M63, where your opportunity for wealth is boundless and the products are of the most elegant varieties. " +
                $"  \nEarth: \n\tNo Balance Shoes: {PI.EarthNoBalanceShoes} \n\tSpace Gold: {PI.EarthSpaceGold} \n\tGalactic TVs: {PI.EarhtGalacticTVs}" +
                $"\n \nAlpha Centari:\n\t No Balance Shoe: {PI.AlphaCentariNoBalanceShoes}\n\tSpace Gold: {PI.AlphaCentariGold}\n\tGalactic " +
                $"TVs: {PI.AlphaCentariGalacticTVs}\n \nM63:\n\t No Balance Shoes: {PI.M63NoBalanceShoes}" +
                $"\n\tSpace Gold: {PI.M63SpaceGold}\n\tGalactic TVs: {PI.M63GalacticTVs} \n" +
                $"Press enter to return to the Messien streets...");
            Console.ReadLine();
        }
        #endregion

        #region Asgard

        
        #endregion


        
       



        




    }
}
