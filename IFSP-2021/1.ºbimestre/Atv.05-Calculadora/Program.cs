using System;

namespace _05___Calculadora
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
            var div = "------------------------------------";
            double result;

            // Introdução ao sistema
            Console.WriteLine("\nBem vindo à calculadora básica ao máximo!\n");

            // Inserção dos valores e operador
            Console.Write("{0}\nInsira o 1º valor: ", div);
            double numero1 = double.Parse(Console.ReadLine());

            Console.Write("{0}\nDefina a operação (+; -; / ou *): ", div);
            string sinal = (Console.ReadLine());

            Console.Write("{0}\nInsira o 2º valor: ", div);
            double numero2 = double.Parse(Console.ReadLine());
            Console.WriteLine(div + "\n");

            // Verificação do sinal e realização da operação
            switch (sinal)
            {
                case "+":
                    result = numero1 + numero2;
                    break;
                case "-":
                    result = numero1 - numero2;
                    break;
                case "*":
                    result = numero1 * numero2;
                    break;
                case "/":
                    result = numero1 / numero2;
                    // Caso o usuário insira o número 0 dará erro
                    if (numero2 == 0 || numero1 == 0)
                    {
                        Console.WriteLine("Divisão impossível!\n");
                        assinatura();
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("ERROR\n");
                    assinatura();
                    return;
            }
            /* Essa foi uma tenativa falha de resumir o código. A calculadora até funcionou,
            mas tive dificuldade de personalizar a útima opção e acabei fazendo da forma mais
            extensa.
             
            dynamic result = sinal switch
            {
                "+" => numero1 + numero2,
                "-" => numero1 - numero2,
                "/" => numero1 / numero2,
                "*" => numero1 * numero2,
                _ => Console.WriteLine("ERROR"),
            };*/

            // Exibição do resultado
            Console.WriteLine("O resultado é {0}!\n", result);
            assinatura();
        }
    }
}