using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class LandingPage
    {
        

        public void LandingPagePicker(LandingPage LP, Shop Shop, ShipYard SY, GameOver GO, PersonalStatus PS, UtilityMethods UM, Ship ship, PlanetInfo PI, Fuel fuel, Asgard Asgard, Earth Earth, AlphaCentari AlphaCentari, M63 M63, PlanetX PlanetX, Titan Titan)
        {
            if (PS.LocationCheck() == "Earth")
                Earth.EarthPage(LP, Shop, SY, GO, PS, UM, ship, PI, fuel, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan);
            if (PS.LocationCheck() == "AlphaCentari")
                AlphaCentari.AlphaCentariPage(LP, Shop, SY, GO, PS, UM, ship, PI, fuel, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan);
            if (PS.LocationCheck() == "M63")
                M63.M63Page(LP, Shop, SY, GO, PS, UM, ship, PI, fuel, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan);
            if (PS.LocationCheck() == "Asgard")
                Asgard.AsgardPage(LP, Shop, SY, GO, PS, UM, ship, PI, fuel, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan);
            if (PS.LocationCheck() == "Planet X")
                PlanetX.PlanetXPage(LP, Shop, SY, GO, PS, UM, ship, PI, fuel, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan);
            if (PS.LocationCheck() == "Titan")
                Titan.TitanPage(LP, Shop, SY, GO, PS, UM, ship, PI, fuel, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan);
            LandingPagePicker(LP, Shop, SY, GO, PS, UM, ship, PI, fuel, Asgard, Earth, AlphaCentari, M63, PlanetX, Titan);
        }

    }
}
