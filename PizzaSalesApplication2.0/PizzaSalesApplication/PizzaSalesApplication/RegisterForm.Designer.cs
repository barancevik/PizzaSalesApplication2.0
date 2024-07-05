namespace PizzaSalesApplication
{
    partial class RegisterForm
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
            this.txtRegisterPass = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtNameSurname = new System.Windows.Forms.TextBox();
            this.labelphonenumber = new System.Windows.Forms.Label();
            this.labeladdress = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblnamesurname = new System.Windows.Forms.Label();
            this.btnRFregister = new System.Windows.Forms.Button();
            this.btnRFExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRegisterPass
            // 
            this.txtRegisterPass.Location = new System.Drawing.Point(168, 236);
            this.txtRegisterPass.Name = "txtRegisterPass";
            this.txtRegisterPass.Size = new System.Drawing.Size(493, 26);
            this.txtRegisterPass.TabIndex = 19;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(168, 193);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(493, 26);
            this.txtEmail.TabIndex = 18;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(168, 142);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(493, 26);
            this.txtPhoneNumber.TabIndex = 17;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(168, 89);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(493, 26);
            this.txtAddress.TabIndex = 16;
            // 
            // txtNameSurname
            // 
            this.txtNameSurname.Location = new System.Drawing.Point(168, 32);
            this.txtNameSurname.Name = "txtNameSurname";
            this.txtNameSurname.Size = new System.Drawing.Size(493, 26);
            this.txtNameSurname.TabIndex = 15;
            // 
            // labelphonenumber
            // 
            this.labelphonenumber.AutoSize = true;
            this.labelphonenumber.Location = new System.Drawing.Point(29, 142);
            this.labelphonenumber.Name = "labelphonenumber";
            this.labelphonenumber.Size = new System.Drawing.Size(115, 20);
            this.labelphonenumber.TabIndex = 14;
            this.labelphonenumber.Text = "Phone Number";
            // 
            // labeladdress
            // 
            this.labeladdress.AutoSize = true;
            this.labeladdress.Location = new System.Drawing.Point(29, 89);
            this.labeladdress.Name = "labeladdress";
            this.labeladdress.Size = new System.Drawing.Size(68, 20);
            this.labeladdress.TabIndex = 13;
            this.labeladdress.Text = "Address";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Location = new System.Drawing.Point(29, 239);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(78, 20);
            this.lblpass.TabIndex = 12;
            this.lblpass.Text = "Password";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(29, 193);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 20);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "E-mail";
            // 
            // lblnamesurname
            // 
            this.lblnamesurname.AutoSize = true;
            this.lblnamesurname.Location = new System.Drawing.Point(29, 32);
            this.lblnamesurname.Name = "lblnamesurname";
            this.lblnamesurname.Size = new System.Drawing.Size(120, 20);
            this.lblnamesurname.TabIndex = 10;
            this.lblnamesurname.Text = "Name/Surname";
            // 
            // btnRFregister
            // 
            this.btnRFregister.BackColor = System.Drawing.Color.LawnGreen;
            this.btnRFregister.Location = new System.Drawing.Point(305, 294);
            this.btnRFregister.Name = "btnRFregister";
            this.btnRFregister.Size = new System.Drawing.Size(165, 51);
            this.btnRFregister.TabIndex = 20;
            this.btnRFregister.Text = "REGISTER";
            this.btnRFregister.UseVisualStyleBackColor = false;
            this.btnRFregister.Click += new System.EventHandler(this.btnRFregister_Click);
            // 
            // btnRFExit
            // 
            this.btnRFExit.BackColor = System.Drawing.Color.Firebrick;
            this.btnRFExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRFExit.Location = new System.Drawing.Point(496, 294);
            this.btnRFExit.Name = "btnRFExit";
            this.btnRFExit.Size = new System.Drawing.Size(165, 51);
            this.btnRFExit.TabIndex = 21;
            this.btnRFExit.Text = "EXIT";
            this.btnRFExit.UseVisualStyleBackColor = false;
            this.btnRFExit.Click += new System.EventHandler(this.btnRFExit_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(710, 395);
            this.Controls.Add(this.btnRFExit);
            this.Controls.Add(this.btnRFregister);
            this.Controls.Add(this.txtRegisterPass);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtNameSurname);
            this.Controls.Add(this.labelphonenumber);
            this.Controls.Add(this.labeladdress);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblnamesurname);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRegisterPass;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtNameSurname;
        private System.Windows.Forms.Label labelphonenumber;
        private System.Windows.Forms.Label labeladdress;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblnamesurname;
        private System.Windows.Forms.Button btnRFregister;
        private System.Windows.Forms.Button btnRFExit;
    }
}