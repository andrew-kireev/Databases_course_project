namespace KR_BD
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label idClientLabel;
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label workLabel;
            System.Windows.Forms.Label adressLivingLabel;
            System.Windows.Forms.Label bankPlaceLabel;
            System.Windows.Forms.Label passportdataLabel;
            System.Windows.Forms.Label idBankLabel;
            this.bankDataSet = new KR_BD.BankDataSet();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new KR_BD.BankDataSetTableAdapters.ClientsTableAdapter();
            this.tableAdapterManager = new KR_BD.BankDataSetTableAdapters.TableAdapterManager();
            this.clientsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.clientsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idClientTextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.workTextBox = new System.Windows.Forms.TextBox();
            this.adressLivingTextBox = new System.Windows.Forms.TextBox();
            this.bankPlaceTextBox = new System.Windows.Forms.TextBox();
            this.passportdataTextBox = new System.Windows.Forms.TextBox();
            this.idBankTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.depositBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depositTableAdapter = new KR_BD.BankDataSetTableAdapters.DepositTableAdapter();
            this.depositDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idClientLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            workLabel = new System.Windows.Forms.Label();
            adressLivingLabel = new System.Windows.Forms.Label();
            bankPlaceLabel = new System.Windows.Forms.Label();
            passportdataLabel = new System.Windows.Forms.Label();
            idBankLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingNavigator)).BeginInit();
            this.clientsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depositBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositDataGridView)).BeginInit();
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
            this.tableAdapterManager.DepositTableAdapter = this.depositTableAdapter;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.TypeCreditTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = KR_BD.BankDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientsBindingNavigator
            // 
            this.clientsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clientsBindingNavigator.BindingSource = this.clientsBindingSource;
            this.clientsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clientsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.clientsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.clientsBindingNavigatorSaveItem});
            this.clientsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clientsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clientsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clientsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clientsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clientsBindingNavigator.Name = "clientsBindingNavigator";
            this.clientsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clientsBindingNavigator.Size = new System.Drawing.Size(611, 25);
            this.clientsBindingNavigator.TabIndex = 0;
            this.clientsBindingNavigator.Text = "bindingNavigator1";
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
            // clientsBindingNavigatorSaveItem
            // 
            this.clientsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clientsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clientsBindingNavigatorSaveItem.Image")));
            this.clientsBindingNavigatorSaveItem.Name = "clientsBindingNavigatorSaveItem";
            this.clientsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.clientsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.clientsBindingNavigatorSaveItem.Click += new System.EventHandler(this.clientsBindingNavigatorSaveItem_Click);
            // 
            // idClientLabel
            // 
            idClientLabel.AutoSize = true;
            idClientLabel.Location = new System.Drawing.Point(31, 60);
            idClientLabel.Name = "idClientLabel";
            idClientLabel.Size = new System.Drawing.Size(64, 13);
            idClientLabel.TabIndex = 1;
            idClientLabel.Text = "Id Клиента:";
            idClientLabel.Click += new System.EventHandler(this.idClientLabel_Click);
            // 
            // idClientTextBox
            // 
            this.idClientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "IdClient", true));
            this.idClientTextBox.Location = new System.Drawing.Point(159, 57);
            this.idClientTextBox.Name = "idClientTextBox";
            this.idClientTextBox.Size = new System.Drawing.Size(136, 20);
            this.idClientTextBox.TabIndex = 2;
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(34, 101);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(37, 13);
            fullNameLabel.TabIndex = 3;
            fullNameLabel.Text = "ФИО:";
            fullNameLabel.Click += new System.EventHandler(this.fullNameLabel_Click);
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "FullName", true));
            this.fullNameTextBox.Location = new System.Drawing.Point(159, 98);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(136, 20);
            this.fullNameTextBox.TabIndex = 4;
            // 
            // workLabel
            // 
            workLabel.AutoSize = true;
            workLabel.Location = new System.Drawing.Point(34, 137);
            workLabel.Name = "workLabel";
            workLabel.Size = new System.Drawing.Size(82, 13);
            workLabel.TabIndex = 5;
            workLabel.Text = "Место работы:";
            // 
            // workTextBox
            // 
            this.workTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Work", true));
            this.workTextBox.Location = new System.Drawing.Point(159, 137);
            this.workTextBox.Name = "workTextBox";
            this.workTextBox.Size = new System.Drawing.Size(136, 20);
            this.workTextBox.TabIndex = 6;
            // 
            // adressLivingLabel
            // 
            adressLivingLabel.AutoSize = true;
            adressLivingLabel.Location = new System.Drawing.Point(31, 173);
            adressLivingLabel.Name = "adressLivingLabel";
            adressLivingLabel.Size = new System.Drawing.Size(112, 13);
            adressLivingLabel.TabIndex = 7;
            adressLivingLabel.Text = "Адресс проживания:";
            // 
            // adressLivingTextBox
            // 
            this.adressLivingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "AdressLiving", true));
            this.adressLivingTextBox.Location = new System.Drawing.Point(159, 173);
            this.adressLivingTextBox.Name = "adressLivingTextBox";
            this.adressLivingTextBox.Size = new System.Drawing.Size(136, 20);
            this.adressLivingTextBox.TabIndex = 8;
            // 
            // bankPlaceLabel
            // 
            bankPlaceLabel.AutoSize = true;
            bankPlaceLabel.Location = new System.Drawing.Point(31, 212);
            bankPlaceLabel.Name = "bankPlaceLabel";
            bankPlaceLabel.Size = new System.Drawing.Size(74, 13);
            bankPlaceLabel.TabIndex = 9;
            bankPlaceLabel.Text = "Адрес банка:";
            bankPlaceLabel.Click += new System.EventHandler(this.bankPlaceLabel_Click);
            // 
            // bankPlaceTextBox
            // 
            this.bankPlaceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "BankPlace", true));
            this.bankPlaceTextBox.Location = new System.Drawing.Point(159, 209);
            this.bankPlaceTextBox.Name = "bankPlaceTextBox";
            this.bankPlaceTextBox.Size = new System.Drawing.Size(136, 20);
            this.bankPlaceTextBox.TabIndex = 10;
            // 
            // passportdataLabel
            // 
            passportdataLabel.AutoSize = true;
            passportdataLabel.Location = new System.Drawing.Point(31, 247);
            passportdataLabel.Name = "passportdataLabel";
            passportdataLabel.Size = new System.Drawing.Size(114, 13);
            passportdataLabel.TabIndex = 11;
            passportdataLabel.Text = "Паспортные данные:";
            // 
            // passportdataTextBox
            // 
            this.passportdataTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "passportdata", true));
            this.passportdataTextBox.Location = new System.Drawing.Point(159, 244);
            this.passportdataTextBox.Name = "passportdataTextBox";
            this.passportdataTextBox.Size = new System.Drawing.Size(136, 20);
            this.passportdataTextBox.TabIndex = 12;
            // 
            // idBankLabel
            // 
            idBankLabel.AutoSize = true;
            idBankLabel.Location = new System.Drawing.Point(31, 281);
            idBankLabel.Name = "idBankLabel";
            idBankLabel.Size = new System.Drawing.Size(53, 13);
            idBankLabel.TabIndex = 13;
            idBankLabel.Text = "Id Банка:";
            // 
            // idBankTextBox
            // 
            this.idBankTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "IdBank", true));
            this.idBankTextBox.Location = new System.Drawing.Point(159, 281);
            this.idBankTextBox.Name = "idBankTextBox";
            this.idBankTextBox.Size = new System.Drawing.Size(136, 20);
            this.idBankTextBox.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Отчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(399, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(399, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // depositBindingSource
            // 
            this.depositBindingSource.DataMember = "FR_Deposit_Client";
            this.depositBindingSource.DataSource = this.clientsBindingSource;
            // 
            // depositTableAdapter
            // 
            this.depositTableAdapter.ClearBeforeFill = true;
            // 
            // depositDataGridView
            // 
            this.depositDataGridView.AutoGenerateColumns = false;
            this.depositDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.depositDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.depositDataGridView.DataSource = this.depositBindingSource;
            this.depositDataGridView.Location = new System.Drawing.Point(0, 352);
            this.depositDataGridView.Name = "depositDataGridView";
            this.depositDataGridView.Size = new System.Drawing.Size(610, 111);
            this.depositDataGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdDeposit";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdDeposit";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdClient";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdClient";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DepostiInformation";
            this.dataGridViewTextBoxColumn3.HeaderText = "DepostiInformation";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BeginData";
            this.dataGridViewTextBoxColumn4.HeaderText = "BeginData";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "EndDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "EndDate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn6.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Term";
            this.dataGridViewTextBoxColumn7.HeaderText = "Term";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Procent";
            this.dataGridViewTextBoxColumn8.HeaderText = "Procent";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 465);
            this.Controls.Add(this.depositDataGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(idBankLabel);
            this.Controls.Add(this.idBankTextBox);
            this.Controls.Add(passportdataLabel);
            this.Controls.Add(this.passportdataTextBox);
            this.Controls.Add(bankPlaceLabel);
            this.Controls.Add(this.bankPlaceTextBox);
            this.Controls.Add(adressLivingLabel);
            this.Controls.Add(this.adressLivingTextBox);
            this.Controls.Add(workLabel);
            this.Controls.Add(this.workTextBox);
            this.Controls.Add(fullNameLabel);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(idClientLabel);
            this.Controls.Add(this.idClientTextBox);
            this.Controls.Add(this.clientsBindingNavigator);
            this.Name = "Form1";
            this.Text = "Клиент";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingNavigator)).EndInit();
            this.clientsBindingNavigator.ResumeLayout(false);
            this.clientsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depositBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BankDataSet bankDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private BankDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private BankDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clientsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton clientsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idClientTextBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox workTextBox;
        private System.Windows.Forms.TextBox adressLivingTextBox;
        private System.Windows.Forms.TextBox bankPlaceTextBox;
        private System.Windows.Forms.TextBox passportdataTextBox;
        private System.Windows.Forms.TextBox idBankTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private BankDataSetTableAdapters.DepositTableAdapter depositTableAdapter;
        private System.Windows.Forms.BindingSource depositBindingSource;
        private System.Windows.Forms.DataGridView depositDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}