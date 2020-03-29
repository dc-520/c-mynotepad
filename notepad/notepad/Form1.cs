using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//命名空间
using System.Drawing.Text;
using System.Collections;
using System.IO;

namespace notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //窗体加载事件 
        private void Form1_Load(object sender, EventArgs e)
        {
            //窗体加载时要加载系统字体
            InstalledFontCollection myFonts = new InstalledFontCollection();
            //获取InstalledFontCollection对象的数组
            FontFamily[] ff = myFonts.Families;
            //声明一个Arraylist变量
            ArrayList list = new ArrayList();
            //获取系统的数组列表集合的长度
            int count = ff.Length;
            //使用for循环把字体名称写入到字体列表控件中
            for (int i = 0; i < count; i++)
            {
                string FontName = ff[i].Name;
                toolStripComboBoxFont.Items.Add(FontName);
            }
        }

        //加粗按钮
        private void toolStripButtonBold_Click(object sender, EventArgs e)
        {
            //点击按钮加粗，加粗时再点击按钮取消
            if (textBoxNote.Font.Bold == false)
            {
                textBoxNote.Font = new Font(textBoxNote.Font, FontStyle.Bold);
            }
            else
            {
                textBoxNote.Font = new Font(textBoxNote.Font, FontStyle.Regular);
            }

           
            
        }
        //倾斜按钮
        private void toolStripButtonItalic_Click(object sender, EventArgs e)
        {
            if (textBoxNote.Font.Italic == false)
            {
                textBoxNote.Font = new Font(textBoxNote.Font, FontStyle.Italic);
            }
            else
            {
                textBoxNote.Font = new Font(textBoxNote.Font, FontStyle.Regular);
            }

            
        }

        //改变选择字体的索引事件
        private void toolStripComboBoxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fontName = toolStripComboBoxFont.Text;
            float fontsize = float.Parse(toolStripComboBoxSize.Text);
            textBoxNote.Font = new Font(fontName, fontsize);
        }
        //改变字体大小
        private void toolStripComboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fontName = toolStripComboBoxFont.Text;
            float fontsize = float.Parse(toolStripComboBoxSize.Text);
            textBoxNote.Font = new Font(fontName, fontsize);
        }

        private void toolStripComboBoxSize_TextChanged(object sender, EventArgs e)
        {
            string fontName = toolStripComboBoxFont.Text;
            float fontsize = float.Parse(toolStripComboBoxSize.Text);
            textBoxNote.Font = new Font(fontName, fontsize);
        }
        //保存文件
        private void toolStripButtonsave_Click(object sender, EventArgs e)
        {
            if (textBoxNote.Text.Trim() != "")
            {
                if (this.Text == "Trl的记事本")
                {
                    //新建一个保存文件的对话框
                    //创建一个筛选器
                    saveFileDialog1.Filter = ("文本文档(*.txt)|*.txt");
                    //判断用户点击的是保存还是取消按钮
                    if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        //保存文件到用户指定的目录位置
                        //获取用户选择的文件及路径
                        string path = saveFileDialog1.FileName;
                        //保存文件到指定路径
                        //false代表要覆盖
                        StreamWriter sw = new StreamWriter(path, false);
                        sw.WriteLine(textBoxNote.Text.Trim());
                        this.Text = path;
                        sw.Flush();
                        sw.Close();
                    }
                }
                else
                {
                    //保存文件到用户指定的目录位置
                    //获取用户选择的文件及路径
                    string path = this.Text;
                    //保存文件到指定路径
                    //false代表要覆盖
                    StreamWriter sw = new StreamWriter(path, false);
                    sw.WriteLine(textBoxNote.Text.Trim());
                    sw.Flush();
                    sw.Close();
                }
                
            }
            else
            {
                MessageBox.Show("空文档不能保存", "信息提示",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //打开文档
        private void toolStripButtonopen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = ("文本文档(*.txt)|*.txt");
            //判断用户点击的是保存还是取消按钮
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //获取文件打开的路径
                string path = openFileDialog1.FileName;
                StreamReader st = new StreamReader(path, Encoding.UTF8);
                //读取文档中的数据流
                string text = st.ReadToEnd();
                textBoxNote.Text = text;
                //将打开的文件路径写到当前窗体的text属性中
                this.Text = path;
                //打开文件时，清空记号标签
                toolStripLabelMake.Text = "Trl的记事本";
                st.Close();


            }

        }
        //编辑文本时
        private void textBoxNote_TextChanged(object sender, EventArgs e)
        {
            toolStripLabelMake.Text = "*";
        }
        //窗体关闭事件
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //判断记号
            if (toolStripLabelMake.Text == "*")
            {
                //如果是*号，提示用户
                DialogResult dr = MessageBox.Show("文档尚未保存，宝贝确定要继续退出吗？", "信息询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Dispose();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
        //新建按钮
        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            textBoxNote.Text = "";
            toolStripLabelMake.Text = "";
            this.Text = "Trl的记事本";
        }
    }
}
