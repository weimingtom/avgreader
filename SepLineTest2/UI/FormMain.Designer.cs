namespace SepLineTest2.UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.textFakeConsole = new System.Windows.Forms.RichTextBox();
            this.btnAllLines = new System.Windows.Forms.Button();
            this.btnOneLine = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFIletoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CLSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.EditScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbIndex = new System.Windows.Forms.TextBox();
            this.btnThisLine = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbNowIndex = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbLength = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSetPos = new System.Windows.Forms.Button();
            this.btnZeroIndex = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsTextStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.CloseFiletoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(7, 20);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "退出程序";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(6, 20);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(117, 23);
            this.btnClearAll.TabIndex = 10;
            this.btnClearAll.Text = "清空测试文本框";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // textFakeConsole
            // 
            this.textFakeConsole.BackColor = System.Drawing.Color.White;
            this.textFakeConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textFakeConsole.Location = new System.Drawing.Point(0, 0);
            this.textFakeConsole.Name = "textFakeConsole";
            this.textFakeConsole.ReadOnly = true;
            this.textFakeConsole.Size = new System.Drawing.Size(312, 490);
            this.textFakeConsole.TabIndex = 9;
            this.textFakeConsole.Text = "";
            // 
            // btnAllLines
            // 
            this.btnAllLines.Location = new System.Drawing.Point(6, 62);
            this.btnAllLines.Name = "btnAllLines";
            this.btnAllLines.Size = new System.Drawing.Size(117, 23);
            this.btnAllLines.TabIndex = 8;
            this.btnAllLines.Text = "清空并输出全部";
            this.btnAllLines.UseVisualStyleBackColor = true;
            this.btnAllLines.Click += new System.EventHandler(this.btnAllLines_Click);
            // 
            // btnOneLine
            // 
            this.btnOneLine.ForeColor = System.Drawing.Color.Red;
            this.btnOneLine.Location = new System.Drawing.Point(6, 20);
            this.btnOneLine.Name = "btnOneLine";
            this.btnOneLine.Size = new System.Drawing.Size(117, 23);
            this.btnOneLine.TabIndex = 7;
            this.btnOneLine.Text = "按定位输出单行";
            this.btnOneLine.UseVisualStyleBackColor = true;
            this.btnOneLine.Click += new System.EventHandler(this.btnOneLine_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.ResetToToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(467, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenScriptToolStripMenuItem,
            this.OpenFIletoolStripMenuItem,
            this.toolStripSeparator4,
            this.CloseFiletoolStripMenuItem1,
            this.toolStripSeparator3,
            this.ExitToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.文件ToolStripMenuItem.Text = "文件(&F)";
            // 
            // OpenScriptToolStripMenuItem
            // 
            this.OpenScriptToolStripMenuItem.Name = "OpenScriptToolStripMenuItem";
            this.OpenScriptToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.OpenScriptToolStripMenuItem.Text = "打开默认脚本";
            this.OpenScriptToolStripMenuItem.ToolTipText = "打开DATA\\AVGS\\story.avgs文件（默认脚本）";
            this.OpenScriptToolStripMenuItem.Click += new System.EventHandler(this.OpenScriptToolStripMenuItem_Click);
            // 
            // OpenFIletoolStripMenuItem
            // 
            this.OpenFIletoolStripMenuItem.Name = "OpenFIletoolStripMenuItem";
            this.OpenFIletoolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.OpenFIletoolStripMenuItem.Text = "打开文本";
            this.OpenFIletoolStripMenuItem.ToolTipText = "可以以GB2312编码打开其他可能是脚本的文本文件";
            this.OpenFIletoolStripMenuItem.Click += new System.EventHandler(this.OpenFIletoolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ExitToolStripMenuItem.Text = "退出";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // ResetToToolStripMenuItem
            // 
            this.ResetToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReplaceToolStripMenuItem,
            this.ResetToolStripMenuItem,
            this.toolStripSeparator1,
            this.CLSToolStripMenuItem,
            this.toolStripSeparator2,
            this.EditScriptToolStripMenuItem});
            this.ResetToToolStripMenuItem.Name = "ResetToToolStripMenuItem";
            this.ResetToToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.ResetToToolStripMenuItem.Text = "脚本控制(&S)";
            // 
            // ReplaceToolStripMenuItem
            // 
            this.ReplaceToolStripMenuItem.Name = "ReplaceToolStripMenuItem";
            this.ReplaceToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.ReplaceToolStripMenuItem.Text = "重新定位到...";
            this.ReplaceToolStripMenuItem.Click += new System.EventHandler(this.ReplaceToolStripMenuItem_Click);
            // 
            // ResetToolStripMenuItem
            // 
            this.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem";
            this.ResetToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.ResetToolStripMenuItem.Text = "定位到脚本起始位置";
            this.ResetToolStripMenuItem.Click += new System.EventHandler(this.ResetToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // CLSToolStripMenuItem
            // 
            this.CLSToolStripMenuItem.Name = "CLSToolStripMenuItem";
            this.CLSToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.CLSToolStripMenuItem.Text = "清空测试框";
            this.CLSToolStripMenuItem.Click += new System.EventHandler(this.CLSToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(161, 6);
            // 
            // EditScriptToolStripMenuItem
            // 
            this.EditScriptToolStripMenuItem.Name = "EditScriptToolStripMenuItem";
            this.EditScriptToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.EditScriptToolStripMenuItem.Text = "编辑默认脚本";
            this.EditScriptToolStripMenuItem.ToolTipText = "将打开DATA\\AVGS\\story.avgs\r\n并可以对其进行编辑";
            this.EditScriptToolStripMenuItem.Click += new System.EventHandler(this.EditScriptToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.帮助ToolStripMenuItem.Text = "帮助(&H)";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AboutToolStripMenuItem.Text = "关于";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textFakeConsole);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 490);
            this.panel1.TabIndex = 14;
            // 
            // tbIndex
            // 
            this.tbIndex.Location = new System.Drawing.Point(6, 106);
            this.tbIndex.Name = "tbIndex";
            this.tbIndex.Size = new System.Drawing.Size(117, 21);
            this.tbIndex.TabIndex = 15;
            this.tbIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnThisLine
            // 
            this.btnThisLine.Location = new System.Drawing.Point(6, 133);
            this.btnThisLine.Name = "btnThisLine";
            this.btnThisLine.Size = new System.Drawing.Size(117, 23);
            this.btnThisLine.TabIndex = 16;
            this.btnThisLine.Text = "输出以上指定行";
            this.btnThisLine.UseVisualStyleBackColor = true;
            this.btnThisLine.Click += new System.EventHandler(this.btnThisLine_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox6);
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(312, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 490);
            this.panel2.TabIndex = 17;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tbNowIndex);
            this.groupBox6.Location = new System.Drawing.Point(13, 58);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(130, 49);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "当前定位";
            // 
            // tbNowIndex
            // 
            this.tbNowIndex.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbNowIndex.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbNowIndex.Location = new System.Drawing.Point(6, 20);
            this.tbNowIndex.Name = "tbNowIndex";
            this.tbNowIndex.ReadOnly = true;
            this.tbNowIndex.Size = new System.Drawing.Size(117, 21);
            this.tbNowIndex.TabIndex = 18;
            this.tbNowIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnExit);
            this.groupBox5.Location = new System.Drawing.Point(13, 427);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(130, 52);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "其他功能";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbLength);
            this.groupBox1.Location = new System.Drawing.Point(13, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 49);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "脚本全长";
            // 
            // tbLength
            // 
            this.tbLength.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbLength.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbLength.Location = new System.Drawing.Point(6, 20);
            this.tbLength.Name = "tbLength";
            this.tbLength.ReadOnly = true;
            this.tbLength.Size = new System.Drawing.Size(117, 21);
            this.tbLength.TabIndex = 21;
            this.tbLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnClearAll);
            this.groupBox4.Location = new System.Drawing.Point(13, 367);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(130, 54);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "文本控制";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSetPos);
            this.groupBox2.Controls.Add(this.btnZeroIndex);
            this.groupBox2.Location = new System.Drawing.Point(13, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 80);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "脚本定位";
            // 
            // btnSetPos
            // 
            this.btnSetPos.Location = new System.Drawing.Point(6, 20);
            this.btnSetPos.Name = "btnSetPos";
            this.btnSetPos.Size = new System.Drawing.Size(117, 23);
            this.btnSetPos.TabIndex = 21;
            this.btnSetPos.Text = "定位到脚本到..";
            this.btnSetPos.UseVisualStyleBackColor = true;
            this.btnSetPos.Click += new System.EventHandler(this.btnSetPos_Click);
            // 
            // btnZeroIndex
            // 
            this.btnZeroIndex.Location = new System.Drawing.Point(6, 49);
            this.btnZeroIndex.Name = "btnZeroIndex";
            this.btnZeroIndex.Size = new System.Drawing.Size(117, 23);
            this.btnZeroIndex.TabIndex = 19;
            this.btnZeroIndex.Text = "定位到脚本起始";
            this.btnZeroIndex.UseVisualStyleBackColor = true;
            this.btnZeroIndex.Click += new System.EventHandler(this.btnZeroIndex_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnOneLine);
            this.groupBox3.Controls.Add(this.btnAllLines);
            this.groupBox3.Controls.Add(this.btnThisLine);
            this.groupBox3.Controls.Add(this.tbIndex);
            this.groupBox3.Location = new System.Drawing.Point(13, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(130, 162);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "脚本输出";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBar,
            this.tsTextStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 514);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(467, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsTextStatus
            // 
            this.tsTextStatus.ForeColor = System.Drawing.Color.Green;
            this.tsTextStatus.Name = "tsTextStatus";
            this.tsTextStatus.Size = new System.Drawing.Size(10, 17);
            this.tsTextStatus.Text = " ";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // CloseFiletoolStripMenuItem1
            // 
            this.CloseFiletoolStripMenuItem1.Name = "CloseFiletoolStripMenuItem1";
            this.CloseFiletoolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.CloseFiletoolStripMenuItem1.Text = "关闭打开文件";
            this.CloseFiletoolStripMenuItem1.Click += new System.EventHandler(this.CloseFiletoolStripMenuItem1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 536);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SepLineTest2  2.5.12.6";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.RichTextBox textFakeConsole;
        private System.Windows.Forms.Button btnAllLines;
        private System.Windows.Forms.Button btnOneLine;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbIndex;
        private System.Windows.Forms.Button btnThisLine;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbNowIndex;
        private System.Windows.Forms.Button btnZeroIndex;
        private System.Windows.Forms.TextBox tbLength;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ToolStripMenuItem ResetToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReplaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ResetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CLSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnSetPos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem OpenScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFIletoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsTextStatus;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem CloseFiletoolStripMenuItem1;
    }
}

