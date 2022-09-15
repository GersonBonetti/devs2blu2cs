using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dvs2Blu.ProjetosAula.Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            int exercicio;
            Console.WriteLine("Escolha o exercício desejado: ");
            Console.WriteLine("Exercicio 1");
            Console.WriteLine("Exercicio 2");
            Console.WriteLine("Exercicio 3");
            string exercicioS = Console.ReadLine();
            int.TryParse(exercicioS, out exercicio);

            switch (exercicio)
            {
                case 1:
                    Exercicio1();
                    break;
                case 2:
                    Exercicio2();
                    break;
                case 3:
                    Exercicio3();
                    break;
                case 4:
                    Exercicio4();
                    break;
                default:
                    break;
            }
        }

        static void Exercicio1()
        {
            Console.WriteLine("**** Digite o nome da fruta desejada para verificar sua disponibilidade: ****");
            Console.WriteLine("|   Maçã   |");
            Console.WriteLine("|   Kiwi   |");
            Console.WriteLine("| Melancia |\n\n");
            string fruta = Console.ReadLine(); ;

            switch (fruta.ToLower())
            {
                case "maçã":
                    Console.WriteLine("\nNão vendemos esta fruta aqui");
                    break;
                case "kiwi":
                    Console.WriteLine("\nEstamos com escassez de kiwis");
                    break;
                case "melancia":
                    Console.WriteLine("\nAqui está, são 3 reais o quilo");
                    break;
                default:
                    Console.WriteLine("Vai comer pastel!");
                    break;
            }
            Console.ReadKey();
        }

        static void Exercicio2()
        {
            Console.WriteLine("Escolha um dos meios de transporte disponíveis: ");
            Console.WriteLine("|                Carro hatch                  |");
            Console.WriteLine("|                Carro sedan                  |");
            Console.WriteLine("|                Motocicletas                 |");
            Console.WriteLine("|                Caminhonetes                 |");

            string modelo = Console.ReadLine();

            switch (modelo.ToUpper())
            {
                case "HATCH":
                    Console.WriteLine("Compra efetuada com sucesso!");
                    break ;
                case "SEDAN":
                case "MOTOCICLETAS":
                case "CAMINHONETES":
                    Console.WriteLine("Tem certeza que não prefere um hatch?");
                    break;
                default: 
                    Console.WriteLine("Não trabalhamos com este tipo de automóvel aqui");
                    break;
            }
            Console.ReadKey();
        }

        static void Exercicio3()
        {
            int usuario;
            int pontosUser = 0;
            int pontosComputador = 0;
            Console.WriteLine("Bem vindo ao 21.");
            Console.WriteLine("Digite um número para começar a jogar");
            string usuarioS = Console.ReadLine();
            int.TryParse(usuarioS, out usuario);

            Random rand = new Random();
            int computador = rand.Next(1, 20);
            int casa = rand.Next(1, 20);

            usuario += casa;
            computador += casa;

            switch (usuario)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    pontosUser += 1;
                    break;
                case 7:
                    pontosUser += 10;
                    break;
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                    pontosUser += 5;
                    break;
                case 14:
                    pontosUser += 10;
                    break;
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    pontosUser += 6;
                    break;
                case 21:
                    pontosUser += 10;
                    break;
                default:
                    pontosUser += 0;
                    break;
            } //os switches incansáveis

            switch (computador)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    pontosComputador += 1;
                    break;
                case 7:
                    pontosComputador += 10;
                    break;
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                    pontosComputador += 5;
                    break;
                case 14:
                    pontosComputador += 10;
                    break;
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    pontosComputador += 6;
                    break;
                case 21:
                    pontosComputador += 10;
                    break;
                default:
                    pontosComputador += 0;
                    break;
            } //os switches incansáveis

            Console.WriteLine($"O número aleatório gerado para a casa: {casa}");
            Console.WriteLine($"\nA soma do computador: {computador}");
            Console.WriteLine($"A pontuação do computador: {pontosComputador}");
            Console.WriteLine($"\nA sua soma: {usuario}");
            Console.WriteLine($"Sua pontuação: {pontosUser}");

            if (pontosUser > pontosComputador)
            {
                Console.WriteLine("\nVocê ganhou!");
            }
            else if (pontosUser < pontosComputador)
            {
                Console.WriteLine("\nVocê perdeu =(");
            }
            else
            {
                Console.WriteLine("\nEmpatou.");
            }
        }
    
        static void Exercicio4()
        {
            //1.	Faça um programa que simule uma calculadora, onde informa as opções pro usuário escolher qual
            //operação deseja realizar, e em seguida informe dois números para realizar a operação.
            //Use o case para programar as operações específicas. (soma, subtração, multiplicação e divisão)
            int x, y;

            Console.WriteLine("Seja bem vindo à calculadora");
            Console.WriteLine("Escolha o tipo de operação que você deseja fazer:");
            Console.WriteLine("|      001 - Adição     |");
            Console.WriteLine("|    002 - Subtração    |");
            Console.WriteLine("|  003 - Multiplicação  |");
            Console.WriteLine("|     004 - Divisão     |");
            string escolha = Console.ReadLine();

            Console.WriteLine("Digite o primeiro e o segundo valor da operação, respectivamente: ");
            string xS = Console.ReadLine();
            string yS = Console.ReadLine();
            int.TryParse(xS, out x);
            int.TryParse(yS, out y);
;
            switch (escolha)
            {
                case "001":
                    Console.WriteLine($"A soma dos números {x} e {y} é de = {x + y}");
                    break;
                case "002":
                    Console.WriteLine($"A subtração dos números {x} e {y} é de = {x + y}");
                    break;
                case "003":
                    Console.WriteLine($"A multiplicação dos números {x} e {y} é de = {x + y}");
                    break;
                case "004":
                    Console.WriteLine($"A divisão dos números {x} e {y} é de = {x + y}");
                    break;
                default:
                    break;
            }
        }
    }
}
