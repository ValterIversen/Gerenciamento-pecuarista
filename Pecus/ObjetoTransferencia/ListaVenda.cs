using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class ListaVenda : Venda
    {
        public int ListaVendaID { get; set; }
        public decimal ListaVendaValor { get; set; }
        public Venda Venda { get; set; }
        public Animal Animal { get; set; }
    }
    public class ListaVendaCollection : List<ListaVenda>
    {

    }
}
