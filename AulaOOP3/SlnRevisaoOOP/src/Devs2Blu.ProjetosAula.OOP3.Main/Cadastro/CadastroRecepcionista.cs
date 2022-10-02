using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastro
{
    public class CadastroRecepcionista : IMenuCadastro
    {
        public CadastroRecepcionista() { }

        public Int32 MenuCadastro()
        {
            Int32 opcao;
            Console.Clear();
            Console.WriteLine("╔════ Cadastro de Recepcionista ══════╗");
            Console.WriteLine("║    1 - Lista de Recepcionista       ║");
            Console.WriteLine("║    2 - Cadastro de Recepcionista    ║");
            Console.WriteLine("║    3 - Alterar Recepcionista        ║");
            Console.WriteLine("║    4 - Excluir Recepcionista        ║");
            Console.WriteLine("║-------------------------------------║");
            Console.WriteLine("║            0 - Sair                 ║");
            Console.WriteLine("╚═════════════════════════════════════╝");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;
        }

        private void ListarRecepcionistasByCodeAndName()
        {
            Console.Clear();

            foreach (Recepcionista recepcionista in Program.Mock.ListaRecepcionistas)
            {
                Console.Write($"{recepcionista.CodigoRecepcionista} - Nome: {recepcionista.Nome}\n");
            }
            Console.WriteLine("\n");
        }

        private void AlterarRecepcionista(Recepcionista recepcionista)
        {
            var pact = Program.Mock.ListaRecepcionistas.Find(p => p.CodigoRecepcionista == recepcionista.CodigoRecepcionista);
            int index = Program.Mock.ListaRecepcionistas.IndexOf(pact);
            Program.Mock.ListaRecepcionistas[index] = recepcionista;
        }

        private void ExcluirRecepcionista(Recepcionista recepcionista)
        {
            Int32 codigo;

            Console.Clear();
            Console.WriteLine("Qual o código da recepcionista que você desejar excluir?");
            Int32.TryParse(Console.ReadLine(), out codigo);
            ListarRecepcionistasByCodeAndName();
        }

        public void Listar()
        {
            Console.Clear();

            foreach (Recepcionista recepcionista in Program.Mock.ListaRecepcionistas)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine($"Recepcionista: {recepcionista.Codigo}");
                Console.WriteLine($"Nome: {recepcionista.Nome}");
                Console.WriteLine($"Setor: {recepcionista.Setor}");
                Console.WriteLine("------------------------------");

            }
            Console.ReadLine();
        }

        public void Cadastrar()
        {
            Console.Clear();

            int codigo = 0;
            string nome = "";
            string cpf = "";
            string setor = "";

            Console.WriteLine("Janela para cadastro de nova recepcionista");
            Console.Write("Código: ");
            int.TryParse(Console.ReadLine(), out codigo);
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("CPF: ");
            cpf = Console.ReadLine();
            Console.Write("Setor: ");
            setor = Console.ReadLine();

            Recepcionista recepcionista = new Recepcionista(codigo, nome, cpf, setor);
            Program.Mock.ListaRecepcionistas.Add(recepcionista);

            Console.WriteLine("\nCadastro efetuado com sucesso!");
        }

        public void Alterar()
        {
            Console.Clear();
            Recepcionista recepcionista;
            int codigoRecepcionista;

            Console.WriteLine("Informe a recepcionista que você deseja alterar");
            ListarRecepcionistasByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoRecepcionista);

            recepcionista = Program.Mock.ListaRecepcionistas.Find(p => p.CodigoRecepcionista == codigoRecepcionista);

            string opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.WriteLine($"Código {recepcionista.Codigo}:{recepcionista.CodigoRecepcionista} | Nome: {recepcionista.Nome} | CPF: {recepcionista.CGCCPF} | Setor: {recepcionista.Setor}\n");
                Console.WriteLine("Qual campo você deseja alterar?");
                Console.WriteLine("01 - Nome | 02 - CPF | 03 - Setor | 00 - Sair\n");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.WriteLine("Informe um novo nome:");
                        recepcionista.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo CPF:");
                        recepcionista.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Informe um novo setor:");
                        recepcionista.Setor = Console.ReadLine();
                        break;
                    default:
                        alterar = false;
                        break;
                }

                if (alterar)
                {
                    Console.Clear();
                    Console.WriteLine("Dado alterado com sucesso!");
                }

            } while (alterar);

            AlterarRecepcionista(recepcionista);
        }

        public void Excluir()
        {
            Recepcionista recepcionista = new Recepcionista();
            ExcluirRecepcionista(recepcionista);
        }
    }
}
