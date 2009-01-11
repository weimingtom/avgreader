using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

namespace AVGreader.Service
{
    public static class TextFrameSrv
    {
        #region 声明

        static Microsoft.DirectX.Direct3D.Font font = null;
        private static string _fontFamily = "微软雅黑";
        private static float _fontSize = 20f;
        private static string _sentense = "null";
        private static Point _position = new Point(150,150);
        private static Color _color = Color.White;

        private static string framePath = Application.StartupPath + @"\DATA\IMG\frame.png";
        static Texture texFrame = null;

        #endregion

        #region 属性

        public static string fontFamily
        {
            get { return _fontFamily; }
            set { _fontFamily = value; }
        }
        public static float fontSize
        {
            get { return _fontSize; }
            set { _fontSize = value; }
        }
        public static string sentense
        {
            get { return _sentense; }
            set { _sentense = value; }
        }
        public static Point position
        {
            get { return _position; }
            set { _position = value; }
        }
        public static Color color
        {
            get { return _color; }
            set { _color = value; }
        }

        #endregion

        #region 创建新字体
        /// <summary>
        /// 创建新字体
        /// </summary>
        /// <param name="family">字体名称</param>
        /// <param name="size">字体大小</param>
        public static void InitializeFont()
        {
            if (font != null)
                font = null;
            System.Drawing.Font sf = new System.Drawing.Font(fontFamily, fontSize);
            font = new Microsoft.DirectX.Direct3D.Font(EngineSrv.device, sf);

            LoadFrame();
        }

        public static void LoadFrame()
        {
            texFrame = TextureLoader.FromFile(EngineSrv.device, framePath);  //载入图像到内存
        }

        #endregion

        #region 渲染
        /// <summary>
        /// 渲染
        /// </summary>
        /// <param name="value">文字内容</param>
        /// <returns>文字内容</returns>
        public static void Render()
        {
            EngineSrv.sprite.Draw2D(texFrame,               //绘制的纹理
                                    Rectangle.Empty,        //选取的区域（空代表选择全部）
                                    new SizeF(611, 270),    //绘制的大小
                                    new PointF(253, 270),   //绘制的位置
                                    Color.White);           //白色代表不使用任何颜色过滤
            
            font.DrawText(EngineSrv.sprite,                 //绘制的图层
                          sentense,                         //字符串
                          position,                         //字位置
                          color);                           //字体颜色
        }

        #endregion
    }
}
