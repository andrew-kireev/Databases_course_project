namespace KR_BD
{
    partial class Deposit
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
            System.Windows.Forms.Label idDepositLabel;
            System.Windows.Forms.Label idClientLabel;
            System.Windows.Forms.Label depostiInformationLabel;
            System.Windows.Forms.Label beginDataLabel;
            System.Windows.Forms.Label endDateLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label procentLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposit));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bankDataSet = new KR_BD.BankDataSet();
            this.depositBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depositTableAdapter = new KR_BD.BankDataSetTableAdapters.DepositTableAdapter();
            this.tableAdapterManager = new KR_BD.BankDataSetTableAdapters.TableAdapterManager();
            this.depositBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.depositBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idDepositTextBox = new System.Windows.Forms.TextBox();
            this.idClientTextBox = new System.Windows.Forms.TextBox();
            this.depostiInformationTextBox = new System.Windows.Forms.TextBox();
            this.beginDataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.procentTextBox = new System.Windows.Forms.TextBox();
            idDepositLabel = new System.Windows.Forms.Label();
            idClientLabel = new System.Windows.Forms.Label();
            depostiInformationLabel = new System.Windows.Forms.Label();
            beginDataLabel = new System.Windows.Forms.Label();
            endDateLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            procentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositBindingNavigator)).BeginInit();
            this.depositBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idDepositLabel
            // 
            idDepositLabel.AutoSize = true;
            idDepositLabel.Location = new System.Drawing.Point(121, 63);
            idDepositLabel.Name = "idDepositLabel";
            idDepositLabel.Size = new System.Drawing.Size(59, 13);
            idDepositLabel.TabIndex = 24;
            idDepositLabel.Text = "Id Вклада:";
            // 
            // idClientLabel
            // 
            idClientLabel.AutoSize = true;
            idClientLabel.Location = new System.Drawing.Point(116, 110);
            idClientLabel.Name = "idClientLabel";
            idClientLabel.Size = new System.Drawing.Size(64, 13);
            idClientLabel.TabIndex = 25;
            idClientLabel.Text = "Id Клиента:";
            // 
            // depostiInformationLabel
            // 
            depostiInformationLabel.AutoSize = true;
            depostiInformationLabel.Location = new System.Drawing.Point(51, 151);
            depostiInformationLabel.Name = "depostiInformationLabel";
            depostiInformationLabel.Size = new System.Drawing.Size(124, 13);
            depostiInformationLabel.TabIndex = 26;
            depostiInformationLabel.Text = "Информация о вкладе:";
            // 
            // beginDataLabel
            // 
            beginDataLabel.AutoSize = true;
            beginDataLabel.Location = new System.Drawing.Point(82, 190);
            beginDataLabel.Name = "beginDataLabel";
            beginDataLabel.Size = new System.Drawing.Size(87, 13);
            beginDataLabel.TabIndex = 27;
            beginDataLabel.Text = "Дата открытия:";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Location = new System.Drawing.Point(68, 232);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new System.Drawing.Size(92, 13);
            endDateLabel.TabIndex = 28;
            endDateLabel.Text = "Дата окончания:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(116, 278);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(44, 13);
            amountLabel.TabIndex = 29;
            amountLabel.Text = "Сумма:";
            // 
            // procentLabel
            // 
            procentLabel.AutoSize = true;
            procentLabel.Location = new System.Drawing.Point(116, 334);
            procentLabel.Name = "procentLabel";
            procentLabel.Size = new System.Drawing.Size(53, 13);
            procentLabel.TabIndex = 30;
            procentLabel.Text = "Процент:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(407, 248);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 32);
            this.button3.TabIndex = 23;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(407, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 32);
            this.button2.TabIndex = 22;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 32);
            this.button1.TabIndex = 21;
            this.button1.Text = "Отчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "BankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // depositBindingSource
            // 
            this.depositBindingSource.DataMember = "Deposit";
            this.depositBindingSource.DataSource = this.bankDataSet;
            // 
            // depositTableAdapter
            // 
            this.depositTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BankTableAdapter = null;
            this.tableAdapterManager.CardTableAdapter = null;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.CreditTableAdapter = null;
            this.tableAdapterManager.DepositTableAdapter = this.depositTableAdapter;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.TypeCreditTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = KR_BD.BankDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // depositBindingNavigator
            // 
            this.depositBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.depositBindingNavigator.BindingSource = this.depositBindingSource;
            this.depositBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.depositBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.depositBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.depositBindingNavigatorSaveItem});
            this.depositBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.depositBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.depositBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.depositBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.depositBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.depositBindingNavigator.Name = "depositBindingNavigator";
            this.depositBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.depositBindingNavigator.Size = new System.Drawing.Size(516, 25);
            this.depositBindingNavigator.TabIndex = 24;
            this.depositBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // depositBindingNavigatorSaveItem
            // 
            this.depositBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.depositBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("depositBindingNavigatorSaveItem.Image")));
            this.depositBindingNavigatorSaveItem.Name = "depositBindingNavigatorSaveItem";
            this.depositBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.depositBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.depositBindingNavigatorSaveItem.Click += new System.EventHandler(this.depositBindingNavigatorSaveItem_Click);
            // 
            // idDepositTextBox
            // 
            this.idDepositTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.depositBindingSource, "IdDeposit", true));
            this.idDepositTextBox.Location = new System.Drawing.Point(204, 63);
            this.idDepositTextBox.Name = "idDepositTextBox";
            this.idDepositTextBox.Size = new System.Drawing.Size(139, 20);
            this.idDepositTextBox.TabIndex = 25;
            // 
            // idClientTextBox
            // 
            this.idClientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.depositBindingSource, "IdClient", true));
            this.idClientTextBox.Location = new System.Drawing.Point(204, 107);
            this.idClientTextBox.Name = "idClientTextBox";
            this.idClientTextBox.Size = new System.Drawing.Size(139, 20);
            this.idClientTextBox.TabIndex = 26;
            // 
            // depostiInformationTextBox
            // 
            this.depostiInformationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.depositBindingSource, "DepostiInformation", true));
            this.depostiInformationTextBox.Location = new System.Drawing.Point(204, 151);
            this.depostiInformationTextBox.Name = "depostiInformationTextBox";
            this.depostiInformationTextBox.Size = new System.Drawing.Size(139, 20);
            this.depostiInformationTextBox.TabIndex = 27;
            // 
            // beginDataDateTimePicker
            // 
            this.beginDataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.depositBindingSource, "BeginData", true));
            this.beginDataDateTimePicker.Location = new System.Drawing.Point(204, 190);
            this.beginDataDateTimePicker.Name = "beginDataDateTimePicker";
            this.beginDataDateTimePicker.Size = new System.Drawing.Size(139, 20);
            this.beginDataDateTimePicker.TabIndex = 28;
            // 
            // endDateDateTimePicker
            // 
            this.endDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.depositBindingSource, "EndDate", true));
            this.endDateDateTimePicker.Location = new System.Drawing.Point(204, 232);
            this.endDateDateTimePicker.Name = "endDateDateTimePicker";
            this.endDateDateTimePicker.Size = new System.Drawing.Size(139, 20);
            this.endDateDateTimePicker.TabIndex = 29;
            // 
            // amountTextBox
            // 
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.depositBindingSource, "Amount", true));
            this.amountTextBox.Location = new System.Drawing.Point(204, 278);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(139, 20);
            this.amountTextBox.TabIndex = 30;
            // 
            // procentTextBox
            // 
            this.procentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.depositBindingSource, "Procent", true));
            this.procentTextBox.Location = new System.Drawing.Point(204, 334);
            this.procentTextBox.Name = "procentTextBox";
            this.procentTextBox.Size = new System.Drawing.Size(139, 20);
            this.procentTextBox.TabIndex = 31;
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 450);
            this.Controls.Add(procentLabel);
            this.Controls.Add(this.procentTextBox);
            this.Controls.Add(amountLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(endDateLabel);
            this.Controls.Add(this.endDateDateTimePicker);
            this.Controls.Add(beginDataLabel);
            this.Controls.Add(this.beginDataDateTimePicker);
            this.Controls.Add(depostiInformationLabel);
            this.Controls.Add(this.depostiInformationTextBox);
            this.Controls.Add(idClientLabel);
            this.Controls.Add(this.idClientTextBox);
            this.Controls.Add(idDepositLabel);
            this.Controls.Add(this.idDepositTextBox);
            this.Controls.Add(this.depositBindingNavigator);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Deposit";
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.Deposit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositBindingNavigator)).EndInit();
            this.depositBindingNavigator.ResumeLayout(false);
            this.depositBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private BankDataSet bankDataSet;
        private System.Windows.Forms.BindingSource depositBindingSource;
        private BankDataSetTableAdapters.DepositTableAdapter depositTableAdapter;
        private BankDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator depositBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton depositBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idDepositTextBox;
        private System.Windows.Forms.TextBox idClientTextBox;
        private System.Windows.Forms.TextBox depostiInformationTextBox;
        private System.Windows.Forms.DateTimePicker beginDataDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateDateTimePicker;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox procentTextBox;
    }
}