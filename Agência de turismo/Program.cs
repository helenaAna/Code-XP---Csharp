using System;

namespace Agência_de_turismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Agência de Turismo");

            string [] nome = new string [5];
            string [] origem = new string [5];
            string [] destino = new string [5];
            DateTime[] data = new DateTime [5];

            int opcao =0, contador = 0;

            do{
                Console.WriteLine("Selecione uma opção");
                Console.WriteLine("1 - Cadastrar passagem ");
                Console.WriteLine("2 - Listar passagem");
                Console.WriteLine("0 - Sair");  
                opcao = int.Parse(Console.ReadLine());
            
                switch (opcao){   
                    case 1:
                    System.Console.WriteLine("Vamos cadastrar agora");
                    string resposta;
                    do
                    {
                        if(contador<=5){
                        System.Console.WriteLine("Digite o nome do passageiro");
                        nome [contador] = Console.ReadLine();

                        System.Console.WriteLine("Digite a origem");
                        origem[contador] = Console.ReadLine();

                        System.Console.WriteLine("Digite o destino");
                        destino[contador] = Console.ReadLine();
                        
                        System.Console.WriteLine("Digite a data da viagem");
                        data[contador] = DateTime.Parse(Console.ReadLine());

                        System.Console.WriteLine("Deseja cadastar mais alguma viagem? S/N");
                        resposta =Console.ReadLine();
                        contador ++;
                        }else{
                            System.Console.WriteLine("Número de passagens excedidas");
                            break;
                        }
                    } while (resposta == "S");
                    break;
                    case 2:
                    System.Console.WriteLine("Listando as passagens");
                    int contadorB = 0;
                    while (contadorB < 5)
                    {
                        Console.WriteLine($"Passageiro nome: {nome[contadorB]} origem: {origem[contadorB]} destino: {destino[contadorB]} data: {data[contadorB]}");
                        contadorB ++;
                    }
                    break;
                    case 0:
                   // System.Console.WriteLine("Obrigado por usar nosso sistema");
                    break;
                    default:
                    System.Console.WriteLine("Opção inválida");
                    break;
                }
            
            }while (opcao != 0);

            System.Console.WriteLine("Obrigado por usar nosso sistema");
            
        }
    }
}
