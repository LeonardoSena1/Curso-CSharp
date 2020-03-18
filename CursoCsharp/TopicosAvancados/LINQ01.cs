using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCsharp.TopicosAvancados
{
    public class Aluno
    {
        public string Nome;
        public int Idade;
        public double Nota;
    }

    class LINQ01
    {
        public static void Executar()
        {
            var alunos = new List<Aluno>
            {
              new Aluno() {Nome = "Pedro", Idade = 22, Nota = 8.1},
              new Aluno() {Nome = "Henrique", Idade = 21, Nota = 6.1},
              new Aluno() {Nome = "Ana", Idade = 23, Nota = 9.4},
              new Aluno() {Nome = "Nathalia", Idade = 22, Nota = 9.8},
              new Aluno() {Nome = "Nancy", Idade = 17, Nota = 7.7},
              new Aluno() {Nome = "Ivan", Idade = 29, Nota = 4.8},
              new Aluno() {Nome = "Gabriel", Idade = 20, Nota = 3.1},
              new Aluno() {Nome = "Fernanda", Idade = 25, Nota = 6.5}
            };

            Console.WriteLine("Aprovados acima de 5");
            var aprovados = alunos.Where(a => a.Nota >= 5).OrderBy(a => a.Nome);
            foreach (var aluno in aprovados)
            {
                Console.WriteLine(aluno.Nome);
            }

            Console.WriteLine("Aprovado acima de 8");
            var aprovado = alunos.Where(a => a.Nota >= 8);
            foreach (var aluno in aprovado)
            {
                Console.WriteLine(aluno.Nota);
            }


            Console.WriteLine("\n Chamada de alunos");
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);
            foreach (var aluno in chamada)
            {
                Console.WriteLine(aluno);
            }

            Console.WriteLine("\nAprovado (por idade)");
            var alunosAprovados = from aluno in alunos
                                  where aluno.Nota >= 7 
                                  orderby aluno.Idade 
                                  select aluno.Nome;
            foreach(var aluno in alunosAprovados)
            {
                Console.WriteLine(aluno);
            }

        }
    }
}
