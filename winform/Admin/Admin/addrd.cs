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
    public partial class addrd : Form
    {
        public addrd()
        {
            InitializeComponent();
        }

        private void btaddrd_Click(object sender, EventArgs e)
        {
            if (checkrd())
                return;
            
            if (txtrdid.Text.Trim() == ""||txtrdName.Text.Trim() == ""
                || txtYear.Text.Trim() == "" || txtMonth.Text.Trim() == "" || txtDay.Text.Trim() == "" 
                ||txtrddpt.Text.Trim() == "" ||comboBox1.SelectedIndex==-1)
            {
                MessageBox.Show("请填写所有信息");
                return;
            }
            string sqlupcase = "insert into reader values('" + txtrdid.Text.Trim() + "','" 
                + txtrdName.Text.Trim() + "','"
                   + txtYear.Text.Trim()+"." + txtMonth.Text.Trim() + "." + txtDay.Text.Trim() + "','"
                + comboBox1.Text.Trim() + "','"
                 + txtrddpt.Text.Trim() +
                "')";
            Cdatabase.UpdateDB(sqlupcase);
            MessageBox.Show("添加成功！");
            txtrdName.Text = "";
            txtYear.Text = "";
            txtMonth.Text = "";
            txtDay.Text = "";
            txtrddpt.Text = "";
            txtrdid.Text = "";
     
        }

        private void txtrdid_Leave(object sender, EventArgs e)
        {
            checkrd();
        }

        private bool checkrd()
        {
            string sqlStr = "select * from reader where rdID='" + txtrdid.Text.Trim() + "'";
            DataSet ds = new DataSet();
            Cdatabase.conn.ConnectionString = Cdatabase.connStr;
            Cdatabase.conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, Cdatabase.conn);
            adapter.Fill(ds);
            Cdatabase.conn.Close();
            if (ds.Tables[0].Rows.Count != 0)
            {
                MessageBox.Show("该读者已经存在");
                return true;
            }
            else return false;
        }
    }
}
