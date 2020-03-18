using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.EstruturaDeControle
{
    class UsandoCONTINUE
    {
        public static void Executar()
        {
            // um exemplo de usar o CONTINUE
            int intervalo = 50;
            Console.WriteLine("Números pares entre 1 e {0}", intervalo);

            for (int i = 1; i <= intervalo; i++)
            {
                if (i % 2 == 1)
                {
                    continue;
                }
                Console.Write(i + " ");
            }

            Console.WriteLine(" ");
            Console.WriteLine("Números Impares de 1 a {0}", intervalo);
            //outro exemplo de ver numero Impares

            for (int i = 1; i <= intervalo; i += 2)
            {
                Console.Write(i + " ");
            }

        }
    }
}
