using StoreManagement.DAO;
using System;
using System.Data;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using StoreManagement.Crystal_Report;

namespace StoreManagement
{
    public partial class ChiTietPhieuNhap : Form
    {
        public ChiTietPhieuNhap()
        {
            InitializeComponent();
        }

        private void ChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
            loadData();
            showCBmaHang();
            showCBmaNv();
            showCBmaPn();
            showCBmaSize();
        }
        public bool kiemTraMaCTPN(string mactpn)
        {

            string query = "select * from tblChiTietPhieuNhap where MaCTPN = ('" + mactpn + "')";
            DataTable ketQua = DataProvider.Instance.ExecuteQuery(query);
            return ketQua.Rows.Count > 0;
        }

        public void clear()
        {
            txtmact.Text = "";
            txtsl.Text = "";
            txtdongia.Text = "";
        }
        public void loadData()
        {
            string query = "select * from tblChiTietPhieuNhap ";
            dtgrvctpn.DataSource = DataProvider.Instance.ExecuteQuery(query);

        }
        public void showCBmaPn()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(@"select * from tblPhieuNhap");
            cbmapn.DataSource = data;
            cbmapn.DisplayMember = "MaPN";
            cbmapn.ValueMember = "MaPN";
        }
        public void showCBmaHang()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(@"select * from tblHang");
            cbmahang.DataSource = data;
            cbmahang.DisplayMember = "MaHang";
            cbmahang.ValueMember = "MaHang";
        }
        public void showCBmaNv()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(@"select * from tblNhanVien");
            cbmanv.DataSource = data;
            cbmanv.DisplayMember = "TenNV";
            cbmanv.ValueMember = "MaNV";
        }
        public void showCBmaSize()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(@"select * from tblSize");
            cbSize.DataSource = data;
            cbSize.DisplayMember = "TenSize";
            cbSize.ValueMember = "LoaiSize";
        }
     
        private void dtgrvctpn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0)
            {
                txtmact.Text = dtgrvctpn.Rows[idx].Cells["MaCTPN"].Value.ToString();
                cbmapn.Text = dtgrvctpn.Rows[idx].Cells["MaPN"].Value.ToString();
                cbmahang.Text = dtgrvctpn.Rows[idx].Cells["MaHang"].Value.ToString();
                cbmanv.SelectedValue = dtgrvctpn.Rows[idx].Cells["MaNV"].Value.ToString();
                cbSize.SelectedValue = dtgrvctpn.Rows[idx].Cells["MaSize"].Value.ToString();
                txtsl.Text = dtgrvctpn.Rows[idx].Cells["SoLuongNhap"].Value.ToString();
                txtdongia.Text = dtgrvctpn.Rows[idx].Cells["DonGiaNhap"].Value.ToString();
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string maCtpn = txtmact.Text;
            string maPn = cbmapn.Text;
            string maHang = cbmahang.Text;
            string maNv = cbmanv.Text;
            string maSize = cbSize.Text;
            string sl = txtsl.Text;
            string donGia = txtdongia.Text;
            if (kiemTraMaCTPN(maCtpn) == true || maCtpn == "")
            {
                MessageBox.Show("Mã trùng hoặc lỗi!!!");
                return;
            }
            else
            {
                string query = "INSERT INTO tblChiTietPhieuNhap (MaCTPN,MaPN,MaHang,MaNV,MaSize,SoLuongNhap,DonGiaNhap)VALUES" +
                    " ('" + maCtpn + "','" + maPn + "','" + maHang + "','" + maNv + "', '" + Size + "','" + sl + "','" + donGia + "') ";
                dtgrvctpn.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            loadData();
            clear();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string mactpn = txtmact.Text;
            string mapn = cbmapn.SelectedValue.ToString();
            string mahang = cbmahang.SelectedValue.ToString();
            string manv = cbmanv.Text;
            string size = cbSize.SelectedValue.ToString();
            string soluong = txtsl.Text;
            string dongia = txtdongia.Text;

            if (kiemTraMaCTPN(mactpn) == true)
            {
                string query = " UPDATE tblChiTietPhieuNhap " +
                    "SET MaPN = N'" + mapn + "', MaHang = N'" + mahang + "',MaNV = '" + manv + "',MaSize = N'" + size + "',SoLuongNhap = N'" + soluong + "',DonGiaNhap = N'" + dongia +
                    "' Where MaCTPN = '" + mactpn + "' ";
                dtgrvctpn.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            else
            {
                MessageBox.Show("Mã hàng không tồn tại!!!");
            }
            loadData();
            clear();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            string mactpn = txtmact.Text;
            string mapn = cbmapn.SelectedValue.ToString();
            string mahang = cbmahang.SelectedValue.ToString();
            string manv = cbmanv.Text;
            string size = cbSize.SelectedValue.ToString();
            string soluong = txtsl.Text;
            string dongia = txtdongia.Text;

            if (kiemTraMaCTPN(mactpn) == false)
            {
                MessageBox.Show("Mã không tồn tại");
            }
            else
            {
                string query = " DELETE  FROM tblChiTietPhieuNhap WHERE MaCTPN = '" + mactpn + "' ";
                if (MessageBox.Show($"Bạn có muốn xóa mặt hàng có mã {mactpn} này không?", "Xác nhận xóa"
                      , MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dtgrvctpn.DataSource = DataProvider.Instance.ExecuteQuery(query);
                    loadData();
                    clear();
                }
            }
        }
        private void dtgrvctpn_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgrvctpn.SelectedRows.Count > 0)
            {
                DataGridViewRow idx = dtgrvctpn.SelectedRows[0];
                txtmact.Text = idx.Cells["MaCTPN"].Value.ToString();
                cbmapn.Text = idx.Cells["MaPN"].Value.ToString();
                cbmahang.Text = idx.Cells["MaHang"].Value.ToString();
                cbmanv.Text = idx.Cells["MaNV"].Value.ToString();
                cbSize.Text = idx.Cells["MaSize"].Value.ToString();
                txtsl.Text = idx.Cells["SoLuongNhap"].Value.ToString();
                txtdongia.Text = idx.Cells["DonGiaNhap"].Value.ToString();
            }
        }



        private void btntim_Click(object sender, EventArgs e)
        {
            string timkiem = txttimkiem.Text;
            string query = "select * from tblChiTietPhieuNhap WHERE MaPN like '%" + timkiem + "%'";
            dtgrvctpn.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txttimkiem.Text))
            {
                loadData();
            }
        }

        private void taoForm(string maCTPN)
        {
            frmBaoCaoNhapHang frmBaoCaoNhapHang = new frmBaoCaoNhapHang();
            ReportDocument reportDocument = new ReportDocument();
            reportDocument.Load(@"C:\\Users\\DELL\\source\\repos\\StoreManagement\\StoreManagement\\Crystal Report\\rptBaoCaoPhieuNhap.rpt");

            // Thiết lập giá trị tham số cho báo cáo
            reportDocument.SetParameterValue("@MaCTPN", maCTPN);

            // Thiết lập nguồn dữ liệu cho Crystal Report Viewer
            frmBaoCaoNhapHang.crystalReportViewer.ReportSource = reportDocument;
            frmBaoCaoNhapHang.crystalReportViewer.Refresh();

            // Hiển thị form báo cáo
            frmBaoCaoNhapHang.ShowDialog();
        }

        private void btXuat_Click(object sender, EventArgs e)
        {
            string maCTPN = txtmact.Text.Trim();
            if (!string.IsNullOrEmpty(maCTPN))
            {
                taoForm(maCTPN);
            }
            else
            {
                MessageBox.Show("Mã phiếu nhập không hợp lệ.");
            }
        }

        
    }

}



