using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Titan
    {
        public void TitanPage(LandingPage LP, Shop Shop, ShipYard SY, GameOver GO, PersonalStatus PS,
           UtilityMethods UM, Ship ship, PlanetInfo PI, Fuel fuel, Asgard Asgard, Earth Earth)
        {
            PS.MyCurrentLocation = "Planet X";




            //display menu on earth upon arrival
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine("Welecome to Titan, "
               "\n1. ShipYard" +
               "\n2. Galactic Bank" +
               "\n3. Buy, Sell, Trade" +
               "\n4. Galactic Market" +
               "\n5. Departure Port" +
               "\n9. Quit Game");


            //send back to check selected option after invalid input
            try
            {
                SelectPlanetXOptions(LP, Shop, SY, GO, PS, UM, ship, PI, fuel, Asgard, Earth);
            }

            //display if invalid input
            catch (Exception)
            {
                Console.WriteLine("Invalid input, try again! Press any key to continue.");
                Console.ReadLine();

                //recycle to Welcome to planet x after invalid entry  
                PlanetXPage(LP, Shop, SY, GO, PS, UM, ship, PI, fuel, Asgard, Earth);
            }

        }

    }
}
