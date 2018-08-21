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

        public int NoBalanaceShoes { get; set; }

        public int GalacticTVs { get; set; }

















    }
}
