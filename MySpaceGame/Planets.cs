using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySpaceGame;

namespace MySpaceGame
{
    public class Planets
    {
        //variables
        public string name;
        public double distanceFromEarth;
        public double distanceFromAlphaCenturi;
        public double distanceFromKrypton;
        public double distanceFromSunnn;
        public List<Items> inventory = new List<Items>();
        
        //constructors
        public Planets(string _name, double _distanceFromEarth, double _distanceFromAlphaCenturi, double _distanceFromKrypton)
        {
            name = _name;
            distanceFromEarth = _distanceFromEarth;
            distanceFromAlphaCenturi = _distanceFromAlphaCenturi;
            distanceFromKrypton = _distanceFromKrypton;
            
        }



        //methods
        public void BuyTransaction(int index, Spaceship Myship, Planets _currentPlanet)
        {
            if (_currentPlanet.distanceFromEarth == 0)
            {
                Myship.inventory.Add(this.inventory.ElementAt(index));
                Myship.currency -= inventory[index].value;
            }
            else if (_currentPlanet.distanceFromKrypton == 0)
            {
                Myship.inventory.Add(this.inventory.ElementAt(index));
                Myship.currency -= inventory[index].value * .8;  
            }
            else if (_currentPlanet.distanceFromAlphaCenturi == 0)
            {
                Myship.inventory.Add(this.inventory.ElementAt(index));
                Myship.currency -= inventory[index].value * .5;
            }
        }
        
        public void SellTransaction(int index, Spaceship Myship, Planets _currentPlanet)
        {
            this.inventory.Add(Myship.inventory.ElementAt(index));
            Myship.currency += inventory[index].value;
            Myship.inventory.RemoveAt(index);
        }

        public void printInv()
        {
            foreach (Items item in inventory)
            {
                Console.WriteLine($"Index: {inventory.IndexOf(item)},\n Product: {item.name}," +
                    $"\n Quantity: {item.quantity}," +
                    $"\n Credits: {item.value}");

            }
        }
    }
}
