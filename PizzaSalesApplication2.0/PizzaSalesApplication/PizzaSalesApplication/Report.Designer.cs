namespace PizzaSalesApplication
{
    partial class Report
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
            this.btnAPFLReport = new System.Windows.Forms.Button();
            this.txtreport = new System.Windows.Forms.TextBox();
            this.dgAPFLReport = new System.Windows.Forms.DataGridView();
            this.btnAPDLRepExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAPFLReport)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAPFLReport
            // 
            this.btnAPFLReport.BackColor = System.Drawing.Color.Lime;
            this.btnAPFLReport.Location = new System.Drawing.Point(12, 59);
            this.btnAPFLReport.Name = "btnAPFLReport";
            this.btnAPFLReport.Size = new System.Drawing.Size(168, 51);
            this.btnAPFLReport.TabIndex = 4;
            this.btnAPFLReport.Text = "REPORT";
            this.btnAPFLReport.UseVisualStyleBackColor = false;
            this.btnAPFLReport.Click += new System.EventHandler(this.btnAPFLReport_Click);
            // 
            // txtreport
            // 
            this.txtreport.BackColor = System.Drawing.Color.White;
            this.txtreport.Location = new System.Drawing.Point(12, 12);
            this.txtreport.Name = "txtreport";
            this.txtreport.Size = new System.Drawing.Size(333, 26);
            this.txtreport.TabIndex = 3;
            this.txtreport.Text = "CLICK THE BUTTON FOR PRODUCT REPORT";
            // 
            // dgAPFLReport
            // 
            this.dgAPFLReport.AllowUserToAddRows = false;
            this.dgAPFLReport.AllowUserToDeleteRows = false;
            this.dgAPFLReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAPFLReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAPFLReport.Location = new System.Drawing.Point(12, 129);
            this.dgAPFLReport.Name = "dgAPFLReport";
            this.dgAPFLReport.ReadOnly = true;
            this.dgAPFLReport.RowHeadersWidth = 62;
            this.dgAPFLReport.RowTemplate.Height = 28;
            this.dgAPFLReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAPFLReport.Size = new System.Drawing.Size(898, 366);
            this.dgAPFLReport.TabIndex = 5;
            // 
            // btnAPDLRepExit
            // 
            this.btnAPDLRepExit.BackColor = System.Drawing.Color.Red;
            this.btnAPDLRepExit.Location = new System.Drawing.Point(12, 547);
            this.btnAPDLRepExit.Name = "btnAPDLRepExit";
            this.btnAPDLRepExit.Size = new System.Drawing.Size(158, 65);
            this.btnAPDLRepExit.TabIndex = 6;
            this.btnAPDLRepExit.Text = "EXIT";
            this.btnAPDLRepExit.UseVisualStyleBackColor = false;
            this.btnAPDLRepExit.Click += new System.EventHandler(this.btnAPDLRepExit_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(940, 624);
            this.Controls.Add(this.btnAPDLRepExit);
            this.Controls.Add(this.dgAPFLReport);
            this.Controls.Add(this.btnAPFLReport);
            this.Controls.Add(this.txtreport);
            this.Name = "Report";
            this.Text = "Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgAPFLReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAPFLReport;
        private System.Windows.Forms.TextBox txtreport;
        private System.Windows.Forms.DataGridView dgAPFLReport;
        private System.Windows.Forms.Button btnAPDLRepExit;
    }
}