using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Enum;
using System;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model
{
    public class Fornecedor : Pessoa
    {
        public Int32 Id { get; set; }
        public String TipoFornecedor { get; set; }

        public Fornecedor() { TipoPessoa = TipoPessoa.PJ; }

    }
}
