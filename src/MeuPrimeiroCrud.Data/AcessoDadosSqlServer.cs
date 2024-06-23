namespace MeuPrimeiroCrud.Data
{
    using MeuPrimeiroCrud.Data.Properties;

    using System;
    using System.Data;
    using System.Data.SqlClient;

    public class AcessoDadosSqlServer
    {
        private SqlConnection CriarConexao() => new SqlConnection(Settings.Default.ConnectionString);
        private readonly SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;
        public void LimparParametros() => sqlParameterCollection.Clear();

        public void AdicionarParametros(string nomeParametro, object valorParametro) => sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));

        public object ExecutarManipulacao(CommandType commandType, string nomeStoredProcedureOuTextoSql)
        {
            try
            {
                var sqlConnection = CriarConexao();
                sqlConnection.Open();
                var sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 1200;
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
                return sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ExecutarConsulta(CommandType commandType, string nomeStoredProcedureOuTextoSql)
        {
            try
            {
                var sqlConnection = this.CriarConexao();
                sqlConnection.Open();
                var sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 1200;
                foreach (SqlParameter sqlParameter in this.sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
                var sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                var dataTable = new DataTable();
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
