using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Vormir
    {

        public void VormirPage(LandingPage LP, Shop Shop, ShipYard SY, GameOver GO, PersonalStatus PS,
            UtilityMethods UM, Ship ship, PlanetInfo PI, Fuel fuel, Asgard Asgard, Earth Earth, 
            AlphaCentari AlphaCentari, M63 M63, PlanetX PlanetX, Titan Titan, PlanetJoe planetJoe, Vormir vormir, Picium Picium)


        {

            //clear up window
            Console.Clear();

            //display menu on Vormir upon arrival
            PS.LocationChanger("Vormir");
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine("Welcome to the desolate planet of Vormir. Our treasures are vast and we are home to the unkown. \n" +
                "\tMany travel to this destination and few are able to make it out." +
                "\tIf you are pure of heart then you should have nothing to worry about. \n" +
                "\t\tWhere would you like to go? \n" +
                "\t\t  1. Ship Yard \n" +
                "\t\t  2. Galactic Bank \n" +
                "\t\t  3. Buy, Sell, Trade \n" +
                "\t\t  4. Galactic Market\n" +
                "\t\t  5. Departure Port\n\n" +
                "\t\t  9. Quit the Game");


            //send back to check selected option after invalid input
            SelectVormirOptions(LP, Shop, SY, GO, PS, UM, ship, PI, fuel, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan, planetJoe, vormir, Picium);
        }
        public void SelectVormirOptions(LandingPage LP, Shop shop, ShipYard SY, GameOver GO, PersonalStatus PS, UtilityMethods UM, 
            Ship ship, PlanetInfo PI, Fuel fuel, Asgard Asgard, Earth Earth, AlphaCentari AlphaCentari, M63 M63, 
            PlanetX PlanetX, Titan Titan, PlanetJoe planetJoe, Vormir vormir, Picium Picium)
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
                    VormirShop(UM, PS, ship, fuel, PI, shop);

                if (response == 4)
                    Market(PS, UM, ship, fuel, PI);

                if (response == 5)
                    VormirPort(ship, UM, PS, fuel, PI, LP, shop, Asgard, M63, Earth, AlphaCentari, SY, GO, PlanetX, Titan, planetJoe, vormir, Picium);

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

        public void VormirShop(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI, Shop Shop)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine("Welcome to the Infinity Shop. My name is Theos, I've owned this place for 3,000yrs. Seen the best of days here on Vormir \n" +
                "\tand I've seen the worst. Our goods remain throughout all the times. You can feel the history ever time you slip one a pair of our\n" +
                "\tlegendary NoBalance shoes. What would you like to do?" +
                "\t\t1. Buy\n" +
                "\t\t2. Sell\n" +
                "\t\t3. Get Fuel\n" +
                "\t\t4. Return");

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
                $"\t 1 NoBalanceShoes 300 GC per Unit\n" +
                $"\t 2 Space Gold 250 GC per Unit\n" +
                $"\t 3 Galactic TV 150 GC per Unit \n" +
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

        public void VormirPort(Ship ship, UtilityMethods UM, PersonalStatus PS, Fuel fuel, PlanetInfo PI, 
            LandingPage LP, Shop shop, Asgard Asgard, M63 M63, Earth Earth, AlphaCentari AlphaCentari, 
            ShipYard SY, GameOver GO, PlanetX PlanetX, Titan Titan, PlanetJoe planetJoe, Vormir vormir, Picium Picium)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);

            string response = UM.PortMenu(PI.VormirXPosition, PI.VormirYPosition, UM, PS, ship, fuel, PI);

            
            if (response == "titan" || response == "Titan")
            {
                UM.PortTravel(PI.VormirXPosition, PI.TitanXPosition, PI.VormirYPosition, PI.TitanYPosition, "Titan", UM, PS, fuel, ship, PI, shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan, planetJoe, vormir, Picium);
            }

            if (response == "centari")
            {
                UM.PortTravel(PI.VormirXPosition, PI.AlphaCentariXPosition, PI.VormirYPosition, PI.AlphaCentariYPosition, "AlphaCentari", UM, PS, fuel, ship, PI, shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan, planetJoe, vormir, Picium);
            }
            if (response == "m63")
            {
                UM.PortTravel(PI.VormirXPosition, PI.M63XPosition, PI.VormirYPosition, PI.M63YPosition, "M63", UM, PS, fuel, ship, PI, shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan, planetJoe, vormir, Picium);
            }
            if (response == "asgard")
            {
                UM.PortTravel(PI.VormirXPosition, PI.AsgardXPosition, PI.VormirYPosition, PI.AsgardYPosition, "Asgard", UM, PS, fuel, ship, PI, shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan, planetJoe, vormir, Picium);
            }
            if (response == "x")
            {
                UM.PortTravel(PI.VormirXPosition, PI.PlanetXXPosition, PI.VormirYPosition, PI.PlanetXYPosition, "Planet X", UM, PS, fuel, ship, PI, shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan, planetJoe, vormir, Picium);
            }
            if (response == "earth")
            {
                UM.PortTravel(PI.VormirXPosition, PI.EarthXPosition, PI.VormirYPosition, PI.EarthYPosition, "Earth", UM, PS, fuel, ship, PI, shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan, planetJoe, vormir, Picium);
            }
            if (response == "joe")
            {
                UM.PortTravel(PI.VormirXPosition, PI.PlanetJoeXPosition, PI.VormirYPosition, PI.PlanetJoeYPosition, "Planet Joe", UM, PS, fuel, ship, PI, shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan, planetJoe, vormir, Picium);
            }
            if (response == "picium")
            {
                UM.PortTravel(PI.VormirXPosition, PI.PiciumXPosition, PI.VormirYPosition, PI.PiciumYPosition, "Picium", UM, PS, fuel, ship, PI, shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan, planetJoe, vormir, Picium);
            }
            if (response == "return")
            {
                return;
            }
        }

    }
}