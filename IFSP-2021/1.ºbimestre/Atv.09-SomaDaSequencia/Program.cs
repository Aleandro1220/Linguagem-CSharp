using System;

namespace _09___Soma_da_Sequência
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
            //Seção de declaração de variáveis
            string div = "————————————————————————————————————————————————————",intro = "Soma da sequência N", fra = "————";
            const int lim = 50;
            int qnt;
            double soma = 0;

            //Introdução ao código
            Console.WriteLine("{1}\n{0,35}\n{1}", intro, div);

            Console.Write("Existe a sequência seguinte : 1/2; 2/3; 3/4...\nPara saber a soma de todos os elementos,\nInsira a o tamanho da sequência: ");

            //Entrada do usuário + verificação
            while (true)
            {
                bool tra = int.TryParse(Console.ReadLine(), out qnt);
                if (qnt >= lim)
                    Console.WriteLine("\nA sequência deve ser menor que 50!");
                else if (qnt < 0)
                    Console.WriteLine("\nO valor inserido não pode ser negativo!");
                else if (tra)
                    break;
                Console.Write("\nDigite um algarismo válido: ");
            }
            Console.Clear();

            //Cálculos
            for (double num = 0, den = 2; num++ < qnt; den++)
            {
                Console.WriteLine($"\n{num, 7}\n{fra, 8}\n{den, 7}\n");
                soma += num / den;
            }

            //Exibição do resultado
            Console.WriteLine($"{div}\nA soma dessas operções é: {soma:F2}\n{div}\n");
            assinatura();
        }
    }
}