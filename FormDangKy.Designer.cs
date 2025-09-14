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
            label1 = new Label();
            SuspendLayout();
            // 
            // lblTaiKhoan
            // 
            lblTaiKhoan.AutoSize = true;
            lblTaiKhoan.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTaiKhoan.Location = new Point(313, 209);
            lblTaiKhoan.Name = "lblTaiKhoan";
            lblTaiKhoan.Size = new Size(120, 32);
            lblTaiKhoan.TabIndex = 0;
            lblTaiKhoan.Text = "Tài khoản:";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMatKhau.Location = new Point(314, 280);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(120, 32);
            lblMatKhau.TabIndex = 1;
            lblMatKhau.Text = "Mật khẩu:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(347, 371);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(76, 32);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTaiKhoan.Location = new Point(466, 209);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(225, 39);
            txtTaiKhoan.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhau.Location = new Point(466, 280);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(225, 39);
            txtMatKhau.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(466, 371);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(225, 39);
            txtEmail.TabIndex = 5;
            // 
            // btnDangKy
            // 
            btnDangKy.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangKy.Location = new Point(286, 461);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(166, 67);
            btnDangKy.TabIndex = 6;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(638, 470);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(137, 58);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            // 
            // linkDangNhap
            // 
            linkDangNhap.AutoSize = true;
            linkDangNhap.Location = new Point(424, 577);
            linkDangNhap.Name = "linkDangNhap";
            linkDangNhap.Size = new Size(152, 25);
            linkDangNhap.TabIndex = 8;
            linkDangNhap.TabStop = true;
            linkDangNhap.Text = "Đã có tài khoản?";
            linkDangNhap.Click += linkDangNhap_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(382, 100);
            label1.Name = "label1";
            label1.Size = new Size(316, 50);
            label1.TabIndex = 9;
            label1.Text = "Đăg ký tài khoản";
            // 
            // FormDangKy
            // 
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1061, 703);
            Controls.Add(label1);
            Controls.Add(lblTaiKhoan);
            Controls.Add(lblMatKhau);
            Controls.Add(lblEmail);
            Controls.Add(txtTaiKhoan);
            Controls.Add(txtMatKhau);
            Controls.Add(txtEmail);
            Controls.Add(btnDangKy);
            Controls.Add(btnThoat);
            Controls.Add(linkDangNhap);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormDangKy";
            Text = "Đăng ký";
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
    }
}
