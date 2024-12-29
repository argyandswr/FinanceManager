using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace PersonalFinanceManager.Model.Context
{
    public class DbContext : IDisposable
    {
        private SqlConnection _conn;
        public SqlConnection Conn
        {
            get { return _conn ?? (_conn = GetOpenConnection()); }
        }

        private SqlConnection GetOpenConnection()
        {
            SqlConnection conn = null;

            try
            {
                string connectionString = string.Format("Data Source=.;Initial Catalog=finance_manager;Integrated Security=True;Trust Server Certificate=True");
                //string connectionString = string.Format(@"Data Source=DELYSIUM_T14;AttachDbFilename=D:\dev\database_system\finance_manager\db\finance_manager_dat.mdf;Initial Catalog=finance_manager;Integrated Security=True;TrustServerCertificate=True");

                conn = new SqlConnection(connectionString);
                conn.Open();
            }

            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("Open Connection Error: {0}", ex.Message);
            }

            return conn;
        }

        public void Dispose()
        {
            if (_conn != null)
            {
                try
                {
                    if (_conn.State != ConnectionState.Closed) _conn.Close();
                }
                finally
                {
                    _conn.Dispose();
                }
            }

            GC.SuppressFinalize(this);
        }
    }
}
