namespace PizzaSalesApplication
{
    partial class MemberLoginForm
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
            this.txtMLFpassword = new System.Windows.Forms.TextBox();
            this.txtMLFemail = new System.Windows.Forms.TextBox();
            this.lblMLFpass = new System.Windows.Forms.Label();
            this.lblMFemail = new System.Windows.Forms.Label();
            this.btnMLFlogin = new System.Windows.Forms.Button();
            this.btnMLFExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMLFpassword
            // 
            this.txtMLFpassword.Location = new System.Drawing.Point(162, 107);
            this.txtMLFpassword.Name = "txtMLFpassword";
            this.txtMLFpassword.Size = new System.Drawing.Size(349, 26);
            this.txtMLFpassword.TabIndex = 7;
            // 
            // txtMLFemail
            // 
            this.txtMLFemail.Location = new System.Drawing.Point(162, 45);
            this.txtMLFemail.Name = "txtMLFemail";
            this.txtMLFemail.Size = new System.Drawing.Size(349, 26);
            this.txtMLFemail.TabIndex = 6;
            // 
            // lblMLFpass
            // 
            this.lblMLFpass.AutoSize = true;
            this.lblMLFpass.Location = new System.Drawing.Point(40, 110);
            this.lblMLFpass.Name = "lblMLFpass";
            this.lblMLFpass.Size = new System.Drawing.Size(125, 20);
            this.lblMLFpass.TabIndex = 5;
            this.lblMLFpass.Text = "Enter Password:";
            // 
            // lblMFemail
            // 
            this.lblMFemail.AutoSize = true;
            this.lblMFemail.Location = new System.Drawing.Point(40, 45);
            this.lblMFemail.Name = "lblMFemail";
            this.lblMFemail.Size = new System.Drawing.Size(104, 20);
            this.lblMFemail.TabIndex = 4;
            this.lblMFemail.Text = "Enter E-mail: ";
            // 
            // btnMLFlogin
            // 
            this.btnMLFlogin.BackColor = System.Drawing.Color.Lime;
            this.btnMLFlogin.Location = new System.Drawing.Point(219, 174);
            this.btnMLFlogin.Name = "btnMLFlogin";
            this.btnMLFlogin.Size = new System.Drawing.Size(133, 42);
            this.btnMLFlogin.TabIndex = 8;
            this.btnMLFlogin.Text = "LOGIN";
            this.btnMLFlogin.UseVisualStyleBackColor = false;
            this.btnMLFlogin.Click += new System.EventHandler(this.btnMLFlogin_Click);
            // 
            // btnMLFExit
            // 
            this.btnMLFExit.BackColor = System.Drawing.Color.Firebrick;
            this.btnMLFExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMLFExit.Location = new System.Drawing.Point(378, 174);
            this.btnMLFExit.Name = "btnMLFExit";
            this.btnMLFExit.Size = new System.Drawing.Size(133, 42);
            this.btnMLFExit.TabIndex = 9;
            this.btnMLFExit.Text = "EXIT";
            this.btnMLFExit.UseVisualStyleBackColor = false;
            this.btnMLFExit.Click += new System.EventHandler(this.btnMLFExit_Click);
            // 
            // MemberLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(590, 391);
            this.Controls.Add(this.btnMLFExit);
            this.Controls.Add(this.btnMLFlogin);
            this.Controls.Add(this.txtMLFpassword);
            this.Controls.Add(this.txtMLFemail);
            this.Controls.Add(this.lblMLFpass);
            this.Controls.Add(this.lblMFemail);
            this.Name = "MemberLoginForm";
            this.Text = "MemberLoginForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMLFpassword;
        private System.Windows.Forms.TextBox txtMLFemail;
        private System.Windows.Forms.Label lblMLFpass;
        private System.Windows.Forms.Label lblMFemail;
        private System.Windows.Forms.Button btnMLFlogin;
        private System.Windows.Forms.Button btnMLFExit;
    }
}