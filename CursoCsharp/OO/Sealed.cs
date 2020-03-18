using System;

namespace CursoCsharp.OO
{
    sealed class SemFilho
    {
        public double ValorDaFortuna()
        {
            return 1_407_033.65;
        }
    }

    //class SouFilho : SemFilho // não pode receber heranca uma class sealed
    //{

    //}

    class Avo
    {
        public virtual bool HonrarNomeFamilia()
        {
            return true;
        }
    }

    class Pai : Avo
    {
        public sealed override bool HonrarNomeFamilia()
        {
            return true;
        }
    }

    class FilhoRebelde : Pai
    {
        //public new bool HonrarNomeFamilia() // metodo ocultando o sealed do pai : Avo
        //{
        //    return false;
        //}

    }

    class Sealed
    {
        public static void Executar()
        {
            SemFilho  Semfilho = new SemFilho();
            Console.WriteLine(Semfilho.ValorDaFortuna());

            FilhoRebelde filhoRebelde = new FilhoRebelde();
            Console.WriteLine(filhoRebelde.HonrarNomeFamilia());
        }
    }
}
