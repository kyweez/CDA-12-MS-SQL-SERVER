using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace ClassLibrarySQLServerDataAccess
{
    public class ConnectionSqlServer
    {
        #region ############### PROPERTIES ###############
        public SqlConnection SqlConnect
        {
            get; private set;
        }

        public List<string> ServerNameList
        {
            get; private set;
        }
        public List<string> DataBaseNameList
        {
            get; private set;
        }
        #endregion

        #region ############### CONSTRUCTOR ###############
        public ConnectionSqlServer()
        {
            SqlConnect = new SqlConnection();
            ServerNameList = new List<string>();
            DataBaseNameList = new List<string>();
            foreach (ConnectionStringSettings _connectionString in ConfigurationManager.ConnectionStrings)
            {
                if (_connectionString.ConnectionString.Contains("Data Source="))
                {
                    ServerNameList.Add(GetServerName(_connectionString.ConnectionString));
                    DataBaseNameList.Add(GetDataBaseName(_connectionString.ConnectionString));
                }
            }
        }
        #endregion

        #region ############### EVENTS ###############
        public delegate void DelegateConnectionStatus();
        public event DelegateConnectionStatus StatusChanged;

        public delegate void DelegateConnectionFailed(string failedConnection);
        public event DelegateConnectionFailed ConnectionFailed;
        #endregion

        #region ############### METHODS ###############
        private string GetServerName(string _connectionString)
        {
            //first cut
            int firstCut = _connectionString.IndexOf("=") + 1;
            string substring = _connectionString.Substring(firstCut);
            //second cut
            int secondCut = substring.IndexOf(";");
            substring = substring.Substring(0, secondCut);
            return substring;
        }

        private string GetDataBaseName(string _connectionString)
        {
            //first cut
            int firstCut = _connectionString.IndexOf(";") + 1;
            string substring = _connectionString.Substring(firstCut);
            //second cut
            int secondCut = substring.IndexOf("=") + 1;
            substring = substring.Substring(secondCut);
            //third cut
            int thirdCut = substring.IndexOf(";");
            return substring.Substring(0, thirdCut);
        }

        public bool ConnectToDatabase(string _serverName, string _dataBaseName)
        {
            SqlConnect.ConnectionString = $"Data Source={_serverName};Initial Catalog={_dataBaseName};Integrated Security=True";

            try
            {
                SqlConnect.Open();
            }
            catch (SqlException ex)
            {
                string errorMessage = "";
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessage += $"\nError number {i} :\n" +
                        $"Message : {ex.Errors[i].Message}\n" +
                        $"Error Code : {ex.ErrorCode}\n" +
                        $"Error number : {ex.Errors[i].Number}\n";
                }
                if (ConnectionFailed != null)
                    ConnectionFailed(errorMessage);
                SqlConnect.Close();
                return false;
            }
            finally
            {
                StatusChanged();
            }
            return true;
        }

        public void DisconnectFromDatabase()
        {
             if (SqlConnect != null)
                SqlConnect.Close();
            StatusChanged();
        }
        #endregion
    }
}