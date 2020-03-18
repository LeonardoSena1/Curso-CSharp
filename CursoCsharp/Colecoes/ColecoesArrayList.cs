using System;
using System.Collections;


namespace CursoCsharp.Colecoes
{
    class ColecoesArrayList
    {
        public static void Executar()
        {
            var lista = new ArrayList {"Palavra", 3, true };

            lista.Add(3.45);
            foreach(var t in lista)
            {
                Console.WriteLine("{0} => {1}", t, t.GetType());
            }
        }
    }
}
