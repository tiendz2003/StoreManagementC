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
    public partial class Trangchu : Form
    {
        public Trangchu()
        {
            InitializeComponent();
        }
        private void Clear_panel()
        {
            main.Controls.Clear();
        }

        private void btnhang_Click(object sender, EventArgs e)

        {
            Clear_panel();
            Hang hang = new Hang(){ Dock = DockStyle.Fill,
            TopLevel = false,TopMost = true};
            main.Controls.Add(hang);
            hang.Show();
        }

        private void btnloai_Click(object sender, EventArgs e)
        {
            Clear_panel();
            LoaiHang loaiHang = new LoaiHang(){Dock = DockStyle.Fill,TopLevel = false,TopMost = true };
            main.Controls.Add(loaiHang);
            loaiHang.Show();
        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            Clear_panel();
            NhanVien nv = new NhanVien()
            {
                Dock = DockStyle.Fill, TopLevel = false, TopMost = true
            };
            main.Controls.Add(nv);
            nv.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnnhacc_Click(object sender, EventArgs e)
        {
            Clear_panel();
            NhaCungCap ncc = new NhaCungCap()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            main.Controls.Add(ncc);
            ncc.Show();
        }

        private void btnphieunhap_Click(object sender, EventArgs e)
        {
            Clear_panel();
                NhapHang nh = new NhapHang()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            main.Controls.Add(nh);
            nh.Show();
        }

        private void btnphieuxuat_Click(object sender, EventArgs e)
        {
            Clear_panel();
            XuatHang xh = new XuatHang()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            main.Controls.Add(xh);
            xh.Show();
        }

        private void btQuanLy_Click(object sender, EventArgs e)
        {
            Clear_panel();
            DangKy dk = new DangKy()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            main.Controls.Add(dk);
            dk.Show();
        }
        private void btnhangton_Click(object sender, EventArgs e)
        {
            Clear_panel();
            ThongKeHangTon tk = new ThongKeHangTon()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            main.Controls.Add(tk);
            tk.Show();
        }
        private void btDangXuat_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Show();
            this.Close();
        }

    
    }
}
