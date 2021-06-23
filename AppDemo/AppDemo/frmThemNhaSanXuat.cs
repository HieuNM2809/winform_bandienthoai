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
namespace AppDemo
{
    public partial class frmThemNhaSanXuat : DevExpress.XtraEditors.XtraForm
    {
        private BUS_ThemNhaSanXuat _BUS_ThemNhaSanXuat = new BUS_ThemNhaSanXuat();
        private BUS_DanhSachNCC _BUS_DanhSachNCC = new BUS_DanhSachNCC();
        String MESSAGE_NDD = "Hãy nhập đẩy đủ thông tin";
        public frmThemNhaSanXuat()
        {
            InitializeComponent();
            dtgvNCCNhap.AutoGenerateColumns = false;
           dtgvNCCNhap.DataSource = _BUS_DanhSachNCC.LayDsanhSachNCC();
        }
        private void sbtnSave_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtTen.Text) || String.IsNullOrEmpty(txtDiaChi.Text) || 
                String.IsNullOrEmpty(txtMaBuuDien.Text)||String.IsNullOrEmpty(txtThanhPho.Text) || String.IsNullOrEmpty(txtSoDienThoai.Text))
            {
                MessageBox.Show(MESSAGE_NDD, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
             DTO_provided _DTO_provided = new DTO_provided();
            _DTO_provided.provFullName = txtTenDayDuNCC.Text;
            _DTO_provided.provName = txtTen.Text;
            _DTO_provided.provAddress = txtDiaChi.Text;
            _DTO_provided.provPostOfficeCode = txtMaBuuDien.Text;
            _DTO_provided.provCountry = txtThanhPho.Text;
            _DTO_provided.provPhone = txtSoDienThoai.Text;
            _DTO_provided.provDescription = txtAbout.Text;
            _DTO_provided.provStatus = 1;
            if (_BUS_ThemNhaSanXuat.ThemNCC(_DTO_provided))
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgvNCCNhap.DataSource = _BUS_DanhSachNCC.LayDsanhSachNCC();
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void sbtnEdit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTen.Text) || String.IsNullOrEmpty(txtDiaChi.Text) ||
              String.IsNullOrEmpty(txtMaBuuDien.Text) || String.IsNullOrEmpty(txtThanhPho.Text) || String.IsNullOrEmpty(txtSoDienThoai.Text))
            {
                MessageBox.Show(MESSAGE_NDD, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DTO_provided _DTO_provided = new DTO_provided();
            _DTO_provided.provID = Convert.ToInt32(txtID.Text);
            _DTO_provided.provFullName = txtTenDayDuNCC.Text;
            _DTO_provided.provName = txtTen.Text;
            _DTO_provided.provAddress = txtDiaChi.Text;
            _DTO_provided.provPostOfficeCode = txtMaBuuDien.Text;
            _DTO_provided.provCountry = txtThanhPho.Text;
            _DTO_provided.provPhone = txtSoDienThoai.Text;
            _DTO_provided.provDescription = txtAbout.Text;
            _DTO_provided.provStatus = (txtTrangThai.Text == "Hợp tác") ? 1 : 0;



            if (_BUS_ThemNhaSanXuat.SuaNCC(_DTO_provided))
            {
                MessageBox.Show("Sủa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgvNCCNhap.DataSource = _BUS_DanhSachNCC.LayDsanhSachNCC();
            }
            else
            {
                MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void sbtnDelete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTen.Text) || String.IsNullOrEmpty(txtDiaChi.Text) ||
            String.IsNullOrEmpty(txtMaBuuDien.Text) || String.IsNullOrEmpty(txtThanhPho.Text) || String.IsNullOrEmpty(txtSoDienThoai.Text))
            {
                MessageBox.Show(MESSAGE_NDD, Constants.THONG_BAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = Convert.ToInt32(txtID.Text);
            if (_BUS_ThemNhaSanXuat.XoaNCC(id))
            {
                MessageBox.Show("Xóa thành công", Constants.THONG_BAO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgvNCCNhap.DataSource = _BUS_DanhSachNCC.LayDsanhSachNCC();
            }
            else
            {
                MessageBox.Show("Xóa thất bại", Constants.THONG_BAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtgvNCCNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtID.Text = dtgvNCCNhap.SelectedCells[0].Value.ToString();
                // txtTenDayDuNCC.Text= dtgvNCCNhap.SelectedCells[4].Value.ToString();

                txtTen.Text = dtgvNCCNhap.SelectedCells[2].Value.ToString();
                txtDiaChi.Text = dtgvNCCNhap.SelectedCells[3].Value.ToString();
                txtMaBuuDien.Text = dtgvNCCNhap.SelectedCells[4].Value.ToString();
                txtThanhPho.Text = dtgvNCCNhap.SelectedCells[5].Value.ToString();
                txtSoDienThoai.Text = dtgvNCCNhap.SelectedCells[6].Value.ToString();
                //txtAbout.Text = dtgvNCCNhap.SelectedCells[7].Value.ToString();
            }
            catch (Exception)
            {
                return;
            }

        }
        private void sbtnReset_Click(object sender, EventArgs e)
        {
            txtID.Text = String.Empty;
            txtTenDayDuNCC.Text= String.Empty;
            txtTen.Text = String.Empty;
            txtDiaChi.Text = String.Empty;
            txtMaBuuDien.Text = String.Empty;
            txtThanhPho.Text = String.Empty;
            txtSoDienThoai.Text = String.Empty;
            txtAbout.Text = String.Empty;
        }

        private void sbtnSaveAndClose_Click(object sender, EventArgs e)
        {
            sbtnSave_Click( sender,  e);
            this.Close();
        }
    }
}