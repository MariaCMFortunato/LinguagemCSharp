using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SGCentroFormacaoProjFinal
{
    internal class DBconnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string username;
        private string password;
        private string port;

        public DBconnect()
        {
            Inicialize();
        }

        private void Inicialize()
        {
            server = "Win_Programador";
            username = "programador";
            password = "Formacao2024";
            database = "DBCentroFormacao";
            port = "3306";

            string connectionString = "Server=" + server + ";Port=" + port + ";Database=" + database + ";Uid=" + username + ";Pwd=" + password + ";";
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

        public string StatusConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                else
                {
                    connection.Close();
                }
            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return connection.State.ToString();
        }

        //Método para contagem dos registos na BD
        public int Contar()
        {
            int count = -1;
            string query = "select count(*) from fichaPessoal;";
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
        public bool InserirFicha (string nif, string niss, string nome, string morada, string telemovel, string email, string dataNasc, string iban,
            string funcao, string habLiterarias, char estado)
        {
            bool flag = true;

            string query = "insert into  fichaPessoal (NIF, NISS, Nome, Morada, Telemovel, Email, DataNascimento, IBAN, Funcao, HabLiterarias, Estado) " +
                " values ('" + nif + "', '" + niss + "', '" + nome + "', '" + morada + "', '" + telemovel + "', '" + email + "', '"+ dataNasc + 
                "', '" + iban + "', '" + funcao + "', '" + habLiterarias + "', '" + estado+ "');";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
            }
            finally
            {
                CloseConnection();
            }

            return flag;
        }

    }

   
}
