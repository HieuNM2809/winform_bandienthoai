using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
    public partial class frmDanhSachSanPham : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private BUS_DanhSachSanPham _BUS_DanhSachSanPham = new BUS_DanhSachSanPham();
        public frmDanhSachSanPham()
        {
            InitializeComponent();
            dtgvDSSP.AutoGenerateColumns = false;
            dtgvDSSP.DataSource = _BUS_DanhSachSanPham.LayDanhSachSanPham();

            //cbb nha sx 
            txtNhaSanXuat.DataSource = _BUS_DanhSachSanPham.LayDanhSachNCC();
            txtNhaSanXuat.DisplayMember = "provName";
            txtNhaSanXuat.ValueMember = "provID";
        }


        public void Message()
        {
            MessageBox.Show(Constants.NHAP_THONG_TIN, Constants.THONG_BAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtTen.Enabled == true && txtID.Enabled == true && txtGiaTu.Enabled == true && txtGiaDen.Enabled == true && txtNamSanXuat.Enabled == true && txtNhaSanXuat.Enabled == true && cbbLoai.Enabled == true)
            {
                MessageBox.Show(Constants.NHAP_THONG_TIN_CAN_TIM, Constants.THONG_BAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtTen.Enabled == true)
            {
                if (String.IsNullOrEmpty(txtTen.Text)) { Message(); }
                else
                    dtgvDSSP.DataSource = _BUS_DanhSachSanPham.TimTheoTen(txtTen.Text);
            }
            else if (cbbLoai.Enabled == true)
            {
                dtgvDSSP.DataSource = _BUS_DanhSachSanPham.TimTheoLoai(cbbLoai.Text);
            }
            else if (txtID.Enabled == true)
            {
                if (String.IsNullOrEmpty(txtID.Text)) { Message(); }
                else
                if (Regex.IsMatch(txtID.Text, @"^\d+$") == false)
                {
                    txtID.Text = String.Empty;
                    MessageBox.Show(Constants.NHAP_SO, Constants.THONG_BAO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               else  dtgvDSSP.DataSource = _BUS_DanhSachSanPham.TimTheoID(txtID.Text);
            }
            else if (txtGiaTu.Enabled == true && txtGiaDen.Enabled == true)
            {
                if (String.IsNullOrEmpty(txtGiaTu.Text) || String.IsNullOrEmpty(txtGiaDen.Text)) { Message(); }
                else
                    dtgvDSSP.DataSource = _BUS_DanhSachSanPham.TimTheoGia(txtGiaTu.Text,txtGiaDen.Text);
            }
            else if (txtNamSanXuat.Enabled == true)
            {
                if (Regex.IsMatch(txtNamSanXuat.Text, @"^\d+$") == false)
                {
                    txtNamSanXuat.Text = String.Empty;
                    MessageBox.Show(Constants.NHAP_SO, Constants.THONG_BAO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else dtgvDSSP.DataSource = _BUS_DanhSachSanPham.TimTheoNamSX(txtNamSanXuat.Text);
            }
            else if (txtNhaSanXuat.Enabled == true)
            {
                int x = Convert.ToInt32(txtNhaSanXuat.SelectedValue);
                dtgvDSSP.DataSource = _BUS_DanhSachSanPham.TimTheoNhaSX(x);
            }
            else
            {
                MessageBox.Show(Constants.TIM_THAT_BAI, Constants.THONG_BAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            txtTen.Enabled = true;
            cbbLoai.Enabled = true;
            txtID.Enabled = true;
            txtGiaTu.Enabled = true;
            txtGiaDen.Enabled = true;
            txtNhaSanXuat.Enabled = true;
            txtNamSanXuat.Enabled = true;

            txtTen.Text = String.Empty;
           // cbbLoai.Text = String.Empty;
            txtID.Text = String.Empty;
            txtGiaTu.Text = String.Empty;
            txtGiaDen.Text = String.Empty;
            txtNhaSanXuat.Text = String.Empty;
            txtNamSanXuat.Text = String.Empty;

        } 
    

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            txtTen.Enabled = true;
            cbbLoai.Enabled = false;
            txtID.Enabled = false;
            txtGiaTu.Enabled = false;
            txtGiaDen.Enabled = false;
            txtNhaSanXuat.Enabled = false;
            txtNamSanXuat.Enabled = false;

        }
        private void cbbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTen.Enabled = false;
            cbbLoai.Enabled = true;
            txtID.Enabled = false;
            txtGiaTu.Enabled = false;
            txtGiaDen.Enabled = false;
            txtNhaSanXuat.Enabled = false;
            txtNamSanXuat.Enabled = false;
        }
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            txtTen.Enabled = false;
            cbbLoai.Enabled = false;
            txtID.Enabled = true;
            txtGiaTu.Enabled = false;
            txtGiaDen.Enabled = false;
            txtNhaSanXuat.Enabled = false;
            txtNamSanXuat.Enabled = false;
        }
        private void txtGiaTu_TextChanged(object sender, EventArgs e)
        {
            txtTen.Enabled = false;
            cbbLoai.Enabled = false;
            txtID.Enabled = false;
            txtGiaTu.Enabled = true;
            txtGiaDen.Enabled = true;
            txtNhaSanXuat.Enabled = false;
            txtNamSanXuat.Enabled = false;
        }
        private void txtGiaDen_TextChanged(object sender, EventArgs e)
        {
            txtTen.Enabled = false;
            cbbLoai.Enabled = false;
            txtID.Enabled = false;
            txtGiaTu.Enabled = true;
            txtGiaDen.Enabled = true;
            txtNhaSanXuat.Enabled = false;
            txtNamSanXuat.Enabled = false;
        }
        private void txtNamSanXuat_TextChanged(object sender, EventArgs e)
        {
            txtTen.Enabled = false;
            cbbLoai.Enabled = false;
            txtID.Enabled = false;
            txtGiaTu.Enabled = false;
            txtGiaDen.Enabled = false;
            txtNhaSanXuat.Enabled = false;
            txtNamSanXuat.Enabled = true;
        }
        private void txtTen_Click(object sender, EventArgs e)
        {
            txtTen_TextChanged(sender, e);
        }
        private void cbbLoai_Click(object sender, EventArgs e)
        {
            cbbLoai_SelectedIndexChanged(sender, e);
        }
        private void txtID_Click(object sender, EventArgs e)
        {
            txtID_TextChanged(sender, e);
        }
        private void txtGiaTu_Click(object sender, EventArgs e)
        {
            txtGiaTu_TextChanged(sender, e);
        }
        private void txtGiaDen_Click(object sender, EventArgs e)
        {
            txtGiaDen_TextChanged(sender, e);
        }
        private void txtNamSanXuat_Click(object sender, EventArgs e)
        {
            txtNamSanXuat_TextChanged(sender, e);
        }
        private void btnLaylaiDanhSach_Click(object sender, EventArgs e)
        {
            dtgvDSSP.DataSource = _BUS_DanhSachSanPham.LayDanhSachSanPham();

            txtTen.Enabled = true;
            cbbLoai.Enabled = true;
            txtID.Enabled = true;
            txtGiaTu.Enabled = true;
            txtGiaDen.Enabled = true;
            txtNhaSanXuat.Enabled = true;
            txtNamSanXuat.Enabled = true;

            txtTen.Text = String.Empty;
            // cbbLoai.Text = String.Empty;
            txtID.Text = String.Empty;
            txtGiaTu.Text = String.Empty;
            txtGiaDen.Text = String.Empty;
            txtNhaSanXuat.Text = String.Empty;
            txtNamSanXuat.Text = String.Empty;
        }

        private void txtNhaSanXuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTen.Enabled = false;
            cbbLoai.Enabled = false;
            txtID.Enabled = false;
            txtGiaTu.Enabled = false;
            txtGiaDen.Enabled = false;
            txtNhaSanXuat.Enabled = true;
            txtNamSanXuat.Enabled = false;
        }
        private void txtNhaSanXuat_Click_1(object sender, EventArgs e)
        {
            txtNhaSanXuat_SelectedIndexChanged(sender, e);
        }
    }
}