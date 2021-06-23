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
    public partial class frmDanhSachNhanVien : DevExpress.XtraEditors.XtraForm
    {
        private BUS_TaoNhanVien _BUS_TaoNhanVien = new BUS_TaoNhanVien();
        private BUS_DanhSachNhanVien _BUS_DanhSachNhanVien = new BUS_DanhSachNhanVien();
        public frmDanhSachNhanVien()
        {
            InitializeComponent();
            dtdvNhanVien.AutoGenerateColumns = false;
            dtdvNhanVien.DataSource = _BUS_TaoNhanVien.LayDanhSachNhanVien();
        }

        public void Message()
        {
            MessageBox.Show(Constants.NHAP_THONG_TIN, Constants.THONG_BAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

            if(txtTimTheoTen.Enabled ==true && txtTimSdt.Enabled == true && txtTimID.Enabled ==true &&txtDiaChi.Enabled ==true && cbbTimViTri.Enabled ==true)
            {
                MessageBox.Show(Constants.NHAP_THONG_TIN_CAN_TIM, Constants.THONG_BAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtTimTheoTen.Enabled == true)
            {
                if (String.IsNullOrEmpty(txtTimTheoTen.Text)) { Message(); }else
                dtdvNhanVien.DataSource =_BUS_DanhSachNhanVien.TimNhanVienTheoTen(txtTimTheoTen.Text);
            }
            else if (txtTimID.Enabled == true)
            {
                if (String.IsNullOrEmpty(txtTimID.Text)) { Message(); }
                else
                {
                    if (Regex.IsMatch(txtTimID.Text, @"^\d+$") == false)
                    {
                        txtTimID.Text = String.Empty;
                        MessageBox.Show(Constants.NHAP_SO, Constants.THONG_BAO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int id = Convert.ToInt32(txtTimID.Text);
                        dtdvNhanVien.DataSource = _BUS_DanhSachNhanVien.TimNhanVienTheoID(id);
                    }
                }
            }
            else if (txtDiaChi.Enabled == true)
            {
                if (String.IsNullOrEmpty(txtDiaChi.Text)) { Message(); }
                else
                    dtdvNhanVien.DataSource = _BUS_DanhSachNhanVien.TimNhanVienTheoDiaCHi(txtDiaChi.Text);
            }
            else if (txtTimSdt.Enabled == true)
            {
                if (String.IsNullOrEmpty(txtTimSdt.Text)) { Message(); }
                else
                    if (Regex.IsMatch(txtTimSdt.Text, @"^\d+$") == false)
                    {
                        txtTimSdt.Text = String.Empty;
                        MessageBox.Show(Constants.NHAP_SO, Constants.THONG_BAO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    dtdvNhanVien.DataSource = _BUS_DanhSachNhanVien.TimNhanVienTheoSoDienThoai(txtTimSdt.Text);
            }
            else if (cbbTimViTri.Enabled == true)
            {
                dtdvNhanVien.DataSource = _BUS_DanhSachNhanVien.TimNhanVienTheoVitri(cbbTimViTri.Text);
            }
            else 
            {
                MessageBox.Show(Constants.TIM_THAT_BAI, Constants.THONG_BAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            txtTimTheoTen.Enabled = true;
            txtDiaChi.Enabled = true;
            txtTimID.Enabled = true;
            txtTimSdt.Enabled = true;
            cbbTimViTri.Enabled = true;

            txtTimTheoTen.Text = String.Empty;
            txtDiaChi.Text = String.Empty;
            txtTimID.Text = String.Empty;
            txtTimSdt.Text = String.Empty;
            cbbTimViTri.SelectedIndex =1 ;
        }
        private void txtTimTheoTen_Click(object sender, EventArgs e)
        {
            txtTimTheoTen.Enabled = true;
            txtDiaChi.Enabled = false;
            txtTimID.Enabled = false;
            txtTimSdt.Enabled = false;
            cbbTimViTri.Enabled = false;
        }
        private void txtTimID_Click(object sender, EventArgs e)
        {
            txtTimTheoTen.Enabled = false;
            txtDiaChi.Enabled = false;
            txtTimID.Enabled = true;
            txtTimSdt.Enabled = false;
            cbbTimViTri.Enabled = false;
        }
        private void txtDiaChi_Click(object sender, EventArgs e)
        {
            txtTimTheoTen.Enabled = false;
            txtDiaChi.Enabled = true;
            txtTimID.Enabled = false;
            txtTimSdt.Enabled = false;
            cbbTimViTri.Enabled = false;
        }
        private void txtTimSdt_Click(object sender, EventArgs e)
        {
            txtTimTheoTen.Enabled = false;
            txtDiaChi.Enabled = false;
            txtTimID.Enabled = false;
            txtTimSdt.Enabled = true;
            cbbTimViTri.Enabled = false;
        }
        private void cbbTimViTri_Click(object sender, EventArgs e)
        {
            txtTimTheoTen.Enabled = false;
            txtDiaChi.Enabled = false;
            txtTimID.Enabled = false;
            txtTimSdt.Enabled = false;
            cbbTimViTri.Enabled = true;
        }
        private void txtTimTheoTen_TextChanged(object sender, EventArgs e)
        {
            txtTimTheoTen.Enabled = true;
            txtDiaChi.Enabled = false;
            txtTimID.Enabled = false;
            txtTimSdt.Enabled = false;
            cbbTimViTri.Enabled = false;
        }
        private void txtTimID_TextChanged(object sender, EventArgs e)
        {
            txtTimTheoTen.Enabled = false;
            txtDiaChi.Enabled = false;
            txtTimID.Enabled = true;
            txtTimSdt.Enabled = false;
            cbbTimViTri.Enabled = false;
        }
        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            txtTimTheoTen.Enabled = false;
            txtDiaChi.Enabled = true;
            txtTimID.Enabled = false;
            txtTimSdt.Enabled = false;
            cbbTimViTri.Enabled = false;
        }
        private void txtTimSdt_TextChanged(object sender, EventArgs e)
        {
            txtTimTheoTen.Enabled = false;
            txtDiaChi.Enabled = false;
            txtTimID.Enabled = false;
            txtTimSdt.Enabled = true;
            cbbTimViTri.Enabled = false;
        }
        private void cbbTimViTri_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTimTheoTen.Enabled = false;
            txtDiaChi.Enabled = false;
            txtTimID.Enabled = false;
            txtTimSdt.Enabled = false;
            cbbTimViTri.Enabled = true;
        }

        private void btnLaylaiDanhSach_Click(object sender, EventArgs e)
        {
            dtdvNhanVien.DataSource = _BUS_TaoNhanVien.LayDanhSachNhanVien();
            txtTimTheoTen.Enabled = true;
            txtDiaChi.Enabled = true;
            txtTimID.Enabled = true;
            txtTimSdt.Enabled = true;
            cbbTimViTri.Enabled = true;

            txtTimTheoTen.Text = String.Empty;
            txtDiaChi.Text = String.Empty;
            txtTimID.Text = String.Empty;
            txtTimSdt.Text = String.Empty;
            cbbTimViTri.SelectedIndex = 1;
        }
    }
}