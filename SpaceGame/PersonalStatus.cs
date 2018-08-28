using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class PersonalStatus
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public PersonalStatus()
        {
            //user current credit
            this.MyCurrentCredit = 300;

            //user current travel time
            this.MyTravelTime = 0;


            //current quantity values
            this.SpaceGold = 0;

            this.NoBalanaceShoes = 0;

            this.GalacticTVs = 0;


            //Camel ship
            this.ShipCapacity = 5;

            this.ShipName = "Camel";

            this.ShipSpeed = 5;


            //Interstellar connex ship
            this.InterstellarConnexCapacity = 10;

            this.InterstellarConnexSpeed = 4;

            this.InterstellarConnexCost = 600;

            //StarWagon Ship
            this.StarWagonCapacity = 6;

            this.StarWagonSpeed = 8;

            this.StarWagonCost = 1200;


            //user info
            this.MyName = "Trader";


            //cost on earth
            this.EarthSpaceGold = 100;

            this.EarthNoBalanceShoes = 80;

            this.EarhtGalacticTVs = 120;



            //cost on alphaC
            this.AlphaCentariGalacticTVs = 100;

            this.AlphaCentariGold = 150;

            this.AlphaCentariNoBalanceShoes = 65;


            //cost on M63
            this.M63GalacticTVs = 140;

            this.M63NoBalanceShoes = 100;

            this.M63SpaceGold = 60;


            //Earth Location
            this.EarthXPosition = 0;

            this.EarthYPosition = 0;


            //AlphaC Location
            this.AlphaCentariXPosition = 0;

            this.AlphaCentariYPosition = -4.37;


            //M63 Location
            this.M63XPosition = 6;

            this.M63YPosition = 4;

            

        }
        public double MyLocation { get; set; }



        /// <summary>
        /// Personal Info
        /// </summary>
        public int MyCurrentCredit { get; set; }

        public string MyName { get; set; }

        public double MyTravelTime { get; set; }

        public string MyCurrentLocation { get; set; }

       



        /// <summary>
        /// Camel
        /// </summary>
        public string ShipName { get; set; }

        public int ShipSpeed { get; set; }

        public int ShipCapacity { get; set; }



        /// <summary>
        /// InterstellarConnex Specs
        /// </summary>
        public int InterstellarConnexSpeed { get; set; }

        public int InterstellarConnexCapacity { get; set; }

        public int InterstellarConnexCost { get; set; }

        /// <summary>
        /// StarWagon Specs
        /// </summary>
        public int StarWagonSpeed { get; set; }

        public int StarWagonCapacity { get; set; }

        public int StarWagonCost { get; set; }


        /// <summary>
        /// cargo
        /// </summary>
        public int SpaceGold { get; set; }
        public int EarthSpaceGold { get; private set; }
        public int AlphaCentariGold { get; private set; }
        public int M63SpaceGold { get; private set; }

        public int NoBalanaceShoes { get; set; }
        public int EarthNoBalanceShoes { get; private set; }
        public int AlphaCentariNoBalanceShoes { get; private set; }
        public int M63NoBalanceShoes { get; private set; }

        public int GalacticTVs { get; set; }
        public int EarhtGalacticTVs { get; private set; }
        public int AlphaCentariGalacticTVs { get; private set; }
        public int M63GalacticTVs { get; private set; }

        /// <summary>
        /// planetary positions
        /// </summary>
        public double EarthXPosition { get; private set; }
        public double EarthYPosition { get; private set; }
        public double AlphaCentariXPosition { get; private set; }
        public double AlphaCentariYPosition { get; private set; }
        public double M63XPosition { get; private set; }
        public double M63YPosition { get; private set; }










    }
}
