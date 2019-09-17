namespace QuanLiNhanSu
{
    partial class FormDangNhap
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDN = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtDanhNhap = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.Label();
            this.txtQLNS = new System.Windows.Forms.Label();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnDN);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.txtDanhNhap);
            this.groupBox1.Controls.Add(this.txtMK);
            this.groupBox1.Controls.Add(this.txtTK);
            this.groupBox1.Controls.Add(this.txtQLNS);
            this.groupBox1.Location = new System.Drawing.Point(586, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 288);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThoat.Location = new System.Drawing.Point(174, 207);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(104, 25);
            this.btnThoat.TabIndex = 21;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDN
            // 
            this.btnDN.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDN.Location = new System.Drawing.Point(27, 207);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(104, 25);
            this.btnDN.TabIndex = 20;
            this.btnDN.Text = "Đăng Nhập";
            this.btnDN.UseVisualStyleBackColor = true;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMatKhau.Location = new System.Drawing.Point(26, 172);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(252, 20);
            this.txtMatKhau.TabIndex = 19;
            this.txtMatKhau.Text = "444";
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtDanhNhap
            // 
            this.txtDanhNhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDanhNhap.Location = new System.Drawing.Point(26, 103);
            this.txtDanhNhap.Name = "txtDanhNhap";
            this.txtDanhNhap.Size = new System.Drawing.Size(252, 20);
            this.txtDanhNhap.TabIndex = 18;
            this.txtDanhNhap.Text = "TPKT";
            this.txtDanhNhap.TextChanged += new System.EventHandler(this.txtDanhNhap_TextChanged);
            // 
            // txtMK
            // 
            this.txtMK.AutoSize = true;
            this.txtMK.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMK.Location = new System.Drawing.Point(23, 142);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(68, 17);
            this.txtMK.TabIndex = 17;
            this.txtMK.Text = "Mật Khẩu";
            // 
            // txtTK
            // 
            this.txtTK.AutoSize = true;
            this.txtTK.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTK.Location = new System.Drawing.Point(23, 72);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(70, 17);
            this.txtTK.TabIndex = 16;
            this.txtTK.Text = "Tài Khoản";
            // 
            // txtQLNS
            // 
            this.txtQLNS.AutoSize = true;
            this.txtQLNS.BackColor = System.Drawing.Color.White;
            this.txtQLNS.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQLNS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtQLNS.Location = new System.Drawing.Point(22, 16);
            this.txtQLNS.Name = "txtQLNS";
            this.txtQLNS.Size = new System.Drawing.Size(147, 15);
            this.txtQLNS.TabIndex = 15;
            this.txtQLNS.Text = "ĐĂNG NHẬP HỆ THỐNG";
            this.txtQLNS.Click += new System.EventHandler(this.txtQLNS_Click);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(346, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(380, 32);
            this.labelX1.SymbolColor = System.Drawing.Color.White;
            this.labelX1.TabIndex = 16;
            this.labelX1.Text = "HỆ THỐNG QUẢN LÝ NHÂN SỰ";
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::QuanLiNhanSu.Properties.Resources.HR_ESS;
            this.ClientSize = new System.Drawing.Size(967, 467);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormDangNhap";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDN;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtDanhNhap;
        private System.Windows.Forms.Label txtMK;
        private System.Windows.Forms.Label txtTK;
        private System.Windows.Forms.Label txtQLNS;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}

