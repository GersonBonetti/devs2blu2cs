using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP2Classes
{
    public class Pessoa : Contato
    {
        public Pessoa() { }

        public Pessoa(string nome, string cel, string email)
        {
            Nome = nome;
            Cel = cel;
            Email = email;
        }
    }
}
