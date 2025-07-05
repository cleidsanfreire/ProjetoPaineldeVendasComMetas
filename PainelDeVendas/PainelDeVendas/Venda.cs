using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PainelDeVendas
{
    internal class Venda
    {
        public Produto ProdutoVendido { get; set; }
        public DateTime DataVenda { get; set; }

        public Venda(Produto produto)
        {
            ProdutoVendido = produto;
            DataVenda = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Produto: {ProdutoVendido.Name}, Comissão: {ProdutoVendido.Comissao:C}, Data da Venda: {DataVenda}";
        }
    }
}
