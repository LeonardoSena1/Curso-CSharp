using System;
using System.Globalization;

namespace CursoCsharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual sua idade? ");
            int idade = int.Parse(Console.ReadLine()); // esse metodo faz um parse na string, convertendo em int. "1" => 1

            Console.Write("Qual o seu salario: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Seu nome é : {nome}, e sua idade: {idade}, seu salario: R$: {salario}");
        }
    }
}
