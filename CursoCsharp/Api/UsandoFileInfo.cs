using System;
using System.IO;

namespace CursoCsharp.Api
{
    class UsandoFileInfo
    {
        public static void ExcluirSeExistir(params string[] caminhos)
        {
            foreach (var caminho in caminhos)
            {
                FileInfo arquivo = new FileInfo(caminho);

                if (arquivo.Exists)
                {
                    arquivo.Delete();
                }
            }
        }


        public static void Executar()
        {
            var caminhoOrigem = @"~/arq_origem.txt".ParseHome();
            var caminhoDestino = @"~/arq_destino.txt".ParseHome();
            var caminhoCopia = @"~/arq_copia.txt".ParseHome();

            ExcluirSeExistir(caminhoOrigem, caminhoDestino, caminhoCopia);

            using (StreamWriter sr = File.CreateText(caminhoOrigem))
            {
                sr.WriteLine("Arquivo Original!");
            }

            FileInfo origem = new FileInfo(caminhoOrigem); //acesso as informações
            Console.WriteLine(origem.Name); //Nome do arquivo
            Console.WriteLine(origem.IsReadOnly);// o arquivo permite leitura e escrita ? false ou true
            Console.WriteLine(origem.FullName);// Nome completo do arquivo!
            Console.WriteLine(origem.Extension);// extesion do arquivo
            Console.WriteLine(origem.DirectoryName);//mostrar o caminho completo

            origem.CopyTo(caminhoCopia);//copia o arquivo
            origem.MoveTo(caminhoDestino); // mover o caminho
        }
    }
}
