using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Admin
{
    public partial class allrd : Form
    {
        public allrd()
        {
            InitializeComponent();
        }

        private void allrd_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“bookmanageDataSet3.reader”中。您可以根据需要移动或删除它。
            this.readerTableAdapter.Fill(this.bookmanageDataSet3.reader);
        }
        
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[0].Value.ToString()))
            {
                editrd editform = new editrd(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                editform.refresh += RefreshForm;
                editform.Show();
            }
        }

        public void RefreshForm()
        {
            dataGridView1.DataSource = Cdatabase.GetDataFromDB("select * from reader").Tables[0];
        }

    }
}
