using System;
using System.Collections.Generic;

namespace Xml2Sb.Models
{
    public class CapabilityElement : IStoryboardElement
    {
        //        <capability name="documents saved in the Xcode 8 format" minToolsVersion="8.0"/>

        public CapabilityElement(int indent)
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
            return "/>";
        }

        public string GetHeader()
        {
            return $"<capability {GetHeaderTags(GetHeaderTagsList())}";
        }

        public List<HeaderTag> GetHeaderTagsList()
        {
            var tagList = new List<HeaderTag>
            {
                new HeaderTag("name", "documents saved in the Xcode 8 format"),
                new HeaderTag("minToolsVersion", "8.0")
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
