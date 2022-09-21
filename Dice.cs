using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_RPG_JMA
{
    public class Dice : Random
    {

        private static Dice instance = null;
        private Dice() : base() { }
        public static Dice GetInstance()
        {
            if (instance == null)
            {
                instance = new Dice();
            }

                return instance;
        }

    }
}
