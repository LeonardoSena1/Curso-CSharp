using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.Colecoes
{
    class IgualdadeEqualseGetHashCode
    {
        public static void Executar()
        {
            var p1 = new Produto("Caneta", 1.89);
            var p2 = new Produto("Caneta", 1.89);
            var p3 = p2;

            //comparação por mememorias diferentes
            Console.WriteLine("p1 é igual a p2? " + (p1 == p2)); // não sera igual, pq é armazenado em memorias diferentes.
            Console.WriteLine("P3 é igual a p2? " + (p3 == p2) + " é igual pq usa a mesma referencia.");

            //Continuacao no List

        }
    }
}
