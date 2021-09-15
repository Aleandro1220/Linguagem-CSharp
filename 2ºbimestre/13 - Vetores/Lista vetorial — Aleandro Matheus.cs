using System;
using System.Linq;

namespace _13___Lista_Vetorial
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
            //Seção de variáveis
            string div = "————————————————————————————————————————————";
            
            //Introdução ao sistema
            Console.WriteLine("\n{0,30}\n{1}", "Lista vetorial", div);
            double num;

            //Inserção dos valores
            Console.WriteLine("Insira os valores desejados:");
            double[] valor = new double[10];

            for (int ind = 0; ind < valor.Length; ind++)
            {
                while (true)
                {
                    Console.Write("\n{0}º número: ", ind + 1);
                    bool tra = double.TryParse(Console.ReadLine(), out num);
                    if (tra)
                        break;
                    Console.WriteLine("\nDigite um algarismo válido: ");
                }
                valor[ind] = num;
            }
            //Exibição dos resultados
            double maior = valor.Max();
            Console.WriteLine("\n{1}\nO maior número é: {0}\n{1}\n", maior, div);
            assinatura();


        }
    }
}
