using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

namespace AVGreader.Service
{
    public static class BackgroundSrv
    {
        #region 声明

        static string _Path;
        static Texture Background1 = null;

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
            Background1 = TextureLoader.FromFile(EngineSrv.device, Path);  //载入图像到内存
        }

        #endregion

        #region 渲染
        /// <summary>
        /// 渲染
        /// </summary>
        public static void Render()
        {
            //Engine.sprite.Draw2D(Background1, new PointF(0, 0), 0, new PointF(0, 0), Color.White);
            EngineSrv.sprite.Draw2D(Background1, 
                                    new Rectangle(0, 0, 1024, 768), //该属性为裁剪图片，具体数值视图像大小而定
                                    new SizeF(EngineSrv.parent.ClientSize.Width, EngineSrv.parent.ClientSize.Height), 
                                    new PointF(0, 0), 
                                    Color.White);  

        }

        #endregion
    }
}
