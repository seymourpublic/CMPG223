
namespace Project1
{
    partial class Textbook
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label textbook_NoLabel;
            System.Windows.Forms.Label module_codeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Textbook));
            this.textbooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.circleDataSet = new Project1.CircleDataSet();
            this.textbooksTableAdapter = new Project1.CircleDataSetTableAdapters.TextbooksTableAdapter();
            this.lsbText = new System.Windows.Forms.ListBox();
            this.tableAdapterManager = new Project1.CircleDataSetTableAdapters.TableAdapterManager();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.btnSell = new System.Windows.Forms.Button();
            this.textbook_NoTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.textbooksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbAname = new System.Windows.Forms.TextBox();
            this.txbAcode = new System.Windows.Forms.TextBox();
            this.txbAquant = new System.Windows.Forms.TextBox();
            this.txbAprice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchTxb = new System.Windows.Forms.TextBox();
            this.textbooksTableAdapter1 = new Project1.CircleDataSet1TableAdapters.TextbooksTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowAllItemsBtn = new System.Windows.Forms.Button();
            this.module_codeTextBox = new System.Windows.Forms.TextBox();
            this.circleDataSet1 = new Project1.CircleDataSet();
            this.button5 = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            textbook_NoLabel = new System.Windows.Forms.Label();
            module_codeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.textbooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textbooksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(700, 90);
            nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(700, 126);
            quantityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(49, 13);
            quantityLabel.TabIndex = 4;
            quantityLabel.Text = "Quantity:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(700, 162);
            priceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 6;
            priceLabel.Text = "Price:";
            priceLabel.Click += new System.EventHandler(this.priceLabel_Click);
            // 
            // textbook_NoLabel
            // 
            textbook_NoLabel.AutoSize = true;
            textbook_NoLabel.Location = new System.Drawing.Point(700, 196);
            textbook_NoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            textbook_NoLabel.Name = "textbook_NoLabel";
            textbook_NoLabel.Size = new System.Drawing.Size(72, 13);
            textbook_NoLabel.TabIndex = 9;
            textbook_NoLabel.Text = "Textbook No:";
            // 
            // module_codeLabel
            // 
            module_codeLabel.AutoSize = true;
            module_codeLabel.Location = new System.Drawing.Point(700, 229);
            module_codeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            module_codeLabel.Name = "module_codeLabel";
            module_codeLabel.Size = new System.Drawing.Size(72, 13);
            module_codeLabel.TabIndex = 42;
            module_codeLabel.Text = "Module code:";
            // 
            // textbooksBindingSource
            // 
            this.textbooksBindingSource.DataMember = "Textbooks";
            this.textbooksBindingSource.DataSource = this.circleDataSet;
            // 
            // circleDataSet
            // 
            this.circleDataSet.DataSetName = "CircleDataSet";
            this.circleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textbooksTableAdapter
            // 
            this.textbooksTableAdapter.ClearBeforeFill = true;
            // 
            // lsbText
            // 
            this.lsbText.DataSource = this.textbooksBindingSource;
            this.lsbText.DisplayMember = "Textbook No";
            this.lsbText.FormattingEnabled = true;
            this.lsbText.Location = new System.Drawing.Point(589, 88);
            this.lsbText.Margin = new System.Windows.Forms.Padding(2);
            this.lsbText.Name = "lsbText";
            this.lsbText.Size = new System.Drawing.Size(91, 160);
            this.lsbText.TabIndex = 1;
            this.lsbText.SelectedIndexChanged += new System.EventHandler(this.lsbText_SelectedIndexChanged);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.Rented_outTableAdapter = null;
            this.tableAdapterManager.ReturnedTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.Textbook_recievedTableAdapter = null;
            this.tableAdapterManager.Textbooks_soldTableAdapter = null;
            this.tableAdapterManager.TextbooksTableAdapter = this.textbooksTableAdapter;
            this.tableAdapterManager.UpdateOrder = Project1.CircleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.textbooksBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(774, 88);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(76, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.textbooksBindingSource, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(774, 126);
            this.quantityTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(76, 20);
            this.quantityTextBox.TabIndex = 5;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.textbooksBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(774, 158);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(76, 20);
            this.priceTextBox.TabIndex = 7;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(589, 263);
            this.btnSell.Margin = new System.Windows.Forms.Padding(2);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(260, 26);
            this.btnSell.TabIndex = 8;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // textbook_NoTextBox
            // 
            this.textbook_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.textbooksBindingSource, "Textbook No", true));
            this.textbook_NoTextBox.Location = new System.Drawing.Point(774, 193);
            this.textbook_NoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.textbook_NoTextBox.Name = "textbook_NoTextBox";
            this.textbook_NoTextBox.Size = new System.Drawing.Size(76, 20);
            this.textbook_NoTextBox.TabIndex = 10;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.textbooksBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(904, 27);
            this.bindingNavigator1.TabIndex = 11;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // textbooksDataGridView
            // 
            this.textbooksDataGridView.AutoGenerateColumns = false;
            this.textbooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.textbooksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.textbooksDataGridView.DataSource = this.textbooksBindingSource;
            this.textbooksDataGridView.Location = new System.Drawing.Point(9, 77);
            this.textbooksDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.textbooksDataGridView.Name = "textbooksDataGridView";
            this.textbooksDataGridView.RowHeadersWidth = 51;
            this.textbooksDataGridView.RowTemplate.Height = 24;
            this.textbooksDataGridView.Size = new System.Drawing.Size(508, 212);
            this.textbooksDataGridView.TabIndex = 20;
            this.textbooksDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.textbooksDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Textbook No";
            this.dataGridViewTextBoxColumn1.HeaderText = "Textbook No";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Module code";
            this.dataGridViewTextBoxColumn3.HeaderText = "Module code";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn5.HeaderText = "Price";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(589, 333);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(260, 26);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete textbook";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(14, 461);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(350, 29);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add new textbook";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 405);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 405);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 357);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Module Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 358);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Name";
            // 
            // txbAname
            // 
            this.txbAname.Location = new System.Drawing.Point(62, 354);
            this.txbAname.Margin = new System.Windows.Forms.Padding(2);
            this.txbAname.Name = "txbAname";
            this.txbAname.Size = new System.Drawing.Size(76, 20);
            this.txbAname.TabIndex = 29;
            // 
            // txbAcode
            // 
            this.txbAcode.Location = new System.Drawing.Point(289, 354);
            this.txbAcode.Margin = new System.Windows.Forms.Padding(2);
            this.txbAcode.Name = "txbAcode";
            this.txbAcode.Size = new System.Drawing.Size(76, 20);
            this.txbAcode.TabIndex = 30;
            // 
            // txbAquant
            // 
            this.txbAquant.Location = new System.Drawing.Point(62, 405);
            this.txbAquant.Margin = new System.Windows.Forms.Padding(2);
            this.txbAquant.Name = "txbAquant";
            this.txbAquant.Size = new System.Drawing.Size(76, 20);
            this.txbAquant.TabIndex = 31;
            // 
            // txbAprice
            // 
            this.txbAprice.Location = new System.Drawing.Point(289, 402);
            this.txbAprice.Margin = new System.Windows.Forms.Padding(2);
            this.txbAprice.Name = "txbAprice";
            this.txbAprice.Size = new System.Drawing.Size(76, 20);
            this.txbAprice.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(726, 29);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 27);
            this.button1.TabIndex = 33;
            this.button1.Text = "View Return records";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(589, 29);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 27);
            this.button2.TabIndex = 34;
            this.button2.Text = "View Sale Records";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(400, 29);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 27);
            this.button3.TabIndex = 35;
            this.button3.Text = "View Rental records";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(238, 29);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 27);
            this.button4.TabIndex = 36;
            this.button4.Text = "View Client Records";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(589, 444);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(260, 19);
            this.SearchBtn.TabIndex = 37;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchTxb
            // 
            this.SearchTxb.Location = new System.Drawing.Point(589, 412);
            this.SearchTxb.Margin = new System.Windows.Forms.Padding(2);
            this.SearchTxb.Name = "SearchTxb";
            this.SearchTxb.Size = new System.Drawing.Size(261, 20);
            this.SearchTxb.TabIndex = 38;
            this.SearchTxb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textbooksTableAdapter1
            // 
            this.textbooksTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(586, 382);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Search for a textbook";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ShowAllItemsBtn
            // 
            this.ShowAllItemsBtn.Location = new System.Drawing.Point(14, 530);
            this.ShowAllItemsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ShowAllItemsBtn.Name = "ShowAllItemsBtn";
            this.ShowAllItemsBtn.Size = new System.Drawing.Size(836, 19);
            this.ShowAllItemsBtn.TabIndex = 40;
            this.ShowAllItemsBtn.Text = "Show All Items";
            this.ShowAllItemsBtn.UseVisualStyleBackColor = true;
            this.ShowAllItemsBtn.Click += new System.EventHandler(this.ShowAllItemsBtn_Click);
            // 
            // module_codeTextBox
            // 
            this.module_codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.textbooksBindingSource, "Module code", true));
            this.module_codeTextBox.Location = new System.Drawing.Point(775, 227);
            this.module_codeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.module_codeTextBox.Name = "module_codeTextBox";
            this.module_codeTextBox.Size = new System.Drawing.Size(76, 20);
            this.module_codeTextBox.TabIndex = 43;
            // 
            // circleDataSet1
            // 
            this.circleDataSet1.DataSetName = "CircleDataSet";
            this.circleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(14, 502);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(835, 23);
            this.button5.TabIndex = 44;
            this.button5.Text = "Rent out select textbook";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Textbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 560);
            this.Controls.Add(this.button5);
            this.Controls.Add(module_codeLabel);
            this.Controls.Add(this.module_codeTextBox);
            this.Controls.Add(this.ShowAllItemsBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchTxb);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbAprice);
            this.Controls.Add(this.txbAquant);
            this.Controls.Add(this.txbAcode);
            this.Controls.Add(this.txbAname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.textbooksDataGridView);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(textbook_NoLabel);
            this.Controls.Add(this.textbook_NoTextBox);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.lsbText);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Textbook";
            this.Text = "Textbook";
            this.Load += new System.EventHandler(this.Textbook_Load);
         //   this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Textbook_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.textbooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textbooksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CircleDataSet circleDataSet;
        private System.Windows.Forms.BindingSource textbooksBindingSource;
        private CircleDataSetTableAdapters.TextbooksTableAdapter textbooksTableAdapter;
        private System.Windows.Forms.ListBox lsbText;
        private CircleDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.TextBox textbook_NoTextBox;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
        private System.Windows.Forms.DataGridView textbooksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbAname;
        private System.Windows.Forms.TextBox txbAcode;
        private System.Windows.Forms.TextBox txbAquant;
        private System.Windows.Forms.TextBox txbAprice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox SearchTxb;
        private CircleDataSet1TableAdapters.TextbooksTableAdapter textbooksTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShowAllItemsBtn;
        private System.Windows.Forms.TextBox module_codeTextBox;
        private CircleDataSet circleDataSet1;
        private System.Windows.Forms.Button button5;
    }
}