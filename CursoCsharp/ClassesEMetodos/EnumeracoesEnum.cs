using System;

namespace CursoCsharp.ClassesEMetodos
{
    class EnumeracoesEnum
    {
        public enum Genero { Acao, Aventura, Terror, Animacao, Comedia};
        public class Filme
        {
            public string Titulo;
            public Genero GeneroFoFilme;
        }

        public static void Executar() 
        {
            int a = (int)Genero.Acao;
            int b = (int)Genero.Aventura;
            int c = (int)Genero.Terror;
            int d = (int)Genero.Animacao;
            int e = (int)Genero.Comedia;
            Console.WriteLine(a + " Acao");
            Console.WriteLine(b + " Aventura");
            Console.WriteLine(c + " Terror");
            Console.WriteLine(d + " Animacao");
            Console.WriteLine(e + " Comedia");

            Console.WriteLine("========================");

            var FilmeParaFamilia = new Filme();
            FilmeParaFamilia.Titulo = "Sharkeado 17";
            FilmeParaFamilia.GeneroFoFilme = Genero.Comedia;
            Console.WriteLine("{0} é {1}", FilmeParaFamilia.Titulo, FilmeParaFamilia.GeneroFoFilme);
        }
    }
}
