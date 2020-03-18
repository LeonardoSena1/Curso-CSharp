using System;

namespace CursoCsharp.Colecoes
{
    class Array
    {
        public static void Executar()
        {
            // 1 exemplo de Array
            string[] Alunos = new string[5];
            Alunos[0] = "Leonardo";
            Alunos[1] = "Gabriel";
            Alunos[2] = "Nathalia";
            Alunos[3] = "Nancy";
            Alunos[4] = "Ivan";

            foreach (var aluno in Alunos)
            {
                Console.WriteLine(aluno);
            }



            //2 exemplo de arrey
            double somatorio = 0;
            double[] notas = { 9.7, 9.4, 4.9, 6.5, 6.5, 3.5, 5.6 };

            foreach (var nota in notas)
            {
                somatorio += nota;
            }
            double media = somatorio / notas.Length;
            Console.WriteLine(media);



            // 3 exemplo de array
            char[] Letras = { 'A', 'R', 'R', 'A', 'Y' };
            string palavra = new string(Letras);
            Console.WriteLine(palavra);

        }
    }
}
