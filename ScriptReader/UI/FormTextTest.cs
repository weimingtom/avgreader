using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ScriptReader.Service;
using ScriptReader.Domain;

namespace ScriptReader.UI
{
    public partial class FormTextTest : Form
    {
        public FormTextTest()
        {
            InitializeComponent();
        }

        private void FormTextTest_Shown(object sender, EventArgs e)
        {
            //ActorFaceSceneTest();
            StoryStringListTest();
        }

        private void ActorFaceSceneTest ()
        {
            AvgsReader avgsReader = new AvgsReader();
            List<Scene> ls = new List<Scene>();
            ls = avgsReader.GetAllScene();
            if (ls == null)
                richTextBox1.Text += ("未得到场景对象list，可能文件头不匹配！");
            else
            {
                richTextBox1.Text = "[SCENE]\n";
                foreach (Scene sce in ls)
                {
                    richTextBox1.Text += (sce.ID + " ; " + sce.Name + " ; " + sce.Path + "\n");
                }
            }

            List<Actor> la = new List<Actor>();
            la = avgsReader.GetAllActor();
            if (ls == null)
                richTextBox1.Text += ("未得到人物或者表情对象list，可能文件头不匹配！");
            else
            {
                richTextBox1.Text += "[ACTOR]\n";
                foreach (Actor act in la)
                {
                    richTextBox1.Text += (act.ID + " ; " + act.Name + " ; " + act.Path + "\n");
                    foreach (Face fc in act.FaceList)
                    {
                        richTextBox1.Text += (fc.ID + " ; " + fc.Name + "\n");
                    }
                }
            }
        }

        private void StoryStringListTest()
        {
            StoryReader storyReader = new StoryReader();
            Story story = new Story();
            story = storyReader.GetWholeStory();
            foreach (string str in story.text)
            {
                richTextBox1.Text += (str + "\n");
            }
            
            
        }

    }
}