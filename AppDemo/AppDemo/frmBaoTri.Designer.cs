
//namespace AppDemo
//{
//    partial class frmBaoTri
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.SuspendLayout();
//            // 
//            // frmBaoTri
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(1243, 746);
//            this.IconOptions.Image = global::AppDemo.Properties.Resources.H2T_free_file10;
//            this.Name = "frmBaoTri";
//            this.Text = "Bảo trì";
//            this.ResumeLayout(false);

//        }

//        #endregion
//    }
//}



namespace AppDemo
{
    partial class frmBaoTri
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblThuonghieu = new System.Windows.Forms.Label();
            this.lblTensanpham = new System.Windows.Forms.Label();
            this.txtTensp = new System.Windows.Forms.TextBox();
            this.grbThongtinsp = new System.Windows.Forms.GroupBox();
            this.cbbThuonghieu = new System.Windows.Forms.ComboBox();
            this.grbDichvu = new System.Windows.Forms.GroupBox();
            this.ckcMatlung = new System.Windows.Forms.CheckBox();
            this.ckcChansac = new System.Windows.Forms.CheckBox();
            this.ckcManhinh = new System.Windows.Forms.CheckBox();
            this.ckcPin = new System.Windows.Forms.CheckBox();
            this.ckcEpkinh = new System.Windows.Forms.CheckBox();
            this.grbHoadon = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnInhoadon = new System.Windows.Forms.Button();
            this.txtThanhtien = new System.Windows.Forms.TextBox();
            this.txtDichvu = new System.Windows.Forms.TextBox();
            this.txtNhaptensp = new System.Windows.Forms.TextBox();
            this.btnTinhtien = new System.Windows.Forms.Button();
            this.txtTenKh = new System.Windows.Forms.TextBox();
            this.lblThanhtien = new System.Windows.Forms.Label();
            this.lblThongtinbaotri = new System.Windows.Forms.Label();
            this.lblMakh = new System.Windows.Forms.Label();
            this.btnTaomoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.labDonBan = new System.Windows.Forms.Label();
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.grbThongtinsp.SuspendLayout();
            this.grbDichvu.SuspendLayout();
            this.grbHoadon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThuonghieu
            // 
            this.lblThuonghieu.AutoSize = true;
            this.lblThuonghieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblThuonghieu.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblThuonghieu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblThuonghieu.Location = new System.Drawing.Point(119, 64);
            this.lblThuonghieu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThuonghieu.Name = "lblThuonghieu";
            this.lblThuonghieu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblThuonghieu.Size = new System.Drawing.Size(128, 24);
            this.lblThuonghieu.TabIndex = 0;
            this.lblThuonghieu.Text = "Thương hiệu ";
            // 
            // lblTensanpham
            // 
            this.lblTensanpham.AutoSize = true;
            this.lblTensanpham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblTensanpham.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblTensanpham.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTensanpham.Location = new System.Drawing.Point(119, 124);
            this.lblTensanpham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTensanpham.Name = "lblTensanpham";
            this.lblTensanpham.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTensanpham.Size = new System.Drawing.Size(143, 24);
            this.lblTensanpham.TabIndex = 1;
            this.lblTensanpham.Text = "Tên sản phẩm ";
            // 
            // txtTensp
            // 
            this.txtTensp.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtTensp.ForeColor = System.Drawing.Color.DarkGray;
            this.txtTensp.Location = new System.Drawing.Point(277, 119);
            this.txtTensp.Margin = new System.Windows.Forms.Padding(4);
            this.txtTensp.Name = "txtTensp";
            this.txtTensp.Size = new System.Drawing.Size(351, 29);
            this.txtTensp.TabIndex = 8;
            // 
            // grbThongtinsp
            // 
            this.grbThongtinsp.Controls.Add(this.cbbThuonghieu);
            this.grbThongtinsp.Controls.Add(this.lblThuonghieu);
            this.grbThongtinsp.Controls.Add(this.txtTensp);
            this.grbThongtinsp.Controls.Add(this.lblTensanpham);
            this.grbThongtinsp.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.grbThongtinsp.ForeColor = System.Drawing.Color.DarkRed;
            this.grbThongtinsp.Location = new System.Drawing.Point(34, 102);
            this.grbThongtinsp.Margin = new System.Windows.Forms.Padding(4);
            this.grbThongtinsp.Name = "grbThongtinsp";
            this.grbThongtinsp.Padding = new System.Windows.Forms.Padding(4);
            this.grbThongtinsp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbThongtinsp.Size = new System.Drawing.Size(792, 271);
            this.grbThongtinsp.TabIndex = 9;
            this.grbThongtinsp.TabStop = false;
            this.grbThongtinsp.Text = "Thông tin sản phẩm";
            // 
            // cbbThuonghieu
            // 
            this.cbbThuonghieu.AutoCompleteCustomSource.AddRange(new string[] {
            "Samsung",
            "Iphone",
            "Xiaomi",
            "Nokia",
            "OPPO"});
            this.cbbThuonghieu.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cbbThuonghieu.FormattingEnabled = true;
            this.cbbThuonghieu.Items.AddRange(new object[] {
            "Samsung",
            "Iphone",
            "Xiaomi",
            "Nokia",
            "OPPO"});
            this.cbbThuonghieu.Location = new System.Drawing.Point(277, 64);
            this.cbbThuonghieu.Margin = new System.Windows.Forms.Padding(4);
            this.cbbThuonghieu.Name = "cbbThuonghieu";
            this.cbbThuonghieu.Size = new System.Drawing.Size(351, 30);
            this.cbbThuonghieu.TabIndex = 9;
            // 
            // grbDichvu
            // 
            this.grbDichvu.Controls.Add(this.ckcMatlung);
            this.grbDichvu.Controls.Add(this.ckcChansac);
            this.grbDichvu.Controls.Add(this.ckcManhinh);
            this.grbDichvu.Controls.Add(this.ckcPin);
            this.grbDichvu.Controls.Add(this.ckcEpkinh);
            this.grbDichvu.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.grbDichvu.ForeColor = System.Drawing.Color.DarkRed;
            this.grbDichvu.Location = new System.Drawing.Point(834, 120);
            this.grbDichvu.Margin = new System.Windows.Forms.Padding(4);
            this.grbDichvu.Name = "grbDichvu";
            this.grbDichvu.Padding = new System.Windows.Forms.Padding(4);
            this.grbDichvu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbDichvu.Size = new System.Drawing.Size(350, 253);
            this.grbDichvu.TabIndex = 10;
            this.grbDichvu.TabStop = false;
            this.grbDichvu.Text = "Dịch vụ bảo trì";
            // 
            // ckcMatlung
            // 
            this.ckcMatlung.AutoSize = true;
            this.ckcMatlung.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.ckcMatlung.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ckcMatlung.Location = new System.Drawing.Point(20, 159);
            this.ckcMatlung.Margin = new System.Windows.Forms.Padding(4);
            this.ckcMatlung.Name = "ckcMatlung";
            this.ckcMatlung.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ckcMatlung.Size = new System.Drawing.Size(114, 28);
            this.ckcMatlung.TabIndex = 11;
            this.ckcMatlung.Text = "Mặt lưng";
            this.ckcMatlung.UseVisualStyleBackColor = true;
            // 
            // ckcChansac
            // 
            this.ckcChansac.AutoSize = true;
            this.ckcChansac.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.ckcChansac.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ckcChansac.Location = new System.Drawing.Point(180, 104);
            this.ckcChansac.Margin = new System.Windows.Forms.Padding(4);
            this.ckcChansac.Name = "ckcChansac";
            this.ckcChansac.Size = new System.Drawing.Size(116, 28);
            this.ckcChansac.TabIndex = 7;
            this.ckcChansac.Text = "Chân sạc";
            this.ckcChansac.UseVisualStyleBackColor = true;
            // 
            // ckcManhinh
            // 
            this.ckcManhinh.AutoSize = true;
            this.ckcManhinh.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.ckcManhinh.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ckcManhinh.Location = new System.Drawing.Point(20, 104);
            this.ckcManhinh.Margin = new System.Windows.Forms.Padding(4);
            this.ckcManhinh.Name = "ckcManhinh";
            this.ckcManhinh.Size = new System.Drawing.Size(117, 28);
            this.ckcManhinh.TabIndex = 6;
            this.ckcManhinh.Text = "Màn hình";
            this.ckcManhinh.UseVisualStyleBackColor = true;
            // 
            // ckcPin
            // 
            this.ckcPin.AutoSize = true;
            this.ckcPin.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.ckcPin.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ckcPin.Location = new System.Drawing.Point(180, 47);
            this.ckcPin.Margin = new System.Windows.Forms.Padding(4);
            this.ckcPin.Name = "ckcPin";
            this.ckcPin.Size = new System.Drawing.Size(63, 28);
            this.ckcPin.TabIndex = 5;
            this.ckcPin.Text = "Pin";
            this.ckcPin.UseVisualStyleBackColor = true;
            // 
            // ckcEpkinh
            // 
            this.ckcEpkinh.AutoSize = true;
            this.ckcEpkinh.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.ckcEpkinh.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ckcEpkinh.Location = new System.Drawing.Point(20, 47);
            this.ckcEpkinh.Margin = new System.Windows.Forms.Padding(4);
            this.ckcEpkinh.Name = "ckcEpkinh";
            this.ckcEpkinh.Size = new System.Drawing.Size(101, 28);
            this.ckcEpkinh.TabIndex = 4;
            this.ckcEpkinh.Text = "Ép kính";
            this.ckcEpkinh.UseVisualStyleBackColor = true;
            // 
            // grbHoadon
            // 
            this.grbHoadon.Controls.Add(this.btnXoa);
            this.grbHoadon.Controls.Add(this.btnInhoadon);
            this.grbHoadon.Controls.Add(this.txtThanhtien);
            this.grbHoadon.Controls.Add(this.txtDichvu);
            this.grbHoadon.Controls.Add(this.txtNhaptensp);
            this.grbHoadon.Controls.Add(this.btnTinhtien);
            this.grbHoadon.Controls.Add(this.txtTenKh);
            this.grbHoadon.Controls.Add(this.lblThanhtien);
            this.grbHoadon.Controls.Add(this.lblThongtinbaotri);
            this.grbHoadon.Controls.Add(this.lblMakh);
            this.grbHoadon.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.grbHoadon.ForeColor = System.Drawing.Color.DarkRed;
            this.grbHoadon.Location = new System.Drawing.Point(34, 395);
            this.grbHoadon.Margin = new System.Windows.Forms.Padding(4);
            this.grbHoadon.Name = "grbHoadon";
            this.grbHoadon.Padding = new System.Windows.Forms.Padding(4);
            this.grbHoadon.Size = new System.Drawing.Size(793, 335);
            this.grbHoadon.TabIndex = 11;
            this.grbHoadon.TabStop = false;
            this.grbHoadon.Text = "Hóa đơn";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnXoa.ForeColor = System.Drawing.Color.DarkRed;
            this.btnXoa.Location = new System.Drawing.Point(419, 242);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 41);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnInhoadon
            // 
            this.btnInhoadon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnInhoadon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInhoadon.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnInhoadon.ForeColor = System.Drawing.Color.DarkRed;
            this.btnInhoadon.Location = new System.Drawing.Point(258, 242);
            this.btnInhoadon.Margin = new System.Windows.Forms.Padding(4);
            this.btnInhoadon.Name = "btnInhoadon";
            this.btnInhoadon.Size = new System.Drawing.Size(115, 41);
            this.btnInhoadon.TabIndex = 14;
            this.btnInhoadon.Text = "In hóa đơn";
            this.btnInhoadon.UseVisualStyleBackColor = false;
            // 
            // txtThanhtien
            // 
            this.txtThanhtien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtThanhtien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThanhtien.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtThanhtien.ForeColor = System.Drawing.Color.DarkRed;
            this.txtThanhtien.Location = new System.Drawing.Point(258, 173);
            this.txtThanhtien.Margin = new System.Windows.Forms.Padding(4);
            this.txtThanhtien.Name = "txtThanhtien";
            this.txtThanhtien.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtThanhtien.Size = new System.Drawing.Size(351, 29);
            this.txtThanhtien.TabIndex = 13;
            // 
            // txtDichvu
            // 
            this.txtDichvu.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtDichvu.ForeColor = System.Drawing.Color.DarkGray;
            this.txtDichvu.Location = new System.Drawing.Point(258, 135);
            this.txtDichvu.Margin = new System.Windows.Forms.Padding(4);
            this.txtDichvu.Name = "txtDichvu";
            this.txtDichvu.Size = new System.Drawing.Size(351, 29);
            this.txtDichvu.TabIndex = 10;
            this.txtDichvu.Text = "Dịch vụ bảo trì";
            // 
            // txtNhaptensp
            // 
            this.txtNhaptensp.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtNhaptensp.ForeColor = System.Drawing.Color.DarkGray;
            this.txtNhaptensp.Location = new System.Drawing.Point(258, 98);
            this.txtNhaptensp.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhaptensp.Name = "txtNhaptensp";
            this.txtNhaptensp.Size = new System.Drawing.Size(351, 29);
            this.txtNhaptensp.TabIndex = 9;
            this.txtNhaptensp.Text = "Tên sản phẩm";
            // 
            // btnTinhtien
            // 
            this.btnTinhtien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnTinhtien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTinhtien.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnTinhtien.ForeColor = System.Drawing.Color.DarkRed;
            this.btnTinhtien.Location = new System.Drawing.Point(104, 242);
            this.btnTinhtien.Margin = new System.Windows.Forms.Padding(4);
            this.btnTinhtien.Name = "btnTinhtien";
            this.btnTinhtien.Size = new System.Drawing.Size(119, 41);
            this.btnTinhtien.TabIndex = 12;
            this.btnTinhtien.Text = "Tính tiền";
            this.btnTinhtien.UseVisualStyleBackColor = false;
            // 
            // txtTenKh
            // 
            this.txtTenKh.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenKh.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtTenKh.ForeColor = System.Drawing.Color.DarkGray;
            this.txtTenKh.Location = new System.Drawing.Point(258, 55);
            this.txtTenKh.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKh.Name = "txtTenKh";
            this.txtTenKh.Size = new System.Drawing.Size(351, 29);
            this.txtTenKh.TabIndex = 4;
            // 
            // lblThanhtien
            // 
            this.lblThanhtien.AutoSize = true;
            this.lblThanhtien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblThanhtien.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblThanhtien.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblThanhtien.Location = new System.Drawing.Point(104, 178);
            this.lblThanhtien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThanhtien.Name = "lblThanhtien";
            this.lblThanhtien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblThanhtien.Size = new System.Drawing.Size(112, 24);
            this.lblThanhtien.TabIndex = 3;
            this.lblThanhtien.Text = "Thành tiền ";
            // 
            // lblThongtinbaotri
            // 
            this.lblThongtinbaotri.AutoSize = true;
            this.lblThongtinbaotri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblThongtinbaotri.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblThongtinbaotri.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblThongtinbaotri.Location = new System.Drawing.Point(97, 99);
            this.lblThongtinbaotri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThongtinbaotri.Name = "lblThongtinbaotri";
            this.lblThongtinbaotri.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblThongtinbaotri.Size = new System.Drawing.Size(172, 24);
            this.lblThongtinbaotri.TabIndex = 2;
            this.lblThongtinbaotri.Text = "Thông tin bảo trì :";
            // 
            // lblMakh
            // 
            this.lblMakh.AutoSize = true;
            this.lblMakh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblMakh.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblMakh.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblMakh.Location = new System.Drawing.Point(100, 56);
            this.lblMakh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMakh.Name = "lblMakh";
            this.lblMakh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMakh.Size = new System.Drawing.Size(158, 24);
            this.lblMakh.TabIndex = 1;
            this.lblMakh.Text = "Tên khách hàng ";
            // 
            // btnTaomoi
            // 
            this.btnTaomoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnTaomoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTaomoi.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnTaomoi.ForeColor = System.Drawing.Color.DarkRed;
            this.btnTaomoi.Location = new System.Drawing.Point(919, 497);
            this.btnTaomoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaomoi.Name = "btnTaomoi";
            this.btnTaomoi.Size = new System.Drawing.Size(254, 100);
            this.btnTaomoi.TabIndex = 13;
            this.btnTaomoi.Text = "Tạo mới";
            this.btnTaomoi.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnThoat.ForeColor = System.Drawing.Color.DarkRed;
            this.btnThoat.Location = new System.Drawing.Point(1052, 634);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(121, 47);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // labDonBan
            // 
            this.labDonBan.AutoSize = true;
            this.labDonBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(91)))), ((int)(((byte)(135)))));
            this.labDonBan.Font = new System.Drawing.Font("Tekton Pro Ext", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDonBan.ForeColor = System.Drawing.Color.White;
            this.labDonBan.Location = new System.Drawing.Point(493, 21);
            this.labDonBan.Name = "labDonBan";
            this.labDonBan.Size = new System.Drawing.Size(268, 44);
            this.labDonBan.TabIndex = 39;
            this.labDonBan.Text = "Nhập đơn bán";
            // 
            // tileNavPane1
            // 
            this.tileNavPane1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // tileNavCategory1
            // 
            this.tileNavPane1.DefaultCategory.Name = "tileNavCategory1";
            // 
            // 
            // 
            this.tileNavPane1.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileNavPane1.Location = new System.Drawing.Point(-3, 12);
            this.tileNavPane1.Name = "tileNavPane1";
            this.tileNavPane1.Size = new System.Drawing.Size(1251, 53);
            this.tileNavPane1.TabIndex = 38;
            this.tileNavPane1.Text = "tileNavPane1";
            // 
            // frmBaoTri
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1247, 752);
            this.Controls.Add(this.labDonBan);
            this.Controls.Add(this.tileNavPane1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTaomoi);
            this.Controls.Add(this.grbHoadon);
            this.Controls.Add(this.grbDichvu);
            this.Controls.Add(this.grbThongtinsp);
            this.IconOptions.Image = global::AppDemo.Properties.Resources.H2T_free_file10;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBaoTri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chăm sóc và bảo trì";
            this.grbThongtinsp.ResumeLayout(false);
            this.grbThongtinsp.PerformLayout();
            this.grbDichvu.ResumeLayout(false);
            this.grbDichvu.PerformLayout();
            this.grbHoadon.ResumeLayout(false);
            this.grbHoadon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThuonghieu;
        private System.Windows.Forms.Label lblTensanpham;
        private System.Windows.Forms.TextBox txtTensp;
        private System.Windows.Forms.GroupBox grbThongtinsp;
        private System.Windows.Forms.GroupBox grbDichvu;
        private System.Windows.Forms.CheckBox ckcPin;
        private System.Windows.Forms.CheckBox ckcEpkinh;
        private System.Windows.Forms.CheckBox ckcChansac;
        private System.Windows.Forms.CheckBox ckcManhinh;
        private System.Windows.Forms.CheckBox ckcMatlung;
        private System.Windows.Forms.GroupBox grbHoadon;
        private System.Windows.Forms.Label lblMakh;
        private System.Windows.Forms.TextBox txtThanhtien;
        private System.Windows.Forms.TextBox txtDichvu;
        private System.Windows.Forms.TextBox txtNhaptensp;
        private System.Windows.Forms.Button btnTinhtien;
        private System.Windows.Forms.TextBox txtTenKh;
        private System.Windows.Forms.Label lblThanhtien;
        private System.Windows.Forms.Label lblThongtinbaotri;
        private System.Windows.Forms.Button btnTaomoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cbbThuonghieu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnInhoadon;
        private System.Windows.Forms.Label labDonBan;
        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
    }
}