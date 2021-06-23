
namespace AppDemo
{
    partial class frmLoginMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginMain));
            this.ctmnsMB2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.thoátToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_AllForm = new System.Windows.Forms.Panel();
            this.pbShowHidePass = new System.Windows.Forms.PictureBox();
            this.lbInfoShop = new System.Windows.Forms.Label();
            this.lbForgetPass = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnGG = new System.Windows.Forms.Button();
            this.btnFB = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.ttAll = new System.Windows.Forms.ToolTip(this.components);
            this.pbNgonNguTiengAnh = new System.Windows.Forms.PictureBox();
            this.pbNgonNguVietnam = new System.Windows.Forms.PictureBox();
            this.ctmnsNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thoátToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.plLanguage = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.notifyIcon_Login = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctmnsMB2.SuspendLayout();
            this.panel_AllForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowHidePass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNgonNguTiengAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNgonNguVietnam)).BeginInit();
            this.ctmnsNotifyIcon.SuspendLayout();
            this.plLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctmnsMB2
            // 
            this.ctmnsMB2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ctmnsMB2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.thoátToolStripMenuItem,
            this.toolStripSeparator1,
            this.thoátToolStripMenuItem1});
            this.ctmnsMB2.Name = "contextMenuStrip_MB2";
            this.ctmnsMB2.Size = new System.Drawing.Size(221, 106);
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(220, 32);
            this.đăngNhậpToolStripMenuItem.Text = "Login";
            this.đăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(220, 32);
            this.thoátToolStripMenuItem.Text = "Forgot password";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(217, 6);
            // 
            // thoátToolStripMenuItem1
            // 
            this.thoátToolStripMenuItem1.Name = "thoátToolStripMenuItem1";
            this.thoátToolStripMenuItem1.Size = new System.Drawing.Size(220, 32);
            this.thoátToolStripMenuItem1.Text = "Exit";
            this.thoátToolStripMenuItem1.Click += new System.EventHandler(this.thoátToolStripMenuItem1_Click);
            // 
            // panel_AllForm
            // 
            this.panel_AllForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.panel_AllForm.Controls.Add(this.pbShowHidePass);
            this.panel_AllForm.Controls.Add(this.lbInfoShop);
            this.panel_AllForm.Controls.Add(this.lbForgetPass);
            this.panel_AllForm.Controls.Add(this.lbTitle);
            this.panel_AllForm.Controls.Add(this.btnGG);
            this.panel_AllForm.Controls.Add(this.btnFB);
            this.panel_AllForm.Controls.Add(this.btnLogin);
            this.panel_AllForm.Controls.Add(this.txtPass);
            this.panel_AllForm.Controls.Add(this.txtUser);
            this.panel_AllForm.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel_AllForm.Location = new System.Drawing.Point(619, 314);
            this.panel_AllForm.Name = "panel_AllForm";
            this.panel_AllForm.Size = new System.Drawing.Size(379, 422);
            this.panel_AllForm.TabIndex = 2;
            // 
            // pbShowHidePass
            // 
            this.pbShowHidePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbShowHidePass.Image = global::AppDemo.Properties.Resources.eye_slash_solid;
            this.pbShowHidePass.Location = new System.Drawing.Point(282, 145);
            this.pbShowHidePass.Name = "pbShowHidePass";
            this.pbShowHidePass.Size = new System.Drawing.Size(55, 50);
            this.pbShowHidePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShowHidePass.TabIndex = 8;
            this.pbShowHidePass.TabStop = false;
            this.pbShowHidePass.Click += new System.EventHandler(this.pictureBox_ShowHidePass_Click);
            // 
            // lbInfoShop
            // 
            this.lbInfoShop.AutoSize = true;
            this.lbInfoShop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbInfoShop.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbInfoShop.ForeColor = System.Drawing.Color.Red;
            this.lbInfoShop.Location = new System.Drawing.Point(231, 289);
            this.lbInfoShop.Name = "lbInfoShop";
            this.lbInfoShop.Size = new System.Drawing.Size(106, 24);
            this.lbInfoShop.TabIndex = 5;
            this.lbInfoShop.Text = "Rules shop";
            this.ttAll.SetToolTip(this.lbInfoShop, "While we know that it is easy to \r\ndisregard these Terms of Service,\r\n we need to" +
        " clearly state our responsibilities\r\n as well as your responsibilities in your u" +
        "se of \r\nGoogle Services.");
            // 
            // lbForgetPass
            // 
            this.lbForgetPass.AutoSize = true;
            this.lbForgetPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbForgetPass.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbForgetPass.ForeColor = System.Drawing.Color.Red;
            this.lbForgetPass.Location = new System.Drawing.Point(31, 289);
            this.lbForgetPass.Name = "lbForgetPass";
            this.lbForgetPass.Size = new System.Drawing.Size(166, 24);
            this.lbForgetPass.TabIndex = 4;
            this.lbForgetPass.Text = "Forgot password?";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTitle.Location = new System.Drawing.Point(127, 12);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(115, 48);
            this.lbTitle.TabIndex = 4;
            this.lbTitle.Text = "Login";
            // 
            // btnGG
            // 
            this.btnGG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGG.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGG.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnGG.FlatAppearance.BorderSize = 0;
            this.btnGG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnGG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnGG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGG.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGG.ForeColor = System.Drawing.Color.Transparent;
            this.btnGG.Location = new System.Drawing.Point(217, 323);
            this.btnGG.Name = "btnGG";
            this.btnGG.Size = new System.Drawing.Size(120, 50);
            this.btnGG.TabIndex = 7;
            this.btnGG.Text = "Google";
            this.btnGG.UseVisualStyleBackColor = false;
            // 
            // btnFB
            // 
            this.btnFB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFB.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFB.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnFB.FlatAppearance.BorderSize = 0;
            this.btnFB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnFB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnFB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFB.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFB.ForeColor = System.Drawing.Color.Transparent;
            this.btnFB.Location = new System.Drawing.Point(35, 323);
            this.btnFB.Name = "btnFB";
            this.btnFB.Size = new System.Drawing.Size(122, 50);
            this.btnFB.TabIndex = 6;
            this.btnFB.Text = "Facebook";
            this.btnFB.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogin.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogin.Location = new System.Drawing.Point(35, 210);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(302, 50);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.ttAll.SetToolTip(this.btnLogin, "Click to agree");
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // txtPass
            // 
            this.txtPass.AccessibleDescription = "";
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPass.Location = new System.Drawing.Point(35, 145);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(241, 48);
            this.txtPass.TabIndex = 2;
            this.ttAll.SetToolTip(this.txtPass, "Password");
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            this.txtUser.AccessibleDescription = "";
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUser.Location = new System.Drawing.Point(35, 70);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(302, 48);
            this.txtUser.TabIndex = 1;
            this.ttAll.SetToolTip(this.txtUser, "ID or Name");
            // 
            // ttAll
            // 
            this.ttAll.ShowAlways = true;
            this.ttAll.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttAll.ToolTipTitle = "Infomation";
            // 
            // pbNgonNguTiengAnh
            // 
            this.pbNgonNguTiengAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbNgonNguTiengAnh.Image = global::AppDemo.Properties.Resources.englishFlag;
            this.pbNgonNguTiengAnh.Location = new System.Drawing.Point(125, 15);
            this.pbNgonNguTiengAnh.Name = "pbNgonNguTiengAnh";
            this.pbNgonNguTiengAnh.Size = new System.Drawing.Size(87, 62);
            this.pbNgonNguTiengAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNgonNguTiengAnh.TabIndex = 5;
            this.pbNgonNguTiengAnh.TabStop = false;
            this.ttAll.SetToolTip(this.pbNgonNguTiengAnh, "English language");
            this.pbNgonNguTiengAnh.Click += new System.EventHandler(this.pictureBox_langEnglish_Click);
            // 
            // pbNgonNguVietnam
            // 
            this.pbNgonNguVietnam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbNgonNguVietnam.Image = global::AppDemo.Properties.Resources.vietnameseFlag;
            this.pbNgonNguVietnam.Location = new System.Drawing.Point(20, 15);
            this.pbNgonNguVietnam.Name = "pbNgonNguVietnam";
            this.pbNgonNguVietnam.Size = new System.Drawing.Size(87, 62);
            this.pbNgonNguVietnam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNgonNguVietnam.TabIndex = 4;
            this.pbNgonNguVietnam.TabStop = false;
            this.ttAll.SetToolTip(this.pbNgonNguVietnam, "Vietnamese language");
            this.pbNgonNguVietnam.Click += new System.EventHandler(this.pictureBox_langVietman_Click);
            // 
            // ctmnsNotifyIcon
            // 
            this.ctmnsNotifyIcon.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ctmnsNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem2});
            this.ctmnsNotifyIcon.Name = "contextMenuStrip_notifyIcon";
            this.ctmnsNotifyIcon.Size = new System.Drawing.Size(112, 36);
            // 
            // thoátToolStripMenuItem2
            // 
            this.thoátToolStripMenuItem2.Name = "thoátToolStripMenuItem2";
            this.thoátToolStripMenuItem2.Size = new System.Drawing.Size(111, 32);
            this.thoátToolStripMenuItem2.Text = "Exit";
            this.thoátToolStripMenuItem2.Click += new System.EventHandler(this.thoátToolStripMenuItem2_Click);
            // 
            // plLanguage
            // 
            this.plLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.plLanguage.Controls.Add(this.pbNgonNguTiengAnh);
            this.plLanguage.Controls.Add(this.pbNgonNguVietnam);
            this.plLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plLanguage.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.plLanguage.Location = new System.Drawing.Point(12, 12);
            this.plLanguage.Name = "plLanguage";
            this.plLanguage.Size = new System.Drawing.Size(228, 95);
            this.plLanguage.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(879, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 50);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button_close_Click);
            // 
            // notifyIcon_Login
            // 
            this.notifyIcon_Login.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon_Login.BalloonTipText = " Đăng Nhập Thành Công";
            this.notifyIcon_Login.BalloonTipTitle = "Thông Báo";
            this.notifyIcon_Login.ContextMenuStrip = this.ctmnsNotifyIcon;
            this.notifyIcon_Login.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon_Login.Icon")));
            this.notifyIcon_Login.Text = "Thông Báo Đăng Nhập Thành Công";
            this.notifyIcon_Login.Visible = true;
            // 
            // frmLoginMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImage = global::AppDemo.Properties.Resources.backgroundMain;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.ContextMenuStrip = this.ctmnsMB2;
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.plLanguage);
            this.Controls.Add(this.panel_AllForm);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoginMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ctmnsMB2.ResumeLayout(false);
            this.panel_AllForm.ResumeLayout(false);
            this.panel_AllForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowHidePass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNgonNguTiengAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNgonNguVietnam)).EndInit();
            this.ctmnsNotifyIcon.ResumeLayout(false);
            this.plLanguage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip ctmnsMB2;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem1;
        private System.Windows.Forms.Panel panel_AllForm;
        private System.Windows.Forms.Label lbInfoShop;
        private System.Windows.Forms.Label lbForgetPass;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnGG;
        private System.Windows.Forms.Button btnFB;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.ToolTip ttAll;
        private System.Windows.Forms.PictureBox pbShowHidePass;
        private System.Windows.Forms.ContextMenuStrip ctmnsNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem2;
        private System.Windows.Forms.PictureBox pbNgonNguVietnam;
        private System.Windows.Forms.PictureBox pbNgonNguTiengAnh;
        private System.Windows.Forms.Panel plLanguage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.NotifyIcon notifyIcon_Login;
    }
}

