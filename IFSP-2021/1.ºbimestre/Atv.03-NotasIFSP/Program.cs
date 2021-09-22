using System;

namespace Média_aritmética
{
    class Program
    {
        static void Main(string[] args)
        {
            var divisoria = "-----------------------------------";
            
            // Minha apresentação
            Console.WriteLine("\n");
            Console.WriteLine("Bem vindo ao sistema de notas do IFSP!\n");

            // Nota do 1° bimestre
            Console.WriteLine(divisoria);
            Console.Write("Digite a nota do 1° bimestre: ");
            double bimestre1 = double.Parse(Console.ReadLine());
            Console.WriteLine(divisoria);

            // Nota do 2° bimestre
            Console.Write("Digite a nota do 2° bimestre: ");
            double bimestre2 = double.Parse(Console.ReadLine());
            Console.WriteLine(divisoria);

            // Nota do 3° bimestre
            Console.Write("Digite a nota do 3° bimestre: ");
            double bimestre3 = double.Parse(Console.ReadLine());
            Console.WriteLine(divisoria);

            // Nota do 4° bimestre
            Console.Write("Digite a nota do 4° bimestre: ");
            double bimestre4 = double.Parse(Console.ReadLine());
            Console.WriteLine(divisoria);

            // Equação simples para calcular a média final
            double médiaFinal = (bimestre1 + bimestre2 + bimestre3 + bimestre4) / 4.0;
            Console.WriteLine("Média final: {0:F2}", médiaFinal);
            Console.WriteLine(divisoria);

            //Inserção da frequência anual
            Console.WriteLine("De 0 a 100, digite sua");
            Console.Write("frequência durante o ano: ");
            double frequencia = double.Parse(Console.ReadLine());
            Console.WriteLine(divisoria);

            // Mensagens de acordo com o desempenho
            
            string aprovacao;

            {
                if (frequencia < 75 && médiaFinal < 6)
                    aprovacao = "Péssimo. Reprovado por nota e frequência!";
                else if (frequencia < 75)
                    aprovacao = "Muito mal. Reprovado por frequência!";
                else if (médiaFinal >= 8.0)
                    aprovacao = "Muito bem. Aprovadíssimo!";
                else if (médiaFinal >= 6.0)
                    aprovacao = "Acima da média. Aprovado! ";
                else
                    aprovacao = "Muito mal. Reprovado por nota!";
                Console.WriteLine(aprovacao);
                Console.WriteLine(divisoria,"\n");
                Console.WriteLine("Sistema criado por: Aleandro Matheus\n");
                
            }
        }
    }
}