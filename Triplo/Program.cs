using System;

namespace Triplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Triplo");

            float numero;

            Console.WriteLine("Digite um número");
            numero = float.Parse(Console.ReadLine());

            float triplo = numero*3;

            Console.WriteLine($"o triplo de {numero} é {triplo}."); 
            
        }
    }
}
