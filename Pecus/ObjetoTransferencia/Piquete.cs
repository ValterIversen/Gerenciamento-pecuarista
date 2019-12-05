using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Piquete
    {
        public int PiqueteID { get; set; }
        public string PiqueteDescricao { get; set; }
        public bool PiqueteAtivo { get; set; }
        public int PiqueteQuantidadeAnimais { get; set; }
        public Pasto Pasto { get; set; }
        public AnimalCollection Animais { get; set; }
    }

    public class PiqueteRelatorio
    {
        public int PiqueteID { get; set; }
        public string PiqueteDescricao { get; set; }
        public bool PiqueteAtivo { get; set; }
        public int PiqueteQuantidadeAnimais { get; set; }
        public string PastoDescricao { get; set; }
        public decimal PastoTamanho { get; set; }
    }
    public class PiqueteCollection : List<Piquete>
    {

    }
}
