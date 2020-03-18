using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            var nome = "Leonardo"; // inferencia tipo string
            Console.WriteLine(nome);

            int idade;
            /*var idade;*/ // precisa colocar um valor dentro ou alterar para int ou inicializar com um valor (var idade = 33)
            idade = 33;
            Console.WriteLine(idade);


            int a;
            a = 3;

            int b = 3;

            Console.WriteLine(a + b);
        
        
        
        }
    }
}
