using System;

namespace CursoCsharp.EstruturaDeControle
{
    class EstruturaFOREACH
    {
        public static void Executar()
        {
            var palavra = "Opa!";
            foreach(var teste in palavra)
            {
                Console.WriteLine(teste);
            }

            var alunos = new string [] { "Leonardo", "Bia", "Carla"};
            foreach(var alun in alunos)
            {
                Console.WriteLine(alun);
            }
        }
    }
}
