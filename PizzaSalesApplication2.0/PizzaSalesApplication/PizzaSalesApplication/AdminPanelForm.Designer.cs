namespace PizzaSalesApplication
{
    partial class AdminPanelForm
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
            this.btnAPExit = new System.Windows.Forms.Button();
            this.btnAPlogin = new System.Windows.Forms.Button();
            this.txtAPPassword = new System.Windows.Forms.TextBox();
            this.txtAPMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAPExit
            // 
            this.btnAPExit.BackColor = System.Drawing.Color.Red;
            this.btnAPExit.Location = new System.Drawing.Point(397, 178);
            this.btnAPExit.Name = "btnAPExit";
            this.btnAPExit.Size = new System.Drawing.Size(107, 43);
            this.btnAPExit.TabIndex = 16;
            this.btnAPExit.Text = "EXIT";
            this.btnAPExit.UseVisualStyleBackColor = false;
            this.btnAPExit.Click += new System.EventHandler(this.btnAPExit_Click);
            // 
            // btnAPlogin
            // 
            this.btnAPlogin.BackColor = System.Drawing.Color.Lime;
            this.btnAPlogin.Location = new System.Drawing.Point(235, 171);
            this.btnAPlogin.Name = "btnAPlogin";
            this.btnAPlogin.Size = new System.Drawing.Size(135, 50);
            this.btnAPlogin.TabIndex = 15;
            this.btnAPlogin.Text = "LOGIN";
            this.btnAPlogin.UseVisualStyleBackColor = false;
            this.btnAPlogin.Click += new System.EventHandler(this.btnAPlogin_Click);
            // 
            // txtAPPassword
            // 
            this.txtAPPassword.Location = new System.Drawing.Point(160, 105);
            this.txtAPPassword.Name = "txtAPPassword";
            this.txtAPPassword.Size = new System.Drawing.Size(344, 26);
            this.txtAPPassword.TabIndex = 14;
            // 
            // txtAPMail
            // 
            this.txtAPMail.Location = new System.Drawing.Point(160, 43);
            this.txtAPMail.Name = "txtAPMail";
            this.txtAPMail.Size = new System.Drawing.Size(344, 26);
            this.txtAPMail.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Enter Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enter E-mail:";
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(546, 320);
            this.Controls.Add(this.btnAPExit);
            this.Controls.Add(this.btnAPlogin);
            this.Controls.Add(this.txtAPPassword);
            this.Controls.Add(this.txtAPMail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminPanelForm";
            this.Text = "AdminPanelForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAPExit;
        private System.Windows.Forms.Button btnAPlogin;
        private System.Windows.Forms.TextBox txtAPPassword;
        private System.Windows.Forms.TextBox txtAPMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}