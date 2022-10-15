using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjaAgendaContato.Enums
{
    public enum Status
    {
        [Description("Inativo")]
        I = 0,
        [Description("Ativo")]
        A = 1,
        [Description("Concluído")]
        C = 2,
        [Description("Remarcado")]
        R = 3
    }
}
