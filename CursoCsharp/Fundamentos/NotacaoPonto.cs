using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            //ToUpper é deixar todoas a letras maiusculas
            var saudacao = "Olá".ToUpper().Insert(3, " World").Replace("World", "Mundo!");
            Console.WriteLine(saudacao);

            string valornull = null;
            Console.WriteLine(valornull?.Length); //trazer um valor fazio em nulo sem ocorrer erro usa ?.
        }
    }
}
