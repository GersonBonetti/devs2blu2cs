<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.Classes
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
    
        public string ApresentarNomeCustom()
        {
            string nomeCustom;
            nomeCustom = $"{SobreNome}, {Nome}";
            return nomeCustom;
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
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
    
        public string ApresentarNomeCustom()
        {
            string nomeCustom;
            nomeCustom = $"{SobreNome}, {Nome}";
            return nomeCustom;
        }
    }
}
>>>>>>> 19bb5480b5f0234aceee6029f0baf077b0a4b731
