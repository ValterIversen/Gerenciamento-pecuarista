using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AcessoBancoDados;
using ObjetoTransferencia;
using System.Data;

namespace Negocios
{
    public class TipoUsuarioNegocios
    {
        //Instancio a classe de acesso ao banco de dados
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public TipoUsuarioCollection ConsultarTodos()
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Descricao");
                acessoDadosSqlServer.AdicionarParametros("@TipoUsuarioID", "");
                acessoDadosSqlServer.AdicionarParametros("@TipoUsuarioDescricao", "");

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaTipoUsuario");

                TipoUsuarioCollection tipoUsuarioCollection = new TipoUsuarioCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    TipoUsuario tipoUsuario = new TipoUsuario();
                    tipoUsuario.TipoUsuarioID = Convert.ToInt32(row["TipoUsuarioID"]);
                    tipoUsuario.TipoUsuarioDescricao = row["TipoUsuarioDescricao"].ToString();

                    tipoUsuarioCollection.Add(tipoUsuario);
                }

                return tipoUsuarioCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
