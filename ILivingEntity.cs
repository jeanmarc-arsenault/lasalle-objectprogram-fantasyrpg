using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_RPG_JMA
{
    internal interface ILivingEntity
    {

        bool IsDead();
        void ReceiveDamage(int damage);
        void Attack();


    }




}
