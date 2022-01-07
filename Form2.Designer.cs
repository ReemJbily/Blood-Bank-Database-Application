namespace third_attempt
{
    partial class Form2
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
            this.btn_emp = new System.Windows.Forms.Button();
            this.btn_request = new System.Windows.Forms.Button();
            this.btn_bbank = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_hospital = new System.Windows.Forms.Button();
            this.btn_donor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_emp
            // 
            this.btn_emp.Location = new System.Drawing.Point(739, 107);
            this.btn_emp.Margin = new System.Windows.Forms.Padding(4);
            this.btn_emp.Name = "btn_emp";
            this.btn_emp.Size = new System.Drawing.Size(173, 32);
            this.btn_emp.TabIndex = 1;
            this.btn_emp.Text = "Employye\'s information";
            this.btn_emp.UseVisualStyleBackColor = true;
            this.btn_emp.Click += new System.EventHandler(this.btn_emp_Click);
            // 
            // btn_request
            // 
            this.btn_request.Location = new System.Drawing.Point(739, 147);
            this.btn_request.Margin = new System.Windows.Forms.Padding(4);
            this.btn_request.Name = "btn_request";
            this.btn_request.Size = new System.Drawing.Size(173, 32);
            this.btn_request.TabIndex = 2;
            this.btn_request.Text = "request";
            this.btn_request.UseVisualStyleBackColor = true;
            this.btn_request.Click += new System.EventHandler(this.btn_request_Click);
            // 
            // btn_bbank
            // 
            this.btn_bbank.Location = new System.Drawing.Point(739, 187);
            this.btn_bbank.Margin = new System.Windows.Forms.Padding(4);
            this.btn_bbank.Name = "btn_bbank";
            this.btn_bbank.Size = new System.Drawing.Size(173, 32);
            this.btn_bbank.TabIndex = 3;
            this.btn_bbank.Text = "BloodBank info";
            this.btn_bbank.UseVisualStyleBackColor = true;
            this.btn_bbank.Click += new System.EventHandler(this.btn_bbank_Click);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(739, 267);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(173, 32);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "log in";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Main Page";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_hospital
            // 
            this.btn_hospital.Location = new System.Drawing.Point(739, 227);
            this.btn_hospital.Margin = new System.Windows.Forms.Padding(4);
            this.btn_hospital.Name = "btn_hospital";
            this.btn_hospital.Size = new System.Drawing.Size(173, 32);
            this.btn_hospital.TabIndex = 7;
            this.btn_hospital.Text = "hospital";
            this.btn_hospital.UseVisualStyleBackColor = true;
            this.btn_hospital.Click += new System.EventHandler(this.btn_hospital_Click_1);
            // 
            // btn_donor
            // 
            this.btn_donor.Location = new System.Drawing.Point(739, 61);
            this.btn_donor.Margin = new System.Windows.Forms.Padding(4);
            this.btn_donor.Name = "btn_donor";
            this.btn_donor.Size = new System.Drawing.Size(173, 35);
            this.btn_donor.TabIndex = 0;
            this.btn_donor.Text = "donor information";
            this.btn_donor.UseVisualStyleBackColor = true;
            this.btn_donor.Click += new System.EventHandler(this.btn_donor_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = global::third_attempt.Properties.Resources.blood_drop_icon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(920, 451);
            this.Controls.Add(this.btn_hospital);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_bbank);
            this.Controls.Add(this.btn_request);
            this.Controls.Add(this.btn_emp);
            this.Controls.Add(this.btn_donor);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_donor;
        private System.Windows.Forms.Button btn_emp;
        private System.Windows.Forms.Button btn_request;
        private System.Windows.Forms.Button btn_bbank;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_hospital;
    }
}