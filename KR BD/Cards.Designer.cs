namespace KR_BD
{
    partial class Cards
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
            System.Windows.Forms.Label idCardLabel;
            System.Windows.Forms.Label idClientLabel;
            System.Windows.Forms.Label cardiInformationLabel;
            System.Windows.Forms.Label beginDataLabel;
            System.Windows.Forms.Label endDateLabel;
            System.Windows.Forms.Label debetLabel;
            System.Windows.Forms.Label creditLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cards));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bankDataSet = new KR_BD.BankDataSet();
            this.cardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardTableAdapter = new KR_BD.BankDataSetTableAdapters.CardTableAdapter();
            this.tableAdapterManager = new KR_BD.BankDataSetTableAdapters.TableAdapterManager();
            this.cardBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cardBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idCardTextBox = new System.Windows.Forms.TextBox();
            this.idClientTextBox = new System.Windows.Forms.TextBox();
            this.cardiInformationTextBox = new System.Windows.Forms.TextBox();
            this.beginDataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.debetTextBox = new System.Windows.Forms.TextBox();
            this.creditTextBox = new System.Windows.Forms.TextBox();
            idCardLabel = new System.Windows.Forms.Label();
            idClientLabel = new System.Windows.Forms.Label();
            cardiInformationLabel = new System.Windows.Forms.Label();
            beginDataLabel = new System.Windows.Forms.Label();
            endDateLabel = new System.Windows.Forms.Label();
            debetLabel = new System.Windows.Forms.Label();
            creditLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBindingNavigator)).BeginInit();
            this.cardBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idCardLabel
            // 
            idCardLabel.AutoSize = true;
            idCardLabel.Location = new System.Drawing.Point(108, 122);
            idCardLabel.Name = "idCardLabel";
            idCardLabel.Size = new System.Drawing.Size(54, 13);
            idCardLabel.TabIndex = 39;
            idCardLabel.Text = "Id Карты:";
            // 
            // idClientLabel
            // 
            idClientLabel.AutoSize = true;
            idClientLabel.Location = new System.Drawing.Point(98, 160);
            idClientLabel.Name = "idClientLabel";
            idClientLabel.Size = new System.Drawing.Size(64, 13);
            idClientLabel.TabIndex = 40;
            idClientLabel.Text = "Id Клиента:";
            // 
            // cardiInformationLabel
            // 
            cardiInformationLabel.AutoSize = true;
            cardiInformationLabel.Location = new System.Drawing.Point(47, 198);
            cardiInformationLabel.Name = "cardiInformationLabel";
            cardiInformationLabel.Size = new System.Drawing.Size(117, 13);
            cardiInformationLabel.TabIndex = 41;
            cardiInformationLabel.Text = "Информация о карте:";
            // 
            // beginDataLabel
            // 
            beginDataLabel.AutoSize = true;
            beginDataLabel.Location = new System.Drawing.Point(90, 240);
            beginDataLabel.Name = "beginDataLabel";
            beginDataLabel.Size = new System.Drawing.Size(74, 13);
            beginDataLabel.TabIndex = 42;
            beginDataLabel.Text = "Дата начала:";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Location = new System.Drawing.Point(70, 272);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new System.Drawing.Size(92, 13);
            endDateLabel.TabIndex = 43;
            endDateLabel.Text = "Дата окончания:";
            // 
            // debetLabel
            // 
            debetLabel.AutoSize = true;
            debetLabel.Location = new System.Drawing.Point(56, 316);
            debetLabel.Name = "debetLabel";
            debetLabel.Size = new System.Drawing.Size(106, 13);
            debetLabel.TabIndex = 44;
            debetLabel.Text = "Дебетовая(да/нет):";
            // 
            // creditLabel
            // 
            creditLabel.AutoSize = true;
            creditLabel.Location = new System.Drawing.Point(60, 358);
            creditLabel.Name = "creditLabel";
            creditLabel.Size = new System.Drawing.Size(104, 13);
            creditLabel.TabIndex = 45;
            creditLabel.Text = "Кредитная(да/нет):";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(431, 272);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 32);
            this.button3.TabIndex = 29;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(431, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 32);
            this.button2.TabIndex = 28;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 32);
            this.button1.TabIndex = 27;
            this.button1.Text = "Отчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 24);
            this.label2.TabIndex = 38;
            this.label2.Text = "Информация о картах:";
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "BankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cardBindingSource
            // 
            this.cardBindingSource.DataMember = "Card";
            this.cardBindingSource.DataSource = this.bankDataSet;
            // 
            // cardTableAdapter
            // 
            this.cardTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BankTableAdapter = null;
            this.tableAdapterManager.CardTableAdapter = this.cardTableAdapter;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.CreditTableAdapter = null;
            this.tableAdapterManager.DepositTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.TypeCreditTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = KR_BD.BankDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cardBindingNavigator
            // 
            this.cardBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cardBindingNavigator.BindingSource = this.cardBindingSource;
            this.cardBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cardBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cardBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cardBindingNavigatorSaveItem});
            this.cardBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cardBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cardBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cardBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cardBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cardBindingNavigator.Name = "cardBindingNavigator";
            this.cardBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cardBindingNavigator.Size = new System.Drawing.Size(567, 25);
            this.cardBindingNavigator.TabIndex = 39;
            this.cardBindingNavigator.Text = "bindingNavigator1";
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
            // cardBindingNavigatorSaveItem
            // 
            this.cardBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cardBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cardBindingNavigatorSaveItem.Image")));
            this.cardBindingNavigatorSaveItem.Name = "cardBindingNavigatorSaveItem";
            this.cardBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cardBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.cardBindingNavigatorSaveItem.Click += new System.EventHandler(this.cardBindingNavigatorSaveItem_Click);
            // 
            // idCardTextBox
            // 
            this.idCardTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardBindingSource, "IdCard", true));
            this.idCardTextBox.Location = new System.Drawing.Point(178, 122);
            this.idCardTextBox.Name = "idCardTextBox";
            this.idCardTextBox.Size = new System.Drawing.Size(100, 20);
            this.idCardTextBox.TabIndex = 40;
            // 
            // idClientTextBox
            // 
            this.idClientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardBindingSource, "IdClient", true));
            this.idClientTextBox.Location = new System.Drawing.Point(178, 160);
            this.idClientTextBox.Name = "idClientTextBox";
            this.idClientTextBox.Size = new System.Drawing.Size(100, 20);
            this.idClientTextBox.TabIndex = 41;
            // 
            // cardiInformationTextBox
            // 
            this.cardiInformationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardBindingSource, "CardiInformation", true));
            this.cardiInformationTextBox.Location = new System.Drawing.Point(178, 198);
            this.cardiInformationTextBox.Name = "cardiInformationTextBox";
            this.cardiInformationTextBox.Size = new System.Drawing.Size(100, 20);
            this.cardiInformationTextBox.TabIndex = 42;
            // 
            // beginDataDateTimePicker
            // 
            this.beginDataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cardBindingSource, "BeginData", true));
            this.beginDataDateTimePicker.Location = new System.Drawing.Point(178, 233);
            this.beginDataDateTimePicker.Name = "beginDataDateTimePicker";
            this.beginDataDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.beginDataDateTimePicker.TabIndex = 43;
            // 
            // endDateDateTimePicker
            // 
            this.endDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cardBindingSource, "EndDate", true));
            this.endDateDateTimePicker.Location = new System.Drawing.Point(178, 273);
            this.endDateDateTimePicker.Name = "endDateDateTimePicker";
            this.endDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endDateDateTimePicker.TabIndex = 44;
            // 
            // debetTextBox
            // 
            this.debetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardBindingSource, "Debet", true));
            this.debetTextBox.Location = new System.Drawing.Point(178, 317);
            this.debetTextBox.Name = "debetTextBox";
            this.debetTextBox.Size = new System.Drawing.Size(100, 20);
            this.debetTextBox.TabIndex = 45;
            // 
            // creditTextBox
            // 
            this.creditTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardBindingSource, "Credit", true));
            this.creditTextBox.Location = new System.Drawing.Point(178, 358);
            this.creditTextBox.Name = "creditTextBox";
            this.creditTextBox.Size = new System.Drawing.Size(100, 20);
            this.creditTextBox.TabIndex = 46;
            // 
            // Cards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 450);
            this.Controls.Add(creditLabel);
            this.Controls.Add(this.creditTextBox);
            this.Controls.Add(debetLabel);
            this.Controls.Add(this.debetTextBox);
            this.Controls.Add(endDateLabel);
            this.Controls.Add(this.endDateDateTimePicker);
            this.Controls.Add(beginDataLabel);
            this.Controls.Add(this.beginDataDateTimePicker);
            this.Controls.Add(cardiInformationLabel);
            this.Controls.Add(this.cardiInformationTextBox);
            this.Controls.Add(idClientLabel);
            this.Controls.Add(this.idClientTextBox);
            this.Controls.Add(idCardLabel);
            this.Controls.Add(this.idCardTextBox);
            this.Controls.Add(this.cardBindingNavigator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Cards";
            this.Text = "Карты";
            this.Load += new System.EventHandler(this.Cards_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBindingNavigator)).EndInit();
            this.cardBindingNavigator.ResumeLayout(false);
            this.cardBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private BankDataSet bankDataSet;
        private System.Windows.Forms.BindingSource cardBindingSource;
        private BankDataSetTableAdapters.CardTableAdapter cardTableAdapter;
        private BankDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cardBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cardBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idCardTextBox;
        private System.Windows.Forms.TextBox idClientTextBox;
        private System.Windows.Forms.TextBox cardiInformationTextBox;
        private System.Windows.Forms.DateTimePicker beginDataDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateDateTimePicker;
        private System.Windows.Forms.TextBox debetTextBox;
        private System.Windows.Forms.TextBox creditTextBox;
    }
}