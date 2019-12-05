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
    public class PesagemNegocios
    {
        //Instancio a classe de acesso ao banco de dados
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public int Cadastrar(Pesagem pesagem, int AnimalID)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Inserir");
                acessoDadosSqlServer.AdicionarParametros("@PesagemID", 0);
                acessoDadosSqlServer.AdicionarParametros("@PesagemData", pesagem.PesagemData);
                acessoDadosSqlServer.AdicionarParametros("@PesagemPeso", pesagem.PesagemPeso);
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", AnimalID);

                return int.Parse(acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterPesagem"));

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(Pesagem pesagem)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Alterar");
                acessoDadosSqlServer.AdicionarParametros("@PesagemID", pesagem.PesagemID);
                acessoDadosSqlServer.AdicionarParametros("@PesagemData", pesagem.PesagemData);
                acessoDadosSqlServer.AdicionarParametros("@PesagemPeso", pesagem.PesagemPeso);
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", 0);

                acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterPesagem");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public PesagemCollection ConsultaPorAnimal(int AnimalID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Animal");
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", AnimalID);
                acessoDadosSqlServer.AdicionarParametros("@PesagemData", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@PesagemData2", DateTime.Now);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaPesagem");

                PesagemCollection pesagemCollection = new PesagemCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Pesagem pesagem = new Pesagem();
                    pesagem.PesagemID = Convert.ToInt32(row["PesagemID"]);
                    pesagem.PesagemPeso = Convert.ToDecimal(row["PesagemPeso"]);
                    pesagem.PesagemData = Convert.ToDateTime(row["PesagemData"]);
                    pesagem.Animal = new Animal();
                    pesagem.Animal.AnimalID = Convert.ToInt32(row["AnimalID"]);
                    pesagem.Animal.AnimalDescricao = row["AnimalDescricao"].ToString();

                    pesagemCollection.Add(pesagem);
                }

                return pesagemCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public PesagemCollection ConsultaPorApos(DateTime PesagemData)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Apos");
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", 0);
                acessoDadosSqlServer.AdicionarParametros("@PesagemData", PesagemData);
                acessoDadosSqlServer.AdicionarParametros("@PesagemData2", DateTime.Now);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaPesagem");

                PesagemCollection pesagemCollection = new PesagemCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Pesagem pesagem = new Pesagem();
                    pesagem.PesagemID = Convert.ToInt32(row["PesagemID"]);
                    pesagem.PesagemPeso = Convert.ToDecimal(row["PesagemPeso"]);
                    pesagem.PesagemData = Convert.ToDateTime(row["PesagemData"]);
                    pesagem.Animal = new Animal();
                    pesagem.Animal.AnimalID = Convert.ToInt32(row["AnimalID"]);
                    pesagem.Animal.AnimalDescricao = row["AnimalDescricao"].ToString();

                    pesagemCollection.Add(pesagem);
                }

                return pesagemCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public PesagemCollection ConsultaPorAntes(DateTime PesagemData)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Antes");
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", 0);
                acessoDadosSqlServer.AdicionarParametros("@PesagemData", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@PesagemData2", PesagemData);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaPesagem");

                PesagemCollection pesagemCollection = new PesagemCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Pesagem pesagem = new Pesagem();
                    pesagem.PesagemID = Convert.ToInt32(row["PesagemID"]);
                    pesagem.PesagemPeso = Convert.ToDecimal(row["PesagemPeso"]);
                    pesagem.PesagemData = Convert.ToDateTime(row["PesagemData"]);
                    pesagem.Animal = new Animal();
                    pesagem.Animal.AnimalID = Convert.ToInt32(row["AnimalID"]);
                    pesagem.Animal.AnimalDescricao = row["AnimalDescricao"].ToString();

                    pesagemCollection.Add(pesagem);
                }

                return pesagemCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public PesagemCollection ConsultaPorEntre(DateTime PesagemData, DateTime PesagemData2)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Entre");
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", 0);
                acessoDadosSqlServer.AdicionarParametros("@PesagemData", PesagemData);
                acessoDadosSqlServer.AdicionarParametros("@PesagemData2", PesagemData2);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaPesagem");

                PesagemCollection pesagemCollection = new PesagemCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Pesagem pesagem = new Pesagem();
                    pesagem.PesagemID = Convert.ToInt32(row["PesagemID"]);
                    pesagem.PesagemPeso = Convert.ToDecimal(row["PesagemPeso"]);
                    pesagem.PesagemData = Convert.ToDateTime(row["PesagemData"]);
                    pesagem.Animal = new Animal();
                    pesagem.Animal.AnimalID = Convert.ToInt32(row["AnimalID"]);
                    pesagem.Animal.AnimalDescricao = row["AnimalDescricao"].ToString();

                    pesagemCollection.Add(pesagem);
                }

                return pesagemCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<PesagemRacaPeso> ConsultaPesagemRacaApos(DateTime PesagemData)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "RAposRaca");
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", 0);
                acessoDadosSqlServer.AdicionarParametros("@PesagemData", PesagemData);
                acessoDadosSqlServer.AdicionarParametros("@PesagemData2", DateTime.Now);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaPesagem");

                List<PesagemRacaPeso> pesagensRacaPeso = new List<PesagemRacaPeso>();

                foreach (DataRow row in dataTable.Rows)
                {
                    PesagemRacaPeso pesagemRaca = new PesagemRacaPeso();
                    pesagemRaca.Peso = Convert.ToDecimal(row["PesagemPeso"]);
                    pesagemRaca.Raca = row["RacaNome"].ToString();

                    pesagensRacaPeso.Add(pesagemRaca);
                }

                return pesagensRacaPeso;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<PesagemRacaPeso> ConsultaPesagemRacaAntes(DateTime PesagemData2)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "RAntesRaca");
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", 0);
                acessoDadosSqlServer.AdicionarParametros("@PesagemData", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@PesagemData2", PesagemData2);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaPesagem");

                List<PesagemRacaPeso> pesagensRacaPeso = new List<PesagemRacaPeso>();

                foreach (DataRow row in dataTable.Rows)
                {
                    PesagemRacaPeso pesagemRaca = new PesagemRacaPeso();
                    pesagemRaca.Peso = Convert.ToDecimal(row["PesagemPeso"]);
                    pesagemRaca.Raca = row["RacaNome"].ToString();

                    pesagensRacaPeso.Add(pesagemRaca);
                }

                return pesagensRacaPeso;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<PesagemRacaPeso> ConsultaPesagemRacaEntre(DateTime PesagemData, DateTime PesagemData2)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "REntreRaca");
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", 0);
                acessoDadosSqlServer.AdicionarParametros("@PesagemData", PesagemData);
                acessoDadosSqlServer.AdicionarParametros("@PesagemData2", PesagemData2);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaPesagem");

                List<PesagemRacaPeso> pesagensRacaPeso = new List<PesagemRacaPeso>();

                foreach (DataRow row in dataTable.Rows)
                {
                    PesagemRacaPeso pesagemRaca = new PesagemRacaPeso();
                    pesagemRaca.Peso = Convert.ToDecimal(row["PesagemPeso"]);
                    pesagemRaca.Raca = row["RacaNome"].ToString();

                    pesagensRacaPeso.Add(pesagemRaca);
                }

                return pesagensRacaPeso;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
