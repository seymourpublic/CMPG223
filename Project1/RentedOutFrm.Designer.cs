
namespace Project1
{
    partial class RentedOutFrm
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
            this.rentNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textbookNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentedOutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.circleDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.circleDataSet = new Project1.CircleDataSet();
            this.rented_outTableAdapter = new Project1.CircleDataSetTableAdapters.Rented_outTableAdapter();
            this.StatusTxb = new System.Windows.Forms.TextBox();
            this.TextbookNoTxb = new System.Windows.Forms.TextBox();
            this.StudentNoTxb = new System.Windows.Forms.TextBox();
            this.RentTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentedOutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rentNoDataGridViewTextBoxColumn,
            this.studentNoDataGridViewTextBoxColumn,
            this.textbookNoDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rentedOutBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(551, 200);
            this.dataGridView1.TabIndex = 0;
            // 
            // rentNoDataGridViewTextBoxColumn
            // 
            this.rentNoDataGridViewTextBoxColumn.DataPropertyName = "Rent no";
            this.rentNoDataGridViewTextBoxColumn.HeaderText = "Rent no";
            this.rentNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rentNoDataGridViewTextBoxColumn.Name = "rentNoDataGridViewTextBoxColumn";
            this.rentNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentNoDataGridViewTextBoxColumn
            // 
            this.studentNoDataGridViewTextBoxColumn.DataPropertyName = "Student no";
            this.studentNoDataGridViewTextBoxColumn.HeaderText = "Student no";
            this.studentNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentNoDataGridViewTextBoxColumn.Name = "studentNoDataGridViewTextBoxColumn";
            this.studentNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // textbookNoDataGridViewTextBoxColumn
            // 
            this.textbookNoDataGridViewTextBoxColumn.DataPropertyName = "Textbook no";
            this.textbookNoDataGridViewTextBoxColumn.HeaderText = "Textbook no";
            this.textbookNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.textbookNoDataGridViewTextBoxColumn.Name = "textbookNoDataGridViewTextBoxColumn";
            this.textbookNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // rentedOutBindingSource
            // 
            this.rentedOutBindingSource.DataMember = "Rented out";
            this.rentedOutBindingSource.DataSource = this.circleDataSetBindingSource;
            // 
            // circleDataSetBindingSource
            // 
            this.circleDataSetBindingSource.DataSource = this.circleDataSet;
            this.circleDataSetBindingSource.Position = 0;
            // 
            // circleDataSet
            // 
            this.circleDataSet.DataSetName = "CircleDataSet";
            this.circleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rented_outTableAdapter
            // 
            this.rented_outTableAdapter.ClearBeforeFill = true;
            // 
            // StatusTxb
            // 
            this.StatusTxb.Location = new System.Drawing.Point(127, 379);
            this.StatusTxb.Name = "StatusTxb";
            this.StatusTxb.Size = new System.Drawing.Size(100, 22);
            this.StatusTxb.TabIndex = 1;
            // 
            // TextbookNoTxb
            // 
            this.TextbookNoTxb.Location = new System.Drawing.Point(127, 340);
            this.TextbookNoTxb.Name = "TextbookNoTxb";
            this.TextbookNoTxb.Size = new System.Drawing.Size(100, 22);
            this.TextbookNoTxb.TabIndex = 2;
            // 
            // StudentNoTxb
            // 
            this.StudentNoTxb.Location = new System.Drawing.Point(127, 296);
            this.StudentNoTxb.Name = "StudentNoTxb";
            this.StudentNoTxb.Size = new System.Drawing.Size(100, 22);
            this.StudentNoTxb.TabIndex = 3;
            // 
            // RentTxb
            // 
            this.RentTxb.Location = new System.Drawing.Point(127, 253);
            this.RentTxb.Name = "RentTxb";
            this.RentTxb.Size = new System.Drawing.Size(100, 22);
            this.RentTxb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rented No";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Student No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Textbook No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Status";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 66);
            this.button1.TabIndex = 9;
            this.button1.Text = "Insert Rented Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RentedOutFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "RentedOutFrm";
            this.Text = "RentedOutFrm";
            this.Load += new System.EventHandler(this.RentedOutFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentedOutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CircleDataSet circleDataSet;
        private System.Windows.Forms.BindingSource circleDataSetBindingSource;
        private System.Windows.Forms.BindingSource rentedOutBindingSource;
        private CircleDataSetTableAdapters.Rented_outTableAdapter rented_outTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textbookNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox StatusTxb;
        private System.Windows.Forms.TextBox TextbookNoTxb;
        private System.Windows.Forms.TextBox StudentNoTxb;
        private System.Windows.Forms.TextBox RentTxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}