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
    public class CompraNegocios
    {
        //Instancio a classe de acesso ao banco de dados
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public int Cadastrar(Compra compra)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Inserir");
                acessoDadosSqlServer.AdicionarParametros("@CompraID", 0);
                acessoDadosSqlServer.AdicionarParametros("@CompraData", compra.CompraData);
                acessoDadosSqlServer.AdicionarParametros("@CompraDataEntrega", compra.CompraDataEntrega);
                acessoDadosSqlServer.AdicionarParametros("@CompraValorTotal", compra.CompraValorTotal);
                acessoDadosSqlServer.AdicionarParametros("@PessoaID", compra.Pessoa.PessoaID);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioID", compra.Usuario.UsuarioID);

                compra.CompraID = int.Parse(acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterCompra"));

                ListaCompraNegocios listaCompraNegocios = new ListaCompraNegocios();
                AnimalNegocios animalNegocios = new AnimalNegocios();
                foreach (Animal animal in compra.Animais)
                {
                    animal.AnimalAtivo = true;
                    animal.AnimalID = animalNegocios.Cadastrar(animal);

                    ListaCompra listaCompra = new ListaCompra();
                    listaCompra.CompraID = compra.CompraID;
                    listaCompra.Animal = animal;
                    listaCompraNegocios.Cadastrar(listaCompra);
                }
                return compra.CompraID;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(Compra compra, ListaCompraCollection animaisCompra, AnimalCollection animaisNovos, ListaCompraCollection listaCompraRemocao)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Alterar");
                acessoDadosSqlServer.AdicionarParametros("@CompraID", compra.CompraID);
                acessoDadosSqlServer.AdicionarParametros("@CompraData", compra.CompraData);
                acessoDadosSqlServer.AdicionarParametros("@CompraDataEntrega", compra.CompraDataEntrega);
                acessoDadosSqlServer.AdicionarParametros("@CompraValorTotal", compra.CompraValorTotal);
                acessoDadosSqlServer.AdicionarParametros("@PessoaID", compra.Pessoa.PessoaID);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioID", compra.Usuario.UsuarioID);

                acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterCompra");

                ListaCompraNegocios listaCompraNegocios = new ListaCompraNegocios();
                AnimalNegocios animalNegocios = new AnimalNegocios();
                foreach (Animal animal in animaisNovos)
                {
                    animal.AnimalAtivo = true;
                    animal.AnimalID = animalNegocios.Cadastrar(animal);

                    ListaCompra listaCompra = new ListaCompra();
                    listaCompra.CompraID = compra.CompraID;
                    listaCompra.Animal = animal;
                    listaCompraNegocios.Cadastrar(listaCompra);
                }

                foreach (ListaCompra listaCompraAlterar in animaisCompra)
                {
                    listaCompraNegocios.Alterar(listaCompraAlterar);
                }
                foreach (ListaCompra listaCompraRem in listaCompraRemocao)
                {
                    listaCompraRem.Animal.AnimalAtivo = false;
                    animalNegocios.Alterar(listaCompraRem.Animal);

                    listaCompraNegocios.Excluir(listaCompraRem);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public CompraCollection ConsultaPorID(int CompraID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "ID");
                acessoDadosSqlServer.AdicionarParametros("@CompraID", CompraID);
                acessoDadosSqlServer.AdicionarParametros("@CompraData", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@CompraData2", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@PessoaID", 0);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioID", 0);
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaCompra");

                CompraCollection compraCollection = new CompraCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Compra compra = new Compra();
                    compra.Pessoa = new Pessoa();
                    compra.Usuario = new Usuario();
                    compra.CompraID = Convert.ToInt32(row["CompraID"]);
                    compra.CompraData = Convert.ToDateTime(row["CompraData"]);
                    compra.CompraDataEntrega = Convert.ToDateTime(row["CompraDataEntrega"]);
                    compra.CompraValorTotal = Convert.ToDecimal(row["CompraValorTotal"]);
                    compra.Pessoa.PessoaID = Convert.ToInt32(row["PessoaID"]);
                    compra.Usuario.UsuarioID = Convert.ToInt32(row["UsuarioID"]);
                    compra.Usuario.UsuarioNome = row["UsuarioNome"].ToString();
                    compra.CompraQuantidade = Convert.ToInt32(row["QuantidadeAnimais"]);

                    compraCollection.Add(compra);
                }

                return compraCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public CompraCollection ConsultaPorDataEntre(DateTime data1, DateTime data2)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "DataEntre");
                acessoDadosSqlServer.AdicionarParametros("@CompraID", 0);
                acessoDadosSqlServer.AdicionarParametros("@CompraData", data1);
                acessoDadosSqlServer.AdicionarParametros("@CompraData2", data2);
                acessoDadosSqlServer.AdicionarParametros("@PessoaID", 0);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioID", 0);
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaCompra");

                CompraCollection compraCollection = new CompraCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Compra compra = new Compra();
                    compra.Pessoa = new Pessoa();
                    compra.Usuario = new Usuario();
                    compra.CompraID = Convert.ToInt32(row["CompraID"]);
                    compra.CompraData = Convert.ToDateTime(row["CompraData"]);
                    compra.CompraDataEntrega = Convert.ToDateTime(row["CompraDataEntrega"]);
                    compra.CompraValorTotal = Convert.ToDecimal(row["CompraValorTotal"]);
                    compra.Pessoa.PessoaID = Convert.ToInt32(row["PessoaID"]);
                    compra.Usuario.UsuarioID = Convert.ToInt32(row["UsuarioID"]);
                    compra.Usuario.UsuarioNome = row["UsuarioNome"].ToString();
                    compra.CompraQuantidade = Convert.ToInt32(row["QuantidadeAnimais"]);

                    compraCollection.Add(compra);
                }

                return compraCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public CompraCollection ConsultaPorDataApos(DateTime data1)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "DataApos");
                acessoDadosSqlServer.AdicionarParametros("@CompraID", 0);
                acessoDadosSqlServer.AdicionarParametros("@CompraData", data1);
                acessoDadosSqlServer.AdicionarParametros("@CompraData2", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@PessoaID", 0);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioID", 0);
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaCompra");

                CompraCollection compraCollection = new CompraCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Compra compra = new Compra();
                    compra.Pessoa = new Pessoa();
                    compra.Usuario = new Usuario();
                    compra.CompraID = Convert.ToInt32(row["CompraID"]);
                    compra.CompraData = Convert.ToDateTime(row["CompraData"]);
                    compra.CompraDataEntrega = Convert.ToDateTime(row["CompraDataEntrega"]);
                    compra.CompraValorTotal = Convert.ToDecimal(row["CompraValorTotal"]);
                    compra.Pessoa.PessoaID = Convert.ToInt32(row["PessoaID"]);
                    compra.Usuario.UsuarioID = Convert.ToInt32(row["UsuarioID"]);
                    compra.Usuario.UsuarioNome = row["UsuarioNome"].ToString();
                    compra.CompraQuantidade = Convert.ToInt32(row["QuantidadeAnimais"]);

                    compraCollection.Add(compra);
                }

                return compraCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public CompraCollection ConsultaPorDataAntes(DateTime data2)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "DataAntes");
                acessoDadosSqlServer.AdicionarParametros("@CompraID", 0);
                acessoDadosSqlServer.AdicionarParametros("@CompraData", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@CompraData2", data2);
                acessoDadosSqlServer.AdicionarParametros("@PessoaID", 0);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioID", 0);
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaCompra");

                CompraCollection compraCollection = new CompraCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Compra compra = new Compra();
                    compra.Pessoa = new Pessoa();
                    compra.Usuario = new Usuario();
                    compra.CompraID = Convert.ToInt32(row["CompraID"]);
                    compra.CompraData = Convert.ToDateTime(row["CompraData"]);
                    compra.CompraDataEntrega = Convert.ToDateTime(row["CompraDataEntrega"]);
                    compra.CompraValorTotal = Convert.ToDecimal(row["CompraValorTotal"]);
                    compra.Pessoa.PessoaID = Convert.ToInt32(row["PessoaID"]);
                    compra.Usuario.UsuarioID = Convert.ToInt32(row["UsuarioID"]);
                    compra.Usuario.UsuarioNome = row["UsuarioNome"].ToString();
                    compra.CompraQuantidade = Convert.ToInt32(row["QuantidadeAnimais"]);

                    compraCollection.Add(compra);
                }

                return compraCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public CompraCollection ConsultaPorPessoa(int PessoaID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Pessoa");
                acessoDadosSqlServer.AdicionarParametros("@CompraID", 0);
                acessoDadosSqlServer.AdicionarParametros("@CompraData", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@CompraData2", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@PessoaID", PessoaID);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioID", 0);
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaCompra");

                CompraCollection compraCollection = new CompraCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Compra compra = new Compra();
                    compra.Pessoa = new Pessoa();
                    compra.Usuario = new Usuario();
                    compra.CompraID = Convert.ToInt32(row["CompraID"]);
                    compra.CompraData = Convert.ToDateTime(row["CompraData"]);
                    compra.CompraDataEntrega = Convert.ToDateTime(row["CompraDataEntrega"]);
                    compra.CompraValorTotal = Convert.ToDecimal(row["CompraValorTotal"]);
                    compra.Pessoa.PessoaID = Convert.ToInt32(row["PessoaID"]);
                    compra.Usuario.UsuarioID = Convert.ToInt32(row["UsuarioID"]);
                    compra.Usuario.UsuarioNome = row["UsuarioNome"].ToString();
                    compra.CompraQuantidade = Convert.ToInt32(row["QuantidadeAnimais"]);

                    compraCollection.Add(compra);
                }

                return compraCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public CompraCollection ConsultaPorUsuario(int UsuarioID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Usuario");
                acessoDadosSqlServer.AdicionarParametros("@CompraID", 0);
                acessoDadosSqlServer.AdicionarParametros("@CompraData", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@CompraData2", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@PessoaID", 0);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioID", UsuarioID);
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaCompra");

                CompraCollection compraCollection = new CompraCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Compra compra = new Compra();
                    compra.Pessoa = new Pessoa();
                    compra.Usuario = new Usuario();
                    compra.CompraID = Convert.ToInt32(row["CompraID"]);
                    compra.CompraData = Convert.ToDateTime(row["CompraData"]);
                    compra.CompraDataEntrega = Convert.ToDateTime(row["CompraDataEntrega"]);
                    compra.CompraValorTotal = Convert.ToDecimal(row["CompraValorTotal"]);
                    compra.Pessoa.PessoaID = Convert.ToInt32(row["PessoaID"]);
                    compra.Usuario.UsuarioID = Convert.ToInt32(row["UsuarioID"]);
                    compra.Usuario.UsuarioNome = row["UsuarioNome"].ToString();
                    compra.CompraQuantidade = Convert.ToInt32(row["QuantidadeAnimais"]);

                    compraCollection.Add(compra);
                }

                return compraCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        public CompraCollection ConsultaPorAnimal(int AnimalID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Animal");
                acessoDadosSqlServer.AdicionarParametros("@CompraID", 0);
                acessoDadosSqlServer.AdicionarParametros("@CompraData", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@CompraData2", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@PessoaID", 0);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioID", 0);
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", AnimalID);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaCompra");

                CompraCollection compraCollection = new CompraCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Compra compra = new Compra();
                    compra.Pessoa = new Pessoa();
                    compra.Usuario = new Usuario();
                    compra.CompraID = Convert.ToInt32(row["CompraID"]);
                    compra.CompraData = Convert.ToDateTime(row["CompraData"]);
                    compra.CompraDataEntrega = Convert.ToDateTime(row["CompraDataEntrega"]);
                    compra.CompraValorTotal = Convert.ToDecimal(row["CompraValorTotal"]);
                    compra.Pessoa.PessoaID = Convert.ToInt32(row["PessoaID"]);
                    compra.Usuario.UsuarioID = Convert.ToInt32(row["UsuarioID"]);
                    compra.Usuario.UsuarioNome = row["UsuarioNome"].ToString();
                    compra.CompraQuantidade = Convert.ToInt32(row["QuantidadeAnimais"]);

                    compraCollection.Add(compra);
                }

                return compraCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
