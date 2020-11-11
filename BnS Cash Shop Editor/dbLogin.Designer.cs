namespace BnS_Cash_Shop_Editor
{
    partial class dbLogin
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
            this.btn_dbConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_dbPass = new System.Windows.Forms.TextBox();
            this.tb_dbUser = new System.Windows.Forms.TextBox();
            this.tb_IP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_dbConnect
            // 
            this.btn_dbConnect.Location = new System.Drawing.Point(12, 100);
            this.btn_dbConnect.Name = "btn_dbConnect";
            this.btn_dbConnect.Size = new System.Drawing.Size(196, 35);
            this.btn_dbConnect.TabIndex = 0;
            this.btn_dbConnect.Text = "Connect";
            this.btn_dbConnect.UseVisualStyleBackColor = true;
            this.btn_dbConnect.Click += new System.EventHandler(this.btn_dbConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "dbUser";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "dbPass";
            // 
            // tb_dbPass
            // 
            this.tb_dbPass.Location = new System.Drawing.Point(60, 72);
            this.tb_dbPass.Name = "tb_dbPass";
            this.tb_dbPass.Size = new System.Drawing.Size(148, 20);
            this.tb_dbPass.TabIndex = 4;
            this.tb_dbPass.Text = "FSmElsXuj3ls8Fq";
            // 
            // tb_dbUser
            // 
            this.tb_dbUser.Location = new System.Drawing.Point(60, 46);
            this.tb_dbUser.Name = "tb_dbUser";
            this.tb_dbUser.Size = new System.Drawing.Size(148, 20);
            this.tb_dbUser.TabIndex = 5;
            this.tb_dbUser.Text = "sa";
            // 
            // tb_IP
            // 
            this.tb_IP.Location = new System.Drawing.Point(60, 22);
            this.tb_IP.Name = "tb_IP";
            this.tb_IP.Size = new System.Drawing.Size(148, 20);
            this.tb_IP.TabIndex = 6;
            this.tb_IP.Text = "192.168.1.27";
            // 
            // dbLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 147);
            this.Controls.Add(this.tb_IP);
            this.Controls.Add(this.tb_dbUser);
            this.Controls.Add(this.tb_dbPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_dbConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "dbLogin";
            this.Text = "dbLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_dbConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_dbPass;
        private System.Windows.Forms.TextBox tb_dbUser;
        private System.Windows.Forms.TextBox tb_IP;
    }
}