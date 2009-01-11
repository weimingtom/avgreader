using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

namespace AVGreader.Service
{
    public static class ActorSrv
    {
        #region 声明

        static string _Path;
        static Texture texRole1 = null;
        //static Texture texRole2 = null;
        
        #endregion

        #region 属性

        public static string Path
        {
            get { return _Path; }
            set { _Path = value; }
        }

        #endregion

        #region 载入资源
        /// <summary>
        /// 载入资源
        /// </summary>
        public static void LoadResX()
        {
            if (Path == null)
                return;
            texRole1 = TextureLoader.FromFile(EngineSrv.device, Path);  //载入图像到内存
            //texRole2 = TextureLoader.FromFile(EngineSrv.device, Path + "Test.png");  //载入图像到内存
        }

        #endregion

        #region 渲染
        public static void Render()
        {
            if (texRole1 == null)
                return;
            //图像，裁剪位置，呈现出来的大小，呈现位置，颜色（白色代表不应用任何过滤）
            EngineSrv.sprite.Draw2D(texRole1,               //绘制的纹理
                                    Rectangle.Empty,        //裁剪纹理（空代表全部）
                                    new SizeF(315, 540),    //绘制的大小
                                    new PointF(96, 0),      //绘制的位置
                                    Color.White);           //颜色过滤（白色代表不应用任何过滤）
            //EngineSrv.sprite.Draw2D(texRole2, Rectangle.Empty, new SizeF(512, 512), new PointF(0, 0), Color.White);
        }

        #endregion
    }
}
