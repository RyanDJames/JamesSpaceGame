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
        static string heroname;
        static string shipname;
        public void Run()
        {
            Logos.logo();
            Console.WriteLine("Press ENTER to continue");
            Console.ReadKey();
            Console.Clear();
            Logos.logo();
            Console.Write("Hello,  Adventurer, welcome to the Space Game!\nfirst we're going to name your ship." +
              "\npick a name for your ship please: ");
            Logos.spaceshiplogo();
            Console.Write("Name: ");
            shipname = Console.ReadLine().ToUpper();
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
            Planets CurrentPlanet = Earth;
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


            Logos.logo();
            Console.WriteLine($"Ah! \nSo {shipname} is what you've decided on... Erm, great name *coughs*");
            Console.ReadKey();
            chooseyourcharacter();
            introductionscreen();
            Console.WriteLine($"Now {heroname} I'm not going to hold your hand. This universe is yours to conquer!");
            Thread.Sleep(1000);
            Console.ReadKey();
            Console.Clear();



            bool play = true;
            while (play)
            {
                statmenu();
                Console.Write("What would you like to do?" +
               "\n1.  Would you like to travel?" +
               "\n2.  Would you like to trade?" +
               "\n0.  Would you like to quit?" +
               "\n-> : ");

                string input = Console.ReadLine();
                if (input == "2")
                {
                    //This is the trading piece
                    bool trade = true;
                    while (trade)
                    {


                        Console.WriteLine("Welcome to the market!");
                        Console.WriteLine("would you like to buy, sell, or quit?: ");
                        string answer = Console.ReadLine();
                        if (answer == "buy")
                        {
                            Thread.Sleep(1000);
                            Earth.printInv();
                            Console.WriteLine("Please select an item you would like to buy: ");
                            int index = int.Parse(Console.ReadLine());
                            Earth.BuyTransaction(index, Myship);


                        }
                        else if (answer == "sell")
                        {

                        }
                        else if (answer == "quit")
                        {
                            trade = false;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Sorry, I didn't understand. Try lower case? muhahahahahahahaha");
                            Console.ResetColor();
                        }
                        Console.Clear();
                        statmenu();
                        Console.ReadKey();

                    }
                }

                // This is the travel piece
                else if (input == "1")
                {
                    Console.Clear();
                    statmenu();
                    Console.WriteLine("Where would you like to go?" +
                    "\n 1. Earth\n 2. Alpha Centuri\n 3. Krypton ");
                    string choice = Console.ReadLine();
                    if (choice == "Earth")
                    {
                        travel.ChoosePlanet(choice);
                        CurrentPlanet = Earth;
                    }
                    else if (choice == "Krypton")
                    {
                        travel.ChoosePlanet(choice);
                        CurrentPlanet = Krypton;
                    }
                    else if (choice == "Alpha Centauri")

                        travel.ChoosePlanet(choice);
                    CurrentPlanet = AlphaCenturi;
                }

                else if (input == "0")
                {
                    play = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("I'm sorry, I didn't understand your choice. Please try again!");
                    Console.ResetColor();
                }
            }

            void chooseyourcharacter()
            {
                int name1 = 0;
                Console.Write("What is your name:");
                heroname = Console.ReadLine().ToUpper();
                do
                {

                    Console.WriteLine($"Are you sure you want your name to be {heroname}  Y/N ?");
                    var yesno = Console.ReadLine().ToUpper();
                    if (yesno == "Y")
                    {
                        name1 = 1;
                    }
                    else if (yesno == "N")
                    {
                        Console.Write("What is your name: ");
                        heroname = Console.ReadLine().ToUpper();
                        name1 = 0;
                    }
                }
                while (name1 == 0);
                name1 = 0;

            }
            //stats menu
             void statmenu()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"=======================================================================================================================");
                Console.WriteLine($"    Name: {heroname}                Ship: {shipname}                 Planet:                Age:             credits:");
                Console.WriteLine($"=======================================================================================================================");
                Console.ResetColor();
            }

            //introduction story line
            void introductionscreen()
            {
                Console.Clear();
                Logos.logo();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"THE YEAR IS 1998 A.D, PLANET EARTH IS IN GREAT DANGER.\n");
                Console.WriteLine($"AFTER FUNDING MANY GREAT WARS AGAINST JUPITER, EARTH IS COMPLETELY BROKE. THE SPACE BANKERS ARE THREATENING\n");
                Console.WriteLine($"TO DESTROY EARTH IF THE LOAN OF 10,000 CREDITS IS NOT REPAID BY 2038 A.D. {heroname} YOUR MISSION IS TO TRAVEL THE\n");
                Console.WriteLine($"GALAXY AND MAKE ENOUGH MONEY TO REPAY THE SPACE BANK.  YOU  MUST BE QUICK... EVERY LIGHT YEAR TRAVELLED MEANS\n");
                Console.WriteLine($"ANOTHER YEAR PASSES.  YOU MUST TAKE 1,000 CREDITS AND GO TO DIFFERENT PLANETS BUYING AND SELLING GOODS UNTIL YOU HAVE \n");
                Console.WriteLine($"ENOUGH TO PAY THE BANKERS. TAKE YOUR SPACE SHIP {shipname} AND BEGIN YOUR JOURNEY!\n");
                Console.ReadKey();
            }
        }
    }
}
