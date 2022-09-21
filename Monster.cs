using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_RPG_JMA
{
    public class Monster : LivingEntity
    {
        int ap;
        int rxp;
        Player target;
        public static Main_Game form;
        public Monster(string name, int hp, int ap, int rxp) : base(name, hp)
        {

            this.Ap = ap;
            this.Rxp = rxp;
            this.Hp = hp;
        }

        public Monster() : base() { }

        public int Ap { get => ap; set => ap = value; }
        public int Rxp { get => rxp; set => rxp = value; }
        public int Damage { get => Dice.GetInstance().Next(0, Ap); }
        public Player Target { get => target; set => target = value; }

        public override void ReceiveDamage(int damage)
        {
            Hp -= damage;
        }

        public override void Attack()
        {
            int currentdamage = Damage;
            GameManager.CurrentPlayer.ReceiveDamage(currentdamage);
            Message.PrintDanger(GameManager.CurrentPlayer.Enemy.Name + " attacks! and inflicts " + currentdamage + "!");


            Message.form.lbPlayerDam.Text = $"{currentdamage} Damage!"; ;
            Task.Delay(500).Wait();
            Message.form.lbPlayerDam.Text = "";


        }

    }

}