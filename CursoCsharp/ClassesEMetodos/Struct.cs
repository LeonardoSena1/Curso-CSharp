namespace CursoCsharp.ClassesEMetodos
{
    interface Ponto
    {
        void MoverNaDiagonal(int delta);
    }

    struct Coordenada : Ponto
    {
        public int X;
        public int Y;

        public Coordenada(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void MoverNaDiagonal(int delta)
        {
            X += delta;
            Y += delta;
        }
    }


    class Struct
    {
        public static void Executar()
        {
            Coordenada coordenadaInicial;
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;

            System.Console.WriteLine("Coordenada inicial");
            System.Console.WriteLine("X = {0}", coordenadaInicial.X);
            System.Console.WriteLine("Y = {0}", coordenadaInicial.Y);


            var CoordenacaoFinal = new Coordenada(x: 9, y: 1);
            CoordenacaoFinal.MoverNaDiagonal(10);

            System.Console.WriteLine("Coordenada Final");
            System.Console.WriteLine("X = {0}", CoordenacaoFinal.X);
            System.Console.WriteLine("Y = {0}", CoordenacaoFinal.Y);
        }
    }
}
