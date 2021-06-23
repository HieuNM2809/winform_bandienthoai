
namespace AppDemo
{
    partial class frmBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCao));
            this.rptBaoCao = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptBaoCao
            // 
            this.rptBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptBaoCao.Location = new System.Drawing.Point(0, 0);
            this.rptBaoCao.Name = "rptBaoCao";
            this.rptBaoCao.ServerReport.BearerToken = null;
            this.rptBaoCao.Size = new System.Drawing.Size(743, 739);
            this.rptBaoCao.TabIndex = 0;
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 739);
            this.Controls.Add(this.rptBaoCao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBaoCao";
            this.Text = "Báo cáo";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptBaoCao;
    }
}