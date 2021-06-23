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
    public partial class frmDanhSachNCC : DevExpress.XtraEditors.XtraForm
    {
        private BUS_DanhSachNCC _BUS_DanhSachNCC = new BUS_DanhSachNCC();
        public frmDanhSachNCC()
        {
            InitializeComponent();
            dtgvNCC.AutoGenerateColumns = false;
            dtgvNCC.DataSource = _BUS_DanhSachNCC.LayDsanhSachNCC();
        }
        public void Message()
        {
            MessageBox.Show(Constants.NHAP_THONG_TIN, Constants.THONG_BAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnLayLaiDS_Click(object sender, EventArgs e)
        {
            txtTimTheoTen.Enabled = true;
            txtDiaChi.Enabled = true;
            txtTimID.Enabled = true;
            txtTimSdt.Enabled = true;
            txtThanhPho.Enabled = true;
            dtgvNCC.DataSource = _BUS_DanhSachNCC.LayDsanhSachNCC();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTimTheoTen.Enabled == true && txtTimSdt.Enabled == true && txtTimID.Enabled == true && txtDiaChi.Enabled == true && txtThanhPho.Enabled == true)
            {
                MessageBox.Show(Constants.NHAP_THONG_TIN_CAN_TIM, Constants.THONG_BAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtTimTheoTen.Enabled == true)
            {
                if (String.IsNullOrEmpty(txtTimTheoTen.Text)) { Message(); }
                else
                    dtgvNCC.DataSource = _BUS_DanhSachNCC.TimNCCTheoTen(txtTimTheoTen.Text);
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
                        dtgvNCC.DataSource = _BUS_DanhSachNCC.TimNCCTheoID(id);
                    }
                }
            }
            else if (txtDiaChi.Enabled == true)
            {
                if (String.IsNullOrEmpty(txtDiaChi.Text)) { Message(); }
                else
                    dtgvNCC.DataSource = _BUS_DanhSachNCC.TimNCCTheoDiaCHi(txtDiaChi.Text);
            }
            else if (txtTimSdt.Enabled == true)
            {
                if (String.IsNullOrEmpty(txtTimSdt.Text)) { Message(); }
                else
                if (Regex.IsMatch(txtTimSdt.Text, @"^\d+$") == false)
                {
                    txtTimSdt.Text = String.Empty;
                    MessageBox.Show("Bạn vui lòng nhập ID là số", Constants.THONG_BAO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    dtgvNCC.DataSource = _BUS_DanhSachNCC.TimNCCTheoSoDienThoai(txtTimSdt.Text);
            }
            else if (txtThanhPho.Enabled == true)
            {
                dtgvNCC.DataSource = _BUS_DanhSachNCC.TimNCCTheoThanhPho(txtThanhPho.Text);
            }
            else
            {
                MessageBox.Show("Tìm kiếm thất bại", Constants.THONG_BAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            txtTimTheoTen.Text = String.Empty;
            txtDiaChi.Text = String.Empty;
            txtTimID.Text = String.Empty;
            txtTimSdt.Text = String.Empty;
            txtThanhPho.Text = String.Empty;

            txtTimTheoTen.Enabled = true;
            txtDiaChi.Enabled = true;
            txtTimID.Enabled = true;
            txtTimSdt.Enabled = true;
            txtThanhPho.Enabled = true;

        }

        private void txtTimTheoTen_TextChanged(object sender, EventArgs e)
        {
            txtTimTheoTen_Click(sender, e);
        }
        private void txtTimID_TextChanged(object sender, EventArgs e)
        {
            txtTimID_Click(sender, e);
        }
        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            txtDiaChi_Click(sender, e);
        }
        private void txtTimSdt_TextChanged(object sender, EventArgs e)
        {
            txtTimSdt_Click(sender, e);
        }
        private void txtThanhPho_TextChanged(object sender, EventArgs e)
        {
            txtThanhPho_Click(sender, e);
        }
        private void txtTimTheoTen_Click(object sender, EventArgs e)
        {
            txtTimTheoTen.Enabled = true;
            txtDiaChi.Enabled = false;
            txtTimID.Enabled = false;
            txtTimSdt.Enabled = false;
            txtThanhPho.Enabled = false;
        }
        private void txtTimID_Click(object sender, EventArgs e)
        {
            txtTimTheoTen.Enabled = false;
            txtDiaChi.Enabled = false;
            txtTimID.Enabled = true;
            txtTimSdt.Enabled = false;
            txtThanhPho.Enabled = false;
        }
        private void txtDiaChi_Click(object sender, EventArgs e)
        {
            txtTimTheoTen.Enabled = false;
            txtDiaChi.Enabled = true;
            txtTimID.Enabled = false;
            txtTimSdt.Enabled = false;
            txtThanhPho.Enabled = false;
        }
        private void txtTimSdt_Click(object sender, EventArgs e)
        {
            txtTimTheoTen.Enabled = false;
            txtDiaChi.Enabled = false;
            txtTimID.Enabled = false;
            txtTimSdt.Enabled = true;
            txtThanhPho.Enabled = false;
        }
        private void txtThanhPho_Click(object sender, EventArgs e)
        {
            txtTimTheoTen.Enabled = false;
            txtDiaChi.Enabled = false;
            txtTimID.Enabled = false;
            txtTimSdt.Enabled = false;
            txtThanhPho.Enabled = true;
        }

      
    }
}