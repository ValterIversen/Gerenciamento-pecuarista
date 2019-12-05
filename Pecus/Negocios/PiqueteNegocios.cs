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
    public class PiqueteNegocios
    {
        //Instancio a classe de acesso ao banco de dados
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public int Cadastrar(Piquete piquete, int PastoID)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Inserir");
                acessoDadosSqlServer.AdicionarParametros("@PiqueteID", 0);
                acessoDadosSqlServer.AdicionarParametros("@PiqueteDescricao", piquete.PiqueteDescricao);
                acessoDadosSqlServer.AdicionarParametros("@PiqueteAtivo", piquete.PiqueteAtivo);
                acessoDadosSqlServer.AdicionarParametros("@PastoID", PastoID);


                piquete.PiqueteID = int.Parse(acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterPiquete"));

                if (piquete.Animais != null)
                {
                    foreach (Animal animal in piquete.Animais)
                    {
                        AnimalNegocios animalNegocios = new AnimalNegocios();
                        animal.Piquete.PiqueteID = piquete.PiqueteID;
                        animalNegocios.Alterar(animal);
                    }
                }

                return piquete.PiqueteID;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Alterar(Piquete piquete, AnimalCollection animaisTransferencia)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Alterar");
                acessoDadosSqlServer.AdicionarParametros("@PiqueteID", piquete.PiqueteID);
                acessoDadosSqlServer.AdicionarParametros("@PiqueteDescricao", piquete.PiqueteDescricao);
                acessoDadosSqlServer.AdicionarParametros("@PiqueteAtivo", piquete.PiqueteAtivo);
                acessoDadosSqlServer.AdicionarParametros("@PastoID", piquete.Pasto.PastoID);

                AnimalNegocios animalNegocios = new AnimalNegocios();
                if (piquete.Animais != null)
                {
                    foreach (Animal animal in piquete.Animais)
                    {
                        animalNegocios.Alterar(animal);
                    }
                }
                if (animaisTransferencia != null)
                {
                    foreach (Animal animal in animaisTransferencia)
                    {
                        animalNegocios.Alterar(animal);
                    }
                }

                acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterPiquete");

                return piquete.PiqueteID;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Excluir(int PiqueteID)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Excluir");
                acessoDadosSqlServer.AdicionarParametros("@PiqueteID", PiqueteID);
                acessoDadosSqlServer.AdicionarParametros("@PiqueteDescricao", "");
                acessoDadosSqlServer.AdicionarParametros("@PiqueteAtivo", 0);
                acessoDadosSqlServer.AdicionarParametros("@PastoID", 0);

                acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterPiquete");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public PiqueteCollection ConsultarPorID(int PiqueteID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "ID");
                acessoDadosSqlServer.AdicionarParametros("@PiqueteID", PiqueteID);
                acessoDadosSqlServer.AdicionarParametros("@PastoID", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaPiquete");

                PiqueteCollection piqueteCollection = new PiqueteCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Piquete piquete = new Piquete();
                    piquete.Pasto = new Pasto();

                    piquete.PiqueteID = Convert.ToInt32(row["PiqueteID"]);
                    piquete.PiqueteDescricao = row["PiqueteDescricao"].ToString();
                    piquete.PiqueteAtivo = Convert.ToBoolean(row["PiqueteAtivo"]);
                    piquete.Pasto.PastoID = Convert.ToInt32(row["PastoID"]);
                    piquete.PiqueteQuantidadeAnimais = Convert.ToInt32(row["PiqueteQuantidadeAnimais"]);

                    piqueteCollection.Add(piquete);
                }

                return piqueteCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public PiqueteCollection ConsultarPorPasto(int PastoID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Pasto");
                acessoDadosSqlServer.AdicionarParametros("@PiqueteID", 0);
                acessoDadosSqlServer.AdicionarParametros("@PastoID", PastoID);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaPiquete");

                PiqueteCollection piqueteCollection = new PiqueteCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Piquete piquete = new Piquete();
                    piquete.Pasto = new Pasto();

                    piquete.PiqueteID = Convert.ToInt32(row["PiqueteID"]);
                    piquete.PiqueteDescricao = row["PiqueteDescricao"].ToString();
                    piquete.PiqueteAtivo = Convert.ToBoolean(row["PiqueteAtivo"]);
                    piquete.Pasto.PastoID = Convert.ToInt32(row["PastoID"]);
                    piquete.PiqueteQuantidadeAnimais = Convert.ToInt32(row["PiqueteQuantidadeAnimais"]);

                    piqueteCollection.Add(piquete);
                }

                return piqueteCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
