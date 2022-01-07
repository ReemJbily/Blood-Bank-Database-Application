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
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source =localhost;port=3306; Initial Catalog=blood_bank;UserId=root;password=12345");
        int i ;
        public Form1()
        {
            InitializeComponent();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            i = 0;
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(" loginp", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

           
            da.SelectCommand.Parameters.AddWithValue("_user_id",Convert.ToInt32( txtuser_id.Text));// to pass the  value of the user id text- after converting it to int -to _user_id parameter in loginp procedure
            da.SelectCommand.Parameters.AddWithValue("_pwd", txtpassword.Text);//to pass the  value of the passWord text to _pwd parameter in loginp procedure
            DataTable dt = new DataTable();
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {// if the password is not correct
                MessageBox.Show("please enter a valid user name or password");
            }
            else
            {//if the the password and user id is correct
                this.Hide();//hiding the log in form
                Form2 nf = new Form2();
                nf.Show();// moving to main page
                
               
            }

            con.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {// to exit the log in form
            DialogResult dialog = MessageBox.Show("Do you want to close the application ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
          if(dialog==DialogResult.Yes)
                Application.Exit();
        else
            {
                MessageBox.Show("Return to the application", "Return", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
              
        }
    }
}
