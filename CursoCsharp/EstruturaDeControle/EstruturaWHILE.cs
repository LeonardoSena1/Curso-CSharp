using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.EstruturaDeControle
{
    class EstruturaWHILE
    {
        public static void Execultar()
        {
            int palpite = 0;
            Random radom = new Random();

            int numeroSecreto = radom.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativaRestante = 5;
            int tentativas = 0;

            while (tentativaRestante > 0 && !numeroEncontrado)
            {
                Console.Write("Insira o seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativaRestante--;

                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Numero encontrado em {0} tentativas", tentativaRestante);
                    Console.BackgroundColor = corAnterior;
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Menos... tente novamente");
                    Console.WriteLine("Tentativas restante: {0}", tentativaRestante);
                }
                else if (palpite < numeroSecreto)
                {
                    Console.WriteLine("Maior... Tente novamente");
                    Console.WriteLine("Tentativas restante: {0}", tentativaRestante);
                }
            }
        }
    }
}
