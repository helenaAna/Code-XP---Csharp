using System;

namespace MediaFalta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App Calculo Média e Falta");
            Console.WriteLine("Benvindo a escola SENAI de Informática");
            // entrada de dados
            Console.WriteLine("Digite a primeira nota");
            int nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            int nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de faltas");
            int faltas = int.Parse(Console.ReadLine());

            // processamento

            double media = (nota1 + nota2)/2;

            if(media>=50 && faltas<=30){
                // Resultado verdadeiro
                Console.WriteLine("Parabéns, você foi aprovado!");
            }else{
                // Resultado falso
                Console.WriteLine("Você foi reprovado!");
            }
        
        }
    }
}
