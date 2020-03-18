using System;
using System.Collections.Generic;
using System.Text;

//Acesso a herança


namespace Encapsulamento
{
    public class FilhoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("Class Filho Reconhecido");

            Console.WriteLine(InfoPublico);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            //Console.WriteLine(UsaMuitoPhotoshop); não tem acesso à UsaMuitoPhotoshop, somente na mesma class o acesso private

        }
    }
}
