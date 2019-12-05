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
    public class PastoNegocios
    {
        //Instancio a classe de acesso ao banco de dados
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public int Cadastrar(Pasto pasto)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Inserir");
                acessoDadosSqlServer.AdicionarParametros("@PastoID", 0);
                acessoDadosSqlServer.AdicionarParametros("@PastoDescricao", pasto.PastoDescricao);
                acessoDadosSqlServer.AdicionarParametros("@PastoTamanho", pasto.PastoTamanho);
                acessoDadosSqlServer.AdicionarParametros("@PastoAtivo", true);
                acessoDadosSqlServer.AdicionarParametros("@CidadeID", pasto.Cidade.CidadeID);
                if(pasto.ContratoAluguel.ContratoAluguelID != 0)
                    acessoDadosSqlServer.AdicionarParametros("@ContratoAluguelID", pasto.ContratoAluguel.ContratoAluguelID);
                else
                    acessoDadosSqlServer.AdicionarParametros("@ContratoAluguelID", null);

                int ID = int.Parse(acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterPasto"));

                PiqueteNegocios piqueteNegocios = new PiqueteNegocios();
                foreach(Piquete piquete in pasto.Piquetes)
                {
                    piqueteNegocios.Cadastrar(piquete, ID);
                }

                return ID;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Alterar(Pasto pasto, PiqueteCollection piquetesRemocao)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Alterar");
                acessoDadosSqlServer.AdicionarParametros("@PastoID", pasto.PastoID);
                acessoDadosSqlServer.AdicionarParametros("@PastoDescricao", pasto.PastoDescricao);
                acessoDadosSqlServer.AdicionarParametros("@PastoTamanho", pasto.PastoTamanho);
                acessoDadosSqlServer.AdicionarParametros("@PastoAtivo", pasto.PastoAtivo);
                acessoDadosSqlServer.AdicionarParametros("@CidadeID", pasto.Cidade.CidadeID);
                if (pasto.ContratoAluguel.ContratoAluguelID != 0)
                    acessoDadosSqlServer.AdicionarParametros("@ContratoAluguelID", pasto.ContratoAluguel.ContratoAluguelID);
                else
                    acessoDadosSqlServer.AdicionarParametros("@ContratoAluguelID", null);


                acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterPasto");

                if (pasto.Piquetes != null)
                {
                    PiqueteNegocios piqueteNegocios = new PiqueteNegocios();
                    foreach (Piquete piquete in pasto.Piquetes)
                    {
                        if (piquete.PiqueteID == 0)
                            piqueteNegocios.Cadastrar(piquete, pasto.PastoID);
                    }
                    foreach (Piquete piquete in piquetesRemocao)
                    {
                        piqueteNegocios.Excluir(piquete.PiqueteID);
                    }
                }

                return pasto.PastoID;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public PastoCollection ConsultaPorDescricao(string Descricao)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Descricao");
                acessoDadosSqlServer.AdicionarParametros("@PastoID", 0);
                acessoDadosSqlServer.AdicionarParametros("@PastoDescricao", Descricao);
                acessoDadosSqlServer.AdicionarParametros("@CidadeID", 0);
                acessoDadosSqlServer.AdicionarParametros("@ContratoAluguelID ", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaPasto");

                PastoCollection pastoCollection = new PastoCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Pasto pasto = new Pasto();

                    pasto.PastoID = Convert.ToInt32(row["PastoID"]);
                    pasto.PastoDescricao = row["PastoDescricao"].ToString();
                    pasto.PastoTamanho = Convert.ToDecimal(row["PastoTamanho"]);
                    pasto.PastoAtivo = Convert.ToBoolean(row["PastoAtivo"]);
                    pasto.ContratoAluguel = new ContratoAluguel();
                    if (int.TryParse(row["ContratoAluguelID"].ToString(), out int ContratoAluguel))
                    {
                        pasto.ContratoAluguel.ContratoAluguelID = ContratoAluguel;
                    }
                    pasto.Cidade = new Cidade();
                    pasto.Cidade.CidadeID = Convert.ToInt32(row["CidadeID"]);
                    pasto.Cidade.CidadeNome = row["CidadeNome"].ToString();
                    pasto.Cidade.EstadoID = Convert.ToInt32(row["EstadoID"]);
                    pasto.Cidade.EstadoNome = row["EstadoNome"].ToString();
                    pasto.Cidade.EstadoSigla = row["EstadoSigla"].ToString();

                    pastoCollection.Add(pasto);
                }

                return pastoCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public PastoCollection ConsultaPorCidade(int CidadeID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Cidade");
                acessoDadosSqlServer.AdicionarParametros("@PastoID", 0);
                acessoDadosSqlServer.AdicionarParametros("@PastoDescricao", "");
                acessoDadosSqlServer.AdicionarParametros("@CidadeID", CidadeID);
                acessoDadosSqlServer.AdicionarParametros("@ContratoAluguelID ", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaPasto");

                PastoCollection pastoCollection = new PastoCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Pasto pasto = new Pasto();
                    pasto.Cidade = new Cidade();
                    pasto.ContratoAluguel = new ContratoAluguel();

                    pasto.PastoID = Convert.ToInt32(row["PastoID"]);
                    pasto.PastoDescricao = row["PastoDescricao"].ToString();
                    pasto.PastoTamanho = Convert.ToDecimal(row["PastoTamanho"]);
                    pasto.PastoAtivo = Convert.ToBoolean(row["PastoAtivo"]);
                    if (int.TryParse(row["ContratoAluguelID"].ToString(), out int ContratoAluguel))
                    {
                        pasto.ContratoAluguel.ContratoAluguelID = ContratoAluguel;
                    }
                    pasto.Cidade.CidadeID = Convert.ToInt32(row["CidadeID"]);
                    pasto.Cidade.CidadeNome = row["CidadeNome"].ToString();
                    pasto.Cidade.EstadoID = Convert.ToInt32(row["EstadoID"]);
                    pasto.Cidade.EstadoNome = row["EstadoNome"].ToString();
                    pasto.Cidade.EstadoSigla = row["EstadoSigla"].ToString();


                    pastoCollection.Add(pasto);
                }

                return pastoCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public PastoCollection ConsultaPorContratoAluguel(int ContratoAluguelID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "ContratoA");
                acessoDadosSqlServer.AdicionarParametros("@PastoID", 0);
                acessoDadosSqlServer.AdicionarParametros("@PastoDescricao", "");
                acessoDadosSqlServer.AdicionarParametros("@CidadeID", 0);
                acessoDadosSqlServer.AdicionarParametros("@ContratoAluguelID ", ContratoAluguelID);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaPasto");

                PastoCollection pastoCollection = new PastoCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Pasto pasto = new Pasto();
                    pasto.Cidade = new Cidade();
                    pasto.ContratoAluguel = new ContratoAluguel();

                    pasto.PastoID = Convert.ToInt32(row["PastoID"]);
                    pasto.PastoDescricao = row["PastoDescricao"].ToString();
                    pasto.PastoTamanho = Convert.ToDecimal(row["PastoTamanho"]);
                    pasto.PastoAtivo = Convert.ToBoolean(row["PastoAtivo"]);
                    if (int.TryParse(row["ContratoAluguelID"].ToString(), out int ContratoAluguel))
                    {
                        pasto.ContratoAluguel.ContratoAluguelID = ContratoAluguel;
                    }
                    pasto.Cidade.CidadeID = Convert.ToInt32(row["CidadeID"]);
                    pasto.Cidade.CidadeNome = row["CidadeNome"].ToString();
                    pasto.Cidade.EstadoID = Convert.ToInt32(row["EstadoID"]);
                    pasto.Cidade.EstadoNome = row["EstadoNome"].ToString();
                    pasto.Cidade.EstadoSigla = row["EstadoSigla"].ToString();


                    pastoCollection.Add(pasto);
                }

                return pastoCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Pasto ConsultaPorID(int PastoID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "ID");
                acessoDadosSqlServer.AdicionarParametros("@PastoID", PastoID);
                acessoDadosSqlServer.AdicionarParametros("@PastoDescricao", "");
                acessoDadosSqlServer.AdicionarParametros("@CidadeID", 0);
                acessoDadosSqlServer.AdicionarParametros("@ContratoAluguelID ", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaPasto");


                PiqueteNegocios piqueteNegocios = new PiqueteNegocios();

                foreach (DataRow row in dataTable.Rows)
                {
                    Pasto pasto = new Pasto();
                    pasto.Cidade = new Cidade();
                    pasto.ContratoAluguel = new ContratoAluguel();

                    pasto.PastoID = Convert.ToInt32(row["PastoID"]);
                    pasto.PastoDescricao = row["PastoDescricao"].ToString();
                    pasto.PastoTamanho = Convert.ToDecimal(row["PastoTamanho"]);
                    pasto.PastoAtivo = Convert.ToBoolean(row["PastoAtivo"]);
                    if (int.TryParse(row["ContratoAluguelID"].ToString(), out int ContratoAluguel))
                    {
                        pasto.ContratoAluguel.ContratoAluguelID = ContratoAluguel;
                    }
                    pasto.Cidade.CidadeID = Convert.ToInt32(row["CidadeID"]);
                    pasto.Cidade.CidadeNome = row["CidadeNome"].ToString();
                    pasto.Cidade.EstadoID = Convert.ToInt32(row["EstadoID"]);
                    pasto.Cidade.EstadoNome = row["EstadoNome"].ToString();
                    pasto.Cidade.EstadoSigla = row["EstadoSigla"].ToString();

                    pasto.Piquetes = new PiqueteCollection();
                    pasto.Piquetes = piqueteNegocios.ConsultarPorPasto(pasto.PastoID);

                    return pasto;
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
