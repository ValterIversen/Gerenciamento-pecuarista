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
    public class ItemNegocios
    {
        //Instancio a classe de acesso ao banco de dados
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public int Cadastrar(Item item)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Inserir");
                acessoDadosSqlServer.AdicionarParametros("@ItemID", 0);
                acessoDadosSqlServer.AdicionarParametros("@ItemDescricao", item.ItemDescricao);
                acessoDadosSqlServer.AdicionarParametros("@TipoItemID", item.TipoItem.TipoItemID);

                return int.Parse(acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterItem"));

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(Item item)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Alterar");
                acessoDadosSqlServer.AdicionarParametros("@ItemID", item.ItemID);
                acessoDadosSqlServer.AdicionarParametros("@ItemDescricao", item.ItemDescricao);
                acessoDadosSqlServer.AdicionarParametros("@TipoItemID", item.TipoItem.TipoItemID);

                acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterItem");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ItemCollection ValidarExist(int ID, string Descricao)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Valid");
                acessoDadosSqlServer.AdicionarParametros("@ItemID", ID);
                acessoDadosSqlServer.AdicionarParametros("@ItemDescricao", Descricao);
                acessoDadosSqlServer.AdicionarParametros("@TipoItemID", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaItem");

                ItemCollection itemCollection = new ItemCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Item item = new Item();
                    item.TipoItem = new TipoItem();
                    item.ItemID = Convert.ToInt32(row["ItemID"]);
                    item.ItemDescricao = row["ItemDescricao"].ToString();
                    item.TipoItem.TipoItemID = Convert.ToInt32(row["TipoItemID"]);
                    item.TipoItem.TipoItemDescricao = row["TipoItemDescricao"].ToString();

                    itemCollection.Add(item);
                }

                return itemCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ItemCollection ConsultaPorID(int ID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "ID");
                acessoDadosSqlServer.AdicionarParametros("@ItemID", ID);
                acessoDadosSqlServer.AdicionarParametros("@ItemDescricao", "");
                acessoDadosSqlServer.AdicionarParametros("@TipoItemID", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaItem");

                ItemCollection itemCollection = new ItemCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Item item = new Item();
                    item.TipoItem = new TipoItem();
                    item.ItemID = Convert.ToInt32(row["ItemID"]);
                    item.ItemDescricao = row["ItemDescricao"].ToString();
                    item.TipoItem.TipoItemID = Convert.ToInt32(row["TipoItemID"]);
                    item.TipoItem.TipoItemDescricao = row["TipoItemDescricao"].ToString();

                    itemCollection.Add(item);
                }

                return itemCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ItemCollection ConsultaPorDescricao(string Descricao)
        {
            try
            {   
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Descricao");
                acessoDadosSqlServer.AdicionarParametros("@ItemID", 0);
                acessoDadosSqlServer.AdicionarParametros("@ItemDescricao", Descricao);
                acessoDadosSqlServer.AdicionarParametros("@TipoItemID", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaItem");

                ItemCollection itemCollection = new ItemCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Item item = new Item();
                    item.TipoItem = new TipoItem();
                    item.ItemID = Convert.ToInt32(row["ItemID"]);
                    item.ItemDescricao = row["ItemDescricao"].ToString();
                    item.TipoItem.TipoItemID = Convert.ToInt32(row["TipoItemID"]);
                    item.TipoItem.TipoItemDescricao = row["TipoItemDescricao"].ToString();

                    itemCollection.Add(item);
                }

                return itemCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ItemCollection ConsultaPorTipoItem(int TipoItemID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "TipoItem");
                acessoDadosSqlServer.AdicionarParametros("@ItemID", 0);
                acessoDadosSqlServer.AdicionarParametros("@ItemDescricao", "");
                acessoDadosSqlServer.AdicionarParametros("@TipoItemID", TipoItemID);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaItem");

                ItemCollection itemCollection = new ItemCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Item item = new Item();
                    item.TipoItem = new TipoItem();
                    item.ItemID = Convert.ToInt32(row["ItemID"]);
                    item.ItemDescricao = row["ItemDescricao"].ToString();
                    item.TipoItem.TipoItemID = Convert.ToInt32(row["TipoItemID"]);
                    item.TipoItem.TipoItemDescricao = row["TipoItemDescricao"].ToString();

                    itemCollection.Add(item);
                }

                return itemCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
