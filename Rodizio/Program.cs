using System;

namespace Rodizio
{
    class Program
    {
        static void oMain(string[] args)
        {
            Console.WriteLine("Rodizio conforme a placa");

            Console.WriteLine("Insira sua placa:");
            // int placa = int.Parse(Console.ReadLine());
            string placa = Console.ReadLine();

            int caracteres = placa.Length;
            Console.WriteLine($"Quantidade de caracteres {caracteres}");
            int final = int.Parse(placa.Substring(caracteres - 1));
            Console.WriteLine($"A posição 0 é {final}");

            if(final == 0 || final == 1){
               Console.WriteLine("Seu rodizio é na segunda-feira"); 
            }else if(final == 2 || final == 3){
                Console.WriteLine("Seu rodizio é na terça-feira");
            }else if(final == 4 || final == 5){
                Console.WriteLine("Seu rodizio é na quarta-feira");
            }else if(final == 6 || final == 7){
                Console.WriteLine("Seu rodizio é na quinta-feira");
            }else if(final == 8 || final == 9){
                Console.WriteLine("Seu rodizio é na sexta-feira");
            }
        }
    }
}
