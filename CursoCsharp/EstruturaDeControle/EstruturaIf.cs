using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.EstruturaDeControle
{
    class EstruturaIf
    {
        public static void Execultar()
        {
            bool BomComportamento = false;
            string entrada;

            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.Write("Possui bom comportamento (S/N): ");
            entrada = Console.ReadLine();

            //if (entrada == "S" || entrada == "s")
            //    BomComportamento = true;

            //BomComportamento = entrada == "S" || entrada == "s";
            BomComportamento = entrada.ToLower() == "s"; // ToLower() faz a conversão de letra maiuscula para minuscula

            if(nota >= 9.0 && BomComportamento)
            {
                Console.WriteLine("Quadro de honra!");
            }


        }
    }
}
