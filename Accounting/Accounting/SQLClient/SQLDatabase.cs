using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Windows.Forms;

namespace Accounting.SQLClient
{
    public class SQLDatabase : IDatabase
    {
        /// <summary>
        /// 
        /// </summary>
        public string ConnectionString { get { return connectionString; }
                                       private set { connectionString = value; } }
        /// <summary>
        /// set or return the Name of the current Database
        /// </summary>
        public string DatabaseName { get { return databaseName; }
                                    set { databaseName = value; } }

        /// <summary>
        /// 
        /// </summary>
        public string DataSource { get { return dataSource; }
                                set { dataSource = value; } }


        private string connectionString = "data source=(LocalDB)\v11.0;Initial Catalog=Accouning;User ID=;Password=;";
        private string dataSource = "(LocalDB)\v11.0";
        private string databaseName = "";

        private SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
        private SqlConnection sqlConnection;

        public SQLDatabase(string databaseName)
        {
            this.databaseName = databaseName;
        }

        public void createConnectionString()
        {
            sqlConnectionStringBuilder.ConnectionString = connectionString;
            //sqlConnectionStringBuilder.AttachDBFilename = "@C:\\TestAC.mdf";
            sqlConnectionStringBuilder.InitialCatalog = databaseName;
            //sqlConnectionStringBuilder.IntegratedSecurity = false;
            //sqlConnectionStringBuilder.ApplicationName = "PinschOfSoil";
            //sqlConnectionStringBuilder.DataSource = dataSource;

            connectionString = sqlConnectionStringBuilder.ToString();
        }

        public void CheckConnection()
        {
            sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();
            }
            catch (Exception)
            {

                MessageBox.Show("can't open Database", "Warning", MessageBoxButtons.OK);
            }
            
        }

    }
}
