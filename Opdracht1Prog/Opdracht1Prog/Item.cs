using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1Prog
{
    public class Item
    {
        public string Potions, Discription;
        public int Health;
        public Item(string Potions1, int Healing, string Discription1)
        {
            this.Potions = Potions1;
            this.Health = Healing;
            this.Discription = Discription1;
        }
    }
}
