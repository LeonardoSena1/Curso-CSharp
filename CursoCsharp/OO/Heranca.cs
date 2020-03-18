using System;

namespace CursoCsharp.OO
{
    public class Carro
    {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta)
        {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0)
            {
                VelocidadeAtual = 0;
            }
            else if (novaVelocidade > VelocidadeMaxima)
            {
                VelocidadeAtual = VelocidadeMaxima;
            }
            else
            {
                VelocidadeAtual = novaVelocidade;
            }
            return VelocidadeAtual;
        }

        public virtual int Acelerar()
        {
            return AlterarVelocidade(5);
        }
        public virtual int frear()
        {
            return AlterarVelocidade(-5);
        }
    }



    public class Uno : Carro
    {
        public Uno() : base(200) { }

    }

    public class Ferrari : Carro
    {
        public Ferrari() : base(350) { }

        public override int Acelerar()
        {
            return AlterarVelocidade(20);
        }
        public override int frear()
        {
            return AlterarVelocidade(-20);
        }
    }


    class Heranca
    {
        public static void Executar()
        {
            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.frear());
            Console.WriteLine(carro1.frear());
            Console.WriteLine(carro1.frear());
            Console.WriteLine(carro1.frear());
            Console.WriteLine(carro1.frear());


            Console.WriteLine("Ferrari...");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.frear());
            Console.WriteLine(carro2.frear());
            Console.WriteLine(carro2.frear());
            Console.WriteLine(carro2.frear());
            Console.WriteLine(carro2.frear());


            Console.WriteLine("Ferrari com o tipo de carro...");
            Carro carro3 = new Ferrari();
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.frear());
            Console.WriteLine(carro3.frear());
            Console.WriteLine(carro3.frear());


            Console.WriteLine("Uno com o tipo de carro...");
            carro3 = new Uno();
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.frear());
            Console.WriteLine(carro3.frear());
            Console.WriteLine(carro3.frear());
        }
    }
}