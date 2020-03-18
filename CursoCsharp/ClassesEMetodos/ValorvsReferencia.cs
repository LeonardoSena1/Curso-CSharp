using System;

namespace CursoCsharp.ClassesEMetodos
{
    public class Dependente // se mudar o class para struct muda o comportamento de copia no resultado final do algoritmo
    {
        public string Nome;
        public int Idade;
    }
    class ValorvsReferencia
    {
        public static void Executar()
        {
            int numero = 3;
            int CopiaNumero = numero;
            Console.WriteLine($"{numero} {CopiaNumero}");

            numero++;
            Console.WriteLine($"{numero} {CopiaNumero}");

            Dependente dep = new Dependente
            {
                Nome = "Beto",
                Idade = 44
            };

            Dependente copiaDep = dep;
            copiaDep.Nome = "Leo";
            copiaDep.Idade = 23;

            Console.WriteLine($"Nome Original: {dep.Nome} Copia: {copiaDep.Nome}");
            Console.WriteLine($"Idade Original: {dep.Idade} Copia: {copiaDep.Idade}");            

            Console.WriteLine($"Nome Original: {dep.Nome} Copia: {copiaDep.Nome}");
            Console.WriteLine($"idade Original: {dep.Idade} Copia: {copiaDep.Idade}");
        }
    }
}
