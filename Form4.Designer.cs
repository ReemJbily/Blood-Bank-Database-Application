namespace third_attempt
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnreturn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtjobdesc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtjobtitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbloodbank = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnshowaddress = new System.Windows.Forms.Button();
            this.btnshowbloodbank = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnreturn
            // 
            this.btnreturn.BackColor = System.Drawing.Color.Red;
            this.btnreturn.Location = new System.Drawing.Point(12, 460);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(126, 23);
            this.btnreturn.TabIndex = 0;
            this.btnreturn.Text = "return to main page";
            this.btnreturn.UseVisualStyleBackColor = false;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(302, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(501, 308);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.White;
            this.txtid.Location = new System.Drawing.Point(163, 27);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(83, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(44, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Employee first name :";
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(163, 53);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(100, 20);
            this.txtfirstname.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(46, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "employee last name :";
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(163, 79);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(100, 20);
            this.txtlastname.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(71, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "job description :";
            // 
            // txtjobdesc
            // 
            this.txtjobdesc.Location = new System.Drawing.Point(163, 235);
            this.txtjobdesc.Multiline = true;
            this.txtjobdesc.Name = "txtjobdesc";
            this.txtjobdesc.Size = new System.Drawing.Size(100, 53);
            this.txtjobdesc.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(105, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "job title :";
            // 
            // txtjobtitle
            // 
            this.txtjobtitle.Location = new System.Drawing.Point(163, 209);
            this.txtjobtitle.Name = "txtjobtitle";
            this.txtjobtitle.Size = new System.Drawing.Size(100, 20);
            this.txtjobtitle.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(122, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Age :";
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(163, 157);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(100, 20);
            this.txtage.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(111, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "phone :";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(163, 183);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(100, 20);
            this.txtphone.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(8, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Employee boodbank number :";
            // 
            // txtbloodbank
            // 
            this.txtbloodbank.Location = new System.Drawing.Point(163, 131);
            this.txtbloodbank.Name = "txtbloodbank";
            this.txtbloodbank.Size = new System.Drawing.Size(100, 20);
            this.txtbloodbank.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(54, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Employee address :";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(163, 105);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(100, 20);
            this.txtaddress.TabIndex = 14;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.Red;
            this.btnsearch.Location = new System.Drawing.Point(677, 12);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(126, 23);
            this.btnsearch.TabIndex = 20;
            this.btnsearch.Text = "sreach";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Red;
            this.btnupdate.Location = new System.Drawing.Point(677, 40);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(126, 23);
            this.btnupdate.TabIndex = 21;
            this.btnupdate.Text = "update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Red;
            this.btndelete.Location = new System.Drawing.Point(677, 69);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(126, 23);
            this.btndelete.TabIndex = 22;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Red;
            this.btnadd.Location = new System.Drawing.Point(677, 98);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(126, 23);
            this.btnadd.TabIndex = 23;
            this.btnadd.Text = "add new employee";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(505, 14);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(166, 20);
            this.txtsearch.TabIndex = 24;
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.Color.Red;
            this.btnshow.Location = new System.Drawing.Point(302, 155);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(126, 23);
            this.btnshow.TabIndex = 25;
            this.btnshow.Text = "show";
            this.btnshow.UseVisualStyleBackColor = false;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnshowaddress
            // 
            this.btnshowaddress.BackColor = System.Drawing.Color.Red;
            this.btnshowaddress.Location = new System.Drawing.Point(440, 157);
            this.btnshowaddress.Name = "btnshowaddress";
            this.btnshowaddress.Size = new System.Drawing.Size(126, 23);
            this.btnshowaddress.TabIndex = 26;
            this.btnshowaddress.Text = "show addrss";
            this.btnshowaddress.UseVisualStyleBackColor = false;
            this.btnshowaddress.Click += new System.EventHandler(this.btnshowaddress_Click);
            // 
            // btnshowbloodbank
            // 
            this.btnshowbloodbank.BackColor = System.Drawing.Color.Red;
            this.btnshowbloodbank.Location = new System.Drawing.Point(572, 154);
            this.btnshowbloodbank.Name = "btnshowbloodbank";
            this.btnshowbloodbank.Size = new System.Drawing.Size(126, 23);
            this.btnshowbloodbank.TabIndex = 27;
            this.btnshowbloodbank.Text = "show bloodbank";
            this.btnshowbloodbank.UseVisualStyleBackColor = false;
            this.btnshowbloodbank.Click += new System.EventHandler(this.btnshowbloodbank_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::third_attempt.Properties.Resources.blood_drop_icon;
            this.ClientSize = new System.Drawing.Size(815, 495);
            this.Controls.Add(this.btnshowbloodbank);
            this.Controls.Add(this.btnshowaddress);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtbloodbank);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtjobdesc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtjobtitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnreturn);
            this.Name = "Form4";
            this.Text = "Employee_Info";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnreturn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtjobdesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtjobtitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbloodbank;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnshowaddress;
        private System.Windows.Forms.Button btnshowbloodbank;
    }
}