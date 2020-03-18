using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.MetodosEFuncoes
{
    class ExemploLambda
    {
        public static void Executar()
        {
            Action AlgoNoConsole = () =>
            {
                Console.WriteLine("Lambda com C#!!!");
            };
            AlgoNoConsole();

            Func<int> JogarDados = () =>
            {
                Random dados = new Random();
                return dados.Next(1, 6);
            };
            Console.WriteLine(JogarDados());

            Func<int, string> conversorHax = numero => numero.ToString("X");
            Console.WriteLine(conversorHax(1234));

            Func<int, int, int, string> data = (Dia, Mes, Ano) => string.Format("{0:D2}/{1:D2}/{2:D4}", Dia, Mes, Ano);
            Console.WriteLine(data(6, 2, 2020));
        }
    }
}
