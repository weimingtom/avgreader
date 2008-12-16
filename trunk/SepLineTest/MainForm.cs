using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace SepLineTest
{
	/// <summary>
	/// Description of MainForm.
    /// E:\_PROJECTS_VC#_\AVGreader\SepLineTest\bin\Debug\DATA\AVGS
	/// </summary>
    
	public partial class MainForm : Form
	{
        private string CurrentDir = AppDomain.CurrentDomain.BaseDirectory;

		public MainForm()
		{
			InitializeComponent();
		}
		
		public void getAllLine ()
		{

            StreamReader SR = new StreamReader(CurrentDir + @"DATA\AVGS\story.avgs", Encoding.GetEncoding("GB2312"));
			string line;
			while ((line = SR.ReadLine()) != null)
			{
				line += '\n';
				textBox1.Text += line;
			}
		}
		
		int index = 1;
		public void getOneLine ()
		{
            StreamReader SR = new StreamReader(CurrentDir + @"DATA\AVGS\story.avgs", Encoding.GetEncoding("GB2312"));
			string line = "";
			int temp = index;
			while (temp--!=0)
				line = SR.ReadLine();
			if(line != null)
			{	
				line += '\n';
				textBox1.Text += line;
			}
			else
				index = 0;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			getOneLine();
			index++;
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			getAllLine();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			index = 1;
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
