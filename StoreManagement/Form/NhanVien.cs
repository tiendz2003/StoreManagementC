using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement
{
    public partial class NhanVien : Form
    {
        private static string constr = @"Data Source=RONALDO-FOREVER\SQLEXPRESS;Initial Catalog=QuanLySanPham;Integrated Security=True;";

        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM tblNhanVien";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dtgrvnhanvien.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi hiển thị nhân viên: " + ex);
                }
            }
        }

        private bool KiemTraMaNhanVien(int maNv)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM tblNhanVien WHERE MaNV = @MaNV";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MaNV", maNv);
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi kiểm tra mã nhân viên:" + ex.Message);
                    return false;
                }
            }
        }

        public void clear()
        {
            txtmanv.Text = "";
            txttennv.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";
            txtEmail.Text = "";
            dtngaysinh.Value = DateTime.Now;
            rbNam.Checked = false;
            rbNu.Checked = false;
        }

        private void XoaHang(int maNV)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_XoaNhanVien", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaNV", maNV);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy mã loại nhân viên hợp lệ.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message);
                }
            }
        }

        private void TimKiemNhanVien(object maNV, string tenNV)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_TimKiemNhanVien", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter paramMaNV = new SqlParameter("@MaNV", maNV);
                        SqlParameter paramTenNV = new SqlParameter("@TenNV", string.IsNullOrEmpty(tenNV) ? (object)DBNull.Value : (object)tenNV);
                        cmd.Parameters.Add(paramMaNV);
                        cmd.Parameters.Add(paramTenNV);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dtgrvnhanvien.DataSource = dt;

                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("Không tìm thấy nhân viên.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm kiếm nhân viên: " + ex.Message);
                }
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            int maNv = int.Parse(txtmanv.Text);
            string tenNv = txttennv.Text;
            string ngaySinh = dtngaysinh.Value.ToString("yyyy-MM-dd");
            string gioitinh = rbNam.Checked ? "Nam" : "Nữ";
            string diaChi = txtdiachi.Text;
            string sdt = txtsdt.Text;
            string Email = txtEmail.Text;
            if (KiemTraMaNhanVien(maNv))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!!!\r\nVui lòng chọn mã nhân viên khác");
                return;
            }
            string query = "INSERT INTO tblNhanVien (MaNV, TenNV, NgaySinh, gioiTinh, diaChi, SDT, Email) " +
                   "VALUES (@MaNV, @TenNV, @Ngaysinh, @Gioitinh, @Diachi, @Dienthoai, @Email)";

            using (SqlConnection conn = new SqlConnection(constr))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNV", maNv);
                        cmd.Parameters.AddWithValue("@TenNV", tenNv);
                        cmd.Parameters.AddWithValue("@Ngaysinh", ngaySinh);
                        cmd.Parameters.AddWithValue("@Gioitinh", gioitinh);
                        cmd.Parameters.AddWithValue("@Diachi", diaChi);
                        cmd.Parameters.AddWithValue("@Dienthoai", sdt);
                        cmd.Parameters.AddWithValue("@Email", Email);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm nhân viên thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Thêm nhân viên thất bại!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            loadData();
            clear();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            int manv = int.Parse(txtmanv.Text);
            string tennv = txttennv.Text;
            string ngaysinh = dtngaysinh.Value.ToString("yyyy-MM-dd");
            string gioitinh = rbNam.Checked ? "Nam" : "Nữ";
            string diachi = txtdiachi.Text;
            string sdt = txtsdt.Text;
            string email = txtEmail.Text;
            if (KiemTraMaNhanVien(manv))
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(constr))
                    {
                        con.Open();
                        string query = "UPDATE tblNhanVien SET TenNV = @TenNV, NgaySinh = @Ngaysinh, GioiTinh = @Gioitinh, diaChi = @Diachi, SDT = @Dienthoai, Email = @Email WHERE MaNV = @MaNV";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@MaNV", manv);
                            cmd.Parameters.AddWithValue("@TenNV", tennv);
                            cmd.Parameters.AddWithValue("@Ngaysinh", ngaysinh);
                            cmd.Parameters.AddWithValue("@Gioitinh", gioitinh);
                            cmd.Parameters.AddWithValue("@Diachi", diachi);
                            cmd.Parameters.AddWithValue("@Dienthoai", sdt);
                            cmd.Parameters.AddWithValue("@Email", email);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cập nhật thông tin nhân viên thành công!");
                                loadData(); // Tải lại dữ liệu để cập nhật DataGridView
                                clear(); // Xóa các trường nhập
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật thông tin nhân viên thất bại!");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật loại sản phẩm: " + ex.Message);
                }
            }
        }

        private void dtgrvnhanvien_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgrvnhanvien.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgrvnhanvien.SelectedRows[0];

                txtmanv.Text = selectedRow.Cells["MaNV"].Value.ToString();
                txttennv.Text = selectedRow.Cells["TenNV"].Value.ToString();
                dtngaysinh.Value = DateTime.Parse(selectedRow.Cells["NgaySinh"].Value.ToString());
                string gioitinh = selectedRow.Cells["GioiTinh"].Value.ToString();
                if (gioitinh == "Nam")
                {
                    rbNam.Checked = true;
                }
                else if (gioitinh == "Nữ")
                {
                    rbNu.Checked = true;
                }
                txtdiachi.Text = selectedRow.Cells["DiaChi"].Value.ToString();
                txtsdt.Text = selectedRow.Cells["SDT"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dtgrvnhanvien.SelectedRows.Count > 0)
            {
                if (dtgrvnhanvien.SelectedRows[0].Cells["MaNV"].Value != null)
                {
                    int maNV = int.Parse(dtgrvnhanvien.SelectedRows[0].Cells["MaNV"].Value.ToString());
                    if (MessageBox.Show($"Bạn có muốn xóa nhân viên có mã {maNV} này không?", "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        XoaHang(maNV);
                        loadData();
                        clear();
                    }
                }
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            object maNVParam = DBNull.Value;

            if (int.TryParse(txttimkiem.Text, out int maNV))
            {
                maNVParam = maNV;
            }

            string tenNV = txttimkiem.Text.Trim();

            TimKiemNhanVien(maNVParam, tenNV);
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txttimkiem.Text))
            {
                loadData();
            }
        }
    }
}
