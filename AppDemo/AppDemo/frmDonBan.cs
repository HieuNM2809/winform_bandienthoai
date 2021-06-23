using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Text.RegularExpressions;

namespace AppDemo
{
    public partial class frmDonBan : DevExpress.XtraEditors.XtraForm
    {
        private BUS_NhapHang _BUS_NhapHang = new BUS_NhapHang();
        private BUS_DanhSachSanPham _BUS_DanhSachSanPham = new BUS_DanhSachSanPham();
        private BUS_TaoNhanVien _BUS_TaoNhanVien = new BUS_TaoNhanVien();
        private BUS_DonBan _BUS_DonBan = new BUS_DonBan();
         private static String User = "";
        private static String Pass = "";
        public frmDonBan()
        {
            InitializeComponent();
        }
        public frmDonBan(String us, String pass) :this()
        {
            User = us;
            Pass = pass;
            // lay id cua LoginID
            int id_Login = _BUS_TaoNhanVien.LayID(User);
            // lay nv theo LoginID
            List<DTO_staff> lstSatff =  _BUS_NhapHang.TimNhanVienTheoID(id_Login);
             lblNhanVienTen.Text =  lstSatff[0].staName;
             lblNhanVienID.Text =  lstSatff[0].staID.ToString();
             lblPhone.Text =  lstSatff[0].staPhone;

        }
        private void frmDonBan_Load(object sender, EventArgs e)
        {
            dtgvDSSP.DataSource = _BUS_DanhSachSanPham.LayDanhSachSanPham();
            dtgvCli.AutoGenerateColumns = false;
            dtgvCli.DataSource = _BUS_DonBan.LayDanhSachKhachHang();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearch.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(cbbOption.Text == "ID")
            {
                // kiem tra xem có phai la so k 
                if(Regex.IsMatch(txtSearch.Text, @"^\d+$") ==false)
                {
                    txtSearch.Text = String.Empty;
                    MessageBox.Show("Bạn vui lòng nhập ID là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                dtgvDSSP.DataSource = _BUS_DanhSachSanPham.TimTheoID(txtSearch.Text);
            }
            else if (cbbOption.Text == "Năm phát hành")
            {
                if (Regex.IsMatch(txtSearch.Text, @"^\d+$") == false)
                {
                    txtSearch.Text = String.Empty;
                    MessageBox.Show("Bạn vui lòng nhập Năm là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    dtgvDSSP.DataSource = _BUS_DanhSachSanPham.TimTheoNamSX(txtSearch.Text);

            }
            else if (cbbOption.Text == "RAM")
            {
                if (Regex.IsMatch(txtSearch.Text, @"^\d+$") == false)
                {
                    txtSearch.Text = String.Empty;
                    MessageBox.Show("Bạn vui lòng nhập RAM là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    dtgvDSSP.DataSource = _BUS_DanhSachSanPham.TimTheoRam(txtSearch.Text);

            }
            else
            {
                dtgvDSSP.DataSource = _BUS_DanhSachSanPham.TimTheoTenGanDung(txtSearch.Text);
            }




        }

        private void btnSearchCli_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearchCli.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cbbOptionCli.Text == "ID")
            {
                // kiem tra xem có phai la so k 
                if (Regex.IsMatch(txtSearchCli.Text, @"^\d+$") == false)
                {
                    txtSearch.Text = String.Empty;
                    MessageBox.Show("Bạn vui lòng nhập ID là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else   dtgvCli.DataSource = _BUS_DonBan.TimKHTheoID(txtSearchCli.Text);
            }
            else if (cbbOptionCli.Text == "SDT")
            {
                if (Regex.IsMatch(txtSearchCli.Text, @"^\d+$") == false)
                {
                    txtSearch.Text = String.Empty;
                    MessageBox.Show("Bạn vui lòng nhập SDT là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else dtgvCli.DataSource = _BUS_DonBan.TimKHTheoSDTGanDung(txtSearchCli.Text);

            }
            else
            {
                dtgvCli.DataSource = _BUS_DonBan.TimKHTheoTenGanDung(txtSearchCli.Text);
            }

        }


        DateTime now = DateTime.Now;
        private void dtgvDSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDprod.Text = dtgvDSSP.SelectedCells[0].Value.ToString();
            txtTenDienThoai.Text = dtgvDSSP.SelectedCells[1].Value.ToString();
            txtGiaDienThoai.Text = dtgvDSSP.SelectedCells[2].Value.ToString();
            txtSoLuong.Text = "1";
        }

        private void dtgvCli_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDkHang.Text = dtgvCli.SelectedCells[0].Value.ToString();
            txtTenKH.Text = dtgvCli.SelectedCells[1].Value.ToString();
            txtDiaChiKH.Text = dtgvCli.SelectedCells[2].Value.ToString();
            txtSDTKH.Text = dtgvCli.SelectedCells[3].Value.ToString();
            txtMbdKH.Text = dtgvCli.SelectedCells[4].Value.ToString();

        }

        private void btnLLDSkhachHang_Click(object sender, EventArgs e)
        {
            dtgvCli.DataSource = _BUS_DonBan.LayDanhSachKhachHang();
        }
        private void btnLaylaiDanhSach_Click(object sender, EventArgs e)
        {
            dtgvDSSP.DataSource = _BUS_DanhSachSanPham.LayDanhSachSanPham();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtIDprod.Text = String.Empty;
            txtTenDienThoai.Text = String.Empty;
            txtGiaDienThoai.Text = String.Empty;
            txtSoLuong.Text = String.Empty;

            txtIDkHang.Text = String.Empty;
            txtTenKH.Text = String.Empty;
            txtDiaChiKH.Text = String.Empty;
            txtSDTKH.Text = String.Empty;
            txtMbdKH.Text = String.Empty;
        }
        DateTime now1 = DateTime.Now;
        private void btnThem_Click(object sender, EventArgs e)
        {
           
            if (String.IsNullOrEmpty(txtIDprod.Text) || String.IsNullOrEmpty(txtTenDienThoai.Text)
                || String.IsNullOrEmpty(txtGiaDienThoai.Text) || String.IsNullOrEmpty(txtSoLuong.Text) 
                || String.IsNullOrEmpty(txtIDkHang.Text) || String.IsNullOrEmpty(txtTenKH.Text) 
                || String.IsNullOrEmpty(txtSDTKH.Text)
                || String.IsNullOrEmpty(txtMbdKH.Text)
                )
            {
                MessageBox.Show(Constants.NHAP_THONG_TIN, Constants.THONG_BAO, MessageBoxButtons.OK , MessageBoxIcon.Warning);
                return;
            }


            // 0: nhap hang , 1: ban

            DTO_order _Order = new DTO_order();
            DateTime now = DateTime.Now;
            _Order.ordDate = now;
            _Order.ordDescription = txtAbout.Text;
            _Order.cliID = Convert.ToInt32(txtIDkHang.Text);
            _Order.staID = Convert.ToInt32(lblNhanVienID.Text);

            bool tamp = true;
            if (_BUS_DonBan.ThemOrderBan(_Order) == false)
            {
                MessageBox.Show(Constants.THEM_THAT_BAI, Constants.THONG_BAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tamp = false; return;
            }


            DTO_informationOrder _InformationOrder = new DTO_informationOrder();
            _InformationOrder.ordID = _BUS_TaoNhanVien.LayIDMax("ordID", "ORDERR");
            _InformationOrder.prodID = Convert.ToInt32(txtIDprod.Text);
            _InformationOrder.infoOrderSl = Convert.ToInt32(txtSoLuong.Text);

            Double gia = Math.Round(Convert.ToDouble(txtGiaDienThoai.Text),0);
            _InformationOrder.infoOrderPrice = (int)gia;

            if (_BUS_DonBan.ThemInfoOrderBan(_InformationOrder) == false)
            {
                MessageBox.Show("Thêm chi tiết đơn nhập thất bại", Constants.THONG_BAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tamp = false; return;
            }
            int id_pro = Convert.ToInt32(txtIDprod.Text);
            int sl_ban = Convert.ToInt32(txtSoLuong.Text);
            _BUS_DonBan.CapNhatSoLuong(id_pro, sl_ban);

            if (tamp == true)
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgvDSSP.DataSource = _BUS_DanhSachSanPham.LayDanhSachSanPham();
                DialogResult result = MessageBox.Show("Bạn có muốn in hóa đơn hay không", Constants.THONG_BAO, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    // String id = Convert.ToString(_BUS_TaoNhanVien.LayIDMax("prodID", "PRODUCT"));
                    int id_nhanvien = _BUS_TaoNhanVien.LayID(User);
                    List<DTO_staff> _lststaff = _BUS_NhapHang.TimNhanVienTheoID(id_nhanvien);

                    String ngay = now1.ToString();

                    Double gia1 = Math.Round(Convert.ToDouble(txtGiaDienThoai.Text), 0);
                    String thanhTien = (Convert.ToInt32(txtSoLuong.Text) * gia1).ToString();

                    frmBaoCao frmbc = new frmBaoCao();
                    frmbc.InPhieuBan(txtIDprod.Text, _lststaff[0].staName, ngay, _lststaff[0].staPhone, thanhTien, txtSoLuong.Text);
                    frmbc.ShowDialog();
                }


            }

        }
        private void btnThemDong_Click(object sender, EventArgs e)
        {
            btnThem_Click(sender, e);
            this.Close();
        }
    }
}