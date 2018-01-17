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

     

        private void bookin_Load(object sender, EventArgs e)
        {
            //vindata.RowCount = 1;
        }

        private void btdpl_Click(object sender, EventArgs e)
        {
            if (txtrdid.Text.Trim() == "")
            {
                MessageBox.Show("读者号不能为空");
                return;
            }

            string sqlStr = "select * from reader where rdID='" + txtrdid.Text.Trim() + "'";
            DataSet ds = new DataSet();
            Cdatabase.conn.ConnectionString = Cdatabase.connStr;
            Cdatabase.conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, Cdatabase.conn);
            adapter.Fill(ds);
            Cdatabase.conn.Close();
            if (ds.Tables[0].Rows.Count != 0)
                MessageBox.Show("该读者已经存在");
            else {
                MessageBox.Show("该读者号可用，请录入详细信息");
            }
        }

        private void btbookin_Click(object sender, EventArgs e)
        {
            if (txtrdName.Text.Trim() == "" || txtYear.Text.Trim() == "" || txtMonth.Text.Trim() == "" || txtDay.Text.Trim() == "" || txtrdid.Text.Trim() == "" ||txtrddpt.Text.Trim() == "" )
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
            //insertvlm();
            //MessageBox.Show(sqlupcase);
            Cdatabase.UpdateDB(sqlupcase);
            MessageBox.Show("录入成功！");
            txtrdName.Text = "";
            txtYear.Text = "";
            txtMonth.Text = "";
            txtDay.Text = "";
            txtrddpt.Text = "";
            
            txtrdid.Text = "";
     
        }

 

     

        private void txtcaseID_Leave(object sender, EventArgs e)
        {
  
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
