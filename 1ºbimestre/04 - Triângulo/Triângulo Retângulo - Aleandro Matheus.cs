using System;

namespace _04___Triângulo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introdução ao programa
            var divisoria = "-----------------------------";
            var anderlaine = "====================================";
            Console.WriteLine("\n");
            Console.WriteLine("Bem vindo ao sistema de verificação de triângulos!\n");

            // Inserção dos valores do triângulo
            Console.WriteLine(divisoria);
            Console.Write("Digite o valor do 1º lado: ");
            double lado1 = double.Parse(Console.ReadLine());
            Console.WriteLine(divisoria);

            Console.Write("Digite o valor do 2º lado: ");
            double lado2 = double.Parse(Console.ReadLine());
            Console.WriteLine(divisoria);

            Console.Write("Digite o valor do 3º lado: ");
            double lado3 = double.Parse(Console.ReadLine());
            Console.WriteLine(divisoria);

            // Verificação do triângulo
            {
                if (lado1 + lado2 > lado3 &&
                lado1 + lado3 > lado2 &&
                lado2 + lado3 > lado1)
                    Console.WriteLine("Temos um triângulo!\n");
                else {
                    Console.WriteLine("Valores inválidos!\n");
                    Console.WriteLine(anderlaine);
            Console.WriteLine("Sistema criado por: Aleandro Matheus");
            Console.WriteLine(anderlaine);
                    return;
                    }
            }

            // Verificação dos valores
            double hip, cat1, cat2;
            if (lado1 > lado2 && lado1 > lado3)
            {
                hip = lado1;
                cat1 = lado2;
                cat2 = lado3;
            }
            else if (lado2 > lado1 && lado2 > lado3)
            {
                hip = lado2;
                cat1 = lado1;
                cat2 = lado3;
            }
            else
            {
                hip = lado3;
                cat1 = lado2;
                cat2 = lado1;
            }

            // Classificação do triângulo
            {
                if (Math.Pow(hip, 2) == Math.Pow(cat1, 2) + Math.Pow(cat2, 2))
                    Console.WriteLine("Esse é um triângulo retângulo!");
                else if (lado1 == lado2 && lado2 == lado3)
                    Console.WriteLine("Esse triângulo não é retângulo, pois é equilátero.");
                else if (lado1 == lado2 || lado2 == lado3 || lado3 == lado1)
                    Console.WriteLine("Esse triângulo não é retângulo, pois é isóceles.");
                else
                    Console.WriteLine("Esse triângulo não é retângulo, pois é escaleno.");
            } 

            // Fim do programa
            Console.WriteLine(anderlaine);
            Console.WriteLine("Sistema criado por: Aleandro Matheus");
            Console.WriteLine(anderlaine);
        }
    }
}

