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
using BUS;
using DTO;

namespace AppDemo
{
    public partial class frmTaoNhanVien : DevExpress.XtraEditors.XtraForm
    {
        private BUS_TaoNhanVien _BUS_TaoNhanVien = new BUS_TaoNhanVien();
        private static String User = "";
        private static String Pass = "";
        String Message_Nhap_Day_Du = "Vui lòng nhập đẩy đủ thông tin";
        public frmTaoNhanVien()
        {
            InitializeComponent();
           // dtdvNhanVien.AutoGenerateColumns = false;
            dtdvNhanVien.DataSource = _BUS_TaoNhanVien.LayDanhSachNhanVien();
        }
        public frmTaoNhanVien(String MUser ,String MPass):this()
        {
            User = MUser; Pass = MPass;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtUser.Text) || String.IsNullOrEmpty(txtPass.Text) || String.IsNullOrEmpty(txtSodienthoai.Text) || String.IsNullOrEmpty(txtTen.Text) || String.IsNullOrEmpty(txtDiaChi.Text) || String.IsNullOrEmpty(txtAbout.Text) 
                )
            {
                MessageBox.Show(Message_Nhap_Day_Du, Constants.THONG_BAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
         

            DTO_staffLogin staffLogin = new DTO_staffLogin();
            staffLogin.LoginUserName = txtUser.Text;
            staffLogin.LoginPassword = txtPass.Text;

            if (_BUS_TaoNhanVien.ThemNhanVienLogin(staffLogin))
            {
                DTO_staff staff = new DTO_staff();
                staff.staName = txtTen.Text;
                staff.staBirthday = dtpkNgaySinh.Value;
                staff.staAddress = txtDiaChi.Text;
                staff.staImg = "";
                staff.staPhone = txtSodienthoai.Text;
                staff.staSex = (cbbGioiTinh.Text == "1") ? true : false;
                staff.staDescription = txtAbout.Text;
                staff.staStatus = 1;
                staff.staSalary = Convert.ToDecimal(mnrudLuong.Value);
                staff.staPosition = cbbViTri.Text;
                staff.LoginID = _BUS_TaoNhanVien.LayID(txtUser.Text);
                bool tam =  _BUS_TaoNhanVien.ThemNhanVien(staff);

                if (tam)
                {
                    MessageBox.Show(Constants.THEM_THANH_CONG, Constants.THONG_BAO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtdvNhanVien.DataSource = _BUS_TaoNhanVien.LayDanhSachNhanVien();
                }
               
            }
            else
            {
                MessageBox.Show(Constants.THEM_THAT_BAI, Constants.THONG_BAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnThemThoat_Click(object sender, EventArgs e)
        {
            btnThem_Click( sender,  e);
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTen.Text) || String.IsNullOrEmpty(txtDiaChi.Text) || String.IsNullOrEmpty(txtSodienthoai.Text)
                )
            {
                MessageBox.Show(Message_Nhap_Day_Du, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DTO_staff staff = new DTO_staff();
            staff.staID =Convert.ToInt32(txtStaffID.Text);
            staff.staName = txtTen.Text;
            staff.staBirthday = dtpkNgaySinh.Value;
            staff.staAddress = txtDiaChi.Text;
            staff.staImg = "";
            staff.staPhone = txtSodienthoai.Text;
            staff.staSex = (cbbGioiTinh.Text == "1") ? true : false;
            staff.staDescription = txtAbout.Text;
            staff.staStatus = 1;
            staff.staSalary = Convert.ToDecimal(mnrudLuong.Value);
            staff.staPosition = cbbViTri.Text;
            if (_BUS_TaoNhanVien.SuaNhanVien(staff))
            {
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtdvNhanVien.DataSource = _BUS_TaoNhanVien.LayDanhSachNhanVien();
            }
            else
            {
                MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTen.Text) || String.IsNullOrEmpty(txtDiaChi.Text)  || String.IsNullOrEmpty(txtSodienthoai.Text)
                )
            {
                MessageBox.Show(Message_Nhap_Day_Du, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = Convert.ToInt32(txtStaffID.Text);
            if (_BUS_TaoNhanVien.XoaNhanVien(id))
            {
               MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtdvNhanVien.DataSource = _BUS_TaoNhanVien.LayDanhSachNhanVien();
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTen.Text = String.Empty;
            cbbGioiTinh.Text = "Nam";
            txtDiaChi.Text = String.Empty;
            dtpkNgaySinh.Value = DateTime.Today.AddDays(-1);
            mnrudLuong.Value = 0;
            cbbViTri.Text = "Nhân Viên";
            cbbTrangThai.Enabled = false;
            txtAbout.Text = String.Empty;

        }
        private void dtdvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                cbbTrangThai.Enabled = true;
                txtTen.Text = dtdvNhanVien.SelectedCells[1].Value.ToString();
                dtpkNgaySinh.Value = Convert.ToDateTime(dtdvNhanVien.SelectedCells[2].Value.ToString());
                txtDiaChi.Text = dtdvNhanVien.SelectedCells[3].Value.ToString();
                txtSodienthoai.Text = dtdvNhanVien.SelectedCells[5].Value.ToString();
                string gt = dtdvNhanVien.SelectedCells[6].Value.ToString();
                if (gt == "True") { cbbGioiTinh.Text = "Nam"; } else { cbbGioiTinh.Text = "Nữ"; }
                //string tt = dtdvNhanVien.SelectedCells[7].Value.ToString();
                //if (tt == null) { txtAbout.Text = ""; } else { cbbGioiTinh.Text = tt; }
                mnrudLuong.Text = dtdvNhanVien.SelectedCells[9].Value.ToString();
                cbbViTri.Text = dtdvNhanVien.SelectedCells[10].Value.ToString();
                txtStaffID.Text = dtdvNhanVien.SelectedCells[0].Value.ToString();

            }
            catch (Exception)
            {
                return;
            }
        }
    }
}