using System;
using System.Collections.Generic;
using System.IO;
using Xml2Sb.Models;

namespace Xml2Sb
{
    public class StoryboardWriter
    {
        private string mFilePath;

        public StoryboardWriter(string filePath = @"../../file.storyboard")
        {
            mFilePath = filePath;
        }

        public void Write(List<IStoryboardElement> elements)
        {
            var header = GetHeader();
            using (var file = new StreamWriter(mFilePath))
            {
                file.WriteLine(header);
                foreach (var element in elements)
                {
                    file.WriteLine(element.GetHeader());
                    
                   
                    file.WriteLine(element.GetFooter());
                }
            }
        }

        public void PrintChild(IStoryboardElement element, StreamWriter file)
        {
            //todo:finish this
            file.WriteLine(element.GetHeader());


            file.WriteLine(element.GetFooter());
            if (element.GetChildren() == null)
            {
                file.WriteLine(element.GetFooter());

                return;
            }
            
        }

        public string GetHeader()
        {
            return "<?xml version=\"1.0\" encoding=\"UTF - 8\"?>";
        }
    }
}
