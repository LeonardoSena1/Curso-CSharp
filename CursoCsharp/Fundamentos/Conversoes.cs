using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int NotaTruncada = (int)nota;
            Console.WriteLine(NotaTruncada);

            Console.Write("Digite sua idade:");
            string idade = Console.ReadLine();
            int idadestring = int.Parse(idade);
            Console.WriteLine("Idade inserida: {0}", idade);

            idadestring = Convert.ToInt32(idade);
            Console.WriteLine("Resuldato: {0}", idade);


            //digitar um numero e ser convertido em int ou 0
            Console.Write("Digite o primeiro Numero: ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);
            Console.WriteLine("Resultado 1 : {0}", numero1);

            Console.Write("Digite o segundo Numero: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado 2 : {0}", numero2);
        }
    }
}
