using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.EstruturaDeControle
{
    class UsandoBREAK
    {
        public static void Executar()
        {
            Random radom = new Random();
            int numero = radom.Next(1, 51);

            Console.WriteLine("O número que queremos é: {0}", numero);
            for(int i = 1; i <= 50; i++)
            {
                Console.Write("{0} O número que queremos?", i);
                if(i == numero)
                {
                    Console.WriteLine("Sim");
                    break;
                }
                else
                {
                    Console.WriteLine("Não");
                }
            }
            Console.WriteLine("Fim!");
        }
    }
}
