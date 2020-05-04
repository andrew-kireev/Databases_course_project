namespace KR_BD
{
    partial class CreditType
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
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label typeCurrencyLabel;
            System.Windows.Forms.Label procentLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditType));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bankDataSet = new KR_BD.BankDataSet();
            this.typeCreditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeCreditTableAdapter = new KR_BD.BankDataSetTableAdapters.TypeCreditTableAdapter();
            this.tableAdapterManager = new KR_BD.BankDataSetTableAdapters.TableAdapterManager();
            this.typeCreditBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.typeCreditBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idCreditTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.typeCurrencyTextBox = new System.Windows.Forms.TextBox();
            this.procentTextBox = new System.Windows.Forms.TextBox();
            idCreditLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            typeCurrencyLabel = new System.Windows.Forms.Label();
            procentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeCreditBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeCreditBindingNavigator)).BeginInit();
            this.typeCreditBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idCreditLabel
            // 
            idCreditLabel.AutoSize = true;
            idCreditLabel.Location = new System.Drawing.Point(119, 147);
            idCreditLabel.Name = "idCreditLabel";
            idCreditLabel.Size = new System.Drawing.Size(64, 13);
            idCreditLabel.TabIndex = 41;
            idCreditLabel.Text = "Id Кредита:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(139, 184);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(44, 13);
            amountLabel.TabIndex = 42;
            amountLabel.Text = "Сумма:";
            // 
            // typeCurrencyLabel
            // 
            typeCurrencyLabel.AutoSize = true;
            typeCurrencyLabel.Location = new System.Drawing.Point(112, 222);
            typeCurrencyLabel.Name = "typeCurrencyLabel";
            typeCurrencyLabel.Size = new System.Drawing.Size(71, 13);
            typeCurrencyLabel.TabIndex = 43;
            typeCurrencyLabel.Text = "Тип валюты:";
            // 
            // procentLabel
            // 
            procentLabel.AutoSize = true;
            procentLabel.Location = new System.Drawing.Point(130, 265);
            procentLabel.Name = "procentLabel";
            procentLabel.Size = new System.Drawing.Size(53, 13);
            procentLabel.TabIndex = 44;
            procentLabel.Text = "Процент:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(410, 274);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 32);
            this.button3.TabIndex = 35;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(410, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 32);
            this.button2.TabIndex = 34;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 32);
            this.button1.TabIndex = 33;
            this.button1.Text = "Отчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 40;
            this.label2.Text = "Тип кредита:";
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "BankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeCreditBindingSource
            // 
            this.typeCreditBindingSource.DataMember = "TypeCredit";
            this.typeCreditBindingSource.DataSource = this.bankDataSet;
            // 
            // typeCreditTableAdapter
            // 
            this.typeCreditTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BankTableAdapter = null;
            this.tableAdapterManager.CardTableAdapter = null;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.CreditTableAdapter = null;
            this.tableAdapterManager.DepositTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.TypeCreditTableAdapter = this.typeCreditTableAdapter;
            this.tableAdapterManager.UpdateOrder = KR_BD.BankDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // typeCreditBindingNavigator
            // 
            this.typeCreditBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.typeCreditBindingNavigator.BindingSource = this.typeCreditBindingSource;
            this.typeCreditBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.typeCreditBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.typeCreditBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.typeCreditBindingNavigatorSaveItem});
            this.typeCreditBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.typeCreditBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.typeCreditBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.typeCreditBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.typeCreditBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.typeCreditBindingNavigator.Name = "typeCreditBindingNavigator";
            this.typeCreditBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.typeCreditBindingNavigator.Size = new System.Drawing.Size(538, 25);
            this.typeCreditBindingNavigator.TabIndex = 41;
            this.typeCreditBindingNavigator.Text = "bindingNavigator1";
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
            // typeCreditBindingNavigatorSaveItem
            // 
            this.typeCreditBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.typeCreditBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("typeCreditBindingNavigatorSaveItem.Image")));
            this.typeCreditBindingNavigatorSaveItem.Name = "typeCreditBindingNavigatorSaveItem";
            this.typeCreditBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.typeCreditBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.typeCreditBindingNavigatorSaveItem.Click += new System.EventHandler(this.typeCreditBindingNavigatorSaveItem_Click);
            // 
            // idCreditTextBox
            // 
            this.idCreditTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeCreditBindingSource, "IdCredit", true));
            this.idCreditTextBox.Location = new System.Drawing.Point(208, 147);
            this.idCreditTextBox.Name = "idCreditTextBox";
            this.idCreditTextBox.Size = new System.Drawing.Size(120, 20);
            this.idCreditTextBox.TabIndex = 42;
            // 
            // amountTextBox
            // 
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeCreditBindingSource, "Amount", true));
            this.amountTextBox.Location = new System.Drawing.Point(208, 181);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(120, 20);
            this.amountTextBox.TabIndex = 43;
            // 
            // typeCurrencyTextBox
            // 
            this.typeCurrencyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeCreditBindingSource, "TypeCurrency", true));
            this.typeCurrencyTextBox.Location = new System.Drawing.Point(208, 222);
            this.typeCurrencyTextBox.Name = "typeCurrencyTextBox";
            this.typeCurrencyTextBox.Size = new System.Drawing.Size(120, 20);
            this.typeCurrencyTextBox.TabIndex = 44;
            // 
            // procentTextBox
            // 
            this.procentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeCreditBindingSource, "Procent", true));
            this.procentTextBox.Location = new System.Drawing.Point(208, 262);
            this.procentTextBox.Name = "procentTextBox";
            this.procentTextBox.Size = new System.Drawing.Size(120, 20);
            this.procentTextBox.TabIndex = 45;
            // 
            // CreditType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 450);
            this.Controls.Add(procentLabel);
            this.Controls.Add(this.procentTextBox);
            this.Controls.Add(typeCurrencyLabel);
            this.Controls.Add(this.typeCurrencyTextBox);
            this.Controls.Add(amountLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(idCreditLabel);
            this.Controls.Add(this.idCreditTextBox);
            this.Controls.Add(this.typeCreditBindingNavigator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "CreditType";
            this.Text = "Тип кредита";
            this.Load += new System.EventHandler(this.CreditType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeCreditBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeCreditBindingNavigator)).EndInit();
            this.typeCreditBindingNavigator.ResumeLayout(false);
            this.typeCreditBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private BankDataSet bankDataSet;
        private System.Windows.Forms.BindingSource typeCreditBindingSource;
        private BankDataSetTableAdapters.TypeCreditTableAdapter typeCreditTableAdapter;
        private BankDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator typeCreditBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton typeCreditBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idCreditTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox typeCurrencyTextBox;
        private System.Windows.Forms.TextBox procentTextBox;
    }
}