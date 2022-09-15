using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoCondicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            Console.WriteLine("Seja bem vindo ao programa Locão!\n\n");
            Console.WriteLine("Escolha o programa desejado: ");
            Console.WriteLine("1 - Exemplo 1");
            Console.WriteLine("2 - Exemplo 2");
            Console.WriteLine("3 - Exemplo 3");
            Console.WriteLine("4 - Exemplo 4");
            Console.WriteLine("5 - Exemplo 5");
            Console.WriteLine("6 - Exemplo 6");
            Console.WriteLine("7 - Exemplo 7");
            Console.WriteLine("8 - Exemplo 8");
            Console.WriteLine("--------------");
            Console.WriteLine("0 - Sair");
            string optSrc = Console.ReadLine();
            int.TryParse(optSrc, out opcao);

            if (opcao == 1)
            {
                Exemplo1();
            }
            else if (opcao == 2)
            {
                Exemplo2();
            }
            else if (opcao == 3)
            {
                Exemplo3();
            }
            else if (opcao == 4)
            {
                Exemplo4();
            }
            else if (opcao == 5)
            {
                Exemplo5();
            }
            else if (opcao == 6)
            {
                Exemplo6();
            }
            else if (opcao == 7)
            {
                Exemplo7();
            }
            else if (opcao == 8)
            {
                Exemplo8();
            }
            else if (opcao == 0)
            {
                Console.WriteLine("Muito grato! Volte Sempre! =D");
            }
        }

        static void Exemplo1()
        {
            Console.WriteLine("***** Programa Exemplo 1 *****");
            Console.WriteLine("***** Gerar 2 números aleatórios *****");
            Console.WriteLine("***** Mostrar o maior *****");
        }

        static void Exemplo2()
        {
            Console.WriteLine("***** Programa Exemplo 2 *****");

        }

        // Par e ímpar
        static void Exemplo3()
        {
            //1.	Faça um programa que verifique se um número é impar. (fórmula n – n/2*2 = 0)
            int numeroI = 0;

            Console.WriteLine("Insira um número qualquer: ");
            string numeroS = Console.ReadLine();
            int.TryParse(numeroS, out numeroI);

            if (numeroI - numeroI / 2 * 2 == 0)
            {
                Console.WriteLine("O número é par");
            }
            else
            {
                Console.WriteLine("O número é ímpar");
            }
        }

        // Código Lista
        static void Exemplo4()
        {
            /*4.	fazer um programa que retorne o nome de um produto a partir do código do
			mesmo.Considere os seguintes códigos:
			001 - Arroz;
			002 - Feijão;
			003 - Farinha;
			Para qualquer outro código indicar: Diversos.*/
            Console.WriteLine("**** Bem vindo ao programa de consulta de produto ****\n\n");

            int codigoI = 0;

            Console.WriteLine("Por favor, digite o código do produto: ");
            string codigo = Console.ReadLine();
            int.TryParse(codigo, out codigoI);

            if (codigoI == 1)
            {
                Console.WriteLine("O produto digitado é arroz");
            }
            else if (codigoI == 2)
            {
                Console.WriteLine("O produto digitado é feijão");
            }
            else if (codigoI == 3)
            {
                Console.WriteLine("O produto digitado é farinha");
            }
            else
            {
                Console.WriteLine("Produtos diversos");
            }

        }

        // Idade para votar
        static void Exemplo5()
        {
            int ano = 0;
            Console.WriteLine("Por favor, insira o ano de nascimento: ");
            string anoString = Console.ReadLine();
            int.TryParse(anoString, out ano);

            bool validacao = (2022 - ano >= 16) ? true : false;

            if (validacao)
            {
                Console.WriteLine("Esse ano você poderá votar!");
            }
            else
            {
                Console.WriteLine("Esse ano você ainda não pode votar.");
            }
        }

        // Senha
        static void Exemplo6()
        {
            const string SENHA = "1234";
            Console.WriteLine("Insira a sua senha: ");
            string senhaInputada = Console.ReadLine();
            bool validacao = (senhaInputada.Equals(SENHA)) ? true : false;

            if (validacao)
            {
                Console.WriteLine("Acesso permitido");
            }
            else
            {
                Console.WriteLine("Acesso negado");
            }
        }

        // Maçãs
        static void Exemplo7()
        {
            int quantidade = 0;
            double preco, precoFinal;
            Console.WriteLine("Quantas maçãs você deseja comprar? ");
            string quantidadeS = Console.ReadLine();
            int.TryParse(quantidadeS, out quantidade);

            if (quantidade >= 12)
            {
                preco = 0.25;
                precoFinal = preco * quantidade;
            }
            else
            {
                preco = 0.30;
                precoFinal = preco * quantidade;
            }
            Console.WriteLine($"O valor total da sua compra é de R${precoFinal:F2}");
        }

        // 3 inteiros
        static void Exemplo8()
        {
            int x, y, z;
            Console.WriteLine("Digite 3 valores inteiros");
            string xS = Console.ReadLine();
            string yS = Console.ReadLine();
            string zS = Console.ReadLine();

            int.TryParse(xS, out x);
            int.TryParse(yS, out y);
            int.TryParse(zS, out z);

            if (x < y && x < z)
            {
                if (y < z)
                {
                    Console.WriteLine($"{x}, {y}, {z}");
                }
                else
                {
                    Console.WriteLine($"{x}, {z}, {y}");
                }
            }
            else if (y < x && y < z)
            {
                if (x < z)
                {
                    Console.WriteLine($"{y}, {x}, {z}");
                }
                else
                {
                    Console.WriteLine($"{y}, {z}, {x}");
                }
            }
            else
            {
                if (x < y)
                {
                    Console.WriteLine($"{z}, {x}, {y}");
                }
                else
                {
                    Console.WriteLine($"{z}, {y}, {x}");
                }
            }

        }
    }
}