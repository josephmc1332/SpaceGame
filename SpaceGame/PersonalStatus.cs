using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class PersonalStatus
    {
        Random rnd = new Random();

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

            //user info
            this.MyName = "Trader";
      

        }
        public double MyLocation { get; set; }


        /// <summary>
        /// goods
        /// </summary>
        public int SpaceGold        { get; set; }
        public int NoBalanaceShoes  { get; set; }
        public int GalacticTVs      { get; set; }

        /// <summary>
        /// Personal Info
        /// </summary>
        public int MyCurrentCredit      { get; set; }
        public string MyName            { get; set; }
        public double MyTravelTime      { get; set; }
        public string MyCurrentLocation { get; set; }









    }
}
