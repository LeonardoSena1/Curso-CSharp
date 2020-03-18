using System;
using System.Collections.Generic;

namespace CursoCsharp.Colecoes
{
    // HastSet não é indexOf(numeração em ordem 0,1,2,3,4...) 
    //não aceita duplicar 
    //não tem remoção de item por index
    class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of throne", 49.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);


            var combo = new HashSet<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("8º Temporada Game of Throne", 99.9),
                new Produto("Poster", 10),
                new Produto("Poster", 10)
            };

            carrinho.UnionWith(combo); //add a lista de HastSet
            //carrinho.AddRange(combo); // add a lista completa do combo dentro do carrinho
            Console.WriteLine("Quantidade de itens no Carrinho: " + carrinho.Count); // Contar quantos itens ao total no carrinho
            //carrinho.RemoveAt(3); // fazer remoção de itens 

            foreach (var item in carrinho)
            {
                //Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }


        }
    }
}
