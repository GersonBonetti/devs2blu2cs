﻿using Devs2Blu.ProjetosAula.OOP3.Models.Enum;
using System;

namespace Devs2Blu.ProjetosAula.OOP3.Models.Model
{
    public class Recepcionista : Pessoa
    {
        public Int32 CodigoRecepcionista { get; set; }
        public String Setor { get; set; }
        public Recepcionista() { TipoPessoa = TipoPessoa.PF; }

        public Recepcionista(Int32 codigo, String nome, String cpf, String setor)
        {
            Codigo = codigo;
            Nome = nome;
            CGCCPF = cpf;
            TipoPessoa = TipoPessoa.PF;
            Setor = setor;

            Random rd = new Random();
            CodigoRecepcionista = int.Parse($"{codigo}{rd.Next(1000, 1100)}");
        }
    }
}