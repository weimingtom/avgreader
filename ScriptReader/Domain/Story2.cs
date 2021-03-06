using System;
using System.Collections.Generic;
using System.Text;
using ScriptReader.Domain;

namespace ScriptReader.Domain
{
    public class Story2
    {
        private List<Line> _content = new List<Line>();
        /// <summary>
        /// 全部脚本信息
        /// </summary>
        public List<Line> content
        {
            get { return _content; }
            set { _content = value; }
        }

        private long _LineNumber = new long();
        /// <summary>
        /// 脚本总行数
        /// </summary>
        public long LineNumber
        {
            get { return _LineNumber; }
            set { _LineNumber = value; }
        }

        public string GetTextByIndex (long index)
        {
            foreach (Line l in content)
            {
                if (l.index == index)
                    return l.text;
            }
            return null;
        }
    }
}
