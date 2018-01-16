namespace Admin
{
    partial class allrd
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
<<<<<<< HEAD
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "allrd";
        }

        #endregion
=======
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(allrd));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.caseBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookmanageDataSet2 = new Admin.bookmanageDataSet2();
            this.lendBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.caseBookTableAdapter = new Admin.bookmanageDataSet2TableAdapters.caseBookTableAdapter();
            this.bookmanageDataSet3 = new Admin.bookmanageDataSet3();
            this.readerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.readerTableAdapter = new Admin.bookmanageDataSet3TableAdapters.readerTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdbirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rddptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdsexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookmanageDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lendBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookmanageDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.rdnameDataGridViewTextBoxColumn,
            this.rdbirthDataGridViewTextBoxColumn,
            this.rddptDataGridViewTextBoxColumn,
            this.rdsexDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.readerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(540, 372);
            this.dataGridView1.TabIndex = 0;
            // 
            // caseBookBindingSource
            // 
            this.caseBookBindingSource.DataMember = "caseBook";
            this.caseBookBindingSource.DataSource = this.bookmanageDataSet2;
            // 
            // bookmanageDataSet2
            // 
            this.bookmanageDataSet2.DataSetName = "bookmanageDataSet2";
            this.bookmanageDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lendBindingSource
            // 
            this.lendBindingSource.DataMember = "lend";
            // 
            // caseBookTableAdapter
            // 
            this.caseBookTableAdapter.ClearBeforeFill = true;
            // 
            // bookmanageDataSet3
            // 
            this.bookmanageDataSet3.DataSetName = "bookmanageDataSet3";
            this.bookmanageDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // readerBindingSource
            // 
            this.readerBindingSource.DataMember = "reader";
            this.readerBindingSource.DataSource = this.bookmanageDataSet3;
            // 
            // readerTableAdapter
            // 
            this.readerTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "rdID";
            this.dataGridViewTextBoxColumn1.HeaderText = "读者号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // rdnameDataGridViewTextBoxColumn
            // 
            this.rdnameDataGridViewTextBoxColumn.DataPropertyName = "rdname";
            this.rdnameDataGridViewTextBoxColumn.HeaderText = "读者姓名";
            this.rdnameDataGridViewTextBoxColumn.Name = "rdnameDataGridViewTextBoxColumn";
            this.rdnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rdbirthDataGridViewTextBoxColumn
            // 
            this.rdbirthDataGridViewTextBoxColumn.DataPropertyName = "rdbirth";
            this.rdbirthDataGridViewTextBoxColumn.HeaderText = "出生日期";
            this.rdbirthDataGridViewTextBoxColumn.Name = "rdbirthDataGridViewTextBoxColumn";
            this.rdbirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rddptDataGridViewTextBoxColumn
            // 
            this.rddptDataGridViewTextBoxColumn.DataPropertyName = "rddpt";
            this.rddptDataGridViewTextBoxColumn.HeaderText = "所在学院";
            this.rddptDataGridViewTextBoxColumn.Name = "rddptDataGridViewTextBoxColumn";
            this.rddptDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rdsexDataGridViewTextBoxColumn
            // 
            this.rdsexDataGridViewTextBoxColumn.DataPropertyName = "rdsex";
            this.rdsexDataGridViewTextBoxColumn.HeaderText = "性别";
            this.rdsexDataGridViewTextBoxColumn.Name = "rdsexDataGridViewTextBoxColumn";
            this.rdsexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // allrd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 446);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "allrd";
            this.Text = "所有读者信息";
            this.Load += new System.EventHandler(this.alllend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookmanageDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lendBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookmanageDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private bookmanageDataSet bookmanageDataSet;
        private System.Windows.Forms.BindingSource lendBindingSource;
        private bookmanageDataSetTableAdapters.lendTableAdapter lendTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lenddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rtndateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn renewDataGridViewCheckBoxColumn;
        private bookmanageDataSet2 bookmanageDataSet2;
        private System.Windows.Forms.BindingSource caseBookBindingSource;
        private bookmanageDataSet2TableAdapters.caseBookTableAdapter caseBookTableAdapter;
        private bookmanageDataSet3 bookmanageDataSet3;
        private System.Windows.Forms.BindingSource readerBindingSource;
        private bookmanageDataSet3TableAdapters.readerTableAdapter readerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdbirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rddptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdsexDataGridViewTextBoxColumn;
>>>>>>> 7c57701bb9f59cd6631acfbeb322f9d04584b178
    }
}