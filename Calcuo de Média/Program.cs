using System;

namespace Calcuo_de_Média
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Calcula Média");

        int n1;
        int n2;
        int n3;
        
        Console.WriteLine("Digite a N1:");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a N2:");
        n2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite a N3:");
        n3 = int.Parse(Console.ReadLine());

        float nota = (n1+n1+n3);
        float media= (nota/3);
        Console.WriteLine($"A sua nota é: {media}.");
    
}
    }
}
