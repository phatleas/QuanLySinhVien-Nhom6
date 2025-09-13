using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace QuanLySV1
{
    public partial class FormSinhVien : Form
    {
        string connectionString = @"Server=.\SQLEXPRESS;Database=QuanLySinhVien;Integrated Security=True;TrustServerCertificate=True;";

        public FormSinhVien()
        {
            InitializeComponent();
            dgvSinhVien.CellClick += dgvSinhVien_CellClick;
        }

        private void FormSinhVien_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadKhoa();
            LoadDanToc();
            
        }

        // Load danh sách sinh viên
        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = @"SELECT sv.MaSV, sv.HoDem, sv.Ten, sv.NgaySinh, sv.GioiTinh, sv.MaLop, 
                                         sv.MaDanToc, 
                                         CASE 
                                             WHEN dt.TenDanToc IS NOT NULL THEN dt.TenDanToc
                                             ELSE 'Chưa xác định' 
                                         END as TenDanToc, 
                                         sv.GhiChu
                                  FROM SinhVien sv 
                                  LEFT JOIN DanToc dt ON sv.MaDanToc = dt.MaDanToc";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvSinhVien.DataSource = dt;
                    
                    // Đặt tên cột hiển thị và ẩn cột không cần thiết
                    if (dgvSinhVien.Columns.Count > 0)
                    {
                        if (dgvSinhVien.Columns["MaSV"] != null)
                            dgvSinhVien.Columns["MaSV"].HeaderText = "Mã SV";
                        if (dgvSinhVien.Columns["HoDem"] != null)
                            dgvSinhVien.Columns["HoDem"].HeaderText = "Họ đệm";
                        if (dgvSinhVien.Columns["Ten"] != null)
                            dgvSinhVien.Columns["Ten"].HeaderText = "Tên";
                        if (dgvSinhVien.Columns["NgaySinh"] != null)
                            dgvSinhVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                        if (dgvSinhVien.Columns["GioiTinh"] != null)
                            dgvSinhVien.Columns["GioiTinh"].HeaderText = "Giới tính";
                        if (dgvSinhVien.Columns["MaLop"] != null)
                            dgvSinhVien.Columns["MaLop"].HeaderText = "Mã lớp";
                        if (dgvSinhVien.Columns["TenDanToc"] != null)
                            dgvSinhVien.Columns["TenDanToc"].HeaderText = "Dân tộc";
                        if (dgvSinhVien.Columns["GhiChu"] != null)
                            dgvSinhVien.Columns["GhiChu"].HeaderText = "Ghi chú";
                        
                        // Ẩn cột MaDanToc vì đã có TenDanToc
                        if (dgvSinhVien.Columns["MaDanToc"] != null)
                            dgvSinhVien.Columns["MaDanToc"].Visible = false;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load danh sách khoa vào ComboBox
        private void LoadKhoa()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT TenKhoa FROM Khoa";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cboKhoa.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    cboKhoa.Items.Add(row["TenKhoa"].ToString());
                }
            }
        }

        // Load danh sách dân tộc vào ComboBox
        private void LoadDanToc()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Kiểm tra cấu trúc bảng DanToc
                    string checkSql = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'DanToc'";
                    SqlDataAdapter checkDa = new SqlDataAdapter(checkSql, conn);
                    DataTable checkDt = new DataTable();
                    checkDa.Fill(checkDt);
                    
                    bool hasMaDanToc = false;
                    foreach (DataRow row in checkDt.Rows)
                    {
                        if (row["COLUMN_NAME"].ToString() == "MaDanToc")
                        {
                            hasMaDanToc = true;
                            break;
                        }
                    }
                    
                    if (hasMaDanToc)
                    {
                        // Bảng có cột MaDanToc
                        string sql = "SELECT MaDanToc, TenDanToc FROM DanToc ORDER BY TenDanToc";
                        SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        
                        cboDanToc.DataSource = dt;
                        cboDanToc.DisplayMember = "TenDanToc";
                        cboDanToc.ValueMember = "MaDanToc";
                        cboDanToc.SelectedIndex = -1;
                    }
                    else
                    {
                        // Bảng chỉ có cột TenDanToc
                        string sql = "SELECT TenDanToc FROM DanToc ORDER BY TenDanToc";
                        SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        
                        cboDanToc.DataSource = dt;
                        cboDanToc.DisplayMember = "TenDanToc";
                        cboDanToc.ValueMember = "TenDanToc";
                        cboDanToc.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách dân tộc: " + ex.Message, 
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                // Thêm dữ liệu mẫu vào ComboBox
                cboDanToc.Items.Clear();
                cboDanToc.Items.Add("Kinh");
                cboDanToc.Items.Add("Tày");
                cboDanToc.Items.Add("Mông");
                cboDanToc.Items.Add("Mường");
            }
        }

        // Hiển thị lại danh sách sinh viên
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        // Thêm sinh viên
        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO SinhVien (MaSV, HoDem, Ten, NgaySinh, GioiTinh, MaLop, MaDiaChi, MaDanToc, GhiChu) " +
                             "VALUES (@MaSV, @HoDem, @Ten, @NgaySinh, @GioiTinh, @MaLop, NULL, @MaDanToc, @GhiChu)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text.Trim());
                cmd.Parameters.AddWithValue("@HoDem", txtHoDem.Text.Trim());
                cmd.Parameters.AddWithValue("@Ten", txtTen.Text.Trim());
                cmd.Parameters.AddWithValue("@NgaySinh", txtNgaySinh.Text.Trim());
                cmd.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.Text.Trim());
                cmd.Parameters.AddWithValue("@MaLop", txtLop.Text.Trim());
                cmd.Parameters.AddWithValue("@MaDanToc", cboDanToc.SelectedValue ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text.Trim());

                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm sinh viên thành công!");
                    ClearInput();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                conn.Close();
                LoadData();
            }
        }

        // Sửa sinh viên
        private void btnSua_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "UPDATE SinhVien SET HoDem=@HoDem, Ten=@Ten, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, MaLop=@MaLop, MaDanToc=@MaDanToc, GhiChu=@GhiChu WHERE MaSV=@MaSV";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text.Trim());
                cmd.Parameters.AddWithValue("@HoDem", txtHoDem.Text.Trim());
                cmd.Parameters.AddWithValue("@Ten", txtTen.Text.Trim());
                cmd.Parameters.AddWithValue("@NgaySinh", txtNgaySinh.Text.Trim());
                cmd.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.Text.Trim());
                cmd.Parameters.AddWithValue("@MaLop", txtLop.Text.Trim());
                cmd.Parameters.AddWithValue("@MaDanToc", cboDanToc.SelectedValue ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text.Trim());

                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật sinh viên thành công!");
                    ClearInput();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                conn.Close();
                LoadData();
            }
        }

        // Xóa sinh viên
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "DELETE FROM SinhVien WHERE MaSV=@MaSV";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text.Trim());

                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa sinh viên thành công!");
                    ClearInput();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                conn.Close();
                LoadData();
            }
        }

        // Lưu (thông báo)
        private void btnLuu_Click(object sender, EventArgs e)
        {
            ClearInput();
            MessageBox.Show("Dữ liệu đã được lưu!", "Thông báo");
        }

        // Hàm clear dữ liệu input
        private void ClearInput()
        {
            txtMaSV.Clear();
            txtHoDem.Clear();
            txtTen.Clear();
            txtNgaySinh.Clear();
            txtGioiTinh.Clear();
            txtLop.Clear();
            txtGhiChu.Clear();
            cboDanToc.SelectedIndex = -1;
            txtMaSV.Focus();
        }

        // Tìm kiếm theo mã, tên, họ đệm
        private void btnTimKiem1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"SELECT sv.MaSV, sv.HoDem, sv.Ten, sv.NgaySinh, sv.GioiTinh, sv.MaLop, 
                                     sv.MaDanToc, 
                                     CASE 
                                         WHEN dt.TenDanToc IS NOT NULL THEN dt.TenDanToc
                                         ELSE 'Chưa xác định' 
                                     END as TenDanToc, 
                                     sv.GhiChu
                              FROM SinhVien sv 
                              LEFT JOIN DanToc dt ON sv.MaDanToc = dt.MaDanToc
                              WHERE sv.MaSV LIKE @kw OR sv.Ten LIKE @kw OR sv.HoDem LIKE @kw";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@kw", "%" + txtTimKiem.Text.Trim() + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSinhVien.DataSource = dt;
                
                // Ẩn cột MaDanToc
                if (dgvSinhVien.Columns["MaDanToc"] != null)
                    dgvSinhVien.Columns["MaDanToc"].Visible = false;
            }
        }

        // Tìm kiếm theo khoa
        private void btnTimKiem2_Click(object sender, EventArgs e)
        {
            if (cboKhoa.SelectedItem == null) return;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"SELECT sv.MaSV, sv.HoDem, sv.Ten, sv.NgaySinh, sv.GioiTinh, sv.MaLop, 
                                     sv.MaDanToc, 
                                     CASE 
                                         WHEN dt.TenDanToc IS NOT NULL THEN dt.TenDanToc
                                         ELSE 'Chưa xác định' 
                                     END as TenDanToc, 
                                     sv.GhiChu
                              FROM SinhVien sv 
                              LEFT JOIN DanToc dt ON sv.MaDanToc = dt.MaDanToc
                              JOIN Lop l ON sv.MaLop=l.MaLop 
                              JOIN Nganh n ON l.MaNganh=n.MaNganh 
                              JOIN Khoa k ON n.MaKhoa=k.MaKhoa 
                              WHERE k.TenKhoa=@kw";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@kw", cboKhoa.SelectedItem.ToString());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSinhVien.DataSource = dt;
                
                // Ẩn cột MaDanToc
                if (dgvSinhVien.Columns["MaDanToc"] != null)
                    dgvSinhVien.Columns["MaDanToc"].Visible = false;
            }
        }

        // Hiển thị lại danh sách sinh viên
        private void btnXemDSSV_Click(object sender, EventArgs e) => LoadData();

        // Xem theo khoa
        private void btnXemTheoKhoa_Click(object sender, EventArgs e) => btnTimKiem2_Click(sender, e);

        // Xem điểm (mở form điểm)
        private void btnXemDiem_Click(object sender, EventArgs e) => new FormDiem().ShowDialog();

        // Xem điểm theo môn (mở form điểm)
        private void btnXemDiemTheoMon_Click(object sender, EventArgs e) => new FormDiem().ShowDialog();

        // Khi chọn dòng trên DataGridView, hiển thị lên các TextBox
        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvSinhVien.Rows[e.RowIndex].Cells["MaSV"].Value != null)
            {
                DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];
                txtMaSV.Text = row.Cells["MaSV"].Value?.ToString();
                txtHoDem.Text = row.Cells["HoDem"].Value?.ToString();
                txtTen.Text = row.Cells["Ten"].Value?.ToString();
                if (row.Cells["NgaySinh"].Value != null && row.Cells["NgaySinh"].Value != DBNull.Value)
                {
                    DateTime ngaySinh = (DateTime)row.Cells["NgaySinh"].Value;
                    txtNgaySinh.Text = ngaySinh.ToString("dd/MM/yyyy");
                }
                else
                {
                    txtNgaySinh.Text = "";
                }
                txtGioiTinh.Text = row.Cells["GioiTinh"].Value?.ToString();
                txtLop.Text = row.Cells["MaLop"].Value?.ToString();
                txtGhiChu.Text = row.Cells["GhiChu"].Value?.ToString();
                
                // Hiển thị dân tộc
                string maDanToc = row.Cells["MaDanToc"].Value?.ToString();
                if (!string.IsNullOrEmpty(maDanToc) && maDanToc != "0")
                {
                    try
                    {
                        // Thử set SelectedValue trước (nếu có MaDanToc)
                        cboDanToc.SelectedValue = maDanToc;
                        
                        // Nếu không thành công, tìm theo tên
                        if (cboDanToc.SelectedIndex == -1)
                        {
                            string tenDanToc = row.Cells["TenDanToc"].Value?.ToString();
                            if (!string.IsNullOrEmpty(tenDanToc) && tenDanToc != "Chưa xác định")
                            {
                                for (int i = 0; i < cboDanToc.Items.Count; i++)
                                {
                                    if (cboDanToc.Items[i].ToString() == tenDanToc)
                                    {
                                        cboDanToc.SelectedIndex = i;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    catch
                    {
                        // Nếu có lỗi, tìm theo tên
                        string tenDanToc = row.Cells["TenDanToc"].Value?.ToString();
                        if (!string.IsNullOrEmpty(tenDanToc) && tenDanToc != "Chưa xác định")
                        {
                            for (int i = 0; i < cboDanToc.Items.Count; i++)
                            {
                                if (cboDanToc.Items[i].ToString() == tenDanToc)
                                {
                                    cboDanToc.SelectedIndex = i;
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    cboDanToc.SelectedIndex = -1;
                }
            }
        }
    }
}
