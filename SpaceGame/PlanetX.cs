using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class PlanetX
    {
        //PersonalStatus PS = new PersonalStatus();

        public void PlanetXPage(LandingPage LP, Shop Shop, ShipYard SY, GameOver GO, PersonalStatus PS,
            UtilityMethods UM, Ship ship, PlanetInfo PI, Fuel fuel, Asgard Asgard, Earth Earth, 
            AlphaCentari AlphaCentari, M63 M63, PlanetX PlanetX, Titan Titan, PlanetJoe planetJoe, Vormir vormir, Picium Picium)
        {
            PS.LocationChanger("Planet X");



            Console.Clear();
            //display menu on earth upon arrival
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine("\n\n" +
                "\tWelcome to Planet X! Not a lot of beings know we exist, but you are lucky\n" +
                "\tto have found our planet. There is truly no greater honor than walking the\n" +
                "\tRuberian Colloseum and feeling the spirits of the elite warriors that have\n" +
                "\tbattled to lifes end. We are home to the universe's most lethal gladiators, \n" +
                "\tand our vast wealth and prosperity is proof of that." +
               "\n\t\t1. ShipYard" +
               "\n\t\t2. Galactic Bank" +
               "\n\t\t3. Buy, Sell, Trade" +
               "\n\t\t4. Galactic Market" +
               "\n\t\t5. Departure Port" +
               "\n\t\t9. Quit Game");


            //send back to check selected option after invalid input
            try
            {
                SelectPlanetXOptions(LP, Shop, SY, GO, PS, UM, ship, PI, fuel, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan, planetJoe, vormir, Picium);
            }

            //display if invalid input
            catch (Exception)
            {
                Console.WriteLine("Invalid input, try again! Press any key to continue.");
                Console.ReadLine();

                //recycle to Welcome to planet x after invalid entry  
                PlanetXPage(LP, Shop, SY, GO, PS, UM, ship, PI, fuel, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan, planetJoe, vormir, Picium);
            }

        }

        public void SelectPlanetXOptions(LandingPage LP, Shop shop, ShipYard SY, GameOver GO, PersonalStatus PS, UtilityMethods UM, 
            Ship ship, PlanetInfo PI, Fuel fuel, Asgard asgard, Earth earth, AlphaCentari AlphaCentari, M63 M63, PlanetX PlanetX, 
            Titan Titan, PlanetJoe planetJoe, Vormir vormir, Picium Picium)
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
                    PlanetXShop(UM, PS, ship, fuel, PI, shop);

                if (response == 4)
                    Market(PS, UM, ship, fuel, PI);

                if (response == 5)
                    PlanetXPort(ship, UM, PS, fuel, PI, earth, LP, shop, SY, GO, asgard, AlphaCentari, M63, PlanetX, Titan, planetJoe, vormir, Picium);

                if (response == 9)
                    GO.EndScreen(PS, ship);

                else
                {
                    //loops back to the beginning of planet x page page
                    Console.WriteLine("invalid entry");
                    PlanetXPage(LP, shop, SY, GO, PS, UM, ship, PI, fuel, asgard, earth, AlphaCentari, M63, PlanetX, Titan, planetJoe, vormir, Picium);
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

        public void PlanetXShop(UtilityMethods UM, PersonalStatus PS, Ship ship, Fuel fuel, PlanetInfo PI, Shop shop)
        {

            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine("Welcome to Masterons, my name is Liam. What can I get for you today?");
            try
            {
                int response = UM.ShopSelector();
                if (response == 1)
                    Buy(UM, PS, ship, fuel, PI, shop);
                if (response == 2)
                    Sell(UM, PS, ship, fuel, PI, shop);
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
                    Shop.BuyShoes(PI.PlanetXNoBalanceShoes, PS, UM, ship, fuel);
                }
                //Buy Gold
                if (response == 2)
                {
                    Shop.BuyGold(PI.PlanetXGold, PS, UM, ship, fuel);
                }

                if (response == 3)
                {
                    Shop.BuyTV(PI.PlanetXGalacticTVs, PS, UM, ship, fuel);
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
                    Shop.SellShoes(PI.PlanetXNoBalanceShoes, PS, UM, ship, fuel);
                }

                if (response == 2)
                {
                    Shop.SellGold(PI.PlanetXGold, PS, UM, ship, fuel);
                }
                if (response == 3)
                {
                    Shop.SellTV(PI.PlanetXGalacticTVs, PS, UM, ship, fuel);
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
                "\tThe Ruberian Market is full of galactic TVs displaying the trends of the universe. " +
                "\n\tYou push your way through the crowd of people watching and betting on the current battle " +
                "\n\tto get a good view of the current universe market prices... ");
            UM.MarketDisplay(PI);

            Console.ReadLine();
        }
        ///NOT DONE NEED TO FIT IN PLANET X
        public void PlanetXPort(Ship ship, UtilityMethods UM, PersonalStatus PS, Fuel fuel, PlanetInfo PI, Earth Earth, 
            LandingPage LP, Shop shop, ShipYard SY, GameOver GO,
            Asgard Asgard, AlphaCentari AlphaCentari, M63 M63, PlanetX PlanetX, Titan Titan, PlanetJoe planetJoe, Vormir vormir, Picium Picium)
        {
            double playerWarpSpeed = (Math.Pow(ship.ShipSpeed, 10 / 3) + Math.Pow(10 - ship.ShipSpeed, -11 / 3));
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);

            string response = UM.PortMenu(PI.PlanetXXPosition, PI.PlanetXYPosition, UM, PS, ship, fuel, PI);

            
            if (response == "centari")
            {
                UM.PortTravel(PI.PlanetXXPosition, PI.AlphaCentariXPosition, PI.PlanetXYPosition, PI.AlphaCentariYPosition, "AlphaCentari", UM, PS, fuel, ship, PI, shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan, planetJoe, vormir, Picium);
            }
            if (response == "m63")
                {
                UM.PortTravel(PI.PlanetXXPosition, PI.M63XPosition, PI.PlanetXYPosition, PI.M63YPosition, "M63", UM, PS, fuel, ship, PI, shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan, planetJoe, vormir, Picium);
            }
            if (response == "asgard")
                {
                UM.PortTravel(PI.PlanetXXPosition, PI.AsgardXPosition, PI.PlanetXYPosition, PI.AsgardYPosition, "Asgard", UM, PS, fuel, ship, PI, shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan, planetJoe, vormir, Picium);
            }
            if (response == "earth")
                {
                UM.PortTravel(PI.PlanetXXPosition, PI.EarthXPosition, PI.PlanetXYPosition, PI.EarthYPosition, "Earth", UM, PS, fuel, ship, PI, shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan, planetJoe, vormir, Picium);
            }
            if (response == "picium")
            {
                UM.PortTravel(PI.PlanetXXPosition, PI.PiciumXPosition, PI.PlanetXYPosition, PI.PiciumYPosition, "Picium", UM, PS, fuel, ship, PI, shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan, planetJoe, vormir, Picium);
            }
            if (response == "joe")
            {
                UM.PortTravel(PI.PlanetXXPosition, PI.PlanetJoeXPosition, PI.PlanetXYPosition, PI.PlanetJoeYPosition, "Planet Joe", UM, PS, fuel, ship, PI, shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan, planetJoe, vormir, Picium);
            }
            if (response == "titan")
            {
                UM.PortTravel(PI.PlanetXXPosition, PI.TitanXPosition, PI.PlanetXYPosition, PI.TitanYPosition, "Titan", UM, PS, fuel, ship, PI, shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan, planetJoe, vormir, Picium);
            }
            if (response == "vormir")
            {
                UM.PortTravel(PI.PlanetXXPosition, PI.VormirXPosition, PI.PlanetXYPosition, PI.VormirYPosition, "Vormir", UM, PS, fuel, ship, PI, shop, SY, LP, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan, planetJoe, vormir, Picium);
            }
            if (response == "return")
                    {
                        return;
                    }
                
            
        }
    }
}