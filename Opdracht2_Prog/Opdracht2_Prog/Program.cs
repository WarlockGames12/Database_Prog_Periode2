using System;

namespace Opdracht2_Prog
{
    class Program
    {
        

        static void Main(string[] args)
        {
            AbilitySystemComponent abilitySystemComponent = new AbilitySystemComponent();

            Attacks fireSlashAttack = new FireSlashAttack("FireSlash", "It can Slash the enemy with a fire effect, giving the enemy more damage", 20);

            abilitySystemComponent.AddAbility(fireSlashAttack);
            abilitySystemComponent.PlayerAttacks(0);
        }
    }
}
