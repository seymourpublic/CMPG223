
namespace Project1
{
    partial class TextbookRecieved
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
            this.textbooksDataGridView = new System.Windows.Forms.DataGridView();
            this.textbookRecievedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textbookNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textbookRecievedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.circleDataSet = new Project1.CircleDataSet();
            this.textbook_recievedTableAdapter = new Project1.CircleDataSetTableAdapters.Textbook_recievedTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextbookRecievedTxb = new System.Windows.Forms.TextBox();
            this.TextbookNoTxb = new System.Windows.Forms.TextBox();
            this.DateTxb = new System.Windows.Forms.TextBox();
            this.StatusTxb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.textbooksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textbookRecievedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textbooksDataGridView
            // 
            this.textbooksDataGridView.AutoGenerateColumns = false;
            this.textbooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.textbooksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.textbookRecievedDataGridViewTextBoxColumn,
            this.textbookNoDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.textbooksDataGridView.DataSource = this.textbookRecievedBindingSource;
            this.textbooksDataGridView.Location = new System.Drawing.Point(12, 12);
            this.textbooksDataGridView.Name = "textbooksDataGridView";
            this.textbooksDataGridView.RowHeadersWidth = 51;
            this.textbooksDataGridView.RowTemplate.Height = 24;
            this.textbooksDataGridView.Size = new System.Drawing.Size(555, 265);
            this.textbooksDataGridView.TabIndex = 21;
            // 
            // textbookRecievedDataGridViewTextBoxColumn
            // 
            this.textbookRecievedDataGridViewTextBoxColumn.DataPropertyName = "Textbook recieved";
            this.textbookRecievedDataGridViewTextBoxColumn.HeaderText = "Textbook recieved";
            this.textbookRecievedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.textbookRecievedDataGridViewTextBoxColumn.Name = "textbookRecievedDataGridViewTextBoxColumn";
            this.textbookRecievedDataGridViewTextBoxColumn.Width = 125;
            // 
            // textbookNoDataGridViewTextBoxColumn
            // 
            this.textbookNoDataGridViewTextBoxColumn.DataPropertyName = "Textbook no";
            this.textbookNoDataGridViewTextBoxColumn.HeaderText = "Textbook no";
            this.textbookNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.textbookNoDataGridViewTextBoxColumn.Name = "textbookNoDataGridViewTextBoxColumn";
            this.textbookNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // textbookRecievedBindingSource
            // 
            this.textbookRecievedBindingSource.DataMember = "Textbook recieved";
            this.textbookRecievedBindingSource.DataSource = this.circleDataSet;
            // 
            // circleDataSet
            // 
            this.circleDataSet.DataSetName = "CircleDataSet";
            this.circleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textbook_recievedTableAdapter
            // 
            this.textbook_recievedTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 66);
            this.button1.TabIndex = 30;
            this.button1.Text = "Insert Recieved Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Textbook No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Textbook Recieved";
            // 
            // TextbookRecievedTxb
            // 
            this.TextbookRecievedTxb.Location = new System.Drawing.Point(170, 294);
            this.TextbookRecievedTxb.Name = "TextbookRecievedTxb";
            this.TextbookRecievedTxb.Size = new System.Drawing.Size(100, 22);
            this.TextbookRecievedTxb.TabIndex = 25;
            // 
            // TextbookNoTxb
            // 
            this.TextbookNoTxb.Location = new System.Drawing.Point(170, 337);
            this.TextbookNoTxb.Name = "TextbookNoTxb";
            this.TextbookNoTxb.Size = new System.Drawing.Size(100, 22);
            this.TextbookNoTxb.TabIndex = 24;
            // 
            // DateTxb
            // 
            this.DateTxb.Location = new System.Drawing.Point(170, 381);
            this.DateTxb.Name = "DateTxb";
            this.DateTxb.Size = new System.Drawing.Size(100, 22);
            this.DateTxb.TabIndex = 23;
            // 
            // StatusTxb
            // 
            this.StatusTxb.Location = new System.Drawing.Point(170, 420);
            this.StatusTxb.Name = "StatusTxb";
            this.StatusTxb.Size = new System.Drawing.Size(100, 22);
            this.StatusTxb.TabIndex = 22;
            // 
            // TextbookRecieved
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 536);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextbookRecievedTxb);
            this.Controls.Add(this.TextbookNoTxb);
            this.Controls.Add(this.DateTxb);
            this.Controls.Add(this.StatusTxb);
            this.Controls.Add(this.textbooksDataGridView);
            this.Name = "TextbookRecieved";
            this.Text = "TextbookRecieved";
            this.Load += new System.EventHandler(this.TextbookRecieved_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textbooksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textbookRecievedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView textbooksDataGridView;
        private CircleDataSet circleDataSet;
        private System.Windows.Forms.BindingSource textbookRecievedBindingSource;
        private CircleDataSetTableAdapters.Textbook_recievedTableAdapter textbook_recievedTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn textbookRecievedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textbookNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextbookRecievedTxb;
        private System.Windows.Forms.TextBox TextbookNoTxb;
        private System.Windows.Forms.TextBox DateTxb;
        private System.Windows.Forms.TextBox StatusTxb;
    }
}