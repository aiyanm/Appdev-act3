using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace appdev_PETA
{
    public class Database
    {
        private string connStr;
        string username;
        DataTable dt;
        OleDbDataAdapter adapter = new OleDbDataAdapter();
        OleDbConnection conn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();


        //Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kyle_\Downloads\DB-ACT3.mdb
        public Database()
        {
            this.connStr = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:/Users/kyle_/Downloads/DB-ACT3.mdb";
            this.conn = new OleDbConnection(connStr);
            
        }
        
        //PROPERTY para sa connection faking string
        public OleDbConnection Connection { get { return this.conn; } }

        public void Login(string username, string password)
        {

            
            string query = "SELECT username, password from [account] WHERE password = @pword and username = @uname";
            
            if(Connection.State != System.Data.ConnectionState.Open)
            {
                this.Connection.Open();
            }
            using (cmd = new OleDbCommand(query, this.Connection ))
            {
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("password", password);
                    
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    frmMain frm = new frmMain(reader["username"].ToString());
                    frm.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Credentials are incorrect", "Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            Connection.Close();
        }

        public void Search(string name, string sex, DataGridView grd)
        {
            string query = "SELECT empid, name as NAME, email as EMAIL, sex as SEX ,address as ADDRESS from [employee] WHERE name LIKE @name and sex = @sex ";
            
            if(this.Connection.State != ConnectionState.Open)
            {
                this.Connection.Open();
            }
            using (cmd = new OleDbCommand(query,this.Connection ))
            {
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@sex", sex);
                
                using(adapter = new OleDbDataAdapter(cmd))
                {
                    using(dt = new DataTable())
                    {
                        adapter.Fill(dt);
                        grd.DataSource = dt;
                        grd.Columns["empid"].Visible = false;
                    }
                }
            }
        }

        public void TextchangeSeacrch(string name, string gender, DataGridView grd)
        {
            string query = "SELECT [empid], name as NAME, email as EMAIL, sex as SEX ,address as ADDRESS from [employee] WHERE name LIKE ? and sex = ?";

            if (this.Connection.State != System.Data.ConnectionState.Open)
            {
                this.Connection.Open();
            }

            using (cmd = new OleDbCommand(query, this.Connection))
            {
                cmd.Parameters.AddWithValue("?", name + "%");
                cmd.Parameters.AddWithValue("?", gender);

                using (adapter = new OleDbDataAdapter(cmd))
                {
                    using (DataTable dt = new DataTable())
                    {
                        adapter.Fill(dt);
                        grd.DataSource = dt;
                        grd.Columns["empid"].Visible = false;
                    }

                }

                Connection.Close();

            }
        }
        public void SearchALL ( DataGridView grd)
        {
            string query = "SELECT [empid], name as NAME, email as EMAIL, sex as SEX ,address as ADDRESS FROM [employee]";
            if(this.Connection.State != ConnectionState.Open)
            {
                this.Connection.Open();
            }

                using (adapter=new OleDbDataAdapter(query, this.Connection))
                {
                    using(dt = new DataTable())
                    {
                        adapter.Fill(dt);
                        grd.DataSource= dt;

                        grd.Columns["empid"].Visible = false;
                    }
                    
                }
            
        }
        public void SearchSex(string sex,DataGridView grd)
        {
            string query = "SELECT [empid], name as NAME, email as EMAIL, sex as SEX ,address as ADDRESS FROM [employee] where sex = @sex";
           
            if (this.Connection.State != ConnectionState.Open)
            {
                this.Connection.Open();
            }
            using (cmd = new OleDbCommand(query, this.Connection))
            {
                cmd.Parameters.AddWithValue("@sex", sex);

                using (adapter = new OleDbDataAdapter(cmd))
                {
                    using (dt = new DataTable())
                    {
                        adapter.Fill(dt);
                        grd.DataSource = dt;

                        grd.Columns["empid"].Visible = false;
                    }

                }
            }
            this.Connection.Close();
        }

        public void SearchFEMALE(string female, DataGridView grd)
        {
            string query = "SELECT [empid], name as NAME, email as EMAIL, sex as SEX ,address as ADDRESS FROM [employee] where sex = @sex";
            if (this.Connection.State != ConnectionState.Open)
            {
                this.Connection.Open();
            }
            using (cmd = new OleDbCommand(query, this.Connection))
            {
                cmd.Parameters.AddWithValue("@sex", female);
            }
            using (adapter = new OleDbDataAdapter(cmd))
            {
                using (dt = new DataTable())
                {
                    adapter.Fill(dt);
                    grd.DataSource = dt;

                    grd.Columns["empid"].Visible = false;
                }

            }
        }

            public void addData(string name, string email, string sex, string address)
        {
            string query = " INSERT INTO [employee] (name,email,sex,address) VALUES(?, ?, ?, ?)";

            if (Connection.State != ConnectionState.Open) 
            {
                this.Connection.Open();
            }

            using(cmd = new OleDbCommand(query,Connection))
            {
                cmd.Parameters.AddWithValue("?",name);
                cmd.Parameters.AddWithValue("?",email);
                cmd.Parameters.AddWithValue("?",sex);
                cmd.Parameters.AddWithValue("?",address);
                cmd.ExecuteNonQuery();

                int res = cmd.ExecuteNonQuery();

                if (res > 0)
                {
                    MessageBox.Show("Successfully Added", "Add Data");
                    
                }
             
            }
            Connection.Close();
        }

        public void editData(int id, string name, string email, string address)
        {
            string query = "UPDATE [employee] SET name = ?, email = ?, address = ? WHERE [empid] = ? ";
            
            if (conn.State != ConnectionState.Open)
            {
                Connection.Open();
            }
            using(cmd = new OleDbCommand(query,this.Connection))
            {
                cmd.Parameters.AddWithValue("?", name);
                cmd.Parameters.AddWithValue("?", email);
                cmd.Parameters.AddWithValue("?", address);
                cmd.Parameters.AddWithValue("?", id);
                cmd.ExecuteNonQuery();

                int res = cmd.ExecuteNonQuery();

                if (res > 0) 
                {
                    MessageBox.Show("Data has been Updated", "Update");
                }
            }
            this.Connection.Close();
        }

        public void deleteData(string name, string email)
        {
            string query = "DELETE from [employee] where name =? and email =?";

            if(conn.State != System.Data.ConnectionState.Open)
            {
                this.Connection.Open();
            }
            using(cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("?", name);
                cmd.Parameters.AddWithValue("?", email);
                cmd.ExecuteNonQuery();

                int res = cmd.ExecuteNonQuery();

                if(res > 0)
                {
                    MessageBox.Show("The Data is Successfully Deleted", "Delete");
                }

            }
        }
    }
}

