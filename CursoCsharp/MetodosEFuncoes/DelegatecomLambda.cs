using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.MetodosEFuncoes
{
    delegate double Operacao(double x, double y);
    class DelegatecomLambda
    {
        public static void Executar()
        {
            Operacao Somar = (x, y) => x + y;
            Operacao Sub = (x, y) => x - y;
            Operacao Mult = (x, y) => x * y;

            Console.WriteLine(Somar(2,2));
            Console.WriteLine(Sub(10, 6));
            Console.WriteLine(Mult(10, 10));
        }
    }
}
