using System;

namespace CursoCsharp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Execultar()
        {
            //Preço Desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var TotalComDesconto = total - (total * desconto);
            Console.WriteLine("O preço final é {0}", TotalComDesconto );

            // IMC
            double peso = 91.4;
            double altura = 1.94;
            double imc = peso / Math.Pow(altura, 2); // elevar a potencia

            //Numero Par_Impar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);
            // % resto da operacao, se o resto da divisáo for 1 e impar, se for 0 é par.
        }

    }
}
