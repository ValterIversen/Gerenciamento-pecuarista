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
    public class VendaNegocios
    {
        //Instancio a classe de acesso ao banco de dados
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public int Cadastrar(Venda venda)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Inserir");
                acessoDadosSqlServer.AdicionarParametros("@VendaID", 0);
                acessoDadosSqlServer.AdicionarParametros("@VendaData", venda.VendaData);
                acessoDadosSqlServer.AdicionarParametros("@VendaDataEntrega", venda.VendaDataEntrega);
                acessoDadosSqlServer.AdicionarParametros("@VendaValorTotal", venda.VendaValorTotal);
                acessoDadosSqlServer.AdicionarParametros("@PessoaID", venda.Pessoa.PessoaID);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioID", venda.Usuario.UsuarioID);

                venda.VendaID = int.Parse(acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterVenda"));

                ListaVendaNegocios listaVendaNegocios = new ListaVendaNegocios();
                AnimalNegocios animalNegocios = new AnimalNegocios();

                for (int i = 0; i < venda.Animais.Count; i++)
                {
                    ListaVenda listaVenda = new ListaVenda();
                    listaVenda.Animal = venda.Animais[i];
                    listaVenda.VendaID = venda.VendaID;
                    listaVendaNegocios.Cadastrar(listaVenda);
                    Animal animal = new Animal();
                    animal = venda.Animais[i];
                    animal.AnimalAtivo = false;

                    animalNegocios.Alterar(animal);
                }
                return venda.VendaID;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(Venda venda, AnimalCollection animaisNovosVenda, ListaVendaCollection animaisVenda, ListaVendaCollection listaVendaRemocao)
        {
            try
            {
                //Limpa todos os parâmetros
                acessoDadosSqlServer.LimparParametros();

                //Adiciona os parâmetros para chamar a store procedure
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Alterar");
                acessoDadosSqlServer.AdicionarParametros("@VendaID", venda.VendaID);
                acessoDadosSqlServer.AdicionarParametros("@VendaData", venda.VendaData);
                acessoDadosSqlServer.AdicionarParametros("@VendaDataEntrega", venda.VendaDataEntrega);
                acessoDadosSqlServer.AdicionarParametros("@VendaValorTotal", venda.VendaValorTotal);
                acessoDadosSqlServer.AdicionarParametros("@PessoaID", venda.Pessoa.PessoaID);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioID", venda.Usuario.UsuarioID);

                acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterVenda");

                ListaVendaNegocios listaVendaNegocios = new ListaVendaNegocios();

                AnimalNegocios animalNegocios = new AnimalNegocios();

                foreach (ListaVenda listaVendaAlterar in animaisVenda)
                {
                    listaVendaNegocios.Alterar(listaVendaAlterar);
                }
                foreach (Animal animalNovo in animaisNovosVenda)
                {
                    animalNovo.AnimalAtivo = false;
                    animalNegocios.Alterar(animalNovo);

                    ListaVenda listaVendaNova = new ListaVenda();
                    listaVendaNova.ListaVendaValor = animalNovo.AnimalValor;
                    listaVendaNova.Animal = animalNovo;
                    listaVendaNova.VendaID = venda.VendaID;

                    listaVendaNegocios.Cadastrar(listaVendaNova);
                }
                foreach (ListaVenda listaVendaRem in listaVendaRemocao)
                {
                    listaVendaRem.Animal.AnimalAtivo = true;
                    animalNegocios.Alterar(listaVendaRem.Animal);

                    listaVendaNegocios.Excluir(listaVendaRem);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public VendaCollection ConsultaPorID(int VendaID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "ID");
                acessoDadosSqlServer.AdicionarParametros("@VendaID", VendaID);
                acessoDadosSqlServer.AdicionarParametros("@VendaData", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@VendaData2", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@PessoaID", 0);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioID", 0);
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaVenda");

                VendaCollection vendaCollection = new VendaCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Venda venda = new Venda();
                    venda.Pessoa = new Pessoa();
                    venda.Usuario = new Usuario();
                    venda.VendaID = Convert.ToInt32(row["VendaID"]);
                    venda.VendaData = Convert.ToDateTime(row["VendaData"]);
                    venda.VendaDataEntrega = Convert.ToDateTime(row["VendaDataEntrega"]);
                    venda.VendaValorTotal = Convert.ToDecimal(row["VendaValorTotal"]);
                    venda.Pessoa.PessoaID = Convert.ToInt32(row["PessoaID"]);
                    venda.Usuario.UsuarioID = Convert.ToInt32(row["UsuarioID"]);
                    venda.Usuario.UsuarioNome = row["UsuarioNome"].ToString();
                    venda.VendaQuantidade = Convert.ToInt32(row["QuantidadeAnimais"]);

                    vendaCollection.Add(venda);
                }

                return vendaCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public VendaCollection ConsultaPorDataEntre(DateTime data1, DateTime data2)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "DataEntre");
                acessoDadosSqlServer.AdicionarParametros("@VendaID", 0);
                acessoDadosSqlServer.AdicionarParametros("@VendaData", data1);
                acessoDadosSqlServer.AdicionarParametros("@VendaData2", data2);
                acessoDadosSqlServer.AdicionarParametros("@PessoaID", 0);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioID", 0);
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaVenda");

                VendaCollection vendaCollection = new VendaCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Venda venda = new Venda();
                    venda.Pessoa = new Pessoa();
                    venda.Usuario = new Usuario();
                    venda.VendaID = Convert.ToInt32(row["VendaID"]);
                    venda.VendaData = Convert.ToDateTime(row["VendaData"]);
                    venda.VendaDataEntrega = Convert.ToDateTime(row["VendaDataEntrega"]);
                    venda.VendaValorTotal = Convert.ToDecimal(row["VendaValorTotal"]);
                    venda.Pessoa.PessoaID = Convert.ToInt32(row["PessoaID"]);
                    venda.Usuario.UsuarioID = Convert.ToInt32(row["UsuarioID"]);
                    venda.Usuario.UsuarioNome = row["UsuarioNome"].ToString();
                    venda.VendaQuantidade = Convert.ToInt32(row["QuantidadeAnimais"]);

                    vendaCollection.Add(venda);
                }

                return vendaCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public VendaCollection ConsultaPorDataApos(DateTime data1)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "DataApos");
                acessoDadosSqlServer.AdicionarParametros("@VendaID", 0);
                acessoDadosSqlServer.AdicionarParametros("@VendaData", data1);
                acessoDadosSqlServer.AdicionarParametros("@VendaData2", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@PessoaID", 0);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioID", 0);
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaVenda");

                VendaCollection vendaCollection = new VendaCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Venda venda = new Venda();
                    venda.Pessoa = new Pessoa();
                    venda.Usuario = new Usuario();
                    venda.VendaID = Convert.ToInt32(row["VendaID"]);
                    venda.VendaData = Convert.ToDateTime(row["VendaData"]);
                    venda.VendaDataEntrega = Convert.ToDateTime(row["VendaDataEntrega"]);
                    venda.VendaValorTotal = Convert.ToDecimal(row["VendaValorTotal"]);
                    venda.Pessoa.PessoaID = Convert.ToInt32(row["PessoaID"]);
                    venda.Usuario.UsuarioID = Convert.ToInt32(row["UsuarioID"]);
                    venda.Usuario.UsuarioNome = row["UsuarioNome"].ToString();
                    venda.VendaQuantidade = Convert.ToInt32(row["QuantidadeAnimais"]);

                    vendaCollection.Add(venda);
                }

                return vendaCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public VendaCollection ConsultaPorDataAntes(DateTime data2)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "DataAntes");
                acessoDadosSqlServer.AdicionarParametros("@VendaID", 0);
                acessoDadosSqlServer.AdicionarParametros("@VendaData", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@VendaData2", data2);
                acessoDadosSqlServer.AdicionarParametros("@PessoaID", 0);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioID", 0);
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaVenda");

                VendaCollection vendaCollection = new VendaCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Venda venda = new Venda();
                    venda.Pessoa = new Pessoa();
                    venda.Usuario = new Usuario();
                    venda.VendaID = Convert.ToInt32(row["VendaID"]);
                    venda.VendaData = Convert.ToDateTime(row["VendaData"]);
                    venda.VendaDataEntrega = Convert.ToDateTime(row["VendaDataEntrega"]);
                    venda.VendaValorTotal = Convert.ToDecimal(row["VendaValorTotal"]);
                    venda.Pessoa.PessoaID = Convert.ToInt32(row["PessoaID"]);
                    venda.Usuario.UsuarioID = Convert.ToInt32(row["UsuarioID"]);
                    venda.Usuario.UsuarioNome = row["UsuarioNome"].ToString();
                    venda.VendaQuantidade = Convert.ToInt32(row["QuantidadeAnimais"]);

                    vendaCollection.Add(venda);
                }

                return vendaCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public VendaCollection ConsultaPorPessoa(int PessoaID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Pessoa");
                acessoDadosSqlServer.AdicionarParametros("@VendaID", 0);
                acessoDadosSqlServer.AdicionarParametros("@VendaData", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@VendaData2", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@PessoaID", PessoaID);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioID", 0);
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaVenda");

                VendaCollection vendaCollection = new VendaCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Venda venda = new Venda();
                    venda.Pessoa = new Pessoa();
                    venda.Usuario = new Usuario();
                    venda.VendaID = Convert.ToInt32(row["VendaID"]);
                    venda.VendaData = Convert.ToDateTime(row["VendaData"]);
                    venda.VendaDataEntrega = Convert.ToDateTime(row["VendaDataEntrega"]);
                    venda.VendaValorTotal = Convert.ToDecimal(row["VendaValorTotal"]);
                    venda.Pessoa.PessoaID = Convert.ToInt32(row["PessoaID"]);
                    venda.Usuario.UsuarioID = Convert.ToInt32(row["UsuarioID"]);
                    venda.Usuario.UsuarioNome = row["UsuarioNome"].ToString();
                    venda.VendaQuantidade = Convert.ToInt32(row["QuantidadeAnimais"]);

                    vendaCollection.Add(venda);
                }

                return vendaCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public VendaCollection ConsultaPorUsuario(int UsuarioID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Usuario");
                acessoDadosSqlServer.AdicionarParametros("@VendaID", 0);
                acessoDadosSqlServer.AdicionarParametros("@VendaData", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@VendaData2", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@PessoaID", 0);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioID", UsuarioID);
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", 0);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaVenda");

                VendaCollection vendaCollection = new VendaCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Venda venda = new Venda();
                    venda.Pessoa = new Pessoa();
                    venda.Usuario = new Usuario();
                    venda.VendaID = Convert.ToInt32(row["VendaID"]);
                    venda.VendaData = Convert.ToDateTime(row["VendaData"]);
                    venda.VendaDataEntrega = Convert.ToDateTime(row["VendaDataEntrega"]);
                    venda.VendaValorTotal = Convert.ToDecimal(row["VendaValorTotal"]);
                    venda.Pessoa.PessoaID = Convert.ToInt32(row["PessoaID"]);
                    venda.Usuario.UsuarioID = Convert.ToInt32(row["UsuarioID"]);
                    venda.Usuario.UsuarioNome = row["UsuarioNome"].ToString();
                    venda.VendaQuantidade = Convert.ToInt32(row["QuantidadeAnimais"]);

                    vendaCollection.Add(venda);
                }

                return vendaCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        public VendaCollection ConsultaPorAnimal(int AnimalID)
        {
            try
            {
                //Limpa e adiciona os parâmetros
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TipoProcedure", "Animal");
                acessoDadosSqlServer.AdicionarParametros("@VendaID", 0);
                acessoDadosSqlServer.AdicionarParametros("@VendaData", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@VendaData2", DateTime.Now);
                acessoDadosSqlServer.AdicionarParametros("@PessoaID", 0);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioID", 0);
                acessoDadosSqlServer.AdicionarParametros("@AnimalID", AnimalID);

                //Cria uma DataTable pois a store procedure returna uma tabela de dados
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultaVenda");

                VendaCollection vendaCollection = new VendaCollection();

                foreach (DataRow row in dataTable.Rows)
                {
                    Venda venda = new Venda();
                    venda.Pessoa = new Pessoa();
                    venda.Usuario = new Usuario();
                    venda.VendaID = Convert.ToInt32(row["VendaID"]);
                    venda.VendaData = Convert.ToDateTime(row["VendaData"]);
                    venda.VendaDataEntrega = Convert.ToDateTime(row["VendaDataEntrega"]);
                    venda.VendaValorTotal = Convert.ToDecimal(row["VendaValorTotal"]);
                    venda.Pessoa.PessoaID = Convert.ToInt32(row["PessoaID"]);
                    venda.Usuario.UsuarioID = Convert.ToInt32(row["UsuarioID"]);
                    venda.Usuario.UsuarioNome = row["UsuarioNome"].ToString();
                    venda.VendaQuantidade = Convert.ToInt32(row["QuantidadeAnimais"]);

                    vendaCollection.Add(venda);
                }

                return vendaCollection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
