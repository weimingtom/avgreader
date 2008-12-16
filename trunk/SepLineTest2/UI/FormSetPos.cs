using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SepLineTest2.UI
{
    public partial class FormSetPos : Form
    {
        private long _newIndex = 1;
        public long newIndex
        {
            get { return _newIndex; }
            set { _newIndex = value; }
        }

        private long newLineNumber = 1;

//         public FormSetPos(long LineNumber)
//         {
//             InitializeComponent();
// 
//             newIndex = 1;
//             LineNumber = 1;
//             tbPosition.Text = newIndex.ToString();
//         }

        public FormSetPos(long LineNumber, long index)
        {
            InitializeComponent();

            newIndex = index;
            newLineNumber = LineNumber;
            tbPosition.Text = newIndex.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //防止空白
            if (tbPosition.Text == "")
            {
                MessageBox.Show("行号文本框内不能为空！\n请填入要定位的行号！", "注意！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //防止出现异常字符
            try
            {
                newIndex = Convert.ToInt64(tbPosition.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message + "\n请确定你已经输入，\n并且输入的是数字。", "注意！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //防止输入数字不在脚本范围内
            if (newIndex > newLineNumber || newIndex < 1)
            {
                MessageBox.Show("输入数字非法！\n请确定你输入的数字在1到脚本最大长度之间！", "注意！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //处理
            this.DialogResult = DialogResult.OK;

        }

    }
}