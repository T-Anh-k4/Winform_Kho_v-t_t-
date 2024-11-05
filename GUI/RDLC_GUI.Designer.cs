namespace GUI
{
    partial class RDLC_GUI
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cTHDNDataSet = new GUI.CTHDNDataSet();
            this.cTHDNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTHDNTableAdapter = new GUI.CTHDNDataSetTableAdapters.CTHDNTableAdapter();
            this.cHITIETHDNHAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHITIET_HD_NHAPTableAdapter = new GUI.CTHDNDataSetTableAdapters.CHITIET_HD_NHAPTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTHDNDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHDNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETHDNHAPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Top;
            reportDataSource1.Name = "CTHDN";
            reportDataSource1.Value = this.cTHDNBindingSource;
            reportDataSource2.Name = "SHDN";
            reportDataSource2.Value = this.cHITIETHDNHAPBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.CTHDN_RP.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 100);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(933, 471);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 100);
            this.panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cTHDNDataSet
            // 
            this.cTHDNDataSet.DataSetName = "CTHDNDataSet";
            this.cTHDNDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cTHDNBindingSource
            // 
            this.cTHDNBindingSource.DataMember = "CTHDN";
            this.cTHDNBindingSource.DataSource = this.cTHDNDataSet;
            // 
            // cTHDNTableAdapter
            // 
            this.cTHDNTableAdapter.ClearBeforeFill = true;
            // 
            // cHITIETHDNHAPBindingSource
            // 
            this.cHITIETHDNHAPBindingSource.DataMember = "CHITIET_HD_NHAP";
            this.cHITIETHDNHAPBindingSource.DataSource = this.cTHDNDataSet;
            // 
            // cHITIET_HD_NHAPTableAdapter
            // 
            this.cHITIET_HD_NHAPTableAdapter.ClearBeforeFill = true;
            // 
            // RDLC_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 597);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "RDLC_GUI";
            this.Text = "RDLC_GUI";
            this.Load += new System.EventHandler(this.RDLC_GUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTHDNDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHDNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETHDNHAPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private CTHDNDataSet cTHDNDataSet;
        private System.Windows.Forms.BindingSource cTHDNBindingSource;
        private CTHDNDataSetTableAdapters.CTHDNTableAdapter cTHDNTableAdapter;
        private System.Windows.Forms.BindingSource cHITIETHDNHAPBindingSource;
        private CTHDNDataSetTableAdapters.CHITIET_HD_NHAPTableAdapter cHITIET_HD_NHAPTableAdapter;
    }
}