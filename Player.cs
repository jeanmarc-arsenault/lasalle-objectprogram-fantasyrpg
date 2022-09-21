using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_RPG_JMA
{

    public class Player: LivingEntity
    {
        public int hp_max= 100;
        public int xp = 0;
        public int gp = 0;
        public int level = 1;
        public List<Power> myPowers = new List<Power>();
        public bool protect = false;
        public Monster enemy;
        public Weapon myWeapon;
        public int shield = 0;
        public int dust = 0;
        public int potion = 0;
        public int cloak = 0;
        public static Main_Game form;

        public Player(string name, int hp, int hp_max, int xp, int gp, int level, List<Power> myPowers, bool protect, Monster enemy, Weapon myWeapon) : base(name, hp)
        {
            this.Hp_max = hp_max;
            this.Xp = xp;
            this.Gp = gp;
            this.Level = level;
            this.MyPowers = myPowers;
            this.Protect = protect;
            this.Enemy = enemy;
            this.MyWeapon = myWeapon;
        }

        public Player(string name, int hp) : base(name, hp) //overload to fit gamemanager
        {
            int Hp_max = 100;
            int Xp=0;
            int Gp=0;
            int Level =1;
            List<Power> MyPowers;
            bool Protect = false;
            Monster Enemy =null;
            Weapon MyWeapon = GameFactory.CreateStick();
        }

        public Player() : base() { }

        public int Xp { get => xp; set => xp = value; }
        public int Hp_max { get => hp_max; set => hp_max = value; }
        public int Gp { get => gp; set => gp = value; }
        public int Level { get => level; set => level = value; }
        internal List<Power> MyPowers { get => myPowers; set => myPowers = value; }
        public bool Protect { get => protect; set => protect = value; }
        public Monster Enemy { get => enemy; set => enemy = value; }
        public Weapon MyWeapon { get => myWeapon; set => myWeapon = value; }


        public void Heal()
        {
            GameManager.CurrentPlayer.Hp = GameManager.CurrentPlayer.Hp_max;
            Message.form.lblHealth.Text = Convert.ToString(GameManager.CurrentPlayer.Hp);
            Message.PrintMainMenu(GameManager.CurrentPlayer.Name + " Gulps down a healing potion!");
            GameManager.StartBattle(Message.form);

        }

        public void Hide()
        {
            GameManager.BattleRounds = 5;
            Message.PrintMainMenu(GameManager.CurrentPlayer.Name + " hides with his Cloak from the " + GameManager.CurrentPlayer.Enemy.Name + "!");
            GameManager.StartBattle(Message.form);
        }

        public void Sprinkle()
        {
            Dragon tempdragon= new Dragon();
            
            if(GameManager.CurrentPlayer.Enemy.GetType() == tempdragon.GetType())
            {
                GameManager.BattleRounds = 5;
                Message.PrintMainMenu(GameManager.CurrentPlayer.Name + " sprinkles fairy Dust on the Dragon and steal his Gold!");
                int gp = ((Dragon)GameManager.CurrentPlayer.Enemy).Rgp;
                GameManager.CurrentPlayer.Gp += gp;
                Message.Print("\nYou collect " + gp + " Gold Pieces !");
                Message.form.lblGold.Text = GameManager.CurrentPlayer.Gp.ToString();
                GameManager.StartBattle(Message.form);
            }
            else
            {
                GameManager.BattleRounds = 5;
                Message.PrintMainMenu(GameManager.CurrentPlayer.Name + " sprinkles fairy Dust on the  " + GameManager.CurrentPlayer.Enemy.Name + "!");
                GameManager.StartBattle(Message.form);
            }
            
        }


        public void AddPower(Power newPower)
        {
            MyPowers.Add(newPower);

            if(newPower.Type == Power.PowerType.Protect)
            {
                shield++;
                Message.form.lblShield.Text= shield.ToString();
            }
            if (newPower.Type == Power.PowerType.Healing)
            {
                potion++;
                Message.form.lblPotion.Text = potion.ToString();
            }
            if (newPower.Type == Power.PowerType.Sleepy)
            {
                dust++;
                Message.form.lblDust.Text = dust.ToString();
            }
            if (newPower.Type == Power.PowerType.Invisible)
            {
                cloak++;
                Message.form.lblCloak.Text = cloak.ToString();
            }


        }
        public Power GetPower(Power.PowerType type)
        {
            foreach (Power power in MyPowers)
            {
                if (power.Type == type)
                {
                    return power;
                }
            }
            return null;
        }

        public void ApplyPower(Power.PowerType type)
        {
            Power power = GetPower(type);

            if (power != null)
            {
                if (power.MinXp < Xp)
                {
                    MyPowers.Remove(power);


                    if( type == Power.PowerType.Healing) {
                        Heal();
                        potion--;
                        Message.form.lblPotion.Text = potion.ToString();
                    }
                        

                    if (type == Power.PowerType.Invisible) { 
                        Hide();
                        cloak--;
                        Message.form.lblCloak.Text = cloak.ToString();

                    }
                        

                    if (type == Power.PowerType.Protect)
                    {
                        Protect = true;
                        Message.PrintMainMenu(GameManager.CurrentPlayer.Name + " uses his sheild for protection against the " + GameManager.CurrentPlayer.Enemy.Name + "!");
                        shield--;
                        Message.form.lblShield.Text = shield.ToString();
                    }

                    if (type == Power.PowerType.Sleepy)
                    {
                        dust--;
                        Message.form.lblDust.Text = dust.ToString();
                        Sprinkle();
                    }
                        
                }
                else
                    Message.PrintWarning("\nYou do not have enough xp to use that power!");
            }
            else
                Message.PrintWarning("\nYou do not have that power...");

        }
        public override void ReceiveDamage(int damage)
        {
            if (Protect == false)
            {
                Hp -= damage;
                Message.form.lblHealth.Text = Convert.ToString(Hp);
            }
            if (Protect == true)
            {
                Hp -= damage/2;
                Message.form.lblHealth.Text = Convert.ToString(Hp);
            }

        }

        public void Next_Level()
        {
            int requiredXP = (int)Math.Floor(10 * Math.Pow(this.Level, 1.5));
            if (this.Xp >= requiredXP)
            {
                this.Level++;
                this.hp_max += (this.Level * 5);
                Message.form.lblLevel.Text = Convert.ToString(GameManager.CurrentPlayer.Level);
                Message.form.lblHealthMax.Text = Convert.ToString(GameManager.CurrentPlayer.hp_max);
                Message.PrintWarning("\nLEVEL UP!!!");
            }
        }

        public override void Attack()
        {
            int currentdamage = GameManager.CurrentPlayer.MyWeapon.Damage;

            Enemy.ReceiveDamage(currentdamage);
            Message.PrintMainMenu("You attack the " + GameManager.CurrentPlayer.Enemy.Name + " and inflicts " + currentdamage + "!");
            Message.form.lblMonsterDam.Text = $"{currentdamage} Damage!";
            Task.Delay(500).Wait();
            Message.form.lblMonsterDam.Text = "";


            GameManager.StartBattle(Message.form);
        }

        public void Buy_Weapon(Weapon newweapon )
        {
            if(newweapon.Price < GameManager.CurrentPlayer.Gp)
            {
                GameManager.CurrentPlayer.Gp -= newweapon.Price;
                Message.form.lblGold.Text = GameManager.CurrentPlayer.Gp.ToString();

                Message.Print($"\nYou collect a {newweapon.Name}!");
                UpdateWeapon(newweapon);
            }
            else
                Message.PrintWarning("\nYou do not have enough gold!");

        }

        public void Buy_Power(Power newpower)
        {
            if (newpower.Price < GameManager.CurrentPlayer.Gp)
            {
                GameManager.CurrentPlayer.Gp -= newpower.Price;
                Message.form.lblGold.Text = GameManager.CurrentPlayer.Gp.ToString();
                Message.Print($"\nYou collect a {newpower.Name}!");
                AddPower(newpower);
            }
            else
                Message.PrintWarning("\nYou do not have enough Gold!");

        }

        public void UpdateWeapon(Weapon weapon)
        {
            if (weapon.Price > MyWeapon.Price)
            {
                GameManager.CurrentPlayer.MyWeapon = weapon;
                Message.form.lblWeapon.Text = GameManager.CurrentPlayer.MyWeapon.Name.ToString();
                Message.form.btnAttack.Image = Message.form.ilImages.Images[weapon.Imgindex];

            }
            Message.PrintWarning("\nBeing a poorer weapon you throw it away!");
        }
    }
}