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
    public class ConsultaVeterinariaNegocios
    {
        //Instancio a classe de acesso ao banco de dados
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public int Cadastrar(ConsultaVeterinaria consultaVeterinaria)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Inserir");
                acessoDadosSqlServer.AdicionarParametros("@ConsultaVeterinariaID", 0);
                acessoDadosSqlServer.AdicionarParametros("@ConsultaVeterinariaData", consultaVeterinaria.ConsultaVeterinariaData);
                acessoDadosSqlServer.AdicionarParametros("@ConsultaVeterinariaDescricao", consultaVeterinaria.ConsultaVeterinariaDescricao);
                acessoDadosSqlServer.AdicionarParametros("@ConsultaVeterinariaCusto", consultaVeterinaria.ConsultaVeterinariaCusto);
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", consultaVeterinaria.Animal.AnimalID);

                consultaVeterinaria.ConsultaVeterinariaID = int.Parse(acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterConsultaVeterinaria"));

                ListaVeterinarioNegocios listaVeterinarioNegocios = new ListaVeterinarioNegocios();

                foreach (Veterinario veterinario in consultaVeterinaria.Veterinarios)
                {
                    ListaVeterinario listaVeterinario = new ListaVeterinario();
                    listaVeterinario.Veterinario = veterinario;
                    listaVeterinario.ConsultaVeterinaria = consultaVeterinaria;
                    listaVeterinarioNegocios.Cadastrar(listaVeterinario);
                }
                return consultaVeterinaria.ConsultaVeterinariaID;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(ConsultaVeterinaria consultaVeterinaria)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Alterar");
                acessoDadosSqlServer.AdicionarParametros("@ConsultaVeterinariaID", consultaVeterinaria.ConsultaVeterinariaID);
                acessoDadosSqlServer.AdicionarParametros("@ConsultaVeterinariaData", consultaVeterinaria.ConsultaVeterinariaData);
                acessoDadosSqlServer.AdicionarParametros("@ConsultaVeterinariaDescricao", consultaVeterinaria.ConsultaVeterinariaDescricao);
                acessoDadosSqlServer.AdicionarParametros("@ConsultaVeterinariaCusto", consultaVeterinaria.ConsultaVeterinariaCusto);
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", consultaVeterinaria.Animal.AnimalID);

                acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterConsultaVeterinaria");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public ConsultaVeterinariaCollection ConsultaPorID(int ConsultaVeterinariaID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "ID");
                acessoDadosSqlServer.AdicionarParametros("@ConsultaVeterinariaID", ConsultaVeterinariaID);
                acessoDadosSqlServer.AdicionarParametros("@ConsultaVeterinariaData", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@ConsultaVeterinariaData2", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@ConsultaVeterinariaDescricao", "");
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", 0);
                acessoDadosSqlServer.AdicionarParametros("@VeterinarioID", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaConsultaVeterinario");

                ConsultaVeterinariaCollection consultaVeterinariaCollection = new ConsultaVeterinariaCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    ConsultaVeterinaria consultaVeterinaria = new ConsultaVeterinaria();
                    consultaVeterinaria.Animal = new Animal();
                    consultaVeterinaria.Veterinarios = new VeterinarioCollection();
                    consultaVeterinaria.ConsultaVeterinariaID = Convert.ToInt32(row["ConsultaVeterinariaID"]);
                    consultaVeterinaria.ConsultaVeterinariaData = Convert.ToDateTime(row["ConsultaVeterinariaData"]);
                    consultaVeterinaria.ConsultaVeterinariaDescricao = row["ConsultaVeterinariaDescricao"].ToString();
                    consultaVeterinaria.ConsultaVeterinariaCusto = Convert.ToDecimal(row["ConsultaVeterinariaCusto"]);

                    consultaVeterinaria.Animal.AnimalID = Convert.ToInt32(row["AnimalID"]);
                    consultaVeterinaria.Animal.AnimalDescricao = row["AnimalDescricao"].ToString();
                    consultaVeterinaria.Animal.AnimalLocalidadeNascimento = row["AnimalLocalidadeNascimento"].ToString();
                    consultaVeterinaria.Animal.AnimalDataNascimento = Convert.ToDateTime(row["AnimalDataNascimento"]);
                    consultaVeterinaria.Animal.AnimalIdentificador = row["AnimalIdentificador"].ToString();
                    consultaVeterinaria.Animal.AnimalAtivo = Convert.ToBoolean(row["AnimalAtivo"]);

                    consultaVeterinaria.Animal.Piquete = new Piquete();
                    consultaVeterinaria.Animal.Piquete.PiqueteID = Convert.ToInt32(row["PiqueteID"]);

                    consultaVeterinaria.Animal.Raca = new Raca();
                    consultaVeterinaria.Animal.Raca.RacaID = Convert.ToInt32(row["RacaID"]);
                    consultaVeterinaria.Animal.Raca.RacaNome = row["RacaNome"].ToString();
                    consultaVeterinaria.Animal.Raca.RacaDescricao = row["RacaDescricao"].ToString();

                    consultaVeterinariaCollection.Add(consultaVeterinaria);
                }

                return consultaVeterinariaCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ConsultaVeterinariaCollection ConsultaPorAnimal(int AnimalID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Animal");
                acessoDadosSqlServer.AdicionarParametros("@ConsultaVeterinariaID", 0);
                acessoDadosSqlServer.AdicionarParametros("@ConsultaVeterinariaData", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@ConsultaVeterinariaData2", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@ConsultaVeterinariaDescricao", "");
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", AnimalID);
                acessoDadosSqlServer.AdicionarParametros("@VeterinarioID", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaConsultaVeterinario");

                ConsultaVeterinariaCollection consultaVeterinariaCollection = new ConsultaVeterinariaCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    ConsultaVeterinaria consultaVeterinaria = new ConsultaVeterinaria();
                    consultaVeterinaria.Animal = new Animal();
                    consultaVeterinaria.Veterinarios = new VeterinarioCollection();
                    consultaVeterinaria.ConsultaVeterinariaID = Convert.ToInt32(row["ConsultaVeterinariaID"]);
                    consultaVeterinaria.ConsultaVeterinariaData = Convert.ToDateTime(row["ConsultaVeterinariaData"]);
                    consultaVeterinaria.ConsultaVeterinariaDescricao = row["ConsultaVeterinariaDescricao"].ToString();
                    consultaVeterinaria.ConsultaVeterinariaCusto = Convert.ToDecimal(row["ConsultaVeterinariaCusto"]);

                    consultaVeterinaria.Animal.AnimalID = Convert.ToInt32(row["AnimalID"]);
                    consultaVeterinaria.Animal.AnimalDescricao = row["AnimalDescricao"].ToString();
                    consultaVeterinaria.Animal.AnimalLocalidadeNascimento = row["AnimalLocalidadeNascimento"].ToString();
                    consultaVeterinaria.Animal.AnimalDataNascimento = Convert.ToDateTime(row["AnimalDataNascimento"]);
                    consultaVeterinaria.Animal.AnimalIdentificador = row["AnimalIdentificador"].ToString();
                    consultaVeterinaria.Animal.AnimalAtivo = Convert.ToBoolean(row["AnimalAtivo"]);

                    consultaVeterinaria.Animal.Piquete = new Piquete();
                    consultaVeterinaria.Animal.Piquete.PiqueteID = Convert.ToInt32(row["PiqueteID"]);

                    consultaVeterinaria.Animal.Raca = new Raca();
                    consultaVeterinaria.Animal.Raca.RacaID = Convert.ToInt32(row["RacaID"]);
                    consultaVeterinaria.Animal.Raca.RacaNome = row["RacaNome"].ToString();
                    consultaVeterinaria.Animal.Raca.RacaDescricao = row["RacaDescricao"].ToString();

                    consultaVeterinariaCollection.Add(consultaVeterinaria);
                }

                return consultaVeterinariaCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ConsultaVeterinariaCollection ConsultaPorDataEntre(DateTime data1, DateTime data2)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "DataEntre");
                acessoDadosSqlServer.AdicionarParametros("@ConsultaVeterinariaID", 0);
                acessoDadosSqlServer.AdicionarParametros("@ConsultaVeterinariaData", data1);
                acessoDadosSqlServer.AdicionarParametros("@ConsultaVeterinariaData2", data2);
                acessoDadosSqlServer.AdicionarParametros("@ConsultaVeterinariaDescricao", "");
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", 0);
                acessoDadosSqlServer.AdicionarParametros("@VeterinarioID", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaConsultaVeterinario");

                ConsultaVeterinariaCollection consultaVeterinariaCollection = new ConsultaVeterinariaCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    ConsultaVeterinaria consultaVeterinaria = new ConsultaVeterinaria();
                    consultaVeterinaria.Animal = new Animal();
                    consultaVeterinaria.Veterinarios = new VeterinarioCollection();
                    consultaVeterinaria.ConsultaVeterinariaID = Convert.ToInt32(row["ConsultaVeterinariaID"]);
                    consultaVeterinaria.ConsultaVeterinariaData = Convert.ToDateTime(row["ConsultaVeterinariaData"]);
                    consultaVeterinaria.ConsultaVeterinariaDescricao = row["ConsultaVeterinariaDescricao"].ToString();
                    consultaVeterinaria.ConsultaVeterinariaCusto = Convert.ToDecimal(row["ConsultaVeterinariaCusto"]);

                    consultaVeterinaria.Animal.AnimalID = Convert.ToInt32(row["AnimalID"]);
                    consultaVeterinaria.Animal.AnimalDescricao = row["AnimalDescricao"].ToString();
                    consultaVeterinaria.Animal.AnimalLocalidadeNascimento = row["AnimalLocalidadeNascimento"].ToString();
                    consultaVeterinaria.Animal.AnimalDataNascimento = Convert.ToDateTime(row["AnimalDataNascimento"]);
                    consultaVeterinaria.Animal.AnimalIdentificador = row["AnimalIdentificador"].ToString();
                    consultaVeterinaria.Animal.AnimalAtivo = Convert.ToBoolean(row["AnimalAtivo"]);

                    consultaVeterinaria.Animal.Piquete = new Piquete();
                    consultaVeterinaria.Animal.Piquete.PiqueteID = Convert.ToInt32(row["PiqueteID"]);

                    consultaVeterinaria.Animal.Raca = new Raca();
                    consultaVeterinaria.Animal.Raca.RacaID = Convert.ToInt32(row["RacaID"]);
                    consultaVeterinaria.Animal.Raca.RacaNome = row["RacaNome"].ToString();
                    consultaVeterinaria.Animal.Raca.RacaDescricao = row["RacaDescricao"].ToString();

                    consultaVeterinariaCollection.Add(consultaVeterinaria);
                }

                return consultaVeterinariaCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ConsultaVeterinariaCollection ConsultaPorDataApos(DateTime data)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "DataApos");
                acessoDadosSqlServer.AdicionarParametros("@ConsultaVeterinariaID", 0);
                acessoDadosSqlServer.AdicionarParametros("@ConsultaVeterinariaData", data);
                acessoDadosSqlServer.AdicionarParametros("@ConsultaVeterinariaData2", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@ConsultaVeterinariaDescricao", "");
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", 0);
                acessoDadosSqlServer.AdicionarParametros("@VeterinarioID", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaConsultaVeterinario");

                ConsultaVeterinariaCollection consultaVeterinariaCollection = new ConsultaVeterinariaCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    ConsultaVeterinaria consultaVeterinaria = new ConsultaVeterinaria();
                    consultaVeterinaria.Animal = new Animal();
                    consultaVeterinaria.Veterinarios = new VeterinarioCollection();
                    consultaVeterinaria.ConsultaVeterinariaID = Convert.ToInt32(row["ConsultaVeterinariaID"]);
                    consultaVeterinaria.ConsultaVeterinariaData = Convert.ToDateTime(row["ConsultaVeterinariaData"]);
                    consultaVeterinaria.ConsultaVeterinariaDescricao = row["ConsultaVeterinariaDescricao"].ToString();
                    consultaVeterinaria.ConsultaVeterinariaCusto = Convert.ToDecimal(row["ConsultaVeterinariaCusto"]);

                    consultaVeterinaria.Animal.AnimalID = Convert.ToInt32(row["AnimalID"]);
                    consultaVeterinaria.Animal.AnimalDescricao = row["AnimalDescricao"].ToString();
                    consultaVeterinaria.Animal.AnimalLocalidadeNascimento = row["AnimalLocalidadeNascimento"].ToString();
                    consultaVeterinaria.Animal.AnimalDataNascimento = Convert.ToDateTime(row["AnimalDataNascimento"]);
                    consultaVeterinaria.Animal.AnimalIdentificador = row["AnimalIdentificador"].ToString();
                    consultaVeterinaria.Animal.AnimalAtivo = Convert.ToBoolean(row["AnimalAtivo"]);

                    consultaVeterinaria.Animal.Piquete = new Piquete();
                    consultaVeterinaria.Animal.Piquete.PiqueteID = Convert.ToInt32(row["PiqueteID"]);

                    consultaVeterinaria.Animal.Raca = new Raca();
                    consultaVeterinaria.Animal.Raca.RacaID = Convert.ToInt32(row["RacaID"]);
                    consultaVeterinaria.Animal.Raca.RacaNome = row["RacaNome"].ToString();
                    consultaVeterinaria.Animal.Raca.RacaDescricao = row["RacaDescricao"].ToString();

                    consultaVeterinariaCollection.Add(consultaVeterinaria);
                }

                return consultaVeterinariaCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ConsultaVeterinariaCollection ConsultaPorDataAntes(DateTime data)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "DataAntes");
                acessoDadosSqlServer.AdicionarParametros("@ConsultaVeterinariaID", 0);
                acessoDadosSqlServer.AdicionarParametros("@ConsultaVeterinariaData", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@ConsultaVeterinariaData2", data);
                acessoDadosSqlServer.AdicionarParametros("@ConsultaVeterinariaDescricao", "");
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", 0);
                acessoDadosSqlServer.AdicionarParametros("@VeterinarioID", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaConsultaVeterinario");

                ConsultaVeterinariaCollection consultaVeterinariaCollection = new ConsultaVeterinariaCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    ConsultaVeterinaria consultaVeterinaria = new ConsultaVeterinaria();
                    consultaVeterinaria.Animal = new Animal();
                    consultaVeterinaria.Veterinarios = new VeterinarioCollection();
                    consultaVeterinaria.ConsultaVeterinariaID = Convert.ToInt32(row["ConsultaVeterinariaID"]);
                    consultaVeterinaria.ConsultaVeterinariaData = Convert.ToDateTime(row["ConsultaVeterinariaData"]);
                    consultaVeterinaria.ConsultaVeterinariaDescricao = row["ConsultaVeterinariaDescricao"].ToString();
                    consultaVeterinaria.ConsultaVeterinariaCusto = Convert.ToDecimal(row["ConsultaVeterinariaCusto"]);

                    consultaVeterinaria.Animal.AnimalID = Convert.ToInt32(row["AnimalID"]);
                    consultaVeterinaria.Animal.AnimalDescricao = row["AnimalDescricao"].ToString();
                    consultaVeterinaria.Animal.AnimalLocalidadeNascimento = row["AnimalLocalidadeNascimento"].ToString();
                    consultaVeterinaria.Animal.AnimalDataNascimento = Convert.ToDateTime(row["AnimalDataNascimento"]);
                    consultaVeterinaria.Animal.AnimalIdentificador = row["AnimalIdentificador"].ToString();
                    consultaVeterinaria.Animal.AnimalAtivo = Convert.ToBoolean(row["AnimalAtivo"]);

                    consultaVeterinaria.Animal.Piquete = new Piquete();
                    consultaVeterinaria.Animal.Piquete.PiqueteID = Convert.ToInt32(row["PiqueteID"]);

                    consultaVeterinaria.Animal.Raca = new Raca();
                    consultaVeterinaria.Animal.Raca.RacaID = Convert.ToInt32(row["RacaID"]);
                    consultaVeterinaria.Animal.Raca.RacaNome = row["RacaNome"].ToString();
                    consultaVeterinaria.Animal.Raca.RacaDescricao = row["RacaDescricao"].ToString();

                    consultaVeterinariaCollection.Add(consultaVeterinaria);
                }

                return consultaVeterinariaCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ConsultaVeterinariaCollection ConsultaPorDescricao(string Descricao)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Descricao");
                acessoDadosSqlServer.AdicionarParametros("@ConsultaVeterinariaID", 0);
                acessoDadosSqlServer.AdicionarParametros("@ConsultaVeterinariaData", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@ConsultaVeterinariaData2", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@ConsultaVeterinariaDescricao", Descricao);
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", 0);
                acessoDadosSqlServer.AdicionarParametros("@VeterinarioID", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaConsultaVeterinario");

                ConsultaVeterinariaCollection consultaVeterinariaCollection = new ConsultaVeterinariaCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    ConsultaVeterinaria consultaVeterinaria = new ConsultaVeterinaria();
                    consultaVeterinaria.Animal = new Animal();
                    consultaVeterinaria.Veterinarios = new VeterinarioCollection();
                    consultaVeterinaria.ConsultaVeterinariaID = Convert.ToInt32(row["ConsultaVeterinariaID"]);
                    consultaVeterinaria.ConsultaVeterinariaData = Convert.ToDateTime(row["ConsultaVeterinariaData"]);
                    consultaVeterinaria.ConsultaVeterinariaDescricao = row["ConsultaVeterinariaDescricao"].ToString();
                    consultaVeterinaria.ConsultaVeterinariaCusto = Convert.ToDecimal(row["ConsultaVeterinariaCusto"]);

                    consultaVeterinaria.Animal.AnimalID = Convert.ToInt32(row["AnimalID"]);
                    consultaVeterinaria.Animal.AnimalDescricao = row["AnimalDescricao"].ToString();
                    consultaVeterinaria.Animal.AnimalLocalidadeNascimento = row["AnimalLocalidadeNascimento"].ToString();
                    consultaVeterinaria.Animal.AnimalDataNascimento = Convert.ToDateTime(row["AnimalDataNascimento"]);
                    consultaVeterinaria.Animal.AnimalIdentificador = row["AnimalIdentificador"].ToString();
                    consultaVeterinaria.Animal.AnimalAtivo = Convert.ToBoolean(row["AnimalAtivo"]);

                    consultaVeterinaria.Animal.Piquete = new Piquete();
                    consultaVeterinaria.Animal.Piquete.PiqueteID = Convert.ToInt32(row["PiqueteID"]);

                    consultaVeterinaria.Animal.Raca = new Raca();
                    consultaVeterinaria.Animal.Raca.RacaID = Convert.ToInt32(row["RacaID"]);
                    consultaVeterinaria.Animal.Raca.RacaNome = row["RacaNome"].ToString();
                    consultaVeterinaria.Animal.Raca.RacaDescricao = row["RacaDescricao"].ToString();

                    consultaVeterinariaCollection.Add(consultaVeterinaria);
                }

                return consultaVeterinariaCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ConsultaVeterinariaCollection ConsultaPorVeterinario(int VeterinarioID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Vet");
                acessoDadosSqlServer.AdicionarParametros("@ConsultaVeterinariaID", 0);
                acessoDadosSqlServer.AdicionarParametros("@ConsultaVeterinariaData", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@ConsultaVeterinariaData2", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@ConsultaVeterinariaDescricao", "");
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", 0);
                acessoDadosSqlServer.AdicionarParametros("@VeterinarioID", VeterinarioID);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaConsultaVeterinario");

                ConsultaVeterinariaCollection consultaVeterinariaCollection = new ConsultaVeterinariaCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    ConsultaVeterinaria consultaVeterinaria = new ConsultaVeterinaria();
                    consultaVeterinaria.Animal = new Animal();
                    consultaVeterinaria.Veterinarios = new VeterinarioCollection();
                    consultaVeterinaria.ConsultaVeterinariaID = Convert.ToInt32(row["ConsultaVeterinariaID"]);
                    consultaVeterinaria.ConsultaVeterinariaData = Convert.ToDateTime(row["ConsultaVeterinariaData"]);
                    consultaVeterinaria.ConsultaVeterinariaDescricao = row["ConsultaVeterinariaDescricao"].ToString();
                    consultaVeterinaria.ConsultaVeterinariaCusto = Convert.ToDecimal(row["ConsultaVeterinariaCusto"]);

                    consultaVeterinaria.Animal.AnimalID = Convert.ToInt32(row["AnimalID"]);
                    consultaVeterinaria.Animal.AnimalDescricao = row["AnimalDescricao"].ToString();
                    consultaVeterinaria.Animal.AnimalLocalidadeNascimento = row["AnimalLocalidadeNascimento"].ToString();
                    consultaVeterinaria.Animal.AnimalDataNascimento = Convert.ToDateTime(row["AnimalDataNascimento"]);
                    consultaVeterinaria.Animal.AnimalIdentificador = row["AnimalIdentificador"].ToString();
                    consultaVeterinaria.Animal.AnimalAtivo = Convert.ToBoolean(row["AnimalAtivo"]);

                    consultaVeterinaria.Animal.Piquete = new Piquete();
                    consultaVeterinaria.Animal.Piquete.PiqueteID = Convert.ToInt32(row["PiqueteID"]);

                    consultaVeterinaria.Animal.Raca = new Raca();
                    consultaVeterinaria.Animal.Raca.RacaID = Convert.ToInt32(row["RacaID"]);
                    consultaVeterinaria.Animal.Raca.RacaNome = row["RacaNome"].ToString();
                    consultaVeterinaria.Animal.Raca.RacaDescricao = row["RacaDescricao"].ToString();

                    consultaVeterinariaCollection.Add(consultaVeterinaria);
                }

                return consultaVeterinariaCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
