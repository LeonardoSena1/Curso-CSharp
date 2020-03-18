using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.Colecoes
{
    class ColecoesDictionary
    {
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Os Incriveis");
            filmes.Add(2006, "O Grande Truque");

            if (filmes.ContainsKey(2004)) // pegar um item do Dictionary pela chave KEY
            {
                Console.WriteLine("2004: " + filmes[2004]); // esse metodo se não existir o 2004 vai ocorrer um erro
                Console.WriteLine("2006: " + filmes.GetValueOrDefault(2006)); // esse metodo se não existir ele traz o valor null, sem erro
            }

            Console.WriteLine("Esse filme tem na lista Dictionary? " + filmes.ContainsValue("Ámenesia")); // traz true ou false

            Console.WriteLine($"Gladiador, ano 2000 foi removido? {filmes.Remove(2000)}"); // esse metodo remove ele remove e mostra um msg de false ou true

            filmes.TryGetValue(2002, out string filme2002); // outra maneira de trazer o dado, se não existir não ocorre erro
            Console.WriteLine($"Filme {filme2002}!");



            // percorrer o Dictionary

            Console.WriteLine("");
            Console.WriteLine("Percorrer toda a lista trazendo o ano");
            foreach(var chave in filmes.Keys) // percorrer toda a lista (2000 foi excluido)
            {
                Console.WriteLine(chave);
            }

            Console.WriteLine("");
            Console.WriteLine("Percorrer toda a lista trazendo o nome do filme");
            foreach(var nome in filmes.Values) // percorrer toda a lista (Gladiador foi excluido)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("");
            Console.WriteLine("Percorrer toda a lista trazendo o Nome e o Ano do filme");
            foreach(KeyValuePair<int, string> Filme in filmes)
            {
                Console.WriteLine($"{Filme.Value} é de {Filme.Key}");
            }

            Console.WriteLine("");
            Console.WriteLine("Percorrer toda a lista trazendo o Nome e o Ano do filme de outra forma mais facil");
            foreach(var filme in filmes)
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }
        }
    }
}
