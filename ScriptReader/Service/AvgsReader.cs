using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ScriptReader.Domain;

namespace ScriptReader.Service
{
    public class AvgsReader
    {
        private string currentDir = AppDomain.CurrentDomain.BaseDirectory;

        public List<Scene> GetAllScene ()
        {
            List<Scene> sceneList = new List<Scene>();
            StreamReader SR = new StreamReader(currentDir + @"DATA\AVGS\scene.avgs", Encoding.GetEncoding("GB2312"));
            string tempStr = SR.ReadLine();
            if (tempStr != @"<File SCENE>")
                return null;
            while((tempStr = SR.ReadLine()) != null)
            {
                Scene scene = new Scene();
                //[场景名称][场景称号]
                string name = "";
                string id = "";
                string path;
                int i;
                for (i = 1; tempStr[i] != ']'; i++)
                    name += tempStr[i];
                for (i+=2; tempStr[i] != ']'; i++)
                    id += tempStr[i];
                path = currentDir + @"DATA\SCENE\" + id + @".jpg";

                scene.Name = name;
                scene.ID = id;
                scene.Path = path;
                sceneList.Add(scene);
            }
            return sceneList;
        }

        private List<Face> GetAllFace (string ActorID)
        {
            List<Face> faceList = new List<Face>();
            string dir = currentDir + @"DATA\ACTOR\" + ActorID + @"\face.avgs";
            StreamReader SR = new StreamReader(dir, Encoding.GetEncoding("GB2312"));
            string tempStr = SR.ReadLine();
            if (tempStr != @"<File FACE "+ActorID+">")
                return null;
            while ((tempStr = SR.ReadLine()) != null)
            {
                Face face = new Face();
                //[表情名称][表情编号]
                string name = "";
                string id = "";
                string path;
                int i;
                for (i = 1; tempStr[i] != ']'; i++)
                    name += tempStr[i];
                for (i += 2; tempStr[i] != ']'; i++)
                    id += tempStr[i];
                path = currentDir + @"DATA\ACTOR\" + ActorID + @"\" + id;

                face.Name = name;
                face.ID = id;
                face.Path = path;
                faceList.Add(face);
            }
            return faceList;
        }

        public List<Actor> GetAllActor ()
        {
            List<Actor> actorList = new List<Actor>();
            StreamReader SR = new StreamReader(currentDir + @"DATA\AVGS\actor.avgs", Encoding.GetEncoding("GB2312"));
            string tempStr = SR.ReadLine();
            if (tempStr != @"<File ACTOR>")
                return null;
            while ((tempStr = SR.ReadLine()) != null)
            {
                Actor actor = new Actor();
                //[人物名字][人物编号]
                string name = "";
                string id = "";
                string path;
                int i;
                for (i = 1; tempStr[i] != ']'; i++)
                    name += tempStr[i];
                for (i += 2; tempStr[i] != ']'; i++)
                    id += tempStr[i];
                path = currentDir + @"DATA\ACTOR\" + id + @"\default.png";

                actor.Name = name;
                actor.ID = id;
                actor.Path = path;
                actor.FaceList = GetAllFace(id);
                actorList.Add(actor);
            }
            return actorList;
        }

        public Scene GetSceneById(string ID)
        {
            List<Scene> SceneList = GetAllScene();
            foreach (Scene sc in SceneList)
            {
                if (sc.ID == ID)
                    return sc;
            }
            return null;
        }

        public Actor GetActorById(string ID)
        {
            List<Actor> ActorList = GetAllActor();
            foreach (Actor ac in ActorList)
            {
                if (ac.ID == ID)
                    return ac;
            }
            return null;
        }
    }
}
