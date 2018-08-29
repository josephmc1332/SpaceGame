using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class ShipYard
    {
        public void PurchaseShip(PersonalStatus PS, Ship ship, UtilityMethods UM, Fuel fuel)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            //display the users current ship and credits. Ship selections with price
            Console.WriteLine($"\n\n" +
                $"\tYou currently own the {ship.ShipName}, which is a great ship, but it's time to upgrade... \n" +
                $"\tWhat ship are you looking to hop in today?\n" +
                $"\tYou currently have {PS.MyCurrentCredit} credits\n" +
                $"\t  1 The Interstellar Connex 600 GCs\n" +
                $"\t  2 The StarWagon 1200GCs");
            //convert response to numeric value of type int
            int shipUpgrade = Convert.ToInt32(Console.ReadLine());
            //If buying the interstellar
            if (shipUpgrade == 1 && PS.MyCurrentCredit >= 600)
            {
                string myShipUpgrade = "The Interstellar Connex";
                Console.Clear();
                Console.WriteLine($"You chose the {myShipUpgrade}! That's a great choice. \n" +
                   $"It has a capacity of {ship.InterstellarConnexCapacity} slots. This is our biggest ship! " +
                   $"\nWith a max warp speed of" +
                   $" {ship.InterstellarConnexSpeed}. ");
                Console.ReadLine();
                //ask if user is sure of purchase
                Console.WriteLine("Would you like to complete this purchase? \nyes or no?");
                //user response 
                string userShipAnswer = Console.ReadLine();
                //execute the purchase
                if (userShipAnswer == "yes")
                {
                    ship.ShipSpeed = ship.InterstellarConnexSpeed;
                    ship.ShipCapacity = ship.InterstellarConnexCapacity;
                    ship.ShipName = myShipUpgrade;
                    //subtract credit after purchase
                    PS.MyCurrentCredit = PS.MyCurrentCredit - 600;
                    //display ship bought and remaining credit
                    Console.WriteLine($"Congratulations on your new ship purchase! " +
                        $"You now own the {ship.ShipName} and have {PS.MyCurrentCredit} remaining");
                    Console.ReadLine();
                    return;
                }
                //stop the purchase
                else
                {
                    return;
                }
            }
            //stop purchase. not enough credits
            if (shipUpgrade == 1 && PS.MyCurrentCredit < 600)
            {
                Console.WriteLine("You do not have enough credits to complete this purchase!");
                Console.ReadLine();
                return;

            }
            //if buying the starwagon
            if (shipUpgrade == 2 && PS.MyCurrentCredit >= 1200)
            {
                //initialize ship 
                string myShipUpgrade = "The StarWagon";
                Console.Clear();
                //summary of ship(speed, name, and capacity)
                Console.WriteLine($"\n\n" +
                    $"\tYou chose the {myShipUpgrade}! That's a great choice. \n" +
                    $"\tIt has a capacity of {ship.StarWagonCapacity} slots.\n" +
                    $"\tWith a max warp speed of {ship.StarWagonSpeed}. This is our fastest ship by far!");
                //press enter
                Console.ReadLine();
                //confirm purchase
                Console.WriteLine("\n\nWould you like to complete this purchase? \nyes or no?");
                string userShipAnswer = Console.ReadLine();
                //after purchase is confirmed subtract credits
                if (userShipAnswer == "yes")
                {
                    ship.ShipName = myShipUpgrade;
                    ship.ShipCapacity = ship.StarWagonCapacity;
                    ship.ShipSpeed = ship.StarWagonSpeed;
                    PS.MyCurrentCredit = PS.MyCurrentCredit - 1200;
                    //display ship purchased and remaining credits
                    Console.Clear();
                    Console.WriteLine($"Congratulations on your new ship purchase! You now own the {ship.ShipName} " +
                        $"\nand have {PS.MyCurrentCredit} credits remaining");
                    Console.ReadLine();
                    return;
                }
                //stop purchase
                else
                {
                    return;
                }
            }
            //stop purchase
            if (shipUpgrade == 2 && PS.MyCurrentCredit < 1200)
            {
                Console.WriteLine("You do not have enough credits to complete this purchase!");
                Console.ReadLine();
                return;
            }
        }
        public void ShipCheck(PersonalStatus PS, Ship ship, UtilityMethods UM, Fuel fuel)
        {
            Console.Clear();
            UM.InventoryDisplay(PS, ship, fuel);
            Console.WriteLine($"\n\n" +
                $"\tYou arrive at your personal hanger, you ship, a {ship.ShipName} the SS {PS.MyName}, stands \n" +
                $"\tbefore you gleaming in the artificail lights of the hanger. \n" +
                $"\tA {ship.ShipName} like this has {ship.ShipCapacity} slots in its cargo hold \n" +
                $"\tand a top speed of Warp Factor {ship.ShipSpeed}\n" +
                $"\tInside the hold you have: \n" +
                $"\t{PS.NoBalanaceShoes} boxes of No Balance Shoes \n" +
                $"\t{PS.SpaceGold} bars of Space Gold \n" +
                $"\t{PS.GalacticTVs} boxes of Galactic TVs\n\n" +
                $"\t\tPress enter to continue...");
            Console.ReadLine();
            return;
        }
    }
}
