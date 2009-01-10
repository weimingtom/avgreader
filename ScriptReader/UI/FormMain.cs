using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ScriptReader.Domain;
using ScriptReader.Service;
using ScriptReader.UI;

namespace ScriptReader
{

    public partial class FormMain : Form
    {
        private string currentDir = AppDomain.CurrentDomain.BaseDirectory;
        Graphics GThumb;
        private string BGpath;
        private string CHpath;
        private string Words;
        long nowIndex = 1;
        Service.MyEnum.RunStatement nowStatus = MyEnum.RunStatement.RUNNING;
        bool isStroyInitialized = false;

        public FormMain()
        {
            InitializeComponent();

            BGpath = currentDir + @"DATA\IMG\background.jpg";
            CHpath = currentDir + @"DATA\IMG\actor.png";

            btnSTART.Enabled = false;
            btnStep.Enabled = false;
            checkBG.Checked = checkCH.Checked = checkTXT.Checked = true;
            btnBackColor.BackColor = Color.White;
            btnForeColor.ForeColor = Color.White;
            btnBackColor.ForeColor = Color.Black;
            btnForeColor.BackColor = Color.Black;

            Label lab = new Label();
            lab.BackColor = Color.Transparent;
            ThumbPicCH.Controls.Add(lab);
            btnStep.Text = "开始单步调试";

            GThumb = panel1.CreateGraphics();
            GThumb.Clear(Color.White);

            LoadFile();
        }

        private void initializeAll()
        {
            initStory();

            ThumbPicBG.Image = ScriptReader.Properties.Resources.black;
            ThumbPicCH.Image = ScriptReader.Properties.Resources.black;
            ThumbText.Text = "";
            rtbSTORY.Text = "";
            btnSTART.Enabled = false;
            btnStep.Enabled = false;
            tbInfoCH.Text = "";
            tbInfoFACE.Text = "";
            tbInfoSCENE.Text = "";
            tbInfoWORD.Text = "";
            tbScriptCmd.Text = "";
            HighlightStartIndex = 0;
            GThumb.Clear(Color.Black);
            btnStep.Text = "开始单步调试";
        }

        private void menuEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBG_CheckedChanged(object sender, EventArgs e)
        {
            ThumbPicBG.Visible = checkBG.Checked;
        }

        private void checkCH_CheckedChanged(object sender, EventArgs e)
        {
            ThumbPicCH.Visible = checkCH.Checked;
        }

        private void checkTXT_CheckedChanged(object sender, EventArgs e)
        {
            ThumbText.Visible = checkTXT.Checked;
        }

        private void ExampleDisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThumbPicBG.Image = ScriptReader.Properties.Resources._0000;
            ThumbPicCH.Image = ScriptReader.Properties.Resources._default;
            ThumbText.Text = "测试界面\n测试字符串~";
            Render();
        }

        private void DefaultDisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThumbPicBG.Image = ScriptReader.Properties.Resources.black;
            ThumbPicCH.Image = ScriptReader.Properties.Resources.black;
            ThumbText.Text = "";
            GThumb.Clear(Color.Black);
        }

        int HighlightStartIndex = 0;
        private void HighLightTesting(string cmd)
        {
            rtbSTORY.Select(HighlightStartIndex, cmd.Length);
            rtbSTORY.SelectionBackColor = Color.Red;
            rtbSTORY.SelectionColor = Color.White;
            if (nowIndex%20 == 0)
                rtbSTORY.ScrollToCaret();
            //tbScriptCmd.Text += (HighlightStartIndex.ToString() + "," + cmd.Length.ToString());
            HighlightStartIndex += cmd.Length;
            HighlightStartIndex++;
        }

        private void btnSTART_Click(object sender, EventArgs e)
        {
            groupScriptFunction.Enabled = false;
            initStory();
            MainLoop();
        }

        int clock = 1000;
        private void timer1_Tick(object sender, EventArgs e)
        {
            clock--;
            if (clock == 0)
                clock = 1000;
        }

        AvgsReader avgsReader = new AvgsReader();
        StoryReader2 storyReader = new StoryReader2();
        Story2 story = new Story2();
        private void initStory ()
        {
            //获得剧本
            story = storyReader.GetWholeStory();
            nowIndex = 1;
            nowStatus = MyEnum.RunStatement.RUNNING;
            isStroyInitialized = true;
            ShowIndex();
        }

        private void MainLoop ()
        {
            //一行一行判断并分发执行
            //foreach (string cmd in story.text)
            while (nowIndex <= story.LineNumber)
            {
                if (nowStatus == MyEnum.RunStatement.RUNNING || nowStatus == MyEnum.RunStatement.PAGE)
                {            
                    //高亮控件
                    QueryScript();
                    Application.DoEvents();
                }
                if (nowStatus == MyEnum.RunStatement.END)
                {
                    break;
                }
            }
        }

        private void QueryScript ()
        {
            string cmd = story.GetTextByIndex(nowIndex);
            tbScriptCmd.Text = cmd;
            HighLightTesting(cmd);

            if (cmd == "<PAGE>")
            {
                nowStatus = MyEnum.RunStatement.PAGE;
                HandlePage();
            }
            else if (cmd == "<BR>")
            {
                HandleBR();
            }
            else if (cmd == "<END>")
            {
                nowStatus = MyEnum.RunStatement.END;
                HandleEnd();
                return;
            }
            else if (cmd[0] == '<' && cmd[cmd.Length - 1] == '>')
            {
                nowStatus = MyEnum.RunStatement.RUNNING;
                int i;
                string detailCMD = "";
                string id = "";
                for (i = 1; cmd[i] != ' '; i++)
                    detailCMD += cmd[i];
                for (i++; cmd[i] != '>'; i++)
                    id += cmd[i];

                switch (detailCMD)
                {
                    case "SCENE": ShowScene(id); break;
                    case "ACTOR": ShowActor(id); break;
                    case "FACE": ShowFace(id); break;
                }
            }
            else if (cmd[0] != '<')
            {
                nowStatus = MyEnum.RunStatement.RUNNING;
                ShowText(cmd);
            }

            //指向下一行
            nowIndex++;
            ShowIndex();
        }

        private void Render()
        {
            if (checkBG.Checked == true)
            {
                //background
                Image pic = Image.FromFile(BGpath);
                GThumb.DrawImage(pic, 0, 0, panel1.Width, panel1.Height);
            }
            else
            {
                GThumb.Clear(Color.Black);
            }
            if (checkCH.Checked == true)
            {
                //actor
                Image pic = Image.FromFile(CHpath);
                int Width = pic.Width * panel1.Height / pic.Height;
                GThumb.DrawImage(pic, panel1.Width / 10, 0, Width, panel1.Height);
            }
            // 这里画上frame
            Image picf = Image.FromFile(currentDir + @"DATA\IMG\frame.png");
            GThumb.DrawImage(picf, 
                             panel1.Width / 10 + ThumbPicCH.Width / 2, 
                             panel1.Height / 2, 
                             panel1.Width - (panel1.Width / 5 + ThumbPicCH.Width / 2), 
                             panel1.Height / 2);
            if (checkTXT.Checked == true)
            {
                //words
                Font font = new Font("微软雅黑", 9);
                Brush brush = new SolidBrush(ThumbText.ForeColor);
                Rectangle rect = new Rectangle(140, 130, 255, 200);
                GThumb.DrawString(Words, font, brush, rect);
            }
        }

        private void ShowText(string words)
        {
            Words = Words + "\n" + words;
            Render();
            foreach (char ch in words)
            {
                ThumbText.Text += ch;
                tbInfoWORD.Text = ThumbText.Text;
                Application.DoEvents();
                //GroupDisplay.Refresh();
                //groupINFO.Refresh();
                //Application.DoEvents();
            }
        }

        private void ShowScene(string id)
        {
            Scene scene = avgsReader.GetSceneById(id);
            BGpath = scene.Path;
            Render();
            ThumbPicBG.Image = Image.FromFile(scene.Path);
            tbInfoSCENE.Text = scene.Name + "[" + scene.ID + "]";
            Application.DoEvents();
            //GroupDisplay.Refresh();
            //groupINFO.Refresh();
            System.Threading.Thread.Sleep(1000);
            Application.DoEvents();
        }

        private void ShowActor(string id)
        {
            Actor actor = avgsReader.GetActorById(id);
            CHpath = actor.Path;
            Render();
            ThumbPicCH.Image = Image.FromFile(actor.Path);
            tbInfoCH.Text = actor.Name + "[" + actor.ID + "]";
            Application.DoEvents();
            //GroupDisplay.Refresh();
            //groupINFO.Refresh();
        }

        private void ShowFace(string id)
        {

        }

        private void HandlePage ()
        {
            System.Threading.Thread.Sleep(850);
            ThumbText.Text = "";
            tbInfoWORD.Text = ThumbText.Text;
            Words = "";
        }

        private void HandleBR ()
        {
            ThumbText.Text += "\n";
            tbInfoWORD.Text = ThumbText.Text;
        }

        private void HandleEnd ()
        {

            MessageBox.Show(this, "脚本执行完毕！", "AVG Script Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
            groupScriptFunction.Enabled = true;
            isStroyInitialized = false;
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        private void LoadFile ()
        {
            string FileName = currentDir + @"DATA\AVGS\story.avgs";
            if (!System.IO.File.Exists(FileName))
            {
                MessageBox.Show("请确认当前目录下的DATA文件夹中存在story.avgs文件！");
                return;
            }
            rtbSTORY.LoadFile(FileName, RichTextBoxStreamType.PlainText);
            btnSTART.Enabled = true;
            btnStep.Enabled = true;
            nowIndex = 1;
        }

        private void EditFile ()
        {
            FormEditScript formEditScript = new FormEditScript();
            if (formEditScript.ShowDialog(this) != DialogResult.OK)
            {
                //MessageBox.Show("脚本编辑错误！\n或用户取消");
            }
            else
            {
                string FileName = currentDir + @"DATA\AVGS\story.avgs";
                rtbSTORY.LoadFile(FileName, RichTextBoxStreamType.PlainText);
                btnSTART.Enabled = true;
                btnStep.Enabled = true;
            }
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbSTORY.Text = "";
            btnSTART.Enabled = false;
            btnStep.Enabled = false;
        }

        private void btnForeColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = ThumbText.ForeColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ThumbText.ForeColor = colorDialog1.Color;
                btnForeColor.BackColor = colorDialog1.Color;
                btnBackColor.ForeColor = colorDialog1.Color;
            }
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = ThumbText.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ThumbText.BackColor = colorDialog1.Color;
                btnBackColor.BackColor = colorDialog1.Color;
                btnForeColor.ForeColor = colorDialog1.Color;
            }
        }

        private void FormMain_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void EditScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditFile();
        }

        private void btnScriptEdit_Click(object sender, EventArgs e)
        {
            EditFile();
        }

        private void btnScriptReload_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        private void btnScriptClose_Click(object sender, EventArgs e)
        {
            ThumbText.Text = "";
            rtbSTORY.Text = "";
            btnSTART.Enabled = false;
            btnStep.Enabled = false;
            tbInfoCH.Text = "";
            tbInfoFACE.Text = "";
            tbInfoSCENE.Text = "";
            tbInfoWORD.Text = "";
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.ShowDialog();
        }

        private void btnSTOP_Click(object sender, EventArgs e)
        {
            if (isStroyInitialized == true)
            {
                nowIndex = story.LineNumber;
                nowStatus = MyEnum.RunStatement.END;
                QueryScript();
            }
            else
            {
                MessageBox.Show("调试信息：脚本story未初始化！\n用户信息：没有开始不能停止谢谢。。。");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            initializeAll();
        }

        private void btnStep_Click(object sender, EventArgs e)
        {
            if (isStroyInitialized == true)
            {
                btnStep.Text = "单步执行";
                QueryScript();
                Application.DoEvents();
            }
            else
            {
                initStory();
                btnStep.Text = "单步执行";
                MessageBox.Show("开始单步调试，初始化story成功\n从下一次点击单步执行开始正常调试。。。");
                groupScriptFunction.Enabled = false;
            }
        }

        private void ShowIndex ()
        {
            if (isStroyInitialized == true)
            {
                tbIndexNow.Text = nowIndex.ToString();
                tbIndexAll.Text = story.LineNumber.ToString();
            }
            else
            {
                MessageBox.Show("调试信息：脚本story未初始化！");
            }
        }

        private void btnGOBACK_Click(object sender, EventArgs e)
        {
            nowIndex--;
            ShowIndex();
        }

        private void btnFORWARD_Click(object sender, EventArgs e)
        {
            nowIndex++;
            ShowIndex();
        }
    }
}