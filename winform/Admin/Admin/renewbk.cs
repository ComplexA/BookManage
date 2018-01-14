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
    public partial class renewbk : Form
    {
        public renewbk()
        {
            InitializeComponent();
        }

        private void btrn_Click(object sender, EventArgs e)
        {
            if (txtrn.Text.Trim() == "")
            {
                MessageBox.Show("请填写图书编码");
                return;
            }

            string sql = "select * from lend where cID='" + txtrn.Text.Trim() + "'";
            DataSet dscase = new DataSet();
            Cdatabase.conn.ConnectionString = Cdatabase.connStr;
            Cdatabase.conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, Cdatabase.conn);
            adapter.Fill(dscase);
            Cdatabase.conn.Close();
            if (!(dscase.Tables[0].Rows.Count == 0))
            {
                if (!((bool)dscase.Tables[0].Rows[0]["renew"]))
                {
                    string sqluprn = "update lend set renew='true' where cID='" + txtrn.Text.Trim() + "'";
                    string sqlupdt = "update lend set rtndate=DATEADD(m,1,rtndate) where cID='" + txtrn.Text.Trim() + "'";
                    Cdatabase.UpdateDB(sqluprn);
                    Cdatabase.UpdateDB(sqlupdt);

                    string sqld = "select * from lend where cID='" + txtrn.Text.Trim() + "'";
                    DataSet dscased = new DataSet();
                    Cdatabase.conn.ConnectionString = Cdatabase.connStr;
                    Cdatabase.conn.Open();
                    SqlDataAdapter adapterd = new SqlDataAdapter(sqld, Cdatabase.conn);
                    adapterd.Fill(dscased);
                    Cdatabase.conn.Close();

                    string showinfo = "读者编码：" + UserPublic.userInfo[0].ToString() +
                    "\n图书编码：" + txtrn.Text.Trim() +
                    "\n借书日期：" + dscased.Tables[0].Rows[0]["lenddate"].ToString().Substring(0,9) +
                    "\n还书日期：" + dscased.Tables[0].Rows[0]["rtndate"].ToString().Substring(0,9);

                    MessageBox.Show(showinfo, "续借成功");
                }
                else
                {
                    MessageBox.Show("已经续借了！");
                }
            }
            else
            {
                MessageBox.Show("该图书未被借出");
                return;
            }
        }

        private void renewbk_Load(object sender, EventArgs e)
        {
            rid.Visible = false;
            ridcp.Visible = false;
            lenddt.Visible = false;
            lddtcp.Visible = false;
            rndt.Visible = false;
            rndtcp.Visible = false;
            rn.Visible = false;
            rncp.Visible = false;
        }

        private void showmess()
        {
            string sql = "select * from lend where cID='" + txtrn.Text.Trim() + "'";
            DataSet dscase = new DataSet();
            Cdatabase.conn.ConnectionString = Cdatabase.connStr;
            Cdatabase.conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, Cdatabase.conn);
            adapter.Fill(dscase);
            Cdatabase.conn.Close();
            if (!(dscase.Tables[0].Rows.Count == 0))
            {
                rid.Visible = true;
                ridcp.Visible = true;
                lenddt.Visible = true;
                lddtcp.Visible = true;
                rndt.Visible = true;
                rndtcp.Visible = true;
                rn.Visible = true;
                rncp.Visible = true;

                rid.Text = UserPublic.userInfo[0].ToString();
                lenddt.Text = dscase.Tables[0].Rows[0]["lenddate"].ToString().Substring(0, 9);
                rndt.Text = dscase.Tables[0].Rows[0]["rtndate"].ToString().Substring(0, 9);
                if (dscase.Tables[0].Rows[0]["renew"].ToString()=="True")
                {
                    rn.Text = "是";
                }
                else
                {
                    rn.Text = "否";
                }
            }
            else
            {
                //rid.Visible = false;
                rid.Visible = true;
                rid.Text = "未查询到该图书的借阅信息";
                ridcp.Visible = false;
                lenddt.Visible = false;
                lddtcp.Visible = false;
                rndt.Visible = false;
                rndtcp.Visible = false;
                rn.Visible = false;
                rncp.Visible = false;
                return;
            }
        }

        private void renewbk_Click(object sender, EventArgs e)
        {
            if (txtrn.Text.Trim() == "")
            {
                return;
            }
            else
            {
                showmess();
            }
        }
    }
}
