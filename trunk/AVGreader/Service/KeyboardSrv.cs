using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using Microsoft.DirectX;
using Microsoft.DirectX.DirectInput;

namespace AVGreader.Service
{
    public static class KeyboardSrv
    {
        #region 声明

        private static Device keyDevice = new Device(new Guid());
        private static KeyboardState _keyState = null;

        #endregion

        #region 属性

        public static KeyboardState keyState
        {
            get { return _keyState; }
            set { _keyState = value; }
        }

        #endregion

        #region 初始化

        private static void initializeKeyboard()
        {
            keyDevice.SetCooperativeLevel(EngineSrv.parent, CooperativeLevelFlags.Exclusive | CooperativeLevelFlags.Foreground);
        }
        
        #endregion

        #region 相关操作方法

        private static void FreeKeyboard()
        {
            keyDevice.Unacquire();
            keyDevice.Dispose();
            keyDevice = null;
        }
        
        public static void PressAnyKey()
        {
            initializeKeyboard();
            while ((keyState = keyDevice.GetCurrentKeyboardState()) == null)
            {
                Application.DoEvents();
            }
            FreeKeyboard();
        }

        #endregion
    }
}
