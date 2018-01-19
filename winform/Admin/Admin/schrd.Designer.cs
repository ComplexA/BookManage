namespace Admin
{
    partial class schrd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(schrd));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.combosch = new System.Windows.Forms.ComboBox();
            this.txtsch = new System.Windows.Forms.TextBox();
            this.btsch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bookmanageDataSet5 = new Admin.bookmanageDataSet5();
            this.readerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.readerTableAdapter = new Admin.bookmanageDataSet5TableAdapters.readerTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdbirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdsexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rddptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btdelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookmanageDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.rdnameDataGridViewTextBoxColumn,
            this.rdbirthDataGridViewTextBoxColumn,
            this.rdsexDataGridViewTextBoxColumn,
            this.rddptDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.readerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(544, 406);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // combosch
            // 
            this.combosch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combosch.FormattingEnabled = true;
            this.combosch.Items.AddRange(new object[] {
            "读者号",
            "读者姓名",
            "学院",
            "男",
            "女"});
            this.combosch.Location = new System.Drawing.Point(73, 20);
            this.combosch.Name = "combosch";
            this.combosch.Size = new System.Drawing.Size(121, 20);
            this.combosch.TabIndex = 1;
            this.combosch.SelectedIndexChanged += new System.EventHandler(this.combosch_SelectedIndexChanged);
            // 
            // txtsch
            // 
            this.txtsch.Location = new System.Drawing.Point(269, 20);
            this.txtsch.Name = "txtsch";
            this.txtsch.Size = new System.Drawing.Size(100, 21);
            this.txtsch.TabIndex = 2;
            // 
            // btsch
            // 
            this.btsch.Location = new System.Drawing.Point(389, 19);
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
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "查询条件";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "查询内容";
            // 
            // bookmanageDataSet5
            // 
            this.bookmanageDataSet5.DataSetName = "bookmanageDataSet5";
            this.bookmanageDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // readerBindingSource
            // 
            this.readerBindingSource.DataMember = "reader";
            this.readerBindingSource.DataSource = this.bookmanageDataSet5;
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
            // rdsexDataGridViewTextBoxColumn
            // 
            this.rdsexDataGridViewTextBoxColumn.DataPropertyName = "rdsex";
            this.rdsexDataGridViewTextBoxColumn.HeaderText = "性别";
            this.rdsexDataGridViewTextBoxColumn.Name = "rdsexDataGridViewTextBoxColumn";
            this.rdsexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rddptDataGridViewTextBoxColumn
            // 
            this.rddptDataGridViewTextBoxColumn.DataPropertyName = "rddpt";
            this.rddptDataGridViewTextBoxColumn.HeaderText = "学院";
            this.rddptDataGridViewTextBoxColumn.Name = "rddptDataGridViewTextBoxColumn";
            this.rddptDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(481, 18);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(75, 23);
            this.btdelete.TabIndex = 8;
            this.btdelete.Text = "删除";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // schrd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 468);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btsch);
            this.Controls.Add(this.txtsch);
            this.Controls.Add(this.combosch);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "schrd";
            this.Text = "读者查询";
            this.Load += new System.EventHandler(this.alllend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookmanageDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private bookmanageDataSet bookmanageDataSet;
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
        private bookmanageDataSet5 bookmanageDataSet5;
        private System.Windows.Forms.BindingSource readerBindingSource;
        private bookmanageDataSet5TableAdapters.readerTableAdapter readerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdbirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdsexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rddptDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btdelete;
    }
}