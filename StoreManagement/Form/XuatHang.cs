using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace StoreManagement
{
    public partial class XuatHang : Form
    {
        private static string constr = @"Data Source=RONALDO-FOREVER\SQLEXPRESS;Initial Catalog=QuanLySanPham;Integrated Security=True;";

        public XuatHang()
        {
            InitializeComponent();
        }

        private void XuatHang_Load(object sender, EventArgs e)
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
                    using (SqlCommand cmd = new SqlCommand("sp_HienThongTinPhieuXuat", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dtgrvxuat.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi hiển thị phiếu nhập: " + ex.Message);
                }
            }
        }
        private bool KiemTraMaPhieuXuat(int maPx)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM tblPhieuXuat WHERE MaPX = @MaPX";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MaPX", maPx);
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi kiểm tra mã phiếu xuất: " + ex.Message);
                    return false;
                }
            }
        }
        private void XoaHang(object maPx)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_XoaPhieuXuat", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaPX", maPx);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa thành công.");
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa phiếu xuất" + ex.Message);
                }
            }
        }

        private void TimKiemPhieuXuat(object maPx)
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_TimKiemPhieuXuat", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaPX", maPx);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dtgrvxuat.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm kiếm phiếu xuất: " + ex.Message);
                }
            }
        }
        public void clear()
        {
            txtmaxuat.Text = "";
            dtngayxuat.Value = DateTime.Now;
            txtNv.Text = "";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmaxuat.Text) || string.IsNullOrEmpty(txtNv.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin phiếu nhập.");
                return;
            }

            int maPX;
            if (!int.TryParse(txtmaxuat.Text, out maPX))
            {
                MessageBox.Show("Mã phiếu xuất không hợp lệ.");
                return;
            }

            if (KiemTraMaPhieuXuat(maPX))
            {
                MessageBox.Show("Mã phiếu xuất đã tồn tại. Vui lòng chọn mã khác.");
                return;
            }

            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_ThemPhieuXuat", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaPX", maPX);
                        cmd.Parameters.AddWithValue("@NgayXuat", dtngayxuat.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@MaNV", int.Parse(txtNv.Text));

                        cmd.ExecuteNonQuery();
                    }
                    loadData();
                    clear();
                    MessageBox.Show("Thêm phiếu xuất thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm phiếu xuất: " + ex.Message);
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            int maPx = int.Parse(txtmaxuat.Text);
            string ngayXuat = dtngayxuat.Value.ToString("yyyy-MM-dd");
            int maNv = int.Parse(txtNv.Text);

            if (KiemTraMaPhieuXuat(maPx))
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(constr))
                    {
                        con.Open();
                        string query = "UPDATE tblPhieuXuat SET NgayXuat = @NgayXuat,MaNV = @MaNV WHERE MaPX = @MaPX"; 

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@MaPX", maPx);
                            cmd.Parameters.AddWithValue("@NgayXuat", ngayXuat);
                            cmd.Parameters.AddWithValue("@MaNV", maNv);


                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cập nhật thông tin phiếu xuất thành công!");
                                loadData(); // Tải lại dữ liệu để cập nhật DataGridView
                                clear(); // Xóa các trường nhập
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật thông tin phiếu xuất thất bại!");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật phiếu xuất: " + ex.Message);
                }
            }

        }

        private void dtgrvxuat_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgrvxuat.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgrvxuat.SelectedRows[0];
                txtmaxuat.Text = selectedRow.Cells["MaPX"].Value.ToString();
                dtngayxuat.Value = DateTime.Parse(selectedRow.Cells["NgayXuat"].Value.ToString());
                txtNv.Text = selectedRow.Cells["MaNV"].Value.ToString();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dtgrvxuat.SelectedRows.Count > 0)
            {
                if (dtgrvxuat.SelectedRows[0].Cells["MaNV"].Value != null)
                {
                    int maPx = int.Parse(dtgrvxuat.SelectedRows[0].Cells["MaPX"].Value.ToString());
                    if (MessageBox.Show($"Bạn có muốn xóa nhân viên có mã {maPx} này không?", "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        XoaHang(maPx);
                        loadData();
                        clear();
                    }
                }
            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            object maNVParam = DBNull.Value;

            if (int.TryParse(txttimkiem.Text, out int maPx))
            {
                maNVParam = maPx;
            }

            string tenNV = txttimkiem.Text.Trim();


            // Gọi thủ tục tìm kiếm và cập nhật DataGridView
            TimKiemPhieuXuat(maPx);
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txttimkiem.Text)) { loadData(); }

        }

        private void btnchitiet_Click(object sender, EventArgs e)
        {
            ChiTietPhieuXuat chiTietPhieuXuat = new ChiTietPhieuXuat();
            chiTietPhieuXuat.ShowDialog();
        }
    }
}
