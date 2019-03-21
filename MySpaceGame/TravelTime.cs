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






        //Class Methods
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
            Logos.travelinglogo2();
            Console.WriteLine("Press ENTER to continue:");
            Console.Read();
            
        }
        
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
        public void AgingToSunnn(Planets _currentPlanet, Spaceship _myShip)
        {
            _myShip.age += Convert.ToInt32(_currentPlanet.distanceFromSunnn);
        }

        
        public void ChoosePlanet(string choice)
        {


            Console.WriteLine($"Ok! {choice} it is!");
            travelAnimatics();
            Console.Clear();
            
            Console.WriteLine($"--------------------Welcome to {choice}--------------------");
            

        }
        public void DeathsSweetEmbrace()
        {
            bool mybool = true;
            while (mybool)
            {
                Console.Clear();
                Logos.spacebanker();
                Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.Gray;
                Console.WriteLine("Your Time is up buddy!! Im Zylon the space banker! Do you have my money??");
                Console.ResetColor();
                Console.WriteLine("1. Slow down there partner im still working on it");
                Console.WriteLine("2. Nah im keeping the money and retiring on Krypton");
                var select = Console.ReadLine();
                if (select == "1")
                {
                  
                    Console.WriteLine("Okay frendo earth is done for!");
                    Logos.earthlogo();
                    Console.ReadKey();
                    Console.Clear();
                    Logos.explosion();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.WriteLine("GAME OVER");
                    Console.ResetColor();
                    Console.ReadLine();
                }
                if (select =="2")
                {
                    
                    Console.WriteLine("Okay frendo earth is done for!");
                    Logos.earthlogo();
                    Console.ReadKey();
                    Console.Clear();
                    Logos.explosion();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.WriteLine("GAME OVER");
                    Console.ResetColor();
                    Console.ReadLine();
                }
            }

        }
    }
}
