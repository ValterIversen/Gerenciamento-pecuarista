using System;

using AcessoBancoDados;
using ObjetoTransferencia;
using System.Data;

namespace Negocios
{
    public class AnimalNegocios
    {
        //Instancio a classe de acesso ao banco de dados
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public int Cadastrar(Animal animal)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Inserir");
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", 0);
                acessoDadosSqlServer.AdicionarParametros("@AnimalDescricao", animal.AnimalDescricao);

                if(animal.AnimalParentescoPai.AnimalID == 0)
                    acessoDadosSqlServer.AdicionarParametros("@AnimalParentescoPai", null);
                else
                    acessoDadosSqlServer.AdicionarParametros("@AnimalParentescoPai", animal.AnimalParentescoPai.AnimalID);

                if (animal.AnimalParentescoMae.AnimalID == 0)
                    acessoDadosSqlServer.AdicionarParametros("@AnimalParentescoMae", null);
                else
                    acessoDadosSqlServer.AdicionarParametros("@AnimalParentescoMae", animal.AnimalParentescoMae.AnimalID);

                acessoDadosSqlServer.AdicionarParametros("@AnimalLocalidadeNascimento", animal.AnimalLocalidadeNascimento);

                if (animal.AnimalDataNascimento == DateTime.Now)
                    acessoDadosSqlServer.AdicionarParametros("@AnimalDataNascimento", null);
                else
                    acessoDadosSqlServer.AdicionarParametros("@AnimalDataNascimento", animal.AnimalDataNascimento);

                acessoDadosSqlServer.AdicionarParametros("@AnimalIdentificador", animal.AnimalIdentificador);
                acessoDadosSqlServer.AdicionarParametros("@AnimalAtivo", 1);
                acessoDadosSqlServer.AdicionarParametros("@RacaID", animal.Raca.RacaID);
                acessoDadosSqlServer.AdicionarParametros("@PiqueteID", animal.Piquete.PiqueteID);

                animal.AnimalID = int.Parse(acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterAnimal"));

                PesagemNegocios pesagemNegocios = new PesagemNegocios();

                pesagemNegocios.Cadastrar(animal.Pesagens[0], animal.AnimalID);

                return animal.AnimalID;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(Animal animal)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Alterar");
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", animal.AnimalID);
                acessoDadosSqlServer.AdicionarParametros("@AnimalDescricao", animal.AnimalDescricao);

                if (animal.AnimalParentescoPai.AnimalID == 0)
                    acessoDadosSqlServer.AdicionarParametros("@AnimalParentescoPai", null);
                else
                    acessoDadosSqlServer.AdicionarParametros("@AnimalParentescoPai", animal.AnimalParentescoPai.AnimalID);

                if (animal.AnimalParentescoMae.AnimalID == 0)
                    acessoDadosSqlServer.AdicionarParametros("@AnimalParentescoMae", null);
                else
                    acessoDadosSqlServer.AdicionarParametros("@AnimalParentescoMae", animal.AnimalParentescoMae.AnimalID);

                acessoDadosSqlServer.AdicionarParametros("@AnimalLocalidadeNascimento", animal.AnimalLocalidadeNascimento);

                if (animal.AnimalDataNascimento == DateTime.Now)
                    acessoDadosSqlServer.AdicionarParametros("@AnimalDataNascimento", null);
                else
                    acessoDadosSqlServer.AdicionarParametros("@AnimalDataNascimento", animal.AnimalDataNascimento);

                acessoDadosSqlServer.AdicionarParametros("@AnimalIdentificador", animal.AnimalIdentificador);
                acessoDadosSqlServer.AdicionarParametros("@AnimalAtivo", animal.AnimalAtivo);
                acessoDadosSqlServer.AdicionarParametros("@RacaID", animal.Raca.RacaID);
                acessoDadosSqlServer.AdicionarParametros("@PiqueteID", animal.Piquete.PiqueteID);

                acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterAnimal");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public AnimalCollection ConsultaPorID(int AnimalID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "ID");
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", AnimalID);
                acessoDadosSqlServer.AdicionarParametros("@AnimalDescricao", "");
                acessoDadosSqlServer.AdicionarParametros("@AnimalIdentificador", "");
                acessoDadosSqlServer.AdicionarParametros("@RacaID", 0);
                acessoDadosSqlServer.AdicionarParametros("@PiqueteID", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaAnimal");

                AnimalCollection animalCollection = new AnimalCollection();
                PesagemNegocios pesagemNegocios = new PesagemNegocios();

                foreach (DataRow row in dataTable.Rows)
                {
                    Animal animal = new Animal();
                    animal.Piquete = new Piquete();
                    animal.Raca = new Raca();
                    animal.Pesagens = new PesagemCollection();
                    animal.AnimalParentescoPai = new Animal();
                    animal.AnimalParentescoMae = new Animal();
                    animal.Piquete.Pasto = new Pasto();
                    animal.Piquete.Pasto.Cidade = new Cidade();

                    animal.AnimalID = Convert.ToInt32(row["AnimalID"]);
                    animal.AnimalDescricao = row["AnimalDescricao"].ToString();

                    if (row["AnimalParentescoPai"] != DBNull.Value)
                        animal.AnimalParentescoPai.AnimalID = Convert.ToInt32(row["AnimalParentescoPai"]);

                    if (row["AnimalParentescoMae"] != DBNull.Value)
                        animal.AnimalParentescoMae.AnimalID = Convert.ToInt32(row["AnimalParentescoMae"]);

                    animal.AnimalLocalidadeNascimento = row["AnimalLocalidadeNascimento"].ToString();

                    if (row["AnimalDataNascimento"] != DBNull.Value)
                        animal.AnimalDataNascimento = Convert.ToDateTime(row["AnimalDataNascimento"]);

                    animal.AnimalIdentificador = row["AnimalIdentificador"].ToString();
                    animal.AnimalAtivo = Convert.ToBoolean(row["AnimalAtivo"]);
                    animal.Raca.RacaID = Convert.ToInt32(row["RacaID"]);
                    animal.Raca.RacaNome = row["RacaNome"].ToString();
                    animal.Raca.RacaDescricao = row["RacaDescricao"].ToString();

                    animal.Pesagens = pesagemNegocios.ConsultaPorAnimal(animal.AnimalID);

                    animal.Piquete.PiqueteID = Convert.ToInt32(row["PiqueteID"]);
                    animal.Piquete.PiqueteDescricao = row["PiqueteDescricao"].ToString();
                    animal.Piquete.Pasto.PastoID = Convert.ToInt32(row["PastoID"]);
                    animal.Piquete.Pasto.PastoDescricao = row["PastoDescricao"].ToString();
                    animal.Piquete.Pasto.PastoTamanho = Convert.ToDecimal(row["PastoTamanho"]);
                    animal.Piquete.Pasto.Cidade.CidadeID = Convert.ToInt32(row["CidadeID"]);
                    animal.Piquete.Pasto.Cidade.CidadeNome = row["CidadeNome"].ToString();
                    animal.Piquete.Pasto.Cidade.EstadoID = Convert.ToInt32(row["EstadoID"]);
                    animal.Piquete.Pasto.Cidade.EstadoSigla = row["EstadoSigla"].ToString();
                    animal.Piquete.Pasto.Cidade.EstadoNome = row["EstadoNome"].ToString();

                    animalCollection.Add(animal);
                }

                return animalCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public AnimalCollection ConsultaPorDescricao(string Descricao)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Descricao");
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", 0);
                acessoDadosSqlServer.AdicionarParametros("@AnimalDescricao", Descricao);
                acessoDadosSqlServer.AdicionarParametros("@AnimalIdentificador", "");
                acessoDadosSqlServer.AdicionarParametros("@RacaID", 0);
                acessoDadosSqlServer.AdicionarParametros("@PiqueteID", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaAnimal");

                AnimalCollection animalCollection = new AnimalCollection();
                PesagemNegocios pesagemNegocios = new PesagemNegocios();

                foreach (DataRow row in dataTable.Rows)
                {
                    Animal animal = new Animal();
                    animal.Piquete = new Piquete();
                    animal.Raca = new Raca();
                    animal.Pesagens = new PesagemCollection();
                    animal.AnimalParentescoPai = new Animal();
                    animal.AnimalParentescoMae = new Animal();
                    animal.Piquete.Pasto = new Pasto();
                    animal.Piquete.Pasto.Cidade = new Cidade();

                    animal.AnimalID = Convert.ToInt32(row["AnimalID"]);
                    animal.AnimalDescricao = row["AnimalDescricao"].ToString();

                    if(row["AnimalParentescoPai"] != DBNull.Value)
                        animal.AnimalParentescoPai.AnimalID = Convert.ToInt32(row["AnimalParentescoPai"]);

                    if (row["AnimalParentescoMae"] != DBNull.Value)
                        animal.AnimalParentescoMae.AnimalID = Convert.ToInt32(row["AnimalParentescoMae"]);

                    animal.AnimalLocalidadeNascimento = row["AnimalLocalidadeNascimento"].ToString();

                    if (row["AnimalDataNascimento"] != DBNull.Value)
                        animal.AnimalDataNascimento = Convert.ToDateTime(row["AnimalDataNascimento"]);

                    animal.AnimalIdentificador = row["AnimalIdentificador"].ToString();
                    animal.AnimalAtivo = Convert.ToBoolean(row["AnimalAtivo"]);
                    animal.Raca.RacaID = Convert.ToInt32(row["RacaID"]);
                    animal.Raca.RacaNome = row["RacaNome"].ToString();

                    animal.Pesagens = pesagemNegocios.ConsultaPorAnimal(animal.AnimalID);

                    animal.Piquete.PiqueteDescricao = row["PiqueteDescricao"].ToString();
                    animal.Piquete.Pasto.PastoDescricao = row["PastoDescricao"].ToString();

                    animalCollection.Add(animal);
                }

                return animalCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public AnimalCollection ConsultaPorIdentificador(string Identificador)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Ident");
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", 0);
                acessoDadosSqlServer.AdicionarParametros("@AnimalDescricao", "");
                acessoDadosSqlServer.AdicionarParametros("@AnimalIdentificador", Identificador);
                acessoDadosSqlServer.AdicionarParametros("@RacaID", 0);
                acessoDadosSqlServer.AdicionarParametros("@PiqueteID", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaAnimal");

                AnimalCollection animalCollection = new AnimalCollection();
                PesagemNegocios pesagemNegocios = new PesagemNegocios();

                foreach (DataRow row in dataTable.Rows)
                {
                    Animal animal = new Animal();
                    animal.Piquete = new Piquete();
                    animal.Raca = new Raca();
                    animal.Pesagens = new PesagemCollection();
                    animal.AnimalParentescoPai = new Animal();
                    animal.AnimalParentescoMae = new Animal();
                    animal.Piquete.Pasto = new Pasto();
                    animal.Piquete.Pasto.Cidade = new Cidade();

                    animal.AnimalID = Convert.ToInt32(row["AnimalID"]);
                    animal.AnimalDescricao = row["AnimalDescricao"].ToString();

                    if (row["AnimalParentescoPai"] != DBNull.Value)
                        animal.AnimalParentescoPai.AnimalID = Convert.ToInt32(row["AnimalParentescoPai"]);

                    if (row["AnimalParentescoMae"] != DBNull.Value)
                        animal.AnimalParentescoMae.AnimalID = Convert.ToInt32(row["AnimalParentescoMae"]);

                    animal.AnimalLocalidadeNascimento = row["AnimalLocalidadeNascimento"].ToString();

                    if (row["AnimalDataNascimento"] != DBNull.Value)
                        animal.AnimalDataNascimento = Convert.ToDateTime(row["AnimalDataNascimento"]);

                    animal.AnimalIdentificador = row["AnimalIdentificador"].ToString();
                    animal.AnimalAtivo = Convert.ToBoolean(row["AnimalAtivo"]);
                    animal.Raca.RacaID = Convert.ToInt32(row["RacaID"]);
                    animal.Raca.RacaNome = row["RacaNome"].ToString();

                    animal.Pesagens = pesagemNegocios.ConsultaPorAnimal(animal.AnimalID);

                    animal.Piquete.PiqueteDescricao = row["PiqueteDescricao"].ToString();
                    animal.Piquete.Pasto.PastoDescricao = row["PastoDescricao"].ToString();

                    animalCollection.Add(animal);
                }

                return animalCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public AnimalCollection ConsultaPorPiquete(int PiqueteID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Piquete");
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", 0);
                acessoDadosSqlServer.AdicionarParametros("@AnimalDescricao", "");
                acessoDadosSqlServer.AdicionarParametros("@AnimalIdentificador", "");
                acessoDadosSqlServer.AdicionarParametros("@RacaID", 0);
                acessoDadosSqlServer.AdicionarParametros("@PiqueteID", PiqueteID);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaAnimal");

                AnimalCollection animalCollection = new AnimalCollection();
                PesagemNegocios pesagemNegocios = new PesagemNegocios();

                foreach (DataRow row in dataTable.Rows)
                {
                    Animal animal = new Animal();
                    animal.Piquete = new Piquete();
                    animal.Raca = new Raca();
                    animal.Pesagens = new PesagemCollection();
                    animal.AnimalParentescoPai = new Animal();
                    animal.AnimalParentescoMae = new Animal();
                    animal.Piquete.Pasto = new Pasto();
                    animal.Piquete.Pasto.Cidade = new Cidade();

                    animal.AnimalID = Convert.ToInt32(row["AnimalID"]);
                    animal.AnimalDescricao = row["AnimalDescricao"].ToString();

                    if (row["AnimalParentescoPai"] != DBNull.Value)
                        animal.AnimalParentescoPai.AnimalID = Convert.ToInt32(row["AnimalParentescoPai"]);

                    if (row["AnimalParentescoMae"] != DBNull.Value)
                        animal.AnimalParentescoMae.AnimalID = Convert.ToInt32(row["AnimalParentescoMae"]);

                    animal.AnimalLocalidadeNascimento = row["AnimalLocalidadeNascimento"].ToString();

                    if (row["AnimalDataNascimento"] != DBNull.Value)
                        animal.AnimalDataNascimento = Convert.ToDateTime(row["AnimalDataNascimento"]);

                    animal.AnimalIdentificador = row["AnimalIdentificador"].ToString();
                    animal.AnimalAtivo = Convert.ToBoolean(row["AnimalAtivo"]);
                    animal.Raca.RacaID = Convert.ToInt32(row["RacaID"]);
                    animal.Raca.RacaNome = row["RacaNome"].ToString();

                    animal.Pesagens = pesagemNegocios.ConsultaPorAnimal(animal.AnimalID);

                    animal.Piquete.PiqueteDescricao = row["PiqueteDescricao"].ToString();
                    animal.Piquete.Pasto.PastoDescricao = row["PastoDescricao"].ToString();

                    animalCollection.Add(animal);
                }

                return animalCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public AnimalCollection ConsultaPorRaca(int RacaID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Raca");
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", 0);
                acessoDadosSqlServer.AdicionarParametros("@AnimalDescricao", "");
                acessoDadosSqlServer.AdicionarParametros("@AnimalIdentificador", "");
                acessoDadosSqlServer.AdicionarParametros("@RacaID", RacaID);
                acessoDadosSqlServer.AdicionarParametros("@PiqueteID", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaAnimal");

                AnimalCollection animalCollection = new AnimalCollection();
                PesagemNegocios pesagemNegocios = new PesagemNegocios();

                foreach (DataRow row in dataTable.Rows)
                {
                    Animal animal = new Animal();
                    animal.Piquete = new Piquete();
                    animal.Raca = new Raca();
                    animal.Pesagens = new PesagemCollection();
                    animal.AnimalParentescoPai = new Animal();
                    animal.AnimalParentescoMae = new Animal();
                    animal.Piquete.Pasto = new Pasto();
                    animal.Piquete.Pasto.Cidade = new Cidade();

                    animal.AnimalID = Convert.ToInt32(row["AnimalID"]);
                    animal.AnimalDescricao = row["AnimalDescricao"].ToString();

                    if (row["AnimalParentescoPai"] != DBNull.Value)
                        animal.AnimalParentescoPai.AnimalID = Convert.ToInt32(row["AnimalParentescoPai"]);

                    if (row["AnimalParentescoMae"] != DBNull.Value)
                        animal.AnimalParentescoMae.AnimalID = Convert.ToInt32(row["AnimalParentescoMae"]);

                    animal.AnimalLocalidadeNascimento = row["AnimalLocalidadeNascimento"].ToString();

                    if (row["AnimalDataNascimento"] != DBNull.Value)
                        animal.AnimalDataNascimento = Convert.ToDateTime(row["AnimalDataNascimento"]);

                    animal.AnimalIdentificador = row["AnimalIdentificador"].ToString();
                    animal.AnimalAtivo = Convert.ToBoolean(row["AnimalAtivo"]);
                    animal.Raca.RacaID = Convert.ToInt32(row["RacaID"]);
                    animal.Raca.RacaNome = row["RacaNome"].ToString();

                    animal.Pesagens = pesagemNegocios.ConsultaPorAnimal(animal.AnimalID);

                    animal.Piquete.PiqueteDescricao = row["PiqueteDescricao"].ToString();
                    animal.Piquete.Pasto.PastoDescricao = row["PastoDescricao"].ToString();

                    animalCollection.Add(animal);
                }

                return animalCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
