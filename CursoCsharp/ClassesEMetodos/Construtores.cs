using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.ClassesEMetodos
{
    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano) // Construtor passando parametros
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }

        public Carro() // Construtor Padrão
        {

        }
    }

    class Construtores
    {
        public static void Executar()
        {
            // 1
            var Carro1 = new Carro(); //Carro criado atraves do construtor padrão
            Carro1.Modelo = "325i";
            Carro1.Fabricante = "BMW";
            Carro1.Ano = 2017;
            Console.WriteLine($"{Carro1.Fabricante} {Carro1.Modelo} {Carro1.Ano}");

            //2
            var Carro2 = new Carro("Ka", "Ford", 2015); // carro criado atraves do contrustor feito
            Console.WriteLine($"{Carro2.Fabricante} {Carro2.Modelo} {Carro2.Ano}");

            //3
            var Carro3 = new Carro()
            {
                Fabricante = "Fiat",
                Modelo = "Palio",
                Ano = 2013
            };
            Console.WriteLine($"{Carro3.Fabricante} {Carro3.Modelo} {Carro3.Ano}");
        }
    }
}
