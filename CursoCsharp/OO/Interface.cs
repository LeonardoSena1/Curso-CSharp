using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.OO
{
    interface OperacaoBinaria
    {
        int Operacao(int a, int b);
    }

    public class Soma : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a + b;
        }       
    }

    public class Subtracao : OperacaoBinaria
    {
        public int Operacao(int a , int b)
        {
            return a - b;
        }
    }

    public class Multiplicacao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a * b;
        }
    }

    public class Calculadora
    {
        List<OperacaoBinaria> operacao = new List<OperacaoBinaria>()
        {
            new Soma(),
            new Subtracao(),
            new Multiplicacao()
        };

        public string ExecultarOperacao(int a, int b)
        {
            string resultado = "";
            
            foreach(var op in operacao)
            {
                resultado += $"Usando {op.GetType().Name} = {op.Operacao(a, b)} \n";
            }
            return resultado;
        }       
    }

    class Interface
    {
        public static void Executar()
        {
            var calc = new Calculadora();
            var resultado = calc.ExecultarOperacao(2,5);

            Console.WriteLine(resultado);
        }
    }
}
