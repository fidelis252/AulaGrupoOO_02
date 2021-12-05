using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadeGrupo02.Models
{
    class Entrega
    {
        public int TipoEntrega { get; set; }
        public string mostraEntrega()
        {
            return TipoEntrega == 0 ? "Via Download." : "Via Email.";
        }

    }
}
