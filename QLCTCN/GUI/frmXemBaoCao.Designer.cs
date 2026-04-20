using Microsoft.Reporting.WinForms;
using System.Windows.Forms;

namespace GUI
{
    partial class frmXemBaoCao
    {
        private System.ComponentModel.IContainer components = null;
        private ReportViewer reportViewer1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(900, 600);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmXemBaoCao
            // 
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmXemBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo thống kê thu chi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmXemBaoCao_Load);
            this.ResumeLayout(false);

        }
    }
}