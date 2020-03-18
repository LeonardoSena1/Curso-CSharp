using System;

namespace CursoCsharp.ClassesEMetodos
{
    class DesafioAcessarAtributo
    {
        int a = 10;

        public static void Executar()
        {
            //Acessar a variavel "a" dentro do metodo executar!
            //Console.WriteLine(a);

            // vou acessar a instancia DesafioAcessarAtributo para ter acessi no meu static Executar
            DesafioAcessarAtributo desafio = new DesafioAcessarAtributo();
            Console.WriteLine(desafio.a);

            // ou poderia mudar no DesafioAcessarAtributo ( static int a = 10 ) e teria o acesso via static
        }
    }
}
