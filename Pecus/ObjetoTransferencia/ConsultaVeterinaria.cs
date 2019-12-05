using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class ConsultaVeterinaria
    {
        public int ConsultaVeterinariaID { get; set; }
        public DateTime ConsultaVeterinariaData { get; set; }
        public string ConsultaVeterinariaDescricao { get; set; }
        public decimal ConsultaVeterinariaCusto { get; set; }
        public Animal Animal { get; set; }
        public VeterinarioCollection Veterinarios { get; set; }
    }

    public class ConsultaVeterinariaRelatorio
    {
        public int ConsultaVeterinariaID { get; set; }
        public DateTime ConsultaVeterinariaData { get; set; }
        public string ConsultaVeterinariaDescricao { get; set; }
        public decimal ConsultaVeterinariaCusto { get; set; }
        public string AnimalDescricao { get; set; }
        public string AnimalIdentificador { get; set; }
        public string RacaNome { get; set; }
    }

    public class ConsultaVeterinariaCollection : List<ConsultaVeterinaria>
    {

    }
}
