using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace AVGreader.UI
{
	/// <summary>
	/// Description of FormMain.
	/// </summary>
	public partial class FormMain : Form
	{
        string CurrentDir = Application.StartupPath;
		bool flagCH, flagFRAME, flagTEXT;
        string BGpath = Application.StartupPath + @"\DATA\IMG\background.BMP";
        string CHpath = Application.StartupPath + @"\DATA\IMG\actor.bmp";
        string DebugText = "";
		
		public FormMain()
		{
			InitializeComponent();

            timer1.Interval = 1;
            //timer1.Start();

            flagCH = flagFRAME = flagTEXT = true; 
        }
		
		private DxVBLib.DirectX7 dx = new DxVBLib.DirectX7();

        /// <summary>
        /// 绘制背景图
        /// </summary>
        /// <param name="strBgPath">背景图地址</param>
        private void drawBackground (string strBGpath)
        {
            Guid guid = System.Guid.NewGuid();
            DxVBLib.DirectDraw7 dDraw = dx.DirectDrawCreate(guid.ToString());
            DxVBLib.DirectDrawClipper dDclipper;
            dDraw.SetCooperativeLevel(this.Handle.ToInt32(), DxVBLib.CONST_DDSCLFLAGS.DDSCL_NORMAL);

            DxVBLib.RECT rect = new DxVBLib.RECT();
            DxVBLib.RECT rectSec = new DxVBLib.RECT();
            DxVBLib.DirectDrawSurface7 dDsurface;
            DxVBLib.DirectDrawSurface7 dDsurfaceSec;
            DxVBLib.DDSURFACEDESC2 dDDesc = new DxVBLib.DDSURFACEDESC2();
            DxVBLib.DDSURFACEDESC2 dDDescSec = new DxVBLib.DDSURFACEDESC2();

            dDDesc.lFlags = DxVBLib.CONST_DDSURFACEDESCFLAGS.DDSD_CAPS;
            dDDesc.ddsCaps.lCaps = DxVBLib.CONST_DDSURFACECAPSFLAGS.DDSCAPS_PRIMARYSURFACE;

            dDsurface = dDraw.CreateSurface(ref dDDesc);
            dDclipper = dDraw.CreateClipper(0);
            dDclipper.SetHWnd(this.Handle.ToInt32());
            dDsurface.SetClipper(dDclipper);

            try
            {
                dDsurfaceSec = dDraw.CreateSurfaceFromFile(strBGpath, ref dDDescSec);
                dx.GetWindowRect(this.Handle.ToInt32(), ref rectSec);
                rect.Top = 0;
                rect.Left = 0;
                rect.Right = dDDescSec.lWidth;
                rect.Bottom = dDDescSec.lHeight;
                //dDsurface.BltFast(0, 0, dDsurfaceSec, ref rect, DxVBLib.CONST_DDBLTFASTFLAGS.DDBLTFAST_WAIT);

                dDsurface.Blt(ref rectSec, dDsurfaceSec, ref rect, DxVBLib.CONST_DDBLTFLAGS.DDBLT_WAIT);
            }
            catch (System.Runtime.InteropServices.COMException e)
            {
                // 没有找到文件。
                if ((uint)e.ErrorCode == 0x800A0035)
                {
                    MessageBox.Show("没有找到文件\n" + "图片没有找到");
                }
                else
                {
                    MessageBox.Show("异常: " + e.ToString(), "异常信息");
                }
                Application.Exit();
                Application.DoEvents();
            }
        }

        /// <summary>
        /// 绘制角色图
        /// </summary>
        /// <param name="strCHpath">角色图地址</param>
        private void drawCharactor (string strCHpath)
        {
            Guid guid = System.Guid.NewGuid();
            DxVBLib.DirectDraw7 dDraw = dx.DirectDrawCreate(guid.ToString());
            DxVBLib.DirectDrawClipper dDclipper;
            dDraw.SetCooperativeLevel(this.Handle.ToInt32(), DxVBLib.CONST_DDSCLFLAGS.DDSCL_NORMAL);

            DxVBLib.RECT rect, rectSec = new DxVBLib.RECT();
            DxVBLib.DirectDrawSurface7 dDsurface;
            DxVBLib.DirectDrawSurface7 dDsurfaceActor;
            DxVBLib.DDSURFACEDESC2 dDDesc = new DxVBLib.DDSURFACEDESC2();
            DxVBLib.DDSURFACEDESC2 dDDescActor = new DxVBLib.DDSURFACEDESC2();
            
            dDDesc.lFlags = DxVBLib.CONST_DDSURFACEDESCFLAGS.DDSD_CAPS;
            dDDesc.ddsCaps.lCaps = DxVBLib.CONST_DDSURFACECAPSFLAGS.DDSCAPS_PRIMARYSURFACE;

            dDsurface = dDraw.CreateSurface(ref dDDesc);
            dDclipper = dDraw.CreateClipper(0);
            dDclipper.SetHWnd(this.Handle.ToInt32());
            dDsurface.SetClipper(dDclipper);

            DxVBLib.DDCOLORKEY dDcolorKey = new DxVBLib.DDCOLORKEY();

            try
            {
                dDsurfaceActor = dDraw.CreateSurfaceFromFile(strCHpath, ref dDDescActor);
                dx.GetWindowRect(this.Handle.ToInt32(), ref rectSec);
                rect.Top = 0;
                rect.Left = 0;
                rect.Bottom = dDDescActor.lHeight;
                rect.Right = dDDescActor.lWidth;
                rectSec.Top = rectSec.Bottom - dDDescActor.lHeight;
                rectSec.Left += (rectSec.Right - rectSec.Left - dDDescActor.lWidth) / 2;
                rectSec.Bottom -= 0;
                rectSec.Right = rectSec.Left + dDDescActor.lWidth;

                dDcolorKey.high = 0; //被屏蔽
                dDcolorKey.low = 0; //的颜色介于这两者之间
                dDsurfaceActor.SetColorKey(DxVBLib.CONST_DDCKEYFLAGS.DDCKEY_SRCBLT, ref dDcolorKey);

                dDsurface.Blt(ref rectSec, dDsurfaceActor, ref rect, DxVBLib.CONST_DDBLTFLAGS.DDBLT_WAIT | DxVBLib.CONST_DDBLTFLAGS.DDBLT_KEYSRC);
            }
            catch (System.Runtime.InteropServices.COMException e)
            {
                // 没有找到文件。
                if ((uint)e.ErrorCode == 0x800A0035)
                {
                    MessageBox.Show("没有找到文件'sample.bmp'.\n该文件必须和程序放在一个目录下面。", "图片没有找到");
                }
                else
                {
                    MessageBox.Show("异常: " + e.ToString(), "异常信息");
                }
                Application.Exit();
                Application.DoEvents();
            }

        }

        /// <summary>
        /// 绘制文本框
        /// </summary>
        private void drawFrame ()
        {
            //Draw frame with GDI+
            Graphics g = CreateGraphics();
            Bitmap bitmap = new Bitmap(CurrentDir + @"\DATA\IMG\frame.bmp");
            float[][] ptsArray ={ 
            new float[] {1, 0, 0, 0, 0},
            new float[] {0, 1, 0, 0, 0},
            new float[] {0, 0, 1, 0, 0},
            new float[] {0, 0, 0, 0.7f, 0}, // [1, 0][不透明, 全透明]
            new float[] {0, 0, 0, 0, 1}};
            ColorMatrix clrMatrix = new ColorMatrix(ptsArray);
            ImageAttributes imgAttributes = new ImageAttributes();
            //设置图像的颜色属性
            imgAttributes.SetColorMatrix(clrMatrix, ColorMatrixFlag.Default,ColorAdjustType.Bitmap);
            //画图像
            g.DrawImage(bitmap, new Rectangle(0, ClientSize.Height - bitmap.Height, ClientSize.Width, bitmap.Height),
                             0, 0, bitmap.Width, bitmap.Height, GraphicsUnit.Pixel, imgAttributes);
            g.Dispose();
        }

        /// <summary>
        /// 绘制文本
        /// </summary>
        /// <param name="strSay">文本内容</param>
        private void drawString (string strSay)
        {
            Graphics g = CreateGraphics();
            Bitmap bitmap = new Bitmap(CurrentDir + @"\DATA\IMG\frame.bmp");

            SolidBrush MyBrush;
            System.Drawing.Font MyFont;
            StringFormat MyFormat;
            Rectangle MyRect;
            try
            {
                MyBrush = new SolidBrush(Color.White);
                MyFont = new System.Drawing.Font("微软雅黑", 16);
                MyFormat = new StringFormat();
                MyFormat.FormatFlags = StringFormatFlags.NoWrap;
                MyFormat.Trimming = StringTrimming.Word;
                MyRect = new Rectangle(10, (ClientSize.Height - bitmap.Height + 10), ClientSize.Width, ClientSize.Height);
                g.DrawString(strSay, MyFont, MyBrush, MyRect, MyFormat);
            }
            catch (Exception MyEx)
            {
                MessageBox.Show(MyEx.Message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            g.Dispose();
        }

        /// <summary>
        /// 绘制调试字符串
        /// </summary>
        /// <param name="strContent">调试字符串内容（可接受多行）</param>
        private void PrintDebugString (string strContent)
        {
            Graphics g = CreateGraphics();

            SolidBrush MyBrush;
            System.Drawing.Font MyFont;
            StringFormat MyFormat;
            Rectangle MyRect;
            try
            {
                MyBrush = new SolidBrush(Color.White);
                MyFont = new System.Drawing.Font("新宋体", 9);
                MyFormat = new StringFormat();
                MyFormat.FormatFlags = StringFormatFlags.NoClip;
                MyFormat.Trimming = StringTrimming.Word;
                MyRect = new Rectangle(0, 0, ClientSize.Width, ClientSize.Height);
                g.DrawString(strContent, MyFont, MyBrush, MyRect, MyFormat);
            }
            catch (Exception MyEx)
            {
                MessageBox.Show(MyEx.Message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            g.Dispose();
        }

        /// <summary>
        /// 绘制整个画面
        /// </summary>
        private void drawAll ()
        {
            drawBackground(BGpath);
            if (flagCH)
            {
                drawCharactor(CHpath);
            }
            if (flagFRAME)
            {
                //drawFrame();
            }
            if (flagTEXT)
            {
                //drawString("出现汉字了吗？What about english?~\n太长呢？啦啦啦啦啦啦啦啦啦啦啦啦啦啦啦啦啦啦啦啦\n最后测试日语　後ろ");
            }
            DebugText = "BG:" + BGpath + "\n" +
                        "CH:" + CHpath + "\n";
            //PrintDebugString(DebugText);
        }

        void FormMainKeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)System.Windows.Forms.Keys.Escape)
            {
                if (MessageBox.Show(this, "You will close the game, sure?", "warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    this.Close();
                else
                    return;
            }
            else if ((int)e.KeyChar >= (int)System.Windows.Forms.Keys.D1 && (int)e.KeyChar <= (int)System.Windows.Forms.Keys.D9)
            {
                BGpath = CurrentDir + @"\DATA\SCENE\000" + e.KeyChar.ToString() + @".bmp";
                drawAll();
            }
            else if (e.KeyChar == 'F' || e.KeyChar == 'f')
            {
                flagTEXT = !flagTEXT;
                drawAll();
            }
            else if (e.KeyChar == 'D' || e.KeyChar == 'd')
            {
                flagFRAME = !flagFRAME;
                drawAll();
            }
            else if (e.KeyChar == 'S' || e.KeyChar == 's')
            {
                flagCH = !flagCH;
                drawAll();
            }
            else 
                return;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //int fps = CalculateFrameRate();
            //this.Text = "AVGreader" + fps.ToString();
            //drawAll();
        }

        private void FormMain_Paint(object sender, PaintEventArgs e)
        {
            drawAll();
        }

        private static int lastTick;
        private static int lastFrameRate;
        private static int frameRate;

        public static int CalculateFrameRate()
        {
            if (System.Environment.TickCount - lastTick >= 1000)
            {
                lastFrameRate = frameRate;
                frameRate = 0;
                lastTick = System.Environment.TickCount;
            }
            frameRate++;
            return lastFrameRate;
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            while (true)
            {
                drawAll();
            }
        }

    }
}
