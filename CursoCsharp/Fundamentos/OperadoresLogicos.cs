using System;

namespace CursoCsharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Execultar()
        {
            var execultouTrabalho1 = true;
            var execultouTrabalho2 = true;

            bool comprouTV50 = execultouTrabalho1 && execultouTrabalho2;
            Console.WriteLine("Comprou a TV de 50? {0}", comprouTV50);

            var comprouSorvete = execultouTrabalho1 || execultouTrabalho2;
            Console.WriteLine("Comprou Sorvete? {0}", comprouSorvete);

            var comprouTV32 = execultouTrabalho1 ^ execultouTrabalho2;
            Console.WriteLine("Comprou a TV 32 {0}", comprouTV32);

            Console.WriteLine("Mais saúdavel? {0}", !comprouSorvete);
        }
    }
}
