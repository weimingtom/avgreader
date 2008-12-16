using System;
using System.Collections.Generic;
using System.Text;
using ScriptReader.Domain;

namespace ScriptReader.Domain
{
    public class Actor
    {
        private string _ID;
        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }        
        
        private string _Path;
        public string Path
        {
            get { return _Path; }
            set { _Path = value; }
        }

        private List<Face> _FaceList = new List<Face>();
        public List<Face> FaceList
        {
            get { return _FaceList; }
            set { _FaceList = value; }
        }
    }
}
