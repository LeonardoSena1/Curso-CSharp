using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.TopicosAvancados
{
    class Nullables
    {
        public static void Executar()
        {
            Nullable<int> num1 = null;
            int? num2 = null;

            if (num1.HasValue)
            {
                Console.WriteLine("Valor de num: {0} ", num1);
            }
            else
            {
                Console.WriteLine("Não a valor nessa variavel!");
            }

            int valor = num1 ?? 1000;

            bool? boleeano = null;
            bool resultado = boleeano.GetValueOrDefault();
            Console.WriteLine(resultado);
        }
    }
}
