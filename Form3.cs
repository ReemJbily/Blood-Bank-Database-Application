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
using MySql.Data;

namespace third_attempt
{
   
 
    public partial class Form3 : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source =localhost;port=3306; Initial Catalog=blood_bank;UserId=root;password=12345");
        int donorid ;
        string s;
        public Form3()
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
                MySqlCommand cmd = new MySqlCommand("updatedonorValues", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_Donor_ID", Convert.ToInt32(txtDonor_id.Text.Trim()));
                cmd.Parameters.AddWithValue("_Address_Num", Convert.ToInt32(txtaddress.Text.Trim()));
                cmd.Parameters.AddWithValue("_Donor_First_Name", txtfirstname.Text.Trim());
                cmd.Parameters.AddWithValue("_Donor_Last_Name", txtlastname.Text.Trim());
                cmd.Parameters.AddWithValue("_Donor_Phone_Number", txtphone.Text.Trim());
                cmd.Parameters.AddWithValue("_Donor_Age", Convert.ToInt32(txtage.Text.Trim()));
                if (isMale.Checked)
                    cmd.Parameters.AddWithValue("_Donor_Gender", isMale.Text);
                else if (isFemale.Checked)
                    cmd.Parameters.AddWithValue("_Donor_Gender", isFemale.Text);
                cmd.Parameters.AddWithValue("_Donor_Weight", Convert.ToDouble(txtweight.Text.Trim()));
                cmd.Parameters.AddWithValue("_Hemoglobin_Amount", Convert.ToInt32(txt_hemo_amount.Text.Trim()));
                cmd.Parameters.AddWithValue("_Pulse_Rate", Convert.ToInt32(txt_pulse_rate.Text.Trim()));
                cmd.Parameters.AddWithValue("_IronBloodPercentege", Convert.ToDouble(txt_iron_blood_percent.Text.Trim()));
                cmd.Parameters.AddWithValue("_platelet_amount", Convert.ToInt32(txtplatlete.Text.Trim()));
                if (a.Checked)
                    cmd.Parameters.AddWithValue("_bloodType", a.Text);
                else if (b.Checked)
                    cmd.Parameters.AddWithValue("_bloodType", b.Text);
                else if (ab.Checked)
                    cmd.Parameters.AddWithValue("_bloodType", ab.Text);
                else if (o.Checked)
                    cmd.Parameters.AddWithValue("_bloodType", o.Text);
                if (radioButton3.Checked)
                    cmd.Parameters.AddWithValue("_RH", radioButton3.Text);
                else if (radioButton4.Checked)
                    cmd.Parameters.AddWithValue("_RH", radioButton4.Text);



                cmd.ExecuteNonQuery();
                fillgrid();
                clear();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }




        











        void fillgrid()
        {
          // string s='select * from donor where donor_id ='txtdono';


            MySqlDataAdapter da = new MySqlDataAdapter("ViewDonorInformation", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }

        void clear()
        {
          txtDonor_id.Text=  txtfirstname.Text = txtlastname.Text = txtaddress.Text=txtage.Text=txtphone.Text=txtplatlete.Text=txtweight.Text=txt_hemo_amount.Text=txt_iron_blood_percent.Text=txt_pulse_rate.Text=txtsearch.Text=txtcount.Text= "";
            isMale.Checked = false;
            isFemale.Checked = false;
            a.Checked = false;
            b.Checked = false;
            ab.Checked = false;
            o.Checked = false;
            radioButton4.Checked = false;
            radioButton3.Checked = false;
            donorid = 0;
         

        }

        private void Form3_Load(object sender, EventArgs e)
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
          
                MySqlCommand cmd = new MySqlCommand("deletedonor", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_Donor_ID", Convert.ToInt32(txtDonor_id.Text.Trim()));

                cmd.ExecuteNonQuery();
                MessageBox.Show("deleted successfully");
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
                
                MySqlDataAdapter da = new MySqlDataAdapter("showdonors", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;//to use the showdonors procedure
                da.SelectCommand.Parameters.AddWithValue("_Donor_ID",Convert.ToInt32( txtsearch.Text));
                DataTable dt = new DataTable();
                da.Fill(dt);// to put values in dt
                dataGridView1.DataSource = dt;
               
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
    
     


        private void btnadd_Click(object sender, EventArgs e)
        {
            
            con.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("addnewdonor", con);
                cmd.CommandType = CommandType.StoredProcedure;
               
                cmd.Parameters.AddWithValue("_Address_Num", Convert.ToInt32(txtaddress.Text.Trim()));
                cmd.Parameters.AddWithValue("_Donor_First_Name", txtfirstname.Text.Trim());
                cmd.Parameters.AddWithValue("_Donor_Last_Name", txtlastname.Text.Trim());
                cmd.Parameters.AddWithValue("_Donor_Phone_Number", txtphone.Text.Trim());
                cmd.Parameters.AddWithValue("_Donor_Age", Convert.ToInt32(txtage.Text.Trim()));
                if (isMale.Checked)
                    cmd.Parameters.AddWithValue("_Donor_Gender", isMale.Text);
                else if (isFemale.Checked)
                    cmd.Parameters.AddWithValue("_Donor_Gender", isFemale.Text);
                cmd.Parameters.AddWithValue("_Donor_Weight", Convert.ToDouble(txtweight.Text.Trim()));
                cmd.Parameters.AddWithValue("_Hemoglobin_Amount", Convert.ToInt32(txt_hemo_amount.Text.Trim()));
                cmd.Parameters.AddWithValue("_Pulse_Rate", Convert.ToInt32(txt_pulse_rate.Text.Trim()));
                cmd.Parameters.AddWithValue("_IronBloodPercentege", Convert.ToDouble(txt_iron_blood_percent.Text.Trim()));
                cmd.Parameters.AddWithValue("_platelet_amount", Convert.ToInt32(txtplatlete.Text.Trim()));
                if (a.Checked)
                    cmd.Parameters.AddWithValue("_bloodType", a.Text);
                else if (b.Checked)
                    cmd.Parameters.AddWithValue("_bloodType", b.Text);
                else if (ab.Checked)
                    cmd.Parameters.AddWithValue("_bloodType", ab.Text);
                else if (o.Checked)
                    cmd.Parameters.AddWithValue("_bloodType", o.Text);
                if (radioButton3.Checked)
                    cmd.Parameters.AddWithValue("_RH", radioButton3.Text);
                else if (radioButton4.Checked)
                    cmd.Parameters.AddWithValue("_RH", radioButton4.Text);
                

                
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
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("_Address_ID", Convert.ToInt32(txtaddress.Text));
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string s1 = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            string s2 = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            string s3 = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            if (dataGridView1.CurrentRow.Index != -1)//to make sure that we are not out of yhe grid
            {   txtDonor_id.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtaddress.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtfirstname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtlastname.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtage.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtphone.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                if (s1 == "male")
                    isMale.Checked = true;
                else if (s1 == "female")
                    isFemale.Checked = true;
               
                txtweight.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                txt_hemo_amount.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                txt_pulse_rate.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                txt_iron_blood_percent.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                txtplatlete.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                if (s2 == "A")
                    a.Checked = true;
                else if (s2 == "B")
                    b.Checked = true;
                else if (s2 == "AB")
                    ab.Checked = true;
                else if (s2 == "O")
                    o.Checked = true;
                if (s3 == "+")
                    radioButton4.Checked = true;
                else if (s3 == "-")
                    radioButton3.Checked = true;


              
            }
        }

        private void btncount_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {

                
                if (a.Checked)
                    s = "Select count(*) from donor where bloodType ='A'";
                else if (b.Checked)
                    s = "Select count(*) from donor where bloodType ='B'";
                else if (ab.Checked)
                    s = "Select count(*) from donor where bloodType ='AB'";
                else if (o.Checked)
                    s = "Select count(*) from donor where bloodType ='O'";
              
                    MySqlCommand cmd = new MySqlCommand(s, con);
       
                object result = cmd.ExecuteScalar();
              
                    int c = Convert.ToInt32(result);                
                txtcount.Text = c.ToString();
              
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btncomp_Click(object sender, EventArgs e)
        {
          
            MySqlDataAdapter da = new MySqlDataAdapter("comp1", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;           
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //newviewproceduer
            MySqlDataAdapter da = new MySqlDataAdapter("newviewproceduer", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //comp1view
            MySqlDataAdapter da = new MySqlDataAdapter("comp1view", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        //////////////////////////////////////////////////////////////////////////
        /*

*/







    }
}
