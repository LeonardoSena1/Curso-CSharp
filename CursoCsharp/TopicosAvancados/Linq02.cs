using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCsharp.TopicosAvancados
{  
    class Linq02
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
              new Aluno() {Nome = "Ivan", Idade = 25, Nota = 9.8},
              new Aluno() {Nome = "Gabriel", Idade = 20, Nota = 3.1},
              new Aluno() {Nome = "Fernanda", Idade = 25, Nota = 6.5}
            };

            var aluno = alunos.Single(aluno => aluno.Nome.Equals("Nancy")); // filtar apenas um aluno na lista
            Console.WriteLine($"{aluno.Nome} {aluno.Nota}");

            var fulano = alunos.SingleOrDefault(a => a.Nome.Equals("fulano"));
            if(fulano == null)
            {
                Console.WriteLine("Aluno Inexistente!");
            }
            else { Console.WriteLine($"{fulano.Nome}"); }




            var ivan = alunos.First(a => a.Nome.Equals("Ivan"));
            Console.WriteLine(ivan.Nota);

            var sicrano = alunos.FirstOrDefault(a => a.Nome.Equals("Iva"));
            if(sicrano == null)
            {
                Console.WriteLine("Aluno inexistente!");
            }
            else { Console.WriteLine($"{sicrano.Nome}"); }

            var exemploSkip = alunos.Skip(1).Take(3); // pegue 3 aluno pulando 1
            foreach(var item in exemploSkip)
            {
                Console.WriteLine(item.Nome);
            }


            var maiorNota = alunos.Max(a => a.Nota);
            Console.WriteLine(maiorNota);

            var menorNota = alunos.Min(a => a.Nota);
            Console.WriteLine(menorNota);

            var somarNotas = alunos.Sum(a => a.Nota);
            Console.WriteLine(somarNotas);

            var mediaNota = alunos.Average(a => a.Nota);
            Console.WriteLine(menorNota);
            
            var mediaNotaMaiorQ7 = alunos.Where(a => a.Nota > 7).Average(a => a.Nota);
            Console.WriteLine(mediaNotaMaiorQ7);
        }
    }
}
