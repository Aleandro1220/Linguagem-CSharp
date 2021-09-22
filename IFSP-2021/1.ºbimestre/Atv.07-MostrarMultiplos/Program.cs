using System;

namespace Mostrar_múltiplos
{
    class Program
    {
        static void assinatura()
        {
            Console.WriteLine("====================================");
            Console.WriteLine("Sistema criado por: Aleandro Matheus");
            Console.WriteLine("====================================");
        }
        static void digite() { Console.Write("\nCaractere inválido!\nDigite um algarismo: "); }
        static void espaco() { Console.WriteLine(); }
        static void Main(string[] args)
        {
            //Seção de variáveis
            var div = "————————————————————————————————————————————————";
            string multi;
            double alg;
            bool trans;
            string quant;
            int alg2;
            bool trans2;
            int vezes = 0;

            //Introdução ao sistema
            Console.Write($"\n          MOSTRADOR DE MÚLTIPLOS\n{div}\n\nInsira o valor a ser multiplicado: ");

            //Verificando se o multiplicado é um algarismo
            while (true)
            {
                multi = Console.ReadLine();
                trans = double.TryParse(multi, out alg);
                if (trans == true)
                    break;
                digite();
            }
            Console.WriteLine(div);

            Console.Write("Insira a quantidade de multiplicações: ");

            //Verificando se a quantidade de multiplicações é um algarismo
            while (true)
            {
                quant = Console.ReadLine();
                trans2 = int.TryParse(quant, out alg2);
                if (trans2 == true)
                    break;
                digite();
            }
            Console.WriteLine($"{div}\nPressione Enter para prosseguir");
            Console.ReadLine();Console.WriteLine(div);
            Console.Clear();

            //Exibição do resultado
            while (vezes++ < alg2)
            {
                Console.WriteLine($"{alg} x {vezes} = {alg * vezes}");
            }
            espaco();
            assinatura();
        }
    }
}
