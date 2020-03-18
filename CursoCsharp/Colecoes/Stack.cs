using System;
using System.Collections;

namespace CursoCsharp.Colecoes
{
    
    class ColecoesStack
    {
        public static void Executar()
        {
            Console.WriteLine("Oredem decrescente");
            var pilha = new Stack();
            //Ordem Decrescente
            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach(var t in pilha)
            {
                Console.WriteLine($"{t} ");
            }



            Console.WriteLine("\nremover o primeiro item de baixo pra cima");
            Console.WriteLine($"\nPop (excluir): {pilha.Pop()}"); // remover o primeiro item de baixo pra cima
            foreach(var te in pilha)
            {
                Console.WriteLine($"{te}");
            }



            Console.WriteLine("\npegar o proximo item da fila sem remover.");
            Console.WriteLine($"Peek (mostrando o primeiro): {pilha.Peek()}"); // pegar o proximo item da fila sem remover.
            foreach(var tr in pilha)
            {
                Console.WriteLine($"{tr}");
            }
        }

    }
}
