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
            
            Myship.inventory.Add(this.inventory.ElementAt(index));
            Myship.currency -= inventory[index].value;
            
        }
        

        public void printInv()
        {
            foreach (Items item in inventory)
            {
                Console.WriteLine($"Index: {inventory.IndexOf(item)},\n Product: {item.name}," +
                    $"\n Quantity {item.quantity}," +
                    $"\n Credits: {item.value}");

            }
        }
    }
}
