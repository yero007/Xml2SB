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

        public void Write(IStoryboardElement element)
        {
            var header = GetHeader();
            using (var file = new StreamWriter(mFilePath))
            {
                WriteLine(file, string.Empty, header);
                PrintChild(element, file);
            }
        }

        public void PrintChild(IStoryboardElement element, StreamWriter file)
        {
            WriteLine(file, GetIndent(element.IndentLevel), element.GetHeader());
            if (element.GetChildren() == null)
            {
                WriteLine(file, GetIndent(element.IndentLevel), element.GetFooter());

                return;
            }

            foreach (var elementItem in element.GetChildren())
            {
                PrintChild(elementItem, file);
            }

            WriteLine(file, GetIndent(element.IndentLevel), element.GetFooter());
        }

        public void WriteLine(StreamWriter file, string indent,  string line)
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                return;
            }
            file.WriteLine($"{indent}{line}");
        }

        public string GetIndent(int indentLevel)
        {
            var text = string.Empty;
            for (var i=0;i<indentLevel; i++)
            {
                text += "\t";
            }

            return text;
        }

        public string GetHeader()
        {
            return "<?xml version=\"1.0\" encoding=\"UTF - 8\"?>";
        }
    }
}
