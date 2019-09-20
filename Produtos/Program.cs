using System;

namespace Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cadastro de produtos");

            string[] produto = new string[6];
            int contador = 0;

            while(contador<=5){
                Console.WriteLine("Digite o Produto");
                produto[contador] = Console.ReadLine();

                contador++;
            }

            contador = 0;
            System.Console.WriteLine("-----------------------------");
            Console.WriteLine("LISTA DE PRODUTOS");
            
            while(contador<=5){
              Console.WriteLine($"{produto[contador]}"); 
              contador++; 
            }
        }
    }
}
