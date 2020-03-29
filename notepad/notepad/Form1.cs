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
    }
}
