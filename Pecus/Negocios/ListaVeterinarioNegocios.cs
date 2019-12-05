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
    public class ListaVeterinarioNegocios
    {
        //Instancio a classe de acesso ao banco de dados
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public int Cadastrar(ListaVeterinario listaVeterinario)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Inserir");
                acessoDadosSqlServer.AdicionarParametros("@ConsultaVeterinariaID", listaVeterinario.ConsultaVeterinaria.ConsultaVeterinariaID);
                acessoDadosSqlServer.AdicionarParametros("@VeterinarioID", listaVeterinario.Veterinario.VeterinarioID);

                return int.Parse(acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterListaVeterinario"));

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public VeterinarioCollection ConsultaPorConsultaVeterinaria(int ConsultaVeterinariaID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "ConsultaV");
                acessoDadosSqlServer.AdicionarParametros("@ConsultaVeterinariaID", ConsultaVeterinariaID);
                acessoDadosSqlServer.AdicionarParametros("@VeterinarioID", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaListaVeterinario");

                VeterinarioCollection veterinarioCollection = new VeterinarioCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Veterinario veterinario = new Veterinario();

                    veterinario.VeterinarioID = Convert.ToInt32(row["VeterinarioID"]);
                    veterinario.VeterinarioCRMV = row["VeterinarioCRMV"].ToString();
                    veterinario.VeterinarioBairro = row["VeterinarioBairro"].ToString();
                    veterinario.VeterinarioAtivo = Convert.ToBoolean(row["VeterinarioAtivo"]);
                    veterinario.VeterinarioTelefone = row["VeterinarioTelefone"].ToString();
                    veterinario.VeterinarioNome = row["VeterinarioNome"].ToString();
                    veterinario.VeterinarioEndereco = row["VeterinarioEndereco"].ToString();
                    veterinario.Cidade = new Cidade();
                    veterinario.Cidade.CidadeID = Convert.ToInt32(row["CidadeID"]);
                    veterinario.Cidade.CidadeNome = row["CidadeNome"].ToString();
                    veterinario.Cidade.EstadoID = Convert.ToInt32(row["EstadoID"]);
                    veterinario.Cidade.EstadoNome = row["EstadoNome"].ToString();
                    veterinario.Cidade.EstadoSigla = row["EstadoSigla"].ToString();

                    veterinarioCollection.Add(veterinario);
                }

                return veterinarioCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
