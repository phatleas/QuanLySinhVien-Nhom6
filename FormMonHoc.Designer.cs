namespace QuanLySV1
{
    partial class FormMonHoc
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvMonHoc;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.TextBox txtSoTinChi;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Label lblMaMH;
        private System.Windows.Forms.Label lblTenMH;
        private System.Windows.Forms.Label lblSoTinChi;
        private System.Windows.Forms.Label lblGhiChu;

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
            dgvMonHoc = new DataGridView();
            txtMaMH = new TextBox();
            txtTenMH = new TextBox();
            txtSoTinChi = new TextBox();
            txtGhiChu = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnHienThi = new Button();
            lblMaMH = new Label();
            lblTenMH = new Label();
            lblSoTinChi = new Label();
            lblGhiChu = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMonHoc).BeginInit();
            SuspendLayout();
            // 
            // dgvMonHoc
            // 
            dgvMonHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMonHoc.ColumnHeadersHeight = 27;
            dgvMonHoc.Location = new Point(69, 257);
            dgvMonHoc.Name = "dgvMonHoc";
            dgvMonHoc.ReadOnly = true;
            dgvMonHoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMonHoc.Size = new Size(821, 347);
            dgvMonHoc.TabIndex = 13;
            // 
            // txtMaMH
            // 
            txtMaMH.Location = new Point(275, 96);
            txtMaMH.Name = "txtMaMH";
            txtMaMH.Size = new Size(109, 29);
            txtMaMH.TabIndex = 1;
            // 
            // txtTenMH
            // 
            txtTenMH.Location = new Point(573, 96);
            txtTenMH.Name = "txtTenMH";
            txtTenMH.Size = new Size(120, 29);
            txtTenMH.TabIndex = 3;
            // 
            // txtSoTinChi
            // 
            txtSoTinChi.Location = new Point(275, 158);
            txtSoTinChi.Name = "txtSoTinChi";
            txtSoTinChi.Size = new Size(120, 29);
            txtSoTinChi.TabIndex = 5;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(573, 161);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(120, 29);
            txtGhiChu.TabIndex = 7;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(69, 636);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(70, 30);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(160, 636);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(70, 30);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(254, 636);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(70, 30);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(363, 636);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(70, 30);
            btnLuu.TabIndex = 11;
            btnLuu.Text = "Lưu";
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(461, 636);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(80, 30);
            btnHienThi.TabIndex = 12;
            btnHienThi.Text = "Hiển thị";
            btnHienThi.Click += btnHienThi_Click;
            // 
            // lblMaMH
            // 
            lblMaMH.AutoSize = true;
            lblMaMH.Location = new Point(171, 96);
            lblMaMH.Name = "lblMaMH";
            lblMaMH.Size = new Size(80, 22);
            lblMaMH.TabIndex = 0;
            lblMaMH.Text = "Mã MH:";
            // 
            // lblTenMH
            // 
            lblTenMH.AutoSize = true;
            lblTenMH.Location = new Point(461, 103);
            lblTenMH.Name = "lblTenMH";
            lblTenMH.Size = new Size(84, 22);
            lblTenMH.TabIndex = 2;
            lblTenMH.Text = "Tên MH:";
            // 
            // lblSoTinChi
            // 
            lblSoTinChi.AutoSize = true;
            lblSoTinChi.Location = new Point(160, 161);
            lblSoTinChi.Name = "lblSoTinChi";
            lblSoTinChi.Size = new Size(91, 22);
            lblSoTinChi.TabIndex = 4;
            lblSoTinChi.Text = "Số tín chỉ:";
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Location = new Point(466, 164);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(79, 22);
            lblGhiChu.TabIndex = 6;
            lblGhiChu.Text = "Ghi chú:";
            // 
            // FormMonHoc
            // 
            ClientSize = new Size(1266, 751);
            Controls.Add(lblMaMH);
            Controls.Add(txtMaMH);
            Controls.Add(lblTenMH);
            Controls.Add(txtTenMH);
            Controls.Add(lblSoTinChi);
            Controls.Add(txtSoTinChi);
            Controls.Add(lblGhiChu);
            Controls.Add(txtGhiChu);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnLuu);
            Controls.Add(btnHienThi);
            Controls.Add(dgvMonHoc);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "FormMonHoc";
            Text = "Quản lý môn học";
            Load += FormMonHoc_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMonHoc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
