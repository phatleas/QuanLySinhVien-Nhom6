namespace QuanLySV1
{
    partial class FormDangKy
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.LinkLabel linkDangNhap;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTaiKhoan = new Label();
            lblMatKhau = new Label();
            lblEmail = new Label();
            txtTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            txtEmail = new TextBox();
            btnDangKy = new Button();
            btnThoat = new Button();
            linkDangNhap = new LinkLabel();
            SuspendLayout();
            // 
            // lblTaiKhoan
            // 
            lblTaiKhoan.AutoSize = true;
            lblTaiKhoan.Location = new Point(40, 30);
            lblTaiKhoan.Name = "lblTaiKhoan";
            lblTaiKhoan.Size = new Size(61, 15);
            lblTaiKhoan.TabIndex = 0;
            lblTaiKhoan.Text = "Tài khoản:";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Location = new Point(40, 70);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(60, 15);
            lblMatKhau.TabIndex = 1;
            lblMatKhau.Text = "Mật khẩu:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(40, 110);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(130, 27);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(180, 23);
            txtTaiKhoan.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(130, 67);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(180, 23);
            txtMatKhau.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(130, 107);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(180, 23);
            txtEmail.TabIndex = 5;
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(130, 150);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(90, 30);
            btnDangKy.TabIndex = 6;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(230, 150);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(80, 30);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            // 
            // linkDangNhap
            // 
            linkDangNhap.AutoSize = true;
            linkDangNhap.Location = new Point(130, 190);
            linkDangNhap.Name = "linkDangNhap";
            linkDangNhap.Size = new Size(94, 15);
            linkDangNhap.TabIndex = 8;
            linkDangNhap.TabStop = true;
            linkDangNhap.Text = "Đã có tài khoản?";
            linkDangNhap.Click += linkDangNhap_LinkClicked;
            // 
            // FormDangKy
            // 
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(442, 252);
            Controls.Add(lblTaiKhoan);
            Controls.Add(lblMatKhau);
            Controls.Add(lblEmail);
            Controls.Add(txtTaiKhoan);
            Controls.Add(txtMatKhau);
            Controls.Add(txtEmail);
            Controls.Add(btnDangKy);
            Controls.Add(btnThoat);
            Controls.Add(linkDangNhap);
            Name = "FormDangKy";
            Text = "Đăng ký";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
