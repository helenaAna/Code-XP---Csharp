using System;

namespace CalculaIdade
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Calculadora de Idade");

        int idade;

        Console.WriteLine ("Digite sua idade:");
        idade = int.Parse(Console.ReadLine());

        int meses = idade*12;
        int dias = idade*365;
        int horas = dias*24;
        int mins = horas*60;
        int seg= mins*60;

        Console.WriteLine($"Sua idade em meses é: {meses}; em dias: {dias}; em horas:{horas}; em minutos:{mins} e em segundos: {seg}.");     
        }
    }
}