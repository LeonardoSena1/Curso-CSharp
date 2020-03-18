using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.ClassesEMetodos
{
    class Mebros
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Leonardo";
            sicrano.Idade = 23;

            //Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos. ");

            sicrano.ApresentarNoConsole();
            sicrano.Zerar();
            sicrano.ApresentarNoConsole();

            //Outro exemplo
            var fulano = new Pessoa();
            fulano.Nome = "Teste";
            fulano.Idade = 20;

            var ApresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(ApresentacaoDoFulano.Length);
            Console.WriteLine(ApresentacaoDoFulano);
        }
    }
}
