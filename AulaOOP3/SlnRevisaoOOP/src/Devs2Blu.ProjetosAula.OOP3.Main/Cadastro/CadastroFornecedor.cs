using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastro
{
    public class CadastroFornecedor : IMenuCadastro
    {
        public CadastroFornecedor() { }

        public Int32 MenuCadastro()
        {
            Int32 opcao;
            Console.Clear();
            Console.WriteLine("╔════ Cadastro de Fornecedor ══════╗");
            Console.WriteLine("║    1 - Lista de Fornecedor       ║");
            Console.WriteLine("║    2 - Cadastro de Fornecedor    ║");
            Console.WriteLine("║    3 - Alterar Fornecedor        ║");
            Console.WriteLine("║    4 - Excluir Fornecedor        ║");
            Console.WriteLine("║----------------------------------║");
            Console.WriteLine("║            0 - Sair              ║");
            Console.WriteLine("╚══════════════════════════════════╝");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;
        }

        private void ListarFornecedoresByCodeAndName()
        {
            Console.Clear();

            foreach (Fornecedor fornecedor in Program.Mock.ListaFornecedores)
            {
                Console.Write($"{fornecedor.CodigoFornecedor} - Nome: {fornecedor.Nome}\n");
            }
            Console.WriteLine("\n");
        }

        private void AlterarFornecedor(Fornecedor fornecedor)
        {
            var pact = Program.Mock.ListaFornecedores.Find(p => p.CodigoFornecedor == fornecedor.CodigoFornecedor);
            int index = Program.Mock.ListaFornecedores.IndexOf(pact);
            Program.Mock.ListaFornecedores[index] = fornecedor;
        }

        private void ExcluirFornecedor(Fornecedor fornecedor)
        {
            Int32 codigo;

            Console.Clear();
            Console.WriteLine("Qual o código do fornecedor que você desejar excluir?");
            Int32.TryParse(Console.ReadLine(), out codigo);
            ListarFornecedoresByCodeAndName();
        }

        public void Listar()
        {
            Console.Clear();

            foreach (Fornecedor fornecedor in Program.Mock.ListaFornecedores)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine($"Fornecedor: {fornecedor.Codigo}");
                Console.WriteLine($"Nome: {fornecedor.Nome}");
                Console.WriteLine($"Material: {fornecedor.TipoFornecedor}");
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
            string material = "";

            Console.WriteLine("Janela para cadastro de novo fornecedor");
            Console.Write("Código: ");
            int.TryParse(Console.ReadLine(), out codigo);
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("CPF: ");
            cpf = Console.ReadLine();
            Console.Write("Material: ");
            material = Console.ReadLine();

            Fornecedor fornecedor = new Fornecedor(codigo, nome, cpf, material);
            Program.Mock.ListaFornecedores.Add(fornecedor);

            Console.WriteLine("\nCadastro efetuado com sucesso!");
        }

        public void Alterar()
        {
            Console.Clear();
            Fornecedor fornecedor;
            int codigoFornecedor;

            Console.WriteLine("Informe o fornecedor que você deseja alterar");
            ListarFornecedoresByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoFornecedor);

            fornecedor = Program.Mock.ListaFornecedores.Find(p => p.CodigoFornecedor == codigoFornecedor);

            string opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.WriteLine($"Código {fornecedor.Codigo}:{fornecedor.CodigoFornecedor} | Nome: {fornecedor.Nome} | CPF: {fornecedor.CGCCPF} | Material: {fornecedor.TipoFornecedor}\n");
                Console.WriteLine("Qual campo você deseja alterar?");
                Console.WriteLine("01 - Nome | 02 - CPF | 03 - Material | 00 - Sair\n");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.WriteLine("Informe um novo nome:");
                        fornecedor.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo CPF:");
                        fornecedor.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Informe um novo tipo de material:");
                        fornecedor.TipoFornecedor = Console.ReadLine();
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

            AlterarFornecedor(fornecedor);
        }

        public void Excluir()
        {
            Fornecedor fornecedor = new Fornecedor();
            ExcluirFornecedor(fornecedor);
        }
        
    }
}
