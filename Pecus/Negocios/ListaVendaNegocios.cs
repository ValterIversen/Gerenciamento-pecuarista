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
    public class ListaVendaNegocios
    {
        //Instancio a classe de acesso ao banco de dados
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public int Cadastrar(ListaVenda listaVenda)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Inserir");
                acessoDadosSqlServer.AdicionarParametros("@ListaVendaID", 0);
                acessoDadosSqlServer.AdicionarParametros("@ListaVendaValor", listaVenda.Animal.AnimalValor);
                acessoDadosSqlServer.AdicionarParametros("@VendaID", listaVenda.VendaID);
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", listaVenda.Animal.AnimalID);

                return int.Parse(acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterListaVenda"));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(ListaVenda listaVenda)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Alterar");
                acessoDadosSqlServer.AdicionarParametros("@ListaVendaID", listaVenda.ListaVendaID);
                acessoDadosSqlServer.AdicionarParametros("@ListaVendaValor", listaVenda.ListaVendaValor);
                acessoDadosSqlServer.AdicionarParametros("@VendaID", listaVenda.VendaID);
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", listaVenda.Animal.AnimalID);

                acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterListaVenda");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Excluir(ListaVenda listaVenda)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Excluir");
                acessoDadosSqlServer.AdicionarParametros("@ListaVendaID", listaVenda.ListaVendaID);
                acessoDadosSqlServer.AdicionarParametros("@ListaVendaValor", 0);
                acessoDadosSqlServer.AdicionarParametros("@VendaID", 0);
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", 0);

                acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterListaVenda");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ListaVendaCollection ConsultaPorVenda(int VendaID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Venda");
                acessoDadosSqlServer.AdicionarParametros("@VendaID", VendaID);
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", "");

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaListaVenda");

                ListaVendaCollection listaVendaCollection = new ListaVendaCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    ListaVenda listaVenda = new ListaVenda();
                    listaVenda.Animal = new Animal();
                    listaVenda.Animal.Raca = new Raca();
                    listaVenda.ListaVendaID = Convert.ToInt32(row["ListaVendaID"]);
                    listaVenda.ListaVendaValor = Convert.ToDecimal(row["ListaVendaValor"]);
                    listaVenda.VendaID = Convert.ToInt32(row["VendaID"]);
                    listaVenda.Animal.AnimalID = Convert.ToInt32(row["AnimalID"]);
                    listaVenda.Animal.AnimalDescricao = row["AnimalDescricao"].ToString();
                    listaVenda.Animal.AnimalDataNascimento = Convert.ToDateTime(row["AnimalDataNascimento"]);
                    listaVenda.Animal.AnimalIdentificador = row["AnimalIdentificador"].ToString();
                    listaVenda.Animal.Raca.RacaNome = row["RacaNome"].ToString();

                    listaVendaCollection.Add(listaVenda);
                }

                return listaVendaCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ListaVendaCollection ConsultaPorAnimal(int AnimalID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Venda");
                acessoDadosSqlServer.AdicionarParametros("@VendaID", "");
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", AnimalID);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaListaVenda");

                ListaVendaCollection listaVendaCollection = new ListaVendaCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    ListaVenda listaVenda = new ListaVenda();
                    listaVenda.Animal = new Animal();
                    listaVenda.Animal.Raca = new Raca();
                    listaVenda.ListaVendaID = Convert.ToInt32(row["ListaVendaID"]);
                    listaVenda.ListaVendaValor = Convert.ToDecimal(row["ListaVendaValor"]);
                    listaVenda.VendaID = Convert.ToInt32(row["VendaID"]);
                    listaVenda.Animal.AnimalID = Convert.ToInt32(row["AnimalID"]);
                    listaVenda.Animal.AnimalDescricao = row["AnimalDescricao"].ToString();
                    listaVenda.Animal.AnimalDataNascimento = Convert.ToDateTime(row["AnimalDataNascimento"]);
                    listaVenda.Animal.AnimalIdentificador = row["AnimalIdentificador"].ToString();
                    listaVenda.Animal.Raca.RacaNome = row["RacaNome"].ToString();

                    listaVendaCollection.Add(listaVenda);
                }

                return listaVendaCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
