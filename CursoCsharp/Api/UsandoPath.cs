using System;
using System.IO;

namespace CursoCsharp.Api
{
    class UsandoPath
    {
        public static void Executar()
        {
            var arquivo = @"~/exemplo_path_arquivo.txt".ParseHome();
            var pasta = @"~/exemplo_path_pasta".ParseHome();

            if (!File.Exists(arquivo))
            {
                using (StreamWriter sw = File.CreateText(arquivo))
                {
                    sw.WriteLine("Um novo arquivo criado !!!");
                }
            }

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            Console.WriteLine(Path.GetExtension(arquivo)); //Extensao do arquivo
            Console.WriteLine(Path.GetFileName(arquivo)); // Nome do arquivo
            Console.WriteLine(Path.GetFileNameWithoutExtension(arquivo));// pegando o nome sem a extensao
            Console.WriteLine(Path.GetDirectoryName(arquivo));//passa o arquivo e recebe o diretorio
            Console.WriteLine(Path.HasExtension(arquivo)); // verificar se tem extensao

            Console.WriteLine(Path.HasExtension(pasta)); // verificar se tem extensao
            Console.WriteLine(Path.GetFullPath(pasta)); // mostrar o caminho completo da pasta
            Console.WriteLine(Path.GetPathRoot(pasta)); // mostrar a raiz da pasta

        }
    }
}
