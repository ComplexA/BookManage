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
    public partial class editrd : Form
    {
        public editrd(string rid)
        {
            InitializeComponent();
            string sqlschcs = "select * from reader where rdID='" + rid + "'";
            DataSet ds = new DataSet();
            ds = Cdatabase.GetDataFromDB(sqlschcs);
            txtrdid.Text = rid;
            txtrdName.Text = ds.Tables[0].Rows[0]["rdname"].ToString();
            txtrddpt.Text = ds.Tables[0].Rows[0]["rddpt"].ToString();
            string[] rdbirth=ds.Tables[0].Rows[0]["rdbirth"].ToString().Split(' ');
            string[] birth=rdbirth[0].Split('/');
            txtYear.Text = birth[0];
            txtMonth.Text = birth[1];
            txtDay.Text = birth[2];
            if (ds.Tables[0].Rows[0]["rdsex"].ToString() == "男")
                comboBox1.SelectedIndex = 0;
            else comboBox1.SelectedIndex = 1;
        }

        public delegate void re();
        public event re refresh;

        private void btaddrd_Click(object sender, EventArgs e)
        {
            if (txtrdid.Text.Trim() == "" || txtrdName.Text.Trim() == "" 
                || txtYear.Text.Trim() == "" || txtMonth.Text.Trim() == "" 
                || txtDay.Text.Trim() == ""
                || txtrddpt.Text.Trim() == "" || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("请填写所有信息");
                return;
            }
            string sqlupcase = "update reader set rdname='" + txtrdName.Text.Trim() 
                + "',rdbirth='" + txtYear.Text.Trim() + "." + txtMonth.Text.Trim() + "." + txtDay.Text.Trim() 
                + "',rdsex='" + comboBox1.Text.Trim() 
                + "',rddpt='"+ txtrddpt.Text.Trim() +"' where rdID='"+txtrdid.Text.Trim()+"'";
            Cdatabase.UpdateDB(sqlupcase);
            MessageBox.Show("修改成功！");
            this.Close();
            this.refresh();
        }
    }
}
