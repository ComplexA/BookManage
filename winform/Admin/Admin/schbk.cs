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
    public partial class schbk : Form
    {
        public schbk()
        {
            InitializeComponent();
        }

        private void alllend_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“bookmanageDataSet4.volume”中。您可以根据需要移动或删除它。
            this.volumeTableAdapter.Fill(this.bookmanageDataSet4.volume);
            // TODO: 这行代码将数据加载到表“bookmanageDataSet2.caseBook”中。您可以根据需要移动或删除它。
            // this.caseBookTableAdapter.Fill(this.bookmanageDataSet2.caseBook);
            // TODO: 这行代码将数据加载到表“bookmanageDataSet.lend”中。您可以根据需要移动或删除它。
            // this.lendTableAdapter.Fill(this.bookmanageDataSet.lend);

        }

        private void btsch_Click(object sender, EventArgs e)
        {
            string sqlStr = "";
            if (combosch.SelectedIndex<4 && txtsch.Text.Trim() == "")
            {
                MessageBox.Show("请输入需要查询的“" + combosch.SelectedItem.ToString().Trim() + "”!", "提示");
                return;
            }
            else if (combosch.SelectedIndex == 0)
                sqlStr = "select * from caseBook where caseID='" + txtsch.Text.Trim() + "'";
            else if (combosch.SelectedIndex == 1)
                sqlStr = "select * from caseBook where caseName='" + txtsch.Text.Trim() + "'";
            else if (combosch.SelectedIndex == 2)
                sqlStr = "select * from caseBook where writer='" + txtsch.Text.Trim() + "'";
            

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string st=dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string str = "select * from volume where cID='" + st + "'";
            DataSet ds = new DataSet();
            ds = Cdatabase.GetDataFromDB(str);
            if (ds != null)
            {
                dataGridView2.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("没有符合条件的记录!", "提示");
            }
        }
    }
}
