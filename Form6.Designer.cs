namespace third_attempt
{
    partial class Form6
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
            this.btnsearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.BloodBank_ID = new System.Windows.Forms.TextBox();
            this.BloodBank_Name = new System.Windows.Forms.TextBox();
            this.BloodBank_address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnshowaddress = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnreturn
            // 
            this.btnreturn.Location = new System.Drawing.Point(54, 474);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(111, 23);
            this.btnreturn.TabIndex = 0;
            this.btnreturn.Text = "return to main page";
            this.btnreturn.UseVisualStyleBackColor = true;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(901, 88);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 1;
            this.btnsearch.Text = "search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(541, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(342, 199);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "BloodBank_ID";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(756, 88);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(139, 20);
            this.txtsearch.TabIndex = 4;
            // 
            // BloodBank_ID
            // 
            this.BloodBank_ID.Location = new System.Drawing.Point(114, 85);
            this.BloodBank_ID.Name = "BloodBank_ID";
            this.BloodBank_ID.Size = new System.Drawing.Size(139, 20);
            this.BloodBank_ID.TabIndex = 5;
            // 
            // BloodBank_Name
            // 
            this.BloodBank_Name.Location = new System.Drawing.Point(114, 124);
            this.BloodBank_Name.Name = "BloodBank_Name";
            this.BloodBank_Name.Size = new System.Drawing.Size(139, 20);
            this.BloodBank_Name.TabIndex = 6;
            // 
            // BloodBank_address
            // 
            this.BloodBank_address.Location = new System.Drawing.Point(114, 162);
            this.BloodBank_address.Name = "BloodBank_address";
            this.BloodBank_address.Size = new System.Drawing.Size(139, 20);
            this.BloodBank_address.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "BloodBank Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "BloodBank_address";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(901, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "btnupdate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnshowaddress
            // 
            this.btnshowaddress.Location = new System.Drawing.Point(660, 220);
            this.btnshowaddress.Name = "btnshowaddress";
            this.btnshowaddress.Size = new System.Drawing.Size(162, 23);
            this.btnshowaddress.TabIndex = 11;
            this.btnshowaddress.Text = "show address information";
            this.btnshowaddress.UseVisualStyleBackColor = true;
            this.btnshowaddress.Click += new System.EventHandler(this.btnshowaddress_Click);
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(541, 220);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(75, 23);
            this.btnshow.TabIndex = 12;
            this.btnshow.Text = "show";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(457, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::third_attempt.Properties.Resources.images2;
            this.pictureBox1.Location = new System.Drawing.Point(25, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 251);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(988, 540);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.btnshowaddress);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BloodBank_address);
            this.Controls.Add(this.BloodBank_Name);
            this.Controls.Add(this.BloodBank_ID);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnreturn);
            this.Name = "Form6";
            this.Text = "Blood_Bank";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnreturn;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.TextBox BloodBank_ID;
        private System.Windows.Forms.TextBox BloodBank_Name;
        private System.Windows.Forms.TextBox BloodBank_address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnshowaddress;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}