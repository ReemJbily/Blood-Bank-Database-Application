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
    public partial class Form6 : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source =localhost;port=3306; Initial Catalog=blood_bank;UserId=root;password=12345");
        public Form6()
        {
            InitializeComponent();
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 nf2 = new Form2();
            nf2.Show();
            this.Close();
        }
  

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {

                MySqlCommand cmd = new MySqlCommand("updatebloodbank", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_BloodBank_ID", Convert.ToInt32(BloodBank_ID.Text));
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
            
           MySqlDataAdapter da = new MySqlDataAdapter("ViewBloodBankInformation", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;//to use the bookviewall procedure
            DataTable dt = new DataTable();
            da.Fill(dt);// to put values in dt
            dataGridView1.DataSource = dt;
           
        }

        void clear()
        {
            BloodBank_ID.Text =BloodBank_address.Text = BloodBank_Name.Text ="";

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {

                MySqlDataAdapter da = new MySqlDataAdapter("viewbloodbank", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;//to use the serachbyvalue procedure
                da.SelectCommand.Parameters.AddWithValue("_BloodBank_ID", Convert.ToInt32(txtsearch.Text));
                DataTable dt = new DataTable();
                da.Fill(dt);// to put values in dt
                dataGridView1.DataSource = dt;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            con.Open();
            fillgrid();
            con.Close();
        }

        private void btnshowaddress_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("viewaddress", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("_Address_ID", Convert.ToInt32(BloodBank_address.Text));
            DataTable dt = new DataTable();
            da.Fill(dt);// to put values in dt
            dataGridView1.DataSource = dt;
            //con.Close();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            con.Open();
            fillgrid();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "select * from donor where BloodBank_ID=" + BloodBank_ID.Text + " and BloodBank_address =" + BloodBank_address + ";";
            MySqlDataAdapter da = new MySqlDataAdapter(s, con);
            DataTable dt = new DataTable();
            da.Fill(dt);// to put values in dt
            dataGridView1.DataSource = dt;
        }
    }
}
