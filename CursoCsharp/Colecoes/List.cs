using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.Colecoes
{
    public class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }


        // usando na IgualdadeEqualseGetHashCode.cs
        public override bool Equals(object obj)
        {
            Produto outroProduto = (Produto)obj;
            bool mesmoNome = Nome == outroProduto.Nome;
            bool mesmoPreco = Preco == outroProduto.Preco;
            return mesmoNome && mesmoPreco;
        }

        public override int GetHashCode() // fara uma comparação de itens. ex: ana, bia, joão, rafa.   ele faz um seleção por Equal de ana e bia  (3 letras), joao e rafa (4 letras)....
        {
            return Nome.Length; // deixa de adcionar informação se for duplicada
        }
    }


    class List
    {        
        public static void Executar()
        {
            var livro = new Produto("Game of throne", 49.9);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);


            var combo = new List<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("8º Temporada Game of Throne", 99.9),
                new Produto("Poster", 10),
                new Produto("Poster", 10)
            };

            carrinho.AddRange(combo); // add a lista completa do combo dentro do carrinho
            Console.WriteLine("Quantidade de itens no Carrinho: " + carrinho.Count); // Contar quantos itens ao total no carrinho
            carrinho.RemoveAt(3); // fazer remoção de itens 

            foreach(var item in carrinho)
            {
                Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }

            
        }
    }
}
