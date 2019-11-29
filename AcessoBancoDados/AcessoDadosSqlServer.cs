﻿namespace AcessoBancoDados
{
    using AcessoBancoDados.Properties;
    using System;
    using System.Data;
    using System.Data.SqlClient;

    public class AcessoDadosSqlServer
    {
        //Criar a conexão.
        private SqlConnection CriarConexao()
        {
            // Pegar sempre a string de conexão.
            return new SqlConnection(Settings.Default.ConnectionString);
        }

        //Parâmetros que vão para o banco.
        private readonly SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        public void LimparParametros()
        {
            sqlParameterCollection.Clear();
        }

        public void AdicionarParametros(String nomeParametro, Object valorParametro)
        {
            sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));
        }

        //Inserir, Alterar e Excluir.
        public object ExecutarManipulacao(CommandType commandType, String nomeStoredProcedureOuTextoSql)
        {
            try
            {
                //Criar conexão
                var sqlConnection = this.CriarConexao();
                //Abrir conexão
                sqlConnection.Open();
                //Criar o comando que leva as informações para o banco
                var sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 1200;

                foreach (SqlParameter sqlParameter in this.sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                //Executar o comando e retornar objeto do banco
                return sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        //Consultar registros no banco
        public DataTable ExecutarConsulta(CommandType commandType, String nomeStoredProcedureOuTextoSql)
        {
            try
            {
                //Criar conexão
                var sqlConnection = this.CriarConexao();
                //Abrir conexão
                sqlConnection.Open();
                //Criar o comando que leva as informações para o banco
                var sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 1200;

                foreach (SqlParameter sqlParameter in this.sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                //Criar um adaptador
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
