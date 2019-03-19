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
        private object choice;

        //in this class, you're going to make some aesthe
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
        public void ChoosePlanet(string choice)
        {


            Console.WriteLine($"Ok! {choice} it is!");
            travelAnimatics();
            Console.Clear();
            App.statmenu();
            Console.WriteLine($"--------------------Welcome to {choice}--------------------");
            //planets.currentplanets = choice

        }

        
        public void CurrentPlanet(string planet)
        {
           

        }
    }
}
