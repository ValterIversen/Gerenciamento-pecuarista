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
    public class RetiradaItemNegocios
    {
        //Instancio a classe de acesso ao banco de dados
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public int Cadastrar(RetiradaItem retiradaItem)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Inserir");
                acessoDadosSqlServer.AdicionarParametros("@RetiradaItemID", 0);
                acessoDadosSqlServer.AdicionarParametros("@RetiradaItemDescricao", retiradaItem.RetiradaItemDescricao);
                acessoDadosSqlServer.AdicionarParametros("@RetiradaItemQuantidade", retiradaItem.RetiradaItemQuantidade);
                acessoDadosSqlServer.AdicionarParametros("@RetiradaItemData", retiradaItem.RetiradaItemData);
                acessoDadosSqlServer.AdicionarParametros("@EstoqueID", retiradaItem.Estoque.EstoqueID);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioID", retiradaItem.Usuario.UsuarioID);

                return int.Parse(acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterRetiradaitem"));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(RetiradaItem retiradaItem)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Alterar");
                acessoDadosSqlServer.AdicionarParametros("@RetiradaItemID", retiradaItem.RetiradaItemID);
                acessoDadosSqlServer.AdicionarParametros("@RetiradaItemDescricao", retiradaItem.RetiradaItemDescricao);
                acessoDadosSqlServer.AdicionarParametros("@RetiradaItemQuantidade", retiradaItem.RetiradaItemQuantidade);
                acessoDadosSqlServer.AdicionarParametros("@RetiradaItemData", retiradaItem.RetiradaItemData);
                acessoDadosSqlServer.AdicionarParametros("@EstoqueID", retiradaItem.Estoque.EstoqueID);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioID", retiradaItem.Usuario.UsuarioID);

                acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterRetiradaitem");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void Excluir(int RetiradaItemID)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Excluir");
                acessoDadosSqlServer.AdicionarParametros("@RetiradaItemID", RetiradaItemID);
                acessoDadosSqlServer.AdicionarParametros("@RetiradaItemDescricao", "");
                acessoDadosSqlServer.AdicionarParametros("@RetiradaItemQuantidade", 0);
                acessoDadosSqlServer.AdicionarParametros("@RetiradaItemData", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@EstoqueID", 0);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioID", 0);

                acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterRetiradaitem");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public RetiradaItem ConsultaPorID(int RetiradaItemID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "ID");
                acessoDadosSqlServer.AdicionarParametros("@RetiradaItemID", RetiradaItemID);
                acessoDadosSqlServer.AdicionarParametros("@RetiradaItemDescricao", "");
                acessoDadosSqlServer.AdicionarParametros("@RetiradaItemData", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@RetiradaItemData2", DateTime.Now);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaRetiradaItem");


                foreach (DataRow row in dataTable.Rows)
                {
                    RetiradaItem retiradaItem = new RetiradaItem();
                    retiradaItem.Usuario = new Usuario();
                    retiradaItem.Estoque = new Estoque();
                    retiradaItem.Usuario.TipoUsuario = new TipoUsuario();
                    retiradaItem.Item = new Item();
                    retiradaItem.Item.TipoItem = new TipoItem();

                    retiradaItem.RetiradaItemID = Convert.ToInt32(row["RetiradaItemID"]);
                    retiradaItem.RetiradaItemDescricao = row["RetiradaItemDescricao"].ToString();
                    retiradaItem.RetiradaItemQuantidade = Convert.ToDecimal(row["RetiradaItemQuantidade"]);
                    retiradaItem.RetiradaItemData = Convert.ToDateTime(row["RetiradaItemData"]);
                    retiradaItem.Estoque.EstoqueID = Convert.ToInt32(row["EstoqueID"]);
                    retiradaItem.Usuario.UsuarioID = Convert.ToInt32(row["UsuarioID"]);
                    retiradaItem.Usuario.UsuarioNome = row["UsuarioNome"].ToString();
                    retiradaItem.Usuario.TipoUsuario.TipoUsuarioDescricao = row["TipoUsuarioDescricao"].ToString();
                    retiradaItem.Usuario.UsuarioAtivo = Convert.ToBoolean(row["UsuarioAtivo"]);
                    retiradaItem.Item.ItemID = Convert.ToInt32(row["ItemID"]);
                    retiradaItem.Item.ItemDescricao = row["ItemDescricao"].ToString();
                    retiradaItem.Item.TipoItem.TipoItemDescricao = row["TipoItemDescricao"].ToString();

                    return retiradaItem;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public RetiradaItemCollection ConsultaPorDataEntre(DateTime Data1, DateTime Data2)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "DataEntre");
                acessoDadosSqlServer.AdicionarParametros("@RetiradaItemID", 0);
                acessoDadosSqlServer.AdicionarParametros("@RetiradaItemDescricao", "");
                acessoDadosSqlServer.AdicionarParametros("@RetiradaItemData", Data1);
                acessoDadosSqlServer.AdicionarParametros("@RetiradaItemData2", Data2);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaRetiradaItem");

                RetiradaItemCollection retiradaItemCollection = new RetiradaItemCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    RetiradaItem retiradaItem = new RetiradaItem();
                    retiradaItem.Usuario = new Usuario();
                    retiradaItem.Estoque = new Estoque();
                    retiradaItem.Usuario.TipoUsuario = new TipoUsuario();
                    retiradaItem.Item = new Item();
                    retiradaItem.Item.TipoItem = new TipoItem();

                    retiradaItem.RetiradaItemID = Convert.ToInt32(row["RetiradaItemID"]);
                    retiradaItem.RetiradaItemDescricao = row["RetiradaItemDescricao"].ToString();
                    retiradaItem.RetiradaItemQuantidade = Convert.ToDecimal(row["RetiradaItemQuantidade"]);
                    retiradaItem.RetiradaItemData = Convert.ToDateTime(row["RetiradaItemData"]);
                    retiradaItem.Estoque.EstoqueID = Convert.ToInt32(row["EstoqueID"]);
                    retiradaItem.Usuario.UsuarioID = Convert.ToInt32(row["UsuarioID"]);
                    retiradaItem.Usuario.UsuarioNome = row["UsuarioNome"].ToString();
                    retiradaItem.Usuario.TipoUsuario.TipoUsuarioDescricao = row["TipoUsuarioDescricao"].ToString();
                    retiradaItem.Usuario.UsuarioAtivo = Convert.ToBoolean(row["UsuarioAtivo"]);
                    retiradaItem.Item.ItemDescricao = row["ItemDescricao"].ToString();
                    retiradaItem.Item.TipoItem.TipoItemDescricao = row["TipoItemDescricao"].ToString();

                    retiradaItemCollection.Add(retiradaItem);
                }

                return retiradaItemCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public RetiradaItemCollection ConsultaPorDataApos(DateTime Data)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "DataApos");
                acessoDadosSqlServer.AdicionarParametros("@RetiradaItemID", 0);
                acessoDadosSqlServer.AdicionarParametros("@RetiradaItemDescricao", "");
                acessoDadosSqlServer.AdicionarParametros("@RetiradaItemData", Data);
                acessoDadosSqlServer.AdicionarParametros("@RetiradaItemData2", DateTime.Now);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaRetiradaItem");

                RetiradaItemCollection retiradaItemCollection = new RetiradaItemCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    RetiradaItem retiradaItem = new RetiradaItem();
                    retiradaItem.Usuario = new Usuario();
                    retiradaItem.Estoque = new Estoque();
                    retiradaItem.Usuario.TipoUsuario = new TipoUsuario();
                    retiradaItem.Item = new Item();
                    retiradaItem.Item.TipoItem = new TipoItem();

                    retiradaItem.RetiradaItemID = Convert.ToInt32(row["RetiradaItemID"]);
                    retiradaItem.RetiradaItemDescricao = row["RetiradaItemDescricao"].ToString();
                    retiradaItem.RetiradaItemQuantidade = Convert.ToDecimal(row["RetiradaItemQuantidade"]);
                    retiradaItem.RetiradaItemData = Convert.ToDateTime(row["RetiradaItemData"]);
                    retiradaItem.Estoque.EstoqueID = Convert.ToInt32(row["EstoqueID"]);
                    retiradaItem.Usuario.UsuarioID = Convert.ToInt32(row["UsuarioID"]);
                    retiradaItem.Usuario.UsuarioNome = row["UsuarioNome"].ToString();
                    retiradaItem.Usuario.TipoUsuario.TipoUsuarioDescricao = row["TipoUsuarioDescricao"].ToString();
                    retiradaItem.Usuario.UsuarioAtivo = Convert.ToBoolean(row["UsuarioAtivo"]);
                    retiradaItem.Item.ItemDescricao = row["ItemDescricao"].ToString();
                    retiradaItem.Item.TipoItem.TipoItemDescricao = row["TipoItemDescricao"].ToString();

                    retiradaItemCollection.Add(retiradaItem);
                }

                return retiradaItemCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public RetiradaItemCollection ConsultaPorDataAntes(DateTime Data)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "DataAntes");
                acessoDadosSqlServer.AdicionarParametros("@RetiradaItemID", 0);
                acessoDadosSqlServer.AdicionarParametros("@RetiradaItemDescricao", "");
                acessoDadosSqlServer.AdicionarParametros("@RetiradaItemData", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@RetiradaItemData2", Data);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaRetiradaItem");

                RetiradaItemCollection retiradaItemCollection = new RetiradaItemCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    RetiradaItem retiradaItem = new RetiradaItem();
                    retiradaItem.Usuario = new Usuario();
                    retiradaItem.Estoque = new Estoque();
                    retiradaItem.Usuario.TipoUsuario = new TipoUsuario();
                    retiradaItem.Item = new Item();
                    retiradaItem.Item.TipoItem = new TipoItem();

                    retiradaItem.RetiradaItemID = Convert.ToInt32(row["RetiradaItemID"]);
                    retiradaItem.RetiradaItemDescricao = row["RetiradaItemDescricao"].ToString();
                    retiradaItem.RetiradaItemQuantidade = Convert.ToDecimal(row["RetiradaItemQuantidade"]);
                    retiradaItem.RetiradaItemData = Convert.ToDateTime(row["RetiradaItemData"]);
                    retiradaItem.Estoque.EstoqueID = Convert.ToInt32(row["EstoqueID"]);
                    retiradaItem.Usuario.UsuarioID = Convert.ToInt32(row["UsuarioID"]);
                    retiradaItem.Usuario.UsuarioNome = row["UsuarioNome"].ToString();
                    retiradaItem.Usuario.TipoUsuario.TipoUsuarioDescricao = row["TipoUsuarioDescricao"].ToString();
                    retiradaItem.Usuario.UsuarioAtivo = Convert.ToBoolean(row["UsuarioAtivo"]);
                    retiradaItem.Item.ItemDescricao = row["ItemDescricao"].ToString();
                    retiradaItem.Item.TipoItem.TipoItemDescricao = row["TipoItemDescricao"].ToString();

                    retiradaItemCollection.Add(retiradaItem);
                }

                return retiradaItemCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public RetiradaItemCollection ConsultaPorDescricao(string Descricao)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Descricao");
                acessoDadosSqlServer.AdicionarParametros("@RetiradaItemID", 0);
                acessoDadosSqlServer.AdicionarParametros("@RetiradaItemDescricao", Descricao);
                acessoDadosSqlServer.AdicionarParametros("@RetiradaItemData", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@RetiradaItemData2", DateTime.Now);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaRetiradaItem");

                RetiradaItemCollection retiradaItemCollection = new RetiradaItemCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    RetiradaItem retiradaItem = new RetiradaItem();
                    retiradaItem.Usuario = new Usuario();
                    retiradaItem.Estoque = new Estoque();
                    retiradaItem.Usuario.TipoUsuario = new TipoUsuario();
                    retiradaItem.Item = new Item();
                    retiradaItem.Item.TipoItem = new TipoItem();

                    retiradaItem.RetiradaItemID = Convert.ToInt32(row["RetiradaItemID"]);
                    retiradaItem.RetiradaItemDescricao = row["RetiradaItemDescricao"].ToString();
                    retiradaItem.RetiradaItemQuantidade = Convert.ToDecimal(row["RetiradaItemQuantidade"]);
                    retiradaItem.RetiradaItemData = Convert.ToDateTime(row["RetiradaItemData"]);
                    retiradaItem.Estoque.EstoqueID = Convert.ToInt32(row["EstoqueID"]);
                    retiradaItem.Usuario.UsuarioID = Convert.ToInt32(row["UsuarioID"]);
                    retiradaItem.Usuario.UsuarioNome = row["UsuarioNome"].ToString();
                    retiradaItem.Usuario.TipoUsuario.TipoUsuarioDescricao = row["TipoUsuarioDescricao"].ToString();
                    retiradaItem.Usuario.UsuarioAtivo = Convert.ToBoolean(row["UsuarioAtivo"]);
                    retiradaItem.Item.ItemDescricao = row["ItemDescricao"].ToString();
                    retiradaItem.Item.TipoItem.TipoItemDescricao = row["TipoItemDescricao"].ToString();

                    retiradaItemCollection.Add(retiradaItem);
                }

                return retiradaItemCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
