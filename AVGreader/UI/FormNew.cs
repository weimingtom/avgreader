using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AVGreader.Service;

namespace AVGreader.UI
{
    public partial class FormNew : Form
    {
        public FormNew()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(800, 600);

            //MessageBox.Show("游戏分辨率为：" + ClientSize.Width.ToString() + " x " + ClientSize.Height.ToString());
        }

        private void FormNew_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Application.Exit();
            else if (e.KeyCode == Keys.F)
                EngineSrv.flag = !EngineSrv.flag;
        }

        private void FormNew_FormClosing(object sender, FormClosingEventArgs e)
        {
            EngineSrv.NowRunState = MyEnum.RunStatement.END;
        }
    }
}