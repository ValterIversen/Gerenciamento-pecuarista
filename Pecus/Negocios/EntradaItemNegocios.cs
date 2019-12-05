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
    public class EntradaItemNegocios
    {
        //Instancio a classe de acesso ao banco de dados
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public int Cadastrar(EntradaItem entradaItem)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Inserir");
                acessoDadosSqlServer.AdicionarParametros("@EntradaItemID", 0);
                acessoDadosSqlServer.AdicionarParametros("@EntradaItemDescricao", entradaItem.EntradaItemDescricao);
                acessoDadosSqlServer.AdicionarParametros("@EntradaItemQuantidade", entradaItem.EntradaItemQuantidade);
                acessoDadosSqlServer.AdicionarParametros("@EntradaItemData", entradaItem.EntradaItemData);
                acessoDadosSqlServer.AdicionarParametros("@EstoqueID", entradaItem.Estoque.EstoqueID);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioID", entradaItem.Usuario.UsuarioID);

                return int.Parse(acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEntradaitem"));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(EntradaItem entradaItem)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Alterar");
                acessoDadosSqlServer.AdicionarParametros("@EntradaItemID", entradaItem.EntradaItemID);
                acessoDadosSqlServer.AdicionarParametros("@EntradaItemDescricao", entradaItem.EntradaItemDescricao);
                acessoDadosSqlServer.AdicionarParametros("@EntradaItemQuantidade", entradaItem.EntradaItemQuantidade);
                acessoDadosSqlServer.AdicionarParametros("@EntradaItemData", entradaItem.EntradaItemData);
                acessoDadosSqlServer.AdicionarParametros("@EstoqueID", entradaItem.Estoque.EstoqueID);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioID", entradaItem.Usuario.UsuarioID);

                acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEntradaitem");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void Excluir(int EntradaItemID)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Excluir");
                acessoDadosSqlServer.AdicionarParametros("@EntradaItemID", EntradaItemID);
                acessoDadosSqlServer.AdicionarParametros("@EntradaItemDescricao", "");
                acessoDadosSqlServer.AdicionarParametros("@EntradaItemQuantidade", 0);
                acessoDadosSqlServer.AdicionarParametros("@EntradaItemData", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@EstoqueID", 0);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioID", 0);

                acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEntradaitem");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public EntradaItem ConsultaPorID(int EntradaItemID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "ID");
                acessoDadosSqlServer.AdicionarParametros("@EntradaItemID", EntradaItemID);
                acessoDadosSqlServer.AdicionarParametros("@EntradaItemDescricao", "");
                acessoDadosSqlServer.AdicionarParametros("@EntradaItemData", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@EntradaItemData2", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@EstoqueID", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaEntradaItem");


                foreach (DataRow row in dataTable.Rows)
                {
                    EntradaItem entradaItem = new EntradaItem();
                    entradaItem.Usuario = new Usuario();
                    entradaItem.Estoque = new Estoque();
                    entradaItem.Usuario.TipoUsuario = new TipoUsuario();
                    entradaItem.Item = new Item();
                    entradaItem.Item.TipoItem = new TipoItem();

                    entradaItem.EntradaItemID = Convert.ToInt32(row["EntradaItemID"]);
                    entradaItem.EntradaItemDescricao = row["EntradaItemDescricao"].ToString();
                    entradaItem.EntradaItemQuantidade = Convert.ToDecimal(row["EntradaItemQuantidade"]);
                    entradaItem.EntradaItemData = Convert.ToDateTime(row["EntradaItemData"]);
                    entradaItem.Estoque.EstoqueID = Convert.ToInt32(row["EstoqueID"]);
                    entradaItem.Usuario.UsuarioID = Convert.ToInt32(row["UsuarioID"]);
                    entradaItem.Usuario.UsuarioNome = row["UsuarioNome"].ToString();
                    entradaItem.Usuario.TipoUsuario.TipoUsuarioDescricao = row["TipoUsuarioDescricao"].ToString();
                    entradaItem.Usuario.UsuarioAtivo = Convert.ToBoolean(row["UsuarioAtivo"]);
                    entradaItem.Item.ItemID = Convert.ToInt32(row["ItemID"]);
                    entradaItem.Item.ItemDescricao = row["ItemDescricao"].ToString();
                    entradaItem.Item.TipoItem.TipoItemDescricao = row["TipoItemDescricao"].ToString();

                    return entradaItem;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public EntradaItemCollection ConsultaPorDataEntre(DateTime Data1, DateTime Data2)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "DataEntre");
                acessoDadosSqlServer.AdicionarParametros("@EntradaItemID", 0);
                acessoDadosSqlServer.AdicionarParametros("@EntradaItemDescricao", "");
                acessoDadosSqlServer.AdicionarParametros("@EntradaItemData", Data1);
                acessoDadosSqlServer.AdicionarParametros("@EntradaItemData2", Data2);
                acessoDadosSqlServer.AdicionarParametros("@EstoqueID", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaEntradaItem");

                EntradaItemCollection entradaItemCollection = new EntradaItemCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    EntradaItem entradaItem = new EntradaItem();
                    entradaItem.Usuario = new Usuario();
                    entradaItem.Estoque = new Estoque();
                    entradaItem.Usuario.TipoUsuario = new TipoUsuario();
                    entradaItem.Item = new Item();
                    entradaItem.Item.TipoItem = new TipoItem();

                    entradaItem.EntradaItemID = Convert.ToInt32(row["EntradaItemID"]);
                    entradaItem.EntradaItemDescricao = row["EntradaItemDescricao"].ToString();
                    entradaItem.EntradaItemQuantidade = Convert.ToDecimal(row["EntradaItemQuantidade"]);
                    entradaItem.EntradaItemData = Convert.ToDateTime(row["EntradaItemData"]);
                    entradaItem.Estoque.EstoqueID = Convert.ToInt32(row["EstoqueID"]);
                    entradaItem.Usuario.UsuarioID = Convert.ToInt32(row["UsuarioID"]);
                    entradaItem.Usuario.UsuarioNome = row["UsuarioNome"].ToString();
                    entradaItem.Usuario.TipoUsuario.TipoUsuarioDescricao = row["TipoUsuarioDescricao"].ToString();
                    entradaItem.Usuario.UsuarioAtivo = Convert.ToBoolean(row["UsuarioAtivo"]);
                    entradaItem.Item.ItemDescricao = row["ItemDescricao"].ToString();
                    entradaItem.Item.TipoItem.TipoItemDescricao = row["TipoItemDescricao"].ToString();

                    entradaItemCollection.Add(entradaItem);
                }

                return entradaItemCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public EntradaItemCollection ConsultaPorDataApos(DateTime Data)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "DataApos");
                acessoDadosSqlServer.AdicionarParametros("@EntradaItemID", 0);
                acessoDadosSqlServer.AdicionarParametros("@EntradaItemDescricao", "");
                acessoDadosSqlServer.AdicionarParametros("@EntradaItemData", Data);
                acessoDadosSqlServer.AdicionarParametros("@EntradaItemData2", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@EstoqueID", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaEntradaItem");

                EntradaItemCollection entradaItemCollection = new EntradaItemCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    EntradaItem entradaItem = new EntradaItem();
                    entradaItem.Usuario = new Usuario();
                    entradaItem.Estoque = new Estoque();
                    entradaItem.Usuario.TipoUsuario = new TipoUsuario();
                    entradaItem.Item = new Item();
                    entradaItem.Item.TipoItem = new TipoItem();

                    entradaItem.EntradaItemID = Convert.ToInt32(row["EntradaItemID"]);
                    entradaItem.EntradaItemDescricao = row["EntradaItemDescricao"].ToString();
                    entradaItem.EntradaItemQuantidade = Convert.ToDecimal(row["EntradaItemQuantidade"]);
                    entradaItem.EntradaItemData = Convert.ToDateTime(row["EntradaItemData"]);
                    entradaItem.Estoque.EstoqueID = Convert.ToInt32(row["EstoqueID"]);
                    entradaItem.Usuario.UsuarioID = Convert.ToInt32(row["UsuarioID"]);
                    entradaItem.Usuario.UsuarioNome = row["UsuarioNome"].ToString();
                    entradaItem.Usuario.TipoUsuario.TipoUsuarioDescricao = row["TipoUsuarioDescricao"].ToString();
                    entradaItem.Usuario.UsuarioAtivo = Convert.ToBoolean(row["UsuarioAtivo"]);
                    entradaItem.Item.ItemDescricao = row["ItemDescricao"].ToString();
                    entradaItem.Item.TipoItem.TipoItemDescricao = row["TipoItemDescricao"].ToString();

                    entradaItemCollection.Add(entradaItem);
                }

                return entradaItemCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public EntradaItemCollection ConsultaPorDataAntes(DateTime Data)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "DataAntes");
                acessoDadosSqlServer.AdicionarParametros("@EntradaItemID", 0);
                acessoDadosSqlServer.AdicionarParametros("@EntradaItemDescricao", "");
                acessoDadosSqlServer.AdicionarParametros("@EntradaItemData", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@EntradaItemData2", Data);
                acessoDadosSqlServer.AdicionarParametros("@EstoqueID", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaEntradaItem");

                EntradaItemCollection entradaItemCollection = new EntradaItemCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    EntradaItem entradaItem = new EntradaItem();
                    entradaItem.Usuario = new Usuario();
                    entradaItem.Estoque = new Estoque();
                    entradaItem.Usuario.TipoUsuario = new TipoUsuario();
                    entradaItem.Item = new Item();
                    entradaItem.Item.TipoItem = new TipoItem();

                    entradaItem.EntradaItemID = Convert.ToInt32(row["EntradaItemID"]);
                    entradaItem.EntradaItemDescricao = row["EntradaItemDescricao"].ToString();
                    entradaItem.EntradaItemQuantidade = Convert.ToDecimal(row["EntradaItemQuantidade"]);
                    entradaItem.EntradaItemData = Convert.ToDateTime(row["EntradaItemData"]);
                    entradaItem.Estoque.EstoqueID = Convert.ToInt32(row["EstoqueID"]);
                    entradaItem.Usuario.UsuarioID = Convert.ToInt32(row["UsuarioID"]);
                    entradaItem.Usuario.UsuarioNome = row["UsuarioNome"].ToString();
                    entradaItem.Usuario.TipoUsuario.TipoUsuarioDescricao = row["TipoUsuarioDescricao"].ToString();
                    entradaItem.Usuario.UsuarioAtivo = Convert.ToBoolean(row["UsuarioAtivo"]);
                    entradaItem.Item.ItemDescricao = row["ItemDescricao"].ToString();
                    entradaItem.Item.TipoItem.TipoItemDescricao = row["TipoItemDescricao"].ToString();

                    entradaItemCollection.Add(entradaItem);
                }

                return entradaItemCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public EntradaItemCollection ConsultaPorEstoque(int EstoqueID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Estoque");
                acessoDadosSqlServer.AdicionarParametros("@EntradaItemID", 0);
                acessoDadosSqlServer.AdicionarParametros("@EntradaItemDescricao", "");
                acessoDadosSqlServer.AdicionarParametros("@EntradaItemData", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@EntradaItemData2", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@EstoqueID", EstoqueID);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaEntradaItem");

                EntradaItemCollection entradaItemCollection = new EntradaItemCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    EntradaItem entradaItem = new EntradaItem();
                    entradaItem.Usuario = new Usuario();
                    entradaItem.Estoque = new Estoque();
                    entradaItem.Usuario.TipoUsuario = new TipoUsuario();
                    entradaItem.Item = new Item();
                    entradaItem.Item.TipoItem = new TipoItem();

                    entradaItem.EntradaItemID = Convert.ToInt32(row["EntradaItemID"]);
                    entradaItem.EntradaItemDescricao = row["EntradaItemDescricao"].ToString();
                    entradaItem.EntradaItemQuantidade = Convert.ToDecimal(row["EntradaItemQuantidade"]);
                    entradaItem.EntradaItemData = Convert.ToDateTime(row["EntradaItemData"]);
                    entradaItem.Estoque.EstoqueID = Convert.ToInt32(row["EstoqueID"]);
                    entradaItem.Usuario.UsuarioID = Convert.ToInt32(row["UsuarioID"]);
                    entradaItem.Usuario.UsuarioNome = row["UsuarioNome"].ToString();
                    entradaItem.Usuario.TipoUsuario.TipoUsuarioDescricao = row["TipoUsuarioDescricao"].ToString();
                    entradaItem.Usuario.UsuarioAtivo = Convert.ToBoolean(row["UsuarioAtivo"]);
                    entradaItem.Item.ItemDescricao = row["ItemDescricao"].ToString();
                    entradaItem.Item.TipoItem.TipoItemDescricao = row["TipoItemDescricao"].ToString();

                    entradaItemCollection.Add(entradaItem);
                }

                return entradaItemCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public EntradaItemCollection ConsultaPorDescricao(string Descricao)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Descricao");
                acessoDadosSqlServer.AdicionarParametros("@EntradaItemID", 0);
                acessoDadosSqlServer.AdicionarParametros("@EntradaItemDescricao", Descricao);
                acessoDadosSqlServer.AdicionarParametros("@EntradaItemData", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@EntradaItemData2", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@EstoqueID", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaEntradaItem");

                EntradaItemCollection entradaItemCollection = new EntradaItemCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    EntradaItem entradaItem = new EntradaItem();
                    entradaItem.Usuario = new Usuario();
                    entradaItem.Estoque = new Estoque();
                    entradaItem.Usuario.TipoUsuario = new TipoUsuario();
                    entradaItem.Item = new Item();
                    entradaItem.Item.TipoItem = new TipoItem();

                    entradaItem.EntradaItemID = Convert.ToInt32(row["EntradaItemID"]);
                    entradaItem.EntradaItemDescricao = row["EntradaItemDescricao"].ToString();
                    entradaItem.EntradaItemQuantidade = Convert.ToDecimal(row["EntradaItemQuantidade"]);
                    entradaItem.EntradaItemData = Convert.ToDateTime(row["EntradaItemData"]);
                    entradaItem.Estoque.EstoqueID = Convert.ToInt32(row["EstoqueID"]);
                    entradaItem.Usuario.UsuarioID = Convert.ToInt32(row["UsuarioID"]);
                    entradaItem.Usuario.UsuarioNome = row["UsuarioNome"].ToString();
                    entradaItem.Usuario.TipoUsuario.TipoUsuarioDescricao = row["TipoUsuarioDescricao"].ToString();
                    entradaItem.Usuario.UsuarioAtivo = Convert.ToBoolean(row["UsuarioAtivo"]);
                    entradaItem.Item.ItemDescricao = row["ItemDescricao"].ToString();
                    entradaItem.Item.TipoItem.TipoItemDescricao = row["TipoItemDescricao"].ToString();

                    entradaItemCollection.Add(entradaItem);
                }

                return entradaItemCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
