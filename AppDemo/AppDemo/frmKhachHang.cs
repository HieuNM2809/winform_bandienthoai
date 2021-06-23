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
    public partial class frmKhachHang : Form
    {
        private BUS_KhachHang _BUS_KhachHang = new BUS_KhachHang();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtTenKH.Text) ||
               String.IsNullOrEmpty(txtSDTKH.Text)
                )
            {
                MessageBox.Show(Constants.NHAP_THONG_TIN, Constants.THONG_BAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DTO_client _Client = new DTO_client();
            _Client.cliName = txtTenKH.Text;
            _Client.cliAddress = txtDiaChiKH.Text;
            _Client.cliCountry = txtThanhPhoKH.Text;
            _Client.cliPostOfficeCode = txtMbdKH.Text;
            _Client.cliPhone = txtSDTKH.Text;
            if (_BUS_KhachHang.ThemKhachHang(_Client))
            {
                MessageBox.Show(Constants.THEM_THANH_CONG, Constants.THONG_BAO, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Constants.THEM_THAT_BAI, Constants.THONG_BAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

      
    }
}
