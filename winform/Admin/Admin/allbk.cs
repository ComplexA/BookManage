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
    public partial class allbk : Form
    {
        public allbk()
        {
            InitializeComponent();
        }

        private void alllend_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“bookmanageDataSet2.caseBook”中。您可以根据需要移动或删除它。
             this.caseBookTableAdapter.Fill(this.bookmanageDataSet2.caseBook);

            //string sqlStr = "";
            //sqlStr = "select * from caseBook";
            //DataSet ds = new DataSet();
            //ds = Cdatabase.GetDataFromDB(sqlStr);
            //if (ds != null)
            //{
            //    dataGridView1.DataSource = ds.Tables[0];
            //}
            //else
            //{
            //    MessageBox.Show("没有符合条件的记录!", "提示");
            //}
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[0].Value.ToString()))
            {
                editbk editform = new editbk(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                
                editform.refresh += RefreshForm;
                editform.Show();
            }
        }
        public void RefreshForm()
        {
            dataGridView1.DataSource = Cdatabase.GetDataFromDB("select * from caseBook").Tables[0];
        }

    }
}
