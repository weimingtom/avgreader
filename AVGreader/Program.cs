using System;
using System.Collections.Generic;
using System.Windows.Forms;

using AVGreader.UI;
using AVGreader.Service;

namespace AVGreader
{
//     static class Program
//     {
//         /// <summary>
//         /// 应用程序的主入口点。
//         /// </summary>
//         [STAThread]
//         static void Main()
//         {
//             Application.EnableVisualStyles();
//             Application.SetCompatibleTextRenderingDefault(false);
//             Application.Run(new FormMain());
//         }
//     }

    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (FormNew frm = new FormNew())
            {
                EngineSrv.parent = frm;
                if (!EngineSrv.Initialize())
                    return;

                frm.Show();
                frm.Activate();

                while (frm.Created)
                {
                    EngineSrv.Run();
                }
            }
        }
    }
}