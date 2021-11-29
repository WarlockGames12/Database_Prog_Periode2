using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2_Prog
{
    class Cadeau
    {
        private string naam;
        public Cadeau(string naam1)
        {
            this.naam = naam1;
        }
        public string GetName()
        {
            return naam;
        }

    }
}
