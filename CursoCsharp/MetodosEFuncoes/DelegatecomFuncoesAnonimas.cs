using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.MetodosEFuncoes
{
    class DelegatecomFuncoesAnonimas
    {
        delegate string StringOperacao(string a); 
        public static void Executar()
        {
            StringOperacao inverter = delegate (string x)
            {
                char[] CharArray = x.ToCharArray();
                Array.Reverse(CharArray);
                return new string(CharArray);
            };

            Console.WriteLine(inverter("C# é Show !!!"));
        }
    }
}
