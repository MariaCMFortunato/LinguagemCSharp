using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMySql
{
    internal class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string username;
        private string password;
        private string port;
        
        public DBConnect()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "grandeporto.ddns.net";
            database = "formandos_prog23224";
            username = "Programador23224";
            password = "Dados@2023";
            port = "3306";

            string connectionString;
            connectionString ="SERVER=" + server + ";" + "DATABASE=" + database + ";" + 
                "UID=" + username + ";" + "PASSWORD=" + password + ";" + "PORT=" + port + ";";
            connection = new MySqlConnection(connectionString);

        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex) 
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public int Count()
        {
            string query = "select count(*) from formando;";
            int count = -1;

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    count = int.Parse(cmd.ExecuteScalar().ToString());
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            { 
                CloseConnection();
            } 
            return count;
        }
    }
}
