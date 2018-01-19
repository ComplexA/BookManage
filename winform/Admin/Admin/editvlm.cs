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
    public partial class editvlm : Form
    {
        public editvlm(string vid)
        {
            InitializeComponent();
            string sqlsch = "select * from volume where vID='" + vid + "'";
            DataSet ds = new DataSet();
            ds = Cdatabase.GetDataFromDB(sqlsch);

            txtvid.Text = vid;
            txtdivision.Text=ds.Tables[0].Rows[0]["division"].ToString();
            txtvwriter.Text = ds.Tables[0].Rows[0]["vwriter"].ToString();
            txttopic.Text = ds.Tables[0].Rows[0]["topic"].ToString();
        }

        private void btedit_Click(object sender, EventArgs e)
        {
            if (txtvid.Text.Trim() == "" || 
                txtdivision.Text.Trim() == "" || 
                txtvwriter.Text.Trim() == ""||
                txttopic.Text.Trim()=="")
            {
                MessageBox.Show("请填写所有信息");
                return;
            }
            string sqlupvlm = "update volume set division='"+txtdivision.Text.Trim()
                +"',vwriter='"+txtvwriter.Text.Trim()
                +"',topic='"+txttopic.Text.Trim()
                +"' where vid='"+txtvid.Text.Trim()
                +"'";
            Cdatabase.UpdateDB(sqlupvlm);
            MessageBox.Show("修改成功");
            this.Close();
            this.refresh();
        }

        public delegate void re();
        public event re refresh;
    }
}
