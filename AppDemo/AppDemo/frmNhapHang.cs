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
namespace AppDemo
{
    public partial class frmNhapHang : Form
    {
        private BUS_DanhSachSanPham _BUS_DanhSachSanPham = new BUS_DanhSachSanPham();
        private BUS_NhapHang _BUS_NhapHang = new BUS_NhapHang();
        private BUS_TaoNhanVien _BUS_TaoNhanVien = new BUS_TaoNhanVien();
        private static String User = "";
        private static String Pass = "";
        public frmNhapHang()
        {
            InitializeComponent();
            dtgvDSSP.DataSource = _BUS_DanhSachSanPham.LayDanhSachSanPham();
            cbbNhaCungCap.DataSource = _BUS_DanhSachSanPham.LayDanhSachNCC();
            cbbNhaCungCap.DisplayMember = "provName";
            cbbNhaCungCap.ValueMember = "provID";
        }
        public frmNhapHang(string MessageUser, String MessagePass) : this()
        {
            //Gán lại vào user và pass để tiếp tục dùng 
            User = MessageUser; Pass = MessagePass;
        }

        private void sbtnDelete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtID.Text)){
                MessageBox.Show("Hãy chọn sản phẩm muốn xóa","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            int id_int = Convert.ToInt32(txtID.Text);
            if (_BUS_NhapHang.XoaSanPham(id_int))
            {
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgvDSSP.DataSource = _BUS_DanhSachSanPham.LayDanhSachSanPham();
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void sbtnEdit_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtID.Text) || String.IsNullOrEmpty(txtTenDienThoai.Text) || String.IsNullOrEmpty(txtGiaDienThoai.Text) 
                || String.IsNullOrEmpty(txtSoLuong.Text) || String.IsNullOrEmpty(txtCamera.Text) || String.IsNullOrEmpty(txtBoNho.Text) )
            {
                MessageBox.Show("Hãy nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DTO_product _Product = new DTO_product();
            _Product.prodID = Convert.ToInt32(txtID.Text);
            _Product.prodName = txtTenDienThoai.Text;
            _Product.prodPrice =Convert.ToDecimal(txtGiaDienThoai.Text);
            _Product.prodSL = Convert.ToInt32(txtSoLuong.Text);
            _Product.prodCamera = txtCamera.Text;
            _Product.prodMenory = Convert.ToInt32(txtBoNho.Text);
            _Product.prodReleaseYear = Convert.ToInt32(txtNamPhatHanh.Text);
            _Product.prodRAM = Convert.ToInt32(cbbRAM.Text);
            _Product.prodDescription = txtAbout.Text;
            _Product.provID = Convert.ToInt32(cbbNhaCungCap.SelectedValue.ToString());
            int i = 0;
            if (cbbDanhMuc.Text == "Điện thoại Phím") { i = 1; } else if (cbbDanhMuc.Text == "Điện thoại Cảm ứng") { i = 2; } else i = 3;
            _Product.catID = i;

            if (_BUS_NhapHang.SuaSanPham(_Product) )
            {
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgvDSSP.DataSource = _BUS_DanhSachSanPham.LayDanhSachSanPham();
            }
            else
            {
                MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void sbtnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtID.Text) || String.IsNullOrEmpty(txtTenDienThoai.Text) || String.IsNullOrEmpty(txtGiaDienThoai.Text)
                || String.IsNullOrEmpty(txtSoLuong.Text) || String.IsNullOrEmpty(txtCamera.Text) || String.IsNullOrEmpty(txtBoNho.Text))
            {
                MessageBox.Show(Constants.NHAP_THONG_TIN, Constants.THONG_BAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DTO_product _Product = new DTO_product();
            _Product.prodName = txtTenDienThoai.Text;
            _Product.prodPrice = Convert.ToDecimal(txtGiaDienThoai.Text);
            _Product.prodSL = Convert.ToInt32(txtSoLuong.Text);
            _Product.prodCamera = txtCamera.Text;
            _Product.prodMenory = Convert.ToInt32(txtBoNho.Text);
            _Product.prodReleaseYear = Convert.ToInt32(txtNamPhatHanh.Text);
            _Product.prodRAM = Convert.ToInt32(cbbRAM.Text);
            _Product.prodDescription = txtAbout.Text;
            _Product.provID = Convert.ToInt32(cbbNhaCungCap.SelectedValue.ToString());
            int i = 0;
            if (cbbDanhMuc.Text == "Điện thoại Phím") { i = 1; } else if (cbbDanhMuc.Text == "Điện thoại Cảm ứng") { i = 2; } else i = 3;
            _Product.catID = i;

            bool tamp = true;
            if (_BUS_NhapHang.ThemSanPham(_Product) == false)
            {
                MessageBox.Show("Thêm sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tamp = false; return;
            }

            DTO_order _Order = new DTO_order();
            DateTime now = DateTime.Now;
            _Order.ordDate = now;
            _Order.ordDescription = txtAbout.Text;
            _Order.staID = _BUS_TaoNhanVien.LayID(User);

            if (_BUS_NhapHang.ThemOrder(_Order) == false)
            {
                MessageBox.Show(Constants.THEM_THAT_BAI, Constants.THONG_BAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tamp = false; return;
            }


            DTO_informationOrder _InformationOrder = new DTO_informationOrder();
            _InformationOrder.ordID = _BUS_TaoNhanVien.LayIDMax("ordID", "ORDERR");
            _InformationOrder.prodID = _BUS_TaoNhanVien.LayIDMax("prodID", "PRODUCT");
            _InformationOrder.infoOrderSl = Convert.ToInt32(txtSoLuong.Text);

            Double gia = Math.Round(Convert.ToDouble(txtGiaDienThoai.Text), 0);
            _InformationOrder.infoOrderPrice = (int)gia;

            if (_BUS_NhapHang.ThemInfoOrder(_InformationOrder) == false)
            {
                MessageBox.Show("Thêm chi tiết đơn nhập thất bại", Constants.THONG_BAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tamp = false; return;
            }
            if (tamp == true)
            {
                MessageBox.Show(Constants.THEM_THANH_CONG, Constants.THONG_BAO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgvDSSP.DataSource = _BUS_DanhSachSanPham.LayDanhSachSanPham();
               DialogResult result=  MessageBox.Show("Bạn có muốn in hóa đơn hay không", Constants.THONG_BAO, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    String id = Convert.ToString(_BUS_TaoNhanVien.LayIDMax("prodID", "PRODUCT"));
                    int id_nhanvien = _BUS_TaoNhanVien.LayID(User);
                    List<DTO_staff> _lststaff = _BUS_NhapHang.TimNhanVienTheoID(id_nhanvien);

                    String ngay = now.ToString();

                    Double gia1 = Math.Round(Convert.ToDouble(txtGiaDienThoai.Text), 0);
                    String thanhTien = (Convert.ToInt32(txtSoLuong.Text) * gia1).ToString();

                    frmBaoCao frmbc = new frmBaoCao();
                    frmbc.InPhieuNhap(id, _lststaff[0].staName, ngay, _lststaff[0].staPhone, thanhTien);
                    frmbc.ShowDialog();
                }


            }
        }
        private void sbtnReset_Click(object sender, EventArgs e)
        {
            txtID.Text = String.Empty;
            txtTenDienThoai.Text = String.Empty;
            txtGiaDienThoai.Text = String.Empty;
            txtSoLuong.Text = String.Empty;
            txtCamera.Text = String.Empty;
            txtBoNho.Text = String.Empty;
            txtNamPhatHanh.Text = String.Empty;
            cbbRAM.Text = String.Empty;
            //txtMauSac.Text = dtgvDSSP.SelectedCells[9].Value.ToString();
            //txtTrangThai.Text = String.Empty;
            cbbNhaCungCap.SelectedIndex = 0;
            cbbDanhMuc.SelectedIndex    = 0;
        }
        private void dtgvDSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dtgvDSSP.SelectedCells[0].Value.ToString();
            txtTenDienThoai.Text = dtgvDSSP.SelectedCells[1].Value.ToString();
            txtGiaDienThoai.Text = dtgvDSSP.SelectedCells[2].Value.ToString();
            txtSoLuong.Text = dtgvDSSP.SelectedCells[3].Value.ToString();

            txtCamera.Text = dtgvDSSP.SelectedCells[5].Value.ToString();
            txtBoNho.Text = dtgvDSSP.SelectedCells[6].Value.ToString();
            txtNamPhatHanh.Text = dtgvDSSP.SelectedCells[7].Value.ToString();
            cbbRAM.Text = dtgvDSSP.SelectedCells[8].Value.ToString();
            //txtMauSac.Text = dtgvDSSP.SelectedCells[9].Value.ToString();
            //txtTrangThai.Text = dtgvDSSP.SelectedCells[10].Value.ToString();

             int index =Convert.ToInt32(dtgvDSSP.SelectedCells[11].FormattedValue.ToString());
            cbbNhaCungCap.SelectedIndex = (index-1);
             String index2 = dtgvDSSP.SelectedCells[12].FormattedValue.ToString();
            if(index2 == "1") { cbbDanhMuc.SelectedIndex = 0; } else if (index2 == "2") { cbbDanhMuc.SelectedIndex = 1; } else cbbDanhMuc.SelectedIndex = 2;
        }

        private void sbtnSaveAndClose_Click(object sender, EventArgs e)
        {
            sbtnSave_Click( sender,  e);
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            String ngay = now.ToString();

            frmBaoCao frmbc = new frmBaoCao();
            frmbc.InDSPhieuNhap("0799501324", ngay);
            frmbc.ShowDialog();
        }

        private void btnInLai_Click(object sender, EventArgs e)
        {
            String id = Convert.ToString(_BUS_TaoNhanVien.LayIDMax("prodID", "PRODUCT"));
            int id_nhanvien =_BUS_TaoNhanVien.LayID(User);
            List<DTO_staff> _lststaff = _BUS_NhapHang.TimNhanVienTheoID(id_nhanvien);
            DateTime now = DateTime.Now;
            String ngay = now.ToString();
            //String thanhTien = (Convert.ToInt32(txtSoLuong.Text) * Convert.ToInt32(txtGiaDienThoai.Text)).ToString();

            frmBaoCao frmbc = new frmBaoCao();
            frmbc.InPhieuNhap(id, _lststaff[0].staName, ngay, _lststaff[0].staPhone, ".");
            frmbc.ShowDialog();

        }
    }
}
