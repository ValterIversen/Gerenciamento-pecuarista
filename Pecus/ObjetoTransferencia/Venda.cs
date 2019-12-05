using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Venda
    {
        public int VendaID { get; set; }
        public DateTime VendaData { get; set; }
        public DateTime VendaDataEntrega { get; set; }
        public decimal VendaValorTotal { get; set; }
        public int VendaQuantidade { get; set; }
        public Pessoa Pessoa { get; set; }
        public Usuario Usuario { get; set; }
        public AnimalCollection Animais{ get; set; }
    }
    public class VendaCollection : List<Venda>
    {

    }
}
