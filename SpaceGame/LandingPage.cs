﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class LandingPage
    {
        Shop Shop = new Shop();
        ShipYard SY = new ShipYard();
        GameOver GO = new GameOver();
        PersonalStatus PS = new PersonalStatus();
        UtilityMethods UM = new UtilityMethods();
        Ship ship = new Ship();
        PlanetInfo PI = new PlanetInfo();
        Fuel fuel = new Fuel();
        Asgard Asgard = new Asgard();
        Earth Earth = new Earth();
        LandingPage LP;

        // quick list of all the class declerations
        // LandingPage LP, Shop Shop, ShipYard SY, GameOver GO, PersonalStatus PS, UtilityMethods UM, Ship ship, PlanetInfo PI, Fuel fuel, Asgard Asgard, Earth Earth 
        //LP, Shop, SY, GO, PS, UM, ship, PI, fuel, Asgard, Earth
        public void FirstPage()
        {
            Console.Write("\n\n\n" +
                "\t\t\t\t                  D U K E                  \n" +
                "\t\t\t\t                    O F                    \n" +
                "\t\t\t\t               M E R C U R Y               \n" +
                "\t\t\t\t  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n" +
                "\t\t\t\t |  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|\n" +
                "\t\t\t\t | |   .      .  _____________  .     *   ||\n" +
                "\t\t\t\t | |     *      / _    \\    \\ \\  .        ||\n" +
                "\t\t\t\t | |  .        / /#\\    \\    \\ \\__    *   ||\n" +
                "\t\t\t\t | |    .  *  | |##|    |    | |##\\       ||\n" +
                "\t\t\t\t | |#####     | |##|    |    | |###\\      ||\n" +
                "\t\t\t\t | |######   _|_|##|____|____|_|####\\     ||\n" +
                "\t\t\t\t | |#######<| | //\\ | /\\\\    CAMEL   |    ||\n" +
                "\t\t\t\t | |#######<|_|||  \\|/ ||____________|    ||\n" +
                "\t\t\t\t | |######   . ||  /*\\ ||     * .    *    ||\n" +
                "\t\t\t\t | |#####  .    \\\\/_|_\\//                 ||\n" +
                "\t\t\t\t | |   *     .   -------     .     *    . ||\n" +
                "\t\t\t\t | |~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~||\n" +
                "\t\t\t\t |_~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|\n\n" +
                "\t\t\t\t  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~" +
                "\n\t\t\t\t    Hello, welcome to Duke Of Mercury!\n" +
                "\t\t\t\t  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n" +
                "\t\t\t\t\t   What is your name? ");

            //Setting the starting stats

            PS.MyName = Console.ReadLine();

            PS.MyCurrentCredit = 300;

            PS.MyCurrentLocation = "Earth";

            //clears the text
            Console.Clear();

            //add story here
            Console.WriteLine($"\n\n\n\n" +
                $"\t\tOkay, {PS.MyName}. You were engaged to Venusian royalty but the king of Venus has forbidden your beloved \n" +
                $"\t\tto marry a mere commoner like yourself. But there is even worse news! \n" +
                $"\t\tYour beloved has other interested parties, and what's worse is they are already nobility. \n" +
                $"\t\tBut you are in luck there is a way to buy into galactic nobility, but it's going to be a lot of work. \n" +
                $"\t\tYou've got a {ship.ShipName} class ship and {PS.MyCurrentCredit} Galactic Credits, \n" +
                $"\t\tso get out there and get to trading, {PS.MyName}!\n\n" +
                $"\n\n\n\n\n\n\n\n\t\t\tPress enter to continue past this or any screen in this game.");

            Console.ReadLine();
        }

        public void LandingPagePicker()
        {
            if (PS.MyCurrentLocation == "Earth")
                Earth.EarthPage(LP, Shop, SY, GO, PS, UM, ship, PI, fuel, Asgard, Earth);
            if (PS.MyCurrentLocation == "AlphaCentari")
                Earth.AlphaCentariPage(LP, Shop, SY, GO, PS, UM, ship, PI, fuel, Asgard, Earth);
            if (PS.MyCurrentLocation == "M63")
                Earth.M63Page(LP, Shop, SY, GO, PS, UM, ship, PI, fuel, Asgard, Earth);
            if (PS.MyCurrentLocation == "Asgard")
                Asgard.AsgardPage(LP, Shop, SY, GO, PS, UM, ship, PI, fuel, Asgard, Earth);
            LandingPagePicker();
        }

    }
}
