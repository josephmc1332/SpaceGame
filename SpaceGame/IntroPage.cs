using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Pages
    {
                
        #region FirstPage
        /// <summary>
        /// This will be the first page for the application
        /// </summary>
        public void FirstPage()
        {
            //ask user for name
            Console.WriteLine("Hello, welcome to Space Game!\n-----------------------------------\n" +
                " What is your name?");
            string yourName = Console.ReadLine();
            //clear code

            Console.Clear();


            //add story here
            Console.WriteLine($"Okay, {yourName} ");

            Console.ReadLine();

            //clear code
            Console.Clear();

            //add instructions here
            Console.WriteLine();

            EarthPage();

        }
        #endregion

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
                SelectPlanetOptions();
            }
            catch (exception)
            // add exception for invalid answer
            

        }
        public void SelectPlanetOptions()
        {
            int response = Convert.ToInt32(Console.ReadLine());
            bool shipYard = response == 1;
            bool galacticBank = response == 2;
            bool shop = response == 3;
            bool market = response == 4;
            bool port = response == 5;
            if (shipYard)
                ShipYard();
            if (galacticBank)
                GalacticBank();
            if (shop)
                Shop();
            if (market)
                Market();
            if (port)
                Port();
        }
        #endregion



    }
}
