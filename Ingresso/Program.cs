using System;

namespace Ingresso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Compre um ingresso");

            Console.WriteLine("Digite a sua Idade:");
            int idade = int.Parse(Console.ReadLine());

            if(idade<18 || idade>=60){
                Console.WriteLine("Você pagará meia!");
            }else{
                Console.WriteLine("Você pagará inteira!");
            }
        }
    }
}
