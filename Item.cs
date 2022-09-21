using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_RPG_JMA
{
    public class Item
    {
        string name;
        int price;

        public Item(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }

        public Item() { }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
    }
}
