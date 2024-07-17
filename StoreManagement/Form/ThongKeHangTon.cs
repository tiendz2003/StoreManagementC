using StoreManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement
{
    public partial class ThongKeHangTon : Form
    {
        public ThongKeHangTon()
        {
            InitializeComponent();
        }

        public void load()
        {
            string query = "SELECT h.MaHang, h.TenHang, h.MaLoai, h.SoLuong, l.TenLoai\r\nFROM tblHang h\r\nINNER JOIN tblLoaiSanPham l ON h.MaLoai = l.MaLoai;\r\n ";//vi su dung split cat theo khoang trang suy ra viet phaii cach dau phay,


            dtgrvthongke.DataSource = DataProvider.Instance.ExecuteQuery(query);//thuc hien cau truy van voi tham so @tenhang, su dung new ojcect de lay 2 doi tuong Xoai vaff Nho
            dtgrvthongke.Columns[0].HeaderText = "Mã Hàng";
            dtgrvthongke.Columns[0].Width = 50;
            dtgrvthongke.Columns[1].HeaderText = "Tên Hàng";
            dtgrvthongke.Columns[1].Width = 200;
            dtgrvthongke.Columns[2].HeaderText = "Loại Hàng";
            dtgrvthongke.Columns[2].Width = 50;
            dtgrvthongke.Columns[3].HeaderText = "Hàng tồn";
            dtgrvthongke.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string timkiem = txttimkiem.Text;
            string query = "SELECT h.MaHang, h.TenHang, h.MaLoai, h.SoLuong, l.TenLoai\r\nFROM tblHang h\r\nINNER JOIN tblLoaiSanPham l ON h.MaLoai = l.MaLoai WHERE TenHang like '%" + timkiem + "%'";
            dtgrvthongke.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

       
    }
}
