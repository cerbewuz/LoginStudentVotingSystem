using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;
namespace LoginStudentVotingSystem
{
    internal class GlobalProcedure
    {
        public string servername;
        public string databasename;
        public string username;
        public string password;
        public string port;

        public MySqlConnection sqlConnection;
        public MySqlCommand sqlCommand;
        public String strConnection;


        public MySqlDataAdapter sqlAdapterStudent;
        public DataTable datStudent;


        public bool funcDatabaseConnection()
        {
            try
            {
                servername = "127.0.0.1";
                databasename = "studentvotingsystemdb";
                username = "root";
                password = "";


                strConnection = "server=" + servername + ";" +
                                "database=" + databasename + ";" +
                                "user=" + username + ";" +
                                "password=" + password + ";" +
                                "Convert Zero Datetime=true";
                sqlConnection = new MySqlConnection(strConnection);

                sqlConnection.Open();

                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlCommand = new MySqlCommand { Connection = sqlConnection };
                    return true;
                }
                else
                {
                    sqlConnection.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return false;
        }



        public void checkkDbConnection()
        {
            if (!funcDatabaseConnection())
            {
                sqlConnection.Open();
            }
            else
            {
                // do nothing, just open the connection
            }
        }
    }
}
