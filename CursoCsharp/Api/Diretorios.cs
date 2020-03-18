using System;
using System.IO;

namespace CursoCsharp.Api
{
    class Diretorios
    {
        public static void Executar()
        {
            var novoDir = @"~/PastCSharp".ParseHome();
            var novoDirDestino = @"~/PastCSharpDestino".ParseHome();
            var dirProjeto = @"~/source/repos/CursoCsharp/CursoCsharp".ParseHome();

            if (Directory.Exists(novoDir))
            {
                Directory.Delete(novoDir, true);
            }
            if (Directory.Exists(novoDirDestino))
            {
                Directory.Delete(novoDirDestino, true);
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir)); //Mostrar a data e hora de criação do projeto


            Console.WriteLine("");

            Console.WriteLine("Pasta que estão no diretorio desse projeto do Curso ");
            var pastas = Directory.GetDirectories(dirProjeto);
            foreach (var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine("\n\n== Arquivos =============");

            var arquivos = Directory.GetFiles(dirProjeto);
            foreach(var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("\n\n ===== Raiz ================");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDir));


            Console.WriteLine("\n\n ===== Mover as pastas===============");
            Directory.Move(novoDir, novoDirDestino);
        }
    }
}