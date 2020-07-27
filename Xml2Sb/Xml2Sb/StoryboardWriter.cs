using System;
using System.IO;

namespace Xml2Sb
{
    public class StoryboardWriter
    {
        private string mFilePath;

        public StoryboardWriter(string filePath = @"../../file.storyboard")
        {
            mFilePath = filePath;
        }

        public void Write(System.Collections.Generic.List<Models.IStoryboardElement> elements)
        {
            var header = GetHeader();
            using (var file = new StreamWriter(mFilePath))
            {
                file.WriteLine(header);
                foreach (var element in elements)
                {
                    file.WriteLine(element.GetHeader());
                }
            }
        }

        public string GetHeader()
        {
            return "<?xml version=\"1.0\" encoding=\"UTF - 8\"?>";
        }
    }
}
