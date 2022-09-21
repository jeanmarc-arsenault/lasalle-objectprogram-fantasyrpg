using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_RPG_JMA
{
    internal class Dragon : Monster
    {



        int rgp;
        public Dragon(string name, int hp, int ap, int rxp, int rgp) : base(name, hp, ap, rxp)
        {
            this.Rgp = rgp;
        }


        public Dragon(string name, int hp, int ap, int rxp) : base(name, hp, ap, rxp)
        {
            rgp = Dice.GetInstance().Next(1000, 10000);
        }


        public Dragon() : base() { }


        public int Rgp { get => rgp; set => rgp = value; }
    }
}
