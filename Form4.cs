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
    public partial class Form4 : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source =localhost;port=3306; Initial Catalog=blood_bank;UserId=root;password=12345");
        public Form4()
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("updateEmployeeValues", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_Employee_ID", Convert.ToInt32(txtid.Text.Trim()));
             
                cmd.Parameters.AddWithValue("_Employee_firstName", txtfirstname.Text.Trim());
                cmd.Parameters.AddWithValue("_Employee_lastName", txtlastname.Text.Trim());
                cmd.Parameters.AddWithValue("_phone", txtphone.Text.Trim());
                cmd.Parameters.AddWithValue("_age", Convert.ToInt32(txtage.Text.Trim()));
               
                cmd.Parameters.AddWithValue("_Employee_Job_Title", txtjobtitle.Text);
                cmd.Parameters.AddWithValue("_Employee_Job_Desc", txtjobdesc.Text);
                cmd.Parameters.AddWithValue("_Employee_address", Convert.ToInt32(txtaddress.Text.Trim()));
                cmd.Parameters.AddWithValue("_bloodbank_ID", Convert.ToInt32(txtbloodbank.Text.Trim()));


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
            //con.Open();


            MySqlDataAdapter da = new MySqlDataAdapter("ViewemployeeInformation", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);// to put values in dt
            dataGridView1.DataSource = dt;
            //con.Close();
        }

        void clear()
        {
            txtid.Text = txtfirstname.Text = txtlastname.Text = txtaddress.Text = txtage.Text = txtphone.Text = txtphone.Text = txtbloodbank.Text = txtjobtitle.Text = txtjobdesc.Text =  "";

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            clear();
            fillgrid();
            dataGridView1.Columns[0].Visible = true;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {

                MySqlCommand cmd = new MySqlCommand("deleteemployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_Employee_ID", Convert.ToInt32(txtid.Text.Trim()));

                cmd.ExecuteNonQuery();
                MessageBox.Show("deleted successfully");
                fillgrid();
                clear();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            con.Open();
            try {
                MySqlCommand cmd = new MySqlCommand("addnewemployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                //   cmd.Parameters.AddWithValue("_Emloyee_ID", Convert.ToInt32(txtid.Text.Trim()));

                cmd.Parameters.AddWithValue("_Employee_firstName", txtfirstname.Text.Trim());
                cmd.Parameters.AddWithValue("_Employee_lastName", txtlastname.Text.Trim());
                cmd.Parameters.AddWithValue("_phone", txtphone.Text.Trim());
                cmd.Parameters.AddWithValue("_age", Convert.ToInt32(txtage.Text.Trim()));

                cmd.Parameters.AddWithValue("_Employee_Job_Title", txtjobtitle.Text);
                cmd.Parameters.AddWithValue("_Employee_Job_Desc", txtjobdesc.Text);
                cmd.Parameters.AddWithValue("_Employee_address", Convert.ToInt32(txtaddress.Text.Trim()));
                cmd.Parameters.AddWithValue("_bloodbank_ID", Convert.ToInt32(txtbloodbank.Text.Trim()));


                cmd.ExecuteNonQuery();
                fillgrid();
                clear();
            }
            catch(Exception ex)
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

                MySqlDataAdapter da = new MySqlDataAdapter("showemployee", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;//to use the serachbyvalue procedure
                da.SelectCommand.Parameters.AddWithValue("_Employee_ID", Convert.ToInt32(txtsearch.Text));//to compare the value of _searchvalue(the values that exists in the database) and the value written in the search textbox(the value we are searching for)
                DataTable dt = new DataTable();
                da.Fill(dt);// to put values in dt
                dataGridView1.DataSource = dt;
             //   string str = dt.Rows[0][0].ToString();

                // dataGridView1.Columns[0].Visible = false;

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
            fillgrid();
            clear();
            con.Close();
        }

        private void btnshowaddress_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("viewaddress", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;//to use the bookviewall procedure
            da.SelectCommand.Parameters.AddWithValue("_Address_ID", Convert.ToInt32(txtaddress.Text));
            DataTable dt = new DataTable();
            da.Fill(dt);// to put values in dt
            dataGridView1.DataSource = dt;
            //con.Close();
        }

        private void btnshowbloodbank_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("viewbloodbank", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("_BloodBank_ID", Convert.ToInt32(txtbloodbank.Text));
            DataTable dt = new DataTable();
            da.Fill(dt);// to put values in dt
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (dataGridView1.CurrentRow.Index != -1)//to make sure that we are not out of yhe grid
            {
              txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtfirstname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtlastname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtage.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtjobtitle.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtjobdesc.Text= dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtaddress.Text= dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txtbloodbank.Text= dataGridView1.CurrentRow.Cells[7].Value.ToString();
                txtphone.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

             
            }
        }





        /////////////////////////////////////////////////////////////////

    }
}
