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
    public class RacaNegocios
    {
        //Instancio a classe de acesso ao banco de dados
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public int Cadastrar(Raca raca)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Inserir");
                acessoDadosSqlServer.AdicionarParametros("@RacaID", 0);
                acessoDadosSqlServer.AdicionarParametros("@RacaNome", raca.RacaNome);
                acessoDadosSqlServer.AdicionarParametros("@RacaDescricao", raca.RacaDescricao);

                return int.Parse(acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterRaca"));

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(Raca raca)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Alterar");
                acessoDadosSqlServer.AdicionarParametros("@RacaID", raca.RacaID);
                acessoDadosSqlServer.AdicionarParametros("@RacaNome", raca.RacaNome);
                acessoDadosSqlServer.AdicionarParametros("@RacaDescricao", raca.RacaDescricao);

                acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterRaca");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public RacaCollection ConsultaPorNome(string Nome)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Nome");
                acessoDadosSqlServer.AdicionarParametros("@RacaID", 0);
                acessoDadosSqlServer.AdicionarParametros("@RacaNome", Nome);
                acessoDadosSqlServer.AdicionarParametros("@RacaDescricao", "");

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaRaca");

                RacaCollection racaCollection = new RacaCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Raca raca = new Raca();
                    raca.RacaID = Convert.ToInt32(row["RacaID"]);
                    raca.RacaNome = row["RacaNome"].ToString();
                    raca.RacaDescricao = row["RacaDescricao"].ToString();

                    racaCollection.Add(raca);
                }

                return racaCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public RacaCollection ValidExist(int RacaID, string Nome)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Valid");
                acessoDadosSqlServer.AdicionarParametros("@RacaID", RacaID);
                acessoDadosSqlServer.AdicionarParametros("@RacaNome", Nome);
                acessoDadosSqlServer.AdicionarParametros("@RacaDescricao", "");

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaRaca");

                RacaCollection racaCollection = new RacaCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Raca raca = new Raca();
                    raca.RacaID = Convert.ToInt32(row["RacaID"]);
                    raca.RacaNome = row["RacaNome"].ToString();
                    raca.RacaDescricao = row["RacaDescricao"].ToString();

                    racaCollection.Add(raca);
                }

                return racaCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public RacaCollection ConsultaPorDescricao(string Descricao)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Descricao");
                acessoDadosSqlServer.AdicionarParametros("@RacaID", 0);
                acessoDadosSqlServer.AdicionarParametros("@RacaNome", "");
                acessoDadosSqlServer.AdicionarParametros("@RacaDescricao", Descricao);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaRaca");

                RacaCollection racaCollection = new RacaCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Raca raca = new Raca();
                    raca.RacaID = Convert.ToInt32(row["RacaID"]);
                    raca.RacaNome = row["RacaNome"].ToString();
                    raca.RacaDescricao = row["RacaDescricao"].ToString();

                    racaCollection.Add(raca);
                }

                return racaCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
