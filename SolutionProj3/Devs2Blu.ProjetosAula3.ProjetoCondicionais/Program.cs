using System;

namespace Devs2Blu.ProjetosAula3.ProjetoCondicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        static void SegundoExercicio()
        {
            Console.WriteLine("Entre com o primeiro valor: ");
            int um = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o segundo valor: ");
            int dois = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (um > dois)
            {
                Console.WriteLine(um);
            }
            else if (um == dois)
            {
                Console.WriteLine("Os números são iguais");
            }
            else
            {
                Console.WriteLine($"{dois}");
            }
        }

        static void TerceiroExercicio()
        {
            Console.WriteLine("Entre com o primeiro valor: ");
            int um = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo valor: ");
            int dois = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o terceiro valor: ");
            int tres = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o quarto valor: ");
            int quatro = int.Parse(Console.ReadLine());

            if (um < dois && um < tres && um < 4)
            {
                Console.WriteLine($"O menor é {um}");
            } else if (dois < tres && dois < quatro)
            {
                Console.WriteLine($"O menor é {dois}");
            }
            else if (tres < quatro)
            {
                Console.WriteLine($"O menor é {tres}");
            } else
            {
                Console.WriteLine($"O menor é {quatro}");
            }
        }

        static void TerceiroExercicio2()
        {
            Console.WriteLine("Entre com o primeiro valor: ");
            int um = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo valor: ");
            int dois = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o terceiro valor: ");
            int tres = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o quarto valor: ");
            int quatro = int.Parse(Console.ReadLine());


        }

        static void QuartoExercicio()
        {
            Console.WriteLine("Digite o número desejado: ");
            int numero = int.Parse(Console.ReadLine());

            /*if (numero)
            {

            }*/

        }

        static void Exemplo1()
        {
            string textoSaida;
            int idadeCandidato, notaCandidato;

            Console.WriteLine("|**** Bem vindo ao Programa SysSchool ****|\n\n");

            Console.Write("Informe o nome do candidato: ");
            string nomeCandidato = Console.ReadLine();
            Console.Write("Informe a idade do candidato: ");
            string idadeString = Console.ReadLine();

            if (idadeString.Equals(""))
            {
                Console.WriteLine("Valor inválido para Idade!");
                return;
            }
            else
            {
                idadeCandidato = int.Parse(idadeString);
            }

            Console.Write("Informe a nota do candidato: ");
            string notaStr = Console.ReadLine();
            if (notaStr.Equals(""))
            {
                Console.WriteLine("Valor inválido para Nota!");
                return;
            }
            else
            {
                notaCandidato = int.Parse(notaStr);
            }

            textoSaida = $"Candidato: {nomeCandidato}\n";
            textoSaida += $"Idade: {idadeCandidato}";

            if (idadeCandidato < 18)
            {
                textoSaida += "(Menor de idade)\n";
            }
            else
            {
                textoSaida += "(Maior de idade)\n";
            }

            textoSaida += $"Nota final: {notaCandidato}\n\n";

            if (notaCandidato > 5)
            {
                textoSaida += "*** APROVADO ***";
            }
            else
            {
                textoSaida += "|REPROVADO| =(";
            }

            Console.WriteLine(textoSaida);

        }
    }
}
