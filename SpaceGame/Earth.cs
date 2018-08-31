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

        public void EarthPage(LandingPage LP, Shop Shop, ShipYard SY, GameOver GO, PersonalStatus PS,
            UtilityMethods UM, Ship ship, PlanetInfo PI, Fuel fuel, Asgard Asgard, Earth Earth, AlphaCentari AlphaCentari, M63 M63)


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
            SelectEarthOptions(LP, Shop, SY, GO, PS, UM, ship, PI, fuel, Asgard, Earth, AlphaCentari, M63);



        }
        public void SelectEarthOptions(LandingPage LP, Shop shop, ShipYard SY, GameOver GO, PersonalStatus PS, UtilityMethods UM, Ship ship, PlanetInfo PI, Fuel fuel, Asgard Asgard, Earth Earth, AlphaCentari AlphaCentari, M63 M63)
        {
            //convert/parse user input string 
            int response = Convert.ToInt32(Console.ReadLine());
            
            //point of method access after valid user selection
            if (response == 1)
                ShipYard(UM, PS, ship, fuel, SY);

            if (response == 2)
                Bank(PS, UM, ship, fuel);

            if (response == 3)
                EarthShop(UM, PS, ship, fuel, PI, shop);

            if (response == 4) 
                 Market(PS, UM, ship, fuel, PI);

            if (response == 5) 
               EarthPort(ship, UM, PS, fuel, PI, LP, shop, Asgard, M63, Earth, AlphaCentari, SY, GO);

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
                Sell(UM, PS, ship, fuel, PI, Shop);
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
                $"\tYou have {PS.Cash()} Galactic Credits, what good would you like to buy?\n" +
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
        public void Sell(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI, Shop Shop)
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
                Shop.SellShoes(PI.EarthNoBalanceShoes, PS, UM, ship, fuel);
            }
            
            if (response == 2)
            {
                Shop.SellGold(PI.EarthSpaceGold, PS, UM, ship, fuel);
            }
            if (response == 3)
            {
                Shop.SellTV(PI.EarthGalacticTVs, PS, UM, ship, fuel);
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

        public void EarthPort(Ship ship, UtilityMethods UM, PersonalStatus PS, Fuel fuel, PlanetInfo PI, LandingPage LP, Shop shop, Asgard Asgard, M63 M63, Earth Earth, AlphaCentari AlphaCentari, ShipYard SY, GameOver GO)
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
            if (UM.FuelCheck(PI.EarthXPosition, PI.AsgardXPosition, PI.EarthYPosition, PI.AsgardYPosition, ship, PS, fuel) == "OK")
                Console.WriteLine($"" +
                    $"\t\t<titan> Titan: {UM.PlanetDistance(PI.EarthXPosition, PI.TitanXPosition, PI.EarthYPosition, PI.TitanYPosition)} Light years away which will take {UM.PlanetDistance(PI.EarthXPosition, PI.TitanXPosition, PI.EarthYPosition, PI.TitanYPosition) / playerWarpSpeed} years\n");


            Console.WriteLine($"" +
                $"\t\t<return> Return to earth");
            string response = Console.ReadLine();
            if (response == "titan" || response == "Titan")
            {
                if (UM.FuelCheck(PI.EarthXPosition, PI.TitanXPosition, PI.EarthYPosition, PI.TitanYPosition, ship, PS, fuel) == "OK")
                {
                    UM.PlanetTravel(PI.EarthXPosition, PI.TitanXPosition, PI.EarthYPosition, PI.TitanYPosition, ship, PS, fuel);
                    UM.Travel(PS);
                    PS.LocationChanger("Titan");
                    LP.LandingPagePicker(LP, shop, SY, GO, PS, UM, ship, PI, fuel, Asgard, Earth, AlphaCentari, M63);
                }
                if (UM.FuelCheck(PI.EarthXPosition, PI.TitanXPosition, PI.EarthYPosition, PI.TitanYPosition, ship, PS, fuel) == "TooFar")
                {
                    UM.TooFar(PI.EarthXPosition, PI.TitanXPosition, PI.EarthYPosition, PI.TitanYPosition, fuel);
                    return;
                }
            }

            if (response == "centari")
            {
                if (UM.FuelCheck(PI.EarthXPosition, PI.AlphaCentariXPosition, PI.EarthYPosition, PI.AlphaCentariYPosition, ship, PS, fuel) == "OK")
                {
                    UM.PlanetTravel(PI.EarthXPosition, PI.AlphaCentariXPosition, PI.EarthYPosition, PI.AlphaCentariYPosition, ship, PS, fuel);
                    UM.Travel(PS);
                    PS.LocationChanger("AlphaCentari");
                    LP.LandingPagePicker(LP, shop, SY, GO, PS, UM, ship, PI, fuel, Asgard, Earth, AlphaCentari, M63);
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
                    PS.LocationChanger("M63");
                    LP.LandingPagePicker(LP, shop, SY, GO, PS, UM, ship, PI, fuel, Asgard, Earth, AlphaCentari, M63);
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
                    PS.LocationChanger("Asgard");
                    LP.LandingPagePicker(LP, shop, SY, GO, PS, UM, ship, PI, fuel, Asgard, Earth, AlphaCentari, M63);
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
    }
}
