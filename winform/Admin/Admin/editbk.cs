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
    public partial class editbk : Form
    {
         
        public editbk(string bookID)
        {
            InitializeComponent();
            string sqlschcs = "select * from caseBook where caseID='"+bookID+"'";
            DataSet ds = new DataSet();
            ds=Cdatabase.GetDataFromDB(sqlschcs);
            txtcaseID.Text = bookID;
            txtisbn.Text=ds.Tables[0].Rows[0]["isbn"].ToString();
            txtcname.Text = ds.Tables[0].Rows[0]["caseName"].ToString();
            txtwriter.Text = ds.Tables[0].Rows[0]["writer"].ToString();
            txtdpt.Text = ds.Tables[0].Rows[0]["department"].ToString();
            txtfloor.Text = ds.Tables[0].Rows[0]["floor"].ToString();
            txtpress.Text = ds.Tables[0].Rows[0]["press"].ToString();
            txtpub.Text = ds.Tables[0].Rows[0]["pubdate"].ToString();
            txtrow.Text = ds.Tables[0].Rows[0]["row"].ToString();
            txtshelf.Text = ds.Tables[0].Rows[0]["shelf"].ToString();
            txtclass.Text = ds.Tables[0].Rows[0]["classID"].ToString();
        }

        private void btbookin_Click(object sender, EventArgs e)
        {
            if (txtcaseID.Text.Trim() == "" || txtclass.Text.Trim() == "" || txtcname.Text.Trim() == ""
                || txtdpt.Text.Trim() == "" || txtfloor.Text.Trim() == "" || txtisbn.Text.Trim() == ""
                || txtpress.Text.Trim() == "" || txtpub.Text.Trim() == "" || txtrow.Text.Trim() == ""
                || txtshelf.Text.Trim() == "" || txtwriter.Text.Trim() == "" )
            {
                MessageBox.Show("请填写所有信息");
                return;
            }
            string sqlupcs = "update caseBook set caseName='"+txtcname.Text.Trim()
                +"',writer='"+txtwriter.Text.Trim()
                +"',department='"+txtdpt.Text.Trim()
                +"',floor='"+txtfloor.Text.Trim()
                +"',press='"+txtpress.Text.Trim()
                +"',pubdate='"+txtpub.Text.Trim()
                +"',row='"+txtrow.Text.Trim()
                +"',shelf='"+txtshelf.Text.Trim()
                +"',classID='"+txtclass.Text.Trim()
                +"' where caseID='"+txtcaseID.Text.Trim()+"'";
            Cdatabase.UpdateDB(sqlupcs);
            MessageBox.Show("修改成功");
            this.Close();
            this.refresh();
        }


        public delegate void re();
        public event re refresh;

    }
}
