using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class ContratoAluguel
    {
        public int ContratoAluguelID { get; set; }
        public DateTime ContratoAluguelDataInicial { get; set; }
        public DateTime ContratoAluguelDataFinal { get; set; }
        public decimal ContratoAluguelValor { get; set; }
        public int QuantidadeEstoqueLocalidade { get; set; }
        public int QuantidadePasto { get; set; }
        public Pessoa Pessoa { get; set; }
        public PastoCollection Pastos { get; set; }
        public EstoqueLocalidadeCollection EstoquesLocalidade{ get; set; }
    }
    public class ContratoAluguelCollection : List<ContratoAluguel>
    {

    }
}
