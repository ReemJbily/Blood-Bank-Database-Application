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
    
    public partial class Form8 : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source =localhost;port=3306; Initial Catalog=blood_bank;UserId=root;password=12345");
        public Form8()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("addnewhospitalinformation", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_hospital_name", txtname.Text.Trim());
                cmd.Parameters.AddWithValue("_hospital_address", Convert.ToInt32(txtaddress.Text.Trim()));
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
            MySqlDataAdapter da = new MySqlDataAdapter("ViewhospitalInformation", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);// to put values in dt
            dataGridView1.DataSource = dt;
          
        }


        void clear()
        {
            txtid.Text = txtname.Text =txtaddress.Text= "";

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
           

            con.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("deletehospitalinformation", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_hospital_ID", Convert.ToInt32(txtid.Text.Trim()));
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("updatehospital", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_hospital_ID", Convert.ToInt32(txtid.Text.Trim()));
                cmd.Parameters.AddWithValue("_hospital_name", txtname.Text.Trim());
                cmd.Parameters.AddWithValue("_hospital_address", Convert.ToInt32( txtaddress.Text.Trim()));
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
                MySqlDataAdapter da = new MySqlDataAdapter("showhospital", con);

                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("_hospital_ID", Convert.ToInt32(txtsearch.Text.Trim()));
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

        private void btnshowaddress_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("viewaddress", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("_Address_ID", Convert.ToInt32(txtaddress.Text));
                DataTable dt = new DataTable();
                da.Fill(dt);// to put values in dt
                dataGridView1.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 nf2 = new Form2();
            nf2.Show();
            this.Close();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            con.Open();
            fillgrid();
            clear();
            con.Close();
        }
    }
}
