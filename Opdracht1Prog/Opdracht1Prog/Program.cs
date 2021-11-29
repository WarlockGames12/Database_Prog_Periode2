using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Opdracht1Prog
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            inventory.AddItem(new Item("HealthPotion ", 10, " Gives you health"));
            inventory.AddItem(new Item("ManaPotion ", 5, " Gives you Health"));

            foreach(Item Pingas in inventory.GetItem())
            {
                Console.WriteLine(Pingas.Potions + Pingas.Health + Pingas.Discription);
            }
        }
    } 
}
