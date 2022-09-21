using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_RPG_JMA
{
    public static class GameFactory
    {

        public static Monster CreateMonster()
        {
            int random = Dice.GetInstance().Next(0, 100);
            //5% of chance to meet a Dragon
            if (random <= 5)
            {
                Message.form.pbMain.Refresh();
                Message.form.pbMain.Image = Message.form.ilImages.Images[1];
                return new Dragon("Dragon", 120, 30, 4);
                
            }
            else //15% of chance to meet an Ogre
            if (random > 5 && random <= 20)
            {

                Message.form.pbMain.Refresh();
                Message.form.pbMain.Image = Message.form.ilImages.Images[6];
                return new Monster("Ogre", 80, 10, 2);
            }
            //80% of chance to meet a Goblin
            Message.form.pbMain.Refresh();
            Message.form.pbMain.Image = Message.form.ilImages.Images[4];
            return new Monster("Goblin", 40, 5, 1);
        }
        public static Power CreateHealing()
        {
            return new Power("Magic Potion", 200, Power.PowerType.Healing ,2);
        }
        public static Power CreateInvisible()
        {
            return new Power("Magic Cape", 300, Power.PowerType.Invisible, 3);
        }
        public static Power CreateProtect()
        {
            return new Power("Wood Shield", 100, Power.PowerType.Protect, 1);
        }
        public static Power CreateSleepy()
        {
            return new Power("Sleepy Dust", 600, Power.PowerType.Sleepy, 6);
        }
        public static Weapon CreateRock()
        {
            return new Weapon("Big rock", 100, 20, 30, 8);
        }
        public static Weapon CreateTorch()
        {
            return new Weapon("Torch", 300, 35, 45, 12);
        }
        public static Weapon CreateSword()
        {
            return new Weapon("Magic Sword", 500, 50, 60, 11);
        }
        public static Weapon CreateStick()
        {
            return new Weapon("Wood Stick", 0, 5, 15,10);
        }

    }
}
