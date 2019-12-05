using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Pesagem
    {
        public int PesagemID { get; set; }
        public DateTime PesagemData { get; set; }
        public decimal PesagemPeso { get; set; }
        public Animal Animal { get; set; }
    }
    public class PesagemRelatorio
    {
        public int PesagemID { get; set; }
        public DateTime PesagemData { get; set; }
        public decimal PesagemPeso { get; set; }
        public string AnimalRaca { get; set; }
        public string AnimalIdentificador { get; set; }
        public string AnimalDescricao { get; set; }
    }

    public class PesagemRacaPeso
    {
        public string Raca { get; set; }
        public decimal Peso { get; set; }
    }

    public class PesagemCollection : List<Pesagem>
    {

    }
}
