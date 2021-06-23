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
    public partial class frmNavigation : DevExpress.XtraEditors.XtraForm
    {
        private static String User = "";
        private static String Pass = "";
        private BUS_Navigation _BUS_Navigation = new BUS_Navigation();
        public frmNavigation()
        {
            InitializeComponent();
        }
        public frmNavigation(string MessageUser ,String MessagePass) : this()
        {
            DTO_staff  staff =  _BUS_Navigation.LayTenVaViTri(MessageUser);
            lblTen.Text = staff.staName;
            labChucVu.Text = staff.staPosition;
            if(labChucVu.Text == "Nhân Viên")
            {
                aceNCC.Enabled = false; aceTaiKhoan.Enabled = false;
                aceTaoNhanVien.Enabled = false;
                aceDanhSachNhanVien.Enabled = false;
                aceThenNCC.Enabled = false;
                aceDanhSachNCC.Enabled = false;
            }

            //Gán lại vào user và pass để tiếp tục dùng 
            User = MessageUser; Pass = MessagePass;
        }









        //=====================================================
        // ===================== nhập hàng, bán hàng,dssp  ==================== 
        //=====================================================
        private void aveNhapHang_Click_1(object sender, EventArgs e)
        {
            frmNhapHang x = new frmNhapHang(User, Pass);
            x.MdiParent = this;
              x.Show();            x.MaximizeBox = false; 
        }
        private void aceBanHang_Click(object sender, EventArgs e)
        {
            frmDonBan x = new frmDonBan(User, Pass);
            x.MdiParent = this;
             x.Show();            x.MaximizeBox = false;

        }
        private void aceDanhSachSanPham_Click(object sender, EventArgs e)
        {
            frmDanhSachSanPham x = new frmDanhSachSanPham();
            x.MdiParent = this;
             x.Show();            x.MaximizeBox = false;
        }

        //=====================================================
        // ===================== Tạo nhân viên==================== 
        //=====================================================
        private void aceTaoNhanVien_Click(object sender, EventArgs e)
        {
            frmTaoNhanVien x = new frmTaoNhanVien(User,Pass);
            // x.ShowDialog();
            x.MdiParent = this;
             x.Show();            x.MaximizeBox = false;
        }
        private void aceDanhSachNhanVien_Click(object sender, EventArgs e)
        {
            frmDanhSachNhanVien x = new frmDanhSachNhanVien();
            x.MdiParent = this;
             x.Show();            x.MaximizeBox = false;
        }
        //=====================================================
        // ===================== Tạo ( nhập ), danh sách NCC ==================== 
        //=====================================================
        private void aceThenNCC_Click(object sender, EventArgs e)
        {
            frmThemNhaSanXuat x = new frmThemNhaSanXuat();
            x.MdiParent = this;
             x.Show();            x.MaximizeBox = false;
        }
        private void aceDanhSachNCC_Click(object sender, EventArgs e)
        {
            frmDanhSachNCC x = new frmDanhSachNCC();
            x.MdiParent = this;
             x.Show();            x.MaximizeBox = false;
        }
        //=====================================================
        // ===================== Tạo ( nhập ), danh sách NCC ==================== 
        //=====================================================
        private void aceBaoTri_Click(object sender, EventArgs e)
        {
            frmBaoTri x = new frmBaoTri();
            x.MdiParent = this;
             x.Show();            x.MaximizeBox = false;
        }
        //=====================================================
        // ===================== Thong ke ==================== 
        //=====================================================
        private void aceThongKe_Click(object sender, EventArgs e)
        {
            frmThongKe x = new frmThongKe();
            x.MdiParent = this;
             x.Show();            x.MaximizeBox = false;
        }
        //=====================================================
        // ===================== LogOut    ==================== 
        //=====================================================
        private void aceLogout_Click_1(object sender, EventArgs e)
        {
            frmLoginMain x = new frmLoginMain();
            this.Visible = false;
            x.Show();        
        }
       

        //=====================================================
        // ===================== thoat form==================== 
        //=====================================================
        private void aceThoat_Click(object sender, EventArgs e)
        {
            //this.Close();
           Application.Exit();
          
        }
        private void aceThongTin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Verion 1.0.0  Design by HM", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //=====================================================
        // ===================== Đổi mật khẩu ==================== 
        //=====================================================
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau x = new frmDoiMatKhau(User,Pass);
            x.MdiParent = this;
             x.Show();            x.MaximizeBox = false;
        }

        private void aceKhanhHang_Click(object sender, EventArgs e)
        {
            frmKhachHang x = new frmKhachHang();
            x.MdiParent = this;
             x.Show();            x.MaximizeBox = false;
        }

        private void frmNavigation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
            if (e.KeyCode == Keys.F1)
            {
                frmNhapHang x = new frmNhapHang(User, Pass);
                x.MdiParent = this;
                x.Show(); x.MaximizeBox = false;
            }
            if (e.KeyCode == Keys.F2)
            {
                frmDonBan x = new frmDonBan(User, Pass);
                x.MdiParent = this;
                x.Show(); x.MaximizeBox = false;
            }
            if (e.KeyCode == Keys.F3)
            {
                frmDanhSachSanPham x = new frmDanhSachSanPham();
                x.MdiParent = this;
                x.Show(); x.MaximizeBox = false;
            }
            if (e.KeyCode == Keys.F4)
            {
                frmTaoNhanVien x = new frmTaoNhanVien(User, Pass);
                // x.ShowDialog();
                x.MdiParent = this;
                x.Show(); x.MaximizeBox = false;
            }
            if (e.KeyCode == Keys.F5)
            {
                frmDanhSachNhanVien x = new frmDanhSachNhanVien();
                x.MdiParent = this;
                x.Show(); x.MaximizeBox = false;
            }
            if (e.KeyCode == Keys.F6)
            {
                frmThemNhaSanXuat x = new frmThemNhaSanXuat();
                x.MdiParent = this;
                x.Show(); x.MaximizeBox = false;
            }
            if (e.KeyCode == Keys.F7)
            {
                frmDanhSachNCC x = new frmDanhSachNCC();
                x.MdiParent = this;
                x.Show(); x.MaximizeBox = false;
            }
            if (e.KeyCode == Keys.F8)
            {
                frmKhachHang x = new frmKhachHang();
                x.MdiParent = this;
                x.Show(); x.MaximizeBox = false;
            }
            if (e.KeyCode == Keys.F9)
            {
                frmThongKe x = new frmThongKe();
                x.MdiParent = this;
                x.Show(); x.MaximizeBox = false;
            }
            if (e.KeyCode == Keys.F10)
            {
                frmBaoTri x = new frmBaoTri();
                x.MdiParent = this;
                x.Show(); x.MaximizeBox = false;
            }
            if (e.KeyCode == Keys.F11)
            {
                frmLoginMain x = new frmLoginMain();
                this.Visible = false;
                x.Show();
            }
            if (e.KeyCode == Keys.F12)
            {
                MessageBox.Show("Verion 1.0.0 Design by HM", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void aceTaiKhoan_Click(object sender, EventArgs e)
        {

        }
    }
}