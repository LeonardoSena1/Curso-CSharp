using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class SubCelebridade
    {
        //todos
        public string InfoPublico = "Tenho um Instagram !";

        // Herança
        protected string CorDoOlho = "Verde";

        //Mesmo projeto (assembly)
        internal ulong NumeroCelular = 5511930104128;

        //herança ou mesmo projeto
        protected internal string JeitoDeFalar = "Uso Muitas girias";

        //mesma clas ou herança no mesm projeto (C# 7.2)
        private protected string SegredoFamilia = "Bla Bla";

        //private é padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine(InfoPublico);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
