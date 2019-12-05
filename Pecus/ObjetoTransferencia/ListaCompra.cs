using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class ListaCompra : Compra
    {
        public int ListaCompraID { get; set; }
        public decimal ListaCompraValor { get; set; }
        public Animal Animal { get; set; }
    }
    public class ListaCompraCollection : List<ListaCompra>
    {

    }
}
