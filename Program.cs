using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tapez un chiffre a !");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Entrez un autre chiffre b !");
            int b = int.Parse(Console.ReadLine());

            a = a + 33;
            b++;

            int resultat = a / b;
            Console.WriteLine("Voici le résultat après avoir rajouté 33 a \"a\" et incrémenté b : " + resultat);

            
        }
    }
}
