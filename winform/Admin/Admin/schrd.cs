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

        private void alllend_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“bookmanageDataSet5.reader”中。您可以根据需要移动或删除它。
            this.readerTableAdapter.Fill(this.bookmanageDataSet5.reader);
            // TODO: 这行代码将数据加载到表“bookmanageDataSet2.caseBook”中。您可以根据需要移动或删除它。
            // this.caseBookTableAdapter.Fill(this.bookmanageDataSet2.caseBook);
            // TODO: 这行代码将数据加载到表“bookmanageDataSet.lend”中。您可以根据需要移动或删除它。
            // this.lendTableAdapter.Fill(this.bookmanageDataSet.lend);

        }

        private void btsch_Click(object sender, EventArgs e)
        {
            string sqlStr = "";
            if (combosch.SelectedIndex < 3 && txtsch.Text.Trim() == "")
            {
                MessageBox.Show("请输入需要查询的“" + combosch.SelectedItem.ToString().Trim() + "”!", "提示");
                return;
            }
            else if (combosch.SelectedIndex == 0)
                sqlStr = "select * from reader where rdID='" + txtsch.Text.Trim() + "'";
            else if (combosch.SelectedIndex == 1)
                sqlStr = "select * from reader where rdName like '%" + txtsch.Text.Trim() + "%'";
            else if (combosch.SelectedIndex == 2)
                sqlStr = "select * from reader where rddpt='" + txtsch.Text.Trim() + "'";
            else if (combosch.SelectedIndex == 3)
                sqlStr = "select * from reader where rdsex='男'";
            else if (combosch.SelectedIndex == 4)
                sqlStr = "select * from reader where rdsex='女'";


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
            if (combosch.SelectedIndex > 2)
            {
                txtsch.ReadOnly = true;
            }
            else txtsch.ReadOnly = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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

        private void btdelete_Click(object sender, EventArgs e)
        {
            string dltnm = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string dltid = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("确定删除\n读者号为" + dltid + "\n姓名为\t" + dltnm + "？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sqldltv = "delete from reader where rdID ='" + dltid + "'";
                string sqldltlend = "delete from lend where rdID='"+dltid+"'";
                Cdatabase.UpdateDB(sqldltv);
                MessageBox.Show("删除成功");
                RefreshForm();
            }
        }

    }
}

