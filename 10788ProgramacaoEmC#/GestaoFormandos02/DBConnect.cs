﻿using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System.Data;
using System.Windows.Forms;

namespace GestaoFormandos02
{
    internal class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string username;
        private string password;
        private string database;
        private string port;   
        
        //Construtor
        public DBConnect()
        {
            Initialize();
        }

        //Método de inicicialização
        private void Initialize()
        {
            server = "Win_Programador";
            username = "programador";
            password = "Formacao2024";
            database = "gestaoFormandos";
            port = "3306";
            string connectionString = "Server=" + server + ";Port=" + port + ";Database=" + database + ";Uid=" + username + ";Pwd=" + password + ";";
            connection = new MySqlConnection(connectionString); 
        }

        //Método de abertura da ligação
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

        //Método de fecho da ligação
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

        //Método para verifcação do estado da licação
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

        public int DevolveUltimoID()
        {
            int utimoID = 0;
            string query = "select max(id_formando) from formando;";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    //utimoID = int.Parse(cmd.ExecuteScalar().ToString());
                    int.TryParse(cmd.ExecuteScalar().ToString(), out utimoID);
                    //Porque o valor recebido pode ser um null
                    utimoID++;
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
            return utimoID;
        }

        public bool Inserir(string id_formando, string nome, string morada, string contacto,
            string iban, char sexo, string data_nascimento)
        {
            bool flag = true;

            string query = "insert into formando (id_formando, nome, morada, contacto, iban, sexo, data_nascimento) values (" + id_formando + ", '" +
                nome + "', '" + morada + "', '" + contacto + "', '" + iban + "','" + sexo + "', '" + data_nascimento + "');";

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
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        nome = dr.GetString(0);
                        morada = dr[1].ToString();
                        contacto = dr["contacto"].ToString();
                        iban = dr[3].ToString();
                        sexo = dr["sexo"].ToString()[0];
                        data_nascimento = dr[5].ToString();

                        flag = true;
                    }
                    dr.Close();
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
                    //nunca dá erro
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

        public void PreencherDataGridViewFormando(ref DataGridView dgv)
        {
            string query = "select id_formando, nome, iban, contacto, sexo from formando order by nome;";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    int idxLinha = 0;
                    while (dr.Read())
                    {
                        dgv.Rows.Add();
                        dgv.Rows[idxLinha].Cells["codID"].Value = dr[0].ToString();
                        dgv.Rows[idxLinha].Cells["nome"].Value = dr["Nome"].ToString();
                        dgv.Rows[idxLinha].Cells["iban"].Value = dr["IBAN"].ToString();
                        dgv.Rows[idxLinha].Cells["contacto"].Value = dr["Contacto"].ToString();
                        dgv.Rows[idxLinha].Cells["genero"].Value = dr["sexo"].ToString()[0];
                        idxLinha++;
                    }
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
        }

        public bool InserirNacionalidade(string iso2, string nacionalidade)
        {
            bool flag = true;

            string query = "insert into nacionalidade (id_nacionalidade, alf2, nacionalidade) values (0, '" + iso2  + "', '" + nacionalidade + "');";

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

        public bool DeleteNacionalidade(string id_nacional)
        {

            bool flag = true;
            string query = "delete from nacionalidade where id_nacionalidade = '" + id_nacional + "';";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    //nunca dá erro
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

        public void PreencherDGVNacionalidade(ref DataGridView dgv)
        {
            string query = "select id_nacionalidade, alf2, nacionalidade from nacionalidade order by alf2;";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    int idxLinha = 0;
                    while (dr.Read())
                    {
                        dgv.Rows.Add();
                        dgv.Rows[idxLinha].Cells["ID"].Value = dr[0].ToString();
                        dgv.Rows[idxLinha].Cells["alf2"].Value = dr["ALF2"].ToString();
                        dgv.Rows[idxLinha].Cells["nacionalidade"].Value = dr[2].ToString();
                        idxLinha++;
                    }
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
        }
    }

}
