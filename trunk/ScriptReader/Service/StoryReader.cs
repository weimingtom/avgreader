using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ScriptReader.Domain;

namespace ScriptReader.Service
{
    public class StoryReader
    {
        private string currentDir = AppDomain.CurrentDomain.BaseDirectory;

        public Story GetWholeStory()
        {
            Story story = new Story();
            StreamReader SR = new StreamReader(currentDir + @"DATA\AVGS\story.avgs", Encoding.GetEncoding("GB2312"));
            string tempStr;
            while ((tempStr = SR.ReadLine()) != null)
            {
                story.text.Add(tempStr);
            }
            return story;
        }

    }
}
