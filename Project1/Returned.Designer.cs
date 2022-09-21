
namespace Project1
{
    partial class frmReturned
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.returnedNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textbookNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.circleDataSet = new Project1.CircleDataSet();
            this.returnedTableAdapter = new Project1.CircleDataSetTableAdapters.ReturnedTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RentTxb = new System.Windows.Forms.TextBox();
            this.StudentNoTxb = new System.Windows.Forms.TextBox();
            this.TextbookNoTxb = new System.Windows.Forms.TextBox();
            this.StatusTxb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTxb = new System.Windows.Forms.TextBox();
            this.circleDataSet1 = new Project1.CircleDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.calDate = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.returnedNoDataGridViewTextBoxColumn,
            this.textbookNoDataGridViewTextBoxColumn,
            this.studentNoDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.returnedBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(677, 176);
            this.dataGridView1.TabIndex = 0;
            // 
            // returnedNoDataGridViewTextBoxColumn
            // 
            this.returnedNoDataGridViewTextBoxColumn.DataPropertyName = "Returned no";
            this.returnedNoDataGridViewTextBoxColumn.HeaderText = "Returned no";
            this.returnedNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.returnedNoDataGridViewTextBoxColumn.Name = "returnedNoDataGridViewTextBoxColumn";
            this.returnedNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // textbookNoDataGridViewTextBoxColumn
            // 
            this.textbookNoDataGridViewTextBoxColumn.DataPropertyName = "Textbook no";
            this.textbookNoDataGridViewTextBoxColumn.HeaderText = "Textbook no";
            this.textbookNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.textbookNoDataGridViewTextBoxColumn.Name = "textbookNoDataGridViewTextBoxColumn";
            this.textbookNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentNoDataGridViewTextBoxColumn
            // 
            this.studentNoDataGridViewTextBoxColumn.DataPropertyName = "Student no";
            this.studentNoDataGridViewTextBoxColumn.HeaderText = "Student no";
            this.studentNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentNoDataGridViewTextBoxColumn.Name = "studentNoDataGridViewTextBoxColumn";
            this.studentNoDataGridViewTextBoxColumn.Width = 125;
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
            // returnedBindingSource
            // 
            this.returnedBindingSource.DataMember = "Returned";
            this.returnedBindingSource.DataSource = this.circleDataSet;
            // 
            // circleDataSet
            // 
            this.circleDataSet.DataSetName = "CircleDataSet";
            this.circleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // returnedTableAdapter
            // 
            this.returnedTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 195);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 54);
            this.button1.TabIndex = 18;
            this.button1.Text = "Return Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 296);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 262);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Student no";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Textbook no";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Return No.";
            // 
            // RentTxb
            // 
            this.RentTxb.Location = new System.Drawing.Point(110, 191);
            this.RentTxb.Margin = new System.Windows.Forms.Padding(2);
            this.RentTxb.Name = "RentTxb";
            this.RentTxb.Size = new System.Drawing.Size(76, 20);
            this.RentTxb.TabIndex = 13;
            // 
            // StudentNoTxb
            // 
            this.StudentNoTxb.Location = new System.Drawing.Point(110, 262);
            this.StudentNoTxb.Margin = new System.Windows.Forms.Padding(2);
            this.StudentNoTxb.Name = "StudentNoTxb";
            this.StudentNoTxb.Size = new System.Drawing.Size(76, 20);
            this.StudentNoTxb.TabIndex = 12;
            // 
            // TextbookNoTxb
            // 
            this.TextbookNoTxb.Location = new System.Drawing.Point(110, 228);
            this.TextbookNoTxb.Margin = new System.Windows.Forms.Padding(2);
            this.TextbookNoTxb.Name = "TextbookNoTxb";
            this.TextbookNoTxb.Size = new System.Drawing.Size(76, 20);
            this.TextbookNoTxb.TabIndex = 11;
            // 
            // StatusTxb
            // 
            this.StatusTxb.Location = new System.Drawing.Point(110, 327);
            this.StatusTxb.Margin = new System.Windows.Forms.Padding(2);
            this.StatusTxb.Name = "StatusTxb";
            this.StatusTxb.Size = new System.Drawing.Size(76, 20);
            this.StatusTxb.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 327);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Status";
            // 
            // dateTxb
            // 
            this.dateTxb.Location = new System.Drawing.Point(110, 296);
            this.dateTxb.Margin = new System.Windows.Forms.Padding(2);
            this.dateTxb.Name = "dateTxb";
            this.dateTxb.Size = new System.Drawing.Size(76, 20);
            this.dateTxb.TabIndex = 19;
            // 
            // circleDataSet1
            // 
            this.circleDataSet1.DataSetName = "CircleDataSet";
            this.circleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(701, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 36);
            this.button2.TabIndex = 21;
            this.button2.Text = "Return To textbook page";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // calDate
            // 
            this.calDate.Location = new System.Drawing.Point(265, 336);
            this.calDate.Name = "calDate";
            this.calDate.TabIndex = 22;
            // 
            // frmReturned
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 516);
            this.Controls.Add(this.calDate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTxb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RentTxb);
            this.Controls.Add(this.StudentNoTxb);
            this.Controls.Add(this.TextbookNoTxb);
            this.Controls.Add(this.StatusTxb);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmReturned";
            this.Text = "Returned";
            this.Load += new System.EventHandler(this.Returned_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CircleDataSet circleDataSet;
        private System.Windows.Forms.BindingSource returnedBindingSource;
        private CircleDataSetTableAdapters.ReturnedTableAdapter returnedTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnedNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textbookNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RentTxb;
        private System.Windows.Forms.TextBox StudentNoTxb;
        private System.Windows.Forms.TextBox TextbookNoTxb;
        private System.Windows.Forms.TextBox StatusTxb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dateTxb;
        private CircleDataSet circleDataSet1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MonthCalendar calDate;
    }
}