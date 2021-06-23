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
using Microsoft.Reporting.WinForms;

namespace AppDemo
{
    public partial class frmBaoCao : Form
    {
        private BUS_DanhSachSanPham _DanhSachSanPham = new BUS_DanhSachSanPham();
        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            this.rptBaoCao.RefreshReport();
        }
        public void InPhieuNhap(string prodID, string ten, string ngay, string sdt, string thanhTien )
        {
            List<DTO_product> _DTO_product = new List<DTO_product>();
            _DTO_product = _DanhSachSanPham.TimTheoID(prodID);
            // lay du lieu 
            rptBaoCao.LocalReport.ReportEmbeddedResource = "AppDemo.rptDonNhap.rdlc";

            // sét biến paLop (trong report ) bằng mã lớp 
            rptBaoCao.LocalReport.SetParameters(new ReportParameter("paSOPHIEU", prodID+"PHIEU"));
            rptBaoCao.LocalReport.SetParameters(new ReportParameter("paTEN", ten));
            rptBaoCao.LocalReport.SetParameters(new ReportParameter("paNGAY",ngay));
            rptBaoCao.LocalReport.SetParameters(new ReportParameter("paSDT", sdt));
            rptBaoCao.LocalReport.SetParameters(new ReportParameter("paTHANHTIEN", thanhTien));
            // DSSV là dataset ( bảng)  bên report 
            rptBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", _DTO_product));
            rptBaoCao.RefreshReport();
        }
        public void InDSPhieuNhap(String sdt, String ngay)
        {
            List<DTO_product> _DTO_product = new List<DTO_product>();
            _DTO_product = _DanhSachSanPham.LayDanhSachSanPham();
            // lay du lieu 
            rptBaoCao.LocalReport.ReportEmbeddedResource = "AppDemo.rptDSSP.rdlc";

            // sét biến paLop (trong report ) bằng mã lớp 
            rptBaoCao.LocalReport.SetParameters(new ReportParameter("paNGAY", ngay));
            rptBaoCao.LocalReport.SetParameters(new ReportParameter("paSDT", sdt));
            // DSSV là dataset ( bảng)  bên report 
            rptBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSSP", _DTO_product));
            rptBaoCao.RefreshReport();
        }
        public void InPhieuBan(string prodID, string ten, string ngay, string sdt, string thanhTien, String sl)
        {
            List<DTO_product> _DTO_product = new List<DTO_product>();
            _DTO_product = _DanhSachSanPham.TimTheoID(prodID);
            // lay du lieu 
            rptBaoCao.LocalReport.ReportEmbeddedResource = "AppDemo.rptDonBan.rdlc";

            // sét biến paLop (trong report ) bằng mã lớp 
            rptBaoCao.LocalReport.SetParameters(new ReportParameter("paSOPHIEU", prodID + "PHIEU"));
            rptBaoCao.LocalReport.SetParameters(new ReportParameter("paTEN", ten));
            rptBaoCao.LocalReport.SetParameters(new ReportParameter("paNGAY", ngay));
            rptBaoCao.LocalReport.SetParameters(new ReportParameter("paSDT", sdt));
            rptBaoCao.LocalReport.SetParameters(new ReportParameter("paTHANHTIEN", thanhTien));
            rptBaoCao.LocalReport.SetParameters(new ReportParameter("paSL", sl));
            // DSSV là dataset ( bảng)  bên report 
            rptBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", _DTO_product));
            rptBaoCao.RefreshReport();
        }

    }
}
