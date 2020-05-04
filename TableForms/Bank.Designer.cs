namespace KR_BD
{
    partial class Bank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bank));
            System.Windows.Forms.Label idBankLabel;
            System.Windows.Forms.Label employeesLabel;
            System.Windows.Forms.Label bankInfoLabel;
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bankDataSet = new KR_BD.BankDataSet();
            this.bankBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankTableAdapter = new KR_BD.BankDataSetTableAdapters.BankTableAdapter();
            this.tableAdapterManager = new KR_BD.BankDataSetTableAdapters.TableAdapterManager();
            this.bankBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bankBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idBankTextBox = new System.Windows.Forms.TextBox();
            this.employeesTextBox = new System.Windows.Forms.TextBox();
            this.bankInfoTextBox = new System.Windows.Forms.TextBox();
            this.clientsTableAdapter = new KR_BD.BankDataSetTableAdapters.ClientsTableAdapter();
            this.clientsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            idBankLabel = new System.Windows.Forms.Label();
            employeesLabel = new System.Windows.Forms.Label();
            bankInfoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankBindingNavigator)).BeginInit();
            this.bankBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(352, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 32);
            this.button3.TabIndex = 20;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(352, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 32);
            this.button2.TabIndex = 19;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 32);
            this.button1.TabIndex = 18;
            this.button1.Text = "Отчет";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "BankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankBindingSource
            // 
            this.bankBindingSource.DataMember = "Bank";
            this.bankBindingSource.DataSource = this.bankDataSet;
            // 
            // bankTableAdapter
            // 
            this.bankTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BankTableAdapter = this.bankTableAdapter;
            this.tableAdapterManager.CardTableAdapter = null;
            this.tableAdapterManager.ClientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.CreditTableAdapter = null;
            this.tableAdapterManager.DepositTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.TypeCreditTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = KR_BD.BankDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bankBindingNavigator
            // 
            this.bankBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bankBindingNavigator.BindingSource = this.bankBindingSource;
            this.bankBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bankBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bankBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bankBindingNavigatorSaveItem});
            this.bankBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bankBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bankBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bankBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bankBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bankBindingNavigator.Name = "bankBindingNavigator";
            this.bankBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bankBindingNavigator.Size = new System.Drawing.Size(550, 25);
            this.bankBindingNavigator.TabIndex = 21;
            this.bankBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bankBindingNavigatorSaveItem
            // 
            this.bankBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bankBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bankBindingNavigatorSaveItem.Image")));
            this.bankBindingNavigatorSaveItem.Name = "bankBindingNavigatorSaveItem";
            this.bankBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.bankBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.bankBindingNavigatorSaveItem.Click += new System.EventHandler(this.bankBindingNavigatorSaveItem_Click);
            // 
            // idBankLabel
            // 
            idBankLabel.AutoSize = true;
            idBankLabel.Location = new System.Drawing.Point(120, 156);
            idBankLabel.Name = "idBankLabel";
            idBankLabel.Size = new System.Drawing.Size(47, 13);
            idBankLabel.TabIndex = 21;
            idBankLabel.Text = "Id Банк:";
            // 
            // idBankTextBox
            // 
            this.idBankTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankBindingSource, "IdBank", true));
            this.idBankTextBox.Location = new System.Drawing.Point(173, 153);
            this.idBankTextBox.Name = "idBankTextBox";
            this.idBankTextBox.Size = new System.Drawing.Size(100, 20);
            this.idBankTextBox.TabIndex = 22;
            // 
            // employeesLabel
            // 
            employeesLabel.AutoSize = true;
            employeesLabel.Location = new System.Drawing.Point(31, 200);
            employeesLabel.Name = "employeesLabel";
            employeesLabel.Size = new System.Drawing.Size(136, 13);
            employeesLabel.TabIndex = 23;
            employeesLabel.Text = "Количество сотрудников:";
            // 
            // employeesTextBox
            // 
            this.employeesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankBindingSource, "employees", true));
            this.employeesTextBox.Location = new System.Drawing.Point(173, 200);
            this.employeesTextBox.Name = "employeesTextBox";
            this.employeesTextBox.Size = new System.Drawing.Size(100, 20);
            this.employeesTextBox.TabIndex = 24;
            // 
            // bankInfoLabel
            // 
            bankInfoLabel.AutoSize = true;
            bankInfoLabel.Location = new System.Drawing.Point(87, 244);
            bankInfoLabel.Name = "bankInfoLabel";
            bankInfoLabel.Size = new System.Drawing.Size(80, 13);
            bankInfoLabel.TabIndex = 24;
            bankInfoLabel.Text = "Адресс банка:";
            // 
            // bankInfoTextBox
            // 
            this.bankInfoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankBindingSource, "BankInfo", true));
            this.bankInfoTextBox.Location = new System.Drawing.Point(173, 244);
            this.bankInfoTextBox.Name = "bankInfoTextBox";
            this.bankInfoTextBox.Size = new System.Drawing.Size(100, 20);
            this.bankInfoTextBox.TabIndex = 25;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // clientsDataGridView
            // 
            this.clientsDataGridView.AutoGenerateColumns = false;
            this.clientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6});
            this.clientsDataGridView.DataSource = this.clientsBindingSource;
            this.clientsDataGridView.Location = new System.Drawing.Point(0, 372);
            this.clientsDataGridView.Name = "clientsDataGridView";
            this.clientsDataGridView.Size = new System.Drawing.Size(545, 140);
            this.clientsDataGridView.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdClient";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdClient";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FullName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Work";
            this.dataGridViewTextBoxColumn3.HeaderText = "Work";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AdressLiving";
            this.dataGridViewTextBoxColumn4.HeaderText = "AdressLiving";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "passportdata";
            this.dataGridViewTextBoxColumn6.HeaderText = "passportdata";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "FR_Clients_Bank";
            this.clientsBindingSource.DataSource = this.bankBindingSource;
            // 
            // Bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 527);
            this.Controls.Add(this.clientsDataGridView);
            this.Controls.Add(bankInfoLabel);
            this.Controls.Add(this.bankInfoTextBox);
            this.Controls.Add(employeesLabel);
            this.Controls.Add(this.employeesTextBox);
            this.Controls.Add(idBankLabel);
            this.Controls.Add(this.idBankTextBox);
            this.Controls.Add(this.bankBindingNavigator);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Bank";
            this.Text = "Bank";
            this.Load += new System.EventHandler(this.Bank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankBindingNavigator)).EndInit();
            this.bankBindingNavigator.ResumeLayout(false);
            this.bankBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private BankDataSet bankDataSet;
        private System.Windows.Forms.BindingSource bankBindingSource;
        private BankDataSetTableAdapters.BankTableAdapter bankTableAdapter;
        private BankDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bankBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bankBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idBankTextBox;
        private System.Windows.Forms.TextBox employeesTextBox;
        private System.Windows.Forms.TextBox bankInfoTextBox;
        private BankDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private System.Windows.Forms.DataGridView clientsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}