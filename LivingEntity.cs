using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_RPG_JMA
{
    public abstract class LivingEntity : ILivingEntity
    {
        public string name;
        public int hp;

        public LivingEntity(string name, int hp)
        {
            this.Name = name;
            this.Hp = hp;
        }


        public LivingEntity()
        { }


        public string Name { get => name; set => name = value; }
        public int Hp { get => hp; set => hp = value; }


        public bool IsDead()
        {
            if (Hp <= 0)
                return true;
            else
                return false;
        }

        public virtual void ReceiveDamage(int damage)
        {
            Hp -= damage;
        }

        public abstract void Attack();


    }
}
