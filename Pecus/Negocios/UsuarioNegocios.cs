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
    public class UsuarioNegocios
    {
        //Instancio a classe de acesso ao banco de dados
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public int Cadastrar(Usuario usuario)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Inserir");
                acessoDadosSqlServer.AdicionarParametros("@UsuarioID", usuario.UsuarioID);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioLogin", usuario.UsuarioLogin);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioSenha", usuario.UsuarioSenha);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioNome", usuario.UsuarioNome);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioAtivo", usuario.UsuarioAtivo);
                acessoDadosSqlServer.AdicionarParametros("@TipoUsuarioID", usuario.TipoUsuario.TipoUsuarioID);

                return int.Parse(acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterUsuario"));

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(Usuario usuario)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Alterar");
                acessoDadosSqlServer.AdicionarParametros("@UsuarioID", usuario.UsuarioID);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioLogin", usuario.UsuarioLogin);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioSenha", usuario.UsuarioSenha);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioNome", usuario.UsuarioNome);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioAtivo", usuario.UsuarioAtivo);
                acessoDadosSqlServer.AdicionarParametros("@TipoUsuarioID", usuario.TipoUsuario.TipoUsuarioID);

                acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterUsuario");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public UsuarioCollection ConsultaPorNome(string Nome)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Nome");
                acessoDadosSqlServer.AdicionarParametros("@UsuarioID", "");
                acessoDadosSqlServer.AdicionarParametros("@UsuarioLogin", "");
                acessoDadosSqlServer.AdicionarParametros("@UsuarioSenha", "");
                acessoDadosSqlServer.AdicionarParametros("@UsuarioNome", Nome);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaUsuario");

                UsuarioCollection usuarioCollection = new UsuarioCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Usuario usuario = new Usuario();
                    usuario.TipoUsuario = new TipoUsuario();
                    usuario.UsuarioID = Convert.ToInt32(row["UsuarioID"]);
                    usuario.UsuarioLogin = row["UsuarioLogin"].ToString();
                    usuario.UsuarioNome = row["UsuarioNome"].ToString();
                    usuario.UsuarioSenha = row["UsuarioSenha"].ToString();
                    usuario.UsuarioAtivo = Convert.ToBoolean(row["UsuarioAtivo"]);
                    usuario.TipoUsuario.TipoUsuarioID = Convert.ToInt32(row["TipoUsuarioID"]);
                    usuario.TipoUsuario.TipoUsuarioDescricao = row["TipoUsuarioDescricao"].ToString();

                    usuarioCollection.Add(usuario);
                }

                return usuarioCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Usuario Validacao(Usuario usuarioP)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Validar");
                acessoDadosSqlServer.AdicionarParametros("@UsuarioID", "");
                acessoDadosSqlServer.AdicionarParametros("@UsuarioLogin", usuarioP.UsuarioLogin);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioSenha", usuarioP.UsuarioSenha);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioNome", "");

                UsuarioCollection usuarioCollection = new UsuarioCollection();

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaUsuario");

                foreach (DataRow row in dataTable.Rows)
                {
                    Usuario usuario = new Usuario();
                    usuario.TipoUsuario = new TipoUsuario();
                    usuario.UsuarioID = Convert.ToInt32(row["UsuarioID"]);
                    usuario.UsuarioLogin = row["UsuarioLogin"].ToString();
                    usuario.UsuarioNome = row["UsuarioNome"].ToString();

                    return usuario;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int ValidacaoLogin(string UsuarioLogin)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "ValLogin");
                acessoDadosSqlServer.AdicionarParametros("@UsuarioID", 0);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioLogin", UsuarioLogin);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioSenha", "");
                acessoDadosSqlServer.AdicionarParametros("@UsuarioNome", "");

                UsuarioCollection usuarioCollection = new UsuarioCollection();

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaUsuario");

                foreach (DataRow row in dataTable.Rows)
                {
                    return Convert.ToInt32(row["UsuarioID"]);
                }

                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Usuario ConsultaPorID(int ID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "ID");
                acessoDadosSqlServer.AdicionarParametros("@UsuarioID", ID);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioLogin", "");
                acessoDadosSqlServer.AdicionarParametros("@UsuarioSenha", "");
                acessoDadosSqlServer.AdicionarParametros("@UsuarioNome", "");

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaUsuario");


                foreach (DataRow row in dataTable.Rows)
                {
                    Usuario usuario = new Usuario();
                    usuario.TipoUsuario = new TipoUsuario();
                    usuario.UsuarioID = Convert.ToInt32(row["UsuarioID"]);
                    usuario.UsuarioLogin = row["UsuarioLogin"].ToString();
                    usuario.UsuarioNome = row["UsuarioNome"].ToString();
                    usuario.UsuarioSenha = row["UsuarioSenha"].ToString();
                    usuario.UsuarioAtivo = Convert.ToBoolean(row["UsuarioAtivo"]);
                    usuario.TipoUsuario.TipoUsuarioID = Convert.ToInt32(row["TipoUsuarioID"]);
                    usuario.TipoUsuario.TipoUsuarioDescricao = row["TipoUsuarioDescricao"].ToString();

                    return usuario;
                }

                return null;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
