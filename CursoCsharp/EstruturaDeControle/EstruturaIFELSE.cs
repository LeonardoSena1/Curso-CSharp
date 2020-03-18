using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.EstruturaDeControle
{
    class EstruturaIFELSE
    {
        public static void Execultar()
        {
            double nota = 7.9;

            if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado");
                Console.WriteLine("Não fez mais que sua obrigação...");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
    }
}
