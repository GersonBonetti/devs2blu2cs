using ProjaAgendaContato.Enums;
using System;

namespace Models.Models
{
    public class Compromisso
    {
        public Int32 Id_contatos { get; set; }
        public String Titulo { get; set; }
        public String Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public Status Status { get; set; }

        public Compromisso() { }

        public Compromisso(int id_contatos, string titulo, string descricao, DateTime dataInicio, DateTime dataFim, Status status)
        {
            Id_contatos = id_contatos;
            Titulo = titulo;
            Descricao = descricao;
            DataInicio = dataInicio;
            DataFim = dataFim;
            Status = status;
        }
    }
}
