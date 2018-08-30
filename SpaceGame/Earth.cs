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

        public void EarthPage(LandingPage LP, Shop Shop, ShipYard SY, GameOver GO, PersonalStatus PS, UtilityMethods UM, Ship ship, PlanetInfo PI, Fuel fuel, Asgard Asgard, Earth Earth)


        {
           
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
                "\t\t  9. Quit the Game");

            //send back to check selected option after invalid input
            try
            {
                SelectEarthOptions(LP, Shop, SY, GO, PS, UM, ship, PI, fuel, Asgard, Earth);
            }

            //display if invalid input
            catch (Exception)
            {
                Console.WriteLine("Invalid input, try again! Press any key to continue.");
                Console.ReadLine();

                //recycle to Welcome to Earth after invalid entry  
                EarthPage(LP, Shop, SY, GO, PS, UM, ship, PI, fuel, Asgard, Earth);
            }



        }

        public void SelectEarthOptions(LandingPage LP, Shop Shop, ShipYard SY, GameOver GO, PersonalStatus PS, UtilityMethods UM, Ship ship, PlanetInfo PI, Fuel fuel, Asgard Asgard, Earth Earth)
        {
            //convert/parse user input string 
            int response = Convert.ToInt32(Console.ReadLine());
            
            //point of method access after valid user selection
            if (response == 1)
                ShipYard(UM, PS, ship, fuel, SY);

            if (response == 2)
                Bank(PS, UM, ship, fuel);

            if (response == 3)
                EarthShop(UM, PS, ship, fuel, PI, Shop);

            if (response == 4) 
                 Market(PS, UM, ship, fuel, PI);

            if (response == 5) 
               EarthPort(ship, UM, PS, fuel, PI, LP);

            if (response == 9)
                GO.EndScreen(PS, ship);

            else
            {
                //loops back to the beginning of earth page
                Console.WriteLine("invalid entry");
                return;
            }

        }

        public void Bank(PersonalStatus PS, UtilityMethods UM, Ship ship, Fuel fuel)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            UM.BankDisplay(PS);
            return;
        }

        public void ShipYard(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, ShipYard SY)
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
       
        public void EarthShop(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI, Shop Shop)
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
                Buy(UM, PS, ship, fuel, PI, Shop);
            if (response == 2)
                Sell(UM, PS, ship, fuel, PI);
            if (response == 3)
                fuel.BuyFuel(PS, ship);
            if (response == 4)
                return;
        }

        public void Buy(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI, Shop Shop)
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
                Shop.BuyTV(PI.EarthGalacticTVs, PS, UM, ship, fuel);
            }

            if (response == 4)
            {
                return;
            }
        }

        public void Sell(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI)
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
                PS.MyCurrentCredit += (quantity * PI.EarthGalacticTVs);
                Console.WriteLine($"Thank you for the Galactic TVs I can't believe how thin they are!\n" +
                    $"You sold {quantity} Galactic TVs for {(quantity * PI.EarthGalacticTVs)} Galactic Credits.\n" +
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

        public void Market(PersonalStatus PS, UtilityMethods UM, Ship ship, Fuel fuel, PlanetInfo PI)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine("\n\n" +
                "\tThe Galactic Stock exchange glitters and flashes, and down but you worry about the three perenial commodities.\n" +
                "\tNo Balance Shoes, the zero gravity shoes that changed the way the galaxy moves. \n" +
                "\tSpace Gold, it's like the gold everyone knows and loves but shinier and better in every way.\n" +
                "\tAnd Galactic TVs, TVs so thin that you can't even see them unless you are standing in front of them.\n" +
                $"\tThe display flashes their market prices. \n\n");
                UM.MarketDisplay(PI);
        }

        public void EarthPort(Ship ship, UtilityMethods UM, PersonalStatus PS, Fuel fuel, PlanetInfo PI, LandingPage LP)
        {
            double playerWarpSpeed = (Math.Pow(ship.ShipSpeed, 10 / 3) + Math.Pow(10 - ship.ShipSpeed, -11 / 3));
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"\n\n" +
                $"\tWhere would you like to go? \n");
            if (UM.FuelCheck(PI.EarthXPosition, PI.AlphaCentariXPosition, PI.EarthYPosition, PI.AlphaCentariYPosition, ship, PS, fuel) == "OK")
                Console.WriteLine($"" +
                    $"\t\t<centari> Alpha Centari: {UM.PlanetDistance(PI.EarthXPosition, PI.AlphaCentariXPosition, PI.EarthYPosition, PI.AlphaCentariYPosition)} Light years away which will take {UM.PlanetDistance(PI.EarthXPosition, PI.AlphaCentariXPosition, PI.EarthYPosition, PI.AlphaCentariYPosition) / playerWarpSpeed} years\n");
            if (UM.FuelCheck(PI.EarthXPosition, PI.M63XPosition, PI.EarthYPosition, PI.M63YPosition, ship, PS, fuel) == "OK")
                Console.WriteLine($"" +
                    $"\t\t<m63> M63: {UM.PlanetDistance(PI.EarthXPosition, PI.M63XPosition, PI.EarthYPosition, PI.M63YPosition)} Light years away which will take {UM.PlanetDistance(PI.EarthXPosition, PI.M63XPosition, PI.EarthYPosition, PI.M63YPosition) / playerWarpSpeed} years\n");
            if (UM.FuelCheck(PI.EarthXPosition, PI.AsgardXPosition, PI.EarthYPosition, PI.AsgardYPosition, ship, PS, fuel) == "OK")
                Console.WriteLine($"" +
                    $"\t\t<asgard> Asgard: {UM.PlanetDistance(PI.EarthXPosition, PI.AsgardXPosition, PI.EarthYPosition, PI.AsgardYPosition)} Light years away which will take {UM.PlanetDistance(PI.EarthXPosition, PI.AsgardXPosition, PI.EarthYPosition, PI.AsgardYPosition) / playerWarpSpeed} years\n");
            Console.WriteLine($"" +
                $"\t\t<return> Return to earth");
            string response = Console.ReadLine();
            if (response == "centari")
            {
                if (UM.FuelCheck(PI.EarthXPosition, PI.AlphaCentariXPosition, PI.EarthYPosition, PI.AlphaCentariYPosition, ship, PS, fuel) == "OK")
                {
                    UM.PlanetTravel(PI.EarthXPosition, PI.AlphaCentariXPosition, PI.EarthYPosition, PI.AlphaCentariYPosition, ship, PS, fuel);
                    UM.Travel(PS);
                    PS.MyCurrentLocation = "AlphaCentari";
                    LP.LandingPagePicker();
                }
                if (UM.FuelCheck(PI.EarthXPosition, PI.AlphaCentariXPosition, PI.EarthYPosition, PI.AlphaCentariYPosition, ship, PS, fuel) == "TooFar")
                {
                    UM.TooFar(PI.EarthXPosition, PI.AlphaCentariXPosition, PI.EarthYPosition, PI.AlphaCentariYPosition, fuel);
                    return;
                }
            }
            if (response == "m63")
            {
                if (UM.FuelCheck(PI.EarthXPosition, PI.M63XPosition, PI.EarthYPosition, PI.M63YPosition, ship, PS, fuel) == "OK")
                {
                    UM.PlanetTravel(PI.EarthXPosition, PI.M63XPosition, PI.EarthYPosition, PI.M63YPosition, ship, PS, fuel);
                    UM.Travel(PS);
                    PS.MyCurrentLocation = "M63";
                    LP.LandingPagePicker();
                }
                if (UM.FuelCheck(PI.EarthXPosition, PI.M63XPosition, PI.EarthYPosition, PI.M63YPosition, ship, PS, fuel) == "TooFar")
                {
                    UM.TooFar(PI.EarthXPosition, PI.M63XPosition, PI.EarthYPosition, PI.M63YPosition, fuel);
                    return;
                }
            }
            if (response == "asgard")
            {
                if (UM.FuelCheck(PI.EarthXPosition, PI.AsgardXPosition, PI.EarthYPosition, PI.AsgardYPosition, ship, PS, fuel) == "OK")
                {
                    UM.PlanetTravel(PI.EarthXPosition, PI.AsgardXPosition, PI.EarthYPosition, PI.AsgardYPosition, ship, PS, fuel);
                    UM.Travel(PS);
                    PS.MyCurrentLocation = "Asgard";
                    LP.LandingPagePicker();
                }
                if (UM.FuelCheck(PI.EarthXPosition, PI.AsgardXPosition, PI.EarthYPosition, PI.AsgardYPosition, ship, PS, fuel) == "TooFar")
                {
                    UM.TooFar(PI.EarthXPosition, PI.AsgardXPosition, PI.EarthYPosition, PI.AsgardYPosition, fuel);
                    return;
                }
            }
            if (response == "return")
            {
                return;
            }
        }

        #endregion

        #region AlphaCentari

        public void AlphaCentariPage(LandingPage LP, Shop Shop, ShipYard SY, GameOver GO, PersonalStatus PS, UtilityMethods UM, Ship ship, PlanetInfo PI, Fuel fuel, Asgard Asgard, Earth Earth)
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
            AlphaCentariSelector(GO, PS, ship, PI, fuel, UM, LP, SY, Shop, Asgard, Earth);
        }
        
        public void AlphaCentariSelector(GameOver GO, PersonalStatus PS, Ship ship, PlanetInfo PI, Fuel fuel, UtilityMethods UM, LandingPage LP, ShipYard SY, Shop Shop, Asgard Asgard, Earth Earth)
        {
            
            int response = Convert.ToInt32(Console.ReadLine());
          
            if (response == 1)
               AlphaYard(UM, PS, ship, fuel, SY, LP);

            if (response == 2)
                AlphaBank(UM, PS, ship, fuel);

            if (response == 3)
                AlphaShop(UM, PS, ship, fuel, PI, Shop);

            if (response == 4)
                AlphaMarket(UM, PS, ship, fuel, PI);

            if (response == 5)
                AlphaCentariPort(ship, PI, PS, fuel, UM, LP, SY, GO, Shop, Asgard, Earth);

            if (response == 9)
                GO.EndScreen(PS, ship);

            else
            {
                Console.WriteLine("invalid entry");
                return;
            }
        }

        public void AlphaYard(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, ShipYard SY, LandingPage LP)
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
                LP.LandingPagePicker();
        }

        public void AlphaShop(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI, Shop Shop)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine("\n\n" +
                "\t\tYou arrive at the shop on Alpha Centari. The owner, Brahman welcomes you. 'What's up, \n" +
                "\t\tmane you know that we have the highest quality gold in the universe!'");
            int response = UM.ShopSelector();
            if (response == 1)
                AlphaBuy(UM, PS, ship, fuel, PI, Shop);
            if (response == 2)
                AlphaSell(UM,PS,ship,fuel,PI);
            if (response == 3)
                fuel.BuyFuel(PS, ship);
            if (response == 4)
                return;
        }

        public void AlphaBank(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"" +
                $"Welcome to the Galactic Bank of Centari Four! Behind the counter is an tall old bird, his \n" +
                $"specticles are low on his beak and attached to his head by a gold chain.\n" +
                $"The high ceilings make room for doors on many levels but with no visable landing, \n" +
                $"of course ground based humans like you have to come in through the 'walkers' door.\n");
            UM.BankDisplay(PS);
            Console.ReadLine();
            return;
        }

        public void AlphaBuy(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI, Shop Shop)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"You have {PS.MyCurrentCredit} Galactic Credits, what good would you like to buy?\n " +
                $"1 NoBalanceShoes {PI.AlphaCentariNoBalanceShoes} GC per Unit\n" +
                $"2 Space Gold {PI.AlphaCentariGold} GC per Unit\n" +
                $"3 Galactic TV {PI.AlphaCentariGalacticTVs} GC per Unit \n" +
                $"4 Return to the Shop");
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
                return;
            }
        }

        public void AlphaSell(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI)
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
                    return;
                }
                PS.NoBalanaceShoes -= quantity;
                PS.MyCurrentCredit += (quantity * PI.AlphaCentariNoBalanceShoes);
                Console.WriteLine($"Thank you for the No Balance Shoes, you can jump so high when gravity doesn't affect your feet!\nYou sold {quantity} No Balance Shoes for {(quantity * PI.AlphaCentariNoBalanceShoes)} Galactic Credits.\n" +
                    $"You now have {PS.MyCurrentCredit} Galactic Credits and {PS.NoBalanaceShoes} No Balanace Shoes.\n Press any key to continue...");
                Console.ReadLine();
                return;
            } 
            if (Gold)
            {
                Console.WriteLine("How much Space Gold do you want sell?");
                int quantity = Convert.ToInt32(Console.ReadLine());
                if (quantity > PS.SpaceGold)
                {
                    Console.WriteLine($"You don't have that much Space Gold!\nYou only have {PS.SpaceGold} bars of Space Gold. \nPress any key to return to the selling menu...");
                    Console.ReadLine();
                    return;
                }
                PS.SpaceGold -= quantity;
                PS.MyCurrentCredit += (quantity * PI.AlphaCentariGold);
                Console.WriteLine($"Thanks for the Space Gold, Space Gold is so much more shiny than boring old regular gold!\nYou sold {quantity} bars of Space Gold for {(quantity * PI.AlphaCentariGold)} Galactic Credits.\n" +
                    $"You now have {PS.MyCurrentCredit} Galactic Credits and {PS.SpaceGold} bars of Space Gold left.\n Press any key to continue...");
                Console.ReadLine();
                return;
            }
            if (TV)
            {
                Console.WriteLine("How many TVs do you want to sell?");
                int quantity = Convert.ToInt32(Console.ReadLine());
                if (quantity > PS.GalacticTVs)
                {
                    Console.WriteLine($"You don't have that many Galactic TVs, you only have {PS.GalacticTVs}.\n Press any key to return to the selling menu...");
                    Console.ReadLine();
                    return;
                }
                PS.GalacticTVs -= quantity;
                PS.MyCurrentCredit += (quantity * PI.AlphaCentariGalacticTVs);
                Console.WriteLine($"Thank you for the Galactic TVs I can't believe how thin they are!\nYou sold {quantity} Galactic TVs for {(quantity * PI.AlphaCentariGalacticTVs)} Galactic Credits.\n" +
                    $"You now have {PS.MyCurrentCredit} Galactic Credits and {PS.GalacticTVs} Galactic TVs left.\n Press any key to continue...");
                Console.ReadLine();
                return;
            }
            if (Return)
            {
                return;
            }

        }

        public void AlphaMarket(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"" +
                $"The city of Macawalani on Centari IV has the largest stock exchange for a light year in any direction.\n" +
                $"But unlike the exchanges of earth it's nearly silent in the exchange. The Centarians are famously capatalistic and the \n" +
                $"Macawalani exchange is almost like a temple. But it takes you hardly any time at all to find the entries of your\n" +
                $"classic moneymakers...\n");
            UM.MarketDisplay(PI);
        }

        public void AlphaCentariPort(Ship ship, PlanetInfo PI, PersonalStatus PS, Fuel fuel, UtilityMethods UM, LandingPage LP, ShipYard SY, GameOver GO, Shop Shop, Asgard Asgard, Earth Earth)
        {
            
            double playerWarpSpeed = (Math.Pow(ship.ShipSpeed, 10 / 3) + Math.Pow(10 - ship.ShipSpeed, -11 / 3));
            Console.Clear();
            Console.WriteLine($"" +
                $"Wind swirls around you as a ships takes off to some new and exciting destination.\n" +
                $"Ports like this always make you miss home a little but the dream of the \n" +
                $"Dukedom of Mercury and the thoughts of your upcoming(hopefully)\n" +
                $"nuptuals drive you forward.");
                 Console.WriteLine($"\n\n" +
                $"\tWhere would you like to go? \n");
            if (UM.FuelCheck(PI.AlphaCentariXPosition, PI.EarthXPosition, PI.AlphaCentariYPosition, PI.EarthYPosition, ship, PS, fuel) == "OK")
                Console.WriteLine($"" +
                    $"\t\t<earth> Earth: {UM.PlanetDistance(PI.AlphaCentariXPosition, PI.EarthXPosition, PI.AlphaCentariYPosition, PI.EarthYPosition)} Light years away which will take {UM.PlanetDistance(PI.EarthXPosition, PI.AlphaCentariXPosition, PI.EarthYPosition, PI.AlphaCentariYPosition) / playerWarpSpeed} years\n");
            if (UM.FuelCheck(PI.AlphaCentariXPosition, PI.M63XPosition, PI.AlphaCentariYPosition, PI.M63YPosition, ship, PS, fuel) == "OK")
                Console.WriteLine($"" +
                    $"\t\t<m63> M63: {UM.PlanetDistance(PI.AlphaCentariXPosition, PI.M63XPosition, PI.AlphaCentariYPosition, PI.M63YPosition)} Light years away which will take {UM.PlanetDistance(PI.EarthXPosition, PI.M63XPosition, PI.EarthYPosition, PI.M63YPosition) / playerWarpSpeed} years\n");
            if (UM.FuelCheck(PI.AlphaCentariXPosition, PI.AsgardXPosition, PI.AlphaCentariYPosition, PI.AsgardYPosition, ship, PS, fuel) == "OK")
                Console.WriteLine($"" +
                    $"\t\t<asgard> Asgard: {UM.PlanetDistance(PI.AlphaCentariXPosition, PI.AsgardXPosition, PI.AlphaCentariYPosition, PI.AsgardYPosition)} Light years away which will take {UM.PlanetDistance(PI.EarthXPosition, PI.AsgardXPosition, PI.EarthYPosition, PI.AsgardYPosition) / playerWarpSpeed} years\n");
            Console.WriteLine($"" +
                $"\t\t<return> Return to Alpha Centari");
            string response = Console.ReadLine();
            if (response == "earth")
            {
                if (UM.FuelCheck(PI.AlphaCentariXPosition, PI.EarthXPosition, PI.AlphaCentariYPosition, PI.EarthYPosition, ship, PS, fuel) == "OK")
                {
                    UM.PlanetTravel(PI.AlphaCentariXPosition, PI.EarthXPosition, PI.AlphaCentariYPosition, PI.EarthYPosition, ship, PS, fuel);
                    UM.Travel(PS);
                    PS.MyCurrentLocation = "Earth";
                    LP.LandingPagePicker();
                }
                if (UM.FuelCheck(PI.AlphaCentariXPosition, PI.EarthXPosition, PI.AlphaCentariYPosition, PI.EarthYPosition, ship, PS, fuel) == "TooFar")
                {
                    UM.TooFar(PI.AlphaCentariXPosition, PI.EarthXPosition, PI.AlphaCentariYPosition, PI.EarthYPosition, fuel);
                    return;
                }
            }
            if (response == "M63")
            {
                if (UM.FuelCheck(PI.AlphaCentariXPosition, PI.M63XPosition, PI.AlphaCentariYPosition, PI.M63YPosition, ship, PS, fuel) == "OK")
                {
                    UM.PlanetTravel(PI.AlphaCentariXPosition, PI.M63XPosition, PI.AlphaCentariYPosition, PI.M63YPosition, ship, PS, fuel);
                    UM.Travel(PS);
                    PS.MyCurrentLocation = "M63";
                    LP.LandingPagePicker();
                }
                if (UM.FuelCheck(PI.AlphaCentariXPosition, PI.M63XPosition, PI.AlphaCentariYPosition, PI.M63YPosition, ship, PS, fuel) == "TooFar")
                {
                    UM.TooFar(PI.AlphaCentariXPosition, PI.M63XPosition, PI.AlphaCentariYPosition, PI.M63YPosition, fuel);
                    return;
                }
            }
            if (response == "asgard")
            {
                if (UM.FuelCheck(PI.AlphaCentariXPosition, PI.AsgardXPosition, PI.AlphaCentariYPosition, PI.AsgardYPosition, ship, PS, fuel) == "OK")
                {
                    UM.PlanetTravel(PI.AlphaCentariXPosition, PI.AsgardXPosition, PI.AlphaCentariYPosition, PI.AsgardYPosition, ship, PS, fuel);
                    UM.Travel(PS);
                    PS.MyCurrentLocation = "Asgard";
                    LP.LandingPagePicker();
                }
                if (UM.FuelCheck(PI.AlphaCentariXPosition, PI.AsgardXPosition, PI.AlphaCentariYPosition, PI.AsgardYPosition, ship, PS, fuel) == "TooFar")
                {
                    UM.TooFar(PI.AlphaCentariXPosition, PI.AsgardXPosition, PI.AlphaCentariYPosition, PI.AsgardYPosition, fuel);
                    return;
                }
            }
            if (response == "return")
            {
                return;
            }
        }
        #endregion

        #region M63

        public void M63Page(LandingPage LP, Shop Shop, ShipYard SY, GameOver GO, PersonalStatus PS, UtilityMethods UM, Ship ship, PlanetInfo PI, Fuel fuel, Asgard Asgard, Earth Earth)
        {
            PS.MyCurrentLocation = "M63";
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine("\n\n" +
                "\tWelcome to the star system M63, named for Messier star cluster circling a black hole.\n" +
                "\tAs you walk into the streets the first thing that you notice is that everything is\n" +
                "\tclean and bright white. None of the architecture has a scrap of color anywhere, the\n" +
                "\tonly exception is the flat holographic ads that are projected up on some of the walls\n" +
                "\tbut even thier colors are muted. The Messinese that you see all wear the same color white\n" +
                "\tof the buildings but in stark contrast their skin is as black as the hole their star orbits" +
                "\n\n\t\tWhere would you like to go? \n" +
                "\t\t1. Ship Yard \n" +
                "\t\t2. Galactic Bank \n" +
                "\t\t3. Buy, Sell, Trade \n" +
                "\t\t4. Galactic Market\n" +
                "\t\t5. Departure Port\n\n" +
                "\t\t9. Quit the Game");
            try
            {
                SelectM63Options(GO, PS, ship, LP , SY, UM, PI, Shop, fuel, Asgard, Earth);
            }

            //display if invalid input
            catch (Exception)
            {
                Console.WriteLine("Invalid input, try again! Press any key to continue.");
                Console.ReadLine();

                //recycle to Welcome to m63 after invalid entry  
                return;
            }
        }

        public void SelectM63Options(GameOver GO, PersonalStatus PS, Ship ship, LandingPage LP, ShipYard SY, UtilityMethods UM, PlanetInfo PI, Shop Shop, Fuel fuel, Asgard Asgard, Earth Earth)
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
            if (response == 1)
                M63ShipYard(UM, PS, ship, fuel, SY, LP);

            if (response == 2)
                M63Bank(UM, PS, ship, fuel);

            if (response == 3)
                M63Shop(UM, PS, ship, fuel, PI);

            if (response == 4)
                M63Market(PI, PS, UM, ship, fuel);

            if (response == 5)
                M63Port(LP, Shop, SY, GO, PS, UM, ship, PI, fuel, Asgard, Earth);

            if (response == 9)
                GO.EndScreen(PS, ship);

            else
            {
                //loops back to the beginning of earth page
                Console.WriteLine("invalid entry");
                return;
            }
        }

        public void M63Bank(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel)
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
            return;
        }

        public void M63Shop(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine("You've arrived at the shop on M63. Niko, the owner welcomes you to look around at all the goods." +
                "\nWe've got the highest quality TV's in the universe!");
            int response = UM.ShopSelector();
            if (response == 1)
                M63Buy(UM, PS, ship, fuel, PI);
            if (response == 2)
                M63Sell(UM, PS, ship, fuel, PI);
            if (response == 3)
                fuel.BuyFuel(PS, ship);
            if (response == 4)
                return;
        }

        public void M63Buy(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"You have {PS.MyCurrentCredit} Galactic Credits, what good would you like to buy?\n " +
                $"1 NoBalanceShoes {PI.M63NoBalanceShoes} GC per Unit\n 2 Space Gold {PI.M63SpaceGold} GC per Unit\n 3 Galactic TV {PI.M63GalacticTVs} GC per Unit \n 4 " +
                $"Return to Planetary Menu");
            int response = Convert.ToInt32(Console.ReadLine());
            
            //Buy Shoes
            if (response == 1)
            {
                Console.WriteLine("How many?");
                int quantity = Convert.ToInt32(Console.ReadLine());
                if ((quantity * PI.M63NoBalanceShoes) > PS.MyCurrentCredit)
                {
                    Console.WriteLine("You can't afford that! \n" +
                        "Press any key to return to the Shop..");
                    Console.ReadLine();
                    return;
                }
                if ((quantity + PS.GalacticTVs + PS.SpaceGold + PS.NoBalanaceShoes) > ship.ShipCapacity)
                {
                    Console.WriteLine($"You don't have room for that! You currently" +
                        $" have {(ship.ShipCapacity - (PS.SpaceGold + PS.GalacticTVs + PS.NoBalanaceShoes))} space left in your cargo hold\n" +
                        $"Press any key to continue...");
                    Console.ReadLine();
                    return;
                }
                PS.MyCurrentCredit -= (quantity * PI.M63NoBalanceShoes);

                PS.NoBalanaceShoes += quantity;

                Console.WriteLine($"you bought {quantity} NoBalance Shoes for {PI.M63NoBalanceShoes * quantity} GC, your new balance is {PS.MyCurrentCredit} GC \n " +
                    $"You now have {PS.NoBalanaceShoes} pairs of No Balanace Shoes in your ship.\n Press any key to continue..");

                Console.ReadLine();
                return;
            }
            //Buy Gold
            if (response == 2)
            {
                Console.WriteLine("How many?");
                int quantity = Convert.ToInt32(Console.ReadLine());
                if ((quantity * PI.M63SpaceGold) > PS.MyCurrentCredit)
                {
                    Console.WriteLine("You can't afford that! \n" +
                        "Press any key to return to the Shop..");
                    Console.ReadLine();
                    return;
                }
                if ((quantity + PS.GalacticTVs + PS.SpaceGold + PS.NoBalanaceShoes) > ship.ShipCapacity)
                {
                    Console.WriteLine($"You don't have room for that! You currently" +
                        $" have {(ship.ShipCapacity - (PS.SpaceGold + PS.GalacticTVs + PS.NoBalanaceShoes))} space left in your cargo hold\n" +
                        $"Press any key to continue...");
                    Console.ReadLine();
                    return;
                }
                PS.MyCurrentCredit -= (quantity * PI.M63SpaceGold);

                PS.SpaceGold += quantity;

                Console.WriteLine($"you bought {quantity} Bars of Space Gold, your new balance is {PS.MyCurrentCredit} \n " +
                    $" You have {PS.SpaceGold} bars of Space Gold in your spaceship.\n Press any key to continue..");
                Console.ReadLine();
                return;
            }

            if (response ==3)
            {
                Console.WriteLine("How many?");
                int quantity = Convert.ToInt32(Console.ReadLine());
                if ((quantity * PI.M63GalacticTVs) > PS.MyCurrentCredit)
                {
                    Console.WriteLine("You can't afford that! \n" +
                        "Press any key to return to the Shop..");
                    Console.ReadLine();
                    return;
                }
                if ((quantity + PS.GalacticTVs + PS.SpaceGold + PS.NoBalanaceShoes) > ship.ShipCapacity)
                {
                    Console.WriteLine($"You don't have room for that! You currently" +
                        $" have {(ship.ShipCapacity - (PS.SpaceGold + PS.GalacticTVs + PS.NoBalanaceShoes))} space left in your cargo hold\n" +
                        $"Press any key to continue...");
                    Console.ReadLine();
                    return;
                }
                PS.MyCurrentCredit -= (quantity * PI.M63GalacticTVs);

                PS.GalacticTVs += quantity;



                Console.WriteLine($"you bought {quantity} Galactic TV(s), your new balance is {PS.MyCurrentCredit} \n " +
                    $"You now have {PS.GalacticTVs} Galactic Tvs in your ship. \n Press any key to continue..");
                Console.ReadLine();
                return;
            }

            if (response == 4)
            {
                return;
            }
        }

        public void M63Sell(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"You have {PS.NoBalanaceShoes} pairs of No Balance Shoes, {PS.SpaceGold} bars of Space Gold & {PS.GalacticTVs} sets of Galactic TVs." +
                $" Which would you like to sell?\n 1 No Balance Shoes\n 2 Space Gold\n 3 Galactic TVs\n 4 or Return to the Shop");
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
                PS.MyCurrentCredit += (quantity * PI.M63NoBalanceShoes);
                Console.WriteLine($"Thank you for the No Balance Shoes, you can jump so high when gravity doesn't affect your feet!\nYou sold {quantity} No Balance Shoes for {(quantity * PI.M63NoBalanceShoes)} Galactic Credits.\n" +
                    $"You now have {PS.MyCurrentCredit} Galactic Credits and {PS.NoBalanaceShoes} No Balanace Shoes.\n Press any key to continue...");
                Console.ReadLine();
                return;
            }
            if (response == 2)
            {
                Console.WriteLine("How much Space Gold do you want sell?");
                int quantity = Convert.ToInt32(Console.ReadLine());
                if (quantity > PS.SpaceGold)
                {
                    Console.WriteLine($"You don't have that much Space Gold!\nYou only have {PS.SpaceGold} bars of Space Gold. \nPress any key to return to the selling menu...");
                    Console.ReadLine();
                    return;
                }
                PS.SpaceGold -= quantity;
                PS.MyCurrentCredit += (quantity * PI.M63SpaceGold);
                Console.WriteLine($"Thanks for the Space Gold, Space Gold is so much more shiny than boring old regular gold!\nYou sold {quantity} bars of Space Gold for {(quantity * PI.M63SpaceGold)} Galactic Credits.\n" +
                    $"You now have {PS.MyCurrentCredit} Galactic Credits and {PS.SpaceGold} bars of Space Gold left.\n Press any key to continue...");
                Console.ReadLine();
                return;
            }
            if (response == 3)
            {
                Console.WriteLine("How many TVs do you want to sell?");
                int quantity = Convert.ToInt32(Console.ReadLine());
                if (quantity > PS.GalacticTVs)
                {
                    Console.WriteLine($"You don't have that many Galactic TVs, you only have {PS.GalacticTVs}.\n Press any key to return to the selling menu...");
                    Console.ReadLine();
                    return;
                }
                PS.GalacticTVs -= quantity;
                PS.MyCurrentCredit += (quantity * PI.M63GalacticTVs);
                Console.WriteLine($"Thank you for the Galactic TVs I can't believe how thin they are!\nYou sold {quantity} Galactic TVs for {(quantity * PI.M63GalacticTVs)} Galactic Credits.\n" +
                    $"You now have {PS.MyCurrentCredit} Galactic Credits and {PS.GalacticTVs} Galactic TVs left.\n Press any key to continue...");
                Console.ReadLine();
                return;
            }
            if (response == 4)
            {
                return;
            }
        }

        public void M63Port(LandingPage LP, Shop Shop, ShipYard SY, GameOver GO, PersonalStatus PS, UtilityMethods UM, Ship ship, PlanetInfo PI, Fuel fuel, Asgard Asgard, Earth Earth)
        {
            double playerWarpSpeed = (Math.Pow(ship.ShipSpeed, 10 / 3) + Math.Pow(10 - ship.ShipSpeed, -11 / 3));
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"Where would you like to go?");
            if (UM.FuelCheck(PI.M63XPosition, PI.EarthXPosition, PI.M63YPosition, PI.EarthYPosition, ship, PS, fuel) == "OK")
            Console.WriteLine($"\t<earth> Earth: {UM.PlanetDistance(PI.M63XPosition, PI.EarthXPosition,PI.M63YPosition, PI.EarthYPosition)} Light years away which will take {UM.PlanetDistance(PI.M63XPosition,PI.EarthXPosition,PI.M63YPosition,PI.EarthYPosition) / playerWarpSpeed} years\n");
            if (UM.FuelCheck(PI.M63XPosition,PI.AlphaCentariXPosition,PI.M63YPosition,PI.AlphaCentariYPosition, ship, PS, fuel) == "OK")
            Console.WriteLine($"\t<centari> Alpha Centari: {UM.PlanetDistance(PI.M63XPosition,PI.AlphaCentariXPosition,PI.M63YPosition,PI.AlphaCentariYPosition)} Light years away which will take {UM.PlanetDistance(PI.M63XPosition, PI.AlphaCentariXPosition, PI.M63YPosition, PI.AlphaCentariYPosition) / playerWarpSpeed} years\n");
            if (UM.FuelCheck(PI.M63XPosition, PI.AsgardXPosition, PI.M63YPosition, PI.AsgardYPosition, ship, PS, fuel) == "OK")
                Console.WriteLine($"\t<asgard> Asgard: {UM.PlanetDistance(PI.M63XPosition, PI.AsgardXPosition, PI.M63YPosition, PI.AsgardYPosition)} Light years away which will take {UM.PlanetDistance(PI.M63XPosition, PI.AsgardXPosition, PI.M63YPosition, PI.AsgardYPosition) / playerWarpSpeed} year");
            Console.WriteLine($"\t<return> Return to earth");
            string response = Console.ReadLine();
            
            if (response == "earth")
            {
                if (UM.FuelCheck(PI.M63XPosition, PI.EarthXPosition, PI.M63YPosition, PI.EarthYPosition, ship, PS, fuel) == "OK")
                {
                    UM.PlanetTravel(PI.M63XPosition, PI.EarthXPosition, PI.M63YPosition, PI.EarthYPosition, ship, PS, fuel);
                    UM.Travel(PS);
                    PS.MyCurrentLocation = "Earth";
                    LP.LandingPagePicker();
                }
                if (UM.FuelCheck(PI.M63XPosition, PI.EarthXPosition, PI.M63YPosition, PI.EarthYPosition, ship, PS, fuel) == "TooFar")
                {
                    UM.TooFar(PI.M63XPosition, PI.EarthXPosition, PI.M63YPosition, PI.EarthYPosition, fuel);
                    return;
                }
            }
            if (response == "centari")
            {
                if (UM.FuelCheck(PI.M63XPosition, PI.AlphaCentariXPosition, PI.M63YPosition, PI.AlphaCentariYPosition, ship, PS, fuel) == "OK")
                {
                    UM.PlanetTravel(PI.M63XPosition, PI.AlphaCentariXPosition, PI.M63YPosition, PI.AlphaCentariYPosition, ship, PS, fuel);
                    UM.Travel(PS);
                    PS.MyCurrentLocation = "AlphaCentari";
                    LP.LandingPagePicker();
                }
                if (UM.FuelCheck(PI.M63XPosition, PI.AlphaCentariXPosition, PI.M63YPosition, PI.AlphaCentariYPosition, ship, PS, fuel) == "TooFar")
                {
                    UM.TooFar(PI.M63XPosition, PI.AlphaCentariXPosition, PI.M63YPosition, PI.AlphaCentariYPosition, fuel);
                    return;
                }
            }
            if (response == "asgard")
            {
                if (UM.FuelCheck(PI.M63XPosition, PI.AsgardXPosition, PI.M63YPosition, PI.AsgardYPosition, ship, PS, fuel) == "OK")
                {
                    UM.PlanetTravel(PI.M63XPosition, PI.AsgardXPosition, PI.M63YPosition, PI.AsgardYPosition, ship, PS, fuel);
                    UM.Travel(PS);
                    PS.MyCurrentLocation = "Asgard";
                    LP.LandingPagePicker();
                }
                if (UM.FuelCheck(PI.M63XPosition, PI.AsgardXPosition, PI.M63YPosition, PI.AsgardYPosition, ship, PS, fuel) == "TooFar")
                {
                    UM.TooFar(PI.M63XPosition, PI.AsgardXPosition, PI.M63YPosition, PI.AsgardYPosition, fuel);
                    return;
                }
            }
            if (response == "return")
            {
                return;
            }
        }

        public void M63ShipYard(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, ShipYard SY, LandingPage LP)
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
                LP.LandingPagePicker();
        }

        public void M63Market(PlanetInfo PI, PersonalStatus PS, UtilityMethods UM, Ship ship, Fuel fuel)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"" +
                $"Welcome to the Epic Market on M63, where your opportunity for wealth is boundless and the products are of the most elegant varieties. " +
                $"  \nEarth: \n\tNo Balance Shoes: {PI.EarthNoBalanceShoes} \n\tSpace Gold: {PI.EarthSpaceGold} \n\tGalactic TVs: {PI.EarthGalacticTVs}" +
                $"\n \nAlpha Centari:\n\t No Balance Shoe: {PI.AlphaCentariNoBalanceShoes}\n\tSpace Gold: {PI.AlphaCentariGold}\n\tGalactic " +
                $"TVs: {PI.AlphaCentariGalacticTVs}\n \nM63:\n\t No Balance Shoes: {PI.M63NoBalanceShoes}" +
                $"\n\tSpace Gold: {PI.M63SpaceGold}\n\tGalactic TVs: {PI.M63GalacticTVs} \n" +
                $"Press enter to return to the Messien streets...");
            Console.ReadLine();
        }
        #endregion

        

        
       



        




    }
}
