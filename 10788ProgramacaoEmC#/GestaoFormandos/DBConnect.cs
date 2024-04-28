using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace GestaoFormandos
{
    internal class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string username;
        private string password;
        private string port;

        //Construtor
        public DBConnect()
        {
            Initialize();
        }

        //valores do Initialize
        private void Initialize()
        {
            server = "Win_Programador";
            username = "programador";
            password = "Formacao2024";
            port = "3306";
            database = "gestaoFormandos";
            string connectionString = "Server = " + server + "; Port = " + port + "; Database = " + 
                database + "; Uid = " + username + "; Pwd = " + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        //Abrir conexão
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException e) 
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        //Fechar conexao
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        //Testar conexao
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
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return connection.State.ToString();
        }

        public int Count()
        {
            int count = -1;
            string query = "select count(*) from formando;";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    count = int.Parse(cmd.ExecuteScalar().ToString());
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                CloseConnection();
            }
            return count;
        }

        public int DevolveUltimoID()
        {
            int ultimoID = 0;
            string query = "select max(id_formando) from formando;";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    //ultimoID = int.Parse(cmd.ExecuteScalar().ToString());
                    int.TryParse(cmd.ExecuteScalar().ToString(), out ultimoID);
                    ultimoID++;
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
            return ultimoID;
        }

        public bool Inserir(string id_formando, string nome, string morada, string contacto,
            string iban, char sexo, string data_nascimento)
        {
            bool flag = true;

            string query = "insert into formando (id_formando, nome, morada, contacto, iban, sexo, data_nascimento) values ("+ id_formando + ", '" + 
                nome + "', '" + morada + "', "+ contacto + ", '" + iban + "','" + sexo + "', '" + data_nascimento + "');"; 

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

        public bool PesquisaFormando(string id_pesquisa, ref string nome, ref string morada, ref string contacto,
            ref string iban, ref char sexo, ref string data_nascimento)
        {
            bool flag = false;

            string query = "select nome, morada, contacto, iban, sexo, data_nascimento from formando " +
                "where id_formando = '" + id_pesquisa + "';";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        nome = dataReader.GetString(0);
                        morada = dataReader[1].ToString();
                        contacto = dataReader["contacto"].ToString();
                        iban = dataReader[3].ToString();
                        sexo = dataReader["sexo"].ToString()[0];
                        data_nascimento = dataReader[5].ToString();
                        flag = true;
                    }
                    dataReader.Close();
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
            return flag;
        }

        public bool Delete(string id)
        {
            bool flag = true;

            string query = "delete from formando where id_formando = '" + id + "';";

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
