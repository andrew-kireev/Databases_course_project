namespace KR_BD
{
    partial class Credit
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
            System.Windows.Forms.Label idCreditLabel;
            System.Windows.Forms.Label idClientLabel;
            System.Windows.Forms.Label beginDataLabel;
            System.Windows.Forms.Label endDateLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label termLabel;
            System.Windows.Forms.Label typeCurrencyLabel;
            System.Windows.Forms.Label procentLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Credit));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bankDataSet = new KR_BD.BankDataSet();
            this.creditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.creditTableAdapter = new KR_BD.BankDataSetTableAdapters.CreditTableAdapter();
            this.tableAdapterManager = new KR_BD.BankDataSetTableAdapters.TableAdapterManager();
            this.typeCreditTableAdapter = new KR_BD.BankDataSetTableAdapters.TypeCreditTableAdapter();
            this.creditBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.creditBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idCreditTextBox = new System.Windows.Forms.TextBox();
            this.idClientTextBox = new System.Windows.Forms.TextBox();
            this.beginDataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.termDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.typeCurrencyTextBox = new System.Windows.Forms.TextBox();
            this.typeCreditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.procentTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            idCreditLabel = new System.Windows.Forms.Label();
            idClientLabel = new System.Windows.Forms.Label();
            beginDataLabel = new System.Windows.Forms.Label();
            endDateLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            termLabel = new System.Windows.Forms.Label();
            typeCurrencyLabel = new System.Windows.Forms.Label();
            procentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditBindingNavigator)).BeginInit();
            this.creditBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeCreditBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idCreditLabel
            // 
            idCreditLabel.AutoSize = true;
            idCreditLabel.Location = new System.Drawing.Point(136, 85);
            idCreditLabel.Name = "idCreditLabel";
            idCreditLabel.Size = new System.Drawing.Size(64, 13);
            idCreditLabel.TabIndex = 27;
            idCreditLabel.Text = "Id Кредита:";
            // 
            // idClientLabel
            // 
            idClientLabel.AutoSize = true;
            idClientLabel.Location = new System.Drawing.Point(136, 123);
            idClientLabel.Name = "idClientLabel";
            idClientLabel.Size = new System.Drawing.Size(64, 13);
            idClientLabel.TabIndex = 28;
            idClientLabel.Text = "Id Клиента:";
            // 
            // beginDataLabel
            // 
            beginDataLabel.AutoSize = true;
            beginDataLabel.Location = new System.Drawing.Point(113, 159);
            beginDataLabel.Name = "beginDataLabel";
            beginDataLabel.Size = new System.Drawing.Size(87, 13);
            beginDataLabel.TabIndex = 29;
            beginDataLabel.Text = "Дата открытия:";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Location = new System.Drawing.Point(108, 208);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new System.Drawing.Size(92, 13);
            endDateLabel.TabIndex = 30;
            endDateLabel.Text = "Дата окончания:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(156, 242);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(44, 13);
            amountLabel.TabIndex = 31;
            amountLabel.Text = "Сумма:";
            // 
            // termLabel
            // 
            termLabel.AutoSize = true;
            termLabel.Location = new System.Drawing.Point(117, 291);
            termLabel.Name = "termLabel";
            termLabel.Size = new System.Drawing.Size(83, 13);
            termLabel.TabIndex = 32;
            termLabel.Text = "Длительность:";
            // 
            // typeCurrencyLabel
            // 
            typeCurrencyLabel.AutoSize = true;
            typeCurrencyLabel.Location = new System.Drawing.Point(46, 384);
            typeCurrencyLabel.Name = "typeCurrencyLabel";
            typeCurrencyLabel.Size = new System.Drawing.Size(79, 13);
            typeCurrencyLabel.TabIndex = 33;
            typeCurrencyLabel.Text = "Type Currency:";
            // 
            // procentLabel
            // 
            procentLabel.AutoSize = true;
            procentLabel.Location = new System.Drawing.Point(77, 421);
            procentLabel.Name = "procentLabel";
            procentLabel.Size = new System.Drawing.Size(47, 13);
            procentLabel.TabIndex = 34;
            procentLabel.Text = "Procent:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(433, 260);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 32);
            this.button3.TabIndex = 26;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(433, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 32);
            this.button2.TabIndex = 25;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 32);
            this.button1.TabIndex = 24;
            this.button1.Text = "Отчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "BankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // creditBindingSource
            // 
            this.creditBindingSource.DataMember = "Credit";
            this.creditBindingSource.DataSource = this.bankDataSet;
            // 
            // creditTableAdapter
            // 
            this.creditTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BankTableAdapter = null;
            this.tableAdapterManager.CardTableAdapter = null;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.CreditTableAdapter = this.creditTableAdapter;
            this.tableAdapterManager.DepositTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.TypeCreditTableAdapter = this.typeCreditTableAdapter;
            this.tableAdapterManager.UpdateOrder = KR_BD.BankDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // typeCreditTableAdapter
            // 
            this.typeCreditTableAdapter.ClearBeforeFill = true;
            // 
            // creditBindingNavigator
            // 
            this.creditBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.creditBindingNavigator.BindingSource = this.creditBindingSource;
            this.creditBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.creditBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.creditBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.creditBindingNavigatorSaveItem});
            this.creditBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.creditBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.creditBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.creditBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.creditBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.creditBindingNavigator.Name = "creditBindingNavigator";
            this.creditBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.creditBindingNavigator.Size = new System.Drawing.Size(558, 25);
            this.creditBindingNavigator.TabIndex = 27;
            this.creditBindingNavigator.Text = "bindingNavigator1";
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
            // creditBindingNavigatorSaveItem
            // 
            this.creditBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.creditBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("creditBindingNavigatorSaveItem.Image")));
            this.creditBindingNavigatorSaveItem.Name = "creditBindingNavigatorSaveItem";
            this.creditBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.creditBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.creditBindingNavigatorSaveItem.Click += new System.EventHandler(this.creditBindingNavigatorSaveItem_Click);
            // 
            // idCreditTextBox
            // 
            this.idCreditTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creditBindingSource, "IdCredit", true));
            this.idCreditTextBox.Location = new System.Drawing.Point(216, 85);
            this.idCreditTextBox.Name = "idCreditTextBox";
            this.idCreditTextBox.Size = new System.Drawing.Size(145, 20);
            this.idCreditTextBox.TabIndex = 28;
            this.idCreditTextBox.TextChanged += new System.EventHandler(this.idCreditTextBox_TextChanged);
            // 
            // idClientTextBox
            // 
            this.idClientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creditBindingSource, "IdClient", true));
            this.idClientTextBox.Location = new System.Drawing.Point(216, 123);
            this.idClientTextBox.Name = "idClientTextBox";
            this.idClientTextBox.Size = new System.Drawing.Size(145, 20);
            this.idClientTextBox.TabIndex = 29;
            // 
            // beginDataDateTimePicker
            // 
            this.beginDataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.creditBindingSource, "BeginData", true));
            this.beginDataDateTimePicker.Location = new System.Drawing.Point(216, 159);
            this.beginDataDateTimePicker.Name = "beginDataDateTimePicker";
            this.beginDataDateTimePicker.Size = new System.Drawing.Size(142, 20);
            this.beginDataDateTimePicker.TabIndex = 30;
            // 
            // endDateDateTimePicker
            // 
            this.endDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.creditBindingSource, "EndDate", true));
            this.endDateDateTimePicker.Location = new System.Drawing.Point(216, 201);
            this.endDateDateTimePicker.Name = "endDateDateTimePicker";
            this.endDateDateTimePicker.Size = new System.Drawing.Size(140, 20);
            this.endDateDateTimePicker.TabIndex = 31;
            // 
            // amountTextBox
            // 
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.creditBindingSource, "Amount", true));
            this.amountTextBox.Location = new System.Drawing.Point(216, 242);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(140, 20);
            this.amountTextBox.TabIndex = 32;
            // 
            // termDateTimePicker
            // 
            this.termDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.creditBindingSource, "Term", true));
            this.termDateTimePicker.Location = new System.Drawing.Point(216, 291);
            this.termDateTimePicker.Name = "termDateTimePicker";
            this.termDateTimePicker.Size = new System.Drawing.Size(140, 20);
            this.termDateTimePicker.TabIndex = 33;
            // 
            // typeCurrencyTextBox
            // 
            this.typeCurrencyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeCreditBindingSource, "TypeCurrency", true));
            this.typeCurrencyTextBox.Location = new System.Drawing.Point(131, 381);
            this.typeCurrencyTextBox.Name = "typeCurrencyTextBox";
            this.typeCurrencyTextBox.Size = new System.Drawing.Size(100, 20);
            this.typeCurrencyTextBox.TabIndex = 34;
            // 
            // typeCreditBindingSource
            // 
            this.typeCreditBindingSource.DataMember = "FR_TypeCredit_Credit";
            this.typeCreditBindingSource.DataSource = this.creditBindingSource;
            // 
            // procentTextBox
            // 
            this.procentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeCreditBindingSource, "Procent", true));
            this.procentTextBox.Location = new System.Drawing.Point(130, 418);
            this.procentTextBox.Name = "procentTextBox";
            this.procentTextBox.Size = new System.Drawing.Size(100, 20);
            this.procentTextBox.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Тип кредита:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Информация о кредите:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Credit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 459);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(procentLabel);
            this.Controls.Add(this.procentTextBox);
            this.Controls.Add(typeCurrencyLabel);
            this.Controls.Add(this.typeCurrencyTextBox);
            this.Controls.Add(termLabel);
            this.Controls.Add(this.termDateTimePicker);
            this.Controls.Add(amountLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(endDateLabel);
            this.Controls.Add(this.endDateDateTimePicker);
            this.Controls.Add(beginDataLabel);
            this.Controls.Add(this.beginDataDateTimePicker);
            this.Controls.Add(idClientLabel);
            this.Controls.Add(this.idClientTextBox);
            this.Controls.Add(idCreditLabel);
            this.Controls.Add(this.idCreditTextBox);
            this.Controls.Add(this.creditBindingNavigator);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Credit";
            this.Text = "Credit";
            this.Load += new System.EventHandler(this.Credit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditBindingNavigator)).EndInit();
            this.creditBindingNavigator.ResumeLayout(false);
            this.creditBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeCreditBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private BankDataSet bankDataSet;
        private System.Windows.Forms.BindingSource creditBindingSource;
        private BankDataSetTableAdapters.CreditTableAdapter creditTableAdapter;
        private BankDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator creditBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton creditBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idCreditTextBox;
        private System.Windows.Forms.TextBox idClientTextBox;
        private System.Windows.Forms.DateTimePicker beginDataDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateDateTimePicker;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.DateTimePicker termDateTimePicker;
        private BankDataSetTableAdapters.TypeCreditTableAdapter typeCreditTableAdapter;
        private System.Windows.Forms.BindingSource typeCreditBindingSource;
        private System.Windows.Forms.TextBox typeCurrencyTextBox;
        private System.Windows.Forms.TextBox procentTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}