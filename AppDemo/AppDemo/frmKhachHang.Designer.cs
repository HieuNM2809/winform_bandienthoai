
namespace AppDemo
{
    partial class frmKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.tpMain = new DevExpress.XtraBars.Navigation.TabPane();
            this.tnnvpThongSo = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThanhPhoKH = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMbdKH = new System.Windows.Forms.TextBox();
            this.txtDiaChiKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.txtThanhPho = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tpMain)).BeginInit();
            this.tpMain.SuspendLayout();
            this.tnnvpThongSo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpMain
            // 
            this.tpMain.Controls.Add(this.tnnvpThongSo);
            this.tpMain.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tpMain.Location = new System.Drawing.Point(84, 13);
            this.tpMain.Margin = new System.Windows.Forms.Padding(4);
            this.tpMain.Name = "tpMain";
            this.tpMain.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tnnvpThongSo});
            this.tpMain.RegularSize = new System.Drawing.Size(580, 321);
            this.tpMain.SelectedPage = this.tnnvpThongSo;
            this.tpMain.Size = new System.Drawing.Size(580, 321);
            this.tpMain.TabIndex = 47;
            // 
            // tnnvpThongSo
            // 
            this.tnnvpThongSo.Caption = "Khách hàng";
            this.tnnvpThongSo.Controls.Add(this.label1);
            this.tnnvpThongSo.Controls.Add(this.txtThanhPhoKH);
            this.tnnvpThongSo.Controls.Add(this.label14);
            this.tnnvpThongSo.Controls.Add(this.txtMbdKH);
            this.tnnvpThongSo.Controls.Add(this.txtDiaChiKH);
            this.tnnvpThongSo.Controls.Add(this.txtTenKH);
            this.tnnvpThongSo.Controls.Add(this.txtSDTKH);
            this.tnnvpThongSo.Controls.Add(this.label7);
            this.tnnvpThongSo.Controls.Add(this.label6);
            this.tnnvpThongSo.Controls.Add(this.txtTrangThai);
            this.tnnvpThongSo.Controls.Add(this.txtThanhPho);
            this.tnnvpThongSo.Controls.Add(this.label9);
            this.tnnvpThongSo.Controls.Add(this.label5);
            this.tnnvpThongSo.Controls.Add(this.label8);
            this.tnnvpThongSo.Margin = new System.Windows.Forms.Padding(4);
            this.tnnvpThongSo.Name = "tnnvpThongSo";
            this.tnnvpThongSo.Size = new System.Drawing.Size(580, 278);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(48, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 132;
            this.label1.Text = "Thành phố";
            // 
            // txtThanhPhoKH
            // 
            this.txtThanhPhoKH.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtThanhPhoKH.Location = new System.Drawing.Point(215, 117);
            this.txtThanhPhoKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtThanhPhoKH.Name = "txtThanhPhoKH";
            this.txtThanhPhoKH.Size = new System.Drawing.Size(301, 32);
            this.txtThanhPhoKH.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.Location = new System.Drawing.Point(48, 168);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 24);
            this.label14.TabIndex = 130;
            this.label14.Text = "Mã bưu điện";
            // 
            // txtMbdKH
            // 
            this.txtMbdKH.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMbdKH.Location = new System.Drawing.Point(215, 165);
            this.txtMbdKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMbdKH.Name = "txtMbdKH";
            this.txtMbdKH.Size = new System.Drawing.Size(301, 32);
            this.txtMbdKH.TabIndex = 4;
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiaChiKH.Location = new System.Drawing.Point(215, 77);
            this.txtDiaChiKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.Size = new System.Drawing.Size(301, 32);
            this.txtDiaChiKH.TabIndex = 2;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenKH.Location = new System.Drawing.Point(215, 27);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(301, 32);
            this.txtTenKH.TabIndex = 1;
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSDTKH.Location = new System.Drawing.Point(215, 211);
            this.txtSDTKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(301, 32);
            this.txtSDTKH.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(48, 77);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(53, 211);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Số điện thoại";
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTrangThai.Location = new System.Drawing.Point(333, 412);
            this.txtTrangThai.Margin = new System.Windows.Forms.Padding(4);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(301, 32);
            this.txtTrangThai.TabIndex = 11;
            // 
            // txtThanhPho
            // 
            this.txtThanhPho.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtThanhPho.Location = new System.Drawing.Point(333, 330);
            this.txtThanhPho.Margin = new System.Windows.Forms.Padding(4);
            this.txtThanhPho.Name = "txtThanhPho";
            this.txtThanhPho.Size = new System.Drawing.Size(301, 32);
            this.txtThanhPho.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(66, 416);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 24);
            this.label9.TabIndex = 11;
            this.label9.Text = "Trạng thái:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(48, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tên khách hàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(66, 333);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "Thành phố:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(287, 358);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(221, 61);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm khách hàng";
            ((System.ComponentModel.ISupportInitialize)(this.tpMain)).EndInit();
            this.tpMain.ResumeLayout(false);
            this.tnnvpThongSo.ResumeLayout(false);
            this.tnnvpThongSo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tpMain;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tnnvpThongSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtThanhPhoKH;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMbdKH;
        private System.Windows.Forms.TextBox txtDiaChiKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtSDTKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.TextBox txtThanhPho;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnThem;
    }
}