using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.Fundamentos
{
    class OperadoresUnarios
    {
        public static void Execultar()
        {
            var ValorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-ValorNegativo); // Regra simples de - com - = +      e       + com - = -. 
            Console.WriteLine(!booleano); // inverte a logica se for true vira false

            numero1++; //Incremento, pós fixado
            Console.WriteLine(numero1);

            --numero1; //decremento, fixado
            Console.WriteLine(numero2);
        }
    }
}
