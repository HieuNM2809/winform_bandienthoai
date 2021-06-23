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
    public partial class frmDoiMatKhau : Form
    {
        public static String User ="";
        public static String Pass="";
        private BUS_DoiMatKhau _BUS_DoiMatKhau = new BUS_DoiMatKhau();
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        public frmDoiMatKhau(String MessageUser ,String MessagePass) : this()
        {
            User = MessageUser;
            Pass = MessagePass;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {   if(txtUser.Text == string.Empty || txtMkCu.Text == string.Empty|| txtMkMoi.Text == string.Empty)
            {
                MessageBox.Show(Constants.NHAP_THONG_TIN, Constants.THONG_BAO
               , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtMkMoi.Text == txtMkCu.Text)
            {
                MessageBox.Show("Mật khẩu mới của bạn đã trùng mới mật khẩu cũ", Constants.THONG_BAO
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtUser.Text != User)
            {
                MessageBox.Show("Sai Tên đăng nhập", Constants.THONG_BAO
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtMkCu.Text != Pass)
            {
                MessageBox.Show("Sai mật khẩu", Constants.THONG_BAO
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(_BUS_DoiMatKhau.LuuMatKhau(User,Pass,txtUserMoi.Text,txtMkMoi.Text))
            {
                MessageBox.Show("Đổi thành công", Constants.THONG_BAO
                     , MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên User đã được dùng rồi , Vui lòng chọn tên tài khoản mới", Constants.THONG_BAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
