namespace PizzaSalesApplication
{
    partial class AdminPanelFormList
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
            this.btnAPFLProductStock = new System.Windows.Forms.Button();
            this.btnAPFLMemberList = new System.Windows.Forms.Button();
            this.btnAPFLReport = new System.Windows.Forms.Button();
            this.btnAPFLExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAPFLProductStock
            // 
            this.btnAPFLProductStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAPFLProductStock.Location = new System.Drawing.Point(30, 25);
            this.btnAPFLProductStock.Name = "btnAPFLProductStock";
            this.btnAPFLProductStock.Size = new System.Drawing.Size(238, 69);
            this.btnAPFLProductStock.TabIndex = 3;
            this.btnAPFLProductStock.Text = "PRODUCT INFORMATION AND STOCK TRACKING";
            this.btnAPFLProductStock.UseVisualStyleBackColor = false;
            this.btnAPFLProductStock.Click += new System.EventHandler(this.btnAPFLProductStock_Click);
            // 
            // btnAPFLMemberList
            // 
            this.btnAPFLMemberList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAPFLMemberList.Location = new System.Drawing.Point(30, 135);
            this.btnAPFLMemberList.Name = "btnAPFLMemberList";
            this.btnAPFLMemberList.Size = new System.Drawing.Size(238, 69);
            this.btnAPFLMemberList.TabIndex = 4;
            this.btnAPFLMemberList.Text = "MEMBER INFORMATION LIST";
            this.btnAPFLMemberList.UseVisualStyleBackColor = false;
            this.btnAPFLMemberList.Click += new System.EventHandler(this.btnAPFLMemberList_Click);
            // 
            // btnAPFLReport
            // 
            this.btnAPFLReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAPFLReport.Location = new System.Drawing.Point(30, 249);
            this.btnAPFLReport.Name = "btnAPFLReport";
            this.btnAPFLReport.Size = new System.Drawing.Size(238, 69);
            this.btnAPFLReport.TabIndex = 5;
            this.btnAPFLReport.Text = "REPORT";
            this.btnAPFLReport.UseVisualStyleBackColor = false;
            this.btnAPFLReport.Click += new System.EventHandler(this.btnAPFLReport_Click);
            // 
            // btnAPFLExit
            // 
            this.btnAPFLExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAPFLExit.Location = new System.Drawing.Point(30, 357);
            this.btnAPFLExit.Name = "btnAPFLExit";
            this.btnAPFLExit.Size = new System.Drawing.Size(207, 76);
            this.btnAPFLExit.TabIndex = 6;
            this.btnAPFLExit.Text = "EXIT";
            this.btnAPFLExit.UseVisualStyleBackColor = false;
            this.btnAPFLExit.Click += new System.EventHandler(this.btnAPFLExit_Click);
            // 
            // AdminPanelFormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(1268, 647);
            this.Controls.Add(this.btnAPFLExit);
            this.Controls.Add(this.btnAPFLReport);
            this.Controls.Add(this.btnAPFLMemberList);
            this.Controls.Add(this.btnAPFLProductStock);
            this.Name = "AdminPanelFormList";
            this.Text = "AdminPanelFormList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAPFLProductStock;
        private System.Windows.Forms.Button btnAPFLMemberList;
        private System.Windows.Forms.Button btnAPFLReport;
        private System.Windows.Forms.Button btnAPFLExit;
    }
}