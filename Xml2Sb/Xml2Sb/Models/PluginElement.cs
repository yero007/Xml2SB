using System;
using System.Collections.Generic;

namespace Xml2Sb.Models
{
    public class PluginElement : IStoryboardElement
    {
         //<plugIn identifier = "com.apple.InterfaceBuilder.IBCocoaTouchPlugin" version="16087"/>
        public PluginElement(int indent)
        {
            IndentLevel = indent;
        }

        public int IndentLevel { get; set; }

        public List<IStoryboardElement> GetChildren()
        {
            return null;
        }

        public string GetFooter()
        {
            return string.Empty;
        }

        public string GetHeader()
        {
            return $"<plugIn {GetHeaderTags(GetHeaderTagsList())}/>";
        }

        public List<HeaderTag> GetHeaderTagsList()
        {
            var tagList = new List<HeaderTag>
            {
                new HeaderTag("identifier", "com.apple.InterfaceBuilder.IBCocoaTouchPlugin"),
                new HeaderTag("version", "16087")
            };
            return tagList;
        }

        public string GetHeaderTags(List<HeaderTag> tags)
        {
            var text = string.Join(" ", tags);
            return text;
        }
    }
}
