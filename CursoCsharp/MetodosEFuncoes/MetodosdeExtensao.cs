using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.MetodosEFuncoes
{
    public static class ExtensoesInteiro
    {
        public static int Soma(this int num, int outroNumero)
        {
            return num + outroNumero;
        }

        public static int Subtracao(this int num, int outroNumero)
        {
            return num - outroNumero;
        }
    }

    class MetodosdeExtensao
    {
        public static void Executar()
        {
            int numero = 10;

            Console.WriteLine(numero.Soma(5));
            Console.WriteLine(numero.Subtracao(5));

            Console.WriteLine(2.Soma(5));
            Console.WriteLine(2.Subtracao(5));
        }
    }
}
