using iTextSharp.text.pdf.parser;
using MySql.Data.MySqlClient;
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
            string iban, char sexo, string data_nascimento, string id_nacionalidade)
        {
            bool flag = true;

            string query = "insert into formando (id_formando, nome, morada, contacto, iban, sexo, " + 
                "data_nascimento, id_nacionalidade) values (" + id_formando + ", '" + nome + "', '" +
                 morada + "', '" + contacto + "', '" + iban + "','" + sexo + "', '" + data_nascimento +
                 "', '" + id_nacionalidade + "');";

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
            ref string iban, ref char sexo, ref string data_nascimento, ref string id_nacionalidade)
        {
            bool flag = false;

            string query = "select nome, morada, contacto, iban, sexo, data_nascimento, id_nacionalidade from formando " +
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
                        id_nacionalidade = dr[6].ToString();

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

        public bool Update(string id_formando, string nome, string morada, string contacto,
            string iban, char sexo, string data_nascimento, string id_nacionalidade)
        {
            bool flag = true;

            string query = "update formando set nome = '" + nome + "', morada = '" + morada + "', contacto = '" + 
                contacto + "', " + "iban = '" + iban + "', sexo = '" + sexo + "', data_nascimento = '" + 
                data_nascimento + "', id_nacionalidade = '" + id_nacionalidade + "'  where id_formando = '" + id_formando + "';";

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

        public void PreencherDataGridViewFormando(ref DataGridView dgv)
        {
            string query = "select * from vFormandoNacionalidade order by nome;";

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
                        dgv.Rows[idxLinha].Cells["nacionalidade"].Value = dr["Nacionalidade"].ToString();
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

        public void PreencherDataGridViewFormando(ref DataGridView dgv, char genero, string nome, string id_nacionalidade)
        {
            string query = "select id_formando, nome, iban, contacto, sexo, nacionalidade from vFormandoNacionalidade ";

            if (genero != 'T' && nome.Length > 0 && id_nacionalidade.Length > 0)
            {
                query = query + " where sexo = '" + genero + "' and nome like '%" + nome + "%' and id_nacionalidade = '" + id_nacionalidade + "'";
            }

            else if (genero != 'T')
            {
                query = query + " where sexo = '" + genero + "' ";

                if (nome.Length > 0)
                {
                    query = query + " and nome like '%" + nome + "%' ";
                }

                else if (id_nacionalidade.Length > 0)
                {
                    query = query + " and id_nacionalidade = '" + id_nacionalidade + "'";
                }
            }

            else if (nome.Length > 0)
            {
                query = query + " where nome like '%" + nome + "%' ";

                if (id_nacionalidade.Length > 0)
                {
                    query = query + " and id_nacionalidade = '" + id_nacionalidade + "'";
                }
            }

            else if (id_nacionalidade.Length > 0)
            {
                query = query + " where id_nacionalidade = '" + id_nacionalidade + "' "; 
            }

            

            query = query + "order by nome;";

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
                        dgv.Rows[idxLinha].Cells["nacionalidade"].Value = dr["Nacionalidade"].ToString();
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

        /*public bool ValidateUser(string userName, string password, ref string id_user)
        {
            bool flag = false;

            try
            {
                string query = "select userRole from users where binary uname = '" + userName + "' and pwd = sha2('" + password + "',512);";

                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    
                    if(cmd.ExecuteScalar() != null)
                    {
                        id_user = cmd.ExecuteScalar().ToString();
                        flag = true;
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
            
            return flag;
        }*/

        public bool ValidateUser2(string userName, string password, ref string id_user)
        {
            bool flag = false;

            try
            {
                string query = "select nome_utilizador from utilizador where binary nome_utilizador = '" + userName + "' and senha = "
                    +"sha2('" + password + "',512) and estado = 'A';";

                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    if (cmd.ExecuteScalar() != null)
                    {
                        id_user = cmd.ExecuteScalar().ToString();
                        flag = true;
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
                if (flag)
                {
                    PUSuccessLogIn(userName,"S" );
                }
                else
                {
                    PUSuccessLogIn(userName, "U");
                }
                CloseConnection();
            }

            return flag;
        }

        private void PUSuccessLogIn(string userName, string result)
        {
            try
            {
                string query = "call pUSuccessLogIn('" + userName + "', '" + result + "');";

                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
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

        public bool ValidateUsersStatus(string userName, ref int nfalhas)
        {
            bool flag = false;

            try
            {
                string query = "select falhas from utilizador where nome_utilizador = '" + userName + "' and estado = 'I';";

                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    if(cmd.ExecuteScalar() != null)
                    {
                        nfalhas = int.Parse(cmd.ExecuteScalar().ToString());
                        flag = true;
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

            return flag ;
        }

        public void PreencherComboNacionalidade (ref ComboBox combo)
        {
            string query = "select id_nacionalidade, alf2, nacionalidade from nacionalidade " +
                "order by nacionalidade;";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        combo.Items.Add(dr[2].ToString() + " - " + dr["alf2"].ToString() +
                            " - " + dr[0].ToString());
                    }
                    dr.Close();
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

        public bool PesquisaNacionalidade(string id_nacionalidade, ref string alf2, ref string nacionalidade)
        {
            bool flag = false;
            string query = "select id_nacionalidade, alf2, nacionalidade from nacionalidade " +
                "where id_nacionalidade = '" + id_nacionalidade + "';";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        alf2 = dr["alf2"].ToString();
                        nacionalidade = dr[2].ToString();
                        flag = true;
                    }
                    dr.Close();
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

        public string DevolverNacionalidade(string id_nacionalidade)
        {
            string query = "select id_nacionalidade, alf2, nacionalidade from nacionalidade " +
                "where id_nacionalidade = '" + id_nacionalidade + "';";
            string nacionalidade = "";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        nacionalidade = dr[2].ToString() + " - " + dr["alf2"].ToString() +
                            " - " + dr[0].ToString();
                    }
                    dr.Close();
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
            return nacionalidade;
        }

        public void PreencherComboTabelas(ref ComboBox combo)
        {
            string query = "show tables;";
            combo.Items.Add("---");
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        combo.Items.Add(dr[0].ToString());
                    }
                    dr.Close();
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

        public void PreencherChkLstColunasTabelas(ref CheckedListBox chkLstBox, string tabela)
        {
            string query = "show columns from " + tabela + " ;";
            chkLstBox.Items.Clear();
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        chkLstBox.Items.Add(dr[0].ToString());
                    }
                    dr.Close();
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

        public void ExportarRegistosParaTextBox(ref TextBox txtDados, string[] colunas, 
            string tabela, string filtro ="")// se o filtro não tiver nada, vai como string vazia
        {
            string query = "select ";
            txtDados.Clear();

            for (int i = 0; i < colunas.Length; i++)
            {
                txtDados.Text = txtDados.Text + colunas[i].ToString() + ";";
                query = query + "`" + colunas[i] + "`" + ",";
            }
            query = query.Substring(0, query.Length - 1); //para tirar a última virgula
            query = query + " from  " + tabela + "  ;";
            
            if(filtro != "")
            {
                query = query.Substring(0, query.Length - 1);// para retirar o ;
                query = query + " where " + filtro + ";";
            }

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        txtDados.Text = txtDados.Text + "\r\n";
                        //dr.FieldCount ou coluna.Length

                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            txtDados.Text = txtDados.Text + dr[i].ToString() + ";";
                        }
                    }
                    dr.Close();
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

        public void PreencherComboColunasTabelas(ref ComboBox combo, string tabela)
        {
            string query = "show columns from " + tabela + " ;";
            combo.Items.Clear();
            combo.Items.Add("");
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        combo.Items.Add(dr[0].ToString());
                    }
                    dr.Close();
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

        public bool InserirArea(string idArea, string area)
        {
            bool flag = true;

            string query = "insert into area (id_area, area) values ('" + idArea + "', '" + area + "');";

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

        public int DevolveUltimoIDArea()
        {
            int utimoID = 0;
            string query = "select max(id_area) from area;";
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

        public bool PesquisaArea(string idArea, ref string area)
        {
            bool flag = false;
            string query = "select id_area, area from area " +
                "where id_area = '" + idArea + "';";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        area = dr[1].ToString();
                        flag = true;
                    }
                    dr.Close();
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
        public bool UpdateArea(string idArea, string area)
        {
            bool flag = true;

            string query = "update area set area = '" + area + "' where id_area = '" + idArea + "';";

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

        public bool DeleteArea(string idArea)
        {

            bool flag = true;
            string query = "delete from area where id_area = '" + idArea + "';";

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

        public void PreencherDGVArea(ref DataGridView dgv)
        {
            string query = "select id_area, area from area order by id_area;";

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
                        dgv.Rows[idxLinha].Cells["Area"].Value = dr[1].ToString();
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
            string query = "select max(id_formador) from formador;";
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

        public bool InserirFormador(string id_formador, string nome, string nif, 
            string data_nascimento, string id_area, string id_utilizador)
        {
            bool flag = true;

            string query = "insert into formador (id_formador, nome, nif, dataNascimento, " + 
                "id_area, id_utilizador) values (" + id_formador + ", '" + nome + "', '" +
                 nif + "', '" + data_nascimento + "', '" + id_area + "', '" + id_utilizador + "');";

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

        public void PreencherComboArea(ref ComboBox combo)
        {
            string query = "select id_area, area from area  order by area;";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    combo.Items.Add("");
                    while (dr.Read())
                    {
                        combo.Items.Add(dr[1].ToString() + " - " + dr[0].ToString());
                    }
                    dr.Close();
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

        public void PreencherComboUtilizador(ref ComboBox combo)
        {
            string query = "select id_utilizador, nome_utilizador from utilizador " +
                "order by nome_utilizador;";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    combo.Items.Add("");
                    while (dr.Read())
                    {
                        combo.Items.Add(dr[1].ToString() + " - " + dr[0].ToString());
                    }
                    dr.Close();
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

        public bool PesquisaFormador(string idFormador, ref string nome, ref string nif, 
            ref string dataNascimento, ref string idArea, ref string idUtilizador)
        {
            bool flag = false;

            string query = "select nome, nif, dataNascimento, id_area, id_utilizador from formador " +
                "where id_formador = '" + idFormador + "';";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        nome = dr.GetString(0);
                        nif = dr[1].ToString();
                        dataNascimento = dr[2].ToString();
                        idArea = dr[3].ToString();
                        idUtilizador = dr[4].ToString();

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

        public bool UpdateFormador(string idFormador, string nome, string nif, string dataNascimento, 
            string idArea, string idUtilizador)
        {
            bool flag = true;

            string query = "update formador set nome = '" + nome + "', nif = '" + nif + "', dataNascimento = '" +
                dataNascimento + "', id_area = '" + idArea + "', id_utilizador = '" + idUtilizador + 
                "'  where id_formador = '" + idFormador + "';";

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

        public string DevolverArea(string idArea)
        {
            string query = "select id_area, area from area " +" where id_area = '" + idArea + "';";
            
            string area = "";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        area = dr[1].ToString() + " - " + dr[0].ToString();
                    }
                    dr.Close();
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
            return area;
        }

        public string DevolverUtilizador(string idUtilizador)
        {
            string query = "select id_utilizador, nome_utilizador from utilizador " +
                "where id_utilizador = '" + idUtilizador + "';";
            string utilizador = "";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        utilizador = dr[1].ToString() + " - " + dr[0].ToString();
                    }
                    dr.Close();
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
            return utilizador;
        }

        public bool DeleteFormador(string id)
        {

            bool flag = true;
            string query = "delete from formador where id_formador = '" + id + "';";

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
    }
}
