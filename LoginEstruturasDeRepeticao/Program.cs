using System;

namespace LoginEstruturasDeRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Faça um programa de login, onde o usuário possa tentar digitar 
             * o usuário e a senha um número pré fixado de vezes, caso não consiga
             * o sistema impede novas tentativas.
             */
            string usuario_correto = "aluno";
            string senha_correta = "123";

            int tentativas_permitidas = 3;
            int tentativas = 0;

            /*for(int i=0; i<tentativas_permitidas; i++)
            {
                Console.WriteLine("Informe seu Usuário: ");
                string usuario_informado = Console.ReadLine();

                Console.WriteLine("Informe sua Senha: ");
                string senha_informada = Console.ReadLine();

                tentativas++;

                if(usuario_informado == usuario_correto && senha_informada == senha_correta)
                {
                    Console.WriteLine("Deu certo, bem vindo ao sistema.");
                    break;
                } else
                {
                    Console.WriteLine("Usuário ou senha incorretos. Tentativa {0} de {1}", tentativas, tentativas_permitidas);
                }
            }*/

            string usuario_informado = "";
            string senha_informada = "";

            bool login_valido = false; // ! => NOT (Negação) Negação de false é true e vice versa.

            do
            {
                Console.WriteLine("Informe seu Usuário: ");
                usuario_informado = Console.ReadLine();

                Console.WriteLine("Informe sua Senha: ");
                senha_informada = Console.ReadLine();

                tentativas++;

                // Comparando se informou corretamente.
                if (usuario_informado == usuario_correto && senha_informada == senha_correta)
                {
                    login_valido = true;
                    break; // Conseguiu o objetivo.
                } else
                {
                    Console.WriteLine("Usuário ou senha inválidos.");
                }


                if (tentativas == tentativas_permitidas)
                {
                    Console.WriteLine("Excedeu o número máximo de tentativas");
                    break;
                }

            } while ( !login_valido );


            // Se login_valido = true;
            if(login_valido)
                Console.WriteLine("Ae, bem-vindo ao sistema!");



            Console.WriteLine("Saiu do looping for.");




            Console.ReadKey();


        }
    }
}
