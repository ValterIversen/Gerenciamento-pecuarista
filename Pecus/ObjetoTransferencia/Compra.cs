using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Compra
    {
        public int CompraID { get; set; }
        public DateTime CompraData { get; set; }
        public DateTime CompraDataEntrega { get; set; }
        public decimal CompraValorTotal { get; set; }
        public int CompraQuantidade { get; set; }
        public Pessoa Pessoa { get; set; }
        public Usuario Usuario { get; set; }
        public AnimalCollection Animais{ get; set; }
    }
    public class CompraCollection : List<Compra>
    {

    }
}
