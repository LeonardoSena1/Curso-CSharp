using System;

namespace CursoCsharp.ClassesEMetodos
{
    class Props
    {
        public class CarroOpcional
        {
            double Desconto = 0.1;

            string nome;

            public string Nome
            {
                get { return "Opcional: " + nome; }
                set { nome = value; }
            }

            //Propriedades autoimplementada
            public double Preco { get; set; }

            //Somente leitura
            public double PrecoComDesconto { get => Preco - (Desconto * Preco); } //Lambda


            public CarroOpcional() { }

            public CarroOpcional(string nome, double preco)
            {
                Nome = nome;
                Preco = preco;
            }
        }
        public static void Executar()
        {
            var op1 = new CarroOpcional("Ar Condicionado", 3499.9);
            Console.WriteLine(op1.Nome);
            Console.WriteLine("valor R$:" + op1.Preco + "Reais.");
            Console.WriteLine("valor com desconto R$:" + op1.PrecoComDesconto + "reais.");

            Console.WriteLine("===================================");


            var op2 = new CarroOpcional();
            op2.Nome = "Direção Elétrica";
            op2.Preco = 2349.9;
            Console.WriteLine(op2.Nome);
            Console.WriteLine("valor R$:" + op2.Preco + "Reais.");
            Console.WriteLine("valor com desconto R$:" + op2.PrecoComDesconto + "Reais.");
        }
    }
}
