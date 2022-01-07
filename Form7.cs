using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace third_attempt
{
    public partial class Form7 : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source =localhost;port=3306; Initial Catalog=blood_bank;UserId=root;password=12345");
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("addingloginInformation", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_user_id", Convert.ToInt32(txtid.Text.Trim()));
                cmd.Parameters.AddWithValue("_pwd", txtpwd.Text.Trim());
                cmd.ExecuteNonQuery();
                fillgrid();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }


        void fillgrid()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("viewusers", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);// to put values in dt
            dataGridView1.DataSource = dt;
            //con.Close();
        }


        void clear()
        {
            txtid.Text = txtpwd.Text = "";

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            con.Open();
            fillgrid();
            con.Close();

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("updatelogin", con);
                cmd.CommandType = CommandType.StoredProcedure;                
                cmd.Parameters.AddWithValue("_user_id", Convert.ToInt32(txtid.Text.Trim()));
                cmd.Parameters.AddWithValue("_pwd", txtpwd.Text.Trim());
                cmd.ExecuteNonQuery();
                fillgrid();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("deleteuser", con);
                cmd.CommandType = CommandType.StoredProcedure;                
                cmd.Parameters.AddWithValue("_User_id", Convert.ToInt32( txtid.Text.Trim()));               
                cmd.ExecuteNonQuery();
                fillgrid();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("loginp", con);

                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("_user_id", Convert.ToInt32(txtsearch.Text.Trim()));
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {               
                fillgrid();
                clear();              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 nf = new Form2();
            nf.Show();
            this.Close();
        }

        private void btnshowEmp_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("showemployee", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("_Employee_ID", Convert.ToInt32(txtid.Text.Trim()));
                DataTable dt = new DataTable();
                da.Fill(dt);// to put values in dt
                dataGridView1.DataSource = dt;
                //con.Close();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }
    }
    }

