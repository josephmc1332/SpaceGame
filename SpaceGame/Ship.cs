using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Ship
    {
        /// <summary>
        /// Current ship specs
        /// </summary>
        public string ShipName { get; set; }

        public int ShipSpeed { get; set; }

        public int ShipCapacity { get; set; }

        public int ShipFuelMax { get; set; }

        


        /// <summary>
        /// Camel specs
        /// </summary>
        public int CamelSpeed { get; set; }

        public int CamelCapacity { get; set; }

        public int CamelCost { get; set; }

        public int CamelFuelMax { get; set; }

        /// <summary>
        /// InterstellarConnex Specs
        /// </summary>
        public int InterstellarConnexSpeed { get; set; }

        public int InterstellarConnexCapacity { get; set; }

        public int InterstellarConnexCost { get; set; }

        public int InterstellarFuelMax { get; set; }

        /// <summary>
        /// StarWagon Specs
        /// </summary>
        public int StarWagonSpeed { get; set; }

        public int StarWagonCapacity { get; set; }

        public int StarWagonCost { get; set; }

        public int StarWagonFuelMax { get; set; }

        /// <summary>
        /// constructor
        /// </summary>
        public Ship()
        {
            //current ship
            this.ShipCapacity = 5;

            this.ShipName = "Camel";

            this.ShipSpeed = 5;

            this.ShipFuelMax = 10;

           



            //Camel
            this.CamelCapacity = 5;

            this.CamelSpeed = 5;

            this.CamelCost = 0;

            this.CamelFuelMax = 10;

            //Interstellar connex ship
            this.InterstellarConnexCapacity = 10;

            this.InterstellarConnexSpeed = 4;

            this.InterstellarConnexCost = 600;

            this.InterstellarFuelMax = 30;

            //StarWagon Ship
            this.StarWagonCapacity = 6;

            this.StarWagonSpeed = 8;

            this.StarWagonCost = 1200;

            this.StarWagonFuelMax = 50;

        }




    }








}

