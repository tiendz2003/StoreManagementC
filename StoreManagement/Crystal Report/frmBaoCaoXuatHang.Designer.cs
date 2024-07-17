namespace StoreManagement.Crystal_Report
{
    partial class frmBaoCaoXuatHang
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
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.reportDocument2 = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            this.reportDocument1 = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            this.SuspendLayout();
            // 
            // crystalReportViewer
            // 
            this.crystalReportViewer.ActiveViewIndex = 0;
            this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.ReportSource = @"C:\\Users\\DELL\\source\\repos\\StoreManagement\\StoreManagement\\Crystal Report\\rptBaoCaoPhieuXuat.rpt";
            this.crystalReportViewer.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewer.TabIndex = 0;
            // 
            // reportDocument2
            // 
            this.reportDocument2.FileName = "rassdk://C:\\Users\\DELL\\source\\repos\\StoreManagement\\StoreManagement\\Crystal Repor" +
    "t\\rptBaoCaoPhieuXuat.rpt";
            // 
            // reportDocument1
            // 
            this.reportDocument1.FileName = "rassdk://C:\\Users\\DELL\\source\\repos\\StoreManagement\\StoreManagement\\Crystal Repor" +
    "t\\rptBaoCaoPhieuXuat.rpt";
            // 
            // frmBaoCaoXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewer);
            this.Name = "frmBaoCaoXuatHang";
            this.Text = "frmBaoCaoXuatHang";
            this.ResumeLayout(false);

        }

        #endregion
        private CrystalDecisions.CrystalReports.Engine.ReportDocument reportDocument1;
        private CrystalDecisions.CrystalReports.Engine.ReportDocument reportDocument2;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
    }
}