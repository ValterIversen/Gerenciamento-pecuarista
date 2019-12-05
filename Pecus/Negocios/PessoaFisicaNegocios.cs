using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AcessoBancoDados;
using ObjetoTransferencia;

namespace Negocios
{
    public class PessoaFisicaNegocios
    {
        //Instancio a classe de acesso ao banco de dados
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Cadastrar(Pessoa pessoa)
        {
            try
            {
                PessoaNegocios pessoaNegocios = new PessoaNegocios();
                pessoa.PessoaID = pessoaNegocios.Cadastrar(pessoa);
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Inserir");
                acessoDadosSqlServer.AdicionarParametros("@PessoaFisicaCPF", pessoa.PessoaFisica.PessoaFisicaCPF);
                acessoDadosSqlServer.AdicionarParametros("@PessoaFisicaNome", pessoa.PessoaFisica.PessoaFisicaNome);
                acessoDadosSqlServer.AdicionarParametros("@PessoaID", pessoa.PessoaID);

                return acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterPessoaFisica").ToString();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(Pessoa pessoa)
        {
            try
            {
                PessoaNegocios pessoaNegocios = new PessoaNegocios();
                pessoaNegocios.Alterar(pessoa);
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                if (pessoa.PessoaJuridica.PessoaJuridicaCNPJ != "")
                {
                    acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Inserir");
                    acessoDadosSqlServer.AdicionarParametros("@PessoaFisicaCPF", pessoa.PessoaFisica.PessoaFisicaCPF);
                    acessoDadosSqlServer.AdicionarParametros("@PessoaFisicaNome", pessoa.PessoaFisica.PessoaFisicaNome);
                    acessoDadosSqlServer.AdicionarParametros("@PessoaID", pessoa.PessoaID);
                }
                else
                {
                    acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Alterar");
                    acessoDadosSqlServer.AdicionarParametros("@PessoaFisicaCPF", pessoa.PessoaFisica.PessoaFisicaCPF);
                    acessoDadosSqlServer.AdicionarParametros("@PessoaFisicaNome", pessoa.PessoaFisica.PessoaFisicaNome);
                    acessoDadosSqlServer.AdicionarParametros("@PessoaID", pessoa.PessoaID);
                }

                acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterPessoaFisica");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Excluir(Pessoa pessoa)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Excluir");
                acessoDadosSqlServer.AdicionarParametros("@PessoaFisicaCPF", pessoa.PessoaFisica.PessoaFisicaCPF);
                acessoDadosSqlServer.AdicionarParametros("@PessoaFisicaNome", "");
                acessoDadosSqlServer.AdicionarParametros("@PessoaID", 0);

                acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterPessoaFisica");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public PessoaCollection ConsultaPorNome(string Nome)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Nome");
                acessoDadosSqlServer.AdicionarParametros("@PessoaFisicaCPF", "");
                acessoDadosSqlServer.AdicionarParametros("@PessoaFisicaNome", Nome);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaPessoaFisica");

                PessoaCollection pessoaCollection = new PessoaCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Pessoa pessoa = new Pessoa();
                    pessoa.PessoaFisica = new PessoaFisica();
                    pessoa.PessoaJuridica = new PessoaJuridica();
                    pessoa.PessoaJuridica.PessoaJuridicaCNPJ = "";
                    pessoa.PessoaJuridica.PessoaJuridicaNomeFicticio = "";
                    pessoa.PessoaJuridica.PessoaJuridicaRazaoSocial = "";
                    pessoa.PessoaFisica.PessoaFisicaCPF = row["PessoaFisicaCPF"].ToString();
                    pessoa.PessoaFisica.PessoaFisicaNome = row["PessoaFisicaNome"].ToString();
                    pessoa.Cidade = new Cidade();
                    pessoa.PessoaID = Convert.ToInt32(row["PessoaID"]);
                    pessoa.PessoaEndereco = row["PessoaEndereco"].ToString();
                    pessoa.PessoaBairro = row["PessoaBairro"].ToString();
                    pessoa.PessoaTelefone = row["PessoaTelefone"].ToString();
                    pessoa.PessoaAtivo = Convert.ToBoolean(row["PessoaAtivo"]);
                    pessoa.Cidade.CidadeID = Convert.ToInt32(row["CidadeID"]);
                    pessoa.Cidade.CidadeNome = row["CidadeNome"].ToString();
                    pessoa.Cidade.EstadoID = Convert.ToInt32(row["EstadoID"]);
                    pessoa.Cidade.EstadoNome = row["EstadoNome"].ToString();
                    pessoa.Cidade.EstadoSigla = row["EstadoSigla"].ToString();

                    pessoaCollection.Add(pessoa);
                }

                return pessoaCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public PessoaCollection ConsultaPorCPF(string CPF)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "CPF");
                acessoDadosSqlServer.AdicionarParametros("@PessoaFisicaCPF", CPF);
                acessoDadosSqlServer.AdicionarParametros("@PessoaFisicaNome", "");

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaPessoaFisica");

                PessoaCollection pessoaCollection = new PessoaCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Pessoa pessoa = new Pessoa();
                    pessoa.PessoaFisica = new PessoaFisica();
                    pessoa.PessoaJuridica = new PessoaJuridica();
                    pessoa.PessoaJuridica.PessoaJuridicaCNPJ = "";
                    pessoa.PessoaJuridica.PessoaJuridicaNomeFicticio = "";
                    pessoa.PessoaJuridica.PessoaJuridicaRazaoSocial = "";
                    pessoa.PessoaFisica.PessoaFisicaCPF = row["PessoaFisicaCPF"].ToString();
                    pessoa.PessoaFisica.PessoaFisicaNome = row["PessoaFisicaNome"].ToString();
                    pessoa.Cidade = new Cidade();
                    pessoa.PessoaID = Convert.ToInt32(row["PessoaID"]);
                    pessoa.PessoaEndereco = row["PessoaEndereco"].ToString();
                    pessoa.PessoaBairro = row["PessoaBairro"].ToString();
                    pessoa.PessoaTelefone = row["PessoaTelefone"].ToString();
                    pessoa.PessoaAtivo = Convert.ToBoolean(row["PessoaAtivo"]);
                    pessoa.Cidade.CidadeID = Convert.ToInt32(row["CidadeID"]);
                    pessoa.Cidade.CidadeNome = row["CidadeNome"].ToString();
                    pessoa.Cidade.EstadoID = Convert.ToInt32(row["EstadoID"]);
                    pessoa.Cidade.EstadoNome = row["EstadoNome"].ToString();
                    pessoa.Cidade.EstadoSigla = row["EstadoSigla"].ToString();

                    pessoaCollection.Add(pessoa);
                }

                return pessoaCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
