using System;

namespace Salario2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salário");

            Console.WriteLine("Digite o valor do salário mínimo:");
            float salarioMinimo = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de horas trabalhadas:");
            float horasTrabalhadas = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de dependentes:");
            float dependentes = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de horas extras trabalhadas:");
            int horasExtra = int.Parse(Console.ReadLine());

            float valorHora = salarioMinimo/5;
            float valordependente = dependentes*64;
            float salario = horasTrabalhadas*valorHora;
            double valorHoraEx = valorHora + (valorHora*0.5);
            double totalHe = horasExtra*valorHoraEx;
            double salarioBruto = valorHora+salario+valordependente+totalHe;
            double ir1 = salarioBruto*0.1;
            double ir2 = salarioBruto*0.2;

                      
            Console.WriteLine($"O valor da hora trabalhada é R${valorHora}.");
            Console.WriteLine($"Seu salário é {salario}.");
            Console.WriteLine($"Você receberá R${valordependente} referente aos seus depententes.");
            Console.WriteLine($"Você receberá R${totalHe} referente as horas extras trabalhadas.");
            Console.WriteLine($"O salário  bruto é de R${salarioBruto}.");

            if(salarioBruto<1750){
                Console.WriteLine("Você é isento de IRRF.");
            }else if(salarioBruto<1750 && salarioBruto>2500){
                Console.WriteLine($"Você terá desconto de {ir1} referente ao IRRF e seu salário líquido é {salarioBruto-ir1}.");
            }else if(salarioBruto>2500){
                Console.WriteLine($"Você terá desconto de {ir2} referente ao IRRF e seu salário líquido é {salarioBruto-ir2}.");
            }
           









        }
    }
}
