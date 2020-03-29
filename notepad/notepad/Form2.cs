using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notepad
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //新建
        private void ToolStripMenuItemNew_Click(object sender, EventArgs e)
        {
             //实例化一个子窗体对象
            Form1 child = new Form1();
            //设置子窗体的父窗体
            child.MdiParent = this;
            //打开子窗体
            child.Show();
        }
        //关闭
        private void ToolStripMenuItemClose_Click(object sender, EventArgs e)
        {
            Form frm = this.ActiveMdiChild;
            frm.Close();
        }
        //关闭全部
        private void ToolStripMenuItemCloseAll_Click(object sender, EventArgs e)
        {
            //this.MdiChildren获取父窗体的子窗体的集合
            foreach (Form form in this.MdiChildren)
            {
                Form frm = this.ActiveMdiChild;
                frm.Close();
            }
        }
        //退出
        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
