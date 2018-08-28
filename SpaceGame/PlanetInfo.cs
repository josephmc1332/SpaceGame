using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class PlanetInfo
    {
        public PlanetInfo()
        {




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

        /// <summary>
        /// cargo
        /// </summary>
        
        public int EarthSpaceGold { get; private set; }
        public int AlphaCentariGold { get; private set; }
        public int M63SpaceGold { get; private set; }

        
        public int EarthNoBalanceShoes { get; private set; }
        public int AlphaCentariNoBalanceShoes { get; private set; }
        public int M63NoBalanceShoes { get; private set; }

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
