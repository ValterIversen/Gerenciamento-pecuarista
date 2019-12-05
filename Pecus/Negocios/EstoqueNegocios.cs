using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AcessoBancoDados;
using ObjetoTransferencia;
using Negocios;

namespace Negocios
{
    public class EstoqueNegocios
    {
        //Instancio a classe de acesso ao banco de dados
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
        public int Cadastrar(Estoque estoque, int UsuarioID)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Inserir");
                acessoDadosSqlServer.AdicionarParametros("@EstoqueID", 0);
                acessoDadosSqlServer.AdicionarParametros("@EstoqueQuantidade", estoque.EstoqueQuantidade);
                acessoDadosSqlServer.AdicionarParametros("@EstoqueLocalidadeID", estoque.EstoqueLocalidade.EstoqueLocalidadeID);
                acessoDadosSqlServer.AdicionarParametros("@EstoqueAtivo", 1);
                acessoDadosSqlServer.AdicionarParametros("@ItemID", estoque.Item.ItemID);

                estoque.EstoqueID = int.Parse(acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEstoque"));

                //Como há a opção da pessoa definir uma quantidade inicial com a criação.
                //É armazenado na tabela de entrada a quantidade inicial.
                EntradaItemNegocios entradaItemNegocios = new EntradaItemNegocios();
                EntradaItem entradaItem = new EntradaItem();
                entradaItem.EntradaItemDescricao = "Criação do estoque. Quantidade inicial.";
                entradaItem.EntradaItemQuantidade = estoque.EstoqueQuantidade;
                entradaItem.EntradaItemData = DateTime.Now;
                entradaItem.Estoque = new Estoque();
                entradaItem.Estoque.EstoqueID = estoque.EstoqueID;
                entradaItem.Usuario = new Usuario();
                entradaItem.Usuario.UsuarioID = UsuarioID;
                entradaItemNegocios.Cadastrar(entradaItem);

                return estoque.EstoqueID;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(Estoque estoque)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();


                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Alterar");
                acessoDadosSqlServer.AdicionarParametros("@EstoqueID", estoque.EstoqueID);
                acessoDadosSqlServer.AdicionarParametros("@EstoqueQuantidade", estoque.EstoqueQuantidade);
                acessoDadosSqlServer.AdicionarParametros("@EstoqueLocalidadeID", estoque.EstoqueLocalidade.EstoqueLocalidadeID);
                acessoDadosSqlServer.AdicionarParametros("@EstoqueAtivo", estoque.EstoqueAtivo);
                acessoDadosSqlServer.AdicionarParametros("@ItemID", estoque.Item.ItemID);

                acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEstoque");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public EstoqueCollection ConsultaPorEstoqueLocalidade(int EstoqueLocalidadeID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "EstoqueL");
                acessoDadosSqlServer.AdicionarParametros("@EstoqueLocalidadeID", EstoqueLocalidadeID);
                acessoDadosSqlServer.AdicionarParametros("@EstoqueID", 0);
                acessoDadosSqlServer.AdicionarParametros("@ItemID", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaEstoque");

                EstoqueCollection estoqueCollection = new EstoqueCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Estoque estoque = new Estoque();
                    estoque.EstoqueLocalidade = new EstoqueLocalidade();
                    estoque.Item = new Item();
                    estoque.Item.TipoItem = new TipoItem();
                    estoque.EstoqueID = Convert.ToInt32(row["EstoqueID"]);
                    estoque.EstoqueQuantidade = Convert.ToDecimal(row["EstoqueQuantidade"].ToString());
                    estoque.EstoqueAtivo = Convert.ToBoolean(row["EstoqueAtivo"]);
                    estoque.EstoqueLocalidade = new EstoqueLocalidade();
                    estoque.EstoqueLocalidade.EstoqueLocalidadeID = Convert.ToInt32(row["EstoqueLocalidadeID"]);
                    estoque.EstoqueLocalidade.EstoqueLocalidadeDescricao = row["EstoqueLocalidadeDescricao"].ToString();
                    estoque.EstoqueLocalidade.EstoqueLocalidadeEndereco = row["EstoqueLocalidadeEndereco"].ToString();
                    estoque.EstoqueLocalidade.Cidade = new Cidade();
                    estoque.EstoqueLocalidade.Cidade.CidadeID = Convert.ToInt32(row["CidadeID"]);
                    estoque.EstoqueLocalidade.Cidade.CidadeNome = row["CidadeNome"].ToString();
                    estoque.EstoqueLocalidade.Cidade.EstadoID = Convert.ToInt32(row["EstadoID"]);
                    estoque.EstoqueLocalidade.Cidade.EstadoNome = row["EstadoNome"].ToString();
                    estoque.Item.ItemID = Convert.ToInt32(row["ItemID"]);
                    estoque.Item.ItemDescricao = row["ItemDescricao"].ToString();
                    estoque.Item.TipoItem.TipoItemID = Convert.ToInt32(row["TipoItemID"]);
                    estoque.Item.TipoItem.TipoItemDescricao = row["TipoItemDescricao"].ToString();

                    estoqueCollection.Add(estoque);
                }

                return estoqueCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public EstoqueCollection ConsultaPorItem(int ItemID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Item");
                acessoDadosSqlServer.AdicionarParametros("@EstoqueLocalidadeID", 0);
                acessoDadosSqlServer.AdicionarParametros("@EstoqueID", 0);
                acessoDadosSqlServer.AdicionarParametros("@ItemID", ItemID);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaEstoque");

                EstoqueCollection estoqueCollection = new EstoqueCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Estoque estoque = new Estoque();
                    estoque.EstoqueLocalidade = new EstoqueLocalidade();
                    estoque.Item = new Item();
                    estoque.Item.TipoItem = new TipoItem();
                    estoque.EstoqueID = Convert.ToInt32(row["EstoqueID"]);
                    estoque.EstoqueQuantidade = Convert.ToDecimal(row["EstoqueQuantidade"].ToString());
                    estoque.EstoqueAtivo = Convert.ToBoolean(row["EstoqueAtivo"]);
                    estoque.EstoqueLocalidade.EstoqueLocalidadeID = Convert.ToInt32(row["EstoqueLocalidadeID"]);
                    estoque.EstoqueLocalidade.EstoqueLocalidadeDescricao = row["EstoqueLocalidadeDescricao"].ToString();
                    estoque.EstoqueLocalidade.EstoqueLocalidadeEndereco = row["EstoqueLocalidadeEndereco"].ToString();
                    estoque.EstoqueLocalidade.Cidade = new Cidade();
                    estoque.EstoqueLocalidade.Cidade.CidadeID = Convert.ToInt32(row["CidadeID"]);
                    estoque.EstoqueLocalidade.Cidade.CidadeNome = row["CidadeNome"].ToString();
                    estoque.EstoqueLocalidade.Cidade.EstadoID = Convert.ToInt32(row["EstadoID"]);
                    estoque.EstoqueLocalidade.Cidade.EstadoNome = row["EstadoNome"].ToString();
                    estoque.Item.ItemID = Convert.ToInt32(row["ItemID"]);
                    estoque.Item.ItemDescricao = row["ItemDescricao"].ToString();
                    estoque.Item.TipoItem.TipoItemID = Convert.ToInt32(row["TipoItemID"]);
                    estoque.Item.TipoItem.TipoItemDescricao = row["TipoItemDescricao"].ToString();

                    estoqueCollection.Add(estoque);
                }

                return estoqueCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Estoque ConsultaPorID(int EstoqueID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "ID");
                acessoDadosSqlServer.AdicionarParametros("@EstoqueLocalidadeID", 0);
                acessoDadosSqlServer.AdicionarParametros("@EstoqueID", EstoqueID);
                acessoDadosSqlServer.AdicionarParametros("@ItemID", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaEstoque");

                foreach (DataRow row in dataTable.Rows)
                {
                    Estoque estoque = new Estoque();
                    estoque.EstoqueLocalidade = new EstoqueLocalidade();
                    estoque.Item = new Item();
                    estoque.Item.TipoItem = new TipoItem();
                    estoque.EstoqueID = Convert.ToInt32(row["EstoqueID"]);
                    estoque.EstoqueQuantidade = Convert.ToDecimal(row["EstoqueQuantidade"].ToString());
                    estoque.EstoqueAtivo = Convert.ToBoolean(row["EstoqueAtivo"]);
                    estoque.EstoqueLocalidade.EstoqueLocalidadeID = Convert.ToInt32(row["EstoqueLocalidadeID"]);
                    estoque.EstoqueLocalidade.EstoqueLocalidadeDescricao = row["EstoqueLocalidadeDescricao"].ToString();
                    estoque.EstoqueLocalidade.EstoqueLocalidadeEndereco = row["EstoqueLocalidadeEndereco"].ToString();
                    estoque.EstoqueLocalidade.Cidade = new Cidade();
                    estoque.EstoqueLocalidade.Cidade.CidadeID = Convert.ToInt32(row["CidadeID"]);
                    estoque.EstoqueLocalidade.Cidade.CidadeNome = row["CidadeNome"].ToString();
                    estoque.EstoqueLocalidade.Cidade.EstadoID = Convert.ToInt32(row["EstadoID"]);
                    estoque.EstoqueLocalidade.Cidade.EstadoNome = row["EstadoNome"].ToString();
                    estoque.Item.ItemID = Convert.ToInt32(row["ItemID"]);
                    estoque.Item.ItemDescricao = row["ItemDescricao"].ToString();
                    estoque.Item.TipoItem.TipoItemID = Convert.ToInt32(row["TipoItemID"]);
                    estoque.Item.TipoItem.TipoItemDescricao = row["TipoItemDescricao"].ToString();

                    return estoque;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
