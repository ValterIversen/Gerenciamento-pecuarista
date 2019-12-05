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
    public class CidadeEstagoNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public Cidade ConsultaCidadePorID(int ID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "ID");
                acessoDadosSqlServer.AdicionarParametros("@CidadeID", ID);
                acessoDadosSqlServer.AdicionarParametros("@EstadoID", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaCidade");

                foreach (DataRow row in dataTable.Rows)
                {
                    Cidade cidade = new Cidade();

                    cidade.CidadeID = Convert.ToInt32(row["CidadeID"]);
                    cidade.CidadeNome = row["CidadeNome"].ToString();
                    cidade.EstadoID = Convert.ToInt32(row["EstadoID"]);

                    return cidade;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public CidadeCollection ConsultaCidadePorEstado(int ID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Estado");
                acessoDadosSqlServer.AdicionarParametros("@CidadeID", 0);
                acessoDadosSqlServer.AdicionarParametros("@EstadoID", ID);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaCidade");

                CidadeCollection cidadeCollection = new CidadeCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Cidade cidade = new Cidade();

                    cidade.CidadeID= Convert.ToInt32(row["CidadeID"]);
                    cidade.CidadeNome = row["CidadeNome"].ToString();
                    cidade.EstadoID = Convert.ToInt32(row["EstadoID"]);

                    cidadeCollection.Add(cidade);
                }

                return cidadeCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Estado ConsultaEstadoPorID(int ID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "ID");
                acessoDadosSqlServer.AdicionarParametros("@EstadoID", ID);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaEstado");

                foreach (DataRow row in dataTable.Rows)
                {
                    Estado estado = new Estado();

                    estado.EstadoID = Convert.ToInt32(row["EstadoID"]);
                    estado.EstadoNome = row["EstadoNome"].ToString();
                    estado.EstadoSigla = row["EstadoSigla"].ToString();

                    return estado;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public EstadoCollection ConsultaEstadoTodos()
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Todos");
                acessoDadosSqlServer.AdicionarParametros("@EstadoID", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaEstado");

                EstadoCollection estadoCollection = new EstadoCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Estado estado = new Estado();

                    estado.EstadoID = Convert.ToInt32(row["EstadoID"]);
                    estado.EstadoNome = row["EstadoNome"].ToString();
                    estado.EstadoSigla = row["EstadoSigla"].ToString();

                    estadoCollection.Add(estado);
                }

                return estadoCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
