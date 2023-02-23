<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.Classes
{
    public class Diretor : Pessoa
    {
        public double ProLabore { get; set; }

        public Diretor() { }

        public Diretor(string nome, string sobrenome, double proLabore)
        {
            Nome = nome;
            SobreNome = sobrenome;
            ProLabore = proLabore;  
        }

        public string VerificaStatus()
        {
            return "Hospital OK!";
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
    public class Diretor : Pessoa
    {
        public double ProLabore { get; set; }

        public Diretor() { }

        public Diretor(string nome, string sobrenome, double proLabore)
        {
            Nome = nome;
            SobreNome = sobrenome;
            ProLabore = proLabore;  
        }

        public string VerificaStatus()
        {
            return "Hospital OK!";
        }
    }
}
>>>>>>> 19bb5480b5f0234aceee6029f0baf077b0a4b731
