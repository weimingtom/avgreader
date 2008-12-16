using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using AVGreader.Domain;
using AVGreader.Service.Persistent;

namespace AVGreader.Service
{
    class ScriptSrv
    {
        #region 声明

        private static AvgsReader avgsReader = new AvgsReader();
        private static StoryReader storyReader = new StoryReader();
        private static Story _story = storyReader.GetWholeStory();

        #endregion

        #region 属性

        public static Story story
        {
            get { return _story; }
            set { _story = value; }
        }

        #endregion


        #region 脚本处理

        /// <summary>
        /// 语句分发主函数
        /// </summary>
        /// <param name="cmd">语句</param>
        public static void QueryScriptCommand(string cmd)
        {
            if (cmd == "<PAGE>")
            {
                HandlePage();
            }
            else if (cmd == "<BR>")
            {
                HandleBR();
            }
            else if (cmd == "<END>")
            {
                HandleEnd();
            }
            else if (cmd[0] == '<' && cmd[cmd.Length - 1] == '>')
            {
                int i;
                string detailCMD = "";
                string id = "";
                for (i = 1; cmd[i] != ' '; i++)
                    detailCMD += cmd[i];
                for (i++; cmd[i] != '>'; i++)
                    id += cmd[i];

                switch (detailCMD)
                {
                    case "SCENE": ShowBackground(id); break;
                    case "ACTOR": ShowActor(id); break;
                    case "FACE": ShowFace(id); break;
                }
            }
            else if (cmd[0] != '<')
            {
                ShowText(cmd);
            }
        }

        /// <summary>
        /// 处理语言
        /// </summary>
        /// <param name="words">对话内容</param>
        private static void ShowText(string words)
        {
            //TextFrameSrv.sentense += words;
            foreach (char ch in words)
            {
                TextFrameSrv.sentense += ch;
                EngineSrv.Render();
            }
        }

        /// <summary>
        /// 处理背景
        /// </summary>
        /// <param name="id">背景ID</param>
        private static void ShowBackground(string id)
        {
            Scene scene = avgsReader.GetSceneById(id);
            BackgroundSrv.Path = scene.Path;
        }

        /// <summary>
        /// 处理角色
        /// </summary>
        /// <param name="id">角色ID</param>
        private static void ShowActor(string id)
        {
            Actor actor = avgsReader.GetActorById(id);
            ActorSrv.Path = actor.Path;
        }

        /// <summary>
        /// 处理表情
        /// </summary>
        /// <param name="id">表情ID</param>
        private static void ShowFace(string id)
        {
        }

        /// <summary>
        /// 处理换页
        /// </summary>
        private static void HandlePage()
        {
            //按键处理统统放在这里做分支！！！
            //1、继续
            //KeyboardSrv.PressAnyKey();
            //2、查看对白
            //3、去掉文本框
            //4、存档、读档

            TextFrameSrv.sentense = "";
        }

        /// <summary>
        /// 处理换行
        /// </summary>
        private static void HandleBR()
        {
            TextFrameSrv.sentense += "\n";
        }

        /// <summary>
        /// 处理结束
        /// </summary>
        private static void HandleEnd()
        {
            EngineSrv.NowRunState = MyEnum.RunStatement.END;
            MessageBox.Show("执行完毕！");
        }

        #endregion
    }
}
