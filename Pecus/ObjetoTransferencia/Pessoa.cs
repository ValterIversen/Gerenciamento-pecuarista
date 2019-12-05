using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Pessoa
    {
        public int PessoaID { get; set; }
        public string PessoaEndereco { get; set; }
        public string PessoaBairro { get; set; }
        public string PessoaTelefone { get; set; }
        public bool PessoaAtivo { get; set; }
        public Cidade Cidade { get; set; }
        public PessoaFisica PessoaFisica{ get; set; }
        public PessoaJuridica PessoaJuridica{ get; set; }
    }
    public class PessoaCollection : List<Pessoa>
    {

    }

}
