﻿using System;
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
            Console.Write("                  D U K E                  \n" +
                "                    O F                    \n" +
                "               M E R C U R Y               \n" +
                "  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n" +
                " |  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|\n" +
                " | |             _____________            ||\n" +
                " | |            / _    \\    \\ \\           ||\n" +
                " | |           / /#\\    \\    \\ \\__        ||\n" +
                " | |          | |##|    |    | |##\\       ||\n" +
                " | |#####     | |##|    |    | |###\\      ||\n" +
                " | |######   _|_|##|____|____|_|####\\     ||\n" +
                " | |#######<| | //\\ | /\\\\ CAMEL      |    ||\n" +
                " | |#######<|_|||  \\|/ ||____________|    ||\n" +
                " | |######     ||  /*\\ ||                 ||\n" +
                " | |#####       \\\\/_|_\\//                 ||\n" +
                " | |             -------                  ||\n" +
                " | |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~||\n" +
                " |_~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|\n\n" +
                "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nHello, welcome to Duke Of Mercury!\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n" +
                " What is your name? ");

            //user name

            PersonalStatus PS = new PersonalStatus();
            string yourName = Console.ReadLine();
            PS.MyCurrentCredit = 300;
            //clears the text
            Console.Clear();

            //add story here
            Console.WriteLine($"Okay, {yourName}. You were engaged to Venusian royalty but the king of Venus has forbidden your beloved \nto marry a mere commoner like yourself." +
                $" But there is even worse news! \nYour beloved has other interested parties, and what's worse is they are already nobility. \nBut you are in luck" +
                $" there is a way to buy into galactic nobility, but it's going to be a lot of work. \nYou've got a {PS.ShipName} class ship and {PS.MyCurrentCredit} Galactic Credits, so get out there and get to trading {yourName}!\n" +
                $"Press any key to contiue...");

            Console.ReadLine();

            //clear code
            Console.Clear();

            //add instructions here
            Console.WriteLine();
            //creating new instance of Earth Class
            var Earth = new Earth();


            
            
        }
        
        #endregion


    }
}
