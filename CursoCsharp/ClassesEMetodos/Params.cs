using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.ClassesEMetodos
{
    class Params
    {
        public static void Recepcionar(params string[] pessoas)
        {
            foreach(var Pessoa in pessoas)
            {
                Console.WriteLine("Olá {0}", Pessoa);
            }
        }


        public static void Executar()
        {
            Recepcionar("Leonardo", "Roger", "Ana", "Jessica","João","Gisele","Nathalia", "Sandro", "Ivan","Nancy","Gabriel", "Fernanda");
        }
    }
}
