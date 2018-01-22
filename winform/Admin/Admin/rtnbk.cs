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
    public partial class rtnbk : Form
    {
        public rtnbk()
        {
            InitializeComponent();
        }

        private void btrtn_Click(object sender, EventArgs e)
        {
            if (txtrtn.Text.Trim() == "")
            {
                MessageBox.Show("请填写图书编码");
                return;
            }

            //修改图书的状态、从lend表中删去此行、判断日期，如果日期在今天之后则提醒
            string sql = "select * from lend where cID='"+txtrtn.Text.Trim()+"'";
            DataSet dscase = new DataSet();
            Cdatabase.conn.ConnectionString = Cdatabase.connStr;
            Cdatabase.conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, Cdatabase.conn);
            adapter.Fill(dscase);
            Cdatabase.conn.Close();
            if (!(dscase.Tables[0].Rows.Count == 0))
            {
                string sqlupcase = "update caseBook set state='True' where caseID='"+txtrtn.Text.Trim()+"'";
                string sqldelete = "delete from lend where cID='" + txtrtn.Text.Trim() + "'";
                
                DateTime d = Convert.ToDateTime(dscase.Tables[0].Rows[0]["rtndate"].ToString());
                if (DateTime.Now < d)
                {
                    Cdatabase.UpdateDB(sqlupcase);
                    Cdatabase.UpdateDB(sqldelete);
                    MessageBox.Show("ok");
                    txtrtn.Text="";
                }
                else
                {
                    if (MessageBox.Show("超时" + (DateTime.Now - d).TotalDays.ToString() + "天", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cdatabase.UpdateDB(sqlupcase);
                        Cdatabase.UpdateDB(sqldelete);
                    }
                }
            }
            else
            {
                MessageBox.Show("该图书未被借出");
            }

        }
    }
}
