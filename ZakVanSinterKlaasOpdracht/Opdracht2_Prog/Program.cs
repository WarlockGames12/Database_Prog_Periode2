using System;

namespace Opdracht2_Prog
{
    class Program
    {
        static void Main(string[] args)
        {
            ZakVanSinterklaas deZak = new ZakVanSinterklaas();

            Cadeau eenCadeau = new Cadeau("Nintendo Switch");
            Cadeau eenCadeau1 = new Cadeau("Pokemon Brilliant Diamond");
            deZak.AddPresent(eenCadeau);
            deZak.AddPresent(eenCadeau1);
            for(int i = 0; i < 1000; i++)
            {
                deZak.AddPresent(new Cadeau($"Cadeau Nummer: {i}"));
            }
            foreach(Cadeau c in deZak.GetPresents())
            {
                Console.WriteLine(c.GetName());
            }
        }
    }
}
