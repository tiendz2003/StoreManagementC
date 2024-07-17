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

namespace StoreManagement
{
    public partial class LoaiHang : Form
    {
        private static string constr = @"Data Source=RONALDO-FOREVER\SQLEXPRESS;Initial Catalog=QuanLySanPham;Integrated Security=True;";

        public LoaiHang()
        {
            InitializeComponent();
        }
        private void LoaiHang_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            using (SqlConnection conn = new SqlConnection(constr)) {
                try
                {
                    conn.Open();
                    using(SqlCommand cmd = new SqlCommand("sp_HienThiTatCaLoaiHang",conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using(SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dtgrvloaihang.DataSource = dt;
                        }
                    }
                }catch (Exception ex) {
                    MessageBox.Show("Lỗi" + ex.ToString());
                }
            }
        }
        private bool KiemTraMaLoaiHang(string maLoaiHang)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM tblLoaiSanPham WHERE MaLoai = @MaLoaiHang";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MaLoaiHang", maLoaiHang);
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi kiểm tra mã loại hàng:" + ex.Message);
                    return false;
                }
            }
        }
        private void XoaHang(string maLoaiHang)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_XoaLoaiSanPham", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaLoai", maLoaiHang);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy mã loại hàng hợp lệ.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa loại mặt hàng: " + ex.Message);
                }
            }
        }
        private void dtgrvloaihang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string maLoai = txtmaloai.Text;
            string tenLoai = txttenloai.Text;
            if (KiemTraMaLoaiHang(txtmaloai.Text))
            {
                MessageBox.Show("Mã loại sản phẩm đã tồn tại!!!\r\nVui lòng chọn mã loại sản phẩm khác");
                return;
            }
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_ThemLoaiHang",con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaLoai", maLoai);
                        cmd.Parameters.AddWithValue("@TenLoai", tenLoai);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm loại hàng thành công!");
                            loadData(); // Gọi lại phương thức load dữ liệu để cập nhật DataGridView
                            clear();
                        }
                        else
                        {
                            MessageBox.Show("Thêm loại hàng thất bại!");
                        }
                    }
                }catch (Exception ex) {
                    MessageBox.Show("Lỗi:" + ex);
                }
            }
        }

        private void clear()
        {
            txtmaloai.Text = " ";
            txttenloai.Text = " ";
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string maLoaiHang = txtmaloai.Text;
            string tenLoaiHang = txttenloai.Text;
       

            if (KiemTraMaLoaiHang(maLoaiHang))
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(constr))
                    {
                        con.Open();
                        string query = "UPDATE tblLoaiSanPham " +
                                       "SET TenLoai = @TenLoai WHERE MaLoai = @MaLoai";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@MaLoai", maLoaiHang);
                            cmd.Parameters.AddWithValue("@TenLoai", tenLoaiHang);
                           

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cập nhật loại sản phẩm thành công.");
                                loadData();
                                clear();
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy loại sản phẩm có mã hàng này.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật loại sản phẩm: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Mã loại hàng không tồn tại.");
            }
        }

        private void dtgrvloaihang_SelectionChanged(object sender, EventArgs e)
        {

            if (dtgrvloaihang.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgrvloaihang.SelectedRows[0];

                txtmaloai.Text = selectedRow.Cells["MaLoai"].Value.ToString();
                txttenloai.Text = selectedRow.Cells["TenLoai"].Value.ToString();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dtgrvloaihang.SelectedRows.Count > 0)
            {
                if (dtgrvloaihang.SelectedRows[0].Cells["MaLoai"].Value != null)
                {
                    string maLoaiHang = dtgrvloaihang.SelectedRows[0].Cells["MaLoai"].Value.ToString();
                    if (MessageBox.Show($"Bạn có muốn xóa mặt hàng có mã {maLoaiHang} này không?", "Xác nhận xóa"
                        , MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        XoaHang(maLoaiHang);
                        loadData();
                        clear();
                    }
                }
            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            string tenHang = txttimkiem.Text.Trim();
           

            using (SqlConnection conn = new SqlConnection(constr))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_TimKiemLoaiHang", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                       
                        cmd.Parameters.AddWithValue("@TenLoai", string.IsNullOrEmpty(tenHang) ? (object)DBNull.Value : tenHang);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dtgrvloaihang.DataSource = dt;

                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("Không tìm thấy loại sản phẩm nào phù hợp.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm kiếm loại mặt hàng: " + ex.Message);
                }
            }
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
