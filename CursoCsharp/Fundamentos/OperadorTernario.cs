using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.Fundamentos
{
    class OperadorTernario
    {
        public static void Execultar()
        {
            var nota = 5.0;          
            string resultado = nota <= 5.0 ? "Aprovado" : "Reprovado"; // ternario
            Console.WriteLine(resultado);


            var nota1 = 9.0;
            bool BomComportamento = true;
            string resultado1 = nota1 >= 7.0 && BomComportamento ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado1);
        }
    }
}
