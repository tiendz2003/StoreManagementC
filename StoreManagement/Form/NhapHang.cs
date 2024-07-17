using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace StoreManagement
{
    public partial class NhapHang : Form
    {
        private static string constr = @"Data Source=RONALDO-FOREVER\SQLEXPRESS;Initial Catalog=QuanLySanPham;Integrated Security=True;";

        public NhapHang()
        {
            InitializeComponent();
        }

        private void NhapHang_Load(object sender, EventArgs e)
        {
            loadData();
            loadCbNcc();
            loadCbNV();
        }

        private void loadData()
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_HienThongTinPhieuNhap", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dtgrvnhap.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi hiển thị phiếu nhập: " + ex.Message);
                }
            }
        }


        private bool KiemTraMaPhieuNhap(int maPn)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM tblPhieuNhap WHERE MaPN = @MaPN";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MaPN", maPn);
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi kiểm tra mã phiếu nhập: " + ex.Message);
                    return false;
                }
            }
        }
        private void TimKiemPhieuNhap(object maPN)
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_TimKiemPhieuNhap", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaPN", maPN);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dtgrvnhap.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm kiếm phiếu nhập: " + ex.Message);
                }
            }
        }
      
        public void clear()
        {
            txtmapn.Text = "";
            cbncc.SelectedIndex = -1;
            cbNhanVien.SelectedIndex = -1;
            dtngaynhap.Value = DateTime.Now;
        }

        private void loadCbNcc()
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM tblNhaCC";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            if (dt.Rows.Count > 0)
                            {
                                cbncc.DataSource = dt;
                                cbncc.DisplayMember = "TenNCC";
                                cbncc.ValueMember = "MaNhaCC";
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Lỗi khi tải nhà cung cấp: " + e.Message);
                }
            }
        }

        private void loadCbNV()
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM tblNhanVien";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            if (dt.Rows.Count > 0)
                            {
                                cbNhanVien.DataSource = dt;
                                cbNhanVien.DisplayMember = "TenNV";
                                cbNhanVien.ValueMember = "MaNV";
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Lỗi khi tải nhân viên: " + e.Message);
                }
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmapn.Text) || cbncc.SelectedIndex == -1 || cbNhanVien.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin phiếu nhập.");
                return;
            }

            int maPN;
            if (!int.TryParse(txtmapn.Text, out maPN))
            {
                MessageBox.Show("Mã phiếu nhập không hợp lệ.");
                return;
            }

            if (KiemTraMaPhieuNhap(maPN))
            {
                MessageBox.Show("Mã phiếu nhập đã tồn tại. Vui lòng chọn mã khác.");
                return;
            }

            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_ThemPhieuNhap", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaPN", maPN);
                        cmd.Parameters.AddWithValue("@MaNhaCC", cbncc.SelectedValue);
                        cmd.Parameters.AddWithValue("@NgayNhap", dtngaynhap.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@MaNV", cbNhanVien.SelectedValue);

                        cmd.ExecuteNonQuery();
                    }
                    loadData();
                    clear();
                    MessageBox.Show("Thêm phiếu nhập thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm phiếu nhập: " + ex.Message);
                }
            }
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            int maPn = int.Parse(txtmapn.Text); 
            string ncc = cbncc.SelectedValue?.ToString();
            string ngayNhap = dtngaynhap.Value.ToString("yyyy-MM-dd");
            string maNv = cbNhanVien.SelectedValue?.ToString();

            if (KiemTraMaPhieuNhap(maPn))
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(constr))
                    {
                        con.Open();
                        string query = " UPDATE tblPhieuNhap SET MaNhaCC = @MaNhaCC, " +
                            "NgayNhap = @NgayNhap, MaNV = @MaNV WHERE MaPN = @MaPN";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@MaPN", maPn);
                            cmd.Parameters.AddWithValue("@MaNhaCC", ncc);
                            cmd.Parameters.AddWithValue("@NgayNhap", ngayNhap);
                            cmd.Parameters.AddWithValue("@MaNV", maNv);
                            

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cập nhật thông tin phiếu nhập thành công!");
                                loadData(); // Tải lại dữ liệu để cập nhật DataGridView
                                clear(); // Xóa các trường nhập
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật thông tin phiếu nhập thất bại!");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật phiếu nhập: " + ex.Message);
                }
            }

        }
        private void dtgrvnhap_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgrvnhap.SelectedRows.Count > 0)
            {
             DataGridViewRow selectedRow = dtgrvnhap.SelectedRows[0];
            txtmapn.Text = selectedRow.Cells["MaPN"].Value.ToString();
            cbncc.Text = selectedRow.Cells["TenNCC"].Value.ToString();
            dtngaynhap.Value = DateTime.Parse(selectedRow.Cells["NgayNhap"].Value.ToString());
            cbNhanVien.Text = selectedRow.Cells["TenNV"].Value.ToString();
            }

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dtgrvnhap.SelectedRows.Count > 0)
            {
                if (dtgrvnhap.SelectedRows[0].Cells["MaNV"].Value != null)
                {
                    int maPn = int.Parse(dtgrvnhap.SelectedRows[0].Cells["MaPN"].Value.ToString());
                    if (MessageBox.Show($"Bạn có muốn xóa nhân viên có mã {maPn} này không?", "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        XoaHang(maPn);
                        loadData();
                        clear();
                    }
                }
            }
        }

        private void XoaHang(object maPn)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_XoaPhieuNhap", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaPN", maPn);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa thành công.");
                        }
                      
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa phiếu nhập" + ex.Message);
                }
            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            object maNVParam = DBNull.Value;

            if (int.TryParse(txttimkiem.Text, out int maPn))
            {
                maNVParam = maPn;
            }

            string tenNV = txttimkiem.Text.Trim();


            // Gọi thủ tục tìm kiếm và cập nhật DataGridView
            TimKiemPhieuNhap(maPn);
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txttimkiem.Text))
            {
                loadData();
            }
        }

        private void btnchitiet_Click(object sender, EventArgs e)
        {
            ChiTietPhieuNhap chiTietPhieuNhap = new ChiTietPhieuNhap();
            chiTietPhieuNhap.ShowDialog();
        }
    }
}
