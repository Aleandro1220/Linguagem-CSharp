using System;

namespace Atividade_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int quant, numsP = 0, numsN = 0;
            double soma = 0, valor = 0, maiorNum = -0.5, menorNum = 0.5;
            const int LIMITE = 20;
            Console.WriteLine("Digite a quantidade de números escolhidos:");
            
            // Validando a entrada do usuário
            while (true)
            {
                bool trans = int.TryParse(Console.ReadLine(), out quant);
                if(!trans)
                    Console.Write("Valor inválido\nTente novamente: ");
                else if(quant > LIMITE)
                    Console.Write("O programa só aguenta no máximo 20 números\nTente novamante: ");
                else if(quant < 0)
                    Console.Write("Não é válido números negativos\nTente novamente: ");    
                else
                    break;
            }
            // Execução da repetição, soma e porcentagens
            for (int ii = 0; ii < quant; ii++)
            {
                
                while(true)
                {
                    Console.Write("\nDigite o {0}° valor: ", ii + 1);
                    bool transformar1 = double.TryParse(Console.ReadLine(), out valor);
                    if(!transformar1)
                        Console.WriteLine("Valor inválido, tente novamente.");
                    else
                        break;    
                }

                if(ii == 0)
                {
                    maiorNum = valor;
                    menorNum = valor;
                }        
                else if(valor > maiorNum)
                    maiorNum = valor;
                else if(valor < menorNum)
                    menorNum = valor;    
             
                soma += valor;

                if(valor > 0)
                    numsP++;          
                else
                    numsN++; 
            }
            
            Console.WriteLine("————————————————————————————————————————\nA quantidade de números positivos é: {0}", numsP);
            Console.WriteLine("A quantidade de números negativos é: {0}\n————————————————————————————————————————", numsN);
            // Calculando as porcentagens
            
            double PorcentagemPositivaFinal = ((numsP+0.0)/quant)*100, PorcentagemNegativaFinal = 100 - PorcentagemPositivaFinal;
            
            // Exibição da porcentagem dos números positivos e a dos negativos.
            Console.WriteLine("A porcentagem de números positivos é: {0:F2}%", PorcentagemPositivaFinal);
            Console.WriteLine("A porcentagem de números negativos é: {0:F2}%\n——————————————————————————————————————————————", PorcentagemNegativaFinal);
            
            // Exibição da soma
            Console.WriteLine($"A soma de todos esses valores é: {soma}\n—————————————————————————————————————");

            // Média dos valores
            Console.WriteLine("A média aritmética da soma desses números é: {0:F2}\n———————————————————————————————————————————————————",soma/quant);

            //Maior e menor número
            Console.WriteLine("O maior número é: {0}", maiorNum);
            Console.WriteLine("O menor número é: {0}\n———————————————————————————", menorNum);
        }
    }
}
