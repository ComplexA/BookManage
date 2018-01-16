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
    public partial class schrd : Form
    {
        public schrd()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
    }
}
=======

        private void alllend_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“bookmanageDataSet2.caseBook”中。您可以根据需要移动或删除它。
            // this.caseBookTableAdapter.Fill(this.bookmanageDataSet2.caseBook);
            // TODO: 这行代码将数据加载到表“bookmanageDataSet.lend”中。您可以根据需要移动或删除它。
            // this.lendTableAdapter.Fill(this.bookmanageDataSet.lend);

        }

        private void btsch_Click(object sender, EventArgs e)
        {
            string sqlStr = "";
            if (combosch.SelectedIndex < 4 && txtsch.Text.Trim() == "")
            {
                MessageBox.Show("请输入需要查询的“" + combosch.SelectedItem.ToString().Trim() + "”!", "提示");
                return;
            }
            else if (combosch.SelectedIndex == 0)
                sqlStr = "select * from reader where rdID='" + txtsch.Text.Trim() + "'";
            else if (combosch.SelectedIndex == 1)
                sqlStr = "select * from reader where rdName='" + txtsch.Text.Trim() + "'";
            else if (combosch.SelectedIndex == 2)
                sqlStr = "select * from reader where rddpt='" + txtsch.Text.Trim() + "'";


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

        private void btall_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.bookmanageDataSet.lend;
        }

        private void combosch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combosch.SelectedIndex > 3)
            {
                txtsch.ReadOnly = true;
            }
            else txtsch.ReadOnly = false;
        }
    }
}

>>>>>>> 7c57701bb9f59cd6631acfbeb322f9d04584b178
