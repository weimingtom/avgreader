using System;
using System.Collections.Generic;
using System.Text;

namespace ScriptReader.Domain
{
    public class Line
    {
        private long _index = new long();
        /// <summary>
        /// 索引号（行号）
        /// </summary>
        public long index
        {
            get { return _index; }
            set { _index = value; }
        }

        private string _text = null;
        /// <summary>
        /// 单行内容
        /// </summary>
        public string text
        {
            get { return _text; }
            set { _text = value; }
        }
    }
}
