namespace PizzaSalesApplication
{
    partial class MemberInformationLıst
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
            this.btnAPFLViewMembInfo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgAPFLViewMemb = new System.Windows.Forms.DataGridView();
            this.btnAPFLMembInfoExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAPFLViewMemb)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAPFLViewMembInfo
            // 
            this.btnAPFLViewMembInfo.BackColor = System.Drawing.Color.Lime;
            this.btnAPFLViewMembInfo.Location = new System.Drawing.Point(12, 55);
            this.btnAPFLViewMembInfo.Name = "btnAPFLViewMembInfo";
            this.btnAPFLViewMembInfo.Size = new System.Drawing.Size(303, 47);
            this.btnAPFLViewMembInfo.TabIndex = 5;
            this.btnAPFLViewMembInfo.Text = "VIEW MEMBER INFORMATION";
            this.btnAPFLViewMembInfo.UseVisualStyleBackColor = false;
            this.btnAPFLViewMembInfo.Click += new System.EventHandler(this.btnAPFLViewMembInfo_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(479, 26);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "CLICK THE BUTTON TO VIEW MEMBER INFORMATION";
            // 
            // dgAPFLViewMemb
            // 
            this.dgAPFLViewMemb.AllowUserToAddRows = false;
            this.dgAPFLViewMemb.AllowUserToDeleteRows = false;
            this.dgAPFLViewMemb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAPFLViewMemb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAPFLViewMemb.Location = new System.Drawing.Point(12, 117);
            this.dgAPFLViewMemb.Name = "dgAPFLViewMemb";
            this.dgAPFLViewMemb.ReadOnly = true;
            this.dgAPFLViewMemb.RowHeadersWidth = 62;
            this.dgAPFLViewMemb.RowTemplate.Height = 28;
            this.dgAPFLViewMemb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAPFLViewMemb.Size = new System.Drawing.Size(830, 394);
            this.dgAPFLViewMemb.TabIndex = 6;
            // 
            // btnAPFLMembInfoExit
            // 
            this.btnAPFLMembInfoExit.BackColor = System.Drawing.Color.Red;
            this.btnAPFLMembInfoExit.Location = new System.Drawing.Point(12, 597);
            this.btnAPFLMembInfoExit.Name = "btnAPFLMembInfoExit";
            this.btnAPFLMembInfoExit.Size = new System.Drawing.Size(144, 69);
            this.btnAPFLMembInfoExit.TabIndex = 7;
            this.btnAPFLMembInfoExit.Text = "EXIT";
            this.btnAPFLMembInfoExit.UseVisualStyleBackColor = false;
            this.btnAPFLMembInfoExit.Click += new System.EventHandler(this.btnAPFLMembInfoExit_Click);
            // 
            // MemberInformationLıst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(908, 705);
            this.Controls.Add(this.btnAPFLMembInfoExit);
            this.Controls.Add(this.dgAPFLViewMemb);
            this.Controls.Add(this.btnAPFLViewMembInfo);
            this.Controls.Add(this.textBox1);
            this.Name = "MemberInformationLıst";
            this.Text = "MemberInformationLıst";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgAPFLViewMemb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAPFLViewMembInfo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgAPFLViewMemb;
        private System.Windows.Forms.Button btnAPFLMembInfoExit;
    }
}