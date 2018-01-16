namespace Admin
{
    partial class allbk
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
            this.Text = "allbk";
        }

        #endregion
=======
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(allbk));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.caseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pubdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shelfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.caseBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookmanageDataSet2 = new Admin.bookmanageDataSet2();
            this.lendBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.caseBookTableAdapter = new Admin.bookmanageDataSet2TableAdapters.caseBookTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookmanageDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lendBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.caseIDDataGridViewTextBoxColumn,
            this.caseNameDataGridViewTextBoxColumn,
            this.pressDataGridViewTextBoxColumn,
            this.pubdateDataGridViewTextBoxColumn,
            this.vnumDataGridViewTextBoxColumn,
            this.isbnDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.classIDDataGridViewTextBoxColumn,
            this.rowDataGridViewTextBoxColumn,
            this.shelfDataGridViewTextBoxColumn,
            this.floorDataGridViewTextBoxColumn,
            this.writerDataGridViewTextBoxColumn,
            this.stateDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.caseBookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(598, 372);
            this.dataGridView1.TabIndex = 0;
            // 
            // caseIDDataGridViewTextBoxColumn
            // 
            this.caseIDDataGridViewTextBoxColumn.DataPropertyName = "caseID";
            this.caseIDDataGridViewTextBoxColumn.HeaderText = "函号";
            this.caseIDDataGridViewTextBoxColumn.Name = "caseIDDataGridViewTextBoxColumn";
            this.caseIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // caseNameDataGridViewTextBoxColumn
            // 
            this.caseNameDataGridViewTextBoxColumn.DataPropertyName = "caseName";
            this.caseNameDataGridViewTextBoxColumn.HeaderText = "函名";
            this.caseNameDataGridViewTextBoxColumn.Name = "caseNameDataGridViewTextBoxColumn";
            this.caseNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pressDataGridViewTextBoxColumn
            // 
            this.pressDataGridViewTextBoxColumn.DataPropertyName = "press";
            this.pressDataGridViewTextBoxColumn.HeaderText = "出版社";
            this.pressDataGridViewTextBoxColumn.Name = "pressDataGridViewTextBoxColumn";
            this.pressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pubdateDataGridViewTextBoxColumn
            // 
            this.pubdateDataGridViewTextBoxColumn.DataPropertyName = "pubdate";
            this.pubdateDataGridViewTextBoxColumn.HeaderText = "出版日期";
            this.pubdateDataGridViewTextBoxColumn.Name = "pubdateDataGridViewTextBoxColumn";
            this.pubdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vnumDataGridViewTextBoxColumn
            // 
            this.vnumDataGridViewTextBoxColumn.DataPropertyName = "vnum";
            this.vnumDataGridViewTextBoxColumn.HeaderText = "册数";
            this.vnumDataGridViewTextBoxColumn.Name = "vnumDataGridViewTextBoxColumn";
            this.vnumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            this.isbnDataGridViewTextBoxColumn.DataPropertyName = "isbn";
            this.isbnDataGridViewTextBoxColumn.HeaderText = "isbn";
            this.isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            this.isbnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "典藏部门";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classIDDataGridViewTextBoxColumn
            // 
            this.classIDDataGridViewTextBoxColumn.DataPropertyName = "classID";
            this.classIDDataGridViewTextBoxColumn.HeaderText = "分类号";
            this.classIDDataGridViewTextBoxColumn.Name = "classIDDataGridViewTextBoxColumn";
            this.classIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rowDataGridViewTextBoxColumn
            // 
            this.rowDataGridViewTextBoxColumn.DataPropertyName = "row";
            this.rowDataGridViewTextBoxColumn.HeaderText = "排";
            this.rowDataGridViewTextBoxColumn.Name = "rowDataGridViewTextBoxColumn";
            this.rowDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shelfDataGridViewTextBoxColumn
            // 
            this.shelfDataGridViewTextBoxColumn.DataPropertyName = "shelf";
            this.shelfDataGridViewTextBoxColumn.HeaderText = "架";
            this.shelfDataGridViewTextBoxColumn.Name = "shelfDataGridViewTextBoxColumn";
            this.shelfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // floorDataGridViewTextBoxColumn
            // 
            this.floorDataGridViewTextBoxColumn.DataPropertyName = "floor";
            this.floorDataGridViewTextBoxColumn.HeaderText = "层";
            this.floorDataGridViewTextBoxColumn.Name = "floorDataGridViewTextBoxColumn";
            this.floorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // writerDataGridViewTextBoxColumn
            // 
            this.writerDataGridViewTextBoxColumn.DataPropertyName = "writer";
            this.writerDataGridViewTextBoxColumn.HeaderText = "著者";
            this.writerDataGridViewTextBoxColumn.Name = "writerDataGridViewTextBoxColumn";
            this.writerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stateDataGridViewCheckBoxColumn
            // 
            this.stateDataGridViewCheckBoxColumn.DataPropertyName = "state";
            this.stateDataGridViewCheckBoxColumn.HeaderText = "借阅状态";
            this.stateDataGridViewCheckBoxColumn.Name = "stateDataGridViewCheckBoxColumn";
            this.stateDataGridViewCheckBoxColumn.ReadOnly = true;
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
            // allbk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 446);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "allbk";
            this.Text = "所有图书信息";
            this.Load += new System.EventHandler(this.alllend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookmanageDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lendBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn caseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pubdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shelfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn writerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn stateDataGridViewCheckBoxColumn;
>>>>>>> 7c57701bb9f59cd6631acfbeb322f9d04584b178
    }
}