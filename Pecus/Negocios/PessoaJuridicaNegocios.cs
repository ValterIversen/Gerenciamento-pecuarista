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
    public class PessoaJuridicaNegocios
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
                acessoDadosSqlServer.AdicionarParametros("@PessoaJuridicaCNPJ", pessoa.PessoaJuridica.PessoaJuridicaCNPJ);
                acessoDadosSqlServer.AdicionarParametros("@PessoaJuridicaRazaoSocial", pessoa.PessoaJuridica.PessoaJuridicaRazaoSocial);
                acessoDadosSqlServer.AdicionarParametros("@PessoaJuridicaNomeFicticio", pessoa.PessoaJuridica.PessoaJuridicaNomeFicticio);
                acessoDadosSqlServer.AdicionarParametros("@PessoaID", pessoa.PessoaID);

                return acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterPessoaJuridica").ToString();

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
                if(pessoa.PessoaFisica.PessoaFisicaCPF != "")
                {
                    acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Inserir");
                    acessoDadosSqlServer.AdicionarParametros("@PessoaJuridicaCNPJ", pessoa.PessoaJuridica.PessoaJuridicaCNPJ);
                    acessoDadosSqlServer.AdicionarParametros("@PessoaJuridicaRazaoSocial", pessoa.PessoaJuridica.PessoaJuridicaRazaoSocial);
                    acessoDadosSqlServer.AdicionarParametros("@PessoaJuridicaNomeFicticio", pessoa.PessoaJuridica.PessoaJuridicaNomeFicticio);
                    acessoDadosSqlServer.AdicionarParametros("@PessoaID", pessoa.PessoaID);
                }
                else
                {
                    acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Alterar");
                    acessoDadosSqlServer.AdicionarParametros("@PessoaJuridicaCNPJ", pessoa.PessoaJuridica.PessoaJuridicaCNPJ);
                    acessoDadosSqlServer.AdicionarParametros("@PessoaJuridicaRazaoSocial", pessoa.PessoaJuridica.PessoaJuridicaRazaoSocial);
                    acessoDadosSqlServer.AdicionarParametros("@PessoaJuridicaNomeFicticio", pessoa.PessoaJuridica.PessoaJuridicaNomeFicticio);
                    acessoDadosSqlServer.AdicionarParametros("@PessoaID", pessoa.PessoaID);
                }

                acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterPessoaJuridica");

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
                acessoDadosSqlServer.AdicionarParametros("@PessoaJuridicaCNPJ", pessoa.PessoaJuridica.PessoaJuridicaCNPJ);
                acessoDadosSqlServer.AdicionarParametros("@PessoaJuridicaRazaoSocial", "");
                acessoDadosSqlServer.AdicionarParametros("@PessoaJuridicaNomeFicticio", "");
                acessoDadosSqlServer.AdicionarParametros("@PessoaID", 0);

                acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterPessoaJuridica");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public PessoaCollection ConsultaPorCNPJ(string CNPJ)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "CNPJ");
                acessoDadosSqlServer.AdicionarParametros("@PessoaJuridicaCNPJ", CNPJ);
                acessoDadosSqlServer.AdicionarParametros("@PessoaJuridicaRazaoSocial", "");
                acessoDadosSqlServer.AdicionarParametros("@PessoaJuridicaNomeFicticio", "");

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaPessoaJuridica");

                PessoaCollection pessoaCollection = new PessoaCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Pessoa pessoa = new Pessoa();
                    pessoa.PessoaJuridica = new PessoaJuridica();
                    pessoa.PessoaFisica = new PessoaFisica();
                    pessoa.PessoaFisica.PessoaFisicaCPF = "";
                    pessoa.PessoaFisica.PessoaFisicaNome = "";
                    pessoa.PessoaJuridica.PessoaJuridicaCNPJ = row["PessoaJuridicaCNPJ"].ToString();
                    pessoa.PessoaJuridica.PessoaJuridicaRazaoSocial = row["PessoaJuridicaRazaoSocial"].ToString();
                    pessoa.PessoaJuridica.PessoaJuridicaNomeFicticio = row["PessoaJuridicaNomeFicticio"].ToString();
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

        public PessoaCollection ConsultaPorRazaoSocial(string RazaoSocial)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "RazaoS");
                acessoDadosSqlServer.AdicionarParametros("@PessoaJuridicaCNPJ", "");
                acessoDadosSqlServer.AdicionarParametros("@PessoaJuridicaRazaoSocial", RazaoSocial);
                acessoDadosSqlServer.AdicionarParametros("@PessoaJuridicaNomeFicticio", "");

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaPessoaJuridica");

                PessoaCollection pessoaCollection = new PessoaCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Pessoa pessoa = new Pessoa();
                    pessoa.PessoaJuridica = new PessoaJuridica();
                    pessoa.PessoaFisica = new PessoaFisica();
                    pessoa.PessoaFisica.PessoaFisicaCPF = "";
                    pessoa.PessoaFisica.PessoaFisicaNome = "";
                    pessoa.PessoaJuridica.PessoaJuridicaCNPJ = row["PessoaJuridicaCNPJ"].ToString();
                    pessoa.PessoaJuridica.PessoaJuridicaRazaoSocial = row["PessoaJuridicaRazaoSocial"].ToString();
                    pessoa.PessoaJuridica.PessoaJuridicaNomeFicticio = row["PessoaJuridicaNomeFicticio"].ToString();
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

        public PessoaCollection ConsultaPorNomeFicticio(string NomeFicticio)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "NomeF");
                acessoDadosSqlServer.AdicionarParametros("@PessoaJuridicaCNPJ", "");
                acessoDadosSqlServer.AdicionarParametros("@PessoaJuridicaRazaoSocial", "");
                acessoDadosSqlServer.AdicionarParametros("@PessoaJuridicaNomeFicticio", NomeFicticio);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaPessoaJuridica");

                PessoaCollection pessoaCollection = new PessoaCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Pessoa pessoa = new Pessoa();
                    pessoa.PessoaJuridica = new PessoaJuridica();
                    pessoa.PessoaFisica = new PessoaFisica();
                    pessoa.PessoaFisica.PessoaFisicaCPF = "";
                    pessoa.PessoaFisica.PessoaFisicaNome = "";
                    pessoa.PessoaJuridica.PessoaJuridicaCNPJ = row["PessoaJuridicaCNPJ"].ToString();
                    pessoa.PessoaJuridica.PessoaJuridicaRazaoSocial = row["PessoaJuridicaRazaoSocial"].ToString();
                    pessoa.PessoaJuridica.PessoaJuridicaNomeFicticio = row["PessoaJuridicaNomeFicticio"].ToString();
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
