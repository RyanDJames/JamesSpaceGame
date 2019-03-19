using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace MySpaceGame
{
    class App
    {
        public void Run()
        {
            Console.WriteLine("Hello,  Adventurer, welcome to the Space Game!\nfirst we're going to name your ship." +
                   "\npick a name for your ship please: ");
            string shipname = Console.ReadLine();
            Console.Clear();

            //Create Spaceship:
            Spaceship Myship = new Spaceship(shipname, 1, 1000);

            //Create items
            Items Food = new Items("Food", 10, 1);
            Items Water = new Items("Water", 5, 10);
            Items Steel = new Items("Steel", 50, 10);
            Items Wood = new Items("Wood", 20, 50);

            //Create Planets
            Planets Earth = new Planets("Earth");
            Planets AlphaCenturi = new Planets("Alpha Centuri");
            Planets Krypton = new Planets("Krypton");

            //Fill initial planet's markets
            Earth.inventory.Add(Water);
            Earth.inventory.Add(Steel);
            Earth.inventory.Add(Wood);
            Earth.inventory.Add(Food);
            Krypton.inventory.Add(Water);
            Krypton.inventory.Add(Steel);
            Krypton.inventory.Add(Wood);
            Krypton.inventory.Add(Food);
            AlphaCenturi.inventory.Add(Water);
            AlphaCenturi.inventory.Add(Steel);
            AlphaCenturi.inventory.Add(Wood);
            AlphaCenturi.inventory.Add(Food);

            //Instantiate travel protocol
            TravelTime travel = new TravelTime();
            TravelTime ChoosePlanet = new TravelTime();
            App App = new App();
            //introductory dialogue. 
            //initial user input.



            Console.WriteLine($"Ah! \nSo {shipname} is what you've decided on... Erm, great name *coughs*");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Now, I'm not going to hold your hand. This universe is yours to conquer!");
            Thread.Sleep(1000);
            Console.Clear();

            
            
            bool play = true;
            while (play)
            {
                Console.WriteLine("What would you like to do?" +
               "\nWould you like to travel?" +
               "\nWould you like to trade?" +
               "\nWould you like to quit?" +
               "\n-> : ");
                
                string input = Console.ReadLine();
                if (input == "trade")
                {
                    

                   
                }
                else if (input == "travel")
                {
                    Console.Clear();
                    Console.WriteLine("Where would you like to go?" +
                    "\n Earth, Alpha Centuri, or Krypton?: ");
                    string choice = Console.ReadLine();
                    travel.CurrentPlanet(choice);

                }
                else if (input == "quit")
                {
                    play = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("I'm sorry, I didn't understand your choice. Please try again, and remember that the options are case sensitive!");
                    Console.ResetColor();
                }

            }
        }
    }
}
