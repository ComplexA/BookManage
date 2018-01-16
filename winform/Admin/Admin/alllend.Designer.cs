namespace Admin
{
    partial class alllend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alllend));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookmanageDataSet = new Admin.bookmanageDataSet();
            this.lendBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lendTableAdapter = new Admin.bookmanageDataSetTableAdapters.lendTableAdapter();
            this.rdIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lenddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtndateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renewDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.combosch = new System.Windows.Forms.ComboBox();
            this.txtsch = new System.Windows.Forms.TextBox();
            this.btsch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btall = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookmanageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lendBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rdIDDataGridViewTextBoxColumn,
            this.cIDDataGridViewTextBoxColumn,
            this.lenddateDataGridViewTextBoxColumn,
            this.rtndateDataGridViewTextBoxColumn,
            this.renewDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.lendBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(543, 372);
            this.dataGridView1.TabIndex = 0;
            // 
            // bookmanageDataSet
            // 
            this.bookmanageDataSet.DataSetName = "bookmanageDataSet";
            this.bookmanageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lendBindingSource
            // 
            this.lendBindingSource.DataMember = "lend";
            this.lendBindingSource.DataSource = this.bookmanageDataSet;
            // 
            // lendTableAdapter
            // 
            this.lendTableAdapter.ClearBeforeFill = true;
            // 
            // rdIDDataGridViewTextBoxColumn
            // 
            this.rdIDDataGridViewTextBoxColumn.DataPropertyName = "rdID";
            this.rdIDDataGridViewTextBoxColumn.HeaderText = "读者编码";
            this.rdIDDataGridViewTextBoxColumn.Name = "rdIDDataGridViewTextBoxColumn";
            this.rdIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cIDDataGridViewTextBoxColumn
            // 
            this.cIDDataGridViewTextBoxColumn.DataPropertyName = "cID";
            this.cIDDataGridViewTextBoxColumn.HeaderText = "图书编码";
            this.cIDDataGridViewTextBoxColumn.Name = "cIDDataGridViewTextBoxColumn";
            this.cIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lenddateDataGridViewTextBoxColumn
            // 
            this.lenddateDataGridViewTextBoxColumn.DataPropertyName = "lenddate";
            this.lenddateDataGridViewTextBoxColumn.HeaderText = "借书日期";
            this.lenddateDataGridViewTextBoxColumn.Name = "lenddateDataGridViewTextBoxColumn";
            this.lenddateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rtndateDataGridViewTextBoxColumn
            // 
            this.rtndateDataGridViewTextBoxColumn.DataPropertyName = "rtndate";
            this.rtndateDataGridViewTextBoxColumn.HeaderText = "还书日期";
            this.rtndateDataGridViewTextBoxColumn.Name = "rtndateDataGridViewTextBoxColumn";
            this.rtndateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // renewDataGridViewCheckBoxColumn
            // 
            this.renewDataGridViewCheckBoxColumn.DataPropertyName = "renew";
            this.renewDataGridViewCheckBoxColumn.HeaderText = "是否续借";
            this.renewDataGridViewCheckBoxColumn.Name = "renewDataGridViewCheckBoxColumn";
            this.renewDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // combosch
            // 
            this.combosch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combosch.FormattingEnabled = true;
            this.combosch.Items.AddRange(new object[] {
            "读者编码",
            "图书编码",
            "借书日期",
            "还书日期",
            "已续借",
            "未续借"});
            this.combosch.Location = new System.Drawing.Point(71, 24);
            this.combosch.Name = "combosch";
            this.combosch.Size = new System.Drawing.Size(121, 20);
            this.combosch.TabIndex = 1;
            this.combosch.SelectedIndexChanged += new System.EventHandler(this.combosch_SelectedIndexChanged);
            // 
            // txtsch
            // 
            this.txtsch.Location = new System.Drawing.Point(267, 25);
            this.txtsch.Name = "txtsch";
            this.txtsch.Size = new System.Drawing.Size(100, 21);
            this.txtsch.TabIndex = 2;
            // 
            // btsch
            // 
            this.btsch.Location = new System.Drawing.Point(387, 23);
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
            this.label2.Location = new System.Drawing.Point(208, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "查询内容";
            // 
            // btall
            // 
            this.btall.Location = new System.Drawing.Point(480, 23);
            this.btall.Name = "btall";
            this.btall.Size = new System.Drawing.Size(75, 23);
            this.btall.TabIndex = 6;
            this.btall.Text = "查看所有";
            this.btall.UseVisualStyleBackColor = true;
            this.btall.Click += new System.EventHandler(this.btall_Click);
            // 
            // alllend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 446);
            this.Controls.Add(this.btall);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btsch);
            this.Controls.Add(this.txtsch);
            this.Controls.Add(this.combosch);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "alllend";
            this.Text = "所有借阅信息";
            this.Load += new System.EventHandler(this.alllend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookmanageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lendBindingSource)).EndInit();
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
        private System.Windows.Forms.Button btall;
    }
}