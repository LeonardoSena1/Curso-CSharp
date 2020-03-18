using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.ClassesEMetodos
{
    class CalculadoraComum
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Multiplicacao(int a, int b)
        {
            return a * b;
        }
    }

    class CalculadoraCadeia
    {
        int memoria;

        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;
            return this;
        }

        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }
        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }
        public int Resultado()
        {
            return memoria;
        }
    }

    class MetodosComRetorno
    {
        public static void Executar()
        {
            // class CalculadoraComum
            var CaculadoraComum = new CalculadoraComum();
            var restultado = CaculadoraComum.Somar(5, 5);

            Console.WriteLine(restultado);
            Console.WriteLine(CaculadoraComum.Subtrair(10, 5));
            Console.WriteLine(CaculadoraComum.Multiplicacao(2, 10));


            //class CalculadoraCadeia
            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();

            restultado = calculadoraCadeia.Somar(2).Multiplicar(3).Resultado();
            Console.WriteLine(restultado);
        }
    }
}
