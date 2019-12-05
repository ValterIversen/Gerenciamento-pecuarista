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
    public class ListaCompraNegocios
    {
        //Instancio a classe de acesso ao banco de dados
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public int Cadastrar(ListaCompra listaCompra)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Inserir");
                acessoDadosSqlServer.AdicionarParametros("@ListaCompraID", 0);
                acessoDadosSqlServer.AdicionarParametros("@ListaCompraValor", listaCompra.Animal.AnimalValor);
                acessoDadosSqlServer.AdicionarParametros("@CompraID", listaCompra.CompraID);
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", listaCompra.Animal.AnimalID);

                return int.Parse(acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterListaCompra"));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(ListaCompra listaCompra)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Alterar");
                acessoDadosSqlServer.AdicionarParametros("@ListaCompraID", listaCompra.ListaCompraID);
                acessoDadosSqlServer.AdicionarParametros("@ListaCompraValor", listaCompra.ListaCompraValor);
                acessoDadosSqlServer.AdicionarParametros("@CompraID", listaCompra.CompraID);
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", listaCompra.Animal.AnimalID);

                acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterListaCompra");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Excluir(ListaCompra listaCompra)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Excluir");
                acessoDadosSqlServer.AdicionarParametros("@ListaCompraID", listaCompra.ListaCompraID);
                acessoDadosSqlServer.AdicionarParametros("@ListaCompraValor", 0);
                acessoDadosSqlServer.AdicionarParametros("@CompraID", 0);
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", 0);

                acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterListaCompra");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ListaCompraCollection ConsultaPorCompra(int CompraID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Compra");
                acessoDadosSqlServer.AdicionarParametros("@CompraID", CompraID);
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", "");

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaListaCompra");

                ListaCompraCollection listaCompraCollection = new ListaCompraCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    ListaCompra listaCompra = new ListaCompra();
                    listaCompra.Animal = new Animal();
                    listaCompra.Animal.Raca = new Raca();
                    listaCompra.ListaCompraID = Convert.ToInt32(row["ListaCompraID"]);
                    listaCompra.ListaCompraValor = Convert.ToDecimal(row["ListaCompraValor"]);
                    listaCompra.CompraID = Convert.ToInt32(row["CompraID"]);
                    listaCompra.Animal.AnimalID = Convert.ToInt32(row["AnimalID"]);
                    listaCompra.Animal.AnimalDescricao = row["AnimalDescricao"].ToString();
                    listaCompra.Animal.AnimalDataNascimento = Convert.ToDateTime(row["AnimalDataNascimento"]);
                    listaCompra.Animal.AnimalIdentificador = row["AnimalIdentificador"].ToString();
                    listaCompra.Animal.Raca.RacaNome = row["RacaNome"].ToString();

                    listaCompraCollection.Add(listaCompra);
                }

                return listaCompraCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ListaCompraCollection ConsultaPorAnimal(int AnimalID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Compra");
                acessoDadosSqlServer.AdicionarParametros("@CompraID", "");
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", AnimalID);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaListaCompra");

                ListaCompraCollection listaCompraCollection = new ListaCompraCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    ListaCompra listaCompra = new ListaCompra();
                    listaCompra.Animal = new Animal();
                    listaCompra.Animal.Raca = new Raca();
                    listaCompra.ListaCompraID = Convert.ToInt32(row["ListaCompraID"]);
                    listaCompra.ListaCompraValor = Convert.ToDecimal(row["ListaCompraValor"]);
                    listaCompra.CompraID = Convert.ToInt32(row["CompraID"]);
                    listaCompra.Animal.AnimalID = Convert.ToInt32(row["AnimalID"]);
                    listaCompra.Animal.AnimalDescricao = row["AnimalDescricao"].ToString();
                    listaCompra.Animal.AnimalDataNascimento = Convert.ToDateTime(row["AnimalDataNascimento"]);
                    listaCompra.Animal.AnimalIdentificador = row["AnimalIdentificador"].ToString();
                    listaCompra.Animal.Raca.RacaNome = row["RacaNome"].ToString();

                    listaCompraCollection.Add(listaCompra);
                }

                return listaCompraCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
