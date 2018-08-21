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
        public void EarthPage()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Earth! Where would you like to go? \n" +
                "1. Ship Yard \n" +
                "2. Galactic Bank \n" +
                "3. Buy, Sell, Trade \n" +
                "4. Galactic Market\n" +
                "5. Departure Port");
            try
            {
                SelectEarthOptions();
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input, try again! Press any key to continue.");
                Console.ReadLine();
                EarthPage();
            }
            // add exception for invalid answer


        }
        public void SelectEarthOptions()
        {
            int response = Convert.ToInt32(Console.ReadLine());
            bool shipYard = response == 1;
            bool galacticBank = response == 2;
            bool shop = response == 3;
            bool market = response == 4;
            bool port = response == 5;
            if (shipYard) ;
            //  ShipYard();
            if (galacticBank) ;
            //   GalacticBank();
            if (shop) ;
            //   Shop();
            if (market) ;
            //   Market();
            if (port) ;
            //   Port();
            else
            {
                Console.WriteLine("invalid entry");
                EarthPage();
            }

        }
        #endregion
    }
}
