using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Ims.Core
{
    public class TransactionScope : IDisposable
    {
        public void Dispose()
        {
        }

        public DataRow ExecuteDataRow(string text, CommandType commandType, params  Parameter[] parameters)
        {
            DataRow[] dataRows = ExecuteDataRows(text, commandType, parameters).ToArray();

            if (dataRows.Length > 1)
            {
                throw new Exception("Zero or 1 rows expected.");
            }

            return dataRows.Length == 0 ? null : dataRows[0];
        }

        public IEnumerable<DataRow> ExecuteDataRows(string text, CommandType commandType, params  Parameter[] parameters)
        {
            return ExecuteDataSet(text, commandType, parameters).Tables[0].Rows.Cast<DataRow>();
        }

        public DataTable ExecuteDataTable(string text, CommandType commandType, params  Parameter[] parameters)
        {
            return ExecuteDataSet(text, commandType, parameters).Tables[0];
        }

        public DataSet ExecuteDataSet(string text, CommandType commandType, params  Parameter[] parameters)
        {
            DataSet dataSet = new DataSet();
            
            ExecuteCommand(command =>
            {
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command))
                {
                    sqlDataAdapter.Fill(dataSet);
                }
            }, text, commandType, parameters);

            return dataSet;
        }

        public T ExecuteScalar<T>(string text, CommandType commandType, params  Parameter[] parameters)
        {
            T t = default(T);

            ExecuteCommand(command =>
            {
                t = (T)command.ExecuteScalar();
            }, text, commandType, parameters);

            return t;
        }

        public IEnumerable<T> ExecuteEnumerable<T>(string text, CommandType commandType, params  Parameter[] parameters)
        {
            return ExecuteDataSet(text, commandType, parameters).Tables[0].Rows.Cast<DataRow>().Select(item => item.Field<T>(0));
        }

        public void ExecuteNonQuery(string text, CommandType commandType, params  Parameter[] parameters)
        {
            ExecuteCommand(command => command.ExecuteNonQuery(), text, commandType, parameters);
        }

        private void ExecuteCommand(Action<SqlCommand> action, string text, CommandType commandType, params  Parameter[] parameters)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Ims"].ConnectionString))
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(text, sqlConnection) { CommandType = commandType })
                {
                    sqlCommand.Parameters.AddRange(parameters.Select(item => new SqlParameter(item.Name, item.SqlDbType) { Value = item.Value }).ToArray());

                    action(sqlCommand);
                }
            }
        }
    }
}