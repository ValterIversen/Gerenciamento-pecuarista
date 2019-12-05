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
    public class ContratoAluguelNegocios
    {
        //Instancio a classe de acesso ao banco de dados
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public int Cadastrar(ContratoAluguel contratoAluguel, int UsuarioID)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Inserir");
                acessoDadosSqlServer.AdicionarParametros("@ContratoAluguelID", 0);
                acessoDadosSqlServer.AdicionarParametros("@ContratoAluguelDataInicial", contratoAluguel.ContratoAluguelDataInicial);
                acessoDadosSqlServer.AdicionarParametros("@ContratoAluguelDataFinal", contratoAluguel.ContratoAluguelDataFinal);
                acessoDadosSqlServer.AdicionarParametros("@ContratoAluguelValor", contratoAluguel.ContratoAluguelValor);
                acessoDadosSqlServer.AdicionarParametros("@PessoaID", contratoAluguel.Pessoa.PessoaID);

                contratoAluguel.ContratoAluguelID = int.Parse(acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterContratoAluguel"));

                PastoNegocios pastoNegocios = new PastoNegocios();
                for (int i = 0; i < contratoAluguel.Pastos.Count; i++)
                {
                    contratoAluguel.Pastos[i].ContratoAluguel = new ContratoAluguel();
                    contratoAluguel.Pastos[i].ContratoAluguel.ContratoAluguelID = contratoAluguel.ContratoAluguelID;
                    if (contratoAluguel.Pastos[i].PastoID == 0)
                        contratoAluguel.Pastos[i].PastoID = pastoNegocios.Cadastrar(contratoAluguel.Pastos[i]);
                    else
                        pastoNegocios.Alterar(contratoAluguel.Pastos[i], new PiqueteCollection());
                }

                EstoqueLocalidadeNegocios estoqueLocalidadeNegocios = new EstoqueLocalidadeNegocios();
                for (int i = 0; i < contratoAluguel.EstoquesLocalidade.Count; i++)
                {
                    contratoAluguel.EstoquesLocalidade[i].ContratoAluguel = new ContratoAluguel();
                    contratoAluguel.EstoquesLocalidade[i].ContratoAluguel.ContratoAluguelID = contratoAluguel.ContratoAluguelID;
                    if (contratoAluguel.EstoquesLocalidade[i].EstoqueLocalidadeID == 0)
                        contratoAluguel.EstoquesLocalidade[i].EstoqueLocalidadeID = estoqueLocalidadeNegocios.Cadastrar(contratoAluguel.EstoquesLocalidade[i], UsuarioID);
                    else
                        estoqueLocalidadeNegocios.Alterar(contratoAluguel.EstoquesLocalidade[i], UsuarioID);
                }

                return contratoAluguel.ContratoAluguelID;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(ContratoAluguel contratoAluguel, int UsuarioID, PastoCollection pastoRemocao, EstoqueLocalidadeCollection estoqueLocalidadeRemocao)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Alterar");
                acessoDadosSqlServer.AdicionarParametros("@ContratoAluguelID", contratoAluguel.ContratoAluguelID);
                acessoDadosSqlServer.AdicionarParametros("@ContratoAluguelDataInicial", contratoAluguel.ContratoAluguelDataInicial);
                acessoDadosSqlServer.AdicionarParametros("@ContratoAluguelDataFinal", contratoAluguel.ContratoAluguelDataFinal);
                acessoDadosSqlServer.AdicionarParametros("@ContratoAluguelValor", contratoAluguel.ContratoAluguelValor);
                acessoDadosSqlServer.AdicionarParametros("@PessoaID", contratoAluguel.Pessoa.PessoaID);

                acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterContratoAluguel");

                PastoNegocios pastoNegocios = new PastoNegocios();
                for (int i = 0; i < contratoAluguel.Pastos.Count; i++)
                {
                    if (contratoAluguel.Pastos[i].ContratoAluguel.ContratoAluguelID != contratoAluguel.ContratoAluguelID)
                    {
                        contratoAluguel.Pastos[i].ContratoAluguel.ContratoAluguelID = contratoAluguel.ContratoAluguelID;

                        if (contratoAluguel.Pastos[i].PastoID == 0)
                            contratoAluguel.Pastos[i].PastoID = pastoNegocios.Cadastrar(contratoAluguel.Pastos[i]);
                        else
                            pastoNegocios.Alterar(contratoAluguel.Pastos[i], new PiqueteCollection());
                    }
                }

                EstoqueLocalidadeNegocios estoqueLocalidadeNegocios = new EstoqueLocalidadeNegocios();
                for (int i = 0; i < contratoAluguel.EstoquesLocalidade.Count; i++)
                {

                    if (contratoAluguel.EstoquesLocalidade[i].ContratoAluguel.ContratoAluguelID != contratoAluguel.ContratoAluguelID)
                    {
                        contratoAluguel.EstoquesLocalidade[i].ContratoAluguel.ContratoAluguelID = contratoAluguel.ContratoAluguelID;
                        if (contratoAluguel.EstoquesLocalidade[i].EstoqueLocalidadeID == 0)
                            contratoAluguel.EstoquesLocalidade[i].EstoqueLocalidadeID = estoqueLocalidadeNegocios.Cadastrar(contratoAluguel.EstoquesLocalidade[i], UsuarioID);
                        else
                            estoqueLocalidadeNegocios.Alterar(contratoAluguel.EstoquesLocalidade[i], UsuarioID);
                    }
                }

                for (int i = 0; i < pastoRemocao.Count; i++)
                {
                    pastoNegocios.Alterar(pastoRemocao[i], new PiqueteCollection());
                }

                for (int i = 0; i < estoqueLocalidadeRemocao.Count; i++)
                {
                    estoqueLocalidadeNegocios.Alterar(estoqueLocalidadeRemocao[i], UsuarioID);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public ContratoAluguelCollection ConsultaPorEstoqueLocalidade(int EstoqueLocalidadeID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "EstoqueL");
                acessoDadosSqlServer.AdicionarParametros("@PastoID", 0);
                acessoDadosSqlServer.AdicionarParametros("@EstoqueLocalidadeID", EstoqueLocalidadeID);
                acessoDadosSqlServer.AdicionarParametros("@PessoaID", 0);
                acessoDadosSqlServer.AdicionarParametros("@ContratoAluguelID", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaContratoAluguel");

                ContratoAluguelCollection contratoAluguelCollection = new ContratoAluguelCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    ContratoAluguel contratoAluguel = new ContratoAluguel();
                    contratoAluguel.Pessoa = new Pessoa();
                    contratoAluguel.EstoquesLocalidade = new EstoqueLocalidadeCollection();
                    contratoAluguel.Pastos = new PastoCollection();
                    contratoAluguel.ContratoAluguelID = Convert.ToInt32(row["ContratoAluguelID"]);
                    contratoAluguel.ContratoAluguelDataInicial = Convert.ToDateTime(row["ContratoAluguelDataInicial"]);
                    contratoAluguel.ContratoAluguelDataFinal = Convert.ToDateTime(row["ContratoAluguelDataFinal"]);
                    contratoAluguel.ContratoAluguelValor = Convert.ToDecimal(row["ContratoAluguelValor"]);
                    contratoAluguel.Pessoa.PessoaID = Convert.ToInt32(row["PessoaID"]);
                    contratoAluguel.QuantidadeEstoqueLocalidade = Convert.ToInt32(row["QuantidadeEstoqueLocalidade"]);
                    contratoAluguel.QuantidadePasto = Convert.ToInt32(row["QuantidadePasto"]);
                    PessoaNegocios pessoaNegocios = new PessoaNegocios();
                    contratoAluguel.Pessoa = pessoaNegocios.ConsultaPorID(contratoAluguel.Pessoa.PessoaID)[0];

                    contratoAluguelCollection.Add(contratoAluguel);
                }

                return contratoAluguelCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ContratoAluguelCollection ConsultaPorPasto(int PastoID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Pasto");
                acessoDadosSqlServer.AdicionarParametros("@PastoID", PastoID);
                acessoDadosSqlServer.AdicionarParametros("@EstoqueLocalidadeID", 0);
                acessoDadosSqlServer.AdicionarParametros("@PessoaID", 0);
                acessoDadosSqlServer.AdicionarParametros("@ContratoAluguelID", 0);


                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaContratoAluguel");

                ContratoAluguelCollection contratoAluguelCollection = new ContratoAluguelCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    ContratoAluguel contratoAluguel = new ContratoAluguel();
                    contratoAluguel.Pessoa = new Pessoa();
                    contratoAluguel.EstoquesLocalidade = new EstoqueLocalidadeCollection();
                    contratoAluguel.Pastos = new PastoCollection();
                    contratoAluguel.ContratoAluguelID = Convert.ToInt32(row["ContratoAluguelID"]);
                    contratoAluguel.ContratoAluguelDataInicial = Convert.ToDateTime(row["ContratoAluguelDataInicial"]);
                    contratoAluguel.ContratoAluguelDataFinal = Convert.ToDateTime(row["ContratoAluguelDataFinal"]);
                    contratoAluguel.ContratoAluguelValor = Convert.ToDecimal(row["ContratoAluguelValor"]);
                    contratoAluguel.Pessoa.PessoaID = Convert.ToInt32(row["PessoaID"]);
                    contratoAluguel.QuantidadeEstoqueLocalidade = Convert.ToInt32(row["QuantidadeEstoqueLocalidade"]);
                    contratoAluguel.QuantidadePasto = Convert.ToInt32(row["QuantidadePasto"]);
                    PessoaNegocios pessoaNegocios = new PessoaNegocios();
                    contratoAluguel.Pessoa = pessoaNegocios.ConsultaPorID(contratoAluguel.Pessoa.PessoaID)[0];

                    contratoAluguelCollection.Add(contratoAluguel);
                }

                return contratoAluguelCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public ContratoAluguelCollection ConsultaPorPessoa(int PessoaID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Pessoa");
                acessoDadosSqlServer.AdicionarParametros("@PastoID", 0);
                acessoDadosSqlServer.AdicionarParametros("@EstoqueLocalidadeID", 0);
                acessoDadosSqlServer.AdicionarParametros("@PessoaID", PessoaID);
                acessoDadosSqlServer.AdicionarParametros("@ContratoAluguelID", 0);


                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaContratoAluguel");

                ContratoAluguelCollection contratoAluguelCollection = new ContratoAluguelCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    ContratoAluguel contratoAluguel = new ContratoAluguel();
                    contratoAluguel.Pessoa = new Pessoa();
                    contratoAluguel.EstoquesLocalidade = new EstoqueLocalidadeCollection();
                    contratoAluguel.Pastos = new PastoCollection();
                    contratoAluguel.ContratoAluguelID = Convert.ToInt32(row["ContratoAluguelID"]);
                    contratoAluguel.ContratoAluguelDataInicial = Convert.ToDateTime(row["ContratoAluguelDataInicial"]);
                    contratoAluguel.ContratoAluguelDataFinal = Convert.ToDateTime(row["ContratoAluguelDataFinal"]);
                    contratoAluguel.ContratoAluguelValor = Convert.ToDecimal(row["ContratoAluguelValor"]);
                    contratoAluguel.Pessoa.PessoaID = Convert.ToInt32(row["PessoaID"]);
                    contratoAluguel.QuantidadeEstoqueLocalidade = Convert.ToInt32(row["QuantidadeEstoqueLocalidade"]);
                    contratoAluguel.QuantidadePasto = Convert.ToInt32(row["QuantidadePasto"]);
                    PessoaNegocios pessoaNegocios = new PessoaNegocios();
                    contratoAluguel.Pessoa = pessoaNegocios.ConsultaPorID(contratoAluguel.Pessoa.PessoaID)[0];

                    contratoAluguelCollection.Add(contratoAluguel);
                }

                return contratoAluguelCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public ContratoAluguelCollection ConsultaPorID(int ContratoAluguelID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "ID");
                acessoDadosSqlServer.AdicionarParametros("@PastoID", 0);
                acessoDadosSqlServer.AdicionarParametros("@EstoqueLocalidadeID", 0);
                acessoDadosSqlServer.AdicionarParametros("@PessoaID", 0);
                acessoDadosSqlServer.AdicionarParametros("@ContratoAluguelID", ContratoAluguelID);


                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaContratoAluguel");

                ContratoAluguelCollection contratoAluguelCollection = new ContratoAluguelCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    ContratoAluguel contratoAluguel = new ContratoAluguel();
                    contratoAluguel.Pessoa = new Pessoa();
                    contratoAluguel.EstoquesLocalidade = new EstoqueLocalidadeCollection();
                    contratoAluguel.Pastos = new PastoCollection();
                    contratoAluguel.ContratoAluguelID = Convert.ToInt32(row["ContratoAluguelID"]);
                    contratoAluguel.ContratoAluguelDataInicial = Convert.ToDateTime(row["ContratoAluguelDataInicial"]);
                    contratoAluguel.ContratoAluguelDataFinal = Convert.ToDateTime(row["ContratoAluguelDataFinal"]);
                    contratoAluguel.ContratoAluguelValor = Convert.ToDecimal(row["ContratoAluguelValor"]);
                    contratoAluguel.Pessoa.PessoaID = Convert.ToInt32(row["PessoaID"]);
                    contratoAluguel.QuantidadeEstoqueLocalidade = Convert.ToInt32(row["QuantidadeEstoqueLocalidade"]);
                    contratoAluguel.QuantidadePasto = Convert.ToInt32(row["QuantidadePasto"]);
                    PessoaNegocios pessoaNegocios = new PessoaNegocios();
                    contratoAluguel.Pessoa = pessoaNegocios.ConsultaPorID(contratoAluguel.Pessoa.PessoaID)[0];

                    contratoAluguelCollection.Add(contratoAluguel);
                }

                return contratoAluguelCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
