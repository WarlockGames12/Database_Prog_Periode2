using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2_Prog
{
    internal class ZakVanSinterklaas
    {
        List<Cadeau> Cadeautjes;
        public ZakVanSinterklaas()
        {
            Cadeautjes = new List<Cadeau>();
        }

        public void AddPresent(Cadeau eenCadeau)
        {
            Cadeautjes.Add(eenCadeau);
        }

        public List<Cadeau> GetPresents()
        {
            return Cadeautjes;
        }
    }
}
