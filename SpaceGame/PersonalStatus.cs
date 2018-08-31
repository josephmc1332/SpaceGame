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
        public int SpaceGold { get; set; }
        public int NoBalanaceShoes { get; set; }
        public int GalacticTVs { get; set; }

        /// <summary>
        /// Personal Info
        /// </summary>
        private int MyCurrentCredit { get; set; }
        private string MyName { get; set; }
        private double MyTravelTime { get; set; }
        private string MyCurrentLocation { get; set; }


        // Money manupulation methods
        #region money manipulation
        public void SpendMoney(int costOfItem)
        {
            MyCurrentCredit -= costOfItem;
        }
        public void EarnMoney(int profit)
        {
            MyCurrentCredit += profit;
        }
        public int Cash()
        {
            return MyCurrentCredit;
        }
        #endregion

        #region time Manipulation
        public double TravelAge()
        {
            return MyTravelTime;
        }
        public void AddTime(double timePassed)
        {
            MyTravelTime += timePassed;
        }
        #endregion

        public string NameCall()
        {
            return MyName;
        }
        public void WhatsMyName(string name)
        {
            MyName = name;
        }

        public void LocationChanger(string planet)
        {
            MyCurrentLocation = planet;
        }
        public string LocationCheck()
        {
            return MyCurrentLocation;
        }



    }
}
