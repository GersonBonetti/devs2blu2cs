using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Utils
{
    public class Mocks
    {
        public List<Paciente> ListaPacientes { get; set; }
        public List<Medico> ListaMedico { get; set; }
        public List<Recepcionista> ListaRecepcionistas { get; set; }
        public List<Fornecedor> ListaFornecedores{ get; set; }

        public Mocks()
        {
            ListaPacientes = new List<Paciente>();
            ListaMedico = new List<Medico>();
            ListaRecepcionistas = new List<Recepcionista>();
            ListaFornecedores = new List<Fornecedor>();

            CargaMock();
        }

        public void CargaMock()
        {
            CargaPaciente();
            CargaMedico();
            CargaRecepcionista();
            CargaFornecedor();
        }

        public void CargaPaciente()
        {
            for (int i = 0; i < 10; i++)
            {
                Paciente paciente = new Paciente(i, $"Paciente {i+1}", $"{i}23{i}56{i}891{i}", "Unimed");
                ListaPacientes.Add(paciente);
            }
        }

        public void CargaMedico()
        {
            Random random = new Random();
            String[] especialidades = {"Clínico Geral", "Neurologista", "Ginecologista", "Pediatra"};
            
            for (int i = 0; i < 10; i++)
            {
                Medico medico = new Medico(i, $"Médico {i + i}", $"{i}23{i}56{i}891{i}", random.Next(1,999), especialidades[random.Next(0,3)]);
                ListaMedico.Add(medico);
            }
        }

        public void CargaRecepcionista()
        {
            Random rd = new Random();

            for (int i = 0; i < 10; i++)
            {
                Recepcionista recepcionista = new Recepcionista(i+1, $"Recepcionista {i + i}", $"{i}23{i}56{i}891{i}", $"Setor {rd.Next(1,8)}");
                ListaRecepcionistas.Add(recepcionista);
            }
        }

        public void CargaFornecedor()
        {
            Random rd = new Random();
            String[] material = {"Medicamentos", "Aparelhos respiratórios", "Agulhas", "Produtos de limpeza" };

            for (int i = 0; i < 10; i++)
            {
                Fornecedor fornecedor = new Fornecedor(i + 1, $"Fornecedor {i + i}", $"{i}23{i}56{i}891{i}", $"Material: {material[rd.Next(0,3)]}");
                ListaFornecedores.Add(fornecedor);
            }
        }
    }
}