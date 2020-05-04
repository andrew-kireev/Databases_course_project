namespace KR_BD
{
    partial class ReportCards
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BankDataSet = new KR_BD.BankDataSet();
            this.CardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CardTableAdapter = new KR_BD.BankDataSetTableAdapters.CardTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.CardBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KR_BD.rep_cards.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(597, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // BankDataSet
            // 
            this.BankDataSet.DataSetName = "BankDataSet";
            this.BankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CardBindingSource
            // 
            this.CardBindingSource.DataMember = "Card";
            this.CardBindingSource.DataSource = this.BankDataSet;
            // 
            // CardTableAdapter
            // 
            this.CardTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(623, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 32);
            this.button3.TabIndex = 31;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ReportCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 274);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportCards";
            this.Text = "ReportCards";
            this.Load += new System.EventHandler(this.ReportCards_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CardBindingSource;
        private BankDataSet BankDataSet;
        private BankDataSetTableAdapters.CardTableAdapter CardTableAdapter;
        private System.Windows.Forms.Button button3;
    }
}