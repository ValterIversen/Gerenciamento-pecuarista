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
    public class PessoaNegocios
    {
        //Instancio a classe de acesso ao banco de dados
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public int Cadastrar(Pessoa pessoa)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@PessoaEndereco", pessoa.PessoaEndereco);
                acessoDadosSqlServer.AdicionarParametros("@PessoaBairro", pessoa.PessoaBairro);
                acessoDadosSqlServer.AdicionarParametros("@PessoaTelefone", pessoa.PessoaTelefone);
                acessoDadosSqlServer.AdicionarParametros("@PessoaAtivo", pessoa.PessoaAtivo);
                acessoDadosSqlServer.AdicionarParametros("@CidadeID", pessoa.Cidade.CidadeID);

                return int.Parse(acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCadastrarPessoa"));

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
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@PessoaID", pessoa.PessoaID);
                acessoDadosSqlServer.AdicionarParametros("@PessoaEndereco", pessoa.PessoaEndereco);
                acessoDadosSqlServer.AdicionarParametros("@PessoaBairro", pessoa.PessoaBairro);
                acessoDadosSqlServer.AdicionarParametros("@PessoaTelefone", pessoa.PessoaTelefone);
                acessoDadosSqlServer.AdicionarParametros("@PessoaAtivo", pessoa.PessoaAtivo);
                acessoDadosSqlServer.AdicionarParametros("@CidadeID", pessoa.Cidade.CidadeID);

                acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspAlterarPessoa");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public PessoaCollection ConsultaPorID(int PessoaID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@PessoaID", PessoaID);
                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarPessoa");

                PessoaCollection pessoaCollection = new PessoaCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Pessoa pessoa = new Pessoa();
                    pessoa.PessoaJuridica = new PessoaJuridica();
                    if (row["PessoaJuridicaCNPJ"] != DBNull.Value)
                    {
                        pessoa.PessoaJuridica.PessoaJuridicaCNPJ = row["PessoaJuridicaCNPJ"].ToString();
                        pessoa.PessoaJuridica.PessoaJuridicaRazaoSocial = row["PessoaJuridicaRazaoSocial"].ToString();
                        pessoa.PessoaJuridica.PessoaJuridicaNomeFicticio = row["PessoaJuridicaNomeFicticio"].ToString();
                    }
                    else
                    {
                        pessoa.PessoaJuridica.PessoaJuridicaCNPJ = "";
                        pessoa.PessoaJuridica.PessoaJuridicaRazaoSocial = "";
                        pessoa.PessoaJuridica.PessoaJuridicaNomeFicticio = "";

                    }

                    pessoa.PessoaFisica = new PessoaFisica();
                    if (row["PessoaFisicaCPF"] != DBNull.Value)
                    {
                        pessoa.PessoaFisica.PessoaFisicaCPF = row["PessoaFisicaCPF"].ToString();
                        pessoa.PessoaFisica.PessoaFisicaNome = row["PessoaFisicaNome"].ToString();
                    }
                    else
                    {
                        pessoa.PessoaFisica.PessoaFisicaCPF = "";
                        pessoa.PessoaFisica.PessoaFisicaNome = "";
                    }

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
