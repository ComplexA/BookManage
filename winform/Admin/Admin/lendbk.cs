using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Admin
{
    public partial class lendbk : Form
    {
        public lendbk()
        {
            InitializeComponent();
        }

        private void btlend_Click(object sender, EventArgs e)
        {
            if (txtlendcid.Text.Trim() == "" || txtlendrid.Text.Trim() == "")
            {
                MessageBox.Show("请填写完整信息");
                return;
            }

            if (chkcid() && chkrid())
            {
                string sqllendbk = "insert into lend values('"+txtlendrid.Text.Trim()
                    + "','" + txtlendcid.Text.Trim() + "','" + DateTime.Now.ToString("yyyy-MM-dd")
                    + "','" + DateTime.Now.AddMonths(1).ToString("yyyy-MM-dd") + " ','false')";
                string sqlcasest = "update caseBook set state='true' where caseID='"+txtlendcid.Text.Trim()+"'";
                string showinfo = "读者编码：" + txtlendrid.Text.Trim() +
                    "\n图书编码：" + txtlendcid.Text.Trim()+
                    "\n借书日期：" + DateTime.Now.ToString("yyyy-MM-dd") +
                    "\n还书日期：" + DateTime.Now.AddMonths(1).ToString("yyyy-MM-dd");

                if (MessageBox.Show(showinfo, "借书信息", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Cdatabase.UpdateDB(sqllendbk);
                    Cdatabase.UpdateDB(sqlcasest);
                    MessageBox.Show("ok");
                    txtlendcid.Text = "";
                    txtlendrid.Text = "";
                }
            }
        }

        private bool chkcid()
        {
            string sqlchkcid = "select * from caseBook where caseID='"+txtlendcid.Text.Trim()+"' and state='True'";
            DataSet dscase = new DataSet();
            Cdatabase.conn.ConnectionString = Cdatabase.connStr;
            Cdatabase.conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlchkcid, Cdatabase.conn);
            adapter.Fill(dscase);
            Cdatabase.conn.Close();
            if (!(dscase.Tables[0].Rows.Count == 0))
                return true;
            else
            {
                MessageBox.Show("该图书编码不存在");
                return false;
            }
        }

        private bool chkrid()
        {
            string sqlchkrid = "select * from reader where rdID='" + txtlendrid.Text.Trim() + "'";
            DataSet dscase = new DataSet();
            Cdatabase.conn.ConnectionString = Cdatabase.connStr;
            Cdatabase.conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlchkrid, Cdatabase.conn);
            adapter.Fill(dscase);
            Cdatabase.conn.Close();
            if (!(dscase.Tables[0].Rows.Count == 0))
                return true;
            else
            {
                MessageBox.Show("该读者编码不存在");
                return false;
            }
        }
    }
}
