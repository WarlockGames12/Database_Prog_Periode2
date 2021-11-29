using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2_Prog
{
    public class FireSlashAttack : Attacks
    {
        private string AttackerName = "Tristan";
        private string Effects = "Fire Effect";

        public FireSlashAttack(string attackNames, string Description, int Damage) : base(attackNames, Description, Damage)
        {
        }

        public override void PlayerAttacks()
        {
            Console.WriteLine($"{AttackerName} uses the {AttackName}, it gave {Damage} damage and it gave the enemy a {Effects} and the description of the attack is: {Discription}");
        }
    }
}
