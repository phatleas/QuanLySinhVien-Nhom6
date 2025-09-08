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
        }

        // Load danh sách sinh viên
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM SinhVien";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSinhVien.DataSource = dt;
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
                             "VALUES (@MaSV, @HoDem, @Ten, @NgaySinh, @GioiTinh, @MaLop, NULL, NULL, @GhiChu)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text.Trim());
                cmd.Parameters.AddWithValue("@HoDem", txtHoDem.Text.Trim());
                cmd.Parameters.AddWithValue("@Ten", txtTen.Text.Trim());
                cmd.Parameters.AddWithValue("@NgaySinh", txtNgaySinh.Text.Trim());
                cmd.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.Text.Trim());
                cmd.Parameters.AddWithValue("@MaLop", txtLop.Text.Trim());
                cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text.Trim());

                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm sinh viên thành công!");
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
                string sql = "UPDATE SinhVien SET HoDem=@HoDem, Ten=@Ten, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, MaLop=@MaLop, GhiChu=@GhiChu WHERE MaSV=@MaSV";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text.Trim());
                cmd.Parameters.AddWithValue("@HoDem", txtHoDem.Text.Trim());
                cmd.Parameters.AddWithValue("@Ten", txtTen.Text.Trim());
                cmd.Parameters.AddWithValue("@NgaySinh", txtNgaySinh.Text.Trim());
                cmd.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.Text.Trim());
                cmd.Parameters.AddWithValue("@MaLop", txtLop.Text.Trim());
                cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text.Trim());

                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật sinh viên thành công!");
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
            MessageBox.Show("Dữ liệu đã được lưu!", "Thông báo");
        }

        // Tìm kiếm theo mã, tên, họ đệm
        private void btnTimKiem1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM SinhVien WHERE MaSV LIKE @kw OR Ten LIKE @kw OR HoDem LIKE @kw";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@kw", "%" + txtTimKiem.Text.Trim() + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSinhVien.DataSource = dt;
            }
        }

        // Tìm kiếm theo khoa
        private void btnTimKiem2_Click(object sender, EventArgs e)
        {
            if (cboKhoa.SelectedItem == null) return;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT sv.* FROM SinhVien sv JOIN Lop l ON sv.MaLop=l.MaLop JOIN Nganh n ON l.MaNganh=n.MaNganh JOIN Khoa k ON n.MaKhoa=k.MaKhoa WHERE k.TenKhoa=@kw";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@kw", cboKhoa.SelectedItem.ToString());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSinhVien.DataSource = dt;
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
                txtNgaySinh.Text = row.Cells["NgaySinh"].Value?.ToString();
                txtGioiTinh.Text = row.Cells["GioiTinh"].Value?.ToString();
                txtLop.Text = row.Cells["MaLop"].Value?.ToString();
                txtGhiChu.Text = row.Cells["GhiChu"].Value?.ToString();
            }
        }
    }
}
