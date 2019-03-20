﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpaceGame
{
    public class Spaceship
    {
        //class variables
        public string Name;
        public int speed;
        public int age;
        public int currency;
        public List<Items> inventory = new List<Items>();

        //class constructors
        public Spaceship(string _name, int _speed, int _age, int _currency)
        {
            Name = _name;
            speed = _speed;
            age = _age;
            currency = _currency;
            

        }



        //class methods

        public void addToInv(Items item)
        {
            inventory.Add(item);
            printInv();
        }

        public void printInv()
        {
            foreach (Items item in inventory)
            {
                Console.WriteLine($"{inventory.IndexOf(item)}, {item.name}, {item.quantity}, {item.value}");

            }
        }

        public void transactionWithPlanet(int value)
        {

        }

        public void statmenu(string _heroName, string _shipName, Planets _currentplanet)
        {
            string CurrentPlanet = _currentplanet.name;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"=======================================================================================================================");
            Console.WriteLine($"    Name: {_heroName}                Ship: {_shipName}              Planet:{CurrentPlanet}             Age:{age}          credits:{currency}");
            Console.WriteLine($"=======================================================================================================================");
            Console.ResetColor();

        }
    }
}
