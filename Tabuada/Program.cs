using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada");

            Console.WriteLine("Digite um número de 1 até 10:");
            int mult = int.Parse(Console.ReadLine());
            int nun = 1;

            Console.WriteLine("---------------------------");
            while(nun <= 10){
            
            int multiplicacao = mult*nun;
            
            Console.WriteLine($"{mult} X {nun} = {multiplicacao}");
            nun = nun+1;
            }
        }
    }
}
