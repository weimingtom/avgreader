using System;
using System.Collections.Generic;
using System.Text;

namespace AVGreader.Domain
{
    public class Story
    {
        private List<string> _text = new List<string>();
        public List<string> text
        {
            get { return _text; }
            set { _text = value; }
        }
    }
}
