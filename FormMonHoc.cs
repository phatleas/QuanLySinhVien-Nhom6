using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace QuanLySV1
{
    public partial class FormMonHoc : Form
    {
        string connectionString = @"Server=.\SQLEXPRESS;Database=QuanLySinhVien;Integrated Security=True;TrustServerCertificate=True;";

        public FormMonHoc()
        {
            InitializeComponent();
            dgvMonHoc.CellClick += dgvMonHoc_CellClick;
        }

        private void FormMonHoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // Load danh sách môn học
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM MonHoc";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMonHoc.DataSource = dt;
            }
        }

        // Thêm môn học
        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO MonHoc (MaMH, TenMH, SoTinChi, GhiChu) VALUES (@MaMH, @TenMH, @SoTinChi, @GhiChu)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaMH", txtMaMH.Text.Trim());
                cmd.Parameters.AddWithValue("@TenMH", txtTenMH.Text.Trim());
                cmd.Parameters.AddWithValue("@SoTinChi", int.TryParse(txtSoTinChi.Text.Trim(), out int stc) ? stc : 0);
                cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text.Trim());

                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm môn học thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                conn.Close();
                LoadData();
            }
        }

        // Sửa môn học
        private void btnSua_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "UPDATE MonHoc SET TenMH=@TenMH, SoTinChi=@SoTinChi, GhiChu=@GhiChu WHERE MaMH=@MaMH";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaMH", txtMaMH.Text.Trim());
                cmd.Parameters.AddWithValue("@TenMH", txtTenMH.Text.Trim());
                cmd.Parameters.AddWithValue("@SoTinChi", int.TryParse(txtSoTinChi.Text.Trim(), out int stc) ? stc : 0);
                cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text.Trim());

                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật môn học thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                conn.Close();
                LoadData();
            }
        }

        // Xóa môn học
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa môn học này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "DELETE FROM MonHoc WHERE MaMH=@MaMH";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaMH", txtMaMH.Text.Trim());

                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa môn học thành công!");
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

        // Hiển thị lại danh sách môn học
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        // Khi chọn dòng trên DataGridView, hiển thị lên các TextBox
        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvMonHoc.Rows[e.RowIndex].Cells["MaMH"].Value != null)
            {
                DataGridViewRow row = dgvMonHoc.Rows[e.RowIndex];
                txtMaMH.Text = row.Cells["MaMH"].Value?.ToString();
                txtTenMH.Text = row.Cells["TenMH"].Value?.ToString();
                txtSoTinChi.Text = row.Cells["SoTinChi"].Value?.ToString();
                txtGhiChu.Text = row.Cells["GhiChu"].Value?.ToString();
            }
        }
    }
}

