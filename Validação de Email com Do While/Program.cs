using System;

namespace Validação_de_Email_com_Do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validação de e-mail com Do While");

            string email;

            do{
                System.Console.WriteLine("Digite seu e-mail:");
                email = Console.ReadLine(); 

            }while(!email.Contains("@") || !email.Contains("."));

            string senha;
            do{
                System.Console.WriteLine("Digite a senha");
                senha =Console.ReadLine();
            }while(senha.Length <= 5);
        }
    }
}
