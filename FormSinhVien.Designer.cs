namespace QuanLySV1
{
    partial class FormSinhVien
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtHoDem;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnTimKiem1;
        private System.Windows.Forms.Button btnTimKiem2;
        private System.Windows.Forms.Button btnXemDSSV;
        private System.Windows.Forms.Button btnXemTheoKhoa;
        private System.Windows.Forms.Button btnXemDiem;
        private System.Windows.Forms.Button btnXemDiemTheoMon;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblHoDem;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Label lblKhoa;

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
            dgvSinhVien = new DataGridView();
            txtMaSV = new TextBox();
            txtHoDem = new TextBox();
            txtTen = new TextBox();
            txtNgaySinh = new TextBox();
            txtGioiTinh = new TextBox();
            txtLop = new TextBox();
            txtGhiChu = new TextBox();
            txtTimKiem = new TextBox();
            cboKhoa = new ComboBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnHienThi = new Button();
            btnTimKiem1 = new Button();
            btnTimKiem2 = new Button();
            btnXemDSSV = new Button();
            btnXemTheoKhoa = new Button();
            btnXemDiem = new Button();
            btnXemDiemTheoMon = new Button();
            lblMaSV = new Label();
            lblHoDem = new Label();
            lblTen = new Label();
            lblNgaySinh = new Label();
            lblGioiTinh = new Label();
            lblLop = new Label();
            lblGhiChu = new Label();
            lblTimKiem = new Label();
            lblKhoa = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSinhVien.Location = new Point(20, 366);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.ReadOnly = true;
            dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSinhVien.Size = new Size(1224, 328);
            dgvSinhVien.TabIndex = 29;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(110, 17);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(200, 25);
            txtMaSV.TabIndex = 9;
            // 
            // txtHoDem
            // 
            txtHoDem.Location = new Point(110, 47);
            txtHoDem.Name = "txtHoDem";
            txtHoDem.Size = new Size(200, 25);
            txtHoDem.TabIndex = 10;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(110, 77);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(200, 25);
            txtTen.TabIndex = 11;
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Location = new Point(110, 107);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(200, 25);
            txtNgaySinh.TabIndex = 12;
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.Location = new Point(110, 137);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(200, 25);
            txtGioiTinh.TabIndex = 13;
            // 
            // txtLop
            // 
            txtLop.Location = new Point(110, 167);
            txtLop.Name = "txtLop";
            txtLop.Size = new Size(200, 25);
            txtLop.TabIndex = 14;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(110, 197);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(200, 25);
            txtGhiChu.TabIndex = 15;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(480, 17);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(180, 25);
            txtTimKiem.TabIndex = 16;
            // 
            // cboKhoa
            // 
            cboKhoa.Location = new Point(480, 57);
            cboKhoa.Name = "cboKhoa";
            cboKhoa.Size = new Size(180, 25);
            cboKhoa.TabIndex = 17;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(20, 240);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(70, 30);
            btnThem.TabIndex = 18;
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(100, 240);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(70, 30);
            btnSua.TabIndex = 19;
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(180, 240);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(70, 30);
            btnXoa.TabIndex = 20;
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(260, 240);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(70, 30);
            btnLuu.TabIndex = 21;
            btnLuu.Text = "Lưu";
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(340, 240);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(80, 30);
            btnHienThi.TabIndex = 22;
            btnHienThi.Text = "Hiển thị";
            btnHienThi.Click += btnHienThi_Click;
            // 
            // btnTimKiem1
            // 
            btnTimKiem1.Location = new Point(670, 15);
            btnTimKiem1.Name = "btnTimKiem1";
            btnTimKiem1.Size = new Size(100, 26);
            btnTimKiem1.TabIndex = 23;
            btnTimKiem1.Text = "Tìm theo tên/mã";
            btnTimKiem1.Click += btnTimKiem1_Click;
            // 
            // btnTimKiem2
            // 
            btnTimKiem2.Location = new Point(670, 55);
            btnTimKiem2.Name = "btnTimKiem2";
            btnTimKiem2.Size = new Size(100, 26);
            btnTimKiem2.TabIndex = 24;
            btnTimKiem2.Text = "Tìm theo khoa";
            btnTimKiem2.Click += btnTimKiem2_Click;
            // 
            // btnXemDSSV
            // 
            btnXemDSSV.Location = new Point(20, 280);
            btnXemDSSV.Name = "btnXemDSSV";
            btnXemDSSV.Size = new Size(100, 30);
            btnXemDSSV.TabIndex = 25;
            btnXemDSSV.Text = "Xem DS SV";
            btnXemDSSV.Click += btnXemDSSV_Click;
            // 
            // btnXemTheoKhoa
            // 
            btnXemTheoKhoa.Location = new Point(130, 280);
            btnXemTheoKhoa.Name = "btnXemTheoKhoa";
            btnXemTheoKhoa.Size = new Size(120, 30);
            btnXemTheoKhoa.TabIndex = 26;
            btnXemTheoKhoa.Text = "Xem theo khoa";
            btnXemTheoKhoa.Click += btnXemTheoKhoa_Click;
            // 
            // btnXemDiem
            // 
            btnXemDiem.Location = new Point(260, 280);
            btnXemDiem.Name = "btnXemDiem";
            btnXemDiem.Size = new Size(100, 30);
            btnXemDiem.TabIndex = 27;
            btnXemDiem.Text = "Xem điểm";
            btnXemDiem.Click += btnXemDiem_Click;
            // 
            // btnXemDiemTheoMon
            // 
            btnXemDiemTheoMon.Location = new Point(370, 280);
            btnXemDiemTheoMon.Name = "btnXemDiemTheoMon";
            btnXemDiemTheoMon.Size = new Size(140, 30);
            btnXemDiemTheoMon.TabIndex = 28;
            btnXemDiemTheoMon.Text = "Xem điểm theo môn";
            btnXemDiemTheoMon.Click += btnXemDiemTheoMon_Click;
            // 
            // lblMaSV
            // 
            lblMaSV.AutoSize = true;
            lblMaSV.Location = new Point(20, 20);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Size = new Size(49, 17);
            lblMaSV.TabIndex = 0;
            lblMaSV.Text = "Mã SV:";
            // 
            // lblHoDem
            // 
            lblHoDem.AutoSize = true;
            lblHoDem.Location = new Point(20, 50);
            lblHoDem.Name = "lblHoDem";
            lblHoDem.Size = new Size(58, 17);
            lblHoDem.TabIndex = 1;
            lblHoDem.Text = "Họ đệm:";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(20, 80);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(31, 17);
            lblTen.TabIndex = 2;
            lblTen.Text = "Tên:";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(20, 110);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(69, 17);
            lblNgaySinh.TabIndex = 3;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(20, 140);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(59, 17);
            lblGioiTinh.TabIndex = 4;
            lblGioiTinh.Text = "Giới tính:";
            // 
            // lblLop
            // 
            lblLop.AutoSize = true;
            lblLop.Location = new Point(20, 170);
            lblLop.Name = "lblLop";
            lblLop.Size = new Size(33, 17);
            lblLop.TabIndex = 5;
            lblLop.Text = "Lớp:";
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Location = new Point(20, 200);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(54, 17);
            lblGhiChu.TabIndex = 6;
            lblGhiChu.Text = "Ghi chú:";
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new Point(400, 20);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(63, 17);
            lblTimKiem.TabIndex = 7;
            lblTimKiem.Text = "Tìm kiếm:";
            // 
            // lblKhoa
            // 
            lblKhoa.AutoSize = true;
            lblKhoa.Location = new Point(400, 60);
            lblKhoa.Name = "lblKhoa";
            lblKhoa.Size = new Size(41, 17);
            lblKhoa.TabIndex = 8;
            lblKhoa.Text = "Khoa:";
            // 
            // FormSinhVien
            // 
            ClientSize = new Size(1291, 751);
            Controls.Add(lblMaSV);
            Controls.Add(lblHoDem);
            Controls.Add(lblTen);
            Controls.Add(lblNgaySinh);
            Controls.Add(lblGioiTinh);
            Controls.Add(lblLop);
            Controls.Add(lblGhiChu);
            Controls.Add(lblTimKiem);
            Controls.Add(lblKhoa);
            Controls.Add(txtMaSV);
            Controls.Add(txtHoDem);
            Controls.Add(txtTen);
            Controls.Add(txtNgaySinh);
            Controls.Add(txtGioiTinh);
            Controls.Add(txtLop);
            Controls.Add(txtGhiChu);
            Controls.Add(txtTimKiem);
            Controls.Add(cboKhoa);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnLuu);
            Controls.Add(btnHienThi);
            Controls.Add(btnTimKiem1);
            Controls.Add(btnTimKiem2);
            Controls.Add(btnXemDSSV);
            Controls.Add(btnXemTheoKhoa);
            Controls.Add(btnXemDiem);
            Controls.Add(btnXemDiemTheoMon);
            Controls.Add(dgvSinhVien);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormSinhVien";
            Text = "Quản lý Sinh Viên";
            Load += FormSinhVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
