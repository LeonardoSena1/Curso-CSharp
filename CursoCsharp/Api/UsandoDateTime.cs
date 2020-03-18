using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CursoCsharp.Api
{
    class UsandoDateTime
    {
        public static void Executar()
        {
            var dateTime = new DateTime(year: 2033, month: 2, day: 10);

            Console.WriteLine(dateTime.Year);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Day);

            //sem horas
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            //Com horas
            var diaAtual = DateTime.Now;
            Console.WriteLine(diaAtual);
            Console.WriteLine("Hora: " + diaAtual.Hour);
            Console.WriteLine("Minutos: " + diaAtual.Minute);

            var amanha = diaAtual.AddDays(1);
            Console.WriteLine(amanha);

            var ontem = diaAtual.AddDays(-1);

            Console.WriteLine(diaAtual.ToString("dd"));
            Console.WriteLine(diaAtual.ToString("d"));
            Console.WriteLine(diaAtual.ToString("D"));
            Console.WriteLine(diaAtual.ToString("g"));
            Console.WriteLine(diaAtual.ToString("G"));
            Console.WriteLine(diaAtual.ToString("dd-mm-yyyy HH:mm"));

        }
    }
}
