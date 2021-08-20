using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using SimbirSoftProj.Core.Log;
using SimbirSoftProj.Core.DBConnection;

namespace SimbirSoftProj.Core
{
    public class DBConnector
    {
        SqlConnection connection;

        public DBConnector(IDBSettings settings)
        {
            connection = new SqlConnection(settings.ConnectionString);
        }
        public void FillTableWithData(Dictionary<string,int> countedWords)
        {
            try
            {
                if (!TableAlreadyExists())
                {
                    CreateTable();
                }
                foreach (var word in countedWords)
                {
                    string comandSting = $"INSERT INTO CountedWords (Word,Count) VALUES (\'{word.Key}\',{word.Value})";
                    ExecuteCommand(comandSting);
                }
            }
            catch(Exception ex)
            {
                Logger.WriteLog($"Failed to load data into table. [ {ex.Message} ]");
            }
            
        }
       
        bool TableAlreadyExists()
        {
            DataTable schemaTable = connection.GetSchema("Tables");
            foreach (DataRow r in schemaTable.Rows)
            {
                if ((string)r[2] == "CountedWords")
                    return true;
            }
            return false;
        }
        void CreateTable()
        {
            string comandString = "CREATE TABLE dbo.CountedWords"
           + "(Word varchar(255) NOT NULL,"
           + "Count int NOT NULL);";
            ExecuteCommand(comandString);
        }
      
        void ExecuteCommand(string commandString)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(commandString, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable DT = new DataTable();
                adapter.Fill(DT);
                Logger.WriteLog($"Command {commandString} was executed.");
            }
            catch(Exception ex)
            {
                Logger.WriteLog($"Command {commandString} was not executed. [ {ex.Message} ]");
            }
            
        }
        public void OpenConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    Logger.WriteLog("Database connection opened.");
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog($"Failed to open connection. Check the server name. [{ex.Message}]");
            }

        }
        public void CloseConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    Logger.WriteLog("Database connection closed.");
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog($"Failed to close connection. [{ex.Message}]");
            }
        }
    }
}
