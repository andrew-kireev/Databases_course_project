namespace KR_BD
{
    partial class Form2
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ClientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BankDataSet = new KR_BD.BankDataSet();
            this.ОтчетКлиент = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ClientsTableAdapter = new KR_BD.BankDataSetTableAdapters.ClientsTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientsBindingSource
            // 
            this.ClientsBindingSource.DataMember = "Clients";
            this.ClientsBindingSource.DataSource = this.BankDataSet;
            // 
            // BankDataSet
            // 
            this.BankDataSet.DataSetName = "BankDataSet";
            this.BankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ОтчетКлиент
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.ClientsBindingSource;
            this.ОтчетКлиент.LocalReport.DataSources.Add(reportDataSource3);
            this.ОтчетКлиент.LocalReport.ReportEmbeddedResource = "KR_BD.Report1.rdlc";
            this.ОтчетКлиент.Location = new System.Drawing.Point(0, 0);
            this.ОтчетКлиент.Name = "ОтчетКлиент";
            this.ОтчетКлиент.ServerReport.BearerToken = null;
            this.ОтчетКлиент.Size = new System.Drawing.Size(661, 428);
            this.ОтчетКлиент.TabIndex = 0;
            this.ОтчетКлиент.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // ClientsTableAdapter
            // 
            this.ClientsTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(681, 38);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 32);
            this.button3.TabIndex = 32;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ОтчетКлиент);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ОтчетКлиент;
        private System.Windows.Forms.BindingSource ClientsBindingSource;
        private BankDataSet BankDataSet;
        private BankDataSetTableAdapters.ClientsTableAdapter ClientsTableAdapter;
        private System.Windows.Forms.Button button3;
    }
}