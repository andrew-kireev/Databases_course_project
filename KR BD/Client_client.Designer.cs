namespace KR_BD
{
    partial class Client_client
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.bankDataSet = new KR_BD.BankDataSet();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new KR_BD.BankDataSetTableAdapters.ClientsTableAdapter();
            this.tableAdapterManager = new KR_BD.BankDataSetTableAdapters.TableAdapterManager();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.workTextBox = new System.Windows.Forms.TextBox();
            this.adressLivingTextBox = new System.Windows.Forms.TextBox();
            this.bankPlaceTextBox = new System.Windows.Forms.TextBox();
            this.passportdataTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "BankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.bankDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BankTableAdapter = null;
            this.tableAdapterManager.CardTableAdapter = null;
            this.tableAdapterManager.ClientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.CreditTableAdapter = null;
            this.tableAdapterManager.DepositTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.TypeCreditTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = KR_BD.BankDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "FullName", true));
            this.fullNameTextBox.Location = new System.Drawing.Point(147, 107);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(139, 20);
            this.fullNameTextBox.TabIndex = 2;
            // 
            // workTextBox
            // 
            this.workTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Work", true));
            this.workTextBox.Location = new System.Drawing.Point(147, 152);
            this.workTextBox.Name = "workTextBox";
            this.workTextBox.Size = new System.Drawing.Size(139, 20);
            this.workTextBox.TabIndex = 4;
            // 
            // adressLivingTextBox
            // 
            this.adressLivingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "AdressLiving", true));
            this.adressLivingTextBox.Location = new System.Drawing.Point(147, 196);
            this.adressLivingTextBox.Name = "adressLivingTextBox";
            this.adressLivingTextBox.Size = new System.Drawing.Size(139, 20);
            this.adressLivingTextBox.TabIndex = 6;
            // 
            // bankPlaceTextBox
            // 
            this.bankPlaceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "BankPlace", true));
            this.bankPlaceTextBox.Location = new System.Drawing.Point(147, 243);
            this.bankPlaceTextBox.Name = "bankPlaceTextBox";
            this.bankPlaceTextBox.Size = new System.Drawing.Size(139, 20);
            this.bankPlaceTextBox.TabIndex = 8;
            // 
            // passportdataTextBox
            // 
            this.passportdataTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "passportdata", true));
            this.passportdataTextBox.Location = new System.Drawing.Point(147, 284);
            this.passportdataTextBox.Name = "passportdataTextBox";
            this.passportdataTextBox.Size = new System.Drawing.Size(139, 20);
            this.passportdataTextBox.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(9, 284);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(114, 13);
            label1.TabIndex = 19;
            label1.Text = "Паспортные данные:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(49, 243);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(74, 13);
            label2.TabIndex = 18;
            label2.Text = "Адрес банка:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(11, 199);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(112, 13);
            label3.TabIndex = 17;
            label3.Text = "Адресс проживания:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(41, 152);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(82, 13);
            label4.TabIndex = 16;
            label4.Text = "Место работы:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(71, 107);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(37, 13);
            label5.TabIndex = 15;
            label5.Text = "ФИО:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(366, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 36);
            this.button3.TabIndex = 20;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(366, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 35);
            this.button2.TabIndex = 21;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(22, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 24);
            this.label6.TabIndex = 39;
            this.label6.Text = "Личные данные:";
            // 
            // Client_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 364);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(label1);
            this.Controls.Add(label2);
            this.Controls.Add(label3);
            this.Controls.Add(label4);
            this.Controls.Add(label5);
            this.Controls.Add(this.passportdataTextBox);
            this.Controls.Add(this.bankPlaceTextBox);
            this.Controls.Add(this.adressLivingTextBox);
            this.Controls.Add(this.workTextBox);
            this.Controls.Add(this.fullNameTextBox);
            this.Name = "Client_client";
            this.Text = "Client_client";
            this.Load += new System.EventHandler(this.Client_client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BankDataSet bankDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private BankDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private BankDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox workTextBox;
        private System.Windows.Forms.TextBox adressLivingTextBox;
        private System.Windows.Forms.TextBox bankPlaceTextBox;
        private System.Windows.Forms.TextBox passportdataTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
    }
}