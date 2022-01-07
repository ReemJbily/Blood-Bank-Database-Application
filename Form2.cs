using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace third_attempt
{
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_donor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 nf3 = new Form3();
            nf3.Show();
           
        }

        private void btn_emp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 nf4 = new Form4();
            nf4.Show();
        }

        private void btn_request_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 nf5 = new Form5();
            nf5.Show();
        }

        private void btn_bbank_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 nf6 = new Form6();
            nf6.Show();
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to close the application ?", "Exit", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                Application.Exit();
            else
            {
                MessageBox.Show("Return to the application", "Return", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

      

        private void btn_login_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form7 nf7 = new Form7();
            nf7.Show();
        }

        private void btn_hospital_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form8 nf8 = new Form8();
            nf8.Show();
        }
    }
}
