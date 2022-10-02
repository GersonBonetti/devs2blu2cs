using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastro
{
    public class CadastroPaciente : IMenuCadastro
    {
        public CadastroPaciente() { }
        public Paciente novoPaciente;

        private void ListarPacientes()
        {
            Console.Clear();

            foreach (Paciente paciente in Program.Mock.ListaPacientes)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine($"Paciente: {paciente.CodigoPaciente}");
                Console.WriteLine($"Nome: {paciente.Nome}");
                Console.WriteLine($"CPF: {paciente.CGCCPF}");
                Console.WriteLine($"Convênio: {paciente.Convenio}");
                Console.WriteLine("------------------------------");
            }
            Console.ReadLine();
        }

        private void ListarPacientesByCodeAndName()
        {
            Console.Clear();

            foreach (Paciente paciente in Program.Mock.ListaPacientes)
            {
                Console.Write($"{paciente.CodigoPaciente} - Nome: {paciente.Nome}\n");
            }
            Console.WriteLine("\n");
        }

        private void CadastrarPaciente(Paciente novoPaciente)
        {
            Console.Clear();

            int codigo = 0;
            string nome = "";
            string cpf = "";
            string convenio = "";

            Console.WriteLine("Janela para cadastro de novo paciente");
            Console.Write("Código: ");
            int.TryParse(Console.ReadLine(), out codigo);
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("CPF: ");
            cpf = Console.ReadLine();
            Console.Write("Convenio: ");
            convenio = Console.ReadLine();

            Paciente paciente = new Paciente(codigo, nome, cpf, convenio);
            Program.Mock.ListaPacientes.Add(paciente);

            Console.WriteLine("\nCadastro efetuado com sucesso!");
        }

        private void AlterarPaciente(Paciente paciente)
        {
            var pact = Program.Mock.ListaPacientes.Find(p => p.CodigoPaciente == paciente.CodigoPaciente);
            int index = Program.Mock.ListaPacientes.IndexOf(pact);
            Program.Mock.ListaPacientes[index] = paciente;
        }

        private void ExcluirPaciente(Paciente paciente)
        {
            Int32 codigo;

            Console.Clear();
            Console.WriteLine("Qual o código do paciente que você desejar excluir?");
            Int32.TryParse(Console.ReadLine(), out codigo);
            ListarPacientesByCodeAndName();
        }

        #region FACADE

        public Int32 MenuCadastro()
        {
            Int32 opcao;
            Console.Clear();
            Console.WriteLine("╔════ Cadastro de Pacientes ════╗");
            Console.WriteLine("║    1 - Lista de Pacientes     ║");
            Console.WriteLine("║    2 - Cadastro de Pacientes  ║");
            Console.WriteLine("║    3 - Alterar Pacientes      ║");
            Console.WriteLine("║    4 - Excluir Pacientes      ║");
            Console.WriteLine("║-------------------------------║");
            Console.WriteLine("║            0 - Sair           ║");
            Console.WriteLine("╚═══════════════════════════════╝");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;
        }

        public void Listar()
        {
            ListarPacientes();
        }

        public void Cadastrar()
        {
            Paciente paciente = new Paciente();
            CadastrarPaciente(paciente);
        }

        public void Alterar()
        {
            Console.Clear();
            Paciente paciente;
            int codigoPacientes;

            Console.WriteLine("Informe o paciente que você deseja alterar");
            ListarPacientesByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoPacientes);

            paciente = Program.Mock.ListaPacientes.Find(p => p.CodigoPaciente == codigoPacientes);

            string opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.WriteLine($"Código {paciente.Codigo}:{paciente.CodigoPaciente} | Nome: {paciente.Nome} | CPF: {paciente.CGCCPF} | Convênio: {paciente.Convenio}");
                Console.WriteLine("Qual campo você deseja alterar?");
                Console.WriteLine("01 - Nome | 02 - CPF | 03 - Convênio | 00 - Sair");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.WriteLine("Informe um novo nome:");
                        paciente.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo CPF:");
                        paciente.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Informe um novo convênio:");
                        paciente.Convenio = Console.ReadLine();
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

            AlterarPaciente(paciente);
        }

        public void Excluir()
        {
            Paciente paciente = new Paciente();
            ExcluirPaciente(paciente);
        }

        #endregion
    }
}
