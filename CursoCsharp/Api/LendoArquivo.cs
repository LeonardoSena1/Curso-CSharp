using System;
using System.IO;

namespace CursoCsharp.Api
{
    class LendoArquivo
    {
        public static void Executar()
        {
            //Criando um arquivo
            var path = @"~/Lendo_arquivo.txt".ParseHome();
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Produto; Preco; Qtde");
                    sw.WriteLine("Caneta Bic Preta; 3.59, 89");
                    sw.WriteLine("Borracha Branca; 2.89; 27");
                }
            }

            //Lendo o arquivo no console do C#
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    var texto = sr.ReadToEnd();
                    Console.WriteLine(texto);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
