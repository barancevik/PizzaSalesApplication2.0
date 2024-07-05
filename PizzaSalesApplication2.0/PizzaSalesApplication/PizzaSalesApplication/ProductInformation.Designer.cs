namespace PizzaSalesApplication
{
    partial class ProductInformation
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
            this.rctAPFL1 = new System.Windows.Forms.RichTextBox();
            this.btnAPFLViewShow = new System.Windows.Forms.Button();
            this.dgAPFLProductInfStck = new System.Windows.Forms.DataGridView();
            this.btnAPFLPInfoExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAPFLProductInfStck)).BeginInit();
            this.SuspendLayout();
            // 
            // rctAPFL1
            // 
            this.rctAPFL1.BackColor = System.Drawing.Color.White;
            this.rctAPFL1.Location = new System.Drawing.Point(12, 12);
            this.rctAPFL1.Name = "rctAPFL1";
            this.rctAPFL1.Size = new System.Drawing.Size(492, 162);
            this.rctAPFL1.TabIndex = 1;
            this.rctAPFL1.Text = "PRODUCT INFORMATION\n-DOUGH\n\nPIZZAS\n- Mexicano Pizza  - Pizza With Cheddar Sauce  " +
    " - Extravaganzza\n- Callypso - Plenty Of Meat- Pastrami & Sausage\n- Margarita- Lo" +
    "ves Mushrooms- Loves Sausage";
            // 
            // btnAPFLViewShow
            // 
            this.btnAPFLViewShow.BackColor = System.Drawing.Color.Lime;
            this.btnAPFLViewShow.Location = new System.Drawing.Point(12, 193);
            this.btnAPFLViewShow.Name = "btnAPFLViewShow";
            this.btnAPFLViewShow.Size = new System.Drawing.Size(181, 37);
            this.btnAPFLViewShow.TabIndex = 4;
            this.btnAPFLViewShow.Text = "VIEW STOCK";
            this.btnAPFLViewShow.UseVisualStyleBackColor = false;
            this.btnAPFLViewShow.Click += new System.EventHandler(this.btnAPFLViewShow_Click);
            // 
            // dgAPFLProductInfStck
            // 
            this.dgAPFLProductInfStck.AllowUserToAddRows = false;
            this.dgAPFLProductInfStck.AllowUserToDeleteRows = false;
            this.dgAPFLProductInfStck.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAPFLProductInfStck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAPFLProductInfStck.Location = new System.Drawing.Point(12, 252);
            this.dgAPFLProductInfStck.Name = "dgAPFLProductInfStck";
            this.dgAPFLProductInfStck.ReadOnly = true;
            this.dgAPFLProductInfStck.RowHeadersWidth = 62;
            this.dgAPFLProductInfStck.RowTemplate.Height = 28;
            this.dgAPFLProductInfStck.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAPFLProductInfStck.Size = new System.Drawing.Size(721, 344);
            this.dgAPFLProductInfStck.TabIndex = 5;
            // 
            // btnAPFLPInfoExit
            // 
            this.btnAPFLPInfoExit.BackColor = System.Drawing.Color.Red;
            this.btnAPFLPInfoExit.Location = new System.Drawing.Point(12, 625);
            this.btnAPFLPInfoExit.Name = "btnAPFLPInfoExit";
            this.btnAPFLPInfoExit.Size = new System.Drawing.Size(129, 69);
            this.btnAPFLPInfoExit.TabIndex = 6;
            this.btnAPFLPInfoExit.Text = "ÇIKIŞ";
            this.btnAPFLPInfoExit.UseVisualStyleBackColor = false;
            this.btnAPFLPInfoExit.Click += new System.EventHandler(this.btnAPFLPInfoExit_Click);
            // 
            // ProductInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(1001, 706);
            this.Controls.Add(this.btnAPFLPInfoExit);
            this.Controls.Add(this.dgAPFLProductInfStck);
            this.Controls.Add(this.btnAPFLViewShow);
            this.Controls.Add(this.rctAPFL1);
            this.Name = "ProductInformation";
            this.Text = "ProductInformation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgAPFLProductInfStck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rctAPFL1;
        private System.Windows.Forms.Button btnAPFLViewShow;
        private System.Windows.Forms.DataGridView dgAPFLProductInfStck;
        private System.Windows.Forms.Button btnAPFLPInfoExit;
    }
}