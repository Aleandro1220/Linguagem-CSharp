using System;
using System.Linq;

namespace _14___System.Linq
{
    class Program
    {
        static void assinatura()
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("Sistema criado por: Aleandro Matheus");
            Console.WriteLine("====================================");
        }

        static void Main(string[] args)
        {
            //Seção de variáveis
            string div = "————————————————————————————————————————————————————————————";
            const int lim = 20;
            int qnt;
            double num = 0;

            //Introdução ao sistema
            Console.WriteLine("\n{0,30}\n{1}\nEsse sistema te mostra informações sobre certos números.\n{1}", "BEM-VINDO!", div);

        Inicio:
            Console.Write("\nPrimeiro, digite a quantidade de valores que deseja: ");

            while (true)
            {
                bool tra = int.TryParse(Console.ReadLine(), out qnt);

                if (qnt >= lim)
                    Console.Write("\nA quantidade máxima é de 20 números!");
                else if (qnt < 0)
                    Console.WriteLine("\nO valor inserido não pode ser negativo!");
                else if (tra)
                    break;
                Console.Write("\nDigite um algarismo válido: ");
            }

            double[] val = new double[qnt];

            for (int ind = 0; ind < val.Length; ind++)
            {
                while (true)
                {
                    Console.Write("\n{0}º número: ", ind + 1);
                    bool tra2 = double.TryParse(Console.ReadLine(), out num);
                    if (tra2)
                        break;
                    Console.WriteLine("\nDigite um algarismo válido: ");
                }
                val[ind] = num;
            }

            //Extração das informações da sequência informada
            int pos = val.Count(num => num > 0);
            int nen = val.Count(num => num < 0);
            double mai = val.Max();
            double men = val.Min();
            double adi = val.Sum();
            double med = val.Average();

            Console.Clear();

            //Exibição da quantidade de valores positivos e negativos
            Console.WriteLine($"{div}\nQuantidade de valores positivos: {pos}");
            Console.WriteLine($"Quantidade de valores negativos: {nen}\n{div}");

            //Exibição do menor e maior número
            Console.WriteLine($"Maior número: {mai}\nMenor número: {men}\n{div}");

            //Exibição da soma de todos os valores
            Console.WriteLine($"Soma dos valores: {adi}\n{div}");

            //Exibição da média aritmética dos valores
            Console.WriteLine("Média aritmética : {0:F2}\n{1}", med, div);

            //Exibição da porcentagem de valores positivos e negativos
            Console.WriteLine("Porcentagem de positivos: {0:F2}%", ((double)pos / qnt) * 100);
            Console.WriteLine("Porcentagem de negativos: {0:F2}%\n{1}", ((double)nen / qnt) * 100, div);

            //Nova consulta
            Console.WriteLine("\nPressione <Enter> para fazer uma nova pesquisa,\nou <Esc> para finalizar a sessão.");

            while (true)
            {
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key == ConsoleKey.Enter)
                    goto Inicio;
                else if (info.Key == ConsoleKey.Escape)
                    break;
                Console.WriteLine("\nComando inválido!");
            }
            assinatura();
        }
    }
}