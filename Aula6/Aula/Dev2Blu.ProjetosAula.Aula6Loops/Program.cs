using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dev2Blu.ProjetosAula.Aula6Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int controle = 0;
            do
            {
                Console.WriteLine("Informe um dos códigos Abaixo");
                Console.WriteLine("1 - Exemplo1");
                Console.WriteLine("2 - Exemplo2");
                Console.WriteLine("3 - Exemplo3");
                Console.WriteLine("4 - Exemplo4");
                Console.WriteLine("5 - Exemplo5");
                Console.WriteLine("6 - Exemplo6");
                Console.WriteLine("7 - Exemplo7");
                Console.WriteLine("8 - Exemplo8");
                Int32.TryParse(Console.ReadLine(), out controle);

                switch (controle)
                {
                    case 1:
                        Exemplo1();
                        break;
                    case 2:
                        Exemplo2();
                        break;
                    case 3:
                        Exemplo3();
                        break;
                    case 4:
                        Exemplo4();
                        break;
                    case 5:
                        Exemplo5();
                        break;
                    case 6:
                        Exemplo6();
                        break;
                    case 7:
                        Exemplo7();
                        break;
                    case 8:
                        Exemplo8();
                        break;
                    default:
                        break;
                }
            } while (controle > 0);
        }

        static void Exemplo1()
        {
            int controle = 1;

            while (controle > 0)
            {
                Console.WriteLine("Informe o código 0 para sair");
                Int32.TryParse(Console.ReadLine(), out controle);
            }
            Console.ReadKey();
        }

        static void Exemplo2()
        {
            //Escreva um aplicativo em Java mostra todos os números ímpares de 1 até 100.
            int numero = 1;
            Console.WriteLine("Exemplo 2");
            while (numero <= 100)
            {
                if (numero % 2 != 0) {
                    Console.WriteLine(numero);
                }
                numero++;
            }
            Console.ReadKey();
        }

        static void Exemplo3()
        {
            int numero = 0;
            Console.WriteLine("Exemplo 3");
            while (numero <= 100)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine(numero);
                }
                numero++;
            }
            Console.ReadKey();
        }

        static void Exemplo4()
        {
            int numero = 1;
            int inputado = 0;
            Console.WriteLine("Exemplo 4");
            Console.WriteLine("Digite um número inteiro qualquer: ");
            int.TryParse((Console.ReadLine()), out inputado);
            while (numero <= inputado)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine($"{numero} é par");
                } else
                {
                    Console.WriteLine($"{numero} é ímpar");
                }
                numero++;
            }
            Console.ReadKey();
        }
    
        static void Exemplo5()
        {
            int alunos = 0;
            int contador = 0;
            double soma = 0;
            double nota = 0;

            Console.WriteLine("Quantos alunos tem na sua sala?");
            int.TryParse(Console.ReadLine(), out alunos);
            Console.WriteLine("\n");

            while (contador < alunos)
            {
                Console.WriteLine($"Digite a nota do {contador + 1}º aluno");
                double.TryParse(Console.ReadLine(), out nota);
                soma += nota;
                contador++;
            }
            double media = soma / alunos;
            Console.WriteLine($"A média de nota dos seus alunos é {media:F1}\n\n");
        }

        static void Exemplo6()
        {
            /*5.	Faça um programa que imprima na tela os números de 1 a 20, um abaixo do outro. 
             * Depois modifique o programa para que ele mostre os números um ao lado do outro.*/
            int numeroAtual = 1;

            while (numeroAtual <= 20)
            {
                Console.WriteLine(numeroAtual);
                numeroAtual++;
            }

            numeroAtual = 1;
            while (numeroAtual <= 20)
            {
                Console.Write($"{numeroAtual} ");
                numeroAtual++;
            }
            Console.WriteLine("\n");
        }

        static void Exemplo7()
        {
            /*6.	Informar todos os números de 1000 a 1999 que quando divididos por 11 obtemos resto = 5.*/
            int x = 1000;

            while (x <= 1999)
            {
                if (x % 11 == 5)
                {
                    Console.Write($"{x}, ");
                }
                x++;
            }
            Console.WriteLine("\n");
        }

        static void Exemplo8()
        {
            /*7.	Jogo Acertar o Número. O jogo consiste em:
                    a.	Gere um número aleatório entre 1 e 20;
                    b.	O usuário terá 3 chances para acertar o número;
                    c.	Caso não consiga acertar, encerra o jogo.*/
            
        
        
        }
    }
}

