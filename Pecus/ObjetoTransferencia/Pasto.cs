using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Pasto
    {
        public int PastoID { get; set; }
        public string PastoDescricao { get; set; }
        public decimal PastoTamanho { get; set; }
        public bool PastoAtivo { get; set; }
        public Cidade Cidade { get; set; }
        public ContratoAluguel ContratoAluguel { get; set; }
        public PiqueteCollection Piquetes { get; set; }
    }
    public class PastoRelatorio
    {
        public int PastoID { get; set; }
        public string PastoDescricao { get; set; }
        public decimal PastoTamanho { get; set; }
        public bool PastoAtivo { get; set; }
        public string CidadeNome { get; set; }
        public string EstadoNome { get; set; }
    }
    public class PastoCollection : List<Pasto>
    {

    }
}
