<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.Classes
{
    public class Recepcionista : Pessoa
    {
        public int NumeroCracha { get; set; }
        
        public Recepcionista() { }
        
        public Recepcionista(string nome, string sobrenome)
        {
            this.Nome = nome;
            this.SobreNome = sobrenome;
        }

        public Recepcionista(int numeroCracha, string endereco)
        {
            NumeroCracha = numeroCracha;
            Endereco = endereco;
        }

        public string AgendarConsulta()
        {
            return $"Consulta agendada";
        }

    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.Classes
{
    public class Recepcionista : Pessoa
    {
        public int NumeroCracha { get; set; }
        
        public Recepcionista() { }
        
        public Recepcionista(string nome, string sobrenome)
        {
            this.Nome = nome;
            this.SobreNome = sobrenome;
        }

        public Recepcionista(int numeroCracha, string endereco)
        {
            NumeroCracha = numeroCracha;
            Endereco = endereco;
        }

        public string AgendarConsulta()
        {
            return $"Consulta agendada";
        }

    }
}
>>>>>>> 19bb5480b5f0234aceee6029f0baf077b0a4b731
