namespace Voucher
{
    partial class mainmenu
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
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.buttonmaster = new System.Windows.Forms.Button();
            this.buttoncustomer = new System.Windows.Forms.Button();
            this.buttonextract = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonproces = new System.Windows.Forms.Button();
            this.buttonkalkulasi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonmaster
            // 
            this.buttonmaster.Location = new System.Drawing.Point(12, 12);
            this.buttonmaster.Name = "buttonmaster";
            this.buttonmaster.Size = new System.Drawing.Size(138, 66);
            this.buttonmaster.TabIndex = 1;
            this.buttonmaster.Text = "Master";
            this.buttonmaster.UseVisualStyleBackColor = true;
            this.buttonmaster.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttoncustomer
            // 
            this.buttoncustomer.Location = new System.Drawing.Point(12, 93);
            this.buttoncustomer.Name = "buttoncustomer";
            this.buttoncustomer.Size = new System.Drawing.Size(138, 66);
            this.buttoncustomer.TabIndex = 2;
            this.buttoncustomer.Text = "Customer Data";
            this.buttoncustomer.UseVisualStyleBackColor = true;
            this.buttoncustomer.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonextract
            // 
            this.buttonextract.Location = new System.Drawing.Point(325, 12);
            this.buttonextract.Name = "buttonextract";
            this.buttonextract.Size = new System.Drawing.Size(138, 66);
            this.buttonextract.TabIndex = 5;
            this.buttonextract.Text = "Extract Report";
            this.buttonextract.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(325, 93);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 66);
            this.button4.TabIndex = 6;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonproces
            // 
            this.buttonproces.Location = new System.Drawing.Point(166, 93);
            this.buttonproces.Name = "buttonproces";
            this.buttonproces.Size = new System.Drawing.Size(138, 66);
            this.buttonproces.TabIndex = 4;
            this.buttonproces.Text = "Proses Report";
            this.buttonproces.UseVisualStyleBackColor = true;
            this.buttonproces.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonkalkulasi
            // 
            this.buttonkalkulasi.Location = new System.Drawing.Point(166, 12);
            this.buttonkalkulasi.Name = "buttonkalkulasi";
            this.buttonkalkulasi.Size = new System.Drawing.Size(138, 66);
            this.buttonkalkulasi.TabIndex = 3;
            this.buttonkalkulasi.Text = "Setting Kalkulasi";
            this.buttonkalkulasi.UseVisualStyleBackColor = true;
            this.buttonkalkulasi.Click += new System.EventHandler(this.buttonkalkulasi_Click);
            // 
            // mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 175);
            this.Controls.Add(this.buttonkalkulasi);
            this.Controls.Add(this.buttonproces);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonextract);
            this.Controls.Add(this.buttoncustomer);
            this.Controls.Add(this.buttonmaster);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "mainmenu";
            this.Text = "MDIParent2";
            this.Load += new System.EventHandler(this.MDIParent2_Load);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button buttonmaster;
        private System.Windows.Forms.Button buttoncustomer;
        private System.Windows.Forms.Button buttonextract;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonproces;
        private System.Windows.Forms.Button buttonkalkulasi;
    }
}



