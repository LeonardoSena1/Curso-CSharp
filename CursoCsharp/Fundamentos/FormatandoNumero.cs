using System;
using System.Globalization;

namespace CursoCsharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // Tostring("F1") faz o arredondamento pra cima !
            Console.WriteLine(valor.ToString("C")); // colocar o valor em moeda R$
            Console.WriteLine(valor.ToString("P")); //Persentual pegaro o valor da variavel e fazer * 100
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo Cultura = new CultureInfo("pt-BR"); // converte no idioma desejado
            Console.WriteLine(valor.ToString("C0", Cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // colocar 0 a esquerda do valor da variavel. 0000000256 = sete 0, variavel 256 = 0000000256
        }
    }
}
