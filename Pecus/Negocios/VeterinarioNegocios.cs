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
    public class VeterinarioNegocios
    {
        //Instancio a classe de acesso ao banco de dados
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public int Cadastrar(Veterinario veterinario)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Inserir");
                acessoDadosSqlServer.AdicionarParametros("@VeterinarioID", 0);
                acessoDadosSqlServer.AdicionarParametros("@VeterinarioCRMV", veterinario.VeterinarioCRMV);
                acessoDadosSqlServer.AdicionarParametros("@VeterinarioNome", veterinario.VeterinarioNome);
                acessoDadosSqlServer.AdicionarParametros("@VeterinarioTelefone", veterinario.VeterinarioTelefone);
                acessoDadosSqlServer.AdicionarParametros("@VeterinarioBairro", veterinario.VeterinarioBairro);
                acessoDadosSqlServer.AdicionarParametros("@VeterinarioEndereco", veterinario.VeterinarioEndereco);
                acessoDadosSqlServer.AdicionarParametros("@VeterinarioAtivo", true);
                acessoDadosSqlServer.AdicionarParametros("@CidadeID", veterinario.Cidade.CidadeID);

                return int.Parse(acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterVeterinario"));

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(Veterinario veterinario)
        {
            try
            {
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Alterar");
                acessoDadosSqlServer.AdicionarParametros("@VeterinarioID", veterinario.VeterinarioID);
                acessoDadosSqlServer.AdicionarParametros("@VeterinarioCRMV", veterinario.VeterinarioCRMV);
                acessoDadosSqlServer.AdicionarParametros("@VeterinarioNome", veterinario.VeterinarioNome);
                acessoDadosSqlServer.AdicionarParametros("@VeterinarioTelefone", veterinario.VeterinarioTelefone);
                acessoDadosSqlServer.AdicionarParametros("@VeterinarioBairro", veterinario.VeterinarioBairro);
                acessoDadosSqlServer.AdicionarParametros("@VeterinarioEndereco", veterinario.VeterinarioEndereco);
                acessoDadosSqlServer.AdicionarParametros("@VeterinarioAtivo", veterinario.VeterinarioAtivo);
                acessoDadosSqlServer.AdicionarParametros("@CidadeID", veterinario.Cidade.CidadeID);

                acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterVeterinario");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public VeterinarioCollection ConsultaPorNome(string Nome)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Nome");
                acessoDadosSqlServer.AdicionarParametros("@VeterinarioNome", Nome);
                acessoDadosSqlServer.AdicionarParametros("@VeterinarioID", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaVeterinario");

                VeterinarioCollection veterinarioCollection = new VeterinarioCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Veterinario veterinario = new Veterinario();
                    veterinario.Cidade = new Cidade();
                    veterinario.VeterinarioID = Convert.ToInt32(row["VeterinarioID"]);
                    veterinario.VeterinarioCRMV = row["VeterinarioCRMV"].ToString();
                    veterinario.VeterinarioNome = row["VeterinarioNome"].ToString();
                    veterinario.VeterinarioTelefone = row["VeterinarioTelefone"].ToString();
                    veterinario.VeterinarioBairro = row["VeterinarioBairro"].ToString();
                    veterinario.VeterinarioEndereco = row["VeterinarioEndereco"].ToString();
                    veterinario.VeterinarioAtivo = Convert.ToBoolean(row["VeterinarioAtivo"]);
                    veterinario.Cidade.CidadeID = Convert.ToInt32(row["CidadeID"]);
                    veterinario.Cidade.CidadeNome = row["CidadeNome"].ToString();
                    veterinario.Cidade.EstadoID = Convert.ToInt32(row["EstadoID"]);
                    veterinario.Cidade.EstadoSigla = row["EstadoSigla"].ToString();
                    veterinario.Cidade.EstadoNome = row["EstadoNome"].ToString();

                    veterinarioCollection.Add(veterinario);
                }

                return veterinarioCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public VeterinarioCollection ConsultaPorID(int ID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "ID");
                acessoDadosSqlServer.AdicionarParametros("@VeterinarioNome", "");
                acessoDadosSqlServer.AdicionarParametros("@VeterinarioID", ID);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaVeterinario");

                VeterinarioCollection veterinarioCollection = new VeterinarioCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Veterinario veterinario = new Veterinario();
                    veterinario.Cidade = new Cidade();
                    veterinario.VeterinarioID = Convert.ToInt32(row["VeterinarioID"]);
                    veterinario.VeterinarioCRMV = row["VeterinarioCRMV"].ToString();
                    veterinario.VeterinarioNome = row["VeterinarioNome"].ToString();
                    veterinario.VeterinarioTelefone = row["VeterinarioTelefone"].ToString();
                    veterinario.VeterinarioBairro = row["VeterinarioBairro"].ToString();
                    veterinario.VeterinarioEndereco = row["VeterinarioEndereco"].ToString();
                    veterinario.VeterinarioAtivo = Convert.ToBoolean(row["VeterinarioAtivo"]);
                    veterinario.Cidade.CidadeID = Convert.ToInt32(row["CidadeID"]);
                    veterinario.Cidade.CidadeNome = row["CidadeNome"].ToString();
                    veterinario.Cidade.EstadoID = Convert.ToInt32(row["EstadoID"]);
                    veterinario.Cidade.EstadoSigla = row["EstadoSigla"].ToString();
                    veterinario.Cidade.EstadoNome = row["EstadoNome"].ToString();

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
