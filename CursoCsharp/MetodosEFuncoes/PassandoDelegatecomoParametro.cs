using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.MetodosEFuncoes
{
    class PassandoDelegatecomoParametro
    {
        public delegate int Operacao(int x, int y);
        public static int Soma(int x, int y)
        {
            return x + y;
        }

        public static string Calculadora(Operacao op, int x, int y)
        {
            var Resutlado = op(x, y);
            return "Resultado " + Resutlado;
        }
        public static void Executar()
        {
            Operacao Subtracao = (int x, int y) => x - y;
            Console.WriteLine(Calculadora(Subtracao, 50, 25));

            Console.WriteLine(Calculadora(Soma, 10, 11));

        }
    }
}
