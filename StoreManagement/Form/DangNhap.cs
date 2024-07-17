using StoreManagement.DAO;
using System;
using System.Data;

using System.Windows.Forms;

namespace StoreManagement
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        private bool KiemTraDangNhap(string taiKhoan, string matKhau)
        {
            string query = "SELECT * FROM tblDangNhap WHERE TaiKhoan = @TaiKhoan AND MatKhau = @MatKhau";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { taiKhoan, matKhau });

            return result.Rows.Count > 0;
        }
        private void clear()
        {
            txtTaiKhoan.Text = string.Empty;
            txtMatKhau.Text = string.Empty;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tk = txtTaiKhoan.Text.Trim();
            string pass = txtMatKhau.Text.Trim();
            if(KiemTraDangNhap(tk, pass)) {
                MessageBox.Show("Đăng nhập thành công");
                Trangchu trangchu = new Trangchu();
                trangchu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Mật khẩu tài khoản không đúng!!!\r\nVui lòng đăng nhập lại !");
                clear();
                return;
            }

        }


    }
}
