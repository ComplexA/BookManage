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

        private void alllend_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“bookmanageDataSet3.reader”中。您可以根据需要移动或删除它。
            this.readerTableAdapter.Fill(this.bookmanageDataSet3.reader);
            // TODO: 这行代码将数据加载到表“bookmanageDataSet2.caseBook”中。您可以根据需要移动或删除它。
            // this.caseBookTableAdapter.Fill(this.bookmanageDataSet2.caseBook);
            // TODO: 这行代码将数据加载到表“bookmanageDataSet.lend”中。您可以根据需要移动或删除它。
            // this.lendTableAdapter.Fill(this.bookmanageDataSet.lend);

            string sqlStr = "";
            sqlStr = "select * from reader";
            DataSet ds = new DataSet();
            ds = Cdatabase.GetDataFromDB(sqlStr);
            if (ds != null)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("没有符合条件的记录!", "提示");
            }
        }
    


    }
}
