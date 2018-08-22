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
            this.MyCurrentCredit = 300;

            this.MyTravelTime = 0;

            this.SpaceGold = 0;

            this.NoBalanaceShoes = 0;

            this.GalacticTVs = 0;

            this.ShipCapacity = 5;

            this.ShipName = "Camel";

            this.ShipSpeed = 5;

            this.MyName = "Trader";

            this.EarthSpaceGold = 100;

            this.EarthNoBalanceShoes = 80;

            this.EarhtGalacticTVs = 120;

            this.AlphaCentariGalacticTVs = 100;

            this.AlphaCentariGold = 150;

            this.AlphaCentariNoBalanceShoes = 65;

            this.M63GalacticTVs = 140;

            this.M63NoBalanceShoes = 100;

            this.M63SpaceGold = 60;

        }




        /// <summary>
        /// Personal Info
        /// </summary>
        public int MyCurrentCredit { get; set; }

        public string MyName { get; set; }

        public int MyTravelTime { get; set; }

        public string MyCurrentLocation { get; set; }

       



        /// <summary>
        /// Ship Specs
        /// </summary>
        public string ShipName { get; set; }

        public int ShipSpeed { get; set; }

        public int ShipCapacity { get; set; }



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
        public int EarthXPosition { get; private set; }
        public int EarthYPosition { get; private set; }
        public int AlphaCentariXPosition { get; private set; }
        public int AlphaCentariYPosition { get; private set; }
        public int M63XPosition { get; private set; }
        public int M63YPosition { get; private set; }










    }
}
