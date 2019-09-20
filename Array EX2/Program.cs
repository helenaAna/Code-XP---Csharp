using System;

namespace Array_EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício de Arrays 2");

            string[] nome = new string[5];
            string[] telefone = new string[5];
            string[] email = new string[5];

            int contador = 0;

            while(contador<5){
                System.Console.WriteLine("Digite o seu nome");
                nome[contador] = Console.ReadLine();
                
                System.Console.WriteLine("Digite o seu telefone");
                telefone[contador] = Console.ReadLine();

                System.Console.WriteLine("Digite o seu email");
                email[contador] = Console.ReadLine();

                contador++;
            } //fim do while

            int contadorB = 0;
            while(contadorB<=4){

                System.Console.WriteLine($"O cliente número {contadorB+1} - Nome: {nome[contadorB]}, Telefone: {telefone[contadorB]} e E-mail: {email[contadorB]}");
                contadorB++;

            }
        }
    }
}
