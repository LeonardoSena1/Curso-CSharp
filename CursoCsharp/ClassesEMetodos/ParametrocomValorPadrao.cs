using System;

namespace CursoCsharp.ClassesEMetodos
{
    class ParametrocomValorPadrao
    {
        public static int Somar(int a = 1, int b = 1)
        {
            return a + b;
        }


        public static void Executar()
        {
            Console.WriteLine("Soma entre 10 + 23: " + Somar(10,23));
            Console.WriteLine("Passar só o 50 ele soma com o outro construtor. " + Somar(50));
            Console.WriteLine("Soma automatico dentro do construtor: " + Somar());
            Console.WriteLine("Valor 10 mais valor que esta no construtor que é 1: " + Somar(a: 10));
            Console.WriteLine("Valor 7 mais valor que esta no construtor que é 1: " + Somar(b: 7));
        }
    }
}
