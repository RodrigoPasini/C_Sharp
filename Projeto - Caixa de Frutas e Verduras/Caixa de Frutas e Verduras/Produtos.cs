using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa_de_Frutas_e_Verduras
{
    class Produtos

    {
        public int Codigo { get; set; }
        public string Produto { get; set; }
        public string Tipo { get; set; }
        public decimal  Preco { get; set; }
        public decimal Quantidade{ get; set; }
        public DateTime Vencimento { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }
    }
}
