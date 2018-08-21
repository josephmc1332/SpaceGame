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
                //loops back to the beginning of earth page
                Console.WriteLine("invalid entry");
                EarthPage();
            }



        }
        #endregion
    }
}
