using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MySpaceGame
{
    public class TravelTime
    {
        
        public void travelAnimatics()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*Ship engine begins firing up*");
            Thread.Sleep(500);
            Console.WriteLine("3");
            Thread.Sleep(500);
            Console.WriteLine("2");
            Thread.Sleep(500);
            Console.WriteLine("1");
            Thread.Sleep(500);
            Console.WriteLine("BLASTOFF!");
            Console.ResetColor();
            Thread.Sleep(600);
            Console.Clear();
            Logos.travelinglogo1();
            Console.WriteLine("Press ENTER to continue:");
            Console.Read();
            
        }
        // add to age not take away9322109813299381023183098391023838029
        public void AgingToEarth(Planets _currentPlanet, Spaceship _myShip)
        {
            _myShip.age += Convert.ToInt32(_currentPlanet.distanceFromEarth);
        }
        public void AgingToKrypton(Planets _currentPlanet, Spaceship _myShip)
        {
            _myShip.age += Convert.ToInt32(_currentPlanet.distanceFromKrypton);
        }
        public void AgingToAlphaCenturi(Planets _currentPlanet, Spaceship _myShip)
        {
            _myShip.age += Convert.ToInt32(_currentPlanet.distanceFromAlphaCenturi);
        }


        public void ChoosePlanet(string choice)
        {


            Console.WriteLine($"Ok! {choice} it is!");
            travelAnimatics();
            Console.Clear();
            
            Console.WriteLine($"--------------------Welcome to {choice}--------------------");
            

        }

        
    }
}
