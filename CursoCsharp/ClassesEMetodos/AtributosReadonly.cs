using System;

namespace CursoCsharp.ClassesEMetodos
{
    class AtributosReadonly
    {
        public class Cliente
        {
            //readonly ele pode ser inicializado dentro do construtor
            public string Nome;
            DateTime Nascimento;

            public Cliente(string nome, DateTime nascimento)
            {
                Nome = nome;
                Nascimento = nascimento;
            }

            public string GetDataNascimento()
            {
                return String.Format("{0}/{1:D2}/{2}"
                    , Nascimento.Day
                    , Nascimento.Month
                    , Nascimento.Year);
            }
        }


        public static void Executar()
        {
            var NovoCliente = new Cliente("Leonardo Sena", new DateTime(1996, 04, 10));

            Console.WriteLine(NovoCliente.Nome);
            Console.WriteLine(NovoCliente.GetDataNascimento());
        }
    }
}
