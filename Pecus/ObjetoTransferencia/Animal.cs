using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Animal
    {
        public int AnimalID { get; set; }
        public string AnimalDescricao { get; set; }
        public Animal AnimalParentescoPai { get; set; }
        public Animal AnimalParentescoMae { get; set; }
        public string AnimalLocalidadeNascimento { get; set; }
        public DateTime AnimalDataNascimento { get; set; }
        public string AnimalIdentificador { get; set; }
        public bool AnimalAtivo { get; set; }
        public decimal AnimalValor { get; set; }
        public Raca Raca { get; set; }
        public Piquete Piquete { get; set; }
        public PesagemCollection Pesagens{ get; set; }
    }
    public class AnimalRelatorio
    {
        public int AnimalID { get; set; }
        public string AnimalDescricao { get; set; }
        public string AnimalIdentificador { get; set; }
        public bool AnimalAtivo { get; set; }
        public int RacaID { get; set; }
        public string RacaNome { get; set; }
        public string RacaDescricao { get; set; }
        public int PesagemID { get; set; }
        public DateTime PesagemData { get; set; }
        public decimal PesagemPeso { get; set; }
    }
    public class AnimalCollection : List<Animal>
    {

    }
}
