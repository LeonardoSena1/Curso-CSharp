using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.ClassesEMetodos
{
    class CalculadoraEstatica
    {
        //Método de classe  ou método estático!!!
        public static int Multiplicar(int a, int b)
        {
            return a + b;
        }
        //Método de instância
        public int Somar(int a, int b)
        {
            return a + b;
        }
    }

    class MetodosEstaticos
    {
        public static void Executar()
        {
            //método estático
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("Resultado da multiplicação de 2 x 2: {0}", resultado);

            //Método de instância
            var calc = new CalculadoraEstatica();
            Console.WriteLine("A soma de 2 + 2: " + calc.Somar(2, 2));
        }
    }
}
