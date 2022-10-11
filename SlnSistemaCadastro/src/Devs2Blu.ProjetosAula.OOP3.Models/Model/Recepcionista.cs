using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Enum;
using System;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model
{
    public class Recepcionista : Pessoa
    {
        public Int32 CodigoRecepcionista { get; set; }

        public String Setor { get; set; }

        public Recepcionista() { TipoPessoa = TipoPessoa.PF; }

    }
}