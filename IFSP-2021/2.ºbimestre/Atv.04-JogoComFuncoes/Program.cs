using System;

namespace Jogo_decisões_Aleandro_Matheus
{
    class Program
    {
        static void AssinaturaDoCriador()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Jogo criado por: Aleandro Matheus");
            Console.WriteLine("=================================");
        }
        static void PressioneEnter()
        {
            Console.Write("Pressione 'Enter' para continuar");
            Console.ReadLine();
            Console.Clear();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\nBem vindo ao jogo 'Mestre Confeiteiro'\n");

            Console.Write("Defina seu nome de confeiteiro: ");
            string name = Console.ReadLine();

            Console.Write("\nDefina seu nome de sua confeitaria: ");
            string enter = Console.ReadLine();

            Console.Clear();

        // Início da história
        Inicio:
            Console.WriteLine("Lá estava {0} em sua confeitaria chamada {1}, até que entra uma bela moça de cabelos longos e negros em sua loja.\n{0} fica desesperado(a), pois suas mãos estavam completamente sujas de farinha...\nE então a moça diz:\n— Bom dia! Eu Gostaria de um bolo de um bolo de cenoura.\n ", name, enter);
            PressioneEnter();
            Console.Clear();

            Console.WriteLine("Bom, seu desafio será cozinhar um bolo de cenoura.\nPara isso, preste muita atenção nos seguintes ingredientes:\n");
        Ingredientes:
            Console.WriteLine("- 3 cenouras raladas\n- 4 ovos\n- 2 de farinha de trigo\n- 1 colher de fermento em pó\n- 2 xícaras de açúcar\n- 1 xícara de óleo\n");
            PressioneEnter();
            Console.Clear();

            // Desafio

            Console.Write("\nQuantas cenouras você precisa? ");
            int cenoura = int.Parse(Console.ReadLine());

            Console.Write("\nQuantos ovos você precisa? ");
            int ovos = int.Parse(Console.ReadLine());

            Console.Write("\nQuantas xícaras de farinha você precisa? ");
            int farinha = int.Parse(Console.ReadLine());

            Console.Write("\nQuantas colheres de fermento você precisa? ");
            int fermento = int.Parse(Console.ReadLine());

            Console.Write("\nQuantas xícaras de açúcar você precisa? ");
            int acucar = int.Parse(Console.ReadLine());

            Console.Write("\nQuantas xícaras de óleo você precisa? ");
            int oleo = int.Parse(Console.ReadLine());

            Console.Clear();

            // Verificação dos ingredientes

            if (cenoura > 3)
            {
                Console.WriteLine("\nA moça disse: 'cenoura demais!'\n");
                PressioneEnter();
                goto Ingredientes;
            }
            else if (cenoura < 3)
            {
                Console.WriteLine("\nA moça disse: 'sabor fraco!'\n");
                PressioneEnter();
                goto Ingredientes;
            }
            else if (ovos < 4)
            {
                Console.WriteLine("\nSeu bolo falta ovos!\n");
                PressioneEnter();
                goto Ingredientes;
            }
            else if (ovos > 4)
            {
                Console.WriteLine("\nSeu bolo tem ovos demais!\n");
                PressioneEnter();
                goto Ingredientes;
            }
            else if (farinha < 2)
            {
                Console.WriteLine("\nA moça disse: 'o bolo está muito úmido!'\n");
                PressioneEnter();
                goto Ingredientes;
            }
            else if (farinha > 2)
            {
                Console.WriteLine("\nA moça disse: 'o bolo está muito massudo!'\n");
                PressioneEnter();
                goto Ingredientes;
            }
            else if (fermento != 1)
            {
                Console.WriteLine("\nSeu bolo cresceu tanto que sujou todo o forno!\n");
                PressioneEnter();
                goto Ingredientes;
            }
            else if (acucar > 2)
            {
                Console.WriteLine("\nA moça disse: 'Que bolo enjoativo!'\n");
                PressioneEnter();
                goto Ingredientes;
            }

            else if (acucar < 2)
            {
                Console.WriteLine("\nA moça disse: 'o bolo está sem graça!'\n");
                PressioneEnter();
                goto Ingredientes;
            }
            else if (oleo != 1)
            {
                Console.WriteLine("\nA moça disse: 'Que bolo oleoso!'\n");
                PressioneEnter();
                goto Ingredientes;
            }
            else
            {
                Console.WriteLine("{0} entrega seu bolo à moça de cabelos longos e...\n", name);
                PressioneEnter();
                Console.WriteLine("O bolo está maravilhoso!! Parabéns {0}. Sem dúvidas recomendarei a {1} para todos os meus amigos!\n", name, enter);

                //Jogar novamente ou finalizar a sessão
                Console.WriteLine("\nPressione <Enter> para jogar novamente,\nou <Esc> para finalizar a sessão.");
                while (true)
                {
                    ConsoleKeyInfo info = Console.ReadKey();
                    if (info.Key == ConsoleKey.Enter)
                        goto Inicio;
                    else if (info.Key == ConsoleKey.Escape)
                        break;
                    Console.WriteLine("\nComando inválido!");
                }
                AssinaturaDoCriador();
            }
        }
    }
}
