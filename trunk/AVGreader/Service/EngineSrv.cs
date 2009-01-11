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
        #region 私有变量声明

        
        #endregion


        #region 属性


        private static Control _parent;
        /// <summary>
        /// 父窗口
        /// </summary>
        public static Control parent
        {
            get { return _parent; }
            set { _parent = value; }
        }


        private static Device _device;
        /// <summary>
        /// 渲染设备
        /// </summary>
        public static Device device
        {
            get { return _device; }
            set { _device = value; }
        }


        private static Sprite _sprite = null;
        /// <summary>
        /// 渲染接口
        /// </summary>
        public static Sprite sprite
        {
            get { return EngineSrv._sprite; }
            set { EngineSrv._sprite = value; }
        }


        private static bool _flag = true;
        /// <summary>
        /// 是否显示菜单框
        /// </summary>
        public static bool flag
        {
            get { return EngineSrv._flag; }
            set { EngineSrv._flag = value; }
        }


        private static MyEnum.RunStatement _nowRunState = MyEnum.RunStatement.RUNNING;
        /// <summary>
        /// 运行标记
        /// </summary>
        public static MyEnum.RunStatement nowRunState
        {
            get { return _nowRunState; }
            set { _nowRunState = value; }
        }

        private static long _nowIndex = 1;
        /// <summary>
        /// 主游戏循环的索引
        /// </summary>
        public static long nowIndex
        {
            get { return _nowIndex; }
            set { _nowIndex = value; }
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
        /// 游戏主循环
        /// </summary>
        private static void MainLoop()
        {
            //一行一行判断并分发执行
            while (nowIndex <= ScriptSrv.story.LineNumber)
            {
                if (nowRunState == MyEnum.RunStatement.RUNNING)
                {
                    ScriptSrv.QueryScriptCommand(nowIndex);
                    FrameMove();
                    Render();
                    Application.DoEvents();
                }
                else if (nowRunState == MyEnum.RunStatement.PAGE)
                {
                    if (KeyboardSrv.keyState == null)
                    {
                        Render();
                        Application.DoEvents();
                    }
                    else
                    {
                        nowRunState = MyEnum.RunStatement.RUNNING;
                        ScriptSrv.QueryScriptCommand(nowIndex);
                        FrameMove();
                        Render();
                        Application.DoEvents();
                    }
                }
                else if (nowRunState == MyEnum.RunStatement.END)
                {
                    break;  //剧本执行完毕 跳出剧本循环
                }

                // 指向下一行
                nowIndex++;
            }
        }

        /// <summary>
        /// 游戏流程
        /// </summary>
        public static void Run ()
        {
            //菜单

            //主循环
            MainLoop();

            //游戏结束，释放
            ExitGame();
        }

        /// <summary>
        /// 退出游戏
        /// </summary>
        private static void ExitGame()
        {
            device.Dispose();
            Application.Exit();
        }

        #endregion
    }
}
