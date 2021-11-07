namespace CHUNGKHOAN
{
    partial class frmTaiKhoan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bntTAO = new System.Windows.Forms.Button();
            this.btnTHOAT = new System.Windows.Forms.Button();
            this.txtTAIKHOAN = new System.Windows.Forms.TextBox();
            this.txtMATKHAU = new System.Windows.Forms.TextBox();
            this.cmbMANV = new System.Windows.Forms.ComboBox();
            this.cmbQUYEN = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbQUYEN);
            this.groupBox1.Controls.Add(this.cmbMANV);
            this.groupBox1.Controls.Add(this.txtMATKHAU);
            this.groupBox1.Controls.Add(this.txtTAIKHOAN);
            this.groupBox1.Controls.Add(this.btnTHOAT);
            this.groupBox1.Controls.Add(this.bntTAO);
            this.groupBox1.Location = new System.Drawing.Point(107, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 364);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // bntTAO
            // 
            this.bntTAO.Location = new System.Drawing.Point(200, 259);
            this.bntTAO.Name = "bntTAO";
            this.bntTAO.Size = new System.Drawing.Size(134, 43);
            this.bntTAO.TabIndex = 0;
            this.bntTAO.Text = "Tạo Tài Khoản";
            this.bntTAO.UseVisualStyleBackColor = true;
            this.bntTAO.Click += new System.EventHandler(this.bntTAO_Click);
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.Location = new System.Drawing.Point(389, 259);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(134, 43);
            this.btnTHOAT.TabIndex = 1;
            this.btnTHOAT.Text = "Thoát";
            this.btnTHOAT.UseVisualStyleBackColor = true;
            this.btnTHOAT.Click += new System.EventHandler(this.btnTHOAT_Click);
            // 
            // txtTAIKHOAN
            // 
            this.txtTAIKHOAN.Location = new System.Drawing.Point(160, 107);
            this.txtTAIKHOAN.Name = "txtTAIKHOAN";
            this.txtTAIKHOAN.Size = new System.Drawing.Size(174, 26);
            this.txtTAIKHOAN.TabIndex = 2;
            // 
            // txtMATKHAU
            // 
            this.txtMATKHAU.Location = new System.Drawing.Point(160, 183);
            this.txtMATKHAU.Name = "txtMATKHAU";
            this.txtMATKHAU.Size = new System.Drawing.Size(174, 26);
            this.txtMATKHAU.TabIndex = 3;
            // 
            // cmbMANV
            // 
            this.cmbMANV.FormattingEnabled = true;
            this.cmbMANV.Location = new System.Drawing.Point(389, 105);
            this.cmbMANV.Name = "cmbMANV";
            this.cmbMANV.Size = new System.Drawing.Size(174, 28);
            this.cmbMANV.TabIndex = 4;
            // 
            // cmbQUYEN
            // 
            this.cmbQUYEN.FormattingEnabled = true;
            this.cmbQUYEN.Location = new System.Drawing.Point(389, 183);
            this.cmbQUYEN.Name = "cmbQUYEN";
            this.cmbQUYEN.Size = new System.Drawing.Size(174, 28);
            this.cmbQUYEN.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tài Khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã NV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mật Khẩu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quyền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(209, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "THÔNG TIN TẠO TÀI KHOẢN";
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTaiKhoan";
            this.Text = "frmTaiKhoan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTaiKhoan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbQUYEN;
        private System.Windows.Forms.ComboBox cmbMANV;
        private System.Windows.Forms.TextBox txtMATKHAU;
        private System.Windows.Forms.TextBox txtTAIKHOAN;
        private System.Windows.Forms.Button btnTHOAT;
        private System.Windows.Forms.Button bntTAO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}