using System;

namespace AumentoSalário
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aumento de Salário");

            Console.WriteLine("Digite o seu cargo:");
            string cargo = Console.ReadLine();
            Console.WriteLine("Digite o seu salário atual:");
            float salario = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o código do seu cargo:");
            string codigo = Console.ReadLine();
             
             switch(codigo){
                case "1":
                Console.WriteLine($"01 - Escriturários receberam o aumento de 50%. Você receberá {salario*0.5} a mais em seu salário.");
                break;
                case "2":
                Console.WriteLine($"02 - Secretários receberam o aumento de 35%. Você receberá {salario*0.35} a mais em seu salário.");
                break;
                case "3":
                Console.WriteLine($"03 - Caixas receberam o aumento de 20%. Você receberá {salario*0.25}a mais em seu salário.");
                break;
                case "4":
                Console.WriteLine($"04 - Gerentes receberam o aumento de 10%. Você receberá {salario*0.1} a mais em seu salário.");
                break;
                case "5":
                Console.WriteLine($"05 - Diretores na receberam aumento. Você não terá reajustes no seu salário");
                break;
                default:
                Console.WriteLine("Você digitou um código inválido.");
                break;
        }
    }
}
}
