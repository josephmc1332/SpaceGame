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
            UtilityMethods UM, Ship ship, PlanetInfo PI, Fuel fuel, Asgard Asgard, Earth Earth, 
            AlphaCentari AlphaCentari, M63 M63, PlanetX PlanetX, Titan Titan, PlanetJoe planetJoe, Vormir vormir, Picium Picium)


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
            SelectEarthOptions(LP, Shop, SY, GO, PS, UM, ship, PI, fuel, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan, planetJoe, vormir, Picium);



        }
        public void SelectEarthOptions(LandingPage LP, Shop shop, ShipYard SY, GameOver GO, PersonalStatus PS, UtilityMethods UM, 
            Ship ship, PlanetInfo PI, Fuel fuel, Asgard Asgard, Earth Earth, 
            AlphaCentari AlphaCentari, M63 M63, PlanetX PlanetX, Titan Titan, PlanetJoe planetJoe, Vormir vormir, Picium Picium)
        {
            //convert/parse user input string 
            try
            {
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
                    EarthPort(ship, UM, PS, fuel, PI, LP, shop, Asgard, M63, Earth, AlphaCentari, SY, GO, PlanetX, Titan, planetJoe, vormir, Picium);

                if (response == 9)
                    GO.EndScreen(PS, ship);

                else
                {
                    //loops back to the beginning of earth page
                    Console.WriteLine("invalid entry");
                    return;
                }
            }
            catch
            {
                Console.WriteLine("Invalid Entry, try again");
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
            try
            {
                int response = Convert.ToInt32(Console.ReadLine());
                if (response == 1)
                    SY.ShipCheck(PS, ship, UM, fuel);
                if (response == 2)
                    SY.PurchaseShip(PS, ship, UM, fuel);
                if (response == 3)
                    return;
            }
            catch
            {
                Console.WriteLine("Invalid Entry, try again");
                return;
            }
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
            try
            {
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
            catch
            {
                Console.WriteLine("Invalid Entry, try again");
                return;
            }
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
            try
            {
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

                if (response == 3)
                {
                    Shop.BuyTV(PI.EarthGalacticTVs, PS, UM, ship, fuel);
                }

                if (response == 4)
                {
                    return;
                }
            }
            catch
            {
                Console.WriteLine("Invalid Entry, try again");
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
            try
            {
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
            catch
            {
                Console.WriteLine("Invalid Entry, try again");
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

        public void EarthPort(Ship ship, UtilityMethods UM, PersonalStatus PS, Fuel fuel, PlanetInfo PI, LandingPage LP, Shop shop, Asgard Asgard, M63 M63, Earth Earth, AlphaCentari AlphaCentari, ShipYard SY, GameOver GO, PlanetX PlanetX, Titan Titan, PlanetJoe planetJoe, Vormir vormir, Picium Picium)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);

            string response = UM.PortMenu(PI.EarthXPosition, PI.EarthYPosition, UM, PS, ship, fuel, PI);

            
            if (response == "titan" || response == "Titan")
            {
                UM.PortTravel(PI.EarthXPosition, PI.TitanXPosition, PI.EarthYPosition, PI.TitanYPosition, "Titan", UM, PS, fuel, ship, PI, shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan, planetJoe, vormir, Picium);
            }

            if (response == "centari")
            {
                UM.PortTravel(PI.EarthXPosition, PI.AlphaCentariXPosition, PI.EarthYPosition, PI.AlphaCentariYPosition, "AlphaCentari", UM, PS, fuel, ship, PI, shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan, planetJoe, vormir, Picium);
            }
            if (response == "m63")
            {
                UM.PortTravel(PI.EarthXPosition, PI.M63XPosition, PI.EarthYPosition, PI.M63YPosition, "M63", UM, PS, fuel, ship, PI, shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan, planetJoe, vormir, Picium);
            }
            if (response == "asgard")
            {
                UM.PortTravel(PI.EarthXPosition, PI.AsgardXPosition, PI.EarthYPosition, PI.AsgardYPosition, "Asgard", UM, PS, fuel, ship, PI, shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan, planetJoe, vormir, Picium);
            }
            if (response == "x")
            {
                UM.PortTravel(PI.EarthXPosition, PI.PlanetXXPosition, PI.EarthYPosition, PI.PlanetXYPosition, "Planet X", UM, PS, fuel, ship, PI, shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan, planetJoe, vormir, Picium);
            }
            
            if (response == "joe")
            {
                UM.PortTravel(PI.EarthXPosition, PI.PlanetJoeXPosition, PI.EarthYPosition, PI.PlanetJoeYPosition, "Planet Joe", UM, PS, fuel, ship, PI, shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan, planetJoe, vormir, Picium);
            }
            if (response == "vormir")
            {
                UM.PortTravel(PI.VormirXPosition, PI.PlanetXXPosition, PI.VormirYPosition, PI.PlanetXYPosition, "Vormir", UM, PS, fuel, ship, PI, shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan, planetJoe, vormir, Picium);
            }
            if (response == "picium")
            {
                UM.PortTravel(PI.EarthXPosition, PI.PiciumXPosition, PI.EarthYPosition, PI.PiciumYPosition, "Picium", UM, PS, fuel, ship, PI, shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan, planetJoe, vormir, Picium);
            }
            if (response == "return")
            {
                return;
            }
        }

        #endregion
    }
}
