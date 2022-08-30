using System;
using System.Data;
using System.IO;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;


namespace DbaCon
{
    public class DataConexao
    {
        public SqlConnection CriarConexao()
        {
            // return new SqlConnection(Settings.Default.stringConexao);

            if (File.Exists(Directory.GetCurrentDirectory() + @"\config.ini"))
            {

            }
            else
            {
                MessageBox.Show("Arquivo config.ini Não Encontrado!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            string stringLocal = File.ReadAllText(Directory.GetCurrentDirectory() + @"\config.ini");
            return new SqlConnection(stringLocal);
            
            //Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = "E:\Projetos C Sharp\AdCert\AdCert\AdCertDB.mdf"; Integrated Security = True
        }

        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        public void LimparParametros()
        {
            sqlParameterCollection.Clear();
        } 

        public void AdicionarParametros(string nomeParametro, object valorParametro)
        {
            sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));
        }

        public object ExecutarManipulacao(CommandType commandType, string nomeStoredProcedureouComandoTextoSql)
        {
            try
            {
                SqlConnection sqlConnection = CriarConexao();
                sqlConnection.Open();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureouComandoTextoSql;
                sqlCommand.CommandTimeout = 7200;

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
            finally
            {
                SqlConnection sqlConnection = CriarConexao();
                if (sqlConnection != null)
                    ((IDisposable)sqlConnection).Dispose();
            }

        }
        public DataTable ExecutarConsulta(CommandType commandType, string nomeStoredProcedureouComandoTextoSql)
        {
            try
            {
                SqlConnection sqlConnection = CriarConexao();
                sqlConnection.Open();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureouComandoTextoSql;
                sqlCommand.CommandTimeout = 7200;

                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));

                }

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                SqlConnection sqlConnection = CriarConexao();
                if (sqlConnection != null)
                    ((IDisposable)sqlConnection).Dispose();
            }
        }
    }
}
