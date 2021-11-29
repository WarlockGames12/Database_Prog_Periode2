using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2_Prog
{
    class AbilitySystemComponent
    {
        public List<Attacks> abilities = new List<Attacks>();

        public AbilitySystemComponent()
        {
            abilities = new List<Attacks>();
        }

        public void AddAbility(Attacks attacks)
        {
            abilities.Add(attacks);
        }

        public void PlayerAttacks(int index)
        {
            abilities[index].PlayerAttacks();
        }
    }
}
