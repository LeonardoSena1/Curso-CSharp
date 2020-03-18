using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.MetodosEFuncoes
{
    class DelegatesUsando
    {
        delegate double Soma(double a, double b);
        delegate void ImprimirSoma(double a, double b);

        static double MinhaSoma(double x, double y)
        {
            return x + y;
        }
        static void MeuImprimirSoma(double a, double b)
        {
            Console.WriteLine(a + b);
        }





        public static void Executar()
        {
            Soma soma = MinhaSoma;
            Console.WriteLine(soma(2.2, 10));

            ImprimirSoma imp = MeuImprimirSoma;
            imp(1, 6.0);

            Func<double, double, double> op3 = MinhaSoma;
            Console.WriteLine(op3(44.2, 56));

            Action<double, double> op4 = MeuImprimirSoma;
            op4(1, 6.2);
        }
    }
}
