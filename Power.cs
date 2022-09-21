using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_RPG_JMA
{
    public class Power : Item
    {


        public enum PowerType
        {
            Protect,
            Invisible,
            Healing,
            Sleepy
        }

        int minXp;
        public PowerType type;

        public Power(string name, int price, PowerType type, int minXp) : base(name, price)
        {
            this.MinXp = minXp;
            this.Type = type;
        }

        public Power(): base() { }

        public int MinXp { get => minXp; set => minXp = value; }
        public PowerType Type { get => type; set => type = value; }
    }
}
