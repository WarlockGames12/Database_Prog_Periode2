using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2_Prog
{
    public abstract class Attacks
    {
        public string AttackName { get; private set; }
        public string Discription { get; private set; }
        public int Damage { get; private set; }

        protected Attacks(string Attacknames, string discriptions, int EnemyDamage)
        {
            this.AttackName = Attacknames;
            this.Discription = discriptions;
            this.Damage = EnemyDamage;
        }

        public abstract void PlayerAttacks();
    }
}
