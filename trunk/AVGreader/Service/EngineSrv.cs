using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

using AVGreader.Domain;
using AVGreader.Service.Persistent;

namespace AVGreader.Service
{
    public static class EngineSrv
    {
        #region 声明

        static Device _device;
        static Control _parent;
        static Sprite _sprite = null;
        static bool _flag = true;
        static MyEnum.RunStatement _NowRunState = MyEnum.RunStatement.RUNNING;
        
        #endregion


        #region 属性
        /// <summary>
        /// 父窗口
        /// </summary>
        public static Control parent
        {
            get { return _parent; }
            set { _parent = value; }
        }
        /// <summary>
        /// 渲染设备
        /// </summary>
        public static Device device
        {
            get { return _device; }
            set { _device = value; }
        }
        /// <summary>
        /// 渲染接口
        /// </summary>
        public static Sprite sprite
        {
            get { return EngineSrv._sprite; }
            set { EngineSrv._sprite = value; }
        }
        /// <summary>
        /// 是否显示菜单框
        /// </summary>
        public static bool flag
        {
            get { return EngineSrv._flag; }
            set { EngineSrv._flag = value; }
        }
        /// <summary>
        /// 运行标记
        /// </summary>
        public static MyEnum.RunStatement NowRunState
        {
            get { return _NowRunState; }
            set { _NowRunState = value; }
        }



        #endregion


        #region 初始化
        /// <summary>
        /// 初始化
        /// </summary>
        /// <returns>True</returns>
        public static bool Initialize()
        {
            try
            {
                PresentParameters pp = new PresentParameters();
                pp.Windowed = true;  //窗口模式
                pp.SwapEffect = SwapEffect.Discard;
                device = new Device(0, DeviceType.Hardware, parent, CreateFlags.SoftwareVertexProcessing, pp);

                sprite = new Sprite(device);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        #endregion


        #region 载入资源

        /// <summary>
        /// 切换显示内容
        /// </summary>
        public static void FrameMove()
        {
            BackgroundSrv.LoadResX();
            ActorSrv.LoadResX();
            TextFrameSrv.InitializeFont();
        }

        #endregion
        

        #region 渲染

        /// <summary>
        /// 渲染
        /// </summary>
        public static void Render()
        {
            device.Clear(ClearFlags.Target, Color.Blue, 0, 0);
            device.BeginScene();
            sprite.Begin(SpriteFlags.AlphaBlend);

            BackgroundSrv.Render();
            ActorSrv.Render();
            if (flag == true)
                TextFrameSrv.Render();

            sprite.End();
            device.EndScene();
            device.Present();
        }

        #endregion
        

        #region 主循环

        /// <summary>
        /// 主游戏循环
        /// </summary>
        public static void Run ()
        {
            //这里插入菜单

            //脚本阅读模式一行一行判断并分发执行
            foreach (string cmd in ScriptSrv.story.text)
            {
                if (NowRunState == MyEnum.RunStatement.RUNNING)
                {
                    ScriptSrv.QueryScriptCommand(cmd);
                    FrameMove();
                    Render();
                    Application.DoEvents();
                }
                else if (NowRunState == MyEnum.RunStatement.PAGE)
                {
                    if (KeyboardSrv.keyState == null)
                    {
                        Render();
                        Application.DoEvents();
                    }
                    else
                    {
                        NowRunState = MyEnum.RunStatement.RUNNING;
                        FrameMove();
                        Render();
                        Application.DoEvents();
                    }
                }
                else if (NowRunState == MyEnum.RunStatement.END)
                {
                    device.Dispose();
                    Application.Exit();
                }
            }
        }

        #endregion
    }
}
