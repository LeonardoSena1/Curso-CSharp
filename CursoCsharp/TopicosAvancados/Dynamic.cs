using System;

namespace CursoCsharp.TopicosAvancados
{
    class Dynamic
    {
        public static void Executar()
        {
            dynamic meuObjeto = "Teste";
            meuObjeto = 3;
            meuObjeto++;

            Console.WriteLine(meuObjeto);

            dynamic Aluno = new System.Dynamic.ExpandoObject();
            Aluno.Nome = "Leonardo";
            Aluno.Idade = 23;
            Aluno.Nota = 8.9;

            Console.WriteLine($"{Aluno.Nome} {Aluno.Idade} {Aluno.Nota}");
        }
    }
}
