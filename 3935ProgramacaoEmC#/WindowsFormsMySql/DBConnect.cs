using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" +
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

        public int DevolveUltimoId()
        {
            string query = "select max(id_formando) from formando;";
            int ultimoID = 0;

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    int.TryParse(cmd.ExecuteScalar().ToString(), out ultimoID);
                    //ultimoID = int.Parse(cmd.ExecuteScalar().ToString());
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


        public void Insert()
        {
            string query = "Insert into formando values ('101','Frederico Varandas','Rua do Sporting','NULL'" +
                        "'000000000','M','1979-09-19');";
            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();

                CloseConnection();
            }
        }

        public bool Insert(string id_formando, string nome, string morada, string contacto,
            string iban, char genero, string dataNascimento)
        {
            string query = "Insert into formando (id_formando, nome, morada, contacto, iban, sexo, " +
                "data_nascimento)" + " values" + "('" + id_formando + "','" + nome + "','" + morada +
                "','" + contacto + "','" + iban + "','" + genero + "','" + dataNascimento + "');";

            bool flag = false;
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    flag = true;
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

        public bool PesquisaFormando(string idpesquisa, ref string nome, ref string morada,
            ref string contacto, ref string iban, ref char genero, ref string data_nascimento)
        {
            string query = "Select nome, morada, contacto, iban, sexo, data_nascimento " +
                "from formando where id_formando = " + idpesquisa;
            bool flag = false;

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        nome = dataReader[0].ToString();
                        morada = dataReader["morada"].ToString();
                        contacto = dataReader["contacto"].ToString();
                        iban = dataReader[3].ToString();
                        genero = dataReader[4].ToString()[0];
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

        public bool Update(string id_formando, string nome, string morada, string contacto,
            string iban, char genero, string dataNascimento)
        {
            string query = "update formando set nome = '" + nome + "', morada = '" + morada +
                "', contacto = '" + contacto + "', iban = '" + iban + "', sexo = '" + genero +
                "', data_nascimento = '" + dataNascimento + "' where id_formando = " + id_formando;


            bool flag = false;
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    flag = true;
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
        public void PreencherDataGridView(ref DataGridView dgv, char genero)
        {
            string query = "select id_formando, nome, iban, data_nascimento, sexo from formando";
            if (genero != 'T' && genero != ' ')
            {
                query = query + " where sexo = '" + genero + "'";
            }
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    int idxlinha = 0;

                    while (dataReader.Read())
                    {
                        dgv.Rows.Add();
                        dgv.Rows[idxlinha].Cells["codID"].Value = dataReader[0].ToString();
                        dgv.Rows[idxlinha].Cells[1].Value = dataReader[1].ToString();
                        dgv.Rows[idxlinha].Cells["iban"].Value = dataReader[2].ToString();
                        dgv.Rows[idxlinha].Cells[3].Value = DateTime.Parse(dataReader[3].ToString()).ToString("dd-MM-yyyy");
                        dgv.Rows[idxlinha].Cells["genero"].Value = dataReader[4].ToString();
                        idxlinha++;
                    }

                    dataReader.Close();
                }
            }
            //catch (MySqlException ex)
            //{
            //   MessageBox.Show(ex.Message);
            //}
            finally
            {
                CloseConnection();

            }
        }

        public bool Delete(string id_formando)
        {
            string query = "delete from formando where id_formando = '" + id_formando+"'";


            bool flag = false;
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    flag = true;
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
    }
}
