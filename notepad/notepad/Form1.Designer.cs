namespace notepad
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonopen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonsave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBold = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonItalic = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBoxFont = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBoxSize = new System.Windows.Forms.ToolStripComboBox();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonopen,
            this.toolStripButtonsave,
            this.toolStripButtonBold,
            this.toolStripButtonItalic,
            this.toolStripComboBoxFont,
            this.toolStripComboBoxSize});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(588, 55);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonopen
            // 
            this.toolStripButtonopen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripButtonopen.Image = global::notepad.Properties.Resources.folder;
            this.toolStripButtonopen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonopen.Name = "toolStripButtonopen";
            this.toolStripButtonopen.Size = new System.Drawing.Size(55, 52);
            this.toolStripButtonopen.Text = " 打开";
            this.toolStripButtonopen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButtonsave
            // 
            this.toolStripButtonsave.Image = global::notepad.Properties.Resources.save;
            this.toolStripButtonsave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonsave.Name = "toolStripButtonsave";
            this.toolStripButtonsave.Size = new System.Drawing.Size(50, 52);
            this.toolStripButtonsave.Text = "保存";
            this.toolStripButtonsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButtonBold
            // 
            this.toolStripButtonBold.Image = global::notepad.Properties.Resources.bold;
            this.toolStripButtonBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBold.Name = "toolStripButtonBold";
            this.toolStripButtonBold.Size = new System.Drawing.Size(50, 52);
            this.toolStripButtonBold.Text = "加粗";
            this.toolStripButtonBold.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButtonItalic
            // 
            this.toolStripButtonItalic.Image = global::notepad.Properties.Resources.italic;
            this.toolStripButtonItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonItalic.Name = "toolStripButtonItalic";
            this.toolStripButtonItalic.Size = new System.Drawing.Size(50, 52);
            this.toolStripButtonItalic.Text = "倾斜";
            this.toolStripButtonItalic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripComboBoxFont
            // 
            this.toolStripComboBoxFont.Name = "toolStripComboBoxFont";
            this.toolStripComboBoxFont.Size = new System.Drawing.Size(121, 55);
            this.toolStripComboBoxFont.Text = "字体";
            // 
            // toolStripComboBoxSize
            // 
            this.toolStripComboBoxSize.Items.AddRange(new object[] {
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "24",
            "28",
            "32",
            "48"});
            this.toolStripComboBoxSize.Name = "toolStripComboBoxSize";
            this.toolStripComboBoxSize.Size = new System.Drawing.Size(121, 55);
            this.toolStripComboBoxSize.Text = "字号";
            // 
            // textBoxNote
            // 
            this.textBoxNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNote.Location = new System.Drawing.Point(3, 55);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxNote.Size = new System.Drawing.Size(588, 472);
            this.textBoxNote.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 530);
            this.Controls.Add(this.textBoxNote);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Text = "我的记事本";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonopen;
        private System.Windows.Forms.ToolStripButton toolStripButtonsave;
        private System.Windows.Forms.ToolStripButton toolStripButtonBold;
        private System.Windows.Forms.ToolStripButton toolStripButtonItalic;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxFont;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxSize;
        private System.Windows.Forms.TextBox textBoxNote;
    }
}

