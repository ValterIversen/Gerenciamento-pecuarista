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
    public class EstoqueLocalidadeNegocios
    {
        //Instancio a classe de acesso ao banco de dados
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public int Cadastrar(EstoqueLocalidade estoqueLocalidade, int UsuarioID)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Inserir");
                acessoDadosSqlServer.AdicionarParametros("@EstoqueLocalidadeID", 0);
                acessoDadosSqlServer.AdicionarParametros("@EstoqueLocalidadeDescricao", estoqueLocalidade.EstoqueLocalidadeDescricao);
                acessoDadosSqlServer.AdicionarParametros("@EstoqueLocalidadeEndereco", estoqueLocalidade.EstoqueLocalidadeEndereco);
                acessoDadosSqlServer.AdicionarParametros("@CidadeID", estoqueLocalidade.Cidade.CidadeID);
                if(estoqueLocalidade.ContratoAluguel.ContratoAluguelID != 0)
                    acessoDadosSqlServer.AdicionarParametros("@ContratoAluguelID", estoqueLocalidade.ContratoAluguel.ContratoAluguelID);
                else
                    acessoDadosSqlServer.AdicionarParametros("@ContratoAluguelID", null);

                estoqueLocalidade.EstoqueLocalidadeID = int.Parse(acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEstoqueLocalidade"));

                EstoqueNegocios estoqueNegocios = new EstoqueNegocios();
                foreach (Estoque estoque in estoqueLocalidade.Estoques)
                {
                    estoque.EstoqueLocalidade = new EstoqueLocalidade();
                    estoque.EstoqueLocalidade.EstoqueLocalidadeID = estoqueLocalidade.EstoqueLocalidadeID;
                    estoqueNegocios.Cadastrar(estoque, UsuarioID);
                }

                return estoqueLocalidade.EstoqueLocalidadeID;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(EstoqueLocalidade estoqueLocalidade, int UsuarioID)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Alterar");
                acessoDadosSqlServer.AdicionarParametros("@EstoqueLocalidadeID", estoqueLocalidade.EstoqueLocalidadeID);
                acessoDadosSqlServer.AdicionarParametros("@EstoqueLocalidadeDescricao", estoqueLocalidade.EstoqueLocalidadeDescricao);
                acessoDadosSqlServer.AdicionarParametros("@EstoqueLocalidadeEndereco", estoqueLocalidade.EstoqueLocalidadeEndereco);
                acessoDadosSqlServer.AdicionarParametros("@CidadeID", estoqueLocalidade.Cidade.CidadeID);
                if(estoqueLocalidade.ContratoAluguel.ContratoAluguelID != 0)
                    acessoDadosSqlServer.AdicionarParametros("@ContratoAluguelID", estoqueLocalidade.ContratoAluguel.ContratoAluguelID);
                else
                    acessoDadosSqlServer.AdicionarParametros("@ContratoAluguelID", null);

                if (estoqueLocalidade.Estoques != null)
                {
                    EstoqueNegocios estoqueNegocios = new EstoqueNegocios();
                    foreach (Estoque estoque in estoqueLocalidade.Estoques)
                    {
                        if (estoque.EstoqueLocalidade.EstoqueLocalidadeID == 0)
                        {
                            estoque.EstoqueLocalidade = new EstoqueLocalidade();
                            estoque.EstoqueLocalidade.EstoqueLocalidadeID = estoqueLocalidade.EstoqueLocalidadeID;
                            estoqueNegocios.Cadastrar(estoque, UsuarioID);
                        }
                    }
                }

                acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEstoqueLocalidade");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public EstoqueLocalidadeCollection ConsultaPorCidade(int CidadeID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Cidade");
                acessoDadosSqlServer.AdicionarParametros("@CidadeID", CidadeID);
                acessoDadosSqlServer.AdicionarParametros("@EstoqueLocalidadeID", 0);
                acessoDadosSqlServer.AdicionarParametros("@ContratoAluguelID", 0);
                acessoDadosSqlServer.AdicionarParametros("@ItemID", 0);
                acessoDadosSqlServer.AdicionarParametros("@EstoqueLocalidadeDescricao", "");

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaEstoqueLocalidade");

                EstoqueLocalidadeCollection estoqueLocalidadeCollection = new EstoqueLocalidadeCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    EstoqueLocalidade estoqueLocalidade = new EstoqueLocalidade();
                    estoqueLocalidade.ContratoAluguel = new ContratoAluguel();
                    estoqueLocalidade.Cidade = new Cidade();
                    estoqueLocalidade.ContratoAluguel = new ContratoAluguel();
                    estoqueLocalidade.EstoqueLocalidadeID = Convert.ToInt32(row["EstoqueLocalidadeID"]);
                    estoqueLocalidade.EstoqueLocalidadeDescricao = row["EstoqueLocalidadeDescricao"].ToString();
                    estoqueLocalidade.EstoqueLocalidadeEndereco = row["EstoqueLocalidadeEndereco"].ToString();
                    estoqueLocalidade.Cidade.CidadeID = Convert.ToInt32(row["CidadeID"]);
                    estoqueLocalidade.Cidade.CidadeNome = row["CidadeNome"].ToString();
                    estoqueLocalidade.Cidade.EstadoID = Convert.ToInt32(row["EstadoID"]);
                    estoqueLocalidade.Cidade.EstadoNome = row["EstadoNome"].ToString();
                    estoqueLocalidade.Cidade.EstadoSigla = row["EstadoSigla"].ToString();
                    if (row["ContratoAluguelID"] != DBNull.Value)
                        estoqueLocalidade.ContratoAluguel.ContratoAluguelID = Convert.ToInt32(row["ContratoAluguelID"]);

                    estoqueLocalidadeCollection.Add(estoqueLocalidade);
                }

                return estoqueLocalidadeCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public EstoqueLocalidade ConsultaPorID(int ID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "ID");
                acessoDadosSqlServer.AdicionarParametros("@CidadeID", 0);
                acessoDadosSqlServer.AdicionarParametros("@EstoqueLocalidadeID", ID);
                acessoDadosSqlServer.AdicionarParametros("@ContratoAluguelID", 0);
                acessoDadosSqlServer.AdicionarParametros("@ItemID", 0);
                acessoDadosSqlServer.AdicionarParametros("@EstoqueLocalidadeDescricao", "");

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaEstoqueLocalidade");


                foreach (DataRow row in dataTable.Rows)
                {
                    EstoqueLocalidade estoqueLocalidade = new EstoqueLocalidade();
                    estoqueLocalidade.ContratoAluguel = new ContratoAluguel();
                    estoqueLocalidade.Cidade = new Cidade();
                    estoqueLocalidade.ContratoAluguel = new ContratoAluguel();
                    estoqueLocalidade.EstoqueLocalidadeID = Convert.ToInt32(row["EstoqueLocalidadeID"]);
                    estoqueLocalidade.EstoqueLocalidadeDescricao = row["EstoqueLocalidadeDescricao"].ToString();
                    estoqueLocalidade.EstoqueLocalidadeEndereco = row["EstoqueLocalidadeEndereco"].ToString();
                    estoqueLocalidade.Cidade.CidadeID = Convert.ToInt32(row["CidadeID"]);
                    estoqueLocalidade.Cidade.CidadeNome = row["CidadeNome"].ToString();
                    estoqueLocalidade.Cidade.EstadoID = Convert.ToInt32(row["EstadoID"]);
                    estoqueLocalidade.Cidade.EstadoNome = row["EstadoNome"].ToString();
                    estoqueLocalidade.Cidade.EstadoSigla = row["EstadoSigla"].ToString();
                    if (row["ContratoAluguelID"] != DBNull.Value)
                        estoqueLocalidade.ContratoAluguel.ContratoAluguelID = Convert.ToInt32(row["ContratoAluguelID"]);
                    return estoqueLocalidade;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public EstoqueLocalidadeCollection ConsultaPorContratoAluguel(int ContratoAluguelID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "ContratoA");
                acessoDadosSqlServer.AdicionarParametros("@CidadeID", 0);
                acessoDadosSqlServer.AdicionarParametros("@EstoqueLocalidadeID", 0);
                acessoDadosSqlServer.AdicionarParametros("@ContratoAluguelID", ContratoAluguelID);
                acessoDadosSqlServer.AdicionarParametros("@ItemID", 0);
                acessoDadosSqlServer.AdicionarParametros("@EstoqueLocalidadeDescricao", "");

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaEstoqueLocalidade");

                EstoqueLocalidadeCollection estoqueLocalidadeCollection = new EstoqueLocalidadeCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    EstoqueLocalidade estoqueLocalidade = new EstoqueLocalidade();
                    estoqueLocalidade.Cidade = new Cidade();
                    estoqueLocalidade.ContratoAluguel = new ContratoAluguel();
                    estoqueLocalidade.EstoqueLocalidadeID = Convert.ToInt32(row["EstoqueLocalidadeID"]);
                    estoqueLocalidade.EstoqueLocalidadeDescricao = row["EstoqueLocalidadeDescricao"].ToString();
                    estoqueLocalidade.EstoqueLocalidadeEndereco = row["EstoqueLocalidadeEndereco"].ToString();
                    estoqueLocalidade.Cidade.CidadeID = Convert.ToInt32(row["CidadeID"]);
                    estoqueLocalidade.Cidade.CidadeNome = row["CidadeNome"].ToString();
                    estoqueLocalidade.Cidade.EstadoID = Convert.ToInt32(row["EstadoID"]);
                    estoqueLocalidade.Cidade.EstadoNome = row["EstadoNome"].ToString();
                    estoqueLocalidade.Cidade.EstadoSigla = row["EstadoSigla"].ToString();
                    if (row["ContratoAluguelID"] != DBNull.Value)
                        estoqueLocalidade.ContratoAluguel.ContratoAluguelID = Convert.ToInt32(row["ContratoAluguelID"]);

                    estoqueLocalidadeCollection.Add(estoqueLocalidade);
                }

                return estoqueLocalidadeCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public EstoqueLocalidadeCollection ConsultaPorItem(int ItemID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Item");
                acessoDadosSqlServer.AdicionarParametros("@CidadeID", 0);
                acessoDadosSqlServer.AdicionarParametros("@EstoqueLocalidadeID", 0);
                acessoDadosSqlServer.AdicionarParametros("@ContratoAluguelID", 0);
                acessoDadosSqlServer.AdicionarParametros("@ItemID", ItemID);
                acessoDadosSqlServer.AdicionarParametros("@EstoqueLocalidadeDescricao", "");

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaEstoqueLocalidade");

                EstoqueLocalidadeCollection estoqueLocalidadeCollection = new EstoqueLocalidadeCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    EstoqueLocalidade estoqueLocalidade = new EstoqueLocalidade();
                    estoqueLocalidade.Cidade = new Cidade();
                    estoqueLocalidade.ContratoAluguel = new ContratoAluguel();
                    estoqueLocalidade.EstoqueLocalidadeID = Convert.ToInt32(row["EstoqueLocalidadeID"]);
                    estoqueLocalidade.EstoqueLocalidadeDescricao = row["EstoqueLocalidadeDescricao"].ToString();
                    estoqueLocalidade.EstoqueLocalidadeEndereco = row["EstoqueLocalidadeEndereco"].ToString();
                    estoqueLocalidade.Cidade.CidadeID = Convert.ToInt32(row["CidadeID"]);
                    estoqueLocalidade.Cidade.CidadeNome = row["CidadeNome"].ToString();
                    estoqueLocalidade.Cidade.EstadoID = Convert.ToInt32(row["EstadoID"]);
                    estoqueLocalidade.Cidade.EstadoNome = row["EstadoNome"].ToString();
                    estoqueLocalidade.Cidade.EstadoSigla = row["EstadoSigla"].ToString();
                    if(row["ContratoAluguelID"] != DBNull.Value)
                        estoqueLocalidade.ContratoAluguel.ContratoAluguelID = Convert.ToInt32(row["ContratoAluguelID"]);

                    estoqueLocalidadeCollection.Add(estoqueLocalidade);
                }

                return estoqueLocalidadeCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public EstoqueLocalidadeCollection ConsultaPorDescricao(string Descricao)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Descricao");
                acessoDadosSqlServer.AdicionarParametros("@CidadeID", 0);
                acessoDadosSqlServer.AdicionarParametros("@EstoqueLocalidadeID", 0);
                acessoDadosSqlServer.AdicionarParametros("@ContratoAluguelID", 0);
                acessoDadosSqlServer.AdicionarParametros("@ItemID", 0);
                acessoDadosSqlServer.AdicionarParametros("@EstoqueLocalidadeDescricao", Descricao);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaEstoqueLocalidade");

                EstoqueLocalidadeCollection estoqueLocalidadeCollection = new EstoqueLocalidadeCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    EstoqueLocalidade estoqueLocalidade = new EstoqueLocalidade();
                    estoqueLocalidade.Cidade = new Cidade();
                    estoqueLocalidade.ContratoAluguel = new ContratoAluguel();
                    estoqueLocalidade.EstoqueLocalidadeID = Convert.ToInt32(row["EstoqueLocalidadeID"]);
                    estoqueLocalidade.EstoqueLocalidadeDescricao = row["EstoqueLocalidadeDescricao"].ToString();
                    estoqueLocalidade.EstoqueLocalidadeEndereco = row["EstoqueLocalidadeEndereco"].ToString();
                    estoqueLocalidade.Cidade.CidadeID = Convert.ToInt32(row["CidadeID"]);
                    estoqueLocalidade.Cidade.CidadeNome = row["CidadeNome"].ToString();
                    estoqueLocalidade.Cidade.EstadoID = Convert.ToInt32(row["EstadoID"]);
                    estoqueLocalidade.Cidade.EstadoNome = row["EstadoNome"].ToString();
                    estoqueLocalidade.Cidade.EstadoSigla = row["EstadoSigla"].ToString();
                    if(row["ContratoAluguelID"] != DBNull.Value)
                    estoqueLocalidade.ContratoAluguel.ContratoAluguelID = Convert.ToInt32(row["ContratoAluguelID"]);

                    estoqueLocalidadeCollection.Add(estoqueLocalidade);
                }

                return estoqueLocalidadeCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
