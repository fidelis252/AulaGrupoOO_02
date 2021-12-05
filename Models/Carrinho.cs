using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadeGrupo02.Models
{
    class Carrinho
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public Entrega Entrega { get; set; }
        private double _valorTotal;

        public void setValorTotal() {
            _valorTotal = Produto.valor * Quantidade;
        }
        public double getValorTotal()
        {
            return _valorTotal;
        }
    }
}
