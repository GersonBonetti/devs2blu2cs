using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastro
{
    public class CadastroMedico : IMenuCadastro
    {
        public CadastroMedico() { }
        public Medico novoMedico;

        public Int32 MenuCadastro()
        {
            Int32 opcao
                ;
            Console.Clear();
            Console.WriteLine("╔════ Cadastro de Médicos ══════╗");
            Console.WriteLine("║    1 - Lista de Médicos       ║");
            Console.WriteLine("║    2 - Cadastro de Médicos    ║");
            Console.WriteLine("║    3 - Alterar Médicos        ║");
            Console.WriteLine("║    4 - Excluir Médicos        ║");
            Console.WriteLine("║-------------------------------║");
            Console.WriteLine("║            0 - Sair           ║");
            Console.WriteLine("╚═══════════════════════════════╝");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;
        }

        private void ListarMedicosByCodeAndName()
        {
            Console.Clear();

            foreach (Medico medico in Program.Mock.ListaMedico)
            {
                Console.Write($"{medico.CodigoMedico} - Nome: {medico.Nome}\n");
            }
            Console.WriteLine("\n");
        }

        private void AlterarMedico(Medico medico)
        {
            var pact = Program.Mock.ListaMedico.Find(p => p.CodigoMedico == medico.CodigoMedico);
            int index = Program.Mock.ListaMedico.IndexOf(pact);
            Program.Mock.ListaMedico[index] = medico;
        }

        private void ExcluirMedico(Medico medico)
        {
            Int32 codigo;

            Console.Clear();
            Console.WriteLine("Qual o código do médico que você desejar excluir?");
            Int32.TryParse(Console.ReadLine(), out codigo);
            ListarMedicosByCodeAndName();
        }

        public void Listar()
        {
            Console.Clear();

            foreach (Medico medico in Program.Mock.ListaMedico)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine($"Médico: {medico.Codigo}");
                Console.WriteLine($"Nome: {medico.Nome}");
                Console.WriteLine($"Especialidade: {medico.Especialidade}");
                Console.WriteLine($"CRM: {medico.CRM}");
                Console.WriteLine("------------------------------");

            }
        }

        public void Cadastrar()
        {
            Console.Clear();

            int codigo = 0;
            string nome = "";
            string cpf = "";
            int crm = 0;
            string especialidade = "";

            Console.WriteLine("Janela para cadastro de novo médico");
            Console.Write("Código: ");
            int.TryParse(Console.ReadLine(), out codigo);
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("CPF: ");
            cpf = Console.ReadLine();
            Console.Write("CRM: ");
            int.TryParse(Console.ReadLine(), out crm);
            Console.Write("Especialidade: ");
            especialidade = Console.ReadLine();

            Medico medico = new Medico(codigo, nome, cpf, crm, especialidade);
            Program.Mock.ListaMedico.Add(medico);

            Console.WriteLine("\nCadastro efetuado com sucesso!");
        }

        public void Alterar()
        {
            Console.Clear();
            Medico medico;
            int codigoMedico;

            Console.WriteLine("Informe o médico que você deseja alterar");
            ListarMedicosByCodeAndName();

            Int32.TryParse(Console.ReadLine(), out codigoMedico);

            medico = Program.Mock.ListaMedico.Find(p => p.CodigoMedico == codigoMedico);

            string opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.WriteLine($"Código {medico.Codigo}:{medico.CodigoMedico} | Nome: {medico.Nome} | CPF: {medico.CGCCPF} | Especialidade: {medico.Especialidade}");
                Console.WriteLine("Qual campo você deseja alterar?");
                Console.WriteLine("01 - Nome | 02 - CPF | 03 - Especialidade | 00 - Sair");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.WriteLine("Informe um novo nome:");
                        medico.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.WriteLine("Informe um novo CPF:");
                        medico.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.WriteLine("Informe um novo especialidade:");
                        medico.Especialidade = Console.ReadLine();
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

            AlterarMedico(medico);
        }

        public void Excluir()
        {
            Medico medico = new Medico();
            ExcluirMedico(medico);
        }
    }
}