namespace ScriptReader
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GroupDisplay = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ThumbText = new System.Windows.Forms.RichTextBox();
            this.ThumbPicCH = new System.Windows.Forms.PictureBox();
            this.ThumbPicBG = new System.Windows.Forms.PictureBox();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.btnForeColor = new System.Windows.Forms.Button();
            this.checkCH = new System.Windows.Forms.CheckBox();
            this.checkTXT = new System.Windows.Forms.CheckBox();
            this.checkBG = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEXIT = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExampleDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DefaultDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupINFO = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbInfoWORD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbInfoSCENE = new System.Windows.Forms.TextBox();
            this.tbInfoFACE = new System.Windows.Forms.TextBox();
            this.tbInfoCH = new System.Windows.Forms.TextBox();
            this.btnSTART = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbSTORY = new System.Windows.Forms.RichTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbScriptCmd = new System.Windows.Forms.TextBox();
            this.btnStep = new System.Windows.Forms.Button();
            this.tbIndexAll = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbIndexNow = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnFORWARD = new System.Windows.Forms.Button();
            this.btnSTOP = new System.Windows.Forms.Button();
            this.btnGOBACK = new System.Windows.Forms.Button();
            this.btnScriptClose = new System.Windows.Forms.Button();
            this.btnScriptReload = new System.Windows.Forms.Button();
            this.btnScriptEdit = new System.Windows.Forms.Button();
            this.groupScriptFunction = new System.Windows.Forms.GroupBox();
            this.statusStrip1.SuspendLayout();
            this.GroupDisplay.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbPicCH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbPicBG)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupINFO.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupScriptFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 599);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(845, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(163, 17);
            this.toolStripStatusLabel1.Text = "本程序为脚本解释的测试工具";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GroupDisplay
            // 
            this.GroupDisplay.Controls.Add(this.panel2);
            this.GroupDisplay.Location = new System.Drawing.Point(12, 37);
            this.GroupDisplay.Name = "GroupDisplay";
            this.GroupDisplay.Size = new System.Drawing.Size(325, 263);
            this.GroupDisplay.TabIndex = 1;
            this.GroupDisplay.TabStop = false;
            this.GroupDisplay.Text = "控件缩略图（不支持半透明）";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ThumbText);
            this.panel2.Controls.Add(this.ThumbPicCH);
            this.panel2.Controls.Add(this.ThumbPicBG);
            this.panel2.Location = new System.Drawing.Point(6, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 233);
            this.panel2.TabIndex = 3;
            // 
            // ThumbText
            // 
            this.ThumbText.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ThumbText.Location = new System.Drawing.Point(63, 162);
            this.ThumbText.Name = "ThumbText";
            this.ThumbText.Size = new System.Drawing.Size(238, 52);
            this.ThumbText.TabIndex = 4;
            this.ThumbText.Text = "";
            // 
            // ThumbPicCH
            // 
            this.ThumbPicCH.BackColor = System.Drawing.Color.Transparent;
            this.ThumbPicCH.Location = new System.Drawing.Point(-1, -1);
            this.ThumbPicCH.Name = "ThumbPicCH";
            this.ThumbPicCH.Size = new System.Drawing.Size(146, 233);
            this.ThumbPicCH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ThumbPicCH.TabIndex = 3;
            this.ThumbPicCH.TabStop = false;
            // 
            // ThumbPicBG
            // 
            this.ThumbPicBG.BackColor = System.Drawing.Color.Black;
            this.ThumbPicBG.Image = global::ScriptReader.Properties.Resources.black;
            this.ThumbPicBG.Location = new System.Drawing.Point(-1, -1);
            this.ThumbPicBG.Name = "ThumbPicBG";
            this.ThumbPicBG.Size = new System.Drawing.Size(312, 233);
            this.ThumbPicBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ThumbPicBG.TabIndex = 2;
            this.ThumbPicBG.TabStop = false;
            // 
            // btnBackColor
            // 
            this.btnBackColor.Location = new System.Drawing.Point(118, 20);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(107, 23);
            this.btnBackColor.TabIndex = 5;
            this.btnBackColor.Text = "改变文本背景色";
            this.btnBackColor.UseVisualStyleBackColor = true;
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
            // 
            // btnForeColor
            // 
            this.btnForeColor.Location = new System.Drawing.Point(8, 20);
            this.btnForeColor.Name = "btnForeColor";
            this.btnForeColor.Size = new System.Drawing.Size(107, 23);
            this.btnForeColor.TabIndex = 4;
            this.btnForeColor.Text = "改变文本前景色";
            this.btnForeColor.UseVisualStyleBackColor = true;
            this.btnForeColor.Click += new System.EventHandler(this.btnForeColor_Click);
            // 
            // checkCH
            // 
            this.checkCH.AutoSize = true;
            this.checkCH.Location = new System.Drawing.Point(80, 78);
            this.checkCH.Name = "checkCH";
            this.checkCH.Size = new System.Drawing.Size(72, 16);
            this.checkCH.TabIndex = 1;
            this.checkCH.Text = "角色显示";
            this.checkCH.UseVisualStyleBackColor = true;
            this.checkCH.CheckedChanged += new System.EventHandler(this.checkCH_CheckedChanged);
            // 
            // checkTXT
            // 
            this.checkTXT.AutoSize = true;
            this.checkTXT.Location = new System.Drawing.Point(153, 78);
            this.checkTXT.Name = "checkTXT";
            this.checkTXT.Size = new System.Drawing.Size(72, 16);
            this.checkTXT.TabIndex = 2;
            this.checkTXT.Text = "文本显示";
            this.checkTXT.UseVisualStyleBackColor = true;
            this.checkTXT.CheckedChanged += new System.EventHandler(this.checkTXT_CheckedChanged);
            // 
            // checkBG
            // 
            this.checkBG.AutoSize = true;
            this.checkBG.Location = new System.Drawing.Point(8, 78);
            this.checkBG.Name = "checkBG";
            this.checkBG.Size = new System.Drawing.Size(72, 16);
            this.checkBG.TabIndex = 0;
            this.checkBG.Text = "背景显示";
            this.checkBG.UseVisualStyleBackColor = true;
            this.checkBG.CheckedChanged += new System.EventHandler(this.checkBG_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(845, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadToolStripMenuItem,
            this.CloseToolStripMenuItem,
            this.toolStripSeparator2,
            this.menuEXIT});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.文件ToolStripMenuItem.Text = "文件(&F)";
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.LoadToolStripMenuItem.Text = "重载脚本";
            this.LoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.CloseToolStripMenuItem.Text = "关闭脚本";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(119, 6);
            // 
            // menuEXIT
            // 
            this.menuEXIT.Name = "menuEXIT";
            this.menuEXIT.Size = new System.Drawing.Size(122, 22);
            this.menuEXIT.Text = "退出";
            this.menuEXIT.Click += new System.EventHandler(this.menuEXIT_Click);
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditScriptToolStripMenuItem,
            this.toolStripSeparator1,
            this.ExampleDisplayToolStripMenuItem,
            this.DefaultDisplayToolStripMenuItem});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.工具ToolStripMenuItem.Text = "工具(&T)";
            // 
            // EditScriptToolStripMenuItem
            // 
            this.EditScriptToolStripMenuItem.Name = "EditScriptToolStripMenuItem";
            this.EditScriptToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.EditScriptToolStripMenuItem.Text = "编辑脚本";
            this.EditScriptToolStripMenuItem.Click += new System.EventHandler(this.EditScriptToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // ExampleDisplayToolStripMenuItem
            // 
            this.ExampleDisplayToolStripMenuItem.Name = "ExampleDisplayToolStripMenuItem";
            this.ExampleDisplayToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.ExampleDisplayToolStripMenuItem.Text = "样例测试";
            this.ExampleDisplayToolStripMenuItem.Click += new System.EventHandler(this.ExampleDisplayToolStripMenuItem_Click);
            // 
            // DefaultDisplayToolStripMenuItem
            // 
            this.DefaultDisplayToolStripMenuItem.Name = "DefaultDisplayToolStripMenuItem";
            this.DefaultDisplayToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.DefaultDisplayToolStripMenuItem.Text = "恢复默认";
            this.DefaultDisplayToolStripMenuItem.Click += new System.EventHandler(this.DefaultDisplayToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.帮助ToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // groupINFO
            // 
            this.groupINFO.Controls.Add(this.label4);
            this.groupINFO.Controls.Add(this.tbInfoWORD);
            this.groupINFO.Controls.Add(this.label3);
            this.groupINFO.Controls.Add(this.label2);
            this.groupINFO.Controls.Add(this.label1);
            this.groupINFO.Controls.Add(this.tbInfoSCENE);
            this.groupINFO.Controls.Add(this.tbInfoFACE);
            this.groupINFO.Controls.Add(this.tbInfoCH);
            this.groupINFO.Location = new System.Drawing.Point(343, 149);
            this.groupINFO.Name = "groupINFO";
            this.groupINFO.Size = new System.Drawing.Size(233, 209);
            this.groupINFO.TabIndex = 0;
            this.groupINFO.TabStop = false;
            this.groupINFO.Text = "脚本执行信息";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "当前语言";
            // 
            // tbInfoWORD
            // 
            this.tbInfoWORD.BackColor = System.Drawing.Color.White;
            this.tbInfoWORD.Location = new System.Drawing.Point(6, 168);
            this.tbInfoWORD.Multiline = true;
            this.tbInfoWORD.Name = "tbInfoWORD";
            this.tbInfoWORD.ReadOnly = true;
            this.tbInfoWORD.Size = new System.Drawing.Size(219, 33);
            this.tbInfoWORD.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "当前场景";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "人物表情";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "当前人物";
            // 
            // tbInfoSCENE
            // 
            this.tbInfoSCENE.BackColor = System.Drawing.Color.White;
            this.tbInfoSCENE.Location = new System.Drawing.Point(6, 126);
            this.tbInfoSCENE.Name = "tbInfoSCENE";
            this.tbInfoSCENE.ReadOnly = true;
            this.tbInfoSCENE.Size = new System.Drawing.Size(219, 21);
            this.tbInfoSCENE.TabIndex = 2;
            // 
            // tbInfoFACE
            // 
            this.tbInfoFACE.BackColor = System.Drawing.Color.White;
            this.tbInfoFACE.Location = new System.Drawing.Point(6, 77);
            this.tbInfoFACE.Name = "tbInfoFACE";
            this.tbInfoFACE.ReadOnly = true;
            this.tbInfoFACE.Size = new System.Drawing.Size(219, 21);
            this.tbInfoFACE.TabIndex = 1;
            // 
            // tbInfoCH
            // 
            this.tbInfoCH.BackColor = System.Drawing.Color.White;
            this.tbInfoCH.Location = new System.Drawing.Point(6, 38);
            this.tbInfoCH.Name = "tbInfoCH";
            this.tbInfoCH.ReadOnly = true;
            this.tbInfoCH.Size = new System.Drawing.Size(219, 21);
            this.tbInfoCH.TabIndex = 0;
            // 
            // btnSTART
            // 
            this.btnSTART.BackColor = System.Drawing.Color.Green;
            this.btnSTART.ForeColor = System.Drawing.Color.White;
            this.btnSTART.Location = new System.Drawing.Point(6, 47);
            this.btnSTART.Name = "btnSTART";
            this.btnSTART.Size = new System.Drawing.Size(134, 22);
            this.btnSTART.TabIndex = 3;
            this.btnSTART.Text = "开始";
            this.btnSTART.UseVisualStyleBackColor = false;
            this.btnSTART.Click += new System.EventHandler(this.btnSTART_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rtbSTORY);
            this.groupBox1.Location = new System.Drawing.Point(582, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 548);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "脚本追踪";
            // 
            // rtbSTORY
            // 
            this.rtbSTORY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbSTORY.Location = new System.Drawing.Point(6, 20);
            this.rtbSTORY.Name = "rtbSTORY";
            this.rtbSTORY.ReadOnly = true;
            this.rtbSTORY.Size = new System.Drawing.Size(239, 518);
            this.rtbSTORY.TabIndex = 4;
            this.rtbSTORY.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(6, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 233);
            this.panel1.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(12, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 263);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "图形缩略图（速度不理想）";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btnForeColor);
            this.groupBox3.Controls.Add(this.btnBackColor);
            this.groupBox3.Controls.Add(this.checkCH);
            this.groupBox3.Controls.Add(this.checkTXT);
            this.groupBox3.Controls.Add(this.checkBG);
            this.groupBox3.Location = new System.Drawing.Point(343, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 106);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "预览相关设置";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(118, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "改变字符大小";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(8, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "改变文本字体";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbScriptCmd);
            this.groupBox4.Controls.Add(this.btnStep);
            this.groupBox4.Controls.Add(this.tbIndexAll);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.tbIndexNow);
            this.groupBox4.Controls.Add(this.btnReset);
            this.groupBox4.Controls.Add(this.btnFORWARD);
            this.groupBox4.Controls.Add(this.btnSTOP);
            this.groupBox4.Controls.Add(this.btnSTART);
            this.groupBox4.Controls.Add(this.btnGOBACK);
            this.groupBox4.Location = new System.Drawing.Point(343, 364);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(233, 161);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "执行控制";
            // 
            // tbScriptCmd
            // 
            this.tbScriptCmd.BackColor = System.Drawing.Color.White;
            this.tbScriptCmd.Location = new System.Drawing.Point(8, 131);
            this.tbScriptCmd.Name = "tbScriptCmd";
            this.tbScriptCmd.ReadOnly = true;
            this.tbScriptCmd.Size = new System.Drawing.Size(210, 21);
            this.tbScriptCmd.TabIndex = 13;
            // 
            // btnStep
            // 
            this.btnStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnStep.ForeColor = System.Drawing.Color.White;
            this.btnStep.Location = new System.Drawing.Point(6, 103);
            this.btnStep.Name = "btnStep";
            this.btnStep.Size = new System.Drawing.Size(212, 22);
            this.btnStep.TabIndex = 8;
            this.btnStep.Text = "单步执行";
            this.btnStep.UseVisualStyleBackColor = false;
            this.btnStep.Click += new System.EventHandler(this.btnStep_Click);
            // 
            // tbIndexAll
            // 
            this.tbIndexAll.BackColor = System.Drawing.Color.White;
            this.tbIndexAll.Location = new System.Drawing.Point(172, 20);
            this.tbIndexAll.Name = "tbIndexAll";
            this.tbIndexAll.ReadOnly = true;
            this.tbIndexAll.Size = new System.Drawing.Size(46, 21);
            this.tbIndexAll.TabIndex = 12;
            this.tbIndexAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "脚本总长";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "当前索引";
            // 
            // tbIndexNow
            // 
            this.tbIndexNow.BackColor = System.Drawing.Color.White;
            this.tbIndexNow.Location = new System.Drawing.Point(65, 20);
            this.tbIndexNow.Name = "tbIndexNow";
            this.tbIndexNow.ReadOnly = true;
            this.tbIndexNow.Size = new System.Drawing.Size(46, 21);
            this.tbIndexNow.TabIndex = 9;
            this.tbIndexNow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.Control;
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(166, 75);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(52, 22);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnFORWARD
            // 
            this.btnFORWARD.BackColor = System.Drawing.Color.Teal;
            this.btnFORWARD.ForeColor = System.Drawing.Color.White;
            this.btnFORWARD.Location = new System.Drawing.Point(86, 75);
            this.btnFORWARD.Name = "btnFORWARD";
            this.btnFORWARD.Size = new System.Drawing.Size(74, 22);
            this.btnFORWARD.TabIndex = 6;
            this.btnFORWARD.Text = "前进";
            this.btnFORWARD.UseVisualStyleBackColor = false;
            this.btnFORWARD.Click += new System.EventHandler(this.btnFORWARD_Click);
            // 
            // btnSTOP
            // 
            this.btnSTOP.BackColor = System.Drawing.Color.Red;
            this.btnSTOP.ForeColor = System.Drawing.Color.White;
            this.btnSTOP.Location = new System.Drawing.Point(146, 47);
            this.btnSTOP.Name = "btnSTOP";
            this.btnSTOP.Size = new System.Drawing.Size(72, 22);
            this.btnSTOP.TabIndex = 4;
            this.btnSTOP.Text = "停止";
            this.btnSTOP.UseVisualStyleBackColor = false;
            this.btnSTOP.Click += new System.EventHandler(this.btnSTOP_Click);
            // 
            // btnGOBACK
            // 
            this.btnGOBACK.BackColor = System.Drawing.Color.Teal;
            this.btnGOBACK.ForeColor = System.Drawing.Color.White;
            this.btnGOBACK.Location = new System.Drawing.Point(6, 75);
            this.btnGOBACK.Name = "btnGOBACK";
            this.btnGOBACK.Size = new System.Drawing.Size(74, 22);
            this.btnGOBACK.TabIndex = 5;
            this.btnGOBACK.Text = "后退";
            this.btnGOBACK.UseVisualStyleBackColor = false;
            this.btnGOBACK.Click += new System.EventHandler(this.btnGOBACK_Click);
            // 
            // btnScriptClose
            // 
            this.btnScriptClose.Location = new System.Drawing.Point(155, 20);
            this.btnScriptClose.Name = "btnScriptClose";
            this.btnScriptClose.Size = new System.Drawing.Size(70, 22);
            this.btnScriptClose.TabIndex = 9;
            this.btnScriptClose.Text = "关闭脚本";
            this.btnScriptClose.UseVisualStyleBackColor = true;
            this.btnScriptClose.Click += new System.EventHandler(this.btnScriptClose_Click);
            // 
            // btnScriptReload
            // 
            this.btnScriptReload.Location = new System.Drawing.Point(80, 20);
            this.btnScriptReload.Name = "btnScriptReload";
            this.btnScriptReload.Size = new System.Drawing.Size(70, 22);
            this.btnScriptReload.TabIndex = 8;
            this.btnScriptReload.Text = "重载脚本";
            this.btnScriptReload.UseVisualStyleBackColor = true;
            this.btnScriptReload.Click += new System.EventHandler(this.btnScriptReload_Click);
            // 
            // btnScriptEdit
            // 
            this.btnScriptEdit.Location = new System.Drawing.Point(6, 20);
            this.btnScriptEdit.Name = "btnScriptEdit";
            this.btnScriptEdit.Size = new System.Drawing.Size(70, 22);
            this.btnScriptEdit.TabIndex = 7;
            this.btnScriptEdit.Text = "编辑脚本";
            this.btnScriptEdit.UseVisualStyleBackColor = true;
            this.btnScriptEdit.Click += new System.EventHandler(this.btnScriptEdit_Click);
            // 
            // groupScriptFunction
            // 
            this.groupScriptFunction.Controls.Add(this.btnScriptClose);
            this.groupScriptFunction.Controls.Add(this.btnScriptReload);
            this.groupScriptFunction.Controls.Add(this.btnScriptEdit);
            this.groupScriptFunction.Location = new System.Drawing.Point(343, 531);
            this.groupScriptFunction.Name = "groupScriptFunction";
            this.groupScriptFunction.Size = new System.Drawing.Size(233, 55);
            this.groupScriptFunction.TabIndex = 10;
            this.groupScriptFunction.TabStop = false;
            this.groupScriptFunction.Text = "脚本相关";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 621);
            this.Controls.Add(this.groupScriptFunction);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupINFO);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.GroupDisplay);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScriptReader Test Tool  1.5.12.6";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyUp);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.GroupDisplay.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ThumbPicCH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbPicBG)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupINFO.ResumeLayout(false);
            this.groupINFO.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupScriptFunction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ThumbPicBG;
        private System.Windows.Forms.GroupBox GroupDisplay;
        private System.Windows.Forms.PictureBox ThumbPicCH;
        private System.Windows.Forms.CheckBox checkTXT;
        private System.Windows.Forms.CheckBox checkCH;
        private System.Windows.Forms.CheckBox checkBG;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupINFO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbInfoWORD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInfoSCENE;
        private System.Windows.Forms.TextBox tbInfoFACE;
        private System.Windows.Forms.TextBox tbInfoCH;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSTART;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExampleDisplayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DefaultDisplayToolStripMenuItem;
        private System.Windows.Forms.RichTextBox ThumbText;
        private System.Windows.Forms.RichTextBox rtbSTORY;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.Button btnForeColor;
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem EditScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnScriptEdit;
        private System.Windows.Forms.Button btnFORWARD;
        private System.Windows.Forms.Button btnGOBACK;
        private System.Windows.Forms.Button btnSTOP;
        private System.Windows.Forms.Button btnScriptClose;
        private System.Windows.Forms.Button btnScriptReload;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupScriptFunction;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStep;
        private System.Windows.Forms.TextBox tbIndexAll;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbIndexNow;
        private System.Windows.Forms.ToolStripMenuItem menuEXIT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TextBox tbScriptCmd;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

