using System;
using System.IO;

namespace CursoCsharp.Api
{
    public static class ExtensaoString
    {
        public static string ParseHome(this string patch)
        {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return patch.Replace("~", home);
        }
    }

    class PrimeiroArquivo
    {
        public static void Executar()
        {
            //Criar um txt na pasta
            var path = @"~/primeiro_arquivo.txt".ParseHome();
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Esse é ");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("arquivo!");
                }                
            }
            //adicionar no mesmo txt criado
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("");
                sw.WriteLine("esse");
                sw.WriteLine("é outro");
                sw.WriteLine("exemplo que da pra fazer!");
            }
            
        }
    }
}
