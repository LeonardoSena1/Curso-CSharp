using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.Fundamentos
{
    public class VariaveisEConstantes
    {
        public static void Executar()
        {
            //Area da circuferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3.1415

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("A area é" + area);

            //tipos internos 
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo? " + estaChovendo);

            //byte vai de 0 ate 256
            byte idade = 45;
            Console.WriteLine("idade: " + idade);

            //sbyte é de -128 ate 127
            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de gols" + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salario: " + salario);

            int menovalor = int.MinValue; //mais usado nas aplicações
            Console.WriteLine("menor valor de inteiro: " + menovalor);

            uint populacaobrasileira = 207_206_000_0; // sem sinal
            Console.WriteLine("População brasileira: " + populacaobrasileira);

            long menoValorLong = long.MaxValue;
            Console.WriteLine("Menor Long" + menoValorLong);

            ulong populaomundial = 7_600_888_888_888_888_888;
            Console.WriteLine("População mundial no exemplo: " + populaomundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço do computador " + precoComputador);

            double ValorDeMercadoDaApple = 1_000_000_000_000_000_000.000;  //mais usado nas aplicações
            Console.WriteLine("Valor De Mercado Da Apple: " + ValorDeMercadoDaApple);

            decimal DistanciaEntreAsEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia entre as estrelas: " + DistanciaEntreAsEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra : " + letra);

            string texto = "Bora Programar";
            Console.WriteLine("Texto: " + texto);

        }
    }
}
