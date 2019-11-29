namespace RegraNegocios
{
    using AcessoBancoDados;
    using ObjetoTransferencia;
    using System;
    using System.Data;

    public class ClienteNegocios
    {
        private readonly AcessoDadosSqlServer AcessoDados = new AcessoDadosSqlServer();

        public string Inserir(ClienteObjeto cliente)
        {
            try
            {
                AcessoDados.LimparParametros();
                AcessoDados.AdicionarParametros("@Nome", cliente.Nome);
                AcessoDados.AdicionarParametros("@CPF", cliente.CPF);
                AcessoDados.AdicionarParametros("@DataNascimento", cliente.DataNascimento);
                AcessoDados.AdicionarParametros("@Sexo", cliente.Sexo);
                AcessoDados.AdicionarParametros("@Telefone", cliente.Telefone);
                AcessoDados.AdicionarParametros("@Celular", cliente.Celular);
                AcessoDados.AdicionarParametros("@CEP", cliente.CEP);
                AcessoDados.AdicionarParametros("@Endereco", cliente.Endereco);
                AcessoDados.AdicionarParametros("@Bairro", cliente.Bairro);
                AcessoDados.AdicionarParametros("@Cidade", cliente.Cidade);
                AcessoDados.AdicionarParametros("@Estado", cliente.Estado);
                AcessoDados.AdicionarParametros("@Complemento", cliente.Complemento);
                AcessoDados.AdicionarParametros("@Email", cliente.Email);
                AcessoDados.AdicionarParametros("@Obs", cliente.Obs);

                string codigo = this.AcessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "ClienteInserir").ToString();

                return codigo;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Alterar(ClienteObjeto cliente)
        {
            try
            {
                AcessoDados.LimparParametros();
                AcessoDados.AdicionarParametros("@Codigo", cliente.Codigo);
                AcessoDados.AdicionarParametros("@Nome", cliente.Nome);
                AcessoDados.AdicionarParametros("@CPF", cliente.CPF);
                AcessoDados.AdicionarParametros("@DataNascimento", cliente.DataNascimento);
                AcessoDados.AdicionarParametros("@Sexo", cliente.Sexo);
                AcessoDados.AdicionarParametros("@Telefone", cliente.Telefone);
                AcessoDados.AdicionarParametros("@Celular", cliente.Celular);
                AcessoDados.AdicionarParametros("@CEP", cliente.CEP);
                AcessoDados.AdicionarParametros("@Endereco", cliente.Endereco);
                AcessoDados.AdicionarParametros("@Bairro", cliente.Bairro);
                AcessoDados.AdicionarParametros("@Cidade", cliente.Cidade);
                AcessoDados.AdicionarParametros("@Estado", cliente.Estado);
                AcessoDados.AdicionarParametros("@Complemento", cliente.Complemento);
                AcessoDados.AdicionarParametros("@Email", cliente.Email);
                AcessoDados.AdicionarParametros("@Obs", cliente.Obs);

                string Codigo = AcessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "ClienteAlterar").ToString();

                return Codigo;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string Excluir(ClienteObjeto cliente)
        {
            try
            {
                AcessoDados.LimparParametros();
                AcessoDados.AdicionarParametros("@Codigo", cliente.Codigo);
                string Codigo = AcessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "ClienteExcluir").ToString();
                return Codigo;

            }

            catch (Exception exception)
            {
                return exception.Message;

            }



        }

        public ClienteColecao ConsulTarPorNome(String nome)
        {
            try
            {
                var clienteColecao = new ClienteColecao();

                AcessoDados.LimparParametros();
                AcessoDados.AdicionarParametros("@Nome", nome);
                var dataTableCliente = this.AcessoDados.ExecutarConsulta(CommandType.StoredProcedure, "ClienteConsultaPorNome");

                foreach (DataRow Linha in dataTableCliente.Rows)
                {
                    var cliente = new ClienteObjeto
                    {
                        Codigo = Convert.ToInt32(Linha["Codigo"]),
                        Nome = Convert.ToString(Linha["Nome"]),
                        CPF = Convert.ToString(Linha["CPF"]),
                        DataNascimento = Convert.ToDateTime(Linha["DataNascimento"]),
                        Sexo = Convert.ToBoolean(Linha["Sexo"]),
                        Telefone = Convert.ToString(Linha["Telefone"]),
                        Celular = Convert.ToString(Linha["Celular"]),
                        CEP = Convert.ToString(Linha["CEP"]),
                        Endereco = Convert.ToString(Linha["Endereco"]),
                        Bairro = Convert.ToString(Linha["Bairro"]),
                        Cidade = Convert.ToString(Linha["Cidade"]),
                        Estado = Convert.ToString(Linha["Estado"]),
                        Complemento = Convert.ToString(Linha["Complemento"]),
                        Email = Convert.ToString(Linha["Email"]),
                        Obs = Convert.ToString(Linha["Obs"])
                    };

                    clienteColecao.Add(cliente);
                }


                return clienteColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não Foi Possive Consultar O Cliente Por Nome. Detalher : " + exception.Message);
            }
        }

        public ClienteColecao ConsulTarPorCodigo(Int32 codigo)
        {
            try
            {
                var clienteColecao = new ClienteColecao();

                AcessoDados.LimparParametros();
                AcessoDados.AdicionarParametros("@Codigo", codigo);
                var dataTableCliente = this.AcessoDados.ExecutarConsulta(CommandType.StoredProcedure, "ClienteConsultaPorNome");

                foreach (DataRow Linha in dataTableCliente.Rows)
                {
                    var cliente = new ClienteObjeto
                    {
                        Codigo = Convert.ToInt32(Linha["Codigo"]),
                        Nome = Convert.ToString(Linha["Nome"]),
                        CPF = Convert.ToString(Linha["CPF"]),
                        DataNascimento = Convert.ToDateTime(Linha["DataNascimento"]),
                        Sexo = Convert.ToBoolean(Linha["Sexo"]),
                        Telefone = Convert.ToString(Linha["Telefone"]),
                        Celular = Convert.ToString(Linha["Celular"]),
                        CEP = Convert.ToString(Linha["CEP"]),
                        Endereco = Convert.ToString(Linha["Endereco"]),
                        Bairro = Convert.ToString(Linha["Bairro"]),
                        Cidade = Convert.ToString(Linha["Cidade"]),
                        Estado = Convert.ToString(Linha["Estado"]),
                        Complemento = Convert.ToString(Linha["Complemento"]),
                        Email = Convert.ToString(Linha["Email"]),
                        Obs = Convert.ToString(Linha[" bs"])
                    };

                    clienteColecao.Add(cliente);
                }


                return clienteColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não Foi Possive Consultar O Cliente Por Codigo. Detalher : " + exception.Message);
            }
        }


    }
}
