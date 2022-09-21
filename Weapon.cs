using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_RPG_JMA
{
    public class Weapon: Item
    {
        
        int minDamage;
        int maxDamage;
        int imgindex;

        public Weapon(string name, int price, int minDamage, int maxDamage, int imgindex):base(name, price)
        {
            
            this.MinDamage = minDamage;
            this.MaxDamage = maxDamage;
            this.Imgindex = imgindex;
        }

        public Weapon() : base() { }
        public int MinDamage { get => minDamage; set => minDamage = value; }
        public int Damage { get => Dice.GetInstance().Next(MinDamage, MaxDamage); }
        public int MaxDamage { get => maxDamage; set => maxDamage = value; }
        public int Imgindex { get => imgindex; set => imgindex = value; }
    }
}