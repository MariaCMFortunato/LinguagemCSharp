using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GestaoFormacao_PF
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
            database = "DBGestaoFormacao";
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

        public int DevolveUltimoIDFormando()
        {
            int utimoID = 0;
            string query = "select max(IDFormando) from formando;";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
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




        public bool InserirFormando(string idFormando, string nif, string nome, string localidade, string dataNasc, string sitEmprego)
        {
            bool flag = true;

            string query = "insert into  formando (IDFormando, NIF, Nome, Localidade, DataNascimento, SituacaoEmprego) " +
                " values ('" + idFormando + "', '" + nif + "', '" + nome + "', '" + localidade + "', '" +  dataNasc +
                "', '" + sitEmprego + "'); ";

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

        public bool PesquisarFormando(string idPesquisa, ref string nif, ref string nome, ref string localidade, 
            ref string dataNascimento, ref string situacaoEmprego)
        {
            bool flag = false;

            string query = "select  NIF, Nome, Localidade, DataNascimento, SituacaoEmprego from formando " +
                " where IDFormando = '" + idPesquisa + "';";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    
                    while (dr.Read())
                    {
                        nif = dr[0].ToString();
                        nome = dr[1].ToString();
                        localidade = dr[2].ToString();
                        dataNascimento = dr[3].ToString();
                        situacaoEmprego = dr[4].ToString();
                        flag = true;
                    }
                    dr.Close();
                }
            }
            catch(MySqlException ex)
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

        public bool UpdateFormando( string IDFormando, string nif, string nome, string localidade, 
            string dataNasc, string sitEmprego)
        {
            bool flag = true;

            string query = "update formando set NIF= '" + nif + "', Nome ='" + nome + "', Localidade = '" + localidade + 
                "', DataNascimento = '" + dataNasc + "', SituacaoEmprego = '" + sitEmprego + "' where IDFormando = '" + IDFormando + "';";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
            }
            catch(MySqlException ex)
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

        public bool ApagarFormando(string id)
        {
            bool flag = true;

            string query = "delete from formando where IDFormando = '" + id + "'; ";

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

        public void PreencherDGVFormando(ref DataGridView dgv)
        {
            string query = "select IDFormando, NIF, Nome, Localidade, DataNascimento, SituacaoEmprego from formando order by nome;";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    int idxLinha = 0;
                    while (dr.Read())
                    {

                        string sitEmp = "";

                        if (dr[5].ToString().Equals("1"))
                        {
                            sitEmp = "Empregado";
                        }

                        if (dr[5].ToString().Equals("2"))
                        {
                            sitEmp = "Desempregado à procura 1º emprego";
                        }

                        if (dr[5].ToString().Equals("3"))
                        {
                            sitEmp = "Empregado à procura de novo emprego";
                        }

                        dgv.Rows.Add();
                        dgv.Rows[idxLinha].Cells["ID"].Value = dr[0].ToString();
                        dgv.Rows[idxLinha].Cells["NIF"].Value = dr[1].ToString();
                        dgv.Rows[idxLinha].Cells["Nome"].Value = dr[2].ToString();
                        dgv.Rows[idxLinha].Cells["Localidade"].Value = dr[3].ToString();
                        dgv.Rows[idxLinha].Cells["DataNascimento"].Value = DateTime.Parse(dr[4].ToString()).ToString("dd-MM-yyyy");
                        dgv.Rows[idxLinha].Cells["SituacaoEmprego"].Value = sitEmp;


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

        public int DevolveUltimoIDFormador()
        {
            int utimoID = 0;
            string query = "select max(IDFormador) from formador;";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
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

        public bool InserirFormador(string idFormador, string nif, string nome, string localidade, string area, string certificado)
        {
            bool flag = true;

            string query = "insert into formador (IDFormador, NIF, Nome, Localidade, Area, Certificado) " +
                " values ('" + idFormador + "', '" + nif + "', '" + nome + "', '" + localidade + "', '" + area +
                "', '" + certificado + "'); ";

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

