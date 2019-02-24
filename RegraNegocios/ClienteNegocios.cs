namespace RegraNegocios
{
    using AcessoBancoDados;
    using ObjetoTransferencia;
    using System;
    using System.Data;

    public class ClienteNegocios
    {
        private readonly AcessoDadosSqlServer AcessoDados = new AcessoDadosSqlServer();

        public String Inserir(ClienteObjeto cliente)
        {
            try
            {
                this.AcessoDados.LimparParametros();
                this.AcessoDados.AdicionarParametros("@Nome", cliente.Nome);
                this.AcessoDados.AdicionarParametros("@CPF", cliente.CPF);
                this.AcessoDados.AdicionarParametros("@DataNascimento", cliente.DataNascimento);
                this.AcessoDados.AdicionarParametros("@Sexo", cliente.Sexo);
                this.AcessoDados.AdicionarParametros("@Telefone", cliente.Telefone);
                this.AcessoDados.AdicionarParametros("@Celular", cliente.Celular);
                this.AcessoDados.AdicionarParametros("@CEP", cliente.CEP);
                this.AcessoDados.AdicionarParametros("@Endereco", cliente.Endereco);
                this.AcessoDados.AdicionarParametros("@Bairro", cliente.Bairro);
                this.AcessoDados.AdicionarParametros("@Cidade", cliente.Cidade);
                this.AcessoDados.AdicionarParametros("@Estado", cliente.Estado);
                this.AcessoDados.AdicionarParametros("@Complemento", cliente.Complemento);
                this.AcessoDados.AdicionarParametros("@Email", cliente.Email);
                this.AcessoDados.AdicionarParametros("@Obs", cliente.Obs);

                String codigo = this.AcessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "ClienteInserir").ToString();

                return codigo;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Alterar(ClienteObjeto cliente)
        {
            try
            {
                this.AcessoDados.LimparParametros();
                this.AcessoDados.AdicionarParametros("@Codigo", cliente.Codigo);
                this.AcessoDados.AdicionarParametros("@Nome", cliente.Nome);
                this.AcessoDados.AdicionarParametros("@CPF", cliente.CPF);
                this.AcessoDados.AdicionarParametros("@DataNascimento", cliente.DataNascimento);
                this.AcessoDados.AdicionarParametros("@Sexo", cliente.Sexo);
                this.AcessoDados.AdicionarParametros("@Telefone", cliente.Telefone);
                this.AcessoDados.AdicionarParametros("@Celular", cliente.Celular);
                this.AcessoDados.AdicionarParametros("@CEP", cliente.CEP);
                this.AcessoDados.AdicionarParametros("@Endereco", cliente.Endereco);
                this.AcessoDados.AdicionarParametros("@Bairro", cliente.Bairro);
                this.AcessoDados.AdicionarParametros("@Cidade", cliente.Cidade);
                this.AcessoDados.AdicionarParametros("@Estado", cliente.Estado);
                this.AcessoDados.AdicionarParametros("@Complemento", cliente.Complemento);
                this.AcessoDados.AdicionarParametros("@Email", cliente.Email);
                this.AcessoDados.AdicionarParametros("@Obs", cliente.Obs);

                String Codigo = this.AcessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "ClienteAlterar").ToString();

                return Codigo;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public String Excluir(ClienteObjeto cliente)
        {
            try
            {
                this.AcessoDados.LimparParametros();
                this.AcessoDados.AdicionarParametros("@Codigo", cliente.Codigo);
                String Codigo = this.AcessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "ClienteExcluir").ToString();
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
                ClienteColecao clienteColecao = new ClienteColecao();

                this.AcessoDados.LimparParametros();
                this.AcessoDados.AdicionarParametros("@Nome", nome);
                var dataTableCliente = this.AcessoDados.ExecutarConsulta(CommandType.StoredProcedure, "ClienteConsultaPorNome");

                foreach (DataRow Linha in dataTableCliente.Rows)
                {
                    ClienteObjeto cliente = new ClienteObjeto
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
                ClienteColecao clienteColecao = new ClienteColecao();

                this.AcessoDados.LimparParametros();
                this.AcessoDados.AdicionarParametros("@Codigo", codigo);
                var dataTableCliente = this.AcessoDados.ExecutarConsulta(CommandType.StoredProcedure, "ClienteConsultaPorNome");

                foreach (DataRow Linha in dataTableCliente.Rows)
                {
                    ClienteObjeto cliente = new ClienteObjeto
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
