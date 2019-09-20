using System;

namespace CalculaIdadeData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Converte data em idade");

            int anoNascimento;
            int anoAtual = DateTime.Now.Year;

            Console.WriteLine("Digite seu ano de nascimento");
            anoNascimento = int.Parse(Console.ReadLine());

            int idade = anoAtual-anoNascimento;
        
            Console.WriteLine($"Sua idade é {idade} anos ou {idadeMeses} meses."); 

        }
    }
}
