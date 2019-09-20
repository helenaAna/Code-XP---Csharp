using System;

namespace LaçoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laço de repetição While");

            Console.WriteLine("Digite o número inicial");
            int contador = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número limite");
            int limite = int.Parse(Console.ReadLine());

            Console.WriteLine("---------------------------");
            while(contador <= limite)
            {
                Console.WriteLine(contador); 
                contador = contador + 1;
            }//Fim do While
        }
    }
}
