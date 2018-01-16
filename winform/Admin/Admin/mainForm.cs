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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            bookin bki = new bookin();
            bki.MdiParent = this;
            bki.Show();
        }

        private void 查看所有图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allbk bki = new allbk();
            bki.MdiParent = this;
            bki.Show();
        }

        private void 借书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lendbk bki = new lendbk();
            bki.MdiParent = this;
            bki.Show();
        }

        private void 图书查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            schbk bki = new schbk();
            bki.MdiParent = this;
            bki.Show();
        }

        private void 添加读者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addrd bki = new addrd();
            bki.MdiParent = this;
            bki.Show();
        }

        private void 查询读者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            schrd bki = new schrd();
            bki.MdiParent = this;
            bki.Show();
        }

        private void 查看所有读者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allrd bki = new allrd();
            bki.MdiParent = this;
            bki.Show();
        }

        private void 还书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtnbk bki = new rtnbk();
            bki.MdiParent = this;
            bki.Show();
        }

        private void 续借ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renewbk bki = new renewbk();
            bki.MdiParent = this;
            bki.Show();
        }

        private void 所有借阅信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alllend bki = new alllend();
            bki.MdiParent = this;
            bki.Show();
        }

        private void tButton5_Click(object sender, EventArgs e)
        {
            person bki = new person();
            bki.MdiParent = this;
            bki.Show();
        }

    }
}
