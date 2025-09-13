namespace QuanLySV1
{
    partial class FormDiem
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvDiem;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.TextBox txtDiemSo;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblMaMH;
        private System.Windows.Forms.Label lblDiemSo;
        private System.Windows.Forms.Label lblGhiChu;
        // Thêm các control tìm kiếm
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cboTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lblTimKiem;

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
            dgvDiem = new DataGridView();
            txtMaSV = new TextBox();
            txtMaMH = new TextBox();
            txtDiemSo = new TextBox();
            txtGhiChu = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnHienThi = new Button();
            lblMaSV = new Label();
            lblMaMH = new Label();
            lblDiemSo = new Label();
            lblGhiChu = new Label();
            txtTimKiem = new TextBox();
            cboTimKiem = new ComboBox();
            btnTimKiem = new Button();
            btnLamMoi = new Button();
            lblTimKiem = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDiem).BeginInit();
            SuspendLayout();
            // 
            // dgvDiem
            // 
            dgvDiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDiem.Location = new Point(20, 150);
            dgvDiem.Name = "dgvDiem";
            dgvDiem.ReadOnly = true;
            dgvDiem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDiem.Size = new Size(660, 250);
            dgvDiem.TabIndex = 16;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(80, 20);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(80, 29);
            txtMaSV.TabIndex = 1;
            // 
            // txtMaMH
            // 
            txtMaMH.Location = new Point(240, 20);
            txtMaMH.Name = "txtMaMH";
            txtMaMH.Size = new Size(80, 29);
            txtMaMH.TabIndex = 3;
            // 
            // txtDiemSo
            // 
            txtDiemSo.Location = new Point(410, 20);
            txtDiemSo.Name = "txtDiemSo";
            txtDiemSo.Size = new Size(60, 29);
            txtDiemSo.TabIndex = 5;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(560, 20);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(120, 29);
            txtGhiChu.TabIndex = 7;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(20, 60);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(70, 30);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(100, 60);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(70, 30);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(180, 60);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(70, 30);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(260, 60);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(70, 30);
            btnLuu.TabIndex = 11;
            btnLuu.Text = "Lưu";
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(340, 60);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(80, 30);
            btnHienThi.TabIndex = 12;
            btnHienThi.Text = "Hiển thị";
            btnHienThi.Click += btnHienThi_Click;
            // 
            // lblMaSV
            // 
            lblMaSV.AutoSize = true;
            lblMaSV.Location = new Point(20, 23);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Size = new Size(58, 21);
            lblMaSV.TabIndex = 0;
            lblMaSV.Text = "Mã SV:";
            // 
            // lblMaMH
            // 
            lblMaMH.AutoSize = true;
            lblMaMH.Location = new Point(180, 23);
            lblMaMH.Name = "lblMaMH";
            lblMaMH.Size = new Size(64, 21);
            lblMaMH.TabIndex = 2;
            lblMaMH.Text = "Mã MH:";
            // 
            // lblDiemSo
            // 
            lblDiemSo.AutoSize = true;
            lblDiemSo.Location = new Point(340, 23);
            lblDiemSo.Name = "lblDiemSo";
            lblDiemSo.Size = new Size(70, 21);
            lblDiemSo.TabIndex = 4;
            lblDiemSo.Text = "Điểm số:";
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Location = new Point(490, 23);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(66, 21);
            lblGhiChu.TabIndex = 6;
            lblGhiChu.Text = "Ghi chú:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(240, 107);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(200, 29);
            txtTimKiem.TabIndex = 1;
            // 
            // cboTimKiem
            // 
            cboTimKiem.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTimKiem.FormattingEnabled = true;
            cboTimKiem.Items.AddRange(new object[] { "Mã sinh viên", "Tên sinh viên", "Mã môn học", "Tên môn học", "Điểm số" });
            cboTimKiem.Location = new Point(100, 107);
            cboTimKiem.Name = "cboTimKiem";
            cboTimKiem.Size = new Size(120, 29);
            cboTimKiem.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(460, 105);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(80, 30);
            btnTimKiem.TabIndex = 14;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(560, 105);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(80, 30);
            btnLamMoi.TabIndex = 15;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new Point(20, 110);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(77, 21);
            lblTimKiem.TabIndex = 13;
            lblTimKiem.Text = "Tìm kiếm:";
            // 
            // FormDiem
            // 
            ClientSize = new Size(998, 579);
            Controls.Add(lblMaSV);
            Controls.Add(txtMaSV);
            Controls.Add(lblMaMH);
            Controls.Add(txtMaMH);
            Controls.Add(lblDiemSo);
            Controls.Add(txtDiemSo);
            Controls.Add(lblGhiChu);
            Controls.Add(txtGhiChu);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnLuu);
            Controls.Add(btnHienThi);
            Controls.Add(lblTimKiem);
            Controls.Add(cboTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(btnLamMoi);
            Controls.Add(dgvDiem);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormDiem";
            Text = "Quản lý điểm";
            Load += FormDiem_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDiem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}