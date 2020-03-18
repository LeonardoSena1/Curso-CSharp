using System;
using System.Collections.Generic;
using System.Text;


//Acesso a Composição

namespace Encapsulamento
{
    public class AmigoProximo
    {
        //instancia
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("Class Amigo Proximo....");

            Console.WriteLine(amiga.InfoPublico);
            //Console.WriteLine(amiga.CorDoOlho);
            Console.WriteLine(amiga.NumeroCelular);
            Console.WriteLine(amiga.JeitoDeFalar);
            //Console.WriteLine(amiga.SegredoFamilia);
            //Console.WriteLine(amiga.UsaMuitoPhotoshop);
        }
    }
}
