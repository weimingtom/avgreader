using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SepLineTest2.UI
{
    public partial class FormEditScript : Form
    {
        private string currentDir = AppDomain.CurrentDomain.BaseDirectory;
        public FormEditScript()
        {
            InitializeComponent();
            btnHelp.Text = "语法规则";

            string FileName = currentDir + @"DATA\AVGS\story.avgs";
            richTextBox1.LoadFile(FileName, RichTextBoxStreamType.PlainText);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            if (btnHelp.Text == "语法规则")
            {
                btnHelp.Text = "返回编辑";
                richTextBox1.Clear();
                string FileName = currentDir + @"DATA\AVGS\rules.txt";
                richTextBox1.LoadFile(FileName, RichTextBoxStreamType.PlainText);
            }
            else if (btnHelp.Text == "返回编辑")
            {
                btnHelp.Text = "语法规则";
                richTextBox1.Clear();
                string FileName = currentDir + @"DATA\AVGS\story.avgs";
                richTextBox1.LoadFile(FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "确定放弃修改，返回测试界面吗？", "warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string FileName = currentDir + @"DATA\AVGS\story.avgs";
            try
            {
                richTextBox1.SaveFile(FileName, RichTextBoxStreamType.PlainText);
                MessageBox.Show("保存成功！");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存失败！\n" + ex.Message);
            }

        }

    }
}