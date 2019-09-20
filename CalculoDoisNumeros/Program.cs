using System;

namespace CalculoDoisNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora com Menu");

            Console.WriteLine("Digite o primeiro número");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            float n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a operação a ser executada:");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("( 1 ) - Soma");
            Console.WriteLine("( 2 ) - Subtração do primeiro pelo segundo");
            Console.WriteLine("( 3 ) - Subtração do segundo pelo primeiro");
            Console.WriteLine("( 4 ) - Multiplicação");
            Console.WriteLine("( 5 ) - Divisão do primeiro pelo segundo");
            Console.WriteLine("( 6 ) - Divisão do segundo pelo primeiro");
            Console.WriteLine("-----------------------------------------------");

            string resposta = Console.ReadLine();
             
             switch(resposta){
                case "1":
                Console.WriteLine($"A soma dos números é {n1+n2}");
                break;
                case "2":
                Console.WriteLine($"A subtração do primeiro pelo segundo é {n1-n2}");
                break;
                case "3":
                Console.WriteLine($"A subtração do segundo pelo primeiro é {n2-n1}");
                break;
                case "4":
                Console.WriteLine($"A multiplicação dos números é {n1*n2}");
                break;
                case "5":
                Console.WriteLine($"A divisão do primeiro pelo segundo é {n1/n2}");
                break;
                case "6":
                Console.WriteLine($"A divisão do segundo pelo primeiro é {n2/n1}");
                break;
                default:
                Console.WriteLine("Digite uma opção válida.");
                break;
             }
        }
    }
}
