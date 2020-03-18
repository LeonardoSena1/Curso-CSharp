﻿using System;

namespace CursoCsharp.Excecoes
{
    public class Conta
    {
        double Saldo;

        public Conta(double saldo)
        {
            Saldo = saldo;
        }
        public void Sacar(double valor)
        {
            if(valor > Saldo)
            {
                throw new ArgumentException("Saldo Insuficiente");
            }

            Saldo -= valor;
        }
    }

    class PrimeiraExcecao
    {
        public static void Executar()
        {
            var conta = new Conta(1_256.45);
            try
            {
                conta.Sacar(1300);
                Console.WriteLine("Retirada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Obrigado!!!");
            }
        }
    }
}
