namespace KR_BD
{
    partial class ReportCredit
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
            this.CreditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CreditTableAdapter = new KR_BD.BankDataSetTableAdapters.CreditTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CreditBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KR_BD.rep_cred.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(650, 300);
            this.reportViewer1.TabIndex = 0;
            // 
            // BankDataSet
            // 
            this.BankDataSet.DataSetName = "BankDataSet";
            this.BankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CreditBindingSource
            // 
            this.CreditBindingSource.DataMember = "Credit";
            this.CreditBindingSource.DataSource = this.BankDataSet;
            // 
            // CreditTableAdapter
            // 
            this.CreditTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(658, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 32);
            this.button3.TabIndex = 31;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ReportCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 359);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportCredit";
            this.Text = "ReportCredit";
            this.Load += new System.EventHandler(this.ReportCredit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CreditBindingSource;
        private BankDataSet BankDataSet;
        private BankDataSetTableAdapters.CreditTableAdapter CreditTableAdapter;
        private System.Windows.Forms.Button button3;
    }
}