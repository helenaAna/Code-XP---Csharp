using System;

namespace ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora nova");

            Console.WriteLine("Digite um número:");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número");
            float n2 = float.Parse(Console.ReadLine());

            float restoN1 = n1%2;
            float restoN2 = n2%2;

            if(restoN1==0 && restoN2==0){
                Console.WriteLine($"{n1} e {n2} são pares");
            }else if(restoN1==0 && restoN2==1){
                Console.WriteLine($"{n1} é par e {n2} é impar");
            }else if(restoN1==1 && restoN2==1){
                Console.WriteLine($"{n1} e {n2} são impar");
            }else if(restoN1==1 && restoN2==0){
                Console.WriteLine($"{n1} é impar e {n2} é par");
            }

            if(n1>n2){
               Console.WriteLine($"{n1} é maior que {n2}."); 
            }else if(n1<n2){
                Console.WriteLine($"{n1} é menos que {n2}."); 
            }else if(n1==n2){
                Console.WriteLine($"{n1} {n2} são iguais."); 
            }
                
          

            


        }
    }
}

