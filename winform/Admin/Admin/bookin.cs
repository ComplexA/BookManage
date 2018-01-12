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
    public partial class bookin : Form
    {
        //bool flag1 = false;
        public bookin()
        {
            InitializeComponent();
        }

        private void vnumup_ValueChanged(object sender, EventArgs e)
        {
            int upvnum = Convert.ToInt16(vnumup.Value);
            vindata.RowCount = upvnum;
        }

        private void bookin_Load(object sender, EventArgs e)
        {
            vindata.RowCount = 1;
        }

        private void btdpl_Click(object sender, EventArgs e)
        {
            if (txtisbn.Text.Trim() == "")
            {
                MessageBox.Show("ISBN不能为空");
                return;
            }

            string sqlStr = "select * from caseBook where isbn='" + txtisbn.Text.Trim() + "'";
            DataSet ds = new DataSet();
            Cdatabase.conn.ConnectionString = Cdatabase.connStr;
            Cdatabase.conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, Cdatabase.conn);
            adapter.Fill(ds);
            Cdatabase.conn.Close();
            if (ds.Tables[0].Rows.Count == 0)
                MessageBox.Show("之前未被录入");
            else 
            {
                //flag1 = true;
                DataTable caseBk = ds.Tables[0];
                //txtcaseID.Text = caseBk.Rows[0]["caseID"].ToString();
                txtcname.Text = caseBk.Rows[0]["caseName"].ToString();
                txtwriter.Text = caseBk.Rows[0]["writer"].ToString();
                txtdpt.Text=caseBk.Rows[0]["department"].ToString();
                txtfloor.Text = caseBk.Rows[0]["floor"].ToString();
                txtisbn.Text = caseBk.Rows[0]["isbn"].ToString();
                txtpress.Text = caseBk.Rows[0]["press"].ToString();
                txtpub.Text = caseBk.Rows[0]["pubdate"].ToString();
                txtrow.Text = caseBk.Rows[0]["row"].ToString();
                txtshelf.Text = caseBk.Rows[0]["shelf"].ToString();
                txtclass.Text = caseBk.Rows[0]["classID"].ToString();
                vnumup.Value = Convert.ToInt16(caseBk.Rows[0]["vnum"]);

                string sqlSt = "select * from volume where cID='" + caseBk.Rows[0]["caseID"].ToString() + "'";
                DataSet dsv = new DataSet();
                Cdatabase.conn.ConnectionString = Cdatabase.connStr;
                Cdatabase.conn.Open();
                SqlDataAdapter adapte = new SqlDataAdapter(sqlSt, Cdatabase.conn);
                adapte.Fill(dsv);
                Cdatabase.conn.Close();
                for (int i = 0; i < Convert.ToInt16(vnumup.Value); i++)
                {
                    vindata.Rows[i].Cells[1].Value = dsv.Tables[0].Rows[i]["division"];
                    vindata.Rows[i].Cells[2].Value = dsv.Tables[0].Rows[i]["vwriter"];
                    vindata.Rows[i].Cells[3].Value = dsv.Tables[0].Rows[i]["topic"];
                }

            }
        }

        private void btbookin_Click(object sender, EventArgs e)
        {
            if (txtcaseID.Text.Trim() == "" || txtclass.Text.Trim() == ""||txtcname.Text.Trim() == "" 
                ||txtdpt.Text.Trim() == "" ||txtfloor.Text.Trim() == "" ||txtisbn.Text.Trim() == "" 
                ||txtpress.Text.Trim() == "" ||txtpub.Text.Trim() == "" ||txtrow.Text.Trim() == "" 
                ||txtshelf.Text.Trim() == "" ||txtwriter.Text.Trim() == "" ||chkvin())
            {
                MessageBox.Show("请填写所有信息");
                return;
            }

            for (int i = 0; i < vnumup.Value; i++)
            {
                string sqlSt = "select * from volume where caseID='" + vindata.Rows[i].Cells[0].Value.ToString() + "'";
                DataSet dsv = new DataSet();
                Cdatabase.conn.ConnectionString = Cdatabase.connStr;
                Cdatabase.conn.Open();
                SqlDataAdapter adapte = new SqlDataAdapter(sqlSt, Cdatabase.conn);
                adapte.Fill(dsv);
                Cdatabase.conn.Close();
                if (!(dsv.Tables[0].Rows.Count == 0))
                {
                    MessageBox.Show("册号重复");
                    vindata.Rows[i].Cells[0].Value = "";
                    return;
                }
            }

            string sqlupcase = "insert into caseBook values('" + txtcaseID.Text.Trim() + "','" 
                + txtcname.Text.Trim() + "','"+ txtpress.Text.Trim() + "','"
                + txtpub.Text.Trim() + "','" + vnumup.Value.ToString() + "','"
                + txtisbn.Text.Trim() + "','" + txtdpt.Text.Trim() + "','"
                + txtclass.Text.Trim() + "','" + txtrow.Text.Trim() + "','"
                + txtshelf.Text.Trim() + "','" + txtfloor.Text.Trim() + "','" 
                + txtwriter.Text.Trim() + "')";
            insertvlm();
            //MessageBox.Show(sqlupcase);
            Cdatabase.UpdateDB(sqlupcase);
            MessageBox.Show("录入成功！");
            txtcaseID.Text = "";
            txtcname.Text = "";
            txtwriter.Text = "";
            txtdpt.Text = "";
            txtfloor.Text ="";
            txtisbn.Text = "";
            txtpress.Text = "";
            txtpub.Text = "";
            txtrow.Text = "";
            txtshelf.Text = "";
            txtclass.Text = "";
            vnumup.Value = 1;
            for (int j = 0; j < 4; j++)
                vindata.Rows[0].Cells[j].Value = "";
        }

        private bool chkvin()//判断datagridview是否填写完整
        {
            for (int i = 0; i < vnumup.Value; i++)
                for (int j = 0; j < 4; j++)
                    if (vindata.Rows[i].Cells[j].Value == null)
                        return true;
            return false;
        }

        private void insertvlm()
        {
            for (int i = 0; i < vnumup.Value; i++)
            {
                string sqlinv = "insert into volume values('";
                for (int j = 0; j < 4; j++)
                {
                    sqlinv += vindata.Rows[i].Cells[j].Value.ToString()+"','";
                }
                //sqlinv =sqlinv.Substring(0,sqlinv.Length-2);
                sqlinv += "false','"+txtcaseID.Text.ToString()+"')";
                Cdatabase.UpdateDB(sqlinv);
                //MessageBox.Show(sqlinv);
            }
        }

        private void txtcaseID_Leave(object sender, EventArgs e)
        {
            string sqlSt = "select * from caseBook where caseID='" + txtcaseID.Text.ToString() + "'";
            DataSet dsv = new DataSet();
            Cdatabase.conn.ConnectionString = Cdatabase.connStr;
            Cdatabase.conn.Open();
            SqlDataAdapter adapte = new SqlDataAdapter(sqlSt, Cdatabase.conn);
            adapte.Fill(dsv);
            Cdatabase.conn.Close();
            if (!(dsv.Tables[0].Rows.Count == 0))
            {
                MessageBox.Show("图书编码重复");
                txtcaseID.Text = "";
            }
        }
    }
}
