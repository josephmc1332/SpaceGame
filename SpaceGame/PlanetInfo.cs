using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class PlanetInfo
    {
        Random rnd = new Random();
        public PlanetInfo()
        {




            //cost on earth
            this.EarthSpaceGold      = 100;

            this.EarthNoBalanceShoes = 80;

            this.EarthGalacticTVs    = 120;



            //cost on alphaC
            this.AlphaCentariGalacticTVs    = 100;

            this.AlphaCentariGold           = 150;

            this.AlphaCentariNoBalanceShoes = 65;


            //cost on M63
            this.M63GalacticTVs    = 140;

            this.M63NoBalanceShoes = 100;

            this.M63SpaceGold      = 60;


            //cost on Asgard
            // There aren't even any TVs in Asgard yet, isn't "globalization" grand
            this.AsgardGalacticTVs    = 170;
            // Asgardians are amazed by the new zero gravity shoe technology
            this.AsgardNoBalanceShoes = 150;
            // Asgard is basically made of space gold so there is no need for them to buy it
            this.AsgardGold           = 15;


            //cost on Planet X
            //nearly the same economy of earth, slightly richer in mineral resourses but slightly more expensive in manufactured goods
            this.PlanetXGold           = 90;

            this.PlanetXNoBalanceShoes = 90;

            this.PlanetXGalacticTVs    = 130;
            // we will make fuel cheap here

            //cost on Planet joe
            // The king of planet Joe is building the galaxy's finest spaceport made entirely of gold
            this.PlanetJoeGold = 300;
            // People need shoes but they aren't amazed by it or anything
            this.PlanetJoeNoBalanceShoes = 100;
            // same as shoes
            this.PlanetJoeGalacticTVs = 100;

            ///titan
            this.TitanGalacticTVs = 80;

            this.TitanGold = 100;

            this.TitanNoBalanceShoes = 200;




            //Earth Location
            this.EarthXPosition = 0.0;

            this.EarthYPosition = 0.0;


            //AlphaC Location
            this.AlphaCentariXPosition = 0.0;

            this.AlphaCentariYPosition = -4.37;


            //M63 Location
            this.M63XPosition = 6.0;

            this.M63YPosition = 4.0;


            //Asgard Location
            double axpositon     = rnd.Next(8, 13);
            this.AsgardXPosition = axpositon;

            double ayposition    = rnd.Next(5, 9);
            this.AsgardYPosition = ayposition;


            //PlanetX position
            //Planet X is the theroetical planet right outside of the sol system
            this.PlanetXXPosition = 0;

            this.PlanetXYPosition = -1;

            //Planet Joe position
            double jxposition = rnd.Next(-1, 4);
            this.PlanetJoeXPosition = jxposition;

            double jyposition = rnd.Next(13, 17);
            this.PlanetJoeYPosition = jyposition;

            //Titan Position
            double txposition = rnd.Next(2, 6);
            this.TitanXPosition = txposition;

            double typosition = rnd.Next(6, 12);
            this.TitanYPosition = typosition;

            
        }


        /// <summary>
        /// cargo
        /// </summary>

        public int EarthSpaceGold   { get; private set; }
        public int AlphaCentariGold { get; private set; }
        public int M63SpaceGold     { get; private set; }
        public int AsgardGold       { get; private set; }
        public int PlanetXGold      { get; private set; }
        public int PlanetJoeGold    { get; private set; }
        public int TitanGold        { get; private set; }

        public int EarthNoBalanceShoes          { get; private set; }
        public int AlphaCentariNoBalanceShoes   { get; private set; }
        public int M63NoBalanceShoes            { get; private set; }
        public int AsgardNoBalanceShoes         { get; private set; }
        public int PlanetXNoBalanceShoes        { get; private set; }
        public int PlanetJoeNoBalanceShoes      { get; private set; }
        public int TitanNoBalanceShoes          { get; private set; }

        public int EarthGalacticTVs         { get; private set; }
        public int AlphaCentariGalacticTVs  { get; private set; }
        public int M63GalacticTVs           { get; private set; }
        public int AsgardGalacticTVs        { get; private set; }
        public int PlanetXGalacticTVs       { get; private set; }
        public int PlanetJoeGalacticTVs     { get; private set; }
        public int TitanGalacticTVs         { get; private set; }

        /// <summary>
        /// planetary positions
        /// </summary>
        public double EarthXPosition        { get; private set; }
        public double EarthYPosition        { get; private set; }
        public double AlphaCentariXPosition { get; private set; }
        public double AlphaCentariYPosition { get; private set; }
        public double M63XPosition          { get; private set; }
        public double M63YPosition          { get; private set; }
        public double AsgardXPosition       { get; private set; }
        public double AsgardYPosition       { get; private set; }
        public double PlanetXXPosition      { get; private set; }
        public double PlanetXYPosition      { get; private set; }
        public double PlanetJoeXPosition    { get; private set; }
        public double PlanetJoeYPosition    { get; private set; }
        public double TitanXPosition        { get; private set; }
        public double TitanYPosition        { get; private set; }




    }
}
