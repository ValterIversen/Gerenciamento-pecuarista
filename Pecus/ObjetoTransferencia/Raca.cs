using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Raca
    {
        public int RacaID { get; set; }
        public string RacaNome { get; set; }
        public string RacaDescricao { get; set; }
    }
    public class RacaCollection : List<Raca>
    {

    }
}
