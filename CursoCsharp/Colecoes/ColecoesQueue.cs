using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace CursoCsharp.Colecoes
{
    class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>(); // esse usa o using System.Collections.Generic;
            fila.Enqueue("Leonardo");
            fila.Enqueue("Sicano");
            fila.Enqueue("Beutrano");

            Console.WriteLine("Primeiro da fila: " + fila.Peek());// mostra o primeiro da lista, sem remover ele da lista
            Console.WriteLine("Quantidade de pessoas na fila: " + fila.Count);// provar que nao saiu da fila, mostra em numeração

            Console.WriteLine("==============================");

            Console.WriteLine("Excluir da fila: " + fila.Dequeue());// remover o primeiro da fila
            Console.WriteLine("Quantidade de pessoas na fila: " + fila.Count);

            Console.WriteLine("==============================");

            foreach(var pessoa in fila)
            {
                Console.WriteLine("Proximos da fila: " + pessoa);
            }

            Console.WriteLine("==============================");

            var salada = new Queue(); // esse usa o using System.Collections;
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            foreach(var t in salada)
            {
                Console.WriteLine("Lista de Queue: " + t);
            }
        }
    }
}
