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



        }
        #endregion



    }
}
