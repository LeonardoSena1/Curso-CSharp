using System;
using System.IO;

namespace CursoCsharp.Api
{
    class ExemploDirectoryInfo
    {
        public static void Executar()
        {
            var dirProjeto = @"~/source/repos/CursoCsharp/CursoCsharp".ParseHome();

            var dirInfo = new DirectoryInfo(dirProjeto);

            Console.WriteLine("== Arquivos =================");
            var arquivos = dirInfo.GetFiles();
            foreach(var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("== Diretorios ===========");
            var pastas = dirInfo.GetDirectories();
            foreach(var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }
            Console.WriteLine("");
            Console.WriteLine("CreateionTime");
            Console.Write(dirInfo.CreationTime);


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("FullName");
            Console.Write(dirInfo.FullName);


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Root");
            Console.Write(dirInfo.Root);


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Parent");
            Console.Write(dirInfo.Parent);
            Console.WriteLine("");
        }
    }
}
