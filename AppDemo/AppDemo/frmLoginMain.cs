using DTO;
using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AppDemo
{
    public partial class frmLoginMain : Form
    {
        private BUS_LoginMain _BUS_LoginMain = new BUS_LoginMain();
        public frmLoginMain()
        {
            InitializeComponent();
        }


        private void button_Login_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            if (String.IsNullOrEmpty(user) || String.IsNullOrEmpty(pass))
            {
                MessageBox.Show(Constants.NHAP_THONG_TIN, Constants.THONG_BAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (_BUS_LoginMain.kiemTraLogin(user, pass))
            {
                notifyIcon_Login.ShowBalloonTip(1000, Constants.THONG_BAO, "Đăng nhập thành công", ToolTipIcon.Info);
                frmNavigation x = new frmNavigation(txtUser.Text, txtPass.Text);
                x.Show();
                this.Visible = false;
            } 
            else
            {
                MessageBox.Show("Sai thông tin", Constants.THONG_BAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            if (String.IsNullOrEmpty(user) || String.IsNullOrEmpty(pass))
            {
                MessageBox.Show(Constants.NHAP_THONG_TIN , Constants.THONG_BAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (_BUS_LoginMain.kiemTraLogin(user, pass))
            {
                notifyIcon_Login.ShowBalloonTip(1000, "Notification", "Successful login", ToolTipIcon.Info);
                frmNavigation x = new frmNavigation(txtUser.Text, txtPass.Text);
                x.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Wrong", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // xử lí nhập 
        int tamp = 0;
        private void pictureBox_ShowHidePass_Click(object sender, EventArgs e)
        {
            if (tamp == 0){
                pbShowHidePass.Image = 
                    new Bitmap(Application.StartupPath + "\\Resources\\eye-slash-solid.png");
                tamp = 1;
                txtPass.UseSystemPasswordChar = true;
            }else{
                pbShowHidePass.Image = 
                    new Bitmap(Application.StartupPath + "\\Resources\\eye-solid.png");
                tamp = 0;
                txtPass.UseSystemPasswordChar = false;
            }
        }
        // chuyển ngôn ngữ 
        private void pictureBox_langVietman_Click(object sender, EventArgs e)
        {
            btnClose.Text = "Đóng";
            lbTitle.Text = "Đăng nhập";
            lbTitle.Location = new System.Drawing.Point(64, 11);
            btnLogin.Text = "Đăng nhập";
            lbForgetPass.Text = "Quên mật khẩu";
            lbInfoShop.Text = "Điều khoản";
        }
        private void pictureBox_langEnglish_Click(object sender, EventArgs e)
        {
            btnClose.Text = "Close";
            lbTitle.Text = "Login";
            btnLogin.Text = "Login";
            lbForgetPass.Text = "Forgot Password?";
            lbInfoShop.Text = "Rules Shop";
        }
        // đóng form 
        private void button_close_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }
        private void thoátToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }
       private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
       {
            //this.Close();
            Application.Exit();
        }
    }
}
