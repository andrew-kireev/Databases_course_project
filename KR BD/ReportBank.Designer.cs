namespace KR_BD
{
    partial class ReportBank
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BankDataSet = new KR_BD.BankDataSet();
            this.BankBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BankTableAdapter = new KR_BD.BankDataSetTableAdapters.BankTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BankBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KR_BD.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(634, 200);
            this.reportViewer1.TabIndex = 0;
            // 
            // BankDataSet
            // 
            this.BankDataSet.DataSetName = "BankDataSet";
            this.BankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BankBindingSource
            // 
            this.BankBindingSource.DataMember = "Bank";
            this.BankBindingSource.DataSource = this.BankDataSet;
            // 
            // BankTableAdapter
            // 
            this.BankTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(673, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 32);
            this.button3.TabIndex = 30;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ReportBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 217);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportBank";
            this.Text = "ReportBank";
            this.Load += new System.EventHandler(this.ReportBank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BankBindingSource;
        private BankDataSet BankDataSet;
        private BankDataSetTableAdapters.BankTableAdapter BankTableAdapter;
        private System.Windows.Forms.Button button3;
    }
}