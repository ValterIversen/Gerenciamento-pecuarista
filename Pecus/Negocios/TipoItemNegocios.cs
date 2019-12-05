using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ObjetoTransferencia;
using AcessoBancoDados;
using System.Data;

namespace Negocios
{
    public class TipoItemNegocios
    {
        //Instancio a classe de acesso ao banco de dados
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public int Cadastrar(TipoItem tipoItem)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Inserir");
                acessoDadosSqlServer.AdicionarParametros("@TipoItemID", 0);
                acessoDadosSqlServer.AdicionarParametros("@TipoItemDescricao", tipoItem.TipoItemDescricao);

                return int.Parse(acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterTipoItem"));

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(TipoItem tipoItem)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Alterar");
                acessoDadosSqlServer.AdicionarParametros("@TipoItemID", tipoItem.TipoItemID);
                acessoDadosSqlServer.AdicionarParametros("@TipoItemDescricao", tipoItem.TipoItemDescricao);

                acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterTipoItem");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public TipoItemCollection ConsultaPorID(int ID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "ID");
                acessoDadosSqlServer.AdicionarParametros("@TipoItemID", ID);
                acessoDadosSqlServer.AdicionarParametros("@TipoItemDescricao", "");

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaTipoItem");

                TipoItemCollection tipoItemCollection = new TipoItemCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    TipoItem tipoItem = new TipoItem();
                    tipoItem.TipoItemID = Convert.ToInt32(row["TipoItemID"]);
                    tipoItem.TipoItemDescricao = row["TipoItemDescricao"].ToString();

                    tipoItemCollection.Add(tipoItem);
                }

                return tipoItemCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public TipoItemCollection ConsultaPorDescricao(string Descricao)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Descricao");
                acessoDadosSqlServer.AdicionarParametros("@TipoItemID", "");
                acessoDadosSqlServer.AdicionarParametros("@TipoItemDescricao", Descricao);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaTipoItem");

                TipoItemCollection tipoItemCollection = new TipoItemCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    TipoItem tipoItem = new TipoItem();
                    tipoItem.TipoItemID = Convert.ToInt32(row["TipoItemID"]);
                    tipoItem.TipoItemDescricao = row["TipoItemDescricao"].ToString();

                    tipoItemCollection.Add(tipoItem);
                }

                return tipoItemCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public TipoItemCollection ConsultaTodos()
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Descricao");
                acessoDadosSqlServer.AdicionarParametros("@TipoItemID", "");
                acessoDadosSqlServer.AdicionarParametros("@TipoItemDescricao", "");

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaTipoItem");

                TipoItemCollection tipoItemCollection = new TipoItemCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    TipoItem tipoItem = new TipoItem();
                    tipoItem.TipoItemID = Convert.ToInt32(row["TipoItemID"]);
                    tipoItem.TipoItemDescricao = row["TipoItemDescricao"].ToString();

                    tipoItemCollection.Add(tipoItem);
                }

                return tipoItemCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
