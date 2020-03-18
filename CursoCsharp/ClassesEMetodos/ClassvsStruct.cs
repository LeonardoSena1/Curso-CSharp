using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.ClassesEMetodos
{
    public struct SPonto
    {
        public int X;
        public int Y;
    }
    public class CPonto
    {
        public int X;
        public int Y;
    }

    class ClassvsStruct
    {
        public static void Executar()
        {
            //Struck
            Console.WriteLine("----Struct----");
            SPonto ponto1 = new SPonto { X = 1, Y = 3 };
            SPonto copiaSPonto = ponto1; //Atribuição por VALOR!!!
            ponto1.X = 3;

            Console.WriteLine("Ponto 1 x:{0}", ponto1.X);
            Console.WriteLine("Copia do ponto 1 X:{0}",copiaSPonto.X);




            //Class
            Console.WriteLine("----Class----");
            CPonto ponto2 = new CPonto { X = 2, Y = 4 };
            CPonto copiaCponto = ponto2; //Atreibuição por REFERÊNCIA!!!
            ponto2.X = 4;

            Console.WriteLine("Ponto 2 x:{0}", ponto2.X);
            Console.WriteLine("Copia do ponto 2 x:{0}", copiaCponto.X);
        }

    }
}
