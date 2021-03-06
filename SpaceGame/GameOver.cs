﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class GameOver
    {
        #region EndPage
        public void EndScreen(PersonalStatus ps, Ship ship)
        {
            Console.Clear();
            Console.WriteLine($"\n\n\n\n\n\n" +
                $"\n\t\t\t\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~" +
                $"\n\t\t\t\t              Game Over" +
                $"\n\t\t\t\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~" +
                $"\n\n\t\t\tYou had {ps.Cash()} Galactic Credits at theR end of your journey" +
                $"\n\t\t\tYou traveled for {ps.TravelAge()} years total" +
                $"\n\t\t\tYou had a {ship.ShipName} class ship\n\n\n" +
                $"\t\t\t              Thank you for playing\n\n\n" +
                $"\t\t\t\t Copyright 2018 The Space Game Company");
            Console.ReadLine();
            Console.WriteLine("Press 'alt+f4' to exit");
            Console.ReadLine();
            EndScreen(ps, ship);
        }
        public void Retire(PersonalStatus ps, Ship ship)
        {
            Console.WriteLine("\n\n\n\n" +
                "\t\tAs you prepare to depart, you realize that like LT Murtagh before you \n" +
                "\t\tyou are getting too old for this shiz and decide to retire.");
            Console.ReadLine();
            EndScreen(ps, ship);
        }
        public void Died(PersonalStatus ps, Ship ship)
        {
            Console.WriteLine($"\n\n\n\n" +
                $"\t\tYou have died. As is customary in Space you body is launched out into the inky blackness.\n" +
                $"\t\tThe admiral of the frigrate that performs the rite, with a tear in his eye, salutes 'Goodbye {ps.NameCall()}\n" +
                $"\t\tyou were one of the good ones...'");
            Console.ReadLine();
            EndScreen(ps, ship);
        }
        public void Win(PersonalStatus ps, Ship ship)
        {
            if (ps.Cash() > 1000000)
            {
                Console.WriteLine($"\n\n\n\n" +
                  $"\t\tYou cash in your million credits for favor and influence, \n" +
                  $"\t\tsoon you are whisked away on a golden chariot inside a golden spaceship. \n" +
                  $"\t\tIt's not long before you arrive at your beautiful new estate on Mercury. \n" +
                  $"\t\tThe days here are short and hot but it's all yours. Your new butler leads \n" +
                  $"\t\tyou inside 'Duke {ps.NameCall()} these are your new digs, and over here' he says \n" +
                  $"\t\tindicating a large banquet hall 'is where your big ceremony will be.' \n\n" +
                  $"\t\tYou marry your beloved and live happily ever after!\n" +
                  $"\t\tCongratulations! You won the game!");
                Console.ReadLine();
                EndScreen(ps, ship);
            }
        }
        #endregion
    }
}
