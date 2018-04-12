using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ContactManager.Classes.DataLayer
{
    public class DatabaseUtil
    {

        private string _dbConnectionString = "";
        private SqlConnection _sqlConnection = null;
        private bool _connOpened = false;

        public DatabaseUtil(string ConnectionString)
        {
            _dbConnectionString = ConnectionString.Trim();
            _sqlConnection = new SqlConnection(_dbConnectionString);

            try
            {
                _sqlConnection.Open();
                _connOpened = true;
            } catch (Exception Ex)
            {
                _connOpened = false;
            }
        }

        public static DatabaseUtil produceDBInstance(string connString)
        {

            return new DatabaseUtil(connString);
        }

        public DataTable ExecuteProcedure(string ProcedureName, string ProcedureParameters)
        {
            if (!_connOpened)
                return null;

            string Query = "exec "+ProcedureName+" "+ ProcedureParameters;

            try
            {

                DataSet ProcResult = new DataSet();

                using (SqlCommand sqlCmd = _sqlConnection.CreateCommand())
                {
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = Query;

                    using (SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCmd))
                    {
                        sqlAdapter.Fill(ProcResult);

                        if (ProcResult == null)
                            return null;

                        if (ProcResult.Tables.Count > 0 && ProcResult.Tables[0].Rows.Count > 0)
                            return ProcResult.Tables[0];
                        else
                            return null;
                    }

                }

            } catch(Exception Ex)
            {
                return null;
            }
        }

    }
}
