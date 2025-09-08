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
            this.dgvMonHoc = new System.Windows.Forms.DataGridView();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.txtSoTinChi = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.lblMaMH = new System.Windows.Forms.Label();
            this.lblTenMH = new System.Windows.Forms.Label();
            this.lblSoTinChi = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            this.SuspendLayout();

            // lblMaMH
            this.lblMaMH.AutoSize = true;
            this.lblMaMH.Location = new System.Drawing.Point(20, 23);
            this.lblMaMH.Name = "lblMaMH";
            this.lblMaMH.Size = new System.Drawing.Size(60, 16);
            this.lblMaMH.Text = "Mã MH:";

            // txtMaMH
            this.txtMaMH.Location = new System.Drawing.Point(90, 20);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(80, 22);

            // lblTenMH
            this.lblTenMH.AutoSize = true;
            this.lblTenMH.Location = new System.Drawing.Point(180, 23);
            this.lblTenMH.Name = "lblTenMH";
            this.lblTenMH.Size = new System.Drawing.Size(62, 16);
            this.lblTenMH.Text = "Tên MH:";

            // txtTenMH
            this.txtTenMH.Location = new System.Drawing.Point(250, 20);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(120, 22);

            // lblSoTinChi
            this.lblSoTinChi.AutoSize = true;
            this.lblSoTinChi.Location = new System.Drawing.Point(380, 23);
            this.lblSoTinChi.Name = "lblSoTinChi";
            this.lblSoTinChi.Size = new System.Drawing.Size(70, 16);
            this.lblSoTinChi.Text = "Số tín chỉ:";

            // txtSoTinChi
            this.txtSoTinChi.Location = new System.Drawing.Point(460, 20);
            this.txtSoTinChi.Name = "txtSoTinChi";
            this.txtSoTinChi.Size = new System.Drawing.Size(50, 22);

            // lblGhiChu
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(520, 23);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(60, 16);
            this.lblGhiChu.Text = "Ghi chú:";

            // txtGhiChu
            this.txtGhiChu.Location = new System.Drawing.Point(590, 20);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(120, 22);

            // btnThem
            this.btnThem.Text = "Thêm";
            this.btnThem.Location = new System.Drawing.Point(20, 60);
            this.btnThem.Size = new System.Drawing.Size(70, 30);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // btnSua
            this.btnSua.Text = "Sửa";
            this.btnSua.Location = new System.Drawing.Point(100, 60);
            this.btnSua.Size = new System.Drawing.Size(70, 30);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // btnXoa
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new System.Drawing.Point(180, 60);
            this.btnXoa.Size = new System.Drawing.Size(70, 30);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // btnLuu
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Location = new System.Drawing.Point(260, 60);
            this.btnLuu.Size = new System.Drawing.Size(70, 30);
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);

            // btnHienThi
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.Location = new System.Drawing.Point(340, 60);
            this.btnHienThi.Size = new System.Drawing.Size(80, 30);
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);

            // dgvMonHoc
            this.dgvMonHoc.Location = new System.Drawing.Point(20, 110);
            this.dgvMonHoc.Size = new System.Drawing.Size(690, 250);
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonHoc.ReadOnly = true;

            // FormMonHoc
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(740, 390);
            this.Controls.Add(this.lblMaMH);
            this.Controls.Add(this.txtMaMH);
            this.Controls.Add(this.lblTenMH);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.lblSoTinChi);
            this.Controls.Add(this.txtSoTinChi);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.dgvMonHoc);
            this.Name = "FormMonHoc";
            this.Text = "Quản lý môn học";
            this.Load += new System.EventHandler(this.FormMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
