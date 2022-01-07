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
    public partial class Form5 : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source =localhost;port=3306; Initial Catalog=blood_bank;UserId=root;password=12345");
        public Form5()
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


        void fillgrid()
        {
            //con.Open();


            MySqlDataAdapter da = new MySqlDataAdapter("ViewrequestInformation", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);// to put values in dt
            dataGridView1.DataSource = dt;
            //con.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            con.Open();
            fillgrid();
            con.Close();
        }

        private void btnhospital_Click(object sender, EventArgs e)
        {
            try { 
            MySqlDataAdapter da = new MySqlDataAdapter("showhospital", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("_hospital_ID", Convert.ToInt32(txthospitalnum.Text));
            DataTable dt = new DataTable();
            da.Fill(dt);// to put values in dt
            dataGridView1.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnshowrequest_Click(object sender, EventArgs e)
        {
            con.Open();
            fillgrid();
            clear();
            con.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            //addrequestinfornmation
            con.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("addrequestinfornmation", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_patient_firstName", txtfirstname.Text.Trim());
                cmd.Parameters.AddWithValue("_patient_lastName", txtlastname.Text.Trim());
                cmd.Parameters.AddWithValue("_hospital_num", Convert.ToInt32(txthospitalnum.Text.Trim()));
                cmd.Parameters.AddWithValue("_numberOfBloodBags", Convert.ToInt32(txtbloodbagsnum.Text.Trim()));
                if (a.Checked)
                    cmd.Parameters.AddWithValue("_patient_bloodType", a.Text);
                else if (b.Checked)
                    cmd.Parameters.AddWithValue("_patient_bloodType", b.Text);
                else if (ab.Checked)
                    cmd.Parameters.AddWithValue("_patient_bloodType", ab.Text);
                else if (o.Checked)
                    cmd.Parameters.AddWithValue("_patient_bloodType", o.Text);
                if (radioButton5.Checked)
                    cmd.Parameters.AddWithValue("_patient_RH_factor", radioButton5.Text);
                else if (radioButton6.Checked)
                    cmd.Parameters.AddWithValue("_patient_RH_factor", radioButton6.Text);
                cmd.Parameters.AddWithValue("_blood_bank_id", Convert.ToInt32(txtbloodbankid.Text.Trim()));



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


        void clear()
        {
            txtrequestnum.Text = txtfirstname.Text = txtlastname.Text = txthospitalnum.Text = txtbloodbankid.Text = txtbloodbagsnum.Text = "";
            a.Checked = false;
            b.Checked = false;
            ab.Checked = false;
            o.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;

        

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {

                MySqlCommand cmd = new MySqlCommand("deleterequest", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_request_num", Convert.ToInt32(txtrequestnum.Text));

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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("updaterequest", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_request_num", Convert.ToInt32(txtrequestnum.Text.Trim()));

                cmd.Parameters.AddWithValue("_patient_firstName", txtfirstname.Text.Trim());
                cmd.Parameters.AddWithValue("_patient_lastName", txtlastname.Text.Trim());
                cmd.Parameters.AddWithValue("_hospital_num", Convert.ToInt32(txthospitalnum.Text.Trim()));
                cmd.Parameters.AddWithValue("_numberOfBloodBags", Convert.ToInt32(txtbloodbagsnum.Text.Trim()));
                if (a.Checked)
                    cmd.Parameters.AddWithValue("_patient_bloodType", a.Text);
                else if (b.Checked)
                    cmd.Parameters.AddWithValue("_patient_bloodType", b.Text);
                else if (ab.Checked)
                    cmd.Parameters.AddWithValue("_patient_bloodType", ab.Text);
                else if (o.Checked)
                    cmd.Parameters.AddWithValue("_patient_bloodType", o.Text);
                if (radioButton5.Checked)
                    cmd.Parameters.AddWithValue("_patient_RH_factor", radioButton5.Text);
                else if (radioButton6.Checked)
                    cmd.Parameters.AddWithValue("_patient_RH_factor", radioButton6.Text);
                cmd.Parameters.AddWithValue("_blood_bank_id", Convert.ToInt32(txtbloodbankid.Text.Trim()));



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

                MySqlDataAdapter da = new MySqlDataAdapter("showrequest", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;//to use the serachbyvalue procedure
                da.SelectCommand.Parameters.AddWithValue("_request_num", Convert.ToInt32(txtsearch.Text));//to compare the value of _searchvalue(the values that exists in the database) and the value written in the search textbox(the value we are searching for)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {   
            string s1= dataGridView1.CurrentRow.Cells[5].Value.ToString(); 
            string s2= dataGridView1.CurrentRow.Cells[6].Value.ToString();
            if (dataGridView1.CurrentRow.Index != -1)//to make sure that we are not out of the grid
            {
                txtrequestnum.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtfirstname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtlastname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txthospitalnum.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtbloodbagsnum.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtbloodbankid.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                if (s1 == "A")
                    a.Checked = true;
                else if (s1 == "B")
                    b.Checked = true;
                else if (s1 == "AB")
                    ab.Checked = true;
                else if (s1 == "O")
                    o.Checked = true;
                if (s2 == "+")
                    radioButton5.Checked = true;
                if (s2 == "-")
                    radioButton5.Checked = true;


            }
        }

        private void btnshowaddress_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("viewaddress", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.SelectCommand.Parameters.AddWithValue("_Address_ID", Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString()));
                DataTable dt = new DataTable();
                da.Fill(dt);// to put values in dt
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}


