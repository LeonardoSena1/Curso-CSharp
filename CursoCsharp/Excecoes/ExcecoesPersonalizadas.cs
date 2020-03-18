using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.Excecoes
{
    public class NegativoException : Exception
    {
        public NegativoException() { }
        public NegativoException(string menssage) : base(menssage) { }
        public NegativoException(string menssage, Exception inner) : base(menssage, inner) { }
    }

    public class ImparException : Exception
    {
        public ImparException(string message) : base(message) { }
    }   


    class ExcecoesPersonalizadas
    {
        public static int PositivoPar()
        {
            Random random = new Random();
            int valor = random.Next(-30, 30);

            if (valor < 0)
            {
                throw new NegativoException("Número negativos... :( ");
            }
            if (valor % 2 == 1)
            {
                throw new ImparException("Valor Impar... :(");
            }
            return valor;
        }


        public static void Executar()
        {
            try
            {
                Console.WriteLine(PositivoPar());
            }
            catch(NegativoException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(ImparException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
