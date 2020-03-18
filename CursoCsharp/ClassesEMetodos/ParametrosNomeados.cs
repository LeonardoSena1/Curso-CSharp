using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.ClassesEMetodos
{
    class ParametrosNomeados
    {
        public static void Formatar(int dia, int mes, int ano)
        {
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano);
        }

        public static void Executar()
        {
            Formatar(mes: 04, dia: 10, ano: 1996); // inverti o modo de descrever a data e por conta do construtor ele corrige a orgem.
        }
    }
}
