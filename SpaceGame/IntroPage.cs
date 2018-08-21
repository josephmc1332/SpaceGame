using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class IntroPage
    {
                
        #region FirstPage
        /// <summary>
        /// This will be the first page for the application
        /// </summary>
        public void FirstPage()
        {
            //ask user for name
            Console.WriteLine("Hello, welcome to Space Game!\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n" +
                " What is your name?");

            //user name
            string yourName = Console.ReadLine();

            //clear code
            Console.Clear();
            //
            var PersonalStatus = new PersonalStatus();

            PersonalStatus.MyCurrentCredit = 300;

            //add story here
            Console.WriteLine($"Okay, {yourName}. You were engaged to Venusian royalty but the king has forbidden your beloved \nto marry a mere commoner like yourself." +
                $" But there is even worse news! \nYour beloved has other interested parties, and what's worse is they are already nobility. \nBut you are in luck" +
                $" there is a way to buy into galactic nobility, but it's going to be a lot of work, \nso get out there and get to trading {yourName}!");

            Console.ReadLine();

            //clear code
            Console.Clear();

            //add instructions here
            Console.WriteLine();
            //creating new instance of Earth Class
            var Earth = new Earth();

            Earth.EarthPage();

        }
        #endregion


    }
}
