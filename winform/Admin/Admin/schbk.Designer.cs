namespace Admin
{
    partial class schbk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(schbk));
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
            this.combosch = new System.Windows.Forms.ComboBox();
            this.txtsch = new System.Windows.Forms.TextBox();
            this.btsch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.caseBookTableAdapter = new Admin.bookmanageDataSet2TableAdapters.caseBookTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.vIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwriterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookmanageDataSet4 = new Admin.bookmanageDataSet4();
            this.volumeTableAdapter = new Admin.bookmanageDataSet4TableAdapters.volumeTableAdapter();
            this.btdelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookmanageDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lendBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookmanageDataSet4)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(9, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(545, 252);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
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
            // combosch
            // 
            this.combosch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combosch.FormattingEnabled = true;
            this.combosch.Items.AddRange(new object[] {
            "图书编码",
            "书名",
            "作者",
            "分书名",
            "分书著者"});
            this.combosch.Location = new System.Drawing.Point(71, 24);
            this.combosch.Name = "combosch";
            this.combosch.Size = new System.Drawing.Size(97, 20);
            this.combosch.TabIndex = 1;
            // 
            // txtsch
            // 
            this.txtsch.Location = new System.Drawing.Point(242, 25);
            this.txtsch.Name = "txtsch";
            this.txtsch.Size = new System.Drawing.Size(100, 21);
            this.txtsch.TabIndex = 2;
            // 
            // btsch
            // 
            this.btsch.Location = new System.Drawing.Point(398, 22);
            this.btsch.Name = "btsch";
            this.btsch.Size = new System.Drawing.Size(75, 23);
            this.btsch.TabIndex = 3;
            this.btsch.Text = "查询";
            this.btsch.UseVisualStyleBackColor = true;
            this.btsch.Click += new System.EventHandler(this.btsch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "查询条件";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "查询内容";
            // 
            // caseBookTableAdapter
            // 
            this.caseBookTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vIDDataGridViewTextBoxColumn,
            this.vwriterDataGridViewTextBoxColumn,
            this.divisionDataGridViewTextBoxColumn,
            this.topicDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.volumeBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(9, 320);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(547, 231);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // vIDDataGridViewTextBoxColumn
            // 
            this.vIDDataGridViewTextBoxColumn.DataPropertyName = "vID";
            this.vIDDataGridViewTextBoxColumn.HeaderText = "册号";
            this.vIDDataGridViewTextBoxColumn.Name = "vIDDataGridViewTextBoxColumn";
            this.vIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vwriterDataGridViewTextBoxColumn
            // 
            this.vwriterDataGridViewTextBoxColumn.DataPropertyName = "vwriter";
            this.vwriterDataGridViewTextBoxColumn.HeaderText = "著者";
            this.vwriterDataGridViewTextBoxColumn.Name = "vwriterDataGridViewTextBoxColumn";
            this.vwriterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // divisionDataGridViewTextBoxColumn
            // 
            this.divisionDataGridViewTextBoxColumn.DataPropertyName = "division";
            this.divisionDataGridViewTextBoxColumn.HeaderText = "分书名";
            this.divisionDataGridViewTextBoxColumn.Name = "divisionDataGridViewTextBoxColumn";
            this.divisionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // topicDataGridViewTextBoxColumn
            // 
            this.topicDataGridViewTextBoxColumn.DataPropertyName = "topic";
            this.topicDataGridViewTextBoxColumn.HeaderText = "主题词";
            this.topicDataGridViewTextBoxColumn.Name = "topicDataGridViewTextBoxColumn";
            this.topicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cID";
            this.dataGridViewTextBoxColumn1.HeaderText = "所在函";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // volumeBindingSource
            // 
            this.volumeBindingSource.DataMember = "volume";
            this.volumeBindingSource.DataSource = this.bookmanageDataSet4;
            // 
            // bookmanageDataSet4
            // 
            this.bookmanageDataSet4.DataSetName = "bookmanageDataSet4";
            this.bookmanageDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // volumeTableAdapter
            // 
            this.volumeTableAdapter.ClearBeforeFill = true;
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(479, 23);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(75, 23);
            this.btdelete.TabIndex = 7;
            this.btdelete.Text = "删除";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // schbk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 563);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btsch);
            this.Controls.Add(this.txtsch);
            this.Controls.Add(this.combosch);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "schbk";
            this.Text = "图书查询";
            this.Load += new System.EventHandler(this.alllend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookmanageDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lendBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookmanageDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ComboBox combosch;
        private System.Windows.Forms.TextBox txtsch;
        private System.Windows.Forms.Button btsch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.DataGridView dataGridView2;
        private bookmanageDataSet4 bookmanageDataSet4;
        private System.Windows.Forms.BindingSource volumeBindingSource;
        private bookmanageDataSet4TableAdapters.volumeTableAdapter volumeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vwriterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn divisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn topicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btdelete;
    }
}