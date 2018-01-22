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
             this.caseBookTableAdapter.Fill(this.bookmanageDataSet2.caseBook);
            
        }

        private void btsch_Click(object sender, EventArgs e)
        {
            string sqlStr = "";
            if (txtsch.Text.Trim() == "")
            {
                MessageBox.Show("请输入需要查询的“" + combosch.SelectedItem.ToString().Trim() + "”!", "提示");
                return;
            }
            else if (combosch.SelectedIndex == 0)
                sqlStr = "select * from caseBook where caseID='" + txtsch.Text.Trim() + "'";
            else if (combosch.SelectedIndex == 1)
                sqlStr = "select * from caseBook where caseName like '%" + txtsch.Text.Trim() + "%'";
            else if (combosch.SelectedIndex == 2)
                sqlStr = "select * from caseBook where writer like '%" + txtsch.Text.Trim() + "%'";
            else if (combosch.SelectedIndex == 3)
                sqlStr = "select * from caseBook where caseID in (select cID from volume where division like '%" + txtsch.Text.Trim() + "%')";
            else if (combosch.SelectedIndex == 4)
                sqlStr = "select * from caseBook where caseID in (select cID from volume where vwriter like '%" + txtsch.Text.Trim() + "%')";

            
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

        private void btdelete_Click(object sender, EventArgs e)
        {
            string dltnm = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string dltid = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("确定删除\n图书编码为" + dltid + "\n书名为\t" + dltnm + "？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sqldltv = "delete from volume where cID ='"+dltid+"'";
                string sqldltb = "delete from caseBook where caseID='"+dltid+"'";
                Cdatabase.UpdateDB(sqldltb);
                Cdatabase.UpdateDB(sqldltv);
                MessageBox.Show("删除成功");

                RefreshForm();
            }
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

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!string.IsNullOrEmpty(dataGridView2.CurrentRow.Cells[0].Value.ToString()))
            {
                editvlm editform = new editvlm(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                editform.refresh += RefreshForm;
                editform.Show();
            }
        }

        public void RefreshForm()
        {
            dataGridView1.DataSource = Cdatabase.GetDataFromDB("select * from caseBook").Tables[0];
            dataGridView2.DataSource = Cdatabase.GetDataFromDB("select * from volume").Tables[0];
        }
    }
}
