using System;
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
        public int currency;
        public List<Items> inventory = new List<Items>();

        //class constructors
        public Spaceship(string _name, int _speed, int _currency)
        {
            Name = _name;
            speed = _speed;
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

    }
}
