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
        public List<Items> inventory = new List<Items>();


        //constructors
        public Planets(string _name)
        {
            name = _name;
        }



        //methods
        public void BuyTransaction(int index, Spaceship Myship)
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
