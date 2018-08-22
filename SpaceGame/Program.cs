using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Program
    {

        static void Main(string[] args)
        {

            var IntroPage = new IntroPage();
            var Earth = new Earth();

            //Entry Page/ Introduction/ Instructions

            IntroPage.FirstPage();
            Earth.EarthPage();


            //Options upon 
            // Pages.EarthPage();






        }
        
    }

}
