using System;

namespace _12_Exibindo_Informações
{
    class Program
    {
        static void assinatura()
        {
            Console.WriteLine("====================================");
            Console.WriteLine("Sistema criado por: Aleandro Matheus");
            Console.WriteLine("====================================");
        }
        static void Main(string[] args)
        {
            //Seção de declaração das variáveis
            string div = "————————————————————————————————————————————————————————————", bem = "BEM VINDO!";
            int qnt, pos = 0, nen = 0;
            double adi = 0, num = 0, maiorNum = -0.5, menorNum = 0.5;
            const int lim = 20;

            //Introdução ao sistema

            Console.Write("\n{0,30}\n{1}\nEsse sistema te mostra informações sobre certos números.\n{1}\n\nPrimeiro, digite a quantidade de valores que deseja: ", bem, div);
            // Validando a entrada do usuário
            while (true)
            {
                bool tra = int.TryParse(Console.ReadLine(), out qnt);

                if (qnt > lim)
                    Console.Write("\nA quantidade máxima é de 20 números!");
                else if (qnt < 0)
                    Console.WriteLine("\nO valor inserido não pode ser negativo!");
                else if (tra)
                    break;
                Console.Write("\nDigite um algarismo válido: ");
            }

            // Inserção de valores pelo usuário
            Console.WriteLine("\nDigite os valores desejados");

            for (int ind = 0; ind < qnt; ind++)
            {
                while (true)
                {
                    Console.Write("\n{0}º número: ", ind + 1);
                    bool tra2 = double.TryParse(Console.ReadLine(), out num);
                    if (tra2)
                        break;
                    Console.WriteLine("\nDigite um algarismo válido: ");
                }

                //Verificando o maior e menor número
                if (ind == 0)
                {
                    maiorNum = num;
                    menorNum = num;
                }
                else if (num > maiorNum)
                    maiorNum = num;
                else if (num < menorNum)
                    menorNum = num;

                adi += num;

                //Contagem de positivos e negativos
                if (num > 0)
                    pos++;
                else
                    nen++;
            }

            //Descobrindo as porcentagens de valores negativos e positivos
            double porMais = ((double)pos / qnt) * 100, porMenos = 100 - porMais;

            //Exibição da quantidade de valores positivos e negativos
            Console.WriteLine($"{div}\nQuantidade de valores positivos: {pos}\nQuantidade de valores negativos: {nen}\n{div}");

            //Exibição do menor e maior número
            Console.WriteLine($"Maior número: {maiorNum}\nMenor número: {menorNum}\n{div}");

            //Exibição da soma de todos os valores
            Console.WriteLine($"Soma dos valores: {adi}\n{div}");

            //Exibição da média aritmética dos valores
            Console.WriteLine("Média aritmética dos valores: {0:F2}\n{1}", adi / qnt, div);

            //Exibição da porcentagem de valores positivos e negativos
            Console.WriteLine("Porcentagem de positivos: {0:F2}%\nPorcentagem de negativos: {1:F2}%\n{2}", porMais, porMenos, div);

            assinatura();
        }
    }
}